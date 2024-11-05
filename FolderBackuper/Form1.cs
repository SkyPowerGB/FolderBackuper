using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace FolderBackuper
{
    public partial class FolderBackup : Form
    {


        
        public FolderBackup()
        {
            InitializeComponent();
            AppTelDataModel md=AppTelDataModelFileMngr.ReadAllAppSettings();
            this.StartPosition = FormStartPosition.CenterScreen;
            if (md == null) { md = new AppTelDataModel(); }
            tbBackupsPath.Text = md.BackupsPath;
            if (md.FoldersToBackup != null)
            {
                foreach (string fp in md.FoldersToBackup)
                {
                    lbFoldersList.Items.Add(fp);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(AppTelDataModelFileMngr.ReadAllAppSettings());
            form.ShowDialog();
        }

        private void btnSelectFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
           var res= dialog.ShowDialog();
            if (res == DialogResult.OK) {
              tbFolderPath.Text=dialog.SelectedPath;
            }
        }

        private void btnSelectBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbBackupsPath.Text = dialog.SelectedPath;

                AppTelDataModel model = AppTelDataModelFileMngr.ReadAllAppSettings();
                if (model == null) { model = new AppTelDataModel(); }
                model.BackupsPath = tbBackupsPath.Text;
                AppTelDataModelFileMngr.SaveNewAppSettings(model);

            }

        }

        private void btnAddFolderPath_Click(object sender, EventArgs e)
        {
            
            AppTelDataModel model = AppTelDataModelFileMngr.ReadAllAppSettings();
            if (model.FoldersToBackup == null) { model.FoldersToBackup = new List<string>(); }
            model.FoldersToBackup.Add(tbFolderPath.Text);

            Console.WriteLine(FolderFunctionHelper.GetBackupsFolderPath(true, tbFolderPath.Text));

            AppTelDataModelFileMngr.SaveNewAppSettings(model);
            lbFoldersList.DataSource= model.FoldersToBackup;
            tbFolderPath.Text = "";
        }

        private void btnRemoveFolderPath_Click(object sender, EventArgs e)
        {
            if (lbFoldersList.SelectedItem != null)
            {
                
                AppTelDataModel model = AppTelDataModelFileMngr.ReadAllAppSettings();
                model.FoldersToBackup.Remove(lbFoldersList.SelectedItem.ToString());
                AppTelDataModelFileMngr.SaveNewAppSettings(model);
                lbFoldersList.Items.Remove(lbFoldersList.SelectedItem.ToString());
            }
        }

        private void btnKopiraj_Click(object sender, EventArgs e)
        {
            Backuper bc=new Backuper();
            bc.PerformImmediateBackup(AppTelDataModelFileMngr.ReadAllAppSettings());
        }
    }
}
