using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper
{
    internal class AppTelDataModel
    {
        public List<string> FoldersToBackup { get; set; }

        public DateTime LastBackup { get; set; }

        public string BackupsPath {  get; set; }




    }
}
