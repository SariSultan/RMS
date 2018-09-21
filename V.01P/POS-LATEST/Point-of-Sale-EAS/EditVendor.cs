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
    public partial class EditVendor : Form
    {
        string OldName = "";
        Color NameBGColor = Color.White;
        Color PhoneBGColor = Color.White;
        Color CompanyBGColor = Color.White;

        public EditVendor()
        {
            InitializeComponent();

            NameBGColor = NameTxtBox.BackColor;
            PhoneBGColor = Phone1TxtBox.BackColor;
            CompanyBGColor = CompanyTxtBox.BackColor;
            EditingLbl.Hide();
            OldNameLbl.Hide();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            Phone1TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);
            Phone2TxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.PhoneInputChange);

            TranslateUI();
        }

        private void UpdateVendorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckRequiredFields())
                {
                    if (!VendorsMgmt.IsVendorExist(NameTxtBox.Text) && NameTxtBox.Text != OldNameLbl.Text)
                    {
                        Vendors aVendor = new Vendors();
                        aVendor.Vendor_Name = NameTxtBox.Text;
                        aVendor.Vendor_Email = EmailTxtBox.Text;
                        aVendor.Vendor_Location = LocationTxtBox.Text;
                        aVendor.Vendor_Phone1 = Phone1TxtBox.Text;
                        aVendor.Vendor_Phone2 = Phone2TxtBox.Text;
                        aVendor.Vendor_Company = CompanyTxtBox.Text;
                        if (VendorsMgmt.UpdateVendorByName(OldName, aVendor))
                        {
                            MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR in:VendorsMgmt.UpdateVendorByName returned false] \n Exception: " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.VendorTxt + " " + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateVendorBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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

            if (!RequiredFieldsFilled)
            {
                MessageBox.Show(MsgToDisplay, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return RequiredFieldsFilled;
        }
        public void UpdateVariables(DataRow aVendorDataRow)
        {
            try
            {
                OldName = aVendorDataRow["Name"].ToString();
                NameTxtBox.Text = OldName;
                EmailTxtBox.Text = aVendorDataRow["Email"].ToString();
                LocationTxtBox.Text = aVendorDataRow["Location"].ToString();
                Phone1TxtBox.Text = aVendorDataRow["Phone1"].ToString();
                Phone2TxtBox.Text = aVendorDataRow["Phone2"].ToString();
                CompanyTxtBox.Text = aVendorDataRow["Company"].ToString();
                OldNameLbl.Show();
                EditingLbl.Show();
                OldNameLbl.Text = OldName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EDIT Vendor: UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditVendorFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
               // this.RightToLeftLayout = true;
                EditingLbl.Text = UiText.EdtVndEditingLbl;
                EditVendorLbl.Text = UiText.EdtVndEditVendorLbl;
                EmailLbl.Text = UiText.EdtVndEmailLbl;
                LocationLbl.Text = UiText.EdtVndLocationLbl;
                NameLbl.Text = UiText.EdtVndNameLbl;
                OldNameLbl.Text = UiText.EdtVndOldNameLbl;
                Phone1Lbl.Text = UiText.EdtVndPhone1Lbl;
                Phone2Lb.Text = UiText.EdtVndPhone2Lb;
                RequiredFieldLbl.Text = UiText.EdtVndRequiredFieldLbl;
                UpdateVendorBtn.Text = UiText.EdtVndUpdateVendorBtn;
                VendorInfoGB.Text = UiText.EdtVndVendorInfoGB;
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
