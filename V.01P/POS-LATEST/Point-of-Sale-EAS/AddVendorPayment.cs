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
using Calcium_RMS.Reports;
using System.Diagnostics;
namespace Calcium_RMS
{
    public partial class AddVendorPayment : Form
    {
        bool VendorDoNotHaveAccount = true;
        double Balance = 0;
        int VendorID = 0;
        bool AccountNotJOD = false;
        bool IsLoading = true;

        bool semaphore = false;

        DataRow aVendorRow = null;
        DataRow aVendorAccountRow = null;

        DataRow aAccountDataRow = null;

        VendorsPayments aVendorPayment;

        Color CreditCardInfoTxtBoxCOLOR = Color.White;

        Color PaymentAmountTxtBoxCOLOR = Color.White;

        Color HolderNameTxtBoxCOLOR = Color.White;

        public AddVendorPayment()
        {
            InitializeComponent();


            PaymentAmountTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            //Add this Line To Each Constructor To Disable Maximize
            this.StartPosition = FormStartPosition.CenterScreen;

            CreditCardInfoTxtBoxCOLOR = CreditCardInfoTxtBox.BackColor;
            PaymentAmountTxtBoxCOLOR = PaymentAmountTxtBox.BackColor;
            HolderNameTxtBoxCOLOR = HolderNameTxtBox.BackColor;

            TranslateUI();
        }

