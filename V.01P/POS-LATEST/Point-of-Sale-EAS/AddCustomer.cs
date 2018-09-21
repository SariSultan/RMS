using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Entities;
using Calcium_RMS.Management;
using Calcium_RMS.Text;


namespace Calcium_RMS
{
    public partial class AddCustomer : Form
    {
        Color NameColor = Color.White;
        Color PhoneColor = Color.White;

        public AddCustomer()
        {
            InitializeComponent();

            TranslateUI();

            NameColor = NameTxtBox.BackColor;
            PhoneColor = Phone1TxtBox.BackColor;

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

            OpenBalTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);

            Phone1TxtBox.TextChanged += new EventHandler(Validators.PhoneInputChange);


        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                BalDateTxtBox.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[AddCustomer_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double TestParserBal = 0.00;
                if (Validators.TxtBoxNotEmpty(NameTxtBox.Text) && Validators.TxtBoxNotEmpty(Phone1TxtBox.Text))
                {
                    if (MakeUserAccountChkBox.Checked)
                    {
                        if (!double.TryParse(OpenBalTxtBox.Text, out TestParserBal))
                        {
                            MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    if (!CustomerMgmt.IsPhoneUsed(Phone1TxtBox.Text))
                    {
                        Customer aCustomer = new Customer();
                        aCustomer.Customer_Name = NameTxtBox.Text;
                        aCustomer.Customer_Address = AddressTxtBox.Text;
                        aCustomer.Customer_Email = EmailTxtBox.Text;
                        aCustomer.Customer_Phone1 = Phone1TxtBox.Text;

                        if (CustomerMgmt.InsertCustomer(aCustomer))
                        {
                            if (MakeUserAccountChkBox.Checked)
                            {
                                int CustomerID = CustomerMgmt.SelectCustomerIDByPhone1(Phone1TxtBox.Text);
                                if (!CustomersAccountsMgmt.InsertCustomerAccount(CustomerID))
                                {
                                    MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                int AccountID = int.Parse(CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID)["ID"].ToString());
                                CustomersAccountsMgmt.UpdateAccountAmountByAccountID(AccountID, TestParserBal);
                            }
                            
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult ret;
                            ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                            MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.PhoneInUse, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (!Validators.TxtBoxNotEmpty(Phone1TxtBox.Text))
                    {
                        Phone1TxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        Phone1TxtBox.Focus();
                    }
                    else
                    {
                        Phone1TxtBox.BackColor = PhoneColor;
                    }

                    if (!Validators.TxtBoxNotEmpty(NameTxtBox.Text))
                    {
                        NameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        NameTxtBox.Focus();
                    }
                    else
                    {
                        NameTxtBox.BackColor = NameColor;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddCustomerBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddCustomerFormName;
                AddCustomerLbl.Text = UiText.AddCstAddCustomerLbl;
                CustomerInfoGB.Text = UiText.AddCstCustomerInfoGB;
                NameLbl.Text = UiText.AddCstNameLbl;
                Phone1Lbl.Text = UiText.AddCstPhone1Lbl;
                AddressLbl.Text = UiText.AddCstAddressLbl;
                EmailLbl.Text = UiText.AddCstEmailLbl;
                AddCustomerBtnLbl.Text = UiText.AddCstAddCustomerBtnLbl;
                MakeUserAccountChkBox.Text = UiText.AddCstMakeUserAccountChkBox;
                RequiredFieldLbl.Text = UiText.AddCstRequiredFieldLbl;
                AddCustomerBtn.Text = UiText.AddCstAddCustomerBtn;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        //MAKE THE BORDERLESS MOVABLE
        //protected override void WndProc(ref Message m)
        //{
        //    try
        //    {
        //        switch (m.Msg)
        //        {
        //            case 0x84:
        //                base.WndProc(ref m);
        //                if ((int)m.Result == 0x1)
        //                    m.Result = (IntPtr)0x2;
        //                return;
        //        }
        //        base.WndProc(ref m);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WndProc] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.Close();
        //    }

        //}
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

        private void MakeUserAccountChkBox_CheckedChanged(object sender, EventArgs e)
        {
            OpenBalTxtBox.Enabled = MakeUserAccountChkBox.Checked;
        }
        //To Make Size Always Normal For Non-Grid Forms



    }
}
