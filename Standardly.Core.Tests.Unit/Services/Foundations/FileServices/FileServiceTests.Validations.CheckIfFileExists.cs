﻿using System;
using FluentAssertions;
using Moq;
using Standardly.Core.Models.FileServices.Exceptions;
using Standardly.Core.Services.Foundations.FileServices;
using Xunit;

namespace Standardly.Core.Tests.Unit.Services.Foundations.FileServices
{
    public partial class FileServiceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ShouldThrowValidationExceptionOnCheckIfFileExistsIfPathIsInvalid(string invalidPath)
        {
            // given
            var invalidFilePathException =
                new InvalidFilePathException();

            var expectedFileValidationException =
                new FileServiceValidationException(invalidFilePathException);

            // when
            Action checkIfFileExistsAction = () =>
                this.fileService.CheckIfFileExists(invalidPath);

            FileServiceValidationException actualException =
                Assert.Throws<FileServiceValidationException>(checkIfFileExistsAction);

            // then
            actualException.Should().BeEquivalentTo(expectedFileValidationException);

            this.fileSystemBrokerMock.Verify(broker =>
                broker.CheckIfFileExists(
                    It.IsAny<string>()),
                        Times.Never);

            this.fileSystemBrokerMock.VerifyNoOtherCalls();
        }
    }
}