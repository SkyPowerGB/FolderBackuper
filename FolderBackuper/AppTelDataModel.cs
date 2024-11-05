using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderBackuper
{
    public class AppTelDataModel
    {
        public List<string> FoldersToBackup { get; set; }

        public DateTime LastBackup { get; set; }

        public string BackupsPath {  get; set; }

        public bool SaveSeperate { get; set; }

        public bool SaveOnStartup { get; set; } = true;

        public int numOfDays {  get; set; }
        public int numOfHours { get; set; }
        public int numOfMonths { get; set; } = 1;

        public int numOfMinutes { get; set; }


    }
}
