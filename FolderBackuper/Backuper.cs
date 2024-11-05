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

        public bool StopBackuper { get; set; } = false;
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
                if (model.numOfHours > 0 || model.numOfDays > 0 || model.numOfMonths > 0|| model.numOfMinutes>0)
                {
                    Task.Run(() => BackupInterval(model));
                }

            }



        
        
        }

        public void PerformImmediateBackup(AppTelDataModel model)
        {
            var folders = model.FoldersToBackup;
            if (string.IsNullOrWhiteSpace(model.BackupsPath) || !Directory.Exists(model.BackupsPath))
            {
                Console.WriteLine("Invalid backup path.");
                return;
            }

            foreach (var folder in folders)
            {
                if (!string.IsNullOrWhiteSpace(folder) && Directory.Exists(folder))
                {
                    FolderFunctionHelper.CopyFolderToBackup(folder, model.BackupsPath, !model.SaveSeperate);
                }
            }
            model.LastBackup = DateTime.Now;
            AppTelDataModelFileMngr.SaveNewAppSettings(model);
        }

        public async Task BackupInterval(AppTelDataModel model)
        {
            while (!StopBackuper)
            {
                DateTime nextBackup = model.LastBackup
                    .AddMinutes(model.numOfMinutes)
                    .AddDays(model.numOfDays)
                    .AddHours(model.numOfHours)
                    .AddMonths(model.numOfMonths);

                // Check if the next backup time is due
                if (DateTime.Now >= nextBackup)
                {
                    Console.WriteLine("Performing scheduled backup...");
                    CopyFolders(model);
                    model.LastBackup = DateTime.Now; // Update last backup time
                    AppTelDataModelFileMngr.SaveNewAppSettings(model);
                }

                // Delay for a while before checking again
                // Adjust this delay time to your needs
                await Task.Delay(TimeSpan.FromMinutes(1)); // Check every minute
            }
        }
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
