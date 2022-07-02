﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using Moq;
using Xunit;

namespace Standardly.Core.Tests.Unit.Services.Foundations.FileServices
{
    public partial class FileServiceTests
    {
        [Fact]
        public void ShouldDeleteFile()
        {
            // given
            string randomFilePath = GetRandomString();
            string inputFilePath = randomFilePath;

            // when
            this.fileService.DeleteFile(inputFilePath);

            // then
            this.fileSystemBrokerMock.Verify(broker =>
                broker.DeleteFile(inputFilePath),
                    Times.Once);

            this.fileSystemBrokerMock.VerifyNoOtherCalls();
        }
    }
}
