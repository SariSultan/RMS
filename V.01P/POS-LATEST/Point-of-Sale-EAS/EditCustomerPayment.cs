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
    public partial class EditCustomerPayment : Form
    {
        DataRow aCustomerPaymentRowGlobal;

        DataRow aCustomerAccount;
        public EditCustomerPayment()
        {
            InitializeComponent();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            this.StartPosition = FormStartPosition.CenterScreen;

            TranslateUI();
        }

        private void EditCustomerPayment_Load(object sender, EventArgs e)
        {
            try
            {
                CurrentUserLbl.Text = SharedFunctions.ReturnLoggedUserName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditCustomerPayment_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void UpdateVariables(DataRow aCustomerPaymentRow)
        {
            try
            {
                PaymentNumberTxtBox.Text = aCustomerPaymentRow["PaymentNumber"].ToString();
                aCustomerPaymentRowGlobal = aCustomerPaymentRow;

                DateLbl.Text = DateTime.Parse(aCustomerPaymentRow["Date"].ToString()).ToShortDateString();
                TimeLbl.Text = aCustomerPaymentRow["Time"].ToString();
                TellerLbl.Text = UsersMgmt.SelectUserNameByID(int.Parse(aCustomerPaymentRow["TellerID"].ToString()));
                if (TellerLbl.Text == null)
                {
                    //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-UsersMgmt.UsrById Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("[EditCustomerPayment-UsersMgmt.UsrById Returned Null]");
                }

                DataRow aCustomerRow = CustomerMgmt.SelectCustomerRowByID(int.Parse(aCustomerPaymentRow["CustomerID"].ToString()));
                if (aCustomerRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCustomerRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditCustomerPayment-SelectCustomerRowByID Returned Null");
                }

                CustomerPhoneTxtBox.Text = aCustomerRow["Phone1"].ToString();
                CustomerNameTxtBox.Text = aCustomerRow["Name"].ToString();
                double OldBalance = double.Parse(aCustomerPaymentRow["OldUsrAccountAmount"].ToString());
                double Amount = double.Parse(aCustomerPaymentRow["Amount"].ToString());
                double NewBalance = OldBalance - Amount;

                CustomerBalanceTxtBox.Text = OldBalance.ToString();
                NewBalanceTxtBox.Text = NewBalance.ToString();

                aCustomerAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(int.Parse(aCustomerPaymentRow["CustomerID"].ToString()));
                if (aCustomerAccount == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCustomerRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditCustomerPayment-SelectCustomerAccountRowByCusID Returned Null");
                }
                CurrentBalanceTxtBox.Text = double.Parse(aCustomerAccount["Amount"].ToString()).ToString();

                PaymentAmountTxtBox.Text = Amount.ToString();
                CommentsTxtBox.Text = aCustomerPaymentRow["Comments"].ToString();

                if (aCustomerPaymentRow["IsRevised"].ToString() == "1")
                {
                    ReviseInfoGB.Show();
                    ReviseDatelbl.Text = DateTime.Parse(aCustomerPaymentRow["ReviseDate"].ToString()).ToShortDateString();
                    ReviseTime.Text = aCustomerPaymentRow["ReviseTime"].ToString();
                    RevisedBylbl.Text = aCustomerPaymentRow["RevisedBy"].ToString();
                    IsRevisedLbl.Visible = true;
                }
                else
                {
                    ReviseInfoGB.Hide();
                }

                if (aCustomerPaymentRow["IsChecked"].ToString() == "1")
                {
                    ChkedByUserNameLbl.Text = aCustomerPaymentRow["CheckedBy"].ToString();
                    ChkDateLbl.Text = DateTime.Parse(aCustomerPaymentRow["CheckDate"].ToString()).ToShortDateString();
                    CheckTime.Text = aCustomerPaymentRow["CheckTime"].ToString();
                    CheckInfoGB.Show();
                }
                else
                {
                    CheckInfoGB.Hide();
                }

                //PaymentInformation
                DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aCustomerPaymentRow["PaymentMethodID"].ToString()));
                if (aMethodRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectMethodRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditCustomerPayment-SelectMethodRowByID Returned Null");
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
                    CheckNumberTxtBox.Text = aCustomerPaymentRow["CheckNumber"].ToString();
                    DataRow aCheckDataRow = ChecksMgmt.SelectCheckRowByNumber(int.Parse(aCustomerPaymentRow["CheckNumber"].ToString()));
                    if (aCheckDataRow == null)
                    {
                        //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCheckRowByNumber Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("EditCustomerPayment-SelectCheckRowByNumber Returned Null");
                    }
                    HolderNameTxtBox.Text = aCheckDataRow["HolderName"].ToString();
                    BanksComboBox.Text = aCheckDataRow["BankName"].ToString();
                    CheckCommentsTxtBox.Text = aCheckDataRow["Comments"].ToString();
                    CheckDatePicker.Text = aCheckDataRow["PaymentDate"].ToString();
                }

                DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(aCustomerPaymentRow["AccountID"].ToString()));
                if (aAccountRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectAccountRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditCustomerPayment-SelectAccountRowByID Returned Null");
                }
                else
                {
                    AccountComboBox.Text = aAccountRow["Name"].ToString();
                    AccountDescriptionTxtBox.Text = aAccountRow["Description"].ToString();
                    CreditCardInfoTxtBox.Text = aCustomerPaymentRow["CreditCardInfo"].ToString();
                    AccountBalanceTxtBox.Text = aAccountRow["Amount"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditCustomerPayment-UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void CheckPaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aCustomerPaymentRowGlobal["IsChecked"].ToString() == "0")
                {
                    string CheckedBy = SharedFunctions.ReturnLoggedUserName();
                    string ChkDate = DateTime.Now.ToShortDateString();
                    string ChkTime = DateTime.Now.ToShortTimeString();
                    int PaymentNumber = int.Parse(aCustomerPaymentRowGlobal["PaymentNumber"].ToString());
                    if (!CustomersPaymentsMgmt.UpdatePaymentToChecked(CheckedBy, ChkDate, ChkTime, PaymentNumber))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditcustomerPayment-CheckPaymentBtn_Click] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.CheckedSuccesfullyTxt, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.AlreadyCheckedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditcustomerPayment-ChkBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void RevisePaymentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aCustomerPaymentRowGlobal["IsRevised"].ToString() == "0")
                {
                    string RevisedBy = SharedFunctions.ReturnLoggedUserName();
                    string ReviseDate = DateTime.Now.ToShortDateString();
                    string ReviseTime = DateTime.Now.ToShortTimeString();
                    int PaymentNumber = int.Parse(aCustomerPaymentRowGlobal["PaymentNumber"].ToString());
                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aCustomerPaymentRowGlobal["PaymentMethodID"].ToString()));
                    if (aMethodRow == null)
                    {
                        // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectMethodRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("EditCustomerPayment-SelectMethodRowByID Returned Null");
                    }
                    if (!CustomersPaymentsMgmt.UpdatePaymentToRevised(RevisedBy, ReviseDate, ReviseTime, PaymentNumber))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditcustomerPayment-RevisePaymentBtn_Click-FUNC:UpdatePaymentToRevised] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    if (aMethodRow["IsCheck"].ToString() == "1")
                    {
                        ChecksMgmt.MakeCheckRevised(int.Parse(aCustomerPaymentRowGlobal["CheckNumber"].ToString()), DateTime.Now.ToShortDateString());
                    }

                   

                    double Amount = double.Parse(aCustomerPaymentRowGlobal["Amount"].ToString());
                    double CurrentAmount = double.Parse(aCustomerAccount["Amount"].ToString());
                    int AccountID = int.Parse(aCustomerAccount["ID"].ToString());
                    double NewAmount = CurrentAmount + Amount;

                    if (!CustomersAccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditcustomerPayment-RevisePaymentBtn_Click-FUNC:UpdateAccountAmountByAccountID] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        //int.Parse(AccountComboBox.SelectedValue.ToString());
                        int MyAccountID = int.Parse(aCustomerPaymentRowGlobal["AccountID"].ToString());
                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(MyAccountID);
                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                        double MyNewAmount = OldAmount - Amount;
                        AccountsMgmt.UpdateAccountAmountByAccountID(MyAccountID, MyNewAmount);
                    }

                    //Mark the check (if any) as revised
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditcustomerPayment-RevisePaymentBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditCustomerPaymentFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
               // this.RightToLeftLayout = true;
                AccountBalanceLbl.Text = UiText.EdtCstPytAccountBalanceLbl;
                AccountLbl.Text = UiText.EdtCstPytAccountLbl;
                AddCustomerLbl.Text = UiText.EdtCstPytAddCustomerLbl;
                BankLbl.Text = UiText.EdtCstPytBankLbl;
                CashPaymentGB.Text = UiText.EdtCstPytCashPaymentGB;
                CheckCommentsLbl.Text = UiText.EdtCstPytCheckCommentsLbl;
                CheckGB.Text = UiText.EdtCstPytCheckGB;
                CheckHolderNameLbl.Text = UiText.EdtCstPytCheckHolderNameLbl;
                CheckInfoGB.Text = UiText.EdtCstPytCheckInfoGB;
                CheckNumber.Text = UiText.EdtCstPytCheckNumber;
                CheckPaymentBtn.Text = UiText.EdtCstPytCheckPaymentBtn;
                CheckTime.Text = UiText.EdtCstPytCheckTime;
                ChkDate.Text = UiText.EdtCstPytChkDate;
                ChkDateLbl.Text = UiText.EdtCstPytChkDateLbl;
                ChkedBy.Text = UiText.EdtCstPytChkedBy;
                ChkedByUserNameLbl.Text = UiText.EdtCstPytChkedByUserNameLbl;
                CheckTimeLbl.Text = UiText.EdtCstPytCkeckTimeLbl;
                CommentsLbl.Text = UiText.EdtCstPytCommentsLbl;
                CurrentBalanceLbl.Text = UiText.EdtCstPytCurrentBalanceLbl;
                CurrentUser.Text = UiText.EdtCstPytCurrentUser;
                CurrentUserLbl.Text = UiText.EdtCstPytCurrentUserLbl;
                CustomerNameLbl.Text = UiText.EdtCstPytCustomerNameLbl;
                CustomerPhoneLbl.Text = UiText.EdtCstPytCustomerPhoneLbl;
                DateLbl.Text = UiText.EdtCstPytDateLbl;
                groupBox1.Text = UiText.EdtCstPytgroupBox1;
                NewBalanceLbl.Text = UiText.EdtCstPytNewBalanceLbl;
                PayInVisaGB.Text = UiText.EdtCstPytPayInVisaGB;
                PaymentAmountLbl.Text = UiText.EdtCstPytPaymentAmountLbl;
                PaymentCommentsLbl.Text = UiText.EdtCstPytPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.EdtCstPytPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.EdtCstPytPaymentMethodLbl;
                PaymentNumberLbl.Text = UiText.EdtCstPytPaymentNumberLbl;
                ReviseDate.Text = UiText.EdtCstPytReviseDate;
                ReviseDatelbl.Text = UiText.EdtCstPytReviseDatelbl;
                RevisedBy.Text = UiText.EdtCstPytRevisedBy;
                RevisedBylbl.Text = UiText.EdtCstPytRevisedBylbl;
                ReviseInfoGB.Text = UiText.EdtCstPytReviseInfoGB;
                RevisePaymentBtn.Text = UiText.EdtCstPytRevisePaymentBtn;
                ReviseTime.Text = UiText.EdtCstPytReviseTime;
                ReviseTimeLbl.Text = UiText.EdtCstPytReviseTimeLbl;
                TellerLbl.Text = UiText.EdtCstPytTellerLbl;
                TimeLbl.Text = UiText.EdtCstPytTimeLbl;
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
        //To Make Size Always Normal For Non-Grid Forms

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
                double OldCustomerAccountAmountParser = 0;
                if (double.TryParse(CustomerBalanceTxtBox.Text, out OldCustomerAccountAmountParser))
                {
                    aDataTable1.Rows[1][0] = ReceiptText.RctTxtOldBalance;
                    aDataTable1.Rows[1][1] = OldCustomerAccountAmountParser;
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[2][0] = ReceiptText.RctTxtNewBalance;
                    aDataTable1.Rows[2][1] = OldCustomerAccountAmountParser + double.Parse(PaymentAmountTxtBox.Text);
                    if (double.TryParse( CurrentBalanceTxtBox.Text,out OldCustomerAccountAmountParser))
                    {
                         aDataTable1.Rows.Add();
                    aDataTable1.Rows[3][0] = ReceiptText.RctTxtCurrenctBalance;
                    aDataTable1.Rows[3][1] = OldCustomerAccountAmountParser.ToString();
                    }
                }

                aDataTableList.Add(aDataTable1);
                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsCustomerPay);
                aStringList.Add(ReceiptText.RctTxtDuplicate);

                if (aCustomerPaymentRowGlobal["IsRevised"].ToString() == "1")
                {
                    aStringList.Add("*** " + ReceiptText.RctTxtReversed + " ***");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedBy + ":&nbsp;&nbsp;" + RevisedBylbl.Text + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedOn + ":&nbsp;&nbsp;" + ReviseDatelbl.Text + "</h2>");
                }

                aStringList.Add("<h2>" + ReceiptText.RctTxtOrgDate + "/" + ReceiptText.RctTxtOrgTime + " " + DateLbl.Text + "&nbsp;&nbsp;" + TimeLbl.Text + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtOrgTeller + ":&nbsp;&nbsp;" + TellerLbl.Text + "</h2>");
                aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

               
                aStringList.Add(ReceiptText.RctTxtCustomer + ":&nbsp;&nbsp;" + CustomerNameTxtBox.Text);
                aStringList.Add(ReceiptText.RctTxtPaymentNum + ":&nbsp; " + PaymentNumberTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[EditCustomerPayment:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReprintBtn_Click(object sender, EventArgs e)
        {
            print_receipt();
        }


    }
}
