﻿using Standardly.Core.Brokers.FileSystems;

namespace Standardly.Core.Services.Foundations.FileServices
{
    public partial class FileService : IFileService
    {
        private readonly IFileSystemBroker fileSystemBroker;

        public FileService(IFileSystemBroker fileSystemBroker)
        {
            this.fileSystemBroker = fileSystemBroker;
        }

        public bool CheckIfFileExists(string path) =>
            TryCatch(() =>
            {
                ValidatePath(path);

                return this.fileSystemBroker.CheckIfFileExists(path);
            });
    }
}