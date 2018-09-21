using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Forms.VisualStyles;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class login : Form
    {
        public bool IsFirstLogin { get; set; }
        Color UsrBGColor = Color.White;
        Color PassBGColor = Color.White;

        public login()
        {
            InitializeComponent();

            OldSize_X = this.Size.Width;
            OldSize_Y = this.Size.Height;
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            if (SharedVariables.IsStartup)
            {
                Helper.Instance.SetLoginWindow(this);
            }

            UsrBGColor = UsrTxtBox.BackColor;
            PassBGColor = PassTxtBox.BackColor;
            TranslateUI();

            if (Security.V1.ActivationCheck.__IsRegisteredVersion)
            {
                RegisteredLbl.Text = " " + MsgTxt.RegisteredToTxt + " :" + Security.V1.ActivationCheck.__RegisteredTo;
                RegisteredLbl.Visible = true;
            }
            else
            {
                RegisteredLbl.Visible = true;
                ActivationBtn.Visible = true;
                RegisteredLbl.Text = "   " + MsgTxt.UnregisteredVersionTxt;
                if (Security.V1.ActivationCheck.__IsTrialValid)
                {
                    TrialLbl.Text = MsgTxt.YouReachedTxt + Security.V1.ActivationCheck.NumberOfItemsInTheSystem + "/" + Security.V1.ActivationCheck.TrialNumberOfItems + " " + MsgTxt.TrialAllowedItemsTxt;
                    TrialLbl.Visible = true;
                }
                else
                {
                    TrialLbl.Text = MsgTxt.YouReachedTxt + Security.V1.ActivationCheck.NumberOfItemsInTheSystem + "/" + Security.V1.ActivationCheck.TrialNumberOfItems + " " + MsgTxt.TrialAllowedItemsTxt + " " + MsgTxt.YouShouldActivateNowTxt;
                    TrialLbl.Visible = true;
                }
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Testing Mode Enabled");
                Testing ateTesting = new Testing();
                ateTesting.Show();
            }
            if (!Security.V1.ActivationCheck.__IsRegisteredVersion)
            {
                if (Security.V1.ActivationCheck.__IsTrialValid == false)
                {
                    MessageBox.Show(MsgTxt.YouShouldActivateNowTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            bool isadmin;

            if (UsrTxtBox.Text.Trim() != "" && PassTxtBox.Text.Trim() != "")
            {
                UsrTxtBox.BackColor = UsrBGColor;
                PassTxtBox.BackColor = PassBGColor;
                DataRow dr = UsersMgmt.SelectUserByUserNameandPassword(UsrTxtBox.Text, PassTxtBox.Text);
                if (dr != null)
                {
                    if (IsFirstLogin || SharedVariables.IsStartup)
                    {
                        if (Convert.ToInt32(dr["IsAdmin"]) == 1)
                        {
                            PrivilegesManager.IsCurrentUserAdmin = true;
                            SharedVariables.user_logged_name = dr["UserName"].ToString();
                            SharedVariables.user_logged_name_name = dr["Name"].ToString();
                            isadmin = true;
                        }
                        else
                        {
                            PrivilegesManager.IsCurrentUserAdmin = false;
                            SharedVariables.user_logged_name = dr["UserName"].ToString();
                            SharedVariables.user_logged_name_name = dr["Name"].ToString();
                            isadmin = false;
                        }
                        PrivilegesManager.FillTemplate(Convert.ToInt32(dr["ID"]));
                        PrivilegesManager.IsTempActive = false;
                        PrivilegesManager.IsAdminActive = isadmin;
                        SharedVariables.is_user_logged = true;
                        if (SharedVariables.IsStartup)
                        {
                            Main2 aMain = new Main2();
                            aMain.Show();
                            //this.Close();
                        }
                    } // END OF FIRST LOGIN
                    else //NOT FIRST LOGIN
                    {
                        if (Convert.ToInt32(dr["IsAdmin"]) == 1)
                        {
                            PrivilegesManager.IsTempUserAdmin = true;
                            SharedVariables.temp_logged_name = dr["UserName"].ToString();
                            SharedVariables.temp_logged_name_name = dr["Name"].ToString();
                        }
                        else
                        {
                            PrivilegesManager.IsTempUserAdmin = false;
                            SharedVariables.temp_logged_name = dr["UserName"].ToString();
                            SharedVariables.temp_logged_name_name = dr["Name"].ToString();
                        }
                        PrivilegesManager.FillTemplate(Convert.ToInt32(dr["ID"]), true);
                        PrivilegesManager.IsTempActive = true;
                    }

                    if (SharedVariables.IsStartup)
                    {
                        SharedVariables.IsStartup = false;
                        this.UsrTxtBox.Focus();
                        this.UsrTxtBox.Clear();
                        this.PassTxtBox.Clear();
                        this.Hide();
                    }
                    else //TEMP LOGIN SCREEN LAUNCHED INSIDE THE PROGRAM
                    {
                        this.Close();
                    }
                }
                else
                {
                    Thread.Sleep(1000);
                    MessageBox.Show(MsgTxt.UsrNameTxt + " " + MsgTxt.OrTxt + " " + MsgTxt.PasswordTxt + " " + MsgTxt.IncorrectTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                string Messagetxt = MsgTxt.PleaseAddAllRequiredFields + "\n";
                if (UsrTxtBox.Text.Trim() == "")
                {
                    Messagetxt += "1)" + MsgTxt.UsrNameTxt + "\n";
                    UsrTxtBox.Focus();
                    UsrTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                }
                if (PassTxtBox.Text.Trim() == "")
                {

                    Messagetxt += "2)" + MsgTxt.PasswordTxt;
                    PassTxtBox.Focus();
                    if (UsrTxtBox.Text.Trim() == "")
                    {
                        UsrTxtBox.Focus();
                    }
                    PassTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                }
                MessageBox.Show(Messagetxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.LoginFormName;
               // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                RegisteredLbl.RightToLeft =TrialLbl.RightToLeft= FlowDirectionManager.GetFlowDirection();
                
                LoginBtn.Text = UiText.LoginLoginBtn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Return:
                    //Process action here.
                    LoginBtn.PerformClick();
                    break;
                case Keys.Escape:
                    //Process action here.
                    this.Close();
                    break;
            }
            return false;
        }

        protected override void OnClosed(EventArgs e)
        {
            if (SharedVariables.IsStartup)
            {
                Application.ExitThread();
            }
            else
            {
                base.OnClosed(e);
            }
        }

        private void ActivationBtn_Click(object sender, EventArgs e)
        {
            Security.ActivationFrm aActivationFrm = new Security.ActivationFrm();
            aActivationFrm.ShowDialog();
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
            while (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            //base.OnResize(e);
        }



        bool Enabled = false;
        int OldSize_X = 0;
        int OldSize_Y = 0;

        private void KeyboardBtn_Click(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                this.Size = new Size(OldSize_X + 281, OldSize_Y + 120);
                Enabled = true;
                keybrd1.Show();
                UsrTxtBox.Focus();
            }
            else
            {
                this.Size = new Size(OldSize_X, OldSize_Y);
                Enabled = false;
                keybrd1.Hide();
            }
        }

        private void keybrd1_ButtonPressed(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send(e.KeyChar.ToString());
        }

        private void keybrd1_VisibleChanged(object sender, EventArgs e)
        {
            if (keybrd1.Visible==false)
            {
                KeyboardBtn.PerformClick();   
            }
            
        }

        private void LinkPicBox_Click(object sender, EventArgs e)
        {
           
        }

        
    }

}
