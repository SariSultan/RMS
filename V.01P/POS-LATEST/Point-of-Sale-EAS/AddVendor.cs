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
    public partial class AddVendor : Form
    {
        Color NameBGColor = Color.White;
        Color PhoneBGColor = Color.White;
        Color CompanyBGColor = Color.White;
        public AddVendor()
        {
            InitializeComponent();
            NameBGColor = NameTxtBox.BackColor;
            PhoneBGColor = Phone1TxtBox.BackColor;
            CompanyBGColor = CompanyTxtBox.BackColor;

            TranslateUI();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            OpenBalTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            Phone1TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);
            Phone2TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);

            //Add this Line To Each Constructor To Disable Maximize
           
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddVendorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredFields())
                {
                    if (!VendorsMgmt.IsVendorExist(NameTxtBox.Text))
                    {
                        Vendors aVendor = new Vendors();
                        aVendor.Vendor_Name = NameTxtBox.Text;
                        aVendor.Vendor_Email = EmailTxtBox.Text;
                        aVendor.Vendor_Location = LocationTxtBox.Text;
                        aVendor.Vendor_Phone1 = Phone1TxtBox.Text;
                        aVendor.Vendor_Phone2 = Phone2TxtBox.Text;
                        aVendor.Vendor_Company = CompanyTxtBox.Text;

                        DateTime aDate = DateTime.Now;
                        aVendor.Vendor_Start_Date = aDate.Date.ToShortDateString();

                        if (VendorsMgmt.AddVendor(aVendor))
                        {
                            int VendorID = VendorsMgmt.SelectVendorIDByName(aVendor.Vendor_Name);

                            if (VendorID == 0)
                            {
                                MessageBox.Show(MsgTxt.UnexpectedError + " \n [DataBase ERROR 1 IN[AddVendorBtn_Click] VendorID=0", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!VendorsAccountsMgmt.InserVendorAccount(VendorID))
                            {
                                MessageBox.Show(MsgTxt.UnexpectedError + " \n [DataBase ERROR 2 IN[AddVendorBtn_Click] ", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                int AccountID = int.Parse(VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(VendorID)["ID"].ToString());
                                VendorsAccountsMgmt.UpdateAccountAmountByAccountID(AccountID,double.Parse(OpenBalTxtBox.Text));
                            }

                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult ret;
                            ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (ret == DialogResult.Yes)
                            {
                                foreach (TextBox aTextBox in this.CustomerInfoGB.Controls.OfType<TextBox>())
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
                            MessageBox.Show(MsgTxt.UnexpectedError + " \n [DataBase ERROR 3 IN[AddVendorBtn_Click]", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.VendorTxt + " [ " + NameTxtBox.Text + " ] " + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddVendorBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private bool CheckRequiredFields()
        {
            bool RequiredFieldsFilled = true;
            int Cnt = 1;
            string MsgToDisplay = MsgTxt.PleaseSelectTxt;
            if (!Validators.TxtBoxNotEmpty(NameTxtBox.Text))
            {
                RequiredFieldsFilled = false;
                MsgToDisplay += "\n" + Cnt++ + ")" + MsgTxt.VendorTxt;
                NameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
            }
            else
            {
                NameTxtBox.BackColor = NameBGColor;
            }

            if (!Validators.TxtBoxNotEmpty(Phone1TxtBox.Text))
            {
                RequiredFieldsFilled = false;
                MsgToDisplay += "\n" + Cnt++ + ")" + MsgTxt.PhoneTxt;
                Phone1TxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
            }
            else
            {
                Phone1TxtBox.BackColor = PhoneBGColor;
            }

            if (!Validators.TxtBoxNotEmpty(CompanyTxtBox.Text))
            {
                RequiredFieldsFilled = false;
                MsgToDisplay += "\n" + Cnt++ + ")" + MsgTxt.CompanyTxt;
                CompanyTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
            }
            else
            {
                CompanyTxtBox.BackColor = CompanyBGColor;
            }

            double TestParserBal = 0.00;
            if (!double.TryParse(OpenBalTxtBox.Text,out TestParserBal))
            {
                RequiredFieldsFilled = false;
                MsgToDisplay += "\n" + Cnt++ + ")" + MsgTxt.OpeningBalTxt;
                OpenBalTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
            }
            else
            {
                OpenBalTxtBox.BackColor = CompanyBGColor;
            }

            if (!RequiredFieldsFilled)
            {
                MessageBox.Show(MsgToDisplay, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return RequiredFieldsFilled;
        }
       

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddNewVednorFormName;

                // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
               // this.RightToLeftLayout = true;
                AddVendorBtn.Text = UiText.AddVndAddVendorBtn;
                AddVendorLbl.Text = UiText.AddVndAddVendorLbl;
                CompanyLbl.Text = UiText.AddVndCompanyLbl;
                CustomerInfoGB.Text = UiText.AddVndCustomerInfoGB;
                EmailLbl.Text = UiText.AddVndEmailLbl;
                LocationLbl.Text = UiText.AddVndLocationLbl;
                NameLbl.Text = UiText.AddVndNameLbl;
                Phone1Lbl.Text = UiText.AddVndPhone1Lbl;
                Phone2Lb.Text = UiText.AddVndPhone2Lb;
                RequiredFieldLbl.Text = UiText.AddVndRequiredFieldLbl;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

      
      
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

        private void AddVendor_Load(object sender, EventArgs e)
        {
            BalDateTxtBox.Text = DateTime.Now.ToShortDateString();
        }


        //To Make Size Always Normal For Non-Grid Forms
      

    }
}
