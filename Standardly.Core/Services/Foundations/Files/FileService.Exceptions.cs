﻿// ---------------------------------------------------------------
// Copyright (c) Christo du Toit. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;
using System.IO;
using System.Runtime.Serialization;
using Standardly.Core.Models.Foundations.Files.Exceptions;
using Xeptions;

namespace Standardly.Core.Services.Foundations.Files
{
    public partial class FileService
    {
        public delegate bool ReturningBooleanFunction();
        public delegate void ReturningNothingFunction();
        public delegate string ReturningStringFunction();
        public delegate string[] ReturningStringsFunction();

        public bool TryCatch(ReturningBooleanFunction returningBooleanFunction)
        {
            try
            {
                return returningBooleanFunction();
            }
            catch (InvalidFilePathException invalidFilePathException)
            {
                throw CreateAndLogValidationException(invalidFilePathException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentNullException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentOutOfRangeException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentException argumentException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (SerializationException serializationException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(serializationException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (OutOfMemoryException outOfMemoryException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(outOfMemoryException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (IOException ioException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(ioException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(unauthorizedAccessException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (Exception exception)
            {
                var failedFileServiceException =
                    new FailedFileServiceException(exception);

                throw CreateAndLogServiceException(failedFileServiceException);
            }
        }

        public void TryCatch(ReturningNothingFunction returningNothingFunction)
        {
            try
            {
                returningNothingFunction();
            }
            catch (InvalidFilePathException invalidFilePathException)
            {
                throw CreateAndLogValidationException(invalidFilePathException);
            }
            catch (InvalidFileContentException invalidFileContentException)
            {
                throw CreateAndLogValidationException(invalidFileContentException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentNullException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentOutOfRangeException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentException argumentException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (SerializationException serializationException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(serializationException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (OutOfMemoryException outOfMemoryException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(outOfMemoryException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (IOException ioException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(ioException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(unauthorizedAccessException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (Exception exception)
            {
                var failedFileServiceException =
                    new FailedFileServiceException(exception);

                throw CreateAndLogServiceException(failedFileServiceException);
            }
        }

        public string TryCatch(ReturningStringFunction returningStringFunction)
        {
            try
            {
                return returningStringFunction();
            }
            catch (InvalidFilePathException invalidFilePathException)
            {
                throw CreateAndLogValidationException(invalidFilePathException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentNullException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentOutOfRangeException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentException argumentException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (SerializationException serializationException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(serializationException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (OutOfMemoryException outOfMemoryException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(outOfMemoryException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (IOException ioException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(ioException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(unauthorizedAccessException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (Exception exception)
            {
                var failedFileServiceException =
                    new FailedFileServiceException(exception);

                throw CreateAndLogServiceException(failedFileServiceException);
            }
        }

        public string[] TryCatch(ReturningStringsFunction returningStringsFunction)
        {
            try
            {
                return returningStringsFunction();
            }
            catch (InvalidFilePathException invalidFilePathException)
            {
                throw CreateAndLogValidationException(invalidFilePathException);
            }
            catch (InvalidFileSearchPatternException invalidFileSearchPatternException)
            {
                throw CreateAndLogValidationException(invalidFileSearchPatternException);
            }
            catch (ArgumentNullException argumentNullException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentNullException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRangeException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentOutOfRangeException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (ArgumentException argumentException)
            {
                var invalidFileDependencyException =
                    new InvalidFileServiceDependencyException(argumentException);

                throw CreateAndLogDependencyValidationException(invalidFileDependencyException);
            }
            catch (SerializationException serializationException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(serializationException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (OutOfMemoryException outOfMemoryException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(outOfMemoryException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (IOException ioException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(ioException);

                throw CreateAndLogDependencyException(failedFileDependencyException);
            }
            catch (UnauthorizedAccessException unauthorizedAccessException)
            {
                var failedFileDependencyException =
                    new FailedFileDependencyException(unauthorizedAccessException);

                throw CreateAndLogCriticalDependencyException(failedFileDependencyException);
            }
            catch (Exception exception)
            {
                var failedFileServiceException =
                    new FailedFileServiceException(exception);

                throw CreateAndLogServiceException(failedFileServiceException);
            }
        }

        private FileValidationException CreateAndLogValidationException(Xeption exception)
        {
            var fileValidationException =
                new FileValidationException(exception);

            return fileValidationException;
        }

        private FileDependencyValidationException CreateAndLogDependencyValidationException(Xeption exception)
        {
            var fileServiceDependencyValidationException =
                new FileDependencyValidationException(exception);

            return fileServiceDependencyValidationException;
        }

        private FileDependencyException CreateAndLogDependencyException(Xeption exception)
        {
            var fileServiceDependencyException = new FileDependencyException(exception);

            return fileServiceDependencyException;
        }

        private FileDependencyException CreateAndLogCriticalDependencyException(
            Xeption exception)
        {
            var fileServiceDependencyException = new FileDependencyException(exception);

            return fileServiceDependencyException;
        }

        private FileServiceException CreateAndLogServiceException(
            Xeption exception)
        {
            var fileServiceException = new FileServiceException(exception);

            return fileServiceException;
        }
    }
}
