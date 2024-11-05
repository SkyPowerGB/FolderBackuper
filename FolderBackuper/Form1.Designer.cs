﻿namespace FolderBackuper
{
    partial class FolderBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbFoldersList = new System.Windows.Forms.ListBox();
            this.tbBackupsPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolderPath = new System.Windows.Forms.Button();
            this.btnAddFolderPath = new System.Windows.Forms.Button();
            this.btnSelectBackupPath = new System.Windows.Forms.Button();
            this.btnRemoveFolderPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.btnKopiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFoldersList
            // 
            this.lbFoldersList.FormattingEnabled = true;
            this.lbFoldersList.ItemHeight = 16;
            this.lbFoldersList.Location = new System.Drawing.Point(20, 114);
            this.lbFoldersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbFoldersList.Name = "lbFoldersList";
            this.lbFoldersList.Size = new System.Drawing.Size(368, 404);
            this.lbFoldersList.TabIndex = 0;
            // 
            // tbBackupsPath
            // 
            this.tbBackupsPath.Location = new System.Drawing.Point(20, 646);
            this.tbBackupsPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBackupsPath.Name = "tbBackupsPath";
            this.tbBackupsPath.Size = new System.Drawing.Size(273, 22);
            this.tbBackupsPath.TabIndex = 2;
            // 
            // btnSelectFolderPath
            // 
            this.btnSelectFolderPath.Location = new System.Drawing.Point(303, 53);
            this.btnSelectFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFolderPath.Name = "btnSelectFolderPath";
            this.btnSelectFolderPath.Size = new System.Drawing.Size(87, 28);
            this.btnSelectFolderPath.TabIndex = 5;
            this.btnSelectFolderPath.Text = "Odaberi";
            this.btnSelectFolderPath.UseVisualStyleBackColor = true;
            this.btnSelectFolderPath.Click += new System.EventHandler(this.btnSelectFolderPath_Click);
            // 
            // btnAddFolderPath
            // 
            this.btnAddFolderPath.Location = new System.Drawing.Point(397, 53);
            this.btnAddFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFolderPath.Name = "btnAddFolderPath";
            this.btnAddFolderPath.Size = new System.Drawing.Size(100, 28);
            this.btnAddFolderPath.TabIndex = 6;
            this.btnAddFolderPath.Text = "Dodaj";
            this.btnAddFolderPath.UseVisualStyleBackColor = true;
            this.btnAddFolderPath.Click += new System.EventHandler(this.btnAddFolderPath_Click);
            // 
            // btnSelectBackupPath
            // 
            this.btnSelectBackupPath.Location = new System.Drawing.Point(303, 646);
            this.btnSelectBackupPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectBackupPath.Name = "btnSelectBackupPath";
            this.btnSelectBackupPath.Size = new System.Drawing.Size(87, 25);
            this.btnSelectBackupPath.TabIndex = 7;
            this.btnSelectBackupPath.Text = "odaberi";
            this.btnSelectBackupPath.UseVisualStyleBackColor = true;
            this.btnSelectBackupPath.Click += new System.EventHandler(this.btnSelectBackupPath_Click);
            // 
            // btnRemoveFolderPath
            // 
            this.btnRemoveFolderPath.Location = new System.Drawing.Point(397, 114);
            this.btnRemoveFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFolderPath.Name = "btnRemoveFolderPath";
            this.btnRemoveFolderPath.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveFolderPath.TabIndex = 8;
            this.btnRemoveFolderPath.Text = "Makni";
            this.btnRemoveFolderPath.UseVisualStyleBackColor = true;
            this.btnRemoveFolderPath.Click += new System.EventHandler(this.btnRemoveFolderPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Popis datoteka ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 626);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lokacije za kopije";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(397, 7);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "postavke";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Putanja do datoteke";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(20, 53);
            this.tbFolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.Size = new System.Drawing.Size(273, 22);
            this.tbFolderPath.TabIndex = 4;
            // 
            // btnKopiraj
            // 
            this.btnKopiraj.Location = new System.Drawing.Point(397, 163);
            this.btnKopiraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnKopiraj.Name = "btnKopiraj";
            this.btnKopiraj.Size = new System.Drawing.Size(100, 28);
            this.btnKopiraj.TabIndex = 13;
            this.btnKopiraj.Text = "Kopiraj";
            this.btnKopiraj.UseVisualStyleBackColor = true;
            this.btnKopiraj.Click += new System.EventHandler(this.btnKopiraj_Click);
            // 
            // FolderBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 686);
            this.Controls.Add(this.btnKopiraj);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveFolderPath);
            this.Controls.Add(this.btnSelectBackupPath);
            this.Controls.Add(this.btnAddFolderPath);
            this.Controls.Add(this.btnSelectFolderPath);
            this.Controls.Add(this.tbFolderPath);
            this.Controls.Add(this.tbBackupsPath);
            this.Controls.Add(this.lbFoldersList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FolderBackup";
            this.Text = "DataBackup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFoldersList;
        private System.Windows.Forms.TextBox tbBackupsPath;
        private System.Windows.Forms.Button btnSelectFolderPath;
        private System.Windows.Forms.Button btnAddFolderPath;
        private System.Windows.Forms.Button btnSelectBackupPath;
        private System.Windows.Forms.Button btnRemoveFolderPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Button btnKopiraj;
    }
}

