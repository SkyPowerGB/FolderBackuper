using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBackuper
{
    public  class AppTelDataModelFileMngr
    {
        private static string appDataFilename = "settings.json";
        private static string projectPath=AppDomain.CurrentDomain.BaseDirectory;
        private static string dirName = "data";
        private static string appDataPath=Path.Combine(projectPath, dirName);
        private static string appDataFilePath=Path.Combine(appDataPath, appDataFilename);


        private NotifyIcon trayIcon;
        private ContextMenuStrip trayMenu;

        public static void SaveNewAppSettings(AppTelDataModel model) {
            if (!Directory.Exists(appDataPath)) { Directory.CreateDirectory(appDataPath); }
         

            String json = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(appDataFilePath,json);
        }

        public static AppTelDataModel ReadAllAppSettings() {
            if (!Directory.Exists(appDataPath)) { Directory.CreateDirectory(appDataPath); }
            if (!File.Exists(appDataFilePath)) { return new AppTelDataModel() ; }


            string json = File.ReadAllText(appDataFilePath);
            AppTelDataModel model=JsonConvert.DeserializeObject<AppTelDataModel>(json);
            if (model == null) { return new AppTelDataModel(); }
            return model;
        }
        

       

    }
}

