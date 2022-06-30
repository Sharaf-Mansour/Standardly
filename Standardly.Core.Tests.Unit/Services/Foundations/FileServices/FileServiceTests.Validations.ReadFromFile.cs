﻿using System;
using FluentAssertions;
using Moq;
using Standardly.Core.Models.FileServices.Exceptions;
using Xunit;

namespace Standardly.Core.Tests.Unit.Services.Foundations.FileServices
{
    public partial class FileServiceTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("   ")]
        public void ShouldThrowValidationExceptionOnReadFromFileIfPathIsInvalid(
            string invalidPath)
        {
            // given
            var invalidFilePathException =
                new InvalidFilePathException();

            var expectedFileServiceValidationException =
                new FileServiceValidationException(
                    invalidFilePathException);

            // when
            Action checkIfDirectoryExistsAction = () =>
                this.fileService.ReadFromFile(invalidPath);

            FileServiceValidationException actualFileServiceValidationException =
                Assert.Throws<FileServiceValidationException>(checkIfDirectoryExistsAction);

            // then
            actualFileServiceValidationException.Should().BeEquivalentTo(expectedFileServiceValidationException);

            this.fileSystemBrokerMock.Verify(broker =>
                broker.ReadFile(
                    It.IsAny<string>()),
                        Times.Never);

            this.fileSystemBrokerMock.VerifyNoOtherCalls();
        }
    }
}