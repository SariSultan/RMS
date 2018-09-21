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

namespace Calcium_RMS
{
    public partial class EditBill : Form
    {
        DataRow aBillGeneralRow;
        DataRow aUserDataRow;

        int RowNum = 0;
        public EditBill()
        {

            InitializeComponent();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            this.StartPosition = FormStartPosition.CenterScreen;

            TeldgView.Columns["Barcode"].ReadOnly = true;
            TeldgView.Columns["Description"].ReadOnly = true;
            TeldgView.Columns["Qty"].ReadOnly = true;
            TeldgView.Columns["PricePerUnit"].ReadOnly = true;
            TeldgView.Columns["PriceTotal"].ReadOnly = true;
            TeldgView.Columns["Tax"].ReadOnly = true;
            TeldgView.Columns["AvalQty"].ReadOnly = true;

            

            TranslateUI();
        }

        public void AddDgView(DataTable aBillDataTable)
        {
            try
            {
                foreach (DataRow r in aBillDataTable.Rows)
                {
                    RowNum = TeldgView.Rows.Add();
                    TeldgView.Rows[RowNum].Cells["Barcode"].Value = ItemsMgmt.SelectItemBarcodeByID(int.Parse(aBillDataTable.Rows[RowNum]["ItemID"].ToString()));
                    TeldgView.Rows[RowNum].Cells["Description"].Value = aBillDataTable.Rows[RowNum]["ItemDescription"].ToString();
                    TeldgView.Rows[RowNum].Cells["Qty"].Value = aBillDataTable.Rows[RowNum]["Qty"].ToString();
                    TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aBillDataTable.Rows[RowNum]["SellPrice"].ToString();
                    TeldgView.Rows[RowNum].Cells["PriceTotal"].Value = double.Parse(aBillDataTable.Rows[RowNum]["TotalPerUnit"].ToString());
                    TeldgView.Rows[RowNum].Cells["Tax"].Value = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(ItemsMgmt.SelectTaxLevelIDByID(int.Parse(aBillDataTable.Rows[RowNum]["ItemID"].ToString())))).ToString();
                    TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aBillDataTable.Rows[RowNum]["OldAvaQty"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-AddDgView] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void UpdateVariables(DataRow aGeneralBillDataRow)
        {
            try
            {
                aBillGeneralRow = aGeneralBillDataRow;

                InvoiceNumTxtBox.Text = aGeneralBillDataRow["Number"].ToString();

                DateLbl.Text = DateTime.Parse(aGeneralBillDataRow["Date"].ToString()).ToShortDateString();

                TimeLbl.Text = aGeneralBillDataRow["BillTime"].ToString();

                TellerLbl.Text = UsersMgmt.SelectUserNameByID(int.Parse(aGeneralBillDataRow["TellerID"].ToString()));
                if (TellerLbl.Text == null)
                {
                    //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-UsersMgmt.UsrById Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("[EditBill-UsersMgmt.UsrById Returned Null]");
                }
                aUserDataRow = CustomerMgmt.SelectCustomerRowByID(int.Parse(aGeneralBillDataRow["CustomerID"].ToString()));
                if (aUserDataRow == null)
                {
                   // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCustomerRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditBill-SelectCustomerRowByID Returned Null");
                }
                PriceLevelComboBox.Text = PriceLevelsMgmt.SelectPriceLevelNameByID(int.Parse(aGeneralBillDataRow["PriceLevelID"].ToString()));
                if (PriceLevelComboBox.Text == null)
                {
                    //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectPriceLevelNameByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditBill-SelectPriceLevelNameByID Returned Null");
                }
                PhoneTxtBox.Text = aUserDataRow["Phone1"].ToString();
                CustomerNameTxtBox.Text = aUserDataRow["Name"].ToString();
                CommentsTxtBox.Text = aGeneralBillDataRow["Comments"].ToString();
                PriceLevelDiscount.Text = aGeneralBillDataRow["SalesDiscount"].ToString();
                DiscountPercTxtBox.Text = aGeneralBillDataRow["DiscountPerc"].ToString();
                SubtotalTxtBox.Text = aGeneralBillDataRow["Subtotal"].ToString();
                NetAmountTxtBox.Text = aGeneralBillDataRow["NetAmount"].ToString();
                TaxTxtBox.Text = aGeneralBillDataRow["TotalTax"].ToString();
                DiscountBillTxtBox.Text = (double.Parse(DiscountPercTxtBox.Text) / 100 * double.Parse(NetAmountTxtBox.Text)).ToString();

                TotalDiscountTxtBox.Text = aGeneralBillDataRow["TotalDiscount"].ToString();
                TotalTxtBox.Text = aGeneralBillDataRow["TotalPrice"].ToString();

                if (aGeneralBillDataRow["IsRevised"].ToString() == "1")
                {
                    ReviseInfoGB.Show();
                    ReviseDatelbl.Text = DateTime.Parse(aGeneralBillDataRow["ReviseDate"].ToString()).ToShortDateString();
                    RevisedBylbl.Text = aGeneralBillDataRow["RevisedBy"].ToString();
                    IsRevisedLbl.Visible = true;
                    ReviseLossProfitLbl.Text = aGeneralBillDataRow["ReviseLoss"].ToString();
                }
                else
                {
                    ReviseInfoGB.Hide();
                }

                if (aGeneralBillDataRow["IsChecked"].ToString() == "1")
                {
                    ChkedByUserNameLbl.Text = aGeneralBillDataRow["CheckedBy"].ToString();
                    ChkDateLbl.Text = DateTime.Parse(aGeneralBillDataRow["CheckedDate"].ToString()).ToShortDateString();
                    CheckInfoGB.Show();
                }
                else
                {
                    CheckInfoGB.Hide();
                }

                //PaymentInformation
                DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aGeneralBillDataRow["PaymentMethodID"].ToString()));
                if (aMethodRow == null)
                {
                   // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectMethodRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditBill-SelectMethodRowByID Returned Null");
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
                    CheckNumberTxtBox.Text = aGeneralBillDataRow["CheckNumber"].ToString();

                    DataRow aCheckDataRow = ChecksMgmt.SelectCheckRowByNumber(int.Parse(aGeneralBillDataRow["CheckNumber"].ToString()));
                    if (aCheckDataRow == null)
                    {
                        //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCheckRowByNumber Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("EditBill-SelectCheckRowByNumber Returned Null");
                    }

                    HolderNameTxtBox.Text = aCheckDataRow["HolderName"].ToString();
                    CheckCommentsTxtBox.Text = aCheckDataRow["Comments"].ToString();
                    CheckDatePicker.Text = aCheckDataRow["PaymentDate"].ToString();


                }

                DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(aGeneralBillDataRow["AccountID"].ToString()));
                if (aAccountRow == null)
                {
                   // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectAccountRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditBill-SelectAccountRowByID Returned Null");
                }
                else
                {
                    AccountComboBox.Text = aAccountRow["Name"].ToString();
                    AccountDescriptionTxtBox.Text = aAccountRow["Description"].ToString();

                    CurrencyComboBox.Text = CurrencyMgmt.SelectCurrencyNameByID(int.Parse(aGeneralBillDataRow["CurrencyID"].ToString()));
                    if (CurrencyComboBox.Text == null)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCurrencyNameByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    CashInCurrency.Text = CurrencyComboBox.Text;
                    CashInTxtBox.Text = aGeneralBillDataRow["CashIn"].ToString();
                    BuyRateTxtBox.Text = CurrencyMgmt.SelectBuyRateByID(int.Parse(aGeneralBillDataRow["CurrencyID"].ToString())).ToString();
                    SellRateTxtBox.Text = CurrencyMgmt.SelectSellRateByID(int.Parse(aGeneralBillDataRow["CurrencyID"].ToString())).ToString();
                    ExchangeTxtBox.Text = (double.Parse(CashInTxtBox.Text) * double.Parse(BuyRateTxtBox.Text) - double.Parse(TotalTxtBox.Text)).ToString();
                    CreditCardInfoTxtBox.Text = aGeneralBillDataRow["CreditCardInfo"].ToString();
                }

                if (aBillGeneralRow["IsCashCredit"].ToString() == "1")
                {
                    CashMethodComboBox.SelectedIndex = 1;

                    //CustomerAccountAmountlbl.Show();
                    CustomerAccountAmountTxtBox.Show();
                    CustomersAccountAmount.Show();

                    CustomerAccountAmountTxtBox.Text = aBillGeneralRow["CustomerAccountAmountOld"].ToString();
                    CashInTxtBox.Hide();
                    ExchangeTxtBox.Hide();
                    CashInLbl.Hide();
                    ExchangeLbl.Hide();
                    JODstatic.Hide();
                    CurrencyLbl.Hide();
                    IsCreditLbl.Show();
                }
                else
                {
                    CashMethodComboBox.SelectedIndex = 0;
                    //CustomerAccountAmountlbl.Hide();
                    CustomerAccountAmountTxtBox.Hide();
                    CustomersAccountAmount.Hide();

                    CashInTxtBox.Show();
                    ExchangeTxtBox.Show();
                    CashInLbl.Show();
                    ExchangeLbl.Show();
                    JODstatic.Show();
                    CurrencyLbl.Show();

                    IsCreditLbl.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ChkBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aBillGeneralRow["IsChecked"].ToString() == "0")
                {
                    string ChkdBy = SharedFunctions.ReturnLoggedUserName();
                    string ChkDate = DateTime.Now.ToShortDateString();
                    if (!BillGeneralMgmt.UpdateBillToChecked(ChkdBy, ChkDate, int.Parse(InvoiceNumTxtBox.Text)))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditBill-ChkBillBtn_Click] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-ChkBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ReviseBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aBillGeneralRow["IsRevised"].ToString() == "0")
                {
                    if (CashMethodComboBox.SelectedIndex == 1)//iscredit
                    {
                        int CustomerID = CustomerMgmt.SelectCustomerIDByPhone1(PhoneTxtBox.Text);
                        DataRow aCustomerAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                        double OldAmount = double.Parse(aCustomerAccount["Amount"].ToString());
                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text);
                        int AccountID = int.Parse(aCustomerAccount["ID"].ToString());
                        CustomersAccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    }
                    else
                    {//int.Parse(AccountComboBox.SelectedValue.ToString());
                        int AccountID = int.Parse(aBillGeneralRow["AccountID"].ToString());
                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text); ;
                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    }
                    //Mark the check (if any) as revised
                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aBillGeneralRow["PaymentMethodID"].ToString()));
                    if (aMethodRow["IsCheck"].ToString() == "1")
                    {
                        ChecksMgmt.MakeCheckRevised(int.Parse(aBillGeneralRow["CheckNumber"].ToString()), DateTime.Now.ToShortDateString());
                    }
                    //Now Update AvgUnitCost
                    double CostLoss = 0;
                    foreach (DataGridViewRow r in TeldgView.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            int ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            double OldAvgUnitCost = BillDetailedMgmt.SelectOldAvgUnitCostByID(ItemID, int.Parse(aBillGeneralRow["Number"].ToString()));
                            double ReturnQty = double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                            double CurrentAvgUnitCost = ItemsMgmt.SelectItemCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            double CurrentAvaQty = ItemsMgmt.SelectItemQtyByID(ItemID);
                            double NewAvgUnitCost = CurrentAvgUnitCost;
                            if ((ReturnQty + CurrentAvaQty) != 0) //to avoid division by zero
                            {
                                NewAvgUnitCost = ((CurrentAvgUnitCost * CurrentAvaQty) + (ReturnQty * OldAvgUnitCost)) / (ReturnQty + CurrentAvaQty);
                            }
                            CostLoss += (NewAvgUnitCost - OldAvgUnitCost) * BillDetailedMgmt.SelectAllItemsSoldAfterBillNumber(ItemID, int.Parse(aBillGeneralRow["Number"].ToString()));
                            ItemsMgmt.UpdateItemQtyandAvgUnitCostByID(ItemID, (ReturnQty + CurrentAvaQty), NewAvgUnitCost);
                            BillDetailedMgmt.MakeItemAsRevised(int.Parse(aBillGeneralRow["Number"].ToString()), ItemID);
                        }
                    }
                    //Now we should mark the bill general as reversed
                    if (!BillGeneralMgmt.UpdateBillToRevised(SharedFunctions.ReturnLoggedUserName(), DateTime.Now.ToShortDateString(), int.Parse(aBillGeneralRow["Number"].ToString()), CostLoss))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditBill-ReviseBillBtn_Click] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-ReviseBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void EditBill_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditBill_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ReprintBtn_Click(object sender, EventArgs e)
        {
            print_receipt();
        }

        private bool print_receipt()
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]<th width=45%>" + ReceiptText.RctTxtItemName);
                aDataTable1.Columns.Add(ReceiptText.RctTxtUnitPrice);
                aDataTable1.Columns.Add(ReceiptText.RctTxtQty);
                aDataTable1.Columns.Add(ReceiptText.RctTxtTotal);

                foreach (DataGridViewRow aRow in TeldgView.Rows)
                {
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[aRow.Index][0] = aRow.Cells["Description"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][1] = aRow.Cells["PricePerUnit"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][2] = aRow.Cells["Qty"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][3] = aRow.Cells["PriceTotal"].Value.ToString();
                }
                int RowCnt = 0;
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                RowCnt = 0;

                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax;
                aDataTable3.Rows[RowCnt++][1] = TaxTxtBox.Text + "<b> JOD";

                if (double.Parse(DiscountBillTxtBox.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtDisountInvoice;
                    aDataTable3.Rows[RowCnt++][1] = "@" + DiscountPercTxtBox.Text + "% =" + DiscountBillTxtBox.Text + "<b> JOD";
                }
                if (double.Parse(PriceLevelDiscount.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPriceLvlDiscount;
                    aDataTable3.Rows[RowCnt++][1] = PriceLevelDiscount.Text + "<b> JOD";
                }
                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = "<td style=\"background-color:#000;color:#fff;border-right-color:#fff;\"><b><font size=4> *** " +  ReceiptText.RctTxtToPayAmount + " ***</font>";
                aDataTable3.Rows[RowCnt++][1] = "<td style=\"background-color:#000;color:#fff;border-left-color:#fff\"><b><font size=5>" + TotalTxtBox.Text + " JOD </font>";
                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayMethod;
                aDataTable3.Rows[RowCnt++][1] = PaymentMethodCheckBox.Text;
                if (PaymentMethodCheckBox.Text.ToUpper() == "CASH")
                {
                    if (CashMethodComboBox.Text == "Cash")
                    {
                        aDataTable3.Rows.Add();
                        aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtCashIn;
                        aDataTable3.Rows[RowCnt++][1] = CashInTxtBox.Text + "<b> " + CurrencyComboBox.Text;
                        double tempamt = 0;
                        if (double.TryParse(ExchangeTxtBox.Text, out tempamt))
                        {
                            if (tempamt != 0)
                            {
                                aDataTable3.Rows.Add();
                                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtExchange;
                                aDataTable3.Rows[RowCnt++][1] = ExchangeTxtBox.Text + "<b> JOD";
                            }
                        }
                    }
                    else if (CashMethodComboBox.Text == "Invoice")
                    {
                        aDataTable3.Rows.Add();
                        aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtReceivable;
                        double CustomerAccountAmountParserChk = 0;
                        if (double.TryParse(CustomerAccountAmountTxtBox.Text, out CustomerAccountAmountParserChk))
                        {
                            aDataTable3.Rows[RowCnt++][1] = ReceiptText.RctTxtOldBalance + " = " + CustomerAccountAmountParserChk + "&nbsp;&nbsp;" + SharedVariables.Line_Solid_10px_Black +
                                     ReceiptText.RctTxtNewBalance + " = " + Math.Round((CustomerAccountAmountParserChk + double.Parse(TotalTxtBox.Text)), 3);
                        }
                    }
                }

                aDataTableList.Add(aDataTable1);
                // aDataTableList.Add(aDataTable2);
                aDataTableList.Add(aDataTable3);

                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsSales);
                aStringList.Add(ReceiptText.RctTxtDuplicate);
                if (aBillGeneralRow["IsRevised"].ToString() == "1")
                {
                    aStringList.Add("*** "+ReceiptText.RctTxtReversed+" ***");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedBy + ":&nbsp;&nbsp;" + RevisedBylbl.Text + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedOn + ":&nbsp;&nbsp;" + ReviseDatelbl.Text + "</h2>");
                }
                
                aStringList.Add("<h2>" + ReceiptText.RctTxtOrgDate + "/" + ReceiptText.RctTxtOrgTime + " " + DateLbl.Text + "&nbsp;&nbsp;" + TimeLbl.Text + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtOrgTeller + ":&nbsp;&nbsp;" +  TellerLbl.Text+ "</h2>");
                aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn  + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

                if (PhoneTxtBox.Text != "00")
                {
                    aStringList.Add(ReceiptText.RctTxtCustomer + ":&nbsp;&nbsp;" + CustomerNameTxtBox.Text);
                }

                aStringList.Add(ReceiptText.RctTxtInvoiceNum + ":&nbsp; " + InvoiceNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TOUCHSCREEN:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditBillFormName;
               //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
          // // this.RightToLeftLayout = true;
            AccountLbl.Text = UiText.EdtBllAccountLbl;
            AddNewItemLbl.Text = UiText.EdtBllAddNewItemLbl;
            BillNumberLbl.Text = UiText.EdtBllBillNumberLbl;
            BuyRateLbl.Text = UiText.EdtBllBuyRateLbl;
            CashInCurrency.Text = UiText.EdtBllCashInCurrency;
            CashInLbl.Text = UiText.EdtBllCashInLbl;
            CashMethodLbl.Text = UiText.EdtBllCashMethodLbl;
            CashPaymentGB.Text = UiText.EdtBllCashPaymentGB;
            CheckCommentsLbl.Text = UiText.EdtBllCheckCommentsLbl;
            CheckGB.Text = UiText.EdtBllCheckGB;
            CheckHolderNameLbl.Text = UiText.EdtBllCheckHolderNameLbl;
            CheckInfoGB.Text = UiText.EdtBllCheckInfoGB;
            CheckNumber.Text = UiText.EdtBllCheckNumber;
            ChkBillBtn.Text = UiText.EdtBllChkBillBtn;
            ChkDate.Text = UiText.EdtBllChkDate;
            ChkDateLbl.Text = UiText.EdtBllChkDateLbl;
            ChkedBy.Text = UiText.EdtBllChkedBy;
            ChkedByUserNameLbl.Text = UiText.EdtBllChkedByUserNameLbl;
            CurrencyLbl.Text = UiText.EdtBllCurrencyLbl;
            
            CustomerNameLbl.Text = UiText.EdtBllCustomerNameLbl;
            CustomerPhoneLbl.Text = UiText.EdtBllCustomerPhoneLbl;
            CustomersAccountAmount.Text = UiText.EdtBllCustomersAccountAmount;
            CommentsLbl.Text = UiText.EdtBllCommentsLbl;
            Date.Text = UiText.EdtBllDate;
            DateLbl.Text = UiText.EdtBllDateLbl;
            DiscountBillPercLbl.Text = UiText.EdtBllDiscountBillPercLbl;
            DiscountOnBillLbl.Text = UiText.EdtBllDiscountOnBillLbl;
            ExchangeLbl.Text = UiText.EdtBllExchangeLbl;
            groupBox1.Text = UiText.EdtBllgroupBox1;
            IsCreditLbl.Text = UiText.EdtBllIsCreditLbl;
            IsRevisedLbl.Text = UiText.EdtBllIsRevisedLbl;
            JODstatic.Text = UiText.EdtBllJODstatic;
            NetAmountLbl.Text = UiText.EdtBllNetAmountLbl;
            PayInVisaGB.Text = UiText.EdtBllPayInVisaGB;
            ReprintBtn.Text = UiText.EdtBllReprintBtn;
            PaymentCommentsLbl.Text = UiText.EdtBllPaymentCommentsLbl;
            PaymentDateLbl.Text = UiText.EdtBllPaymentDateLbl;
            PaymentGB.Text = UiText.EdtBllPaymentGB;
            PaymentMethodLbl.Text = UiText.EdtBllPaymentMethodLbl;
            PriceLevelLbl.Text = UiText.EdtBllPriceLevelLbl;
            PriceLvlDiscountLbl.Text = UiText.EdtBllPriceLvlDiscountLbl;
            ReviseBillBtn.Text = UiText.EdtBllReviseBillBtn;
            ReviseDate.Text = UiText.EdtBllReviseDate;
            ReviseDatelbl.Text = UiText.EdtBllReviseDatelbl;
            RevisedBy.Text = UiText.EdtBllRevisedBy;
            RevisedBylbl.Text = UiText.EdtBllRevisedBylbl;
            ReviseInfoGB.Text = UiText.EdtBllReviseInfoGB;
            ReviseLossProfit.Text = UiText.EdtBllReviseLossProfit;
            ReviseLossProfitLbl.Text = UiText.EdtBllReviseLossProfitLbl;
            SellPriceLbl.Text = UiText.EdtBllSellPriceLbl;
            SubtotalLbl.Text = UiText.EdtBllSubtotalLbl;
            TellerLbl.Text = UiText.EdtBllTellerLbl;
            
            Time.Text = UiText.EdtBllTime;
            TimeLbl.Text = UiText.EdtBllTimeLbl;
            TotalBillLbl.Text = UiText.EdtBllTotalBillLbl;
            TotalDiscountLbl.Text = UiText.EdtBllTotalDiscountLbl;
            TotalTaxlbl.Text = UiText.EdtBllTotalTaxlbl;
            UserName.Text = UiText.EdtBllUserName;
            ReprintBtn.Text = UiText.EdtBllReprintBtn;
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
