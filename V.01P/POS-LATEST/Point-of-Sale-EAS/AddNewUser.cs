using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Entities;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class AddNewUser : Form
    {
        Color NameBGColor = Color.White;
        Color PasswordBGColor = Color.White;

        public AddNewUser()
        {
            InitializeComponent();
            NameBGColor = UserNameTxtBox.BackColor;
            PasswordBGColor = PasswordTxtBox.BackColor;

            TranslateUI();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            //Add this Line To Each Constructor To Disable Maximize
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Validators.TxtBoxNotEmpty(UserNameTxtBox.Text) && Validators.TxtBoxNotEmpty(PasswordTxtBox.Text))
                {
                    if (!UsersMgmt.IsUserExist(UserNameTxtBox.Text))
                    {
                        Users aUser = new Users();
                        aUser.User_Name = NameTxtBox.Text;
                        aUser.User_Address = AddressTxtBox.Text;
                        aUser.User_Phone1 = Phone1TxtBox.Text;
                        aUser.User_Phone2 = Phone2TxtBox.Text;
                        aUser.User_Password = PasswordTxtBox.Text;
                        aUser.User_Description = DescriptionTxtBox.Text;
                        aUser.User_UserName = UserNameTxtBox.Text;

                        if (UsersMgmt.AddUser(aUser))
                        {
                           
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult ret;
                            ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (ret == DialogResult.Yes)
                            {
                                foreach (TextBox aTextBox in this.UserInfoGB.Controls.OfType<TextBox>())
                                {
                                    aTextBox.Text = "";
                                }
                            }
                            else
                            {
                                this.Close();
                            }

                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + " \n[DataBase Error]:IN [AddUserBtn_Click]" + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.UserTxt + " [ " + UserNameTxtBox.Text + " ] " + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (!Validators.TxtBoxNotEmpty(PasswordTxtBox.Text))
                    {
                        PasswordTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        PasswordTxtBox.Focus();
                    }
                    else
                    {
                        PasswordTxtBox.BackColor = PasswordBGColor;
                    }

                    if (!Validators.TxtBoxNotEmpty(UserNameTxtBox.Text))
                    {
                        UserNameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        UserNameTxtBox.Focus();
                    }
                    else
                    {
                        UserNameTxtBox.BackColor = NameBGColor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " \n[Exception]:IN [AddUserBtn_Click]" + "\n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
        private void ReloadForm()
        {
            
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddNewUser_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TranslateUI()
        {
            try
            {
               this.Text = FormsNames.AddNewUserFormName;
                // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //this.RightToLeftLayout = true;
                AddressLbl.Text = UiText.AddUsrAddressLbl;
                AddUserBtn.Text = UiText.AddUsrAddUserBtn;
                Descriptionlbl.Text = UiText.AddUsrDescriptionlbl;
                label3.Text = UiText.AddUsrlabel3;
                NameLbl.Text = UiText.AddUsrNameLbl;
                PasswordLbl.Text = UiText.AddUsrPasswordLbl;
                Phone1lbl.Text = UiText.AddUsrPhone1lbl;
                Phone2lbl.Text = UiText.AddUsrPhone2lbl;
                UserInfoGB.Text = UiText.AddUsrUserInfoGB;
                UserNameLbl.Text = UiText.AddUsrUserNameLbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //MAKE THE BORDERLESS MOVABLE
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

        //Garbage Collector
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                foreach (object obj in this.Controls)
                {
                    if (obj is IDisposable)
                    {
                        (obj as IDisposable).Dispose();
                    }
                }
                base.OnClosed(e);
                base.Dispose();
                this.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [OnClosed] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        
    }
}
