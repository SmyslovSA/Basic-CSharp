using System;
using System.Collections.Generic;
using System.IO;
using MailSender;
using NLog;

namespace FileSearcher
{
    public class FileSearch
    {
        private readonly IPath ipath;
        private readonly ILogger logger;
        private readonly Queue<string> filesToSent = new Queue<string>();

        public FileSearch(IPath ipath, ILogger logger)
        {
            this.ipath = ipath;
            this.logger = logger;
        }

        /*[Tests]
         SearchFiles_With_Invalid_Path()
         SearchFiles_With_Valid_Path()
        */
        public bool SearchFiles(string path)
        {
            if (!Directory.Exists(path))
            {
                logger.Error("Directory is not exist");
                return false;
            }
            var directory = new DirectoryInfo(path);
            foreach (var file in directory.GetFiles())
            {
                if (file.FullName.EndsWith(".txt"))
                    filesToSent.Enqueue(file.FullName);
            }
            foreach (var dir in directory.GetDirectories())
                SearchFiles(dir.FullName);

            ipath.GetFiles(filesToSent);
            return true;
        }

        /*[Tests]
          DeleteFiles_With_Null_Reference()
          DeleteFiles_With_Empty_Queue()
          DeleteFiles_With_Valid_Queue() 
        */
        public void DeleteFiles(Queue<string> filesToDelete)
        {
            if (filesToDelete == null)
            {
                logger.Error("There are no files to delete");
                return;
            }
            while (filesToDelete.Count > 0)
                try
                {
                    File.Delete(filesToDelete.Dequeue());
                    logger.Info("File was deleted.");
                }
                catch (Exception ex)
                {
                    logger.Error($"{ex.Message}. File was not deleted.");
                }
        }
    }
}
