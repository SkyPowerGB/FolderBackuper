using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBackuper
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Backuper backuper = new Backuper();
            backuper.Backup();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var folderBackupForm = new FolderBackup();

            if (IsRunningAtStartup())
            {
                folderBackupForm.WindowState = FormWindowState.Minimized;
            }
            Application.Run(folderBackupForm);
            backuper.StopBackuper = true;
        }


        private static bool IsRunningAtStartup()
        {
         
            return Environment.GetCommandLineArgs().Length > 1 &&
                   Environment.GetCommandLineArgs()[1] == "autostart";
        }


        

    }
}
