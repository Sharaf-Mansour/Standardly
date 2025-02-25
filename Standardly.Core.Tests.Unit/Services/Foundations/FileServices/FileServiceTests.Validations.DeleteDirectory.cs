﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using FluentAssertions;
using Moq;
using Standardly.Core.Models.Foundations.Files.Exceptions;
using Xunit;

namespace Standardly.Core.Tests.Unit.Services.Foundations.FileServices
{
    public partial class FileServiceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ShouldThrowValidationExceptionOnDeleteDirectoryIfPathIsInvalid(string invalidPath)
        {
            // given
            var invalidFilePathException =
                new InvalidFilePathException(invalidPath);

            var expectedFileServiceValidationException =
                new FileValidationException(invalidFilePathException);

            // when
            Action checkIfDirectoryExistsAction = () =>
                this.fileService.DeleteDirectory(invalidPath);

            FileValidationException actualFileServiceValidationException =
                Assert.Throws<FileValidationException>(checkIfDirectoryExistsAction);

            // then
            actualFileServiceValidationException.Should().BeEquivalentTo(expectedFileServiceValidationException);

            this.fileSystemBrokerMock.Verify(broker =>
                broker.DeleteDirectory(
                    It.IsAny<string>(), It.IsAny<bool>()),
                        Times.Never);

            this.fileSystemBrokerMock.VerifyNoOtherCalls();
        }
    }
}
