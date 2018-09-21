using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcium_RMS.BackupManager
{
    public partial class BackupFrm : Form
    {
        public BackupFrm()
        {
            InitializeComponent();
        }

        private void __SetProgressBar()
        {
            DatabaseBackupManager.__ProgressBar = this.progressBar1;
        }

        private void BackupDBBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog __SaveFileDial = new SaveFileDialog();
            __SaveFileDial.Filter = "RMS Database Backup|*.RMSbak";
            __SaveFileDial.FileName = "Backup" + DateTime.Now.ToShortDateString().Replace("\\", "").Replace("/", "");
            if (__SaveFileDial.ShowDialog() == DialogResult.OK)
            {
                __SetProgressBar();
                string __SavePath = __SaveFileDial.FileName;
                try
                {
                    DatabaseBackupManager.BackupDataBase(__SavePath, Helper.Instance.con);
                    MessageBox.Show("Database Backed Up Succesffully","Done!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void VerifyBackedUpDBBTn_Click(object sender, EventArgs e)
        {
            OpenFileDialog __OpenFileDial = new OpenFileDialog();
            __OpenFileDial.Filter = "RMS Database Backup|*.RMSbak";
           
            if (__OpenFileDial.ShowDialog() == DialogResult.OK)
            {
                __SetProgressBar();
                string __FileBath = __OpenFileDial.FileName;
                try
                {
                    if (DatabaseBackupManager.VerifyDatabaseBackup(__FileBath, Helper.Instance.con))
                    {
                        MessageBox.Show("Verified Successfully, You can restore the database safely now","Done!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not-Verified");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RestoreDBBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog __OpenFileDial = new OpenFileDialog();
            __OpenFileDial.Filter = "RMS Database Backup|*.RMSbak";
            if (__OpenFileDial.ShowDialog() == DialogResult.OK)
            {
                __SetProgressBar();
                string __FileBath = __OpenFileDial.FileName;
                try
                {
                    if (DatabaseBackupManager.RestoreDatabse(__FileBath, Helper.Instance.con))
                    {
                        MessageBox.Show("Database Restored Successfully", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Not-Verified");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