        private void AddVendorPayment_Load(object sender, EventArgs e)
        {
            try
            {
                IsLoading = true;

                int PaymentNumber = VendorsPaymentsMgmt.NextPaymentNumber();

                if (PaymentNumber == 0)
                {
                    throw new Exception("Payment Number ==0");
                }
                else
                {
                    PaymentNumberTxtBox.Text = PaymentNumber.ToString();
                    DataRow aPaymentMethodRow = PaymentMethodMgmt.SelectDefaultPaymentMethod();
                    if (aPaymentMethodRow == null)
                    {
                        throw new Exception("aPaymentMethodRow ==null");
                    }
                    else
                    {
                        PaymentMethodCheckBox.Text = aPaymentMethodRow["Name"].ToString();
                        PaymentMethodCheckBox.SelectedValue = aPaymentMethodRow["ID"].ToString();
                        PaymentMethodDescripTxtBox.Text = aPaymentMethodRow["Description"].ToString();

                        AccountComboBox.SelectedValue = int.Parse(aPaymentMethodRow["DefaultAccountID"].ToString());//PaymentMethodMgmt.SelectDefaultAccountIDByMethodID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aPaymentMethodRow["DefaultAccountID"].ToString()));
                        IsLoading = false;
                    }

                }
            }
            catch (Exception ex)
            {
                IsLoading = false;
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddVendorPayment_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void VendorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (VendorNameComboBox.SelectedValue != null)
                {
                    semaphore = true;

                    aVendorRow = VendorsMgmt.SelectVendorRowByID(int.Parse(VendorNameComboBox.SelectedValue.ToString()));
                    if (aVendorRow == null)
                    {
                        throw new Exception("Vendor Row==null");
                    }

                    VendorCompanyTxtBox.Text = aVendorRow["Company"].ToString();
                    VendorID = int.Parse(VendorNameComboBox.SelectedValue.ToString());

                    aVendorAccountRow = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(int.Parse(VendorNameComboBox.SelectedValue.ToString()));
                    if (aVendorAccountRow == null)
                    {
                        VendorAccountBalanceTxtBox.Text = "Vendor Have No Account";
                        VendorDoNotHaveAccount = true;
                    }
                    else
                    {
                        VendorAccountBalanceTxtBox.Text = aVendorAccountRow["Amount"].ToString();
                        Balance = Double.Parse(aVendorAccountRow["Amount"].ToString());
                        VendorDoNotHaveAccount = false;
                    }
                    semaphore = false;
                }
                else
                {
                    //EXCEPTION
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [VendorNameComboBox_SelectedIndexChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddPaymentBtn_Click(object sender, EventArgs e)
        {
            if (AddPayment())
            {
                // print_receipt();
                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddNewTxt + "?", MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (ret == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void ReloadForm()
        {
            VendorAccountBalanceTxtBox.Text = string.Empty;
            VendorCompanyTxtBox.Text = string.Empty;
            VendorDoNotHaveAccount = true;
            PaymentAmountTxtBox.Text = string.Empty;
            CommentsTxtBox.Text = string.Empty;
        }

        private void AccountComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (AccountComboBox.SelectedValue != null)
                {
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(AccountComboBox.SelectedValue.ToString()));
                    if (AccountsMgmt.SelectAccountPaymentMethodByID(int.Parse(AccountComboBox.SelectedValue.ToString())) == int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()))
                    {
                        if (aAccountRow["CurrencyID"].ToString() != "1")
                        {
                            AccountNotJOD = true;
                        }
                        else
                        {
                            AccountNotJOD = false;
                        }
                        AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aAccountRow["ID"].ToString()));
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.AccountTxt + "\n[" + AccountComboBox.Text + "]\n" + MsgTxt.DoNotAcceptTxt + "\n" + PaymentMethodCheckBox.Text, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Same As Function on value change for the payment method combo box
                        DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        AccountComboBox.SelectedValue = int.Parse(aMethodRow["DefaultAccountID"].ToString());//PaymentMethodMgmt.SelectDefaultAccountIDByMethodID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        PaymentMethodDescripTxtBox.Text = aMethodRow["Description"].ToString();//PaymentMethodMgmt.SelectDescriptionByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        if (aMethodRow["IsCash"].ToString() == "1")
                        {
                            CashPaymentGB.Show();
                            CashPaymentGB.BringToFront();
                            PayInVisaGB.Hide();
                            CheckGB.Hide();
                        }
                        else if (aMethodRow["IsCredit"].ToString() == "1")
                        {
                            PayInVisaGB.Show();
                            PayInVisaGB.BringToFront();
                            CashPaymentGB.Hide();
                            CheckGB.Hide();
                        }
                        else
                        {
                            CheckGB.Show();
                            CheckGB.BringToFront();
                            CashPaymentGB.Hide();
                            PayInVisaGB.Hide();
                        }
                    }

                }
            }
            catch (Exception ex) //Unexpected Error
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AccountComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void PaymentMethodCheckBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (PaymentMethodCheckBox.SelectedValue != null)
            {
                DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                AccountComboBox.SelectedValue = int.Parse(aMethodRow["DefaultAccountID"].ToString());//PaymentMethodMgmt.SelectDefaultAccountIDByMethodID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aMethodRow["DefaultAccountID"].ToString()));
                PaymentMethodDescripTxtBox.Text = aMethodRow["Description"].ToString();//PaymentMethodMgmt.SelectDescriptionByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                if (aMethodRow["IsCash"].ToString() == "1")
                {
                    CashPaymentGB.Show();
                    CashPaymentGB.BringToFront();
                    PayInVisaGB.Hide();
                    CheckGB.Hide();
                }
                else if (aMethodRow["IsCredit"].ToString() == "1")
                {
                    PayInVisaGB.Show();
                    PayInVisaGB.BringToFront();
                    CashPaymentGB.Hide();
                    CheckGB.Hide();
                }
                else
                {
                    CheckGB.Show();
                    CheckGB.BringToFront();
                    CashPaymentGB.Hide();
                    PayInVisaGB.Hide();
                    CheckNumberTxtBox.Text = ChecksMgmt.NextCheckNumber().ToString();
                }
            }

        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddNewVendorPaymentFormName;
                AccountBalnaceLbl.Text = UiText.AddVndPytAccountBalanceLbl;
                AccountLbl.Text = UiText.AddVndPytAccountLbl;
                AddCustomerLbl.Text = UiText.AddVndPytAddCustomerLbl;
                AddPaymentBtn.Text = UiText.AddVndPytAddPaymentBtn;
                CashPaymentGB.Text = UiText.AddVndPytCashPaymentGB;
                CheckGB.Text = UiText.AddVndPytCheckGB;
                CheckHolderNameLbl.Text = UiText.AddVndPytCheckHolderNameLbl;
                CheckNumber.Text = UiText.AddVndPytCheckNumber;                
                CommentsLbl.Text = UiText.AddVndPytCommentsLbl;
                groupBox1.Text = UiText.AddVndPytgroupBox1;
                PayInVisaGB.Text = UiText.AddVndPytPayInVisaGB;
                PaymentAmountLbl.Text = UiText.AddVndPytPaymentAmountLbl;
                PaymentCommentsLbl.Text = UiText.AddVndPytPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.AddVndPytPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.AddVndPytPaymentMethodLbl;
                PaymentNumberLbl.Text = UiText.AddVndPytPaymentNumberLbl;
                VendorCompanyLbl.Text = UiText.AddVndPytVendorCompanyLbl;
                VendorNameLbl.Text = UiText.AddVndPytVendorNameLbl;
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
            IsLoading = true;
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

        private void AddPaymentandPrintBtn_Click(object sender, EventArgs e)
        {
            if (AddPayment())
            {
                print_receipt();
                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddNewTxt + "?", MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (ret == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool AddPayment()
        {
            try
            {
                semaphore = true;
                int NextCheckNumber = -1;
                double Amount = 0;
                if (VendorDoNotHaveAccount || AccountNotJOD)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n 1)" + MsgTxt.VendorTxt + "\n2)" + MsgTxt.ValidAccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    semaphore = false; return false;
                }
                else
                {
                    if (!double.TryParse(PaymentAmountTxtBox.Text, out Amount))
                    {

                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PaymentAmountTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return false;
                    }
                    else if (Amount == 0)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PaymentAmountTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return false;
                    }
                    else
                    {
                        PaymentAmountTxtBox.BackColor = PaymentAmountTxtBoxCOLOR;

                        DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        if (aMethodRow == null)
                        {
                            throw new Exception("aMethodRow==null");
                        }
                        aVendorAccountRow = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(VendorID);

                        Balance = Double.Parse(aVendorAccountRow["Amount"].ToString());

                        aVendorPayment = new VendorsPayments();
                        int PaymentNumber = VendorsPaymentsMgmt.NextPaymentNumber();
                        aVendorPayment.Vendor_Payment_PaymentNumber = PaymentNumber;
                        aVendorPayment.Vendor_Payment_VendorID = VendorID;
                        aVendorPayment.Vendor_Payment_Date = DateTime.Now.ToShortDateString();
                        aVendorPayment.Vendor_Payment_Time = DateTime.Now.ToShortTimeString();
                        int TellerID = UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName());
                        aVendorPayment.Vendor_Payment_TellerID = TellerID;
                        aVendorPayment.Vendor_Payment_OldAmount = Balance;
                        aVendorPayment.PaymentMethodID = int.Parse(PaymentMethodCheckBox.SelectedValue.ToString());
                        aVendorPayment.Vendor_Payment_Comments = CommentsTxtBox.Text;
                        aVendorPayment.MyAccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                        aVendorPayment.Vendor_Payment_Amount = double.Parse(PaymentAmountTxtBox.Text);
                        Checks aCheck = new Checks();
                        if (aMethodRow["IsCash"].ToString() == "1")
                        {
                            aVendorPayment.IsCreditCard = 0;
                            aVendorPayment.CreditCardInfo = "NOT-CREDIT";
                            VendorsPaymentsMgmt.AddVendorPayment(aVendorPayment);
                            //IS REVISED AND IS CHECKED ADDED TO ZERO IN QUERY
                            int VenAccountID = int.Parse(aVendorAccountRow["ID"].ToString());
                            double NewAmount = Balance - aVendorPayment.Vendor_Payment_Amount;
                            VendorsAccountsMgmt.UpdateAccountAmountByAccountID(VenAccountID, NewAmount);
                            double MyOldAmount = AccountsMgmt.SelectAccountAmountByID(int.Parse(AccountComboBox.SelectedValue.ToString()));
                            AccountsMgmt.UpdateAccountAmountByAccountID(int.Parse(AccountComboBox.SelectedValue.ToString()), MyOldAmount - aVendorPayment.Vendor_Payment_Amount);
                        }
                        else if (aMethodRow["IsCredit"].ToString() == "1")
                        {
                            aVendorPayment.IsCreditCard = 1;
                            aVendorPayment.CreditCardInfo = CreditCardInfoTxtBox.Text;
                            VendorsPaymentsMgmt.AddVendorPayment(aVendorPayment);
                            //IS REVISED AND IS CHECKED ADDED TO ZERO IN QUERY
                            int VenAccountID = int.Parse(aVendorAccountRow["ID"].ToString());
                            double NewAmount = Balance - aVendorPayment.Vendor_Payment_Amount;
                            VendorsAccountsMgmt.UpdateAccountAmountByAccountID(VenAccountID, NewAmount);
                            int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                            DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                            double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                            double NewAmount2 = OldAmount - aVendorPayment.Vendor_Payment_Amount;
                            AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount2);

                        }
                        else
                        {
                            aVendorPayment.IsCreditCard = 0;
                            aVendorPayment.CreditCardInfo = "NOT-CREDIT";
                            NextCheckNumber = ChecksMgmt.NextCheckNumber();
                            aVendorPayment.CheckNumber = NextCheckNumber;
                            VendorsPaymentsMgmt.AddVendorPayment(aVendorPayment);

                            aCheck.Chekcs_HolderName = HolderNameTxtBox.Text;
                            aCheck.Chekcs_PaymentDate = CheckDatePicker.Value.ToShortDateString();
                            aCheck.Chekcs_IsBill = 0;
                            aCheck.Chekcs_IsPurchaseVoucher = 0;
                            aCheck.Chekcs_AccountID = 0;
                            aCheck.Chekcs_Comments = CheckCommentsTxtBox.Text;
                            aCheck.Chekcs_Amount = aVendorPayment.Vendor_Payment_Amount;
                            aCheck.Chekcs_IsPaid = 0;
                            aCheck.CheckNumber = NextCheckNumber;
                            aCheck.AddingDate = DateTime.Now.ToShortDateString();
                            aCheck.Chekcs_PaymentDate = CheckDatePicker.Text;
                            aCheck.Chekcs_IsVendorPayment = 1;
                            aCheck.Chekcs_VendorPaymentNumber = aVendorPayment.Vendor_Payment_PaymentNumber;
                            aCheck.Chekcs_IsCustomerPayment = 0;

                            if (!ChecksMgmt.InsertCheck(aCheck))
                            {
                                VendorsPaymentsMgmt.DeleteVendorPayment(aVendorPayment);
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error: CANNOT ADD CHECK] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                //ReloadForm();
                                return false;
                            }
                        }
                        MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        semaphore = false;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddPaymentBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
            }
        }

