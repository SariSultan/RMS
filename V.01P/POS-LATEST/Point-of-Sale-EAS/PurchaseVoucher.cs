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
    public partial class PurchaseVoucher : Form
    {
        Color aThisBGColor;
        bool IsAddingItem = false; bool OnExit = false; bool semaphore = false;
        double Subtotal = 0, TotalTax = 0, SubtotalTemp = 0, TaxTemp = 0, TotalCost = 0;
        double QtyTemp = 0;
        double PricePerUnitTemp = 0;
        double AvgUnitCostTemp = 0;
        double AvaQtyTemp = 0;
        double Discount = 0;
        int VoucherNumber = 0;
        string Temp = string.Empty;
        double TotalItemsDiscount = 0;
        double TotalFreeItemQty = 0;
        bool IsLoading = true;

        bool IsClosing = false;
        DataRow aVendorAccount;
        DataRow aVendorDataRow;
        int DivisionScale = 1;
        int BarcodeLength = 1;
        bool aThereIsWeigth = false;

        Color CashBGColor = Color.White;
        public PurchaseVoucher()
        {
            InitializeComponent();
            aThisBGColor = this.BackColor;
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            DiscountPercTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            FeesTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            CashInTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            CashBGColor = CashInTxtBox.BackColor;
            try
            {
                DataRow aWeightRow = WeightMgmt.SelectWeightRow();
                if (
                    int.TryParse(aWeightRow["DivisionScale"].ToString(), out DivisionScale)
                && int.TryParse(aWeightRow["BarcodeLength"].ToString(), out BarcodeLength)
                    )
                {
                    if (BarcodeLength > 0)
                    {
                        aThereIsWeigth = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " " + "Error Loading Weight In POS\n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            TranslateUI();
            IsLoading = false;
        }
        private void Purchase_Voucher_Load(object sender, EventArgs e)
        {
            try
            {
                IsLoading = true;
                // TODO: This line of code loads data into the 'dBDataSet2.Items' table. You can move, or remove it, as needed.
                this.itemsTableAdapter.WithBarcode(this.dBDataSet2.Items);
                this.itemsTableAdapter.WithoutBarcode(this.dBDataSet.Items);
                // TODO: This line of code loads data into the 'dBDataSet.Banks' table. You can move, or remove it, as needed.
                // TODO: This line of code loads data into the 'dBDataSet.Currency' table. You can move, or remove it, as needed.
                this.currencyTableAdapter.Fill(this.dBDataSet.Currency);
                // TODO: This line of code loads data into the 'dBDataSet.PaymentMethod' table. You can move, or remove it, as needed.
                this.paymentMethodTableAdapter.Fill(this.dBDataSet.PaymentMethod);
                // TODO: This line of code loads data into the 'dBDataSet.Accounts' table. You can move, or remove it, as needed.
                this.accountsTableAdapter.Fill(this.dBDataSet.Accounts);
                // TODO: This line of code loads data into the 'dBDataSet.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
                // TODO: This line of code loads data into the 'dBDataSet.Items' table. You can move, or remove it, as needed.
                //this.itemsTableAdapter.Fill(this.dBDataSet.Items);
                DateTime temp = DateTime.Now;
                BarcodeTxtBox.Text = string.Empty;
                ItemDescriptionComboBox.Text = string.Empty;
                VoucherNumber = PurchaseVoucherGeneralMgmt.NextVoucherNumber();
                PurchaseVoucherNumTxtBox.Text = VoucherNumber.ToString();
                CheckDatePicker.MinDate = DateTime.Today;
                //Default Account
                int DefaultAccountID = AccountsMgmt.SelectDefaultAccountID();
                AccountComboBox.SelectedValue = DefaultAccountID.ToString();
                AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(DefaultAccountID);
                IsLoading = false; //KEEP IT HERE WE WANT SOME EVENT FOR BELOW TO OCCUR
                //Default Payment Method
                DataRow aPaymentMethodRow = PaymentMethodMgmt.SelectDefaultPaymentMethod();
                PaymentMethodCheckBox.Text = aPaymentMethodRow["Name"].ToString();
                PaymentMethodCheckBox.SelectedValue = aPaymentMethodRow["ID"].ToString();
                PaymentMethodDescripTxtBox.Text = aPaymentMethodRow["Description"].ToString();
                CashMethodComboBox.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[Purchase_Voucher_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        #region [BARCODE FUNCTIONS]
        /// <summary>
        /// ADD ITEM USING BARCODE
        /// this is one of the major function which is used to add item using its barcode to the 
        /// TELDGVIEW with the following columns
        /// [Barcode] [Qty] [Description] [PricePerUnit] [Tax]  [PriceTotal] [AvalQty]
        /// And this function loocks a bool called IsAddingItem
        /// Function Version 1.01 Edited For for adding Purchase Voucher
        /// 1) Added Item Discount to TelDGview
        /// 2) Adding Free Qtu
        /// Last Edited By Sari Sultan On August,27,2013
        /// </summary>
        /// <param name="aBarcode"></param>
        /// <param name="IsFromGun"></param>
        private void AddItemUsingBarcode(string aBarcode, bool IsFromGun = false)
        {
            semaphore = true;
            IsAddingItem = true;
            try
            {
                double TotwgtPrice = 0;
                bool dowgt = false;
                DataTable aItemTable = null;

                if (aThereIsWeigth && IsFromGun)
                {
                    if (aBarcode.Length > BarcodeLength)
                    {
                        // aBarcode = aBarcode.Substring(0, BarcodeLength);
                        string shortBar = aBarcode.Substring(0, BarcodeLength);
                        if (ItemsMgmt.IsItemWgtExist(shortBar))
                        {
                            aItemTable = ItemsMgmt.SelectItemByBarCode(shortBar);
                            string tempcoststr = aBarcode.Substring(BarcodeLength, aBarcode.Length - BarcodeLength);
                            if (double.TryParse(tempcoststr, out TotwgtPrice))
                            {
                                dowgt = true;
                            }
                        }
                        else { aItemTable = ItemsMgmt.SelectItemByBarCode(aBarcode); }
                    }
                    else { aItemTable = ItemsMgmt.SelectItemByBarCode(aBarcode); }
                }
                else { aItemTable = ItemsMgmt.SelectItemByBarCode(aBarcode); }

                if (aItemTable != null)
                {
                    if (aItemTable.Rows.Count >= 1)
                    {
                        double TaxPer = double.Parse(ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemTable.Rows[0]["TaxLevel"].ToString())));
                        foreach (DataGridViewRow r in TeldgView.Rows)
                        {
                            if (TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString() == aItemTable.Rows[0]["Barcode"].ToString())
                            {
                                TeldgView.ClearSelection();
                                if (dowgt)
                                {
                                    TeldgView.Rows[r.Index].Cells["Qty"].Value = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) + Math.Round(TotwgtPrice / DivisionScale / (double.Parse(aItemTable.Rows[0]["SellPrice"].ToString()) * (1 + TaxPer / 100)), 3);
                                }
                                else
                                {
                                    TeldgView.Rows[r.Index].Cells["Qty"].Value = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) + 1;
                                }
                                TeldgView.Rows[r.Index].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString()), 3);
                                TeldgView.Rows[r.Index].Selected = true;
                                IsAddingItem = false;
                                semaphore = false;
                                return;
                            }
                        }
                        IsAddingItem = true;
                        TeldgView.ClearSelection();
                        int RowNum = TeldgView.Rows.Add();
                        TeldgView.Rows[RowNum].Cells["DiscountPerc"].Value = 0;
                        TeldgView.Rows[RowNum].Cells["FreeItemsQty"].Value = 0;

                        TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
                        TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
                        TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = Math.Round(Convert.ToDouble(aItemTable.Rows[0]["AvgUnitCost"].ToString()), 3);
                        if (dowgt)
                        {
                            TeldgView.Rows[RowNum].Cells["Qty"].Value = Math.Round((TotwgtPrice / DivisionScale) / (double.Parse(aItemTable.Rows[0]["AvgUnitCost"].ToString()) * (1 + TaxPer / 100)), 3);
                        }
                        else
                        {
                            TeldgView.Rows[RowNum].Cells["Qty"].Value = 1;
                        }
                        TeldgView.Rows[RowNum].Cells["PriceTotal"].Value = Math.Round(double.Parse(TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[RowNum].Cells["Qty"].Value.ToString()), 3);
                        TeldgView.Rows[RowNum].Cells["Tax"].Value = TaxPer;
                        TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aItemTable.Rows[0]["Qty"].ToString();
                        if ((double.Parse(aItemTable.Rows[0]["Qty"].ToString())) == -1)
                        {
                            aItemTable.Rows[0]["Qty"] = 0;
                        }
                        TeldgView.Rows[RowNum].Cells["AvgUnitCost"].Value = (((double.Parse(aItemTable.Rows[0]["AvgUnitCost"].ToString()) * double.Parse(aItemTable.Rows[0]["Qty"].ToString())) + double.Parse(TeldgView.Rows[RowNum].Cells["PriceTotal"].Value.ToString())) / (double.Parse(aItemTable.Rows[0]["Qty"].ToString()) + 1));
                        TeldgView.Rows[RowNum].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.ItemNotFoundTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    IsAddingItem = false;
                }
            }
            catch (Exception ex)
            {
                IsAddingItem = false;
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddItemUsingBarcode] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsAddingItem = false;
            semaphore = false;
        }
        private void BarcodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                AddItemUsingBarcode(BarcodeTxtBox.Text, true);
                UpdateCash();
                BarcodeTxtBox.Text = string.Empty;
            }
            else if ((e.KeyChar.ToString() == "+" || e.KeyChar.ToString() == "-") && BarcodeTxtBox.Text == "")
            {
                e.Handled = true; //do not put it in the field
            }
        }
        private void DescriptionAddBtn_Click(object sender, EventArgs e)
        {
            if (ItemDescriptionComboBox.SelectedValue != null)
            {
                AddItemUsingBarcode(ItemDescriptionComboBox.SelectedValue.ToString());
                UpdateCash();
            }
        }
        private void WithoutAddBtn_Click(object sender, EventArgs e)
        {
            if (ItemsWithoutBarcodeComboBox.SelectedValue != null)
            {
                AddItemUsingBarcode(ItemsWithoutBarcodeComboBox.SelectedValue.ToString());
                UpdateCash();
            }
        }
        private void ItemDescriptionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ItemDescriptionComboBox.SelectedValue != null)
            {
                AddItemUsingBarcode(ItemDescriptionComboBox.SelectedValue.ToString());
                UpdateCash();
            }
        }
        private void ItemsWithoutBarcodeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ItemsWithoutBarcodeComboBox.SelectedValue != null)
            {
                AddItemUsingBarcode(ItemsWithoutBarcodeComboBox.SelectedValue.ToString());
                UpdateCash();
            }
        }
        #endregion [BARCODE FUNCTIONS]

        #region [UPDATING TEXTBOXES METHODS]
        double TestParser;
        private void UpdateCash()
        {

            //  StartTime = DateTime.Now;
            try
            {
                if (!IsLoading && !OnExit && !semaphore)
                {
                    semaphore = true;
                    Subtotal = 0; TotalTax = 0; SubtotalTemp = 0; TaxTemp = 0; TotalCost = 0;
                    Temp = string.Empty;
                    TotalItemsDiscount = 0;
                    TotalFreeItemQty = 0;
                    foreach (DataGridViewRow r in TeldgView.Rows)
                    {
                        if (!r.IsNewRow && !IsClosing && !OnExit)
                        {
                            //PriceLevelSelection
                            DataRow aItemRow = ItemsMgmt.SelectItemRowByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            if (aItemRow == null)
                            {
                                continue;
                            }
                            if (!OnExit)
                            {
                                TeldgView.Rows[r.Index].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString()), 3);
                                SubtotalTemp = Math.Round(double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString()), 3);
                                //updates                    
                                Subtotal += SubtotalTemp;
                                TotalCost = Math.Round(TotalCost + double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(aItemRow["AvgUnitCost"].ToString()), 3);
                                TotalItemsDiscount += ((double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * double.Parse(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString()) * double.Parse(TeldgView.Rows[r.Index].Cells["DiscountPerc"].Value.ToString()) / 100));
                                TotalFreeItemQty += double.Parse(TeldgView.Rows[r.Index].Cells["FreeItemsQty"].Value.ToString());
                                if (!double.TryParse(DiscountPercTxtBox.Text, out TestParser))
                                {
                                    DiscountPercTxtBox.Text = "0.00";
                                }
                                //new calculation tax - discount
                                TaxTemp = double.Parse(TeldgView.Rows[r.Index].Cells["Tax"].Value.ToString());
                                double Level1Discount = SubtotalTemp - (SubtotalTemp * (double.Parse(TeldgView.Rows[r.Index].Cells["DiscountPerc"].Value.ToString()) / 100));
                                double Level2Discount = Level1Discount - (Level1Discount * double.Parse(DiscountPercTxtBox.Text) / 100);
                                TotalTax += (TaxTemp / 100) * (Level2Discount);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    Subtotal = Math.Round(Subtotal, 3);
                    SubtotalTxtBox.Text = Subtotal.ToString();

                    if (!double.TryParse(FeesTxtBox.Text, out TestParser))
                    {
                        FeesTxtBox.Text = "0.00";
                    }
                    TotalTax = Math.Round(TotalTax, 3);
                    TotalTaxTxtBox.Text = TotalTax.ToString();
                    if (!double.TryParse(DiscountPercTxtBox.Text, out TestParser))
                    {
                        DiscountPercTxtBox.Text = "0.00";
                    }
                    DiscountTxtBox.Text = Math.Round(((double.Parse(DiscountPercTxtBox.Text) / 100 * (double.Parse(SubtotalTxtBox.Text) - TotalItemsDiscount))), 3).ToString();
                    TotalItemsDiscount = Math.Round(TotalItemsDiscount, 3);
                    ItemsDiscountTxtBox.Text = TotalItemsDiscount.ToString();
                    TotalDiscountTxtBox.Text = Math.Round((Convert.ToDouble(DiscountTxtBox.Text) + Convert.ToDouble(TotalItemsDiscount)), 3).ToString();
                    TotalTxtBox.Text = Math.Round((Subtotal + TotalTax - double.Parse(TotalDiscountTxtBox.Text) + double.Parse(FeesTxtBox.Text)), 3).ToString();
                    if (double.TryParse(CashInTxtBox.Text, out TestParser))
                    {
                        ExchangeTxtBox.Text = Math.Round((double.Parse(CashInTxtBox.Text) - double.Parse(TotalTxtBox.Text)), 3).ToString();
                    }
                    else
                    {
                        ExchangeTxtBox.Text = MsgTxt.CannotBeCalculatedTxt;
                    }
                    semaphore = false;
                }
                //TimeSpan ts = DateTime.Now.Subtract(StartTime);
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                //        ts.Hours, ts.Minutes, ts.Seconds,
                //        ts.Milliseconds / 10);
                // MessageBox.Show("UPDATECASH=" + elapsedTime);
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "{Pur.Voucher:IN:UPDATE CASH EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void TeldgView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!semaphore && !IsLoading && !OnExit && !IsAddingItem)
                {
                    if (!double.TryParse(TeldgView.Rows[e.RowIndex].Cells["Qty"].Value.ToString(), out TestParser))
                    {
                        TeldgView.Rows[e.RowIndex].Cells["Qty"].Value = 1;
                    }
                    if (!double.TryParse(TeldgView.Rows[e.RowIndex].Cells["DiscountPerc"].Value.ToString(), out TestParser))
                    {
                        TeldgView.Rows[e.RowIndex].Cells["DiscountPerc"].Value = 0;
                    }
                    if (!double.TryParse(TeldgView.Rows[e.RowIndex].Cells["DiscountPerc"].Value.ToString(), out TestParser))
                    {
                        TeldgView.Rows[e.RowIndex].Cells["DiscountPerc"].Value = 0;
                    }
                    if (!double.TryParse(TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value.ToString(), out TestParser))
                    {
                        TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value = -1;
                    }


                    QtyTemp = Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["Qty"].Value);
                    PricePerUnitTemp = Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value);
                    AvaQtyTemp = Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["AvalQty"].Value);
                    Discount = Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["DiscountPerc"].Value.ToString());
                    DataTable test = ItemsMgmt.SelectItemByBarCode(TeldgView.Rows[e.RowIndex].Cells["Barcode"].Value.ToString());
                    if (test != null)
                    {
                        AvgUnitCostTemp = Convert.ToDouble(test.Rows[0]["AvgUnitCost"].ToString());
                        if (PricePerUnitTemp < 0)
                        {
                            TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value = AvgUnitCostTemp;
                        }
                        TeldgView.Rows[e.RowIndex].Cells["PriceTotal"].Value = (QtyTemp * PricePerUnitTemp);// -((QtyTemp * PricePerUnitTemp) * Discount / 100);
                        if ((QtyTemp + AvaQtyTemp) == 0)
                        {
                            ++QtyTemp;
                        }
                        TeldgView.Rows[e.RowIndex].Cells["AvgUnitCost"].Value = (((AvaQtyTemp * AvgUnitCostTemp) + (QtyTemp * PricePerUnitTemp)) / (QtyTemp + AvaQtyTemp));
                        UpdateCash();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "{Pur.Voucher:IN:TeldgView_CellValueChanged EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion [UPDATING TEXTBOXES METHODS]

        private void UpdateCashBtns(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return || e.KeyChar == (int)Keys.Tab)
            { UpdateCash(); }
        }
        private void PaymentMethodCheckBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading && PaymentMethodCheckBox.SelectedValue != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "{Pur.Voucher:IN:PaymentMethodCheckBox_SelectedValueChanged EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateCash();
        }
        private void AccountComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading && AccountComboBox.SelectedValue != null)
                {
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(AccountComboBox.SelectedValue.ToString()));
                    if (AccountsMgmt.SelectAccountPaymentMethodByID(int.Parse(AccountComboBox.SelectedValue.ToString())) == int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()))
                    {

                        AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aAccountRow["CurrencyID"].ToString()));
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.AccountTxt + AccountComboBox.Text + " " + MsgTxt.DoNotAcceptTxt + " " + PaymentMethodCheckBox.Text, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                UpdateCash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "{Pur.Voucher:IN:PaymentMethodCheckBox_SelectedValueChanged EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CashMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CashMethodComboBox.SelectedIndex == 1)
                {
                    VendorAccountAmountLbl.Show();
                    VendorAccountAmountTxtBox.Show();
                    int VendorID = int.Parse(VendorsComboBox.SelectedValue.ToString());// CustomerMgmt.SelectCustomerIDByPhone1(PhoneTxtBox.Text);
                    aVendorAccount = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(VendorID);// CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                    if (aVendorAccount != null)
                    {
                        VendorAccountAmountTxtBox.Text = aVendorAccount["Amount"].ToString();
                        CashInTxtBox.Hide();
                        ExchangeTxtBox.Hide();
                        CashInLbl.Hide();
                        ExchangeLbl.Hide();
                        JODstatic.Hide();

                        IsCreditLbl.Show();
                        AccountDescriptionTxtBox.Hide();
                        AccountComboBox.Hide();
                        CashInCurrency.Hide();

                    }
                    else
                    {
                        MessageBox.Show("DB-ERROR: aVendorAccount --> Occured in Pur.Voucher: CashMethodComboBox_SelectedIndexChanged", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CashMethodComboBox.SelectedIndex = 0;
                    }

                }
                else
                {
                    VendorAccountAmountLbl.Hide();
                    VendorAccountAmountTxtBox.Hide();
                    CashInTxtBox.Show();
                    ExchangeTxtBox.Show();
                    CashInLbl.Show();
                    ExchangeLbl.Show();
                    JODstatic.Show();

                    IsCreditLbl.Hide();

                    AccountDescriptionTxtBox.Show();
                    AccountComboBox.Show();
                    CashInCurrency.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[Pur.Voucher:CashMethodComboBox_SelectedIndexChanged [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VendorsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!IsLoading && VendorsComboBox.SelectedValue != null)
            {
                aVendorDataRow = VendorsMgmt.SelectVendorRowByID(int.Parse(VendorsComboBox.SelectedValue.ToString()));
                if (aVendorDataRow != null)
                {
                    VendorDescriptionTxtBox.Text = aVendorDataRow["Company"].ToString();
                }
                else
                {
                    MessageBox.Show("DB-ERROR: aVendorDataRow --> Occured in Pur.Voucher: VendorsComboBox_SelectedValueChanged", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool Add_payment()
        {
            try
            {
                int NextCheckNumber = -1;
                UpdateCash();
                if (TeldgView.Rows.Count > 0)
                {
                    if (PaymentMethodCheckBox.SelectedValue == null)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.PaymentMethodTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                    if (aMethodRow == null)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.PaymentMethodTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    double TempCashIn = 0;
                    if (double.TryParse(CashInTxtBox.Text, out TempCashIn))
                    {
                        if (TempCashIn >= double.Parse(TotalTxtBox.Text) || CashMethodComboBox.SelectedIndex == 1 || aMethodRow["IsCash"].ToString() != "1")
                        {
                            DialogResult ret;
                            ret = MessageBox.Show(MsgTxt.SureToTakePaymentTxt + "\n" + MsgTxt.TotalAmountTxt + " : " + TotalTxtBox.Text + "\n" + MsgTxt.ExchangeTxt + " : " + ExchangeTxtBox.Text, MsgTxt.SureToTakePaymentTxt.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            if (ret == DialogResult.Yes)
                            {

                                PurchaseVoucherGeneral aPurchaseGeneral = new PurchaseVoucherGeneral();
                                Checks aCheck = new Checks();
                                aPurchaseGeneral.VoucherNumber = PurchaseVoucherGeneralMgmt.NextVoucherNumber();
                                if (aPurchaseGeneral.VoucherNumber == 0)
                                {
                                    MessageBox.Show(MsgTxt.UnexpectedError + "DB-ERROR-IN: Pur.Voucher [VoucherNumber==0]", MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                                aPurchaseGeneral.Date = DateTime.Now.ToShortDateString();
                                aPurchaseGeneral.Time = DateTime.Now.ToShortTimeString();
                                if (VendorsComboBox.SelectedValue == null)
                                {
                                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    VendorsComboBox.Focus();
                                    return false;
                                }
                                aPurchaseGeneral.VendorID = int.Parse(VendorsComboBox.SelectedValue.ToString());
                                aPurchaseGeneral.TotalFreeItemsQty = TotalFreeItemQty;
                                aPurchaseGeneral.TotalTax = TotalTax;
                                aPurchaseGeneral.Subtotal = Subtotal;
                                aPurchaseGeneral.DiscountPerc = double.Parse(DiscountPercTxtBox.Text);
                                aPurchaseGeneral.TotalDiscount = double.Parse(TotalDiscountTxtBox.Text);
                                aPurchaseGeneral.TotalCost = double.Parse(TotalTxtBox.Text);
                                aPurchaseGeneral.TellerID = UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName());
                                aPurchaseGeneral.Comments = CommentsTxtBox.Text.Trim();
                                aPurchaseGeneral.CurrencyID = 1;//JUST FOR NOW
                                aPurchaseGeneral.IsChecked = 0;
                                aPurchaseGeneral.IsRevised = 0;
                                aPurchaseGeneral.ReviseLoss = 0;
                                aPurchaseGeneral.Fees = double.Parse(FeesTxtBox.Text);//handled in Update Cash to insure its double
                                aPurchaseGeneral.TotalItemsDiscount = double.Parse(ItemsDiscountTxtBox.Text);
                                aPurchaseGeneral.PaymentMethodID = int.Parse(PaymentMethodCheckBox.SelectedValue.ToString());//handeled in if statement
                                if (AccountComboBox.SelectedValue == null)
                                {
                                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.AccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    AccountComboBox.Focus();
                                    return false;
                                }
                                aPurchaseGeneral.AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                //--------------------------------------------START METHOD
                                if (aMethodRow["IsCash"].ToString() == "1")
                                {
                                    aPurchaseGeneral.CreditCardInfo = "NOT-CREDIT";
                                    if (CashMethodComboBox.SelectedIndex == 1)
                                    {
                                        aPurchaseGeneral.IsCashCredit = 1;//Themam

                                        double OldAmount = double.Parse(aVendorAccount["Amount"].ToString());
                                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text);
                                        int VenAccountID = int.Parse(aVendorAccount["ID"].ToString());
                                        aPurchaseGeneral.VendorAccountAmountOld = OldAmount;
                                        VendorsAccountsMgmt.UpdateAccountAmountByAccountID(VenAccountID, NewAmount);
                                    }
                                    else//here it is cash we dont care about vendor/customer account OLD amount
                                    {
                                        aPurchaseGeneral.IsCashCredit = 0;
                                        aPurchaseGeneral.VendorAccountAmountOld = 0;

                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text); //HERE SIGN IS NEGATIVE
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }

                                }
                                else if (aMethodRow["IsCredit"].ToString() == "1")
                                {
                                    if (CreditCardInfoTxtBox.Text.Trim() != "")
                                    {
                                        aPurchaseGeneral.CreditCardInfo = CreditCardInfoTxtBox.Text;

                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text); ;//HERE SIGN IS NEGATIVE
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.PleaseAddCreditCardInfoTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        CreditCardInfoTxtBox.Focus();
                                        return false;
                                    }
                                }
                                else
                                {
                                    aPurchaseGeneral.CreditCardInfo = "NOT-CREDIT";
                                    //its check
                                    NextCheckNumber = ChecksMgmt.NextCheckNumber();
                                    aPurchaseGeneral.CheckNumber = NextCheckNumber;

                                    // aCheck.Chekcs_BankName = BanksComboBox.Text;
                                    if (HolderNameTxtBox.Text.Trim() != "")
                                    {
                                        aCheck.Chekcs_HolderName = HolderNameTxtBox.Text;
                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text); ;
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.CheckHolderNameTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        HolderNameTxtBox.Focus();
                                        return false;
                                    }
                                    aCheck.Chekcs_PaymentDate = CheckDatePicker.Value.ToShortDateString();
                                    aCheck.Chekcs_IsBill = 0;
                                    // aCheck.Chekcs_GeneralBillNumber = 
                                    aCheck.Chekcs_IsPurchaseVoucher = 1;
                                    aCheck.Chekcs_PurchaseVoucherNumber = aPurchaseGeneral.VoucherNumber;
                                    aCheck.Chekcs_AccountID = aPurchaseGeneral.AccountID;
                                    aCheck.Chekcs_Comments = CheckCommentsTxtBox.Text;
                                    aCheck.Chekcs_Amount = aPurchaseGeneral.TotalCost;
                                    aCheck.Chekcs_IsPaid = 0;
                                    aCheck.CheckNumber = NextCheckNumber;
                                    aCheck.AddingDate = DateTime.Now.ToShortDateString();
                                    aCheck.Chekcs_PaymentDate = CheckDatePicker.Text;
                                    aCheck.Chekcs_IsCustomerPayment = 0;
                                    aCheck.Chekcs_IsVendorPayment = 0;
                                    aCheck.Chekcs_IsCustomerPayment = 0;
                                    aCheck.Chekcs_IsVendorPayment = 0;
                                    if (ChecksMgmt.InsertCheck(aCheck))
                                    {
                                        MessageBox.Show(MsgTxt.ChequeTxt + " " + MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.ChequeTxt + " " + MsgTxt.NotAddedTxt, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        return false;
                                    }
                                }//-------------------------------END MOTHOD
                                if (PurchaseVoucherGeneralMgmt.AddVoucher(aPurchaseGeneral))
                                {

                                    PurchaseVoucherDetailed aPurchaseVoucherDetailed = new PurchaseVoucherDetailed();
                                    foreach (DataGridViewRow r in TeldgView.Rows)
                                    {
                                        if (!r.IsNewRow)
                                        {
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_Qty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_ItemCost = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_Discount = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["DiscountPerc"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_FreeItemsQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["FreeItemsQty"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_VoucherNumber = VoucherNumber;
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_OldAvgUnitCost = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                            aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_OldAvaQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvalQty"].Value.ToString());

                                            ItemsMgmt.UpdateItemQtyByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString(), ItemsMgmt.SelectItemQtyByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString()), (Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) + Convert.ToDouble(TeldgView.Rows[r.Index].Cells["FreeItemsQty"].Value.ToString())));//PositiveNum + Free Items
                                            ItemsMgmt.UpdateAvgUnitCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString(), Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvgUnitCost"].Value.ToString()));
                                            PurchaseVoucherDetailedMgmt.AddItem(aPurchaseVoucherDetailed);
                                        }
                                    }
                                }
                                else
                                {
                                    /* HERE WE SHOULD REMOVE ALL THE ROW
                               * FROM BILL DETAILED NUMBER THAT ARE
                               * RELATED TO BILL GENERAL NUMBER
                               * AND AFTER THAT REMOVE THE CHECK
                               * AND FINALLY REMOVE GENERAL BILL DETAILES*/
                                    PurchaseVoucherGeneralMgmt.DeleteVoucher(aPurchaseGeneral.VoucherNumber);
                                    PurchaseVoucherDetailedMgmt.DeleteVoucherByNumber(aPurchaseGeneral.VoucherNumber);
                                    if (NextCheckNumber != -1)
                                    {
                                        ChecksMgmt.DeleteCheckByCheckNumber(NextCheckNumber);
                                    }
                                }
                                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else //DIALOG
                            {
                                return false; //user select that he is not sure about taking this payment
                            }
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.CashLargerThanTotAmtTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            CashInTxtBox.Focus();
                            CashInTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        CashInTxtBox.Focus();
                        CashInTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.NotItemsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[Pur.Voucher:AddPayment [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        private void AddVoucherNoPrintBtn_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (ReturnChkBox.Checked)
            {
                if (AddReturnPayment())
                { reloadwindow(); }
                else
                {
                    // MessageBox.Show("Try Again Later");
                }
            }
            else
            {
                if (Add_payment())
                { reloadwindow(); }
                else
                {
                    // MessageBox.Show("Try Again Later");
                }
            }
            this.UseWaitCursor = false;
        }
        private void CashInTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            double TestP = 0.00;
            if (double.TryParse(CashInTxtBox.Text, out TestP))
            {
                if (e.KeyChar == (int)Keys.Return)
                    UpdateCash();
            }
        }
        private void OpenCashBtn_Click(object sender, EventArgs e)
        {
            PrintingManager.Instance.OpenCashDrawer();
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.PurchaseVoucherFormName;
                AccountLbl.Text = UiText.PrchVchAccountLbl;
                AddNewItemLbl.Text = UiText.PrchVchAddNewItemLbl;
                AddVoucherAndPrintBtn.Text = UiText.PrchVchAddVoucherAndPrintBtn;
                AddVoucherNoPrintBtn.Text = UiText.PrchVchAddVoucherNoPrintBtn;
                BarcodeLbl.Text = UiText.PrchVchBarcodeLbl;
                CashInCurrency.Text = UiText.PrchVchCashInCurrency;
                CashInLbl.Text = UiText.PrchVchCashInLbl;
                CashMethodLbl.Text = UiText.PrchVchCashMethodLbl;
                CashPaymentGB.Text = UiText.PrchVchCashPaymentGB;
                CheckCommentsLbl.Text = UiText.PrchVchCheckCommentsLbl;
                CheckGB.Text = UiText.PrchVchCheckGB;
                CheckHolderNameLbl.Text = UiText.PrchVchCheckHolderNameLbl;
                CheckNumber.Text = UiText.PrchVchCheckNumber;
                CompanyLbl.Text = UiText.PrchVchCompanyLbl;
                DiscountLbl.Text = UiText.PrchVchDiscountLbl;
                DiscountOnVouPercLbl.Text = UiText.PrchVchDiscountOnVouPercLbl;//@AYMAN-V01F should be Discount Percentage %
                ExchangeLbl.Text = UiText.PrchVchExchangeLbl;
                FeesLbl.Text = UiText.PrchVchFeesLbl;
                groupBox1.Text = UiText.PrchVchgroupBox1;
                IsCreditLbl.Text = UiText.PrchVchIsCreditLbl;
                ItemDescriptionLbl.Text = UiText.PrchVchItemDescriptionLbl;
                ItemsDiscountLbl.Text = UiText.PrchVchItemsDiscountLbl;
                ItemsWithoutBarcodeLbl.Text = UiText.PrchVchItemsWithoutBarcodeLbl;
                // JODstatic.Text = UiText.PrchVchJODstatic;
                PayInVisaGB.Text = UiText.PrchVchPayInVisaGB;
                PaymentCommentsLbl.Text = UiText.PrchVchPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.PrchVchPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.PrchVchPaymentMethodLbl;
                SubtotalLbl.Text = UiText.PrchVchSubtotalLbl;
                TaxLbl.Text = UiText.PrchVchTaxLbl;
                TotalBillLbl.Text = UiText.PrchVchTotalBillLbl;
                TotalDiscountLbl.Text = UiText.PrchVchTotalDiscountLbl;
                VendorAccountAmountLbl.Text = UiText.PrchVchVendorAccountAmountLbl;
                VendorLbl.Text = UiText.PrchVchVendorLbl;
                VoucherNumberLbl.Text = UiText.PrchVchVoucherNumberLbl;
                OpenCashBtn.Text = UiText.PrchVchOpenChashBtn;
                CommentsLbl.Text = UiText.PrchVchCommentsLblTxt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void reloadwindow()
        {
            try
            {
                IsLoading = true;
                ExchangeTxtBox.Clear();
                TotalTaxTxtBox.Clear();
                SubtotalTxtBox.Clear();
                DiscountPercTxtBox.Clear();
                DiscountTxtBox.Clear();

                CashMethodComboBox.SelectedIndex = 0;
                //Default Currency
                CheckDatePicker.MinDate = DateTime.Today;
                //Default Account
                int DefaultAccountID = AccountsMgmt.SelectDefaultAccountID();
                AccountComboBox.SelectedValue = DefaultAccountID.ToString();
                AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(DefaultAccountID);
                //Default Customer Name
                BarcodeTxtBox.Text = string.Empty;
                ItemDescriptionComboBox.SelectedText = string.Empty;
                // fillBy1ToolStripButton.PerformClick();
                IsLoading = false;
                //Default Payment Method
                DataRow aPaymentMethodRow = PaymentMethodMgmt.SelectDefaultPaymentMethod();
                PaymentMethodCheckBox.Text = aPaymentMethodRow["Name"].ToString();
                PaymentMethodCheckBox.SelectedValue = aPaymentMethodRow["ID"].ToString();
                PaymentMethodDescripTxtBox.Text = aPaymentMethodRow["Description"].ToString();
                TeldgView.Rows.Clear();
                CashInTxtBox.Text = "0.00";
                CashInTxtBox.BackColor = CashBGColor;
                UpdateCash();
                if (ReturnChkBox.Checked)
                {
                    PurchaseVoucherNumTxtBox.Text = ReturnItemsVendorGeneralMgmt.NextReturnVendorNumber().ToString();
                }
                else
                {
                    PurchaseVoucherNumTxtBox.Text = PurchaseVoucherGeneralMgmt.NextVoucherNumber().ToString();
                }

                TranslateUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[Pur.Voucher:reloadwindow [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.F4:
                    //Process action here.

                    AddVoucherNoPrintBtn.PerformClick();
                    break;
                case Keys.F2:
                    //Process action here.
                    AddVoucherAndPrintBtn.PerformClick();
                    break;
                case Keys.Escape:
                    reloadwindow();
                    break;
                case Keys.Delete:
                    DeleteItemsBtn.PerformClick();
                    break;
                case Keys.Add:
                    IncreaseBtn.PerformClick();
                    break;
                case Keys.Subtract:
                    DecreaseBtn.PerformClick();
                    break;
                case Keys.F6:
                    OpenCashBtn.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref message, keys);
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
        double OverrideError;
        private void IncreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                semaphore = true;
                //DateTime StartTime = DateTime.Now;
                foreach (DataGridViewRow row in TeldgView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        if (double.TryParse(TeldgView.Rows[row.Index].Cells["Qty"].Value.ToString(), out OverrideError))
                        {
                            TeldgView.Rows[row.Index].Cells["Qty"].Value = OverrideError + 1;
                        }
                        else
                        {
                            TeldgView.Rows[row.Index].Cells["Qty"].Value = 1;
                        }

                    }
                }

                //TimeSpan ts = DateTime.Now.Subtract(StartTime);
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                //        ts.Hours, ts.Minutes, ts.Seconds,
                //        ts.Milliseconds / 10);
                // MessageBox.Show("IncreaseBtn_Click=" + elapsedTime);
                semaphore = false;
                UpdateCash();
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [Pur.Voucher:IncreaseBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DecreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                semaphore = true;
                foreach (DataGridViewRow row in TeldgView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        if (double.TryParse(TeldgView.Rows[row.Index].Cells["Qty"].Value.ToString(), out OverrideError))
                        {
                            if (OverrideError > 1)
                            {
                                TeldgView.Rows[row.Index].Cells["Qty"].Value = OverrideError - 1;
                            }
                            else
                            {
                                return;
                            }

                        }
                        else
                        {
                            TeldgView.Rows[row.Index].Cells["Qty"].Value = 1;
                        }
                    }
                }

                semaphore = false;
                UpdateCash();
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [Pur.Voucher:DecreaseBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                semaphore = true;
                foreach (DataGridViewRow row in TeldgView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        TeldgView.Rows.Remove(row);
                    }
                }

                semaphore = false;
                UpdateCash();
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[Pur.Voucher:DeleteItemsBtn_Click [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddVoucherAndPrintBtn_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (ReturnChkBox.Checked)
            {
                if (AddReturnPayment())
                {
                    if (!PrintReturnReceipt())
                    {
                        MessageBox.Show(MsgTxt.PrintingErrorTxt + " " + MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reloadwindow();
                }
            }
            else
            {
                if (Add_payment())
                {
                    if (!print_receipt())
                    {
                        MessageBox.Show(MsgTxt.PrintingErrorTxt + " " + MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reloadwindow();
                }
            }
            this.UseWaitCursor = false;
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
                aDataTable1.Columns.Add(ReceiptText.RctTxtFreeItems);

                #region Calculating Tax Based On Levels
                DataTable TaxLevels = new DataTable();
                TaxLevels.Columns.Add("TaxLevel");
                TaxLevels.Columns.Add("Amount");
                #endregion Calculating Tax Based On Levels


                bool NoDiscount = true;
                bool NoFreeItems = true;
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
                    aDataTable1.Rows[aRow.Index][5] = aRow.Cells["FreeItemsQty"].Value.ToString();
                    if (double.Parse(aRow.Cells["FreeItemsQty"].Value.ToString()) > 0)
                    {
                        NoFreeItems = false;
                    }

                    #region Calculating Tax Based On Levels
                    bool TaxExistInTbl = false;
                    foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                    {
                        if (aTaxLevelRow["TaxLevel"].ToString() == aRow.Cells["Tax"].Value.ToString())
                        {
                            TaxExistInTbl = true;
                            double ItemTax = Math.Round((double.Parse(aRow.Cells["Tax"].Value.ToString()) / 100 * double.Parse(aRow.Cells["PriceTotal"].Value.ToString())), 3);
                            aTaxLevelRow["Amount"] = double.Parse(aTaxLevelRow["Amount"].ToString()) + ItemTax;
                            break;
                        }
                        else
                        {

                        }
                    }
                    if (!TaxExistInTbl)
                    {
                        DataRow NewTaxRow = TaxLevels.Rows.Add();
                        NewTaxRow["TaxLevel"] = aRow.Cells["Tax"].Value.ToString();
                        NewTaxRow["Amount"] = Math.Round((double.Parse(aRow.Cells["Tax"].Value.ToString()) / 100 * double.Parse(aRow.Cells["PriceTotal"].Value.ToString())), 3).ToString();
                    }
                    else
                    {

                    }
                    #endregion Calculating Tax Based On Levels
                }

                if (NoDiscount)
                {
                    aDataTable1.Columns.Remove(aDataTable1.Columns[4]);
                    if (NoFreeItems)
                    {
                        aDataTable1.Columns.Remove(aDataTable1.Columns[4]);
                    }
                }
                else if (NoFreeItems)
                {
                    aDataTable1.Columns.Remove(aDataTable1.Columns[5]);
                }
                int RowCnt = 0;
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                RowCnt = 0;

                #region Adding Tax Based On TaxLevels
                foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax + " " + aTaxLevelRow["TaxLevel"].ToString() + " %";
                    aDataTable3.Rows[RowCnt++][1] = aTaxLevelRow["Amount"].ToString() + "<b> JOD";
                }
                #endregion Adding Tax Based On TaxLevels

                //aDataTable3.Rows.Add(); ;
                //aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax;
                //aDataTable3.Rows[RowCnt++][1] = TotalTaxTxtBox.Text + "<b> JOD";

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
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

                aStringList.Add("<h2> " + ReceiptText.RctTxtVendor + ":&nbsp;&nbsp;" + VendorsComboBox.Text + "</h2>");


                aStringList.Add(ReceiptText.RctTxtPurchaseNumber + ":&nbsp; " + PurchaseVoucherNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf");
                if (PrintingThermalA4ChkBox.Checked)
                {
                    Process.Start(ReportsHelper.TempPDFOutputPath);

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[PurchaseVoucher:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void ReturnChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReturnChkBox.Checked)
            {
                TransformToReturn();
            }
            else
            {
                TransformToSale();
            }
        }
        #region Returns

        private void TransformToReturn()
        {
            this.BackColor = Color.Silver;

            PaymentMethodCheckBox.SelectedIndex = 0;

            CashPaymentGB.Show();
            CashPaymentGB.BringToFront();
            PayInVisaGB.Hide();
            CheckGB.Hide();

            AccountComboBox.Enabled = false;
            PaymentMethodCheckBox.Enabled = false;

            CashInTxtBox.Enabled = false;
            ExchangeTxtBox.Enabled = false;
            PurchaseVoucherNumTxtBox.Text = ReturnItemsVendorGeneralMgmt.NextReturnVendorNumber().ToString();
        }

        private void TransformToSale()
        {
            this.BackColor = aThisBGColor;

            AccountComboBox.Enabled = true;
            PaymentMethodCheckBox.Enabled = true;

            CashInTxtBox.Enabled = true;
            ExchangeTxtBox.Enabled = true;

            PurchaseVoucherNumTxtBox.Text = PurchaseVoucherGeneralMgmt.NextVoucherNumber().ToString();
        }

        private ReturnItemsVendorGeneral PreperaReturnClassObject()
        {
            try
            {
                ReturnItemsVendorGeneral aReturnItemsVendorGeneral = new ReturnItemsVendorGeneral();
                aReturnItemsVendorGeneral.Number = ReturnItemsVendorGeneralMgmt.NextReturnVendorNumber();
                aReturnItemsVendorGeneral.Date = DateTime.Now.ToShortDateString();
                aReturnItemsVendorGeneral.Time = DateTime.Now.ToShortTimeString();
                if (VendorsComboBox.SelectedValue == null)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    VendorsComboBox.Focus();
                    return null;
                }
                aReturnItemsVendorGeneral.VendorID = int.Parse(VendorsComboBox.SelectedValue.ToString());

                aReturnItemsVendorGeneral.TotalTax = TotalTax;
                aReturnItemsVendorGeneral.Subtotal = Subtotal;
                aReturnItemsVendorGeneral.DiscountPerc = double.Parse(DiscountPercTxtBox.Text);
                aReturnItemsVendorGeneral.TotalDiscount = double.Parse(TotalDiscountTxtBox.Text);
                aReturnItemsVendorGeneral.TotalCost = double.Parse(TotalTxtBox.Text);
                aReturnItemsVendorGeneral.TellerID = UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName());
                aReturnItemsVendorGeneral.Comments = CommentsTxtBox.Text.Trim();

                aReturnItemsVendorGeneral.IsChecked = 0;
                aReturnItemsVendorGeneral.IsRevised = 0;

                aReturnItemsVendorGeneral.Fees = double.Parse(FeesTxtBox.Text);//handled in Update Cash to insure its double
                aReturnItemsVendorGeneral.TotalItemsDiscount = double.Parse(ItemsDiscountTxtBox.Text);

                if (AccountComboBox.SelectedValue == null)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.AccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    AccountComboBox.Focus();
                    return null;
                }
                aReturnItemsVendorGeneral.AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());

                if (CashMethodComboBox.SelectedIndex == 1)
                {
                    aReturnItemsVendorGeneral.IsCashCredit = 1;//Themam

                    double OldAmount = double.Parse(aVendorAccount["Amount"].ToString());
                    double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text);
                    int VenAccountID = int.Parse(aVendorAccount["ID"].ToString());
                    aReturnItemsVendorGeneral.VendorAccountAmountOld = OldAmount;
                    VendorsAccountsMgmt.UpdateAccountAmountByAccountID(VenAccountID, NewAmount);
                }
                else//here it is cash we dont care about vendor/customer account OLD amount
                {
                    aReturnItemsVendorGeneral.IsCashCredit = 0;
                    aReturnItemsVendorGeneral.VendorAccountAmountOld = 0;
                    int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                    double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                    double NewAmount = OldAmount - double.Parse(TotalTxtBox.Text); //HERE SIGN IS NEGATIVE
                    AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                }

                return aReturnItemsVendorGeneral;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private bool AddReturnPayment()
        {
            try
            {
                UpdateCash();
                semaphore = true;
                if (TeldgView.Rows.Count > 0)
                {
                    DialogResult ret;
                    ret = MessageBox.Show(MsgTxt.SureToTakePaymentTxt, MsgTxt.SureToTakePaymentTxt.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        ReturnItemsVendorGeneral aReturnItemsVendorGeneral = PreperaReturnClassObject();
                        if (aReturnItemsVendorGeneral == null)
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return false;
                        }

                        if (ReturnItemsVendorGeneralMgmt.AddVoucher(aReturnItemsVendorGeneral))
                        {
                            ReturnItemsVendorDetailed aReturnItemsVendorDetailed = new ReturnItemsVendorDetailed();
                            foreach (DataGridViewRow r in TeldgView.Rows)
                            {
                                if (!r.IsNewRow)
                                {
                                    aReturnItemsVendorDetailed.ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                    aReturnItemsVendorDetailed.Qty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                                    aReturnItemsVendorDetailed.ItemCost = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                    aReturnItemsVendorDetailed.Discount = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["DiscountPerc"].Value.ToString());
                                    aReturnItemsVendorDetailed.FreeItemsQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["FreeItemsQty"].Value.ToString());
                                    aReturnItemsVendorDetailed.Number = aReturnItemsVendorGeneral.Number;
                                    aReturnItemsVendorDetailed.OldAvgUnitCost = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                    aReturnItemsVendorDetailed.OldAvaQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvalQty"].Value.ToString());
                                    string Barcode = TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString();
                                    double OldQty = ItemsMgmt.SelectItemQtyByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                    double QtyAdded = (Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) + Convert.ToDouble(TeldgView.Rows[r.Index].Cells["FreeItemsQty"].Value.ToString()));
                                    ItemsMgmt.UpdateItemQtyByBarcode(Barcode, OldQty, (0 - QtyAdded));//PositiveNum + Free Items
                                    ItemsMgmt.UpdateAvgUnitCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString(), Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvgUnitCost"].Value.ToString()));
                                    ReturnItemsVendorDetailedMgmt.AddItem(aReturnItemsVendorDetailed);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.TransactionNotAddedSuccessfullyTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else //DIALOG
                    {
                        return false; //user select that he is not sure about taking this payment
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.NotItemsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[POS:AddReturnPayment [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                semaphore = false;
            }
            semaphore = false;
        }

        private bool PrintReturnReceipt()
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
                aDataTable1.Columns.Add(ReceiptText.RctTxtFreeItems);

                #region Calculating Tax Based On Levels
                DataTable TaxLevels = new DataTable();
                TaxLevels.Columns.Add("TaxLevel");
                TaxLevels.Columns.Add("Amount");
                #endregion Calculating Tax Based On Levels


                bool NoDiscount = true;
                bool NoFreeItems = true;
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
                    aDataTable1.Rows[aRow.Index][5] = aRow.Cells["FreeItemsQty"].Value.ToString();
                    if (double.Parse(aRow.Cells["FreeItemsQty"].Value.ToString()) > 0)
                    {
                        NoFreeItems = false;
                    }

                    #region Calculating Tax Based On Levels
                    bool TaxExistInTbl = false;
                    foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                    {
                        if (aTaxLevelRow["TaxLevel"].ToString() == aRow.Cells["Tax"].Value.ToString())
                        {
                            TaxExistInTbl = true;
                            double ItemTax = Math.Round((double.Parse(aRow.Cells["Tax"].Value.ToString()) / 100 * double.Parse(aRow.Cells["PriceTotal"].Value.ToString())), 3);
                            aTaxLevelRow["Amount"] = double.Parse(aTaxLevelRow["Amount"].ToString()) + ItemTax;
                            break;
                        }
                        else
                        {

                        }
                    }
                    if (!TaxExistInTbl)
                    {
                        DataRow NewTaxRow = TaxLevels.Rows.Add();
                        NewTaxRow["TaxLevel"] = aRow.Cells["Tax"].Value.ToString();
                        NewTaxRow["Amount"] = Math.Round((double.Parse(aRow.Cells["Tax"].Value.ToString()) / 100 * double.Parse(aRow.Cells["PriceTotal"].Value.ToString())), 3).ToString();
                    }
                    else
                    {

                    }
                    #endregion Calculating Tax Based On Levels
                }

                if (NoDiscount)
                {
                    aDataTable1.Columns.Remove(aDataTable1.Columns[4]);
                }
                if (NoFreeItems)
                {
                    aDataTable1.Columns.Remove(aDataTable1.Columns[5]);
                }
                int RowCnt = 0;
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                RowCnt = 0;

                #region Adding Tax Based On TaxLevels
                foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax + " " + aTaxLevelRow["TaxLevel"].ToString() + " %";
                    aDataTable3.Rows[RowCnt++][1] = aTaxLevelRow["Amount"].ToString() + "<b> JOD";
                }
                #endregion Adding Tax Based On TaxLevels
                //aDataTable3.Rows.Add();
                //aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax;
                //aDataTable3.Rows[RowCnt++][1] = TotalTaxTxtBox.Text + "<b> JOD";

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
                aDataTable3.Rows[RowCnt++][1] = "<td style=\"background-color:#000;color:#fff;border-left-color:#fff\"><b><font size=5>" + "-" + TotalTxtBox.Text + " JOD </font>";

                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayMethod;
                aDataTable3.Rows[RowCnt++][1] = PaymentMethodCheckBox.Text;

                if (CashMethodComboBox.Text == "Invoice")
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayable;
                    double VendorAccountAmountParserChk = 0;
                    if (double.TryParse(VendorAccountAmountTxtBox.Text, out VendorAccountAmountParserChk))
                    {
                        aDataTable3.Rows[RowCnt++][1] = ReceiptText.RctTxtOldBalance + " = " + VendorAccountAmountParserChk + "&nbsp;&nbsp;" + SharedVariables.Line_Solid_10px_Black +
                                 ReceiptText.RctTxtNewBalance + " = " + Math.Round((VendorAccountAmountParserChk - double.Parse(TotalTxtBox.Text)), 3);
                    }
                }


                aDataTableList.Add(aDataTable1);
                // aDataTableList.Add(aDataTable2);
                aDataTableList.Add(aDataTable3);

                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsVendorReturns);
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

                aStringList.Add("<h2> " + ReceiptText.RctTxtVendor + ":&nbsp;&nbsp;" + VendorsComboBox.Text + "</h2>");


                aStringList.Add(ReceiptText.RctTxtRetVenInvNum + ":&nbsp; " + PurchaseVoucherNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf");
                if (PrintingThermalA4ChkBox.Checked)
                {
                    Process.Start(ReportsHelper.TempPDFOutputPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[PurchaseVoucher:PrintReturnReceipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion Returns
    }
}
