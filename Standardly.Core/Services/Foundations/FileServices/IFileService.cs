﻿namespace Standardly.Core.Services.Foundations.FileServices
{
    public interface IFileService
    {
        bool CheckIfFileExists(string path);
        void WriteToFile(string path, string content);
        string ReadFromFile(string path);
        void DeleteFile(string path);
        string[] RetrieveListOfFiles(string path, string searchPattern = "*");
        bool CheckIfDirectoryExists(string path);
        void CreateDirectory(string path);
        void DeleteDirectory(string path, bool recursive = false);
    }
}
