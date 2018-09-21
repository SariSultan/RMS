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
    public partial class EditAdmins : Form
    {
        bool isloading = false;
        Color PasswordBGColor = Color.White;
        Color UserBGColor = Color.White;

        public EditAdmins()
        {
            InitializeComponent();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);




            //Add this Line To Each Constructor To Disable Maximize
            this.StartPosition = FormStartPosition.CenterScreen;

            PasswordBGColor = PasswordTxtBox.BackColor;
            UserBGColor = UserNameComboBox.BackColor;

            TranslateUI();
        }

        private void EditAdmins_Load(object sender, EventArgs e)
        {
            isloading = true;
            try
            {
                // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.dBDataSet.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[AddVendor_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            isloading = false;
        }

        private void UserNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (UserNameComboBox.SelectedValue != null && !isloading)
                {
                    int UserID = int.Parse(UserNameComboBox.SelectedValue.ToString());
                    DataRow UserInfo = UsersMgmt.SelectUserInfoByID(UserID);

                    foreach (TextBox aTextBox in UserInfoGB.Controls.OfType<TextBox>())
                    {
                        aTextBox.Text = UserInfo[aTextBox.Name.ToString().Substring(0, aTextBox.Name.Length - 6)].ToString();
                    }
                    EditAdminsCheckBox.Checked = PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName("EditAdmins"));
                    AdminCheckBox.Checked = UsersMgmt.IsUserAdmin(UserID);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UserNameComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminCheckBox.Checked == true)
            { EditAdminsCheckBox.Enabled = true; }
            else
            {
                EditAdminsCheckBox.Checked = false;
                EditAdminsCheckBox.Enabled = false;
            }
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (UserNameComboBox.SelectedValue != null && UserNameComboBox.Text != "")
                {
                    UserNameComboBox.BackColor = UserBGColor;
                    if (Validators.TxtBoxNotEmpty(PasswordTxtBox.Text))
                    {
                        PasswordTxtBox.BackColor = PasswordBGColor;
                        Users aUser = new Users();
                        aUser.User_Name = NameTxtBox.Text;
                        aUser.User_Address = AddressTxtBox.Text;
                        aUser.User_Phone1 = Phone1TxtBox.Text;
                        aUser.User_Phone2 = Phone2TxtBox.Text;
                        aUser.User_Password = PasswordTxtBox.Text;
                        aUser.User_Description = DescriptionTxtBox.Text;
                        aUser.User_ID = int.Parse(UserNameComboBox.SelectedValue.ToString());
                        UsersMgmt.UpdateUser(aUser);
                        foreach (TextBox aTextBox in this.UserInfoGB.Controls.OfType<TextBox>())
                        {
                            aTextBox.Text = "";
                        }
                        MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserNameComboBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PasswordTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        PasswordTxtBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserNameComboBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    UserNameComboBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateInfoBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UpdatePrivBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserNameComboBox.SelectedValue != null && UserNameComboBox.Text != "")
                {
                    UserNameComboBox.BackColor = UserBGColor;
                    if (UserNameComboBox.Text.ToLower() != "admin")
                    {
                        int UserID = int.Parse(UserNameComboBox.SelectedValue.ToString());
                        if (EditAdminsCheckBox.Checked)
                        {
                            if (!PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName("EditAdmins")))
                            {
                                PriviligesMgmt.AddPrivilige(UserID, EventsMgmt.SelectEventIDbyName("EditAdmins"));
                            }
                        }
                        else
                        {
                            if (PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName("EditAdmins")))
                            {
                                PriviligesMgmt.RemovePrivilige(UserID, EventsMgmt.SelectEventIDbyName("EditAdmins"));
                            }
                        }
                        if (AdminCheckBox.Checked == true)
                        {
                            UsersMgmt.MakeUserAdmin(UserID, 1);
                        }
                        else
                        {
                            UsersMgmt.MakeUserAdmin(UserID, 0);
                        }

                        MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserNameComboBox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.CannotChangeAdminTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    UserNameComboBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    UserNameComboBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdatePrivBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); ;
            }
        }


        private void TranslateUI()
        {
            try
            {
              this.Text = FormsNames.EditAdminsFormName;

            AddCustomerLbl.Text = UiText.EdtAdmAddCustomerLbl;
            AddressLbl.Text = UiText.EdtAdmAddressLbl;
            AdminCheckBox.Text = UiText.EdtAdmAdminCheckBox;
            Descriptionlbl.Text = UiText.EdtAdmDescriptionlbl;
            EditAdminsCheckBox.Text = UiText.EdtAdmEditAdminsCheckBox;
            MakeAdminGB.Text = UiText.EdtAdmMakeAdminGB;
            NameLbl.Text = UiText.EdtAdmNameLbl;
            PasswordLbl.Text = UiText.EdtAdmPasswordLbl;
            Phone1lbl.Text = UiText.EdtAdmPhone1lbl;
            Phone2lbl.Text = UiText.EdtAdmPhone2lbl;
            UpdateInfoBtn.Text = UiText.EdtAdmUpdateInfoBtn;
            UpdatePrivBtn.Text = UiText.EdtAdmUpdatePrivBtn;
            UserInfoGB.Text = UiText.EdtAdmUserInfoGB;
            UserNameLbl.Text = UiText.EdtAdmUserNameLbl;
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
