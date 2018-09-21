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
using Calcium_RMS.Reports;
namespace Calcium_RMS
{
    public partial class EditVendorPayments : Form
    {
        DataRow aVendorPaymentRowGlobal = null;
        DataRow aVendorAccount;
        DataRow aAccount;
        public EditVendorPayments()
        {
            InitializeComponent();
            TranslateUI();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
        }

        private void EditVendorPayments_Load(object sender, EventArgs e)
        {
            CurrentUserLbl.Text = SharedFunctions.ReturnLoggedUserName();
        }

        public void UpdateVariables(DataRow aVendorPaymentRow)
        {
            try
            {
                PaymentNumberTxtBox.Text = aVendorPaymentRow["PaymentNumber"].ToString();
                aVendorPaymentRowGlobal = aVendorPaymentRow;
                DateLbl.Text = DateTime.Parse(aVendorPaymentRow["Date"].ToString()).ToShortDateString();
                TimeLbl.Text = aVendorPaymentRow["Time"].ToString();
                TellerLbl.Text = UsersMgmt.SelectUserNameByID(int.Parse(aVendorPaymentRow["TellerID"].ToString()));

                DataRow aVendorRow = VendorsMgmt.SelectVendorRowByID(int.Parse(aVendorPaymentRow["VendorID"].ToString()));
                if (aVendorRow == null)
                {
                    throw new Exception("LOWER in aVendorRow==null");
                }
                VendorNameTxtBox.Text = aVendorRow["Name"].ToString();
                VendorCompanyTxtBox.Text = aVendorRow["Company"].ToString();
                double OldBalance = double.Parse(aVendorPaymentRow["OldVendorAccountAmount"].ToString());
                double Amount = double.Parse(aVendorPaymentRow["Amount"].ToString());
                double NewBalance = OldBalance - Amount;//+ because its reversed
                VendorAccountBalanceTxtBox.Text = OldBalance.ToString();
                NewBalanceTxtBox.Text = NewBalance.ToString();

                aAccount = AccountsMgmt.SelectAccountRowByID(int.Parse(aVendorPaymentRow["MyAccountID"].ToString()));
                if (aAccount == null)
                {
                    throw new Exception("LOWER in aAccount == null");
                }
                AccountDescriptionTxtBox.Text = aAccount["Description"].ToString();

                aVendorAccount = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(int.Parse(aVendorPaymentRow["VendorID"].ToString()));
                if (aVendorAccount == null)
                {
                    throw new Exception("LOWER in aVendorAccount == null");
                }
                CurrentBalanceTxtBox.Text = double.Parse(aVendorAccount["Amount"].ToString()).ToString();
                PaymentAmountTxtBox.Text = Amount.ToString();
                CommentsTxtBox.Text = aVendorPaymentRow["Comments"].ToString();
                if (aVendorPaymentRow["IsRevised"].ToString() == "1")
                {
                    ReviseInfoGB.Show();
                    ReviseDatelbl.Text = DateTime.Parse(aVendorPaymentRow["ReviseDate"].ToString()).ToShortDateString();
                    ReviseTime.Text = aVendorPaymentRow["ReviseTime"].ToString();
                    RevisedBylbl.Text = aVendorPaymentRow["RevisedBy"].ToString();
                    IsRevisedLbl.Visible = true;
                }
                else
                {
                    ReviseInfoGB.Hide();
                }

                if (aVendorPaymentRow["IsChecked"].ToString() == "1")
                {
                    ChkedByUserNameLbl.Text = aVendorPaymentRow["CheckedBy"].ToString();
                    ChkDateLbl.Text = DateTime.Parse(aVendorPaymentRow["CheckDate"].ToString()).ToShortDateString();
                    CheckTime.Text = aVendorPaymentRow["CheckTime"].ToString();
                    CheckInfoGB.Show();
                }
                else
                {
                    CheckInfoGB.Hide();
                }

                //PaymentInformation
                DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aVendorPaymentRow["PaymentMethodID"].ToString()));
                if (aMethodRow == null)
                {
                    throw new Exception("LOWER in aMethodRow == null");
                }
                PaymentMethodCheckBox.Text = aMethodRow["Name"].ToString();
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
                    CheckNumberTxtBox.Text = aVendorPaymentRow["CheckNumber"].ToString();
                    DataRow aCheckDataRow = ChecksMgmt.SelectCheckRowByNumber(int.Parse(aVendorPaymentRow["CheckNumber"].ToString()));
                    if (aCheckDataRow == null)
                    {
                        throw new Exception("LOWER in aCheckDataRow == null");
                    }
                    HolderNameTxtBox.Text = aCheckDataRow["HolderName"].ToString();
                    CheckCommentsTxtBox.Text = aCheckDataRow["Comments"].ToString();
                    CheckDatePicker.Text = DateTime.Parse(aCheckDataRow["PaymentDate"].ToString()).ToShortDateString();

                }
                DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(aVendorPaymentRow["MyAccountID"].ToString()));
                if (aAccountRow == null)
                {
                    throw new Exception("LOWER in aAccountRow == null");
                }
                AccountComboBox.Text = aAccountRow["Name"].ToString();
                AccountDescriptionTxtBox.Text = aAccountRow["Description"].ToString();
                CreditCardInfoTxtBox.Text = aVendorPaymentRow["CreditCardInfo"].ToString();
                AccountBalanceTxtBox.Text = aAccountRow["Amount"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EDIT Vendor Payment: UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void CheckPaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aVendorPaymentRowGlobal["IsChecked"].ToString() == "0")
                {
                    string CheckedBy = SharedFunctions.ReturnLoggedUserName();
                    string ChkDate = DateTime.Now.ToShortDateString();
                    string ChkTime = DateTime.Now.ToShortTimeString();
                    int PaymentNumber = int.Parse(aVendorPaymentRowGlobal["PaymentNumber"].ToString());
                    if (!VendorsPaymentsMgmt.UpdatePaymentToChecked(CheckedBy, ChkDate, ChkTime, PaymentNumber))
                    {
                        throw new Exception(" IN [DB-ERROR-EditVendorPayment-CheckPaymentBtn_Click] ");
                    }
                    MessageBox.Show(MsgTxt.CheckedSuccesfullyTxt, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(MsgTxt.AlreadyCheckedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVendorPayment-CheckPaymentBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void RevisePaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aVendorPaymentRowGlobal["IsRevised"].ToString() == "0")
                {
                    string RevisedBy = SharedFunctions.ReturnLoggedUserName();
                    string ReviseDate = DateTime.Now.ToShortDateString();
                    string ReviseTime = DateTime.Now.ToShortTimeString();
                    int PaymentNumber = int.Parse(aVendorPaymentRowGlobal["PaymentNumber"].ToString());
                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aVendorPaymentRowGlobal["PaymentMethodID"].ToString()));
                    if (aMethodRow == null)
                    {
                        // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectMethodRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("EditVendorPayment-aMethodRow Returned Null");
                    }

                    if (!VendorsPaymentsMgmt.UpdatePaymentToRevised(RevisedBy, ReviseDate, ReviseTime, PaymentNumber))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditVendorPayment-UpdatePaymentToRevised-FUNC:UpdatePaymentToRevised] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    if (aMethodRow["IsCheck"].ToString() == "1")
                    {
                        ChecksMgmt.MakeCheckRevised(int.Parse(aVendorPaymentRowGlobal["CheckNumber"].ToString()), DateTime.Now.ToShortDateString());
                    }
                    double Amount = double.Parse(aVendorPaymentRowGlobal["Amount"].ToString());
                    double CurrentAmount = double.Parse(aVendorAccount["Amount"].ToString());
                    int AccountID = int.Parse(aVendorAccount["ID"].ToString());
                    double NewAmount = CurrentAmount + Amount;
                    VendorsAccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    double MyOldAccountAmount = double.Parse(aAccount["Amount"].ToString());
                    double MyNewAccountAmount = MyOldAccountAmount + Amount;
                    int MyAccountID = int.Parse(aAccount["ID"].ToString());
                    if (!AccountsMgmt.UpdateAccountAmountByAccountID(MyAccountID, MyNewAccountAmount))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditcustomerPayment-RevisePaymentBtn_Click-FUNC:UpdateAccountAmountByAccountID] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    MessageBox.Show(MsgTxt.ReversedSuccessfullyTxt, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show(MsgTxt.AlreadyReversedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVendorPayment-RevisePaymentBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditVendorPaymentFormName;

                AccountBalanceLbl.Text = UiText.EdtVndPytAccountBalanceLbl;
                AccountBalnaceLbl.Text = UiText.EdtVndPytAccountBalnaceLbl;
                AccountLbl.Text = UiText.EdtVndPytAccountLbl;
                AddCustomerLbl.Text = UiText.EdtVndPytAddCustomerLbl;
                CashPaymentGB.Text = UiText.EdtVndPytCashPaymentGB;
                CheckCommentsLbl.Text = UiText.EdtVndPytCheckCommentsLbl;
                CheckGB.Text = UiText.EdtVndPytCheckGB;
                CheckHolderNameLbl.Text = UiText.EdtVndPytCheckHolderNameLbl;
                CheckInfoGB.Text = UiText.EdtVndPytCheckInfoGB;
                CheckNumber.Text = UiText.EdtVndPytCheckNumber;
                CheckPaymentBtn.Text = UiText.EdtVndPytCheckPaymentBtn;
                CheckTime.Text = UiText.EdtVndPytCheckTime;
                CheckTimeLbl.Text = UiText.EdtVndPytCheckTimeLbl;
                ChkDate.Text = UiText.EdtVndPytChkDate;
                ChkDateLbl.Text = UiText.EdtVndPytChkDateLbl;
                ChkedBy.Text = UiText.EdtVndPytChkedBy;
                ChkedByUserNameLbl.Text = UiText.EdtVndPytChkedByUserNameLbl;
                CommentsLbl.Text = UiText.EdtVndPytCommentsLbl;
                CurrentBalanceLbl.Text = UiText.EdtVndPytCurrentBalanceLbl;
                CurrentUser.Text = UiText.EdtVndPytCurrentUser;
                CurrentUserLbl.Text = UiText.EdtVndPytCurrentUserLbl;
                DateLbl.Text = UiText.EdtVndPytDateLbl;
                EditCustomerPaymentLbl.Text = UiText.EdtVndPytEditCustomerPaymentLbl;
                groupBox1.Text = UiText.EdtVndPytgroupBox1;
                NewBalanceLbl.Text = UiText.EdtVndPytNewBalanceLbl;
                PayInVisaGB.Text = UiText.EdtVndPytPayInVisaGB;
                PaymentAmountLbl.Text = UiText.EdtVndPytPaymentAmountLbl;
                PaymentCommentsLbl.Text = UiText.EdtVndPytPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.EdtVndPytPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.EdtVndPytPaymentMethodLbl;
                PaymentNumberLbl.Text = UiText.EdtVndPytPaymentNumberLbl;
                ReviseDate.Text = UiText.EdtVndPytReviseDate;
                ReviseDatelbl.Text = UiText.EdtVndPytReviseDatelbl;
                RevisedBy.Text = UiText.EdtVndPytRevisedBy;
                RevisedBylbl.Text = UiText.EdtVndPytRevisedBylbl;
                ReviseInfoGB.Text = UiText.EdtVndPytReviseInfoGB;
                RevisePaymentBtn.Text = UiText.EdtVndPytRevisePaymentBtn;
                ReviseTime.Text = UiText.EdtVndPytReviseTime;
                ReviseTimeLbl.Text = UiText.EdtVndPytReviseTimeLbl;
                TellerLbl.Text = UiText.EdtVndPytTellerLbl;
                TimeLbl.Text = UiText.EdtVndPytTimeLbl;
                VendorCompanyLbl.Text = UiText.EdtVndPytVendorCompanyLbl;
                VendorNameLbl.Text = UiText.EdtVndPytVendorNameLbl;
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
                    if (double.TryParse(CurrentBalanceTxtBox.Text, out OldVendorAccountAmountParser))
                    {
                        aDataTable1.Rows.Add();
                        aDataTable1.Rows[3][0] = ReceiptText.RctTxtCurrenctBalance;
                        aDataTable1.Rows[3][1] = OldVendorAccountAmountParser.ToString();
                    }
                }

                aDataTableList.Add(aDataTable1);
                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsVendorPay);
                aStringList.Add(ReceiptText.RctTxtDuplicate);

                if (aVendorPaymentRowGlobal["IsRevised"].ToString() == "1")
                {
                    aStringList.Add("*** " + ReceiptText.RctTxtReversed + " ***");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedBy + ":&nbsp;&nbsp;" + RevisedBylbl.Text + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedOn + ":&nbsp;&nbsp;" + ReviseDatelbl.Text + "</h2>");
                }

                aStringList.Add("<h2>" + ReceiptText.RctTxtOrgDate + "/" + ReceiptText.RctTxtOrgTime + " " + DateLbl.Text + "&nbsp;&nbsp;" + TimeLbl.Text + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtOrgTeller + ":&nbsp;&nbsp;" + TellerLbl.Text + "</h2>");
                aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");


                aStringList.Add(ReceiptText.RctTxtVendor + ":&nbsp;&nbsp;" + VendorNameTxtBox.Text);
                aStringList.Add(ReceiptText.RctTxtPaymentNum + ":&nbsp; " + PaymentNumberTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[EditVendorPayment:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReprintBtn_Click(object sender, EventArgs e)
        {
            print_receipt();
        }

    }
}
