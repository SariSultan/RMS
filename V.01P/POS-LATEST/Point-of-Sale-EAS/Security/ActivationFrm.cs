using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Security.V1;
using Calcium_RMS.Text;
using System.IO;
namespace Calcium_RMS.Security
{
    public partial class ActivationFrm : Form
    {
        public ActivationFrm()
        {
            InitializeComponent();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

        }

        private void GenerateKeyBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog __SaveFileDial = new SaveFileDialog();
            __SaveFileDial.Filter = "Calcium RMS Request Activation File|*.RMSreq";
            RMSActivationManagerV1.ClientInfo __ClientInfo=new RMSActivationManagerV1.ClientInfo();
            __ClientInfo.ClientName=ClientNameTxtBox.Text;
            __ClientInfo.CompanyName=CompanyNameTxtBox.Text;
            __ClientInfo.ClientPhone=ClientPhoneTxtBox.Text;
            __ClientInfo.ClientEmail=ClientEmailTxtBox.Text;
            __ClientInfo.RequestDate=DateTime.Now.ToString();

            if (ClientNameTxtBox.Text.Trim()!="" &&CompanyNameTxtBox.Text.Trim()!="" && ClientPhoneTxtBox.Text.Trim()!="" && ClientEmailTxtBox.Text.Trim()!="")
            {
                if (__SaveFileDial.ShowDialog() == DialogResult.OK)
                {
                    RMSActivationManagerV1.GenerateRequestkey(__ClientInfo, __SaveFileDial.FileName);
                }  
            }
            else
            {
                MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }

        private void AddResponseKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog __openfileDial = new OpenFileDialog();
             __openfileDial.Filter = "Calcium RMS KEY Activation File|*.RMSKey";
            if (__openfileDial.ShowDialog()==DialogResult.OK)
            {
                File.Copy(__openfileDial.FileName, System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\\key.RMSKey",true);                
                Application.Restart();
            }
        }

        private void Step1Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Step2Lbl_Click(object sender, EventArgs e)
        {

        }
        //  MAKE THE BORDERLESS MOVABLE
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case 0x84:
                        base.WndProc(ref m);
                        if ((int)m.Result == 0x1)
                            m.Result = (IntPtr)0x2;
                        return;
                }
                base.WndProc(ref m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WndProc] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            while (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
            }
            //base.OnResize(e);
        }
    }
}