        private bool print_receipt()
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]" + ReceiptText.RctTxtToPayAmount);
                aDataTable1.Columns.Add(PaymentAmountTxtBox.Text);

                aDataTable1.Rows.Add();
                aDataTable1.Rows[0][0] = ReceiptText.RctTxtPayMethod;
                aDataTable1.Rows[0][1] = PaymentMethodCheckBox.Text;
                aDataTable1.Rows.Add();
                double OldVendorAccountAmountParser = 0;
                if (double.TryParse(VendorAccountBalanceTxtBox.Text, out OldVendorAccountAmountParser))
                {
                    aDataTable1.Rows[1][0] = ReceiptText.RctTxtOldBalance;
                    aDataTable1.Rows[1][1] = OldVendorAccountAmountParser;
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[2][0] = ReceiptText.RctTxtNewBalance;
                    aDataTable1.Rows[2][1] = OldVendorAccountAmountParser - double.Parse(PaymentAmountTxtBox.Text);
                }

                aDataTableList.Add(aDataTable1);
                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsVendorPay);
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                aStringList.Add(ReceiptText.RctTxtVendor + ":&nbsp;&nbsp;" + VendorNameComboBox.Text);
                aStringList.Add(ReceiptText.RctTxtPaymentNum + ":&nbsp; " + PaymentNumberTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
              //  PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf", false, "", false, PrintingThermalA4ChkBox.Checked);
                if (PrintingThermalA4ChkBox.Checked)
                {
                    Process.Start(ReportsHelper.TempPDFOutputPath);

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[AddVendorPayment:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
