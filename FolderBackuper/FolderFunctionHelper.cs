using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper
{
    internal class FolderFunctionHelper
    {
        private static string backupsFolder = "Backup";
        private static string bakupsSingle = "_S";
        

        private static void CopyFolder(string folderPath, string futurePath)
        {
            
            var subdirs = Directory.GetDirectories(folderPath);
            var files = Directory.GetFiles(folderPath);

       
            if (!Directory.Exists(futurePath))
            {
                Directory.CreateDirectory(futurePath);
            }

         
            foreach (var folder in subdirs)
            {
             
                var newDestination = Path.Combine(futurePath, Path.GetFileName(folder));
                CopyFolder(folder, newDestination);
            }

         
            foreach (var file in files)
            {
                var destFile = Path.Combine(futurePath, Path.GetFileName(file));
                File.Copy(file, destFile, overwrite: true);
            }

        }

        public static string GetBackupsFolderName(bool single) {

            if (single)
            {
                return backupsFolder + bakupsSingle;
            }
            else {
                var data = DateTime.Now;
                DateTimeOffset off = data;

                return  backupsFolder+"_" + off.ToUnixTimeMilliseconds().ToString();
            }
        }

        public static string GetBackupsFolderPath(bool single, string targetFolder) {

            return Path.Combine(targetFolder, GetBackupsFolderName(single));
        }
    
        public static void CopyFolderToBackup(string folderToCopy,string backupsFolder,bool single) {
            string folder = GetBackupsFolderPath(single, backupsFolder);
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            CopyFolder(folderToCopy, Path.Combine(folder,Path.GetFileName(folderToCopy)));
        }


    }
}
