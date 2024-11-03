using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper
{
    public class Backuper
    {
        public Backuper() { }
        public void Backup() { 
        var model=AppTelDataModelFileMngr.ReadAllAppSettings();
            if (model.SaveOnStartup)
            {
                var folders = model.FoldersToBackup;
                if (model.BackupsPath == null && !Directory.Exists(model.BackupsPath)) { return; }

                foreach (var folder in folders)
                {
                    if (folder != null && Directory.Exists(folder))
                    {

                        FolderFunctionHelper.CopyFolderToBackup(folder, model.BackupsPath, !model.SaveSeperate);

                    }
                }
                model.LastBackup = DateTime.Now;
                AppTelDataModelFileMngr.SaveNewAppSettings(model);
            }
            else {
               
             
                if (model.LastBackup == new DateTime()) { Console.WriteLine("backup now");
                    CopyFolders(model);
                    model.LastBackup = DateTime.Now;
                    AppTelDataModelFileMngr.SaveNewAppSettings(model);
                    return;
                }
                var nextBackup = model.LastBackup;
                nextBackup= nextBackup.AddDays(model.numOfDays);
                nextBackup= nextBackup.AddHours(model.numOfHours);
                nextBackup=nextBackup.AddMonths(model.numOfMonths);

                var result=DateTime.Compare(nextBackup, DateTime.Now);

                if (result >= 0) {
                CopyFolders(model);
                }

            }



        
        
        }

        public void BackupInterval(AppTelDataModel model) { }

        private void CopyFolders(AppTelDataModel model) {
            var folders = model.FoldersToBackup;
            if (model.BackupsPath == null && !Directory.Exists(model.BackupsPath)) { return; }

            foreach (var folder in folders)
            {
                if (folder != null && Directory.Exists(folder))
                {

                    FolderFunctionHelper.CopyFolderToBackup(folder, model.BackupsPath, !model.SaveSeperate);

                }
            }



        }


    }
}
