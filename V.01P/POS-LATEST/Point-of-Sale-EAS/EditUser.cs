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
    public partial class EditUser : Form
    {
        bool isloading = true;

        public EditUser()
        {
            // this.SuspendLayout();
            //  this.SuspendDrawing();
            InitializeComponent();

            Phone1TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);
            Phone2TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            this.StartPosition = FormStartPosition.CenterScreen;

            TranslateUI();
            // this.ResumeDrawing();
            // this.ResumeLayout();

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.dBDataSet.Users);
                UserNameComboBox.Text = "";
                //trun it to false after finish loading
                isloading = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditUser_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void UpdatePrivBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validators.TxtBoxNotEmpty(UserNameComboBox.Text))
                {
                    int UserID = int.Parse(UserNameComboBox.SelectedValue.ToString());
                    if (UsersMgmt.SelectUserInfoByID(UserID)["IsAdmin"].ToString() == "1")
                    {
                        MessageBox.Show(UiText.CannotEditAdminsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        foreach (CheckBox aCheckBox in PriviligesGB.Controls.OfType<CheckBox>())
                        {
                            if (aCheckBox.Checked == true)
                            {
                                if (!PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName(aCheckBox.Tag.ToString())))
                                {
                                    PriviligesMgmt.AddPrivilige(UserID, EventsMgmt.SelectEventIDbyName(aCheckBox.Tag.ToString()));
                                }
                            }
                            else
                            {
                                if (PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName(aCheckBox.Tag.ToString())))
                                {
                                    PriviligesMgmt.RemovePrivilige(UserID, EventsMgmt.SelectEventIDbyName(aCheckBox.Tag.ToString()));
                                }
                            }
                        }
                        MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.UserTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdatePrivBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void UserNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (UserNameComboBox.SelectedValue != null && !isloading)
                {
                    //ControlHelper.SuspendDrawing(this);
                    int UserID = int.Parse(UserNameComboBox.SelectedValue.ToString());
                    bool isenabled;
                    if (UsersMgmt.SelectUserInfoByID(UserID)["IsAdmin"].ToString() == "1")
                    {
                        PasswordTxtBox.UseSystemPasswordChar = true;
                        isenabled = false;
                        CannotEditAdminLbl.Visible = true;
                    }
                    else
                    {
                        PasswordTxtBox.UseSystemPasswordChar = false;
                        isenabled = true;
                        CannotEditAdminLbl.Visible = false;
                    }
                    DataRow UserInfo = UsersMgmt.SelectUserInfoByID(UserID);
                    foreach (var aGroupBox in this.Controls.OfType<GroupBox>())
                    {
                        foreach (TextBox aTextBox in aGroupBox.Controls.OfType<TextBox>())
                        {
                            aTextBox.Text = UserInfo[aTextBox.Name.ToString().Substring(0, aTextBox.Name.Length - 6)].ToString();
                            aTextBox.Enabled = isenabled;
                        }
                        foreach (CheckBox aCheckBox in aGroupBox.Controls.OfType<CheckBox>())
                        {
                            aCheckBox.Checked = PriviligesMgmt.IsPriviligeExist(UserID, EventsMgmt.SelectEventIDbyName(aCheckBox.Tag.ToString()));
                            aCheckBox.Enabled = isenabled;
                        }
                    }
                    UpdateInfoBtn.Enabled = isenabled;
                    UpdatePrivBtn.Enabled = isenabled;
                  //  ControlHelper.ResumeDrawing(this);
                }
            }
            catch (Exception ex)
            {
                //ControlHelper.ResumeDrawing(this);
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UserNameComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        public void UpdateVariables(string aUserName)
        {
            try
            {
                UserNameComboBox.Text = aUserName;
                UserNameComboBox.SelectedValue = UsersMgmt.SelectUserIDByUserName(aUserName).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }

        }
        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserNameComboBox.Text != "")
                {
                    if (UsersMgmt.SelectUserInfoByID(int.Parse(UserNameComboBox.SelectedValue.ToString()))["IsAdmin"].ToString() == "1")
                    {
                        MessageBox.Show(UiText.CannotEditAdminsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Users aUser = new Users();
                        aUser.User_Name = NameTxtBox.Text;
                        aUser.User_Address = AddressTxtBox.Text;
                        aUser.User_Phone1 = Phone1TxtBox.Text;
                        aUser.User_Phone2 = Phone2TxtBox.Text;
                        aUser.User_Password = PasswordTxtBox.Text;
                        aUser.User_Description = DescriptionTxtBox.Text;
                        aUser.User_ID = int.Parse(UserNameComboBox.SelectedValue.ToString());

                        if (UsersMgmt.UpdateUser(aUser))
                        {
                            foreach (TextBox aTextBox in this.UserInfoGB.Controls.OfType<TextBox>())
                            {
                                aTextBox.Text = "";
                            }
                            MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UserNameComboBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.UserTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateInfoBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void EditAdminsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditAdmins) == EventStatus.Permit)
                {
                    EditAdmins aEditAdmin = new EditAdmins();
                 //   aEditAdmin.MdiParent = Helper.Instance.ActiveMainWindow;
                    aEditAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditAdminsBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditUserFormName;
                EditUsersLbl.Text = UiText.EdtUsrEditUsersLbl;
                UserNameLbl.Text = UiText.EdtUsrUserNameLbl;
                UserInfoGB.Text = UiText.EdtUsrUserInfoGB;
                PasswordLbl.Text = UiText.EdtUsrPasswordLbl;
                Descriptionlbl.Text = UiText.EdtUsrDescriptionlbl;
                Phone2lbl.Text = UiText.EdtUsrPhone2lbl;
                Phone1lbl.Text = UiText.EdtUsrPhone1lbl;
                AddressLbl.Text = UiText.EdtUsrAddressLbl;
                NameLbl.Text = UiText.EdtUsrNameLbl;
                EditAdminsBtn.Text = UiText.EdtUsrEditAdminsBtn;
                PriviligesGB.Text = UiText.EdtUsrPriviligesGB;

                //ListCustomers.Text = UiText.EdtUsrListCustomers;
                //AddNewUser.Text = UiText.EdtUsrAddNewUser;
                //ListVouchers.Text = UiText.EdtUsrListVouchers;
                //ReturnItemsVoucher.Text = UiText.EdtUsrReturnItemsVoucher;
                //EditBills.Text = UiText.EdtUsrEditBills;
                //EditOrReturnVoucher.Text = UiText.EdtUsrEditOrReturnVoucher;
                //ListBills.Text = UiText.EdtUsrListBills;
                //PurchaseVoucher.Text = UiText.EdtUsrPurchaseVoucher;
                //ListVendors.Text = UiText.EdtUsrListVendors;
                //ListItems.Text = UiText.EdtUsrListItems;
                //EditVendors.Text = UiText.EdtUsrEditVendors;
                //EditItems.Text = UiText.EdtUsrEditItems;
                //EditCustomer.Text = UiText.EdtUsrEditCustomer;
                //EndOfDay.Text = UiText.EdtUsrEndOfDay;
                //AddCustomer.Text = UiText.EdtUsrAddCustomer;
                //FullSalesHistory.Text = UiText.EdtUsrFullSalesHistory;
                //Reports.Text = UiText.EdtUsrReports;
                //MySalesHistory.Text = UiText.EdtUsrMySalesHistory;
                //ListUsers.Text = UiText.EdtUsrListUsers;
                //AddVendor.Text = UiText.EdtUsrAddVendor;
                //AddNewITem.Text = UiText.EdtUsrAddNewITem;
                //ReturnHistory.Text = UiText.EdtUsrReturnHistory;
                //MakeASale.Text = UiText.EdtUsrMakeASale;
                //UpdateInfoBtn.Text = UiText.EdtUsrUpdateInfoBtn;
                //UpdatePrivBtn.Text = UiText.EdtUsrUpdatePrivBtn;
                //EditUsers.Text = UiText.EdtUsrEditUsersLbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
