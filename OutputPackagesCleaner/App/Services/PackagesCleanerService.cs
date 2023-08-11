using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace ClearSolutions.Services
{
    public class PackagesCleanerService
    {
        private readonly ILogger<PackagesCleanerService> _logger;
        private static string BinFileName = "bin";
        private static string ObjFileName = "obj";
        
        public PackagesCleanerService()
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder
                    .AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning);
            });
            _logger = loggerFactory.CreateLogger<PackagesCleanerService>();
        }

        public void ClearOutputFolders(string path) 
        { 
            if (!Path.Exists(path))
            {
                return;
            }

            foreach (string projectPath in FindProjectsPath(path))
            {
                DeleteOutputFolders(projectPath);
            }
        }

        private void DeleteOutputFolders(string path)
        {
            try

            {
                var binFilePath = Path.Combine(path, BinFileName);
                var objFilePath = Path.Combine(path, ObjFileName);
                Directory.Delete(binFilePath, true);
                Directory.Delete(objFilePath, true);
            }
            catch (DirectoryNotFoundException ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        private List<string> FindProjectsPath(string path)
        {
            List<string> paths = new List<string>();
            foreach (string acPath in Directory.GetDirectories(path))
            {
                if (Directory.GetFiles(acPath, "*.csproj").Any())
                {
                    paths.Add(acPath);
                }
            }
            return paths;
        }
    }
}
