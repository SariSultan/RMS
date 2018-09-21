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
    public partial class EditVoucher : Form
    {
        string Temp = string.Empty;
        DataRow aPurchaseDataRow;
        DataRow aVendorDataRow;

        public EditVoucher()
        {
            InitializeComponent();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

        }

        private void EditVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                TellerUserNameLbl.Text = SharedFunctions.ReturnLoggedUserName();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditVoucher_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        public void AddDGView(DataTable aVoucherDataTable)
        {
            try
            {
                foreach (DataRow r in aVoucherDataTable.Rows)
                {
                    int RowNum = TeldgView.Rows.Add();
                    DataRow aItemRow = ItemsMgmt.SelectItemRowByID(int.Parse( aVoucherDataTable.Rows[RowNum]["ItemID"].ToString()));
                    TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemRow["Barcode"].ToString();
                     
                    TeldgView.Rows[RowNum].Cells["Description"].Value = aItemRow["Description"].ToString();
                    TeldgView.Rows[RowNum].Cells["Qty"].Value = aVoucherDataTable.Rows[RowNum]["Qty"].ToString();
                    TeldgView.Rows[RowNum].Cells["DiscountPerc"].Value = aVoucherDataTable.Rows[RowNum]["Discount"].ToString();
                    TeldgView.Rows[RowNum].Cells["FreeItemsQty"].Value = aVoucherDataTable.Rows[RowNum]["FreeItemsQty"].ToString();
                    TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aVoucherDataTable.Rows[RowNum]["ItemCost"].ToString();
                    TeldgView.Rows[RowNum].Cells["PriceTotal"].Value = double.Parse(aVoucherDataTable.Rows[RowNum]["Qty"].ToString()) * double.Parse(aVoucherDataTable.Rows[RowNum]["ItemCost"].ToString());
                    TeldgView.Rows[RowNum].Cells["Tax"].Value = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemRow["TaxLevel"].ToString()));
                    TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aVoucherDataTable.Rows[RowNum]["OldAvaQty"].ToString();
                    TeldgView.Rows[RowNum].Cells["AvgUnitCost"].Value = aVoucherDataTable.Rows[0]["OldAvgUnitCost"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVoucher-AddDGView] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void UpdateVariables(DataRow aGeneralVoucherDataRow)
        {
            try
            {
                aPurchaseDataRow = aGeneralVoucherDataRow;
                PurchaseVoucherNumTxtBox.Text = aGeneralVoucherDataRow["VoucherNumber"].ToString();
                aVendorDataRow = VendorsMgmt.SelectVendorRowByID(int.Parse(aGeneralVoucherDataRow["VendorID"].ToString()));
                if (aVendorDataRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCustomerRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditVoucher-SelectVendorRowByID Returned Null");
                }

                VendorsComboBox.Text = aVendorDataRow["Name"].ToString();
                VendorDescriptionTxtBox.Text = aVendorDataRow["Company"].ToString();
                //account amount is latered to iscredit
                DateLbl.Text = DateTime.Parse(aGeneralVoucherDataRow["Date"].ToString()).ToShortDateString();
                TimeLbl.Text = DateTime.Parse(aGeneralVoucherDataRow["Time"].ToString()).ToShortTimeString();
                TellerLbl.Text = UsersMgmt.SelectUserNameByID(int.Parse(aGeneralVoucherDataRow["TellerID"].ToString()));
                if (TellerLbl.Text == null)
                {
                    //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-UsersMgmt.UsrById Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("[EditVoucher-UsersMgmt.UsrById Returned Null]");
                }
                //DOWN RIGHT
                SubtotalTxtBox.Text = aGeneralVoucherDataRow["Subtotal"].ToString();
                DiscountPercTxtBox.Text = aGeneralVoucherDataRow["DiscountPerc"].ToString();
                DiscountTxtBox.Text = (float.Parse(SubtotalTxtBox.Text) * float.Parse(DiscountPercTxtBox.Text) / 100).ToString();
                ItemsDiscountTxtBox.Text = aGeneralVoucherDataRow["TotalItemsDiscount"].ToString();
                TotalDiscountTxtBox.Text = aGeneralVoucherDataRow["TotalDiscount"].ToString();
                TotalTaxTxtBox.Text = aGeneralVoucherDataRow["TotalTax"].ToString();
                FeesTxtBox.Text = aGeneralVoucherDataRow["Fees"].ToString();
                TotalTxtBox.Text = aGeneralVoucherDataRow["TotalCost"].ToString();
                //GroupBox1 Elements
                if (aPurchaseDataRow["IsRevised"].ToString() == "1")
                {
                    ReviseInfoGB.Show();
                    ReviseDatelbl.Text = DateTime.Parse(aPurchaseDataRow["ReviseDate"].ToString()).ToShortDateString();
                    ReviseTime.Text = DateTime.Parse(aPurchaseDataRow["ReviseTime"].ToString()).ToShortTimeString();
                    RevisedBylbl.Text = aPurchaseDataRow["RevisedBy"].ToString();
                    IsRevisedLbl.Visible = true;
                    ReviseLossProfitLbl.Text = aPurchaseDataRow["ReviseLoss"].ToString();
                }
                else
                {
                    ReviseInfoGB.Hide();
                }

                if (aPurchaseDataRow["IsChecked"].ToString() == "1")
                {
                    ChkedByUserNameLbl.Text = aPurchaseDataRow["CheckedBy"].ToString();

                    ChkDateLbl.Text = DateTime.Parse(aPurchaseDataRow["CheckDate"].ToString()).ToShortDateString();
                    CheckTime.Text = DateTime.Parse(aPurchaseDataRow["CheckTime"].ToString()).ToShortTimeString();
                    CheckInfoGB.Show();
                }
                else
                {
                    CheckInfoGB.Hide();
                }
                //PaymentInformation
                DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aPurchaseDataRow["PaymentMethodID"].ToString()));
                if (aMethodRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectMethodRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditVoucher-SelectMethodRowByID Returned Null");
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
                    CheckNumberTxtBox.Text = aPurchaseDataRow["CheckNumber"].ToString();
                    DataRow aCheckDataRow = ChecksMgmt.SelectCheckRowByNumber(int.Parse(aPurchaseDataRow["CheckNumber"].ToString()));
                    if (aCheckDataRow == null)
                    {
                        //MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectCheckRowByNumber Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("EditVoucher-SelectCheckRowByNumber Returned Null");
                    }
                    HolderNameTxtBox.Text = aCheckDataRow["HolderName"].ToString();
                    CheckCommentsTxtBox.Text = aCheckDataRow["Comments"].ToString();
                    CheckDatePicker.Text = aCheckDataRow["PaymentDate"].ToString();
                }
                DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(aPurchaseDataRow["AccountID"].ToString()));
                if (aAccountRow == null)
                {
                    // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBill-SelectAccountRowByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("EditBill-SelectAccountRowByID Returned Null");
                }
                else
                {
                    AccountComboBox.Text = aAccountRow["Name"].ToString();
                    AccountDescriptionTxtBox.Text = aAccountRow["Description"].ToString();
                    CurrencyComboBox.Text = CurrencyMgmt.SelectCurrencyNameByID(int.Parse(aAccountRow["CurrencyID"].ToString()));
                    if (CurrencyComboBox.Text == null)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVoucher-SelectCurrencyNameByID Returned Null] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    CreditCardInfoTxtBox.Text = aPurchaseDataRow["CreditCardInfo"].ToString();
                }
                if (aPurchaseDataRow["IsCashCredit"].ToString() == "1")
                {
                    CashMethodComboBox.SelectedIndex = 1;
                    VendorAccountAmountTxtBox.Show();
                    VendorAccountAmountTxtBox.Text = aPurchaseDataRow["VendorAccountAmountOld"].ToString();
                    AccountComboBox.Hide();
                    AccountLbl.Hide();
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
                    VendorAccountAmountTxtBox.Hide();
                    AccountComboBox.Show();
                    AccountLbl.Show();
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVoucher-UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void ChkBillBtn_Click(object sender, EventArgs e)
        {


            try
            {
                if (aPurchaseDataRow["IsChecked"].ToString() == "0")
                {
                    string ChkdBy = TellerUserNameLbl.Text;
                    string ChkDate = DateTime.Now.ToShortDateString();
                    string ChkTime = DateTime.Now.ToShortTimeString();

                    if (!PurchaseVoucherGeneralMgmt.UpdateVoucherChecked(ChkdBy, ChkDate, ChkTime, int.Parse(PurchaseVoucherNumTxtBox.Text)))
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVoucher-ChkBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ReviseBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aPurchaseDataRow["IsRevised"].ToString() == "0")
                {
                    if (CashMethodComboBox.SelectedIndex == 1)//iscredit
                    {
                        int VendorID = VendorsMgmt.SelectVendorIDByName(VendorsComboBox.Text);
                        DataRow aVendorAccount = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(VendorID);
                        double OldAmount = double.Parse(aVendorAccount["Amount"].ToString());
                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text);
                        int AccountID = int.Parse(aVendorAccount["ID"].ToString());
                        VendorsAccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    }
                    else
                    {
                        int AccountID = int.Parse(aPurchaseDataRow["AccountID"].ToString());
                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text); ;
                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    }
                    //Mark the check (if any) as revised
                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(aPurchaseDataRow["PaymentMethodID"].ToString()));
                    if (aMethodRow["IsCheck"].ToString() == "1")
                    {
                        ChecksMgmt.MakeCheckRevised(int.Parse(aPurchaseDataRow["CheckNumber"].ToString()), DateTime.Now.ToShortDateString());
                    }
                    //Now Update AvgUnitCost
                    double CostLoss = 0;
                    foreach (DataGridViewRow r in TeldgView.Rows)
                    {
                        if (!r.IsNewRow)
                        {
                            int ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            double ItemCost = PurchaseVoucherDetailedMgmt.SelectItemCostByNumber(ItemID, int.Parse(aPurchaseDataRow["VoucherNumber"].ToString()));
                            double ReturnQty = double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                            double CurrentAvgUnitCost = ItemsMgmt.SelectItemCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            double CurrentAvaQty = ItemsMgmt.SelectItemQtyByID(ItemID);
                            double NewAvgUnitCost = ((CurrentAvgUnitCost * CurrentAvaQty) + (ReturnQty * ItemCost)) / (ReturnQty + CurrentAvaQty);
                            ItemsMgmt.UpdateItemQtyandAvgUnitCostByID(ItemID, (ReturnQty + CurrentAvaQty), NewAvgUnitCost);
                            PurchaseVoucherDetailedMgmt.MakeItemAsRevised(int.Parse(aPurchaseDataRow["VoucherNumber"].ToString()), ItemID);
                        }
                    }
                    //Now we should mark the bill general as reversed
                    if (!PurchaseVoucherGeneralMgmt.UpdateVoucherToRevised(TellerUserNameLbl.Text, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString(), int.Parse(aPurchaseDataRow["VoucherNumber"].ToString()), CostLoss))
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DB-ERROR-EditBill-ReviseBillBtn_Click] " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.ReversedSuccessfullyTxt, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.AlreadyReversedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditVoucher-ReviseBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void TranslateUI()
        {

            try
            {
                this.Text = FormsNames.EditPurchaseVoucherFormName;
                //   this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                // this.RightToLeftLayout = true;
                AccountLbl.Text = UiText.EdtVchAccountLbl;
                AddNewItemLbl.Text = UiText.EdtVchAddNewItemLbl;
                BuyRateLbl.Text = UiText.EdtVchBuyRateLbl;
                CashInCurrency.Text = UiText.EdtVchCashInCurrency;
                CashInLbl.Text = UiText.EdtVchCashInLbl;
                CashMethodLbl.Text = UiText.EdtVchCashMethodLbl;
                CashPaymentGB.Text = UiText.EdtVchCashPaymentGB;
                CheckCommentsLbl.Text = UiText.EdtVchCheckCommentsLbl;
                CheckGB.Text = UiText.EdtVchCheckGB;
                CheckHolderNameLbl.Text = UiText.EdtVchCheckHolderNameLbl;
                CheckInfoGB.Text = UiText.EdtVchCheckInfoGB;
                CheckNumber.Text = UiText.EdtVchCheckNumber;
                CheckTime.Text = UiText.EdtVchCheckTime;
                CheckTimeLbl.Text = UiText.EdtVchCheckTimeLbl;
                ChkBillBtn.Text = UiText.EdtVchChkBillBtn;
                ChkDate.Text = UiText.EdtVchChkDate;
                ChkDateLbl.Text = UiText.EdtVchChkDateLbl;
                ChkedBy.Text = UiText.EdtVchChkedBy;
                ChkedByUserNameLbl.Text = UiText.EdtVchChkedByUserNameLbl;
                CompanyLbl.Text = UiText.EdtVchCompanyLbl;
                CurrencyLbl.Text = UiText.EdtVchCurrencyLbl;
                CurrentUserLbl.Text = UiText.EdtVchCurrentUserLbl;
                DateLbl.Text = UiText.EdtVchDateLbl;
                DiscountLbl.Text = UiText.EdtVchDiscountLbl;
                DiscountOnVouPercLbl.Text = UiText.EdtVchDiscountOnVouPercLbl;
                ExchangeLbl.Text = UiText.EdtVchExchangeLbl;
                FeesLbl.Text = UiText.EdtVchFeesLbl;
                groupBox1.Text = UiText.EdtVchgroupBox1;
                IsRevisedLbl.Text = UiText.EdtVchIsRevisedLbl;
                ItemsDiscountLbl.Text = UiText.EdtVchItemsDiscountLbl;
                JODstatic.Text = UiText.EdtVchJODstatic;
                PayInVisaGB.Text = UiText.EdtVchPayInVisaGB;
                PaymentCommentsLbl.Text = UiText.EdtVchPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.EdtVchPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.EdtVchPaymentMethodLbl;
                ReviseBillBtn.Text = UiText.EdtVchReviseBillBtn;
                ReviseDate.Text = UiText.EdtVchReviseDate;
                ReviseDatelbl.Text = UiText.EdtVchReviseDatelbl;
                RevisedBy.Text = UiText.EdtVchRevisedBy;
                RevisedBylbl.Text = UiText.EdtVchRevisedBylbl;
                ReviseInfoGB.Text = UiText.EdtVchReviseInfoGB;
                ReviseLossProfit.Text = UiText.EdtVchReviseLossProfit;
                ReviseLossProfitLbl.Text = UiText.EdtVchReviseLossProfitLbl;
                ReviseTime.Text = UiText.EdtVchReviseTime;
                ReviseTimeLbl.Text = UiText.EdtVchReviseTimeLbl;
                SellPriceLbl.Text = UiText.EdtVchSellPriceLbl;
                SubtotalLbl.Text = UiText.EdtVchSubtotalLbl;
                TaxLbl.Text = UiText.EdtVchTaxLbl;
                TellerLbl.Text = UiText.EdtVchTellerLbl;
                TellerUserNameLbl.Text = UiText.EdtVchTellerUserNameLbl;
                TimeLbl.Text = UiText.EdtVchTimeLbl;
                TotalBillLbl.Text = UiText.EdtVchTotalBillLbl;
                TotalDiscountLbl.Text = UiText.EdtVchTotalDiscountLbl;
                VendorAccountAmountLbl.Text = UiText.EdtVchVendorAccountAmountLbl;
                VendorLbl.Text = UiText.EdtVchVendorLbl;
                VoucherNumberLbl.Text = UiText.EdtVchVoucherNumberLbl;
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
                aDataTable1.Columns.Add("[border=true1]<th width=45%>" + ReceiptText.RctTxtItemName);
                aDataTable1.Columns.Add(ReceiptText.RctTxtUnitPrice);
                aDataTable1.Columns.Add(ReceiptText.RctTxtQty);
                aDataTable1.Columns.Add(ReceiptText.RctTxtTotal);
                aDataTable1.Columns.Add(ReceiptText.RctTxtDiscount + " %");

                bool NoDiscount = true;
                foreach (DataGridViewRow aRow in TeldgView.Rows)
                {
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[aRow.Index][0] = aRow.Cells["Description"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][1] = aRow.Cells["PricePerUnit"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][2] = aRow.Cells["Qty"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][3] = aRow.Cells["PriceTotal"].Value.ToString();

                    aDataTable1.Rows[aRow.Index][4] = aRow.Cells["DiscountPerc"].Value.ToString();
                    if (double.Parse(aRow.Cells["DiscountPerc"].Value.ToString()) > 0)
                    {
                        NoDiscount = false;
                    }
                }

                if (NoDiscount)
                {
                    aDataTable1.Columns.Remove(aDataTable1.Columns[4]);
                }
                int RowCnt = 0;
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                RowCnt = 0;

                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax;
                aDataTable3.Rows[RowCnt++][1] = TotalTaxTxtBox.Text + "<b> JOD";

                if (double.Parse(DiscountTxtBox.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtVoucherDiscount;
                    aDataTable3.Rows[RowCnt++][1] = "@" + DiscountPercTxtBox.Text + "% =" + DiscountTxtBox.Text + "<b> JOD";
                }
                if (double.Parse(ItemsDiscountTxtBox.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtItemsDiscount;
                    aDataTable3.Rows[RowCnt++][1] = ItemsDiscountTxtBox.Text + "<b> JOD";
                }
                if (double.Parse(TotalDiscountTxtBox.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTotalDiscount;
                    aDataTable3.Rows[RowCnt++][1] = TotalDiscountTxtBox.Text + "<b> JOD";
                }
                if (double.Parse(FeesTxtBox.Text) != 0)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtFees;
                    aDataTable3.Rows[RowCnt++][1] = FeesTxtBox.Text + "<b> JOD";
                }


                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = "<td style=\"background-color:#000;color:#fff;border-right-color:#fff;\"><b><font size=4>" + ReceiptText.RctTxtToPayAmount + "</font>";
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
                        aDataTable3.Rows[RowCnt++][1] = CashInTxtBox.Text + "<b> " + " JOD";
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
                        aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayable;
                        double VendorAccountAmountParserChk = 0;
                        if (double.TryParse(VendorAccountAmountTxtBox.Text, out VendorAccountAmountParserChk))
                        {
                            aDataTable3.Rows[RowCnt++][1] = ReceiptText.RctTxtOldBalance + " = " + VendorAccountAmountParserChk + "&nbsp;&nbsp;" + SharedVariables.Line_Solid_10px_Black +
                                     ReceiptText.RctTxtNewBalance + " = " + Math.Round((VendorAccountAmountParserChk + double.Parse(TotalTxtBox.Text)), 3);
                        }
                    }
                }

                aDataTableList.Add(aDataTable1);
                // aDataTableList.Add(aDataTable2);
                aDataTableList.Add(aDataTable3);

                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsPurchase);


                aStringList.Add("*** " + ReceiptText.RctTxtDuplicate + " ***");
                if (aPurchaseDataRow["IsRevised"].ToString() == "1")
                {
                    aStringList.Add("*** " + ReceiptText.RctTxtReversed + " ***");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedBy + ":&nbsp;&nbsp;" + RevisedBylbl.Text + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReversedOn + ":&nbsp;&nbsp;" + ReviseDatelbl.Text + "</h2>");
                }

                aStringList.Add("<h2>" + ReceiptText.RctTxtOrgDate + "/" + ReceiptText.RctTxtOrgTime + " " + DateLbl.Text + "&nbsp;&nbsp;" + TimeLbl.Text + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtOrgTeller + ":&nbsp;&nbsp;" + TellerLbl.Text + "</h2>");
                aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

                aStringList.Add("<h2> " + ReceiptText.RctTxtVendor + ":&nbsp;&nbsp;" + VendorsComboBox.Text + "</h2>");


                aStringList.Add(ReceiptText.RctTxtPurchaseNumber + ":&nbsp; " + PurchaseVoucherNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[Edit PurchaseVoucher:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReprintBtn_Click(object sender, EventArgs e)
        {
            print_receipt();
        }
    }
}
