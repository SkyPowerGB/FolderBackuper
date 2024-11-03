using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderBackuper
{
    public partial class SettingsForm : Form
    {

        public SettingsForm(AppTelDataModel model)
        {
            this.DialogResult = DialogResult.Cancel;
            TelDataModel = model;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            tbD.Text = TelDataModel.numOfDays.ToString();
            tbH.Text = TelDataModel.numOfHours.ToString();
            tbM.Text = TelDataModel.numOfMonths.ToString();
            chckSaveSep.Checked = TelDataModel.SaveSeperate;
            
            if (TelDataModel.SaveOnStartup)
            {
                radioButton2.Checked = false;
                rbStartupSave.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
                rbStartupSave.Checked = false;

            }



        }


        public AppTelDataModel TelDataModel { get; set; }

   
        

        private int getNumber(string num) {
            int number;
            if (!int.TryParse(num,out number)) { return 0; }
       
            return number;
        
        }

        private void btnMp_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbM.Text);
            num++;
            tbM.Text=num.ToString();

        }

        private void btnDp_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbD.Text);
            num++;
            tbD.Text = num.ToString();
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbH.Text);
            num++;
            tbH.Text = num.ToString();
        }

        private void btnMn_Click(object sender, EventArgs e)
        {
            int num = getNumber(tbM.Text);
            num-=1;
            tbM.Text = num.ToString();

        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbD.Text);
            num--;
            tbD.Text = num.ToString();
        }

        private void btnHn_Click(object sender, EventArgs e)
        {
            var num = getNumber(tbH.Text);
            num--;
            tbH.Text = num.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            var model = AppTelDataModelFileMngr.ReadAllAppSettings();

            model.numOfHours=getNumber(tbH.Text);
            model.numOfDays=getNumber(tbD.Text);
            model.numOfMonths=getNumber(tbM.Text);
            model.SaveSeperate=chckSaveSep.Checked;
            model.SaveOnStartup=rbStartupSave.Checked;
     

            AppTelDataModelFileMngr.SaveNewAppSettings(model);

            this.Close();
        }
   
    
    }
}
