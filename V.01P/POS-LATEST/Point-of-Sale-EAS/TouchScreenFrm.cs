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
using Calcium_RMS.Reports;
using Calcium_RMS.Text;
using System.Diagnostics;


namespace Calcium_RMS
{
    public partial class TouchScreenFrm : Form
    {
        DataTable aCustomerScreenDataTable;
        public DateTime StartTime;
        Color aThisBGColor;
        bool IsAddingItem = false;
        bool IsLoading = true;
        bool OnExit = false;
        bool IsClosing = false;
        int isclosed = 0;
        bool semaphore = false;
        DataTable TouchScreenItems = null;
        DataTable TouchScreenCategories = null;
        DataRow aCustomerAccount = null;

        DataTable SpecialPricesTable = null;
        int DivisionScale = 1;
        int BarcodeLength = 1;
        bool aThereIsWeigth = false;

        double Subtotal = 0, TotalTax = 0, SubtotalTemp = 0, TaxTemp = 0, TotalCost = 0;
        double TotalPriceLevelDiscount = 0, PriceLevelTemp = 0;
        public TouchScreenFrm()
        {
            // StartTime = DateTime.Now;
            // ControlHelper.SuspendDrawing(this);
            //this.SuspendLayout();
            IsLoading = true;
            InitializeComponent();

            aColor[0] = Color1;
            aColor[1] = Color2;
            aColor[2] = Color3;
            aColor[3] = Color4;
            aColor[4] = Color5;
            aColor[5] = Color6;
            aColor[6] = Color7;

            aThisBGColor = this.BackColor;
            TouchScreenItems =ItemsMgmt.SelectAllTouchScreenItems(); //@Sari Bug fix in version 01E
            TouchScreenCategories = ItemCategoryMgmt.SelectTouchScreenCategories();
            SpecialPricesTable = SpecialPricesMgmt.SelectAllPriceLevels();
            CashInTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            PhoneTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);
            DiscountPercTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);

            CashInTxtBox.GotFocus += new EventHandler(ShowNumpad);
            PhoneTxtBox.GotFocus += new EventHandler(ShowNumpad);
            DiscountPercTxtBox.GotFocus += new EventHandler(ShowNumpad);

            CashInTxtBox.LostFocus += new EventHandler(HideNumpad);
            PhoneTxtBox.LostFocus += new EventHandler(HideNumpad);
            DiscountPercTxtBox.LostFocus += new EventHandler(HideNumpad);

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            //Add this Line To Each Constructor To Disable Maximize
            TranslateUI();
            AddEvent(this);
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
            
            IsLoading = false;
            // this.ResumeLayout();
            /* ControlHelper.ResumeDrawing(this, false);

              TimeSpan ts = DateTime.Now.Subtract(StartTime);
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds / 10);
            
             // MessageBox.Show("CONSTRUCTO="+elapsedTime);*/
        }

        private void TouchScreenFrm_Load(object sender, EventArgs e)
        {
            try
            {
                IsLoading = true;
                //ControlHelper.SuspendDrawing(this);
                // this.SuspendLayout();
                // TODO: This line of code loads data into the 'dBDataSet.PriceLevels' table. You can move, or remove it, as needed.
                this.priceLevelsTableAdapter.Fill(this.dBDataSet.PriceLevels);
                // TODO: This line of code loads data into the 'dBDataSet.Currency' table. You can move, or remove it, as needed.
                this.currencyTableAdapter.Fill(this.dBDataSet.Currency);
                // TODO: This line of code loads data into the 'dBDataSet.Accounts' table. You can move, or remove it, as needed.
                this.accountsTableAdapter.Fill(this.dBDataSet.Accounts);
                // TODO: This line of code loads data into the 'dBDataSet.PaymentMethod' table. You can move, or remove it, as needed.
                this.paymentMethodTableAdapter.Fill(this.dBDataSet.PaymentMethod);
                CashMethodComboBox.SelectedIndex = 0;
                //Default Currency
                CheckDatePicker.MinDate = DateTime.Today;
                int DefaultCurrencyID = CurrencyMgmt.SelectDefaultCurrencyID();
                CurrencyComboBox.SelectedValue = DefaultCurrencyID.ToString();
                SellRateTxtBox.Text = CurrencyMgmt.SelectSellRateByID(DefaultCurrencyID).ToString();
                BuyRateTxtBox.Text = CurrencyMgmt.SelectBuyRateByID(DefaultCurrencyID).ToString();
                CashInCurrency.Text = CurrencyMgmt.SelectCurrencyNameByID(DefaultCurrencyID);

                //Default Account
                int DefaultAccountID = AccountsMgmt.SelectDefaultAccountID();
                AccountComboBox.SelectedValue = DefaultAccountID.ToString();
                AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(DefaultAccountID);

                //Default Customer Name
                PhoneTxtBox.Text = "00";
                CustomerNameTxtBox.Text = "CASH";

                DateTime temp = DateTime.Now;
                TeldgView.Columns["Barcode"].ReadOnly = true;
                TeldgView.Columns["Description"].ReadOnly = true;
                TeldgView.Columns["Qty"].ReadOnly = false;
                TeldgView.Columns["PricePerUnit"].ReadOnly = true;
                TeldgView.Columns["PriceTotal"].ReadOnly = true;
                TeldgView.Columns["Tax"].ReadOnly = true;
                TeldgView.Columns["AvalQty"].ReadOnly = true;

                InvoiceNumTxtBox.Text = BillGeneralMgmt.NextBillNumber().ToString();
                // fillBy1ToolStripButton.PerformClick();
                //Default Payment Method
                DataRow aPaymentMethodRow = PaymentMethodMgmt.SelectDefaultPaymentMethod();
                PaymentMethodCheckBox.Text = aPaymentMethodRow["Name"].ToString();
                PaymentMethodCheckBox.SelectedValue = aPaymentMethodRow["ID"].ToString();
                PaymentMethodDescripTxtBox.Text = aPaymentMethodRow["Description"].ToString();




                AddTabPages();
                AddItemsToTabPages();

                aCustomerScreenDataTable = new DataTable();
                aCustomerScreenDataTable.Columns.Add("Description");
                aCustomerScreenDataTable.Columns.Add("UnitPrice");
                aCustomerScreenDataTable.Columns.Add("TaxLevel");
                aCustomerScreenDataTable.Columns.Add("Quantity");
                aCustomerScreenDataTable.Columns.Add("Total");

                IsLoading = false;

                //  this.ResumeLayout();
                // ControlHelper.ResumeDrawing(this);
                /* TimeSpan ts = DateTime.Now.Subtract(StartTime);
                 string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                         ts.Hours, ts.Minutes, ts.Seconds,
                         ts.Milliseconds / 10);

                // MessageBox.Show("LOAD=" + elapsedTime);*/
            }
            catch (Exception ex)
            {
                IsLoading = false;
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[TouchScreenFrm_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AddItemsToTabPages()
        {
            int counter = 0;
            try
            {
                foreach (TabPage atp in atab.TabPages)
                {
                    FlowLayoutPanel aFlp = new FlowLayoutPanel();

                    foreach (DataRow aRow in TouchScreenItems.Rows)
                    {

                        aFlp.Dock = DockStyle.Fill;
                        if (aRow["Category"].ToString() == atp.Tag.ToString())
                        {
                            Button aButton = new Button();
                            aButton.Tag = aRow["Barcode"].ToString();
                            aButton.Text = aRow["Description"].ToString();
                            aButton.Size = new Size(100, 100);
                            aButton.Font = new Font("Century Gothic", 14,FontStyle.Bold);
                            aButton.FlatStyle = FlatStyle.Flat;
                            aButton.Cursor = Cursors.Hand;
                            aButton.ForeColor = Color.White;
                            aButton.Click += new EventHandler(AddItemBtn);
                            aButton.KeyPress += new KeyPressEventHandler(aButton_KeyPress);
                            aFlp.Controls.Add(aButton);
                            aFlp.AutoScroll = true;
                        }
                        if (counter++ > 1000) { counter = 0;break;}
                    }
                    atp.Controls.Add(aFlp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddItemsToTabPages] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void aButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
            if (elapsed.TotalMilliseconds > 100)
                _barcode.Clear();
            // record keystroke & timestamp
            _barcode.Add(e.KeyChar);
            _lastKeystroke = DateTime.Now;
            // process barcode
            if (e.KeyChar == (int)Keys.Enter && _barcode.Count > 5)
            {
                if (BarcodeTxtBox.ContainsFocus)
                {
                    return;
                }
                MessageBox.Show("Warning! Item Not Added Please Select Barcode Text Box", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
                string msg = new String(_barcode.ToArray());
                msg = msg.Replace("\r", "");
                AddItemUsingBarcode(msg, true);
                _barcode.Clear();
                e.Handled = false;
            }
        }

        #region [BARCODE FUNCTIONS]
        DateTime _lastKeystroke = new DateTime(0);
        List<char> _barcode = new List<char>(10);
        private void AddEvent(Control parentCtrl)
        {
            parentCtrl.KeyPress += new KeyPressEventHandler(ReadBarcodeGun);
            foreach (Control c in parentCtrl.Controls)
            {

                c.KeyPress += new KeyPressEventHandler(ReadBarcodeGun);
                AddEvent(c);

            }
        }
        private void BarcodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DateTime StartTime = DateTime.Now;
            if (e.KeyChar == (int)Keys.Return)
            {
                AddItemUsingBarcode(BarcodeTxtBox.Text, true);
                UpdateCash();
                if (BarcodeTxtBox.ContainsFocus)
                {
                    BarcodeTxtBox.Text = string.Empty; 
                }
                else
                {
                    BarcodeTxtBox.Text = "Barcode Scanner Here";
                }
            }
            else if ((e.KeyChar.ToString() == "+" || e.KeyChar.ToString() == "-") && BarcodeTxtBox.Text == "")
            {
                e.Handled = true; //do not put it in the field
            }
            ////ADDING ITEM STATISTICS
            //TimeSpan ts = DateTime.Now.Subtract(StartTime);
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //        ts.Hours, ts.Minutes, ts.Seconds,
            //        ts.Milliseconds / 10);
            ////MessageBox.Show("Elasped Time in Seconds for Select Barcode from [10,000] items [TRIAL 2 new code] is =" + elapsedTime);
        }
        private void ReadBarcodeGun(object sender, KeyPressEventArgs e)
        {
            try
            {
                // check timing (keystrokes within 100 ms)
                TimeSpan elapsed = (DateTime.Now - _lastKeystroke);
                if (elapsed.TotalMilliseconds > 100)
                    _barcode.Clear();
                // record keystroke & timestamp
                _barcode.Add(e.KeyChar);
                _lastKeystroke = DateTime.Now;
                // process barcode
                if (e.KeyChar == (int)Keys.Enter && _barcode.Count > 5)
                {
                    if (BarcodeTxtBox.ContainsFocus)
                    {
                        return;
                    }
                    MessageBox.Show("Warning! Item Not Added Please Select Barcode Text Box",MsgTxt.WarningCaption,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                    string msg = new String(_barcode.ToArray());
                    msg = msg.Replace("\r", "");
                    AddItemUsingBarcode(msg, true);
                    _barcode.Clear();
                    e.Handled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ReadBarcodeGun] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void AddItemUsingBarcode(string aBarcode, bool IsFromGun = false)
        {
            IsAddingItem = false;
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
                        TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
                        TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
                        TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["SellPrice"].ToString();
                        if (dowgt)
                        {
                            TeldgView.Rows[RowNum].Cells["Qty"].Value = Math.Round((TotwgtPrice / DivisionScale) / (double.Parse(aItemTable.Rows[0]["SellPrice"].ToString()) * (1 + TaxPer / 100)), 3);
                        }
                        else
                        {
                            TeldgView.Rows[RowNum].Cells["Qty"].Value = 1;
                        }
                        TeldgView.Rows[RowNum].Cells["PriceTotal"].Value = Math.Round(double.Parse(TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[RowNum].Cells["Qty"].Value.ToString()), 3);
                        TeldgView.Rows[RowNum].Cells["Tax"].Value = TaxPer;
                        TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aItemTable.Rows[0]["Qty"].ToString();
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddItemUsingBarcode] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            IsAddingItem = false;
        }
        private void AddItemBtn(object sender, EventArgs e)
        {
            Button aButton = (Button)sender;
            AddItemUsingBarcode(aButton.Tag.ToString());
            UpdateCash();
            BarcodeTxtBox.Focus();
            //DataTable aItemTable = ItemsMgmt.SelectItemByBarCode(aButton.Tag.ToString());
            //if (aItemTable.Rows.Count == 1)
            //{
            //    foreach (DataGridViewRow r in TeldgView.Rows)
            //    {
            //        if (TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString() == aItemTable.Rows[0]["Barcode"].ToString())
            //        {
            //            TeldgView.ClearSelection();
            //            TeldgView.Rows[r.Index].Cells["Qty"].Value = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) + 1;
            //            TeldgView.Rows[r.Index].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString()), 3);
            //            TeldgView.Rows[r.Index].Selected = true;
            //            UpdateCash();
            //            return;
            //        }
            //    }
            //    IsAddingItem = true;
            //    TeldgView.ClearSelection();
            //    int RowNum = TeldgView.Rows.Add();
            //    TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
            //    TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
            //    TeldgView.Rows[RowNum].Cells["Qty"].Value = 1;
            //    TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["SellPrice"].ToString();
            //    TeldgView.Rows[RowNum].Cells["PriceTotal"].Value = double.Parse(TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value.ToString()) * Convert.ToInt32(TeldgView.Rows[RowNum].Cells["Qty"].Value.ToString());
            //    TeldgView.Rows[RowNum].Cells["Tax"].Value = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemTable.Rows[0]["TaxLevel"].ToString()));
            //    TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aItemTable.Rows[0]["Qty"].ToString();
            //    TeldgView.Rows[RowNum].Selected = true;

            //    UpdateCash();
            //}
            //else
            //{
            //    MessageBox.Show("Item Not Found");
            //}
            //IsAddingItem = false;
        }
        #endregion [BARCODE FUNCTIONS]

        Color Color1 = Color.FromArgb(156,143,49);
        Color Color2 = Color.FromArgb(160,173,57);
        Color Color3 = Color.FromArgb(240,192,130);
        Color Color4 = Color.FromArgb(244,175,48);
        Color Color5 = Color.FromArgb(215,94,39);
        Color Color6 = Color.FromArgb(183,87,39);
        Color Color7 = Color.FromArgb(103, 33, 69);

        Color[] aColor = new Color[7];
        
        private void AddTabPages()
        {
            try
            {
                int Cnt = 0;
                foreach (DataRow aRow in TouchScreenCategories.Rows)
                {
                    //TabPage aTabPage = new TabPage();
                    //aTabPage.Text = aRow["Name"].ToString();
                    //aTabPage.Tag = aRow["ID"].ToString();
                    //aTabPage.AutoScroll = true;
                    //atab.TabPages.Add(aTabPage);

                    //-------------------------------------
                    Font __fonttemp = this.Font;
                    Color __backcolortemp = this.BackColor;
                    Color __forcecolortemp = this.ForeColor;
                    //Added new TabPage
                    TabPage tbp = new TabPage();
                    tbp.Text = aRow["Name"].ToString();
                    tbp.Text += "     ";
                    tbp.BackColor = aColor[Cnt++%7];
                    tbp.Tag = aRow["ID"].ToString();
                    // tbp.ImageIndex = 0;              
                    tbp.AutoScroll = true;
                    atab.TabPages.Add(tbp);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddTabPages] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UpdateCash()
        {

            //  StartTime = DateTime.Now;
            try
            {
                if (!IsLoading && !OnExit)
                {
                    BarcodeTxtBox.Focus();
                    aCustomerScreenDataTable.Rows.Clear();
                    semaphore = true;
                    DataRow DR = CustomerMgmt.SelectCustomerByPhone1(PhoneTxtBox.Text);
                    if (DR != null)
                    {
                        CustomerNameTxtBox.Text = DR["Name"].ToString();
                    }
                    else
                    {
                        PhoneTxtBox.Text = "00";
                        CustomerNameTxtBox.Text = "CASH";
                    }

                    Subtotal = 0; TotalTax = 0; SubtotalTemp = 0; TaxTemp = 0; TotalCost = 0;
                    TotalPriceLevelDiscount = 0; PriceLevelTemp = 0;
                    double PriceLvlDiscountTemp = 0;

                    foreach (DataGridViewRow r in TeldgView.Rows)
                    {
                        if (CustomerScreenChkBox.Checked)
                        {
                            DataRow aRow = aCustomerScreenDataTable.Rows.Add();
                            aRow["Description"] = r.Cells["Description"].Value.ToString();
                            aRow["UnitPrice"] = r.Cells["PricePerUnit"].Value.ToString();
                            aRow["TaxLevel"] = r.Cells["Tax"].Value.ToString();
                            aRow["Quantity"] = r.Cells["Qty"].Value.ToString();
                            aRow["Total"] = r.Cells["PriceTotal"].Value.ToString();
                        }
                        if (!r.IsNewRow && !IsClosing && !OnExit)
                        {
                            //PriceLevelSelection
                            DataRow aItemRow = null;// ItemsMgmt.SelectItemRowByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            foreach (DataRow rinner in TouchScreenItems.Rows)
                            {
                                if (rinner["Barcode"].ToString() == TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString())
                                {
                                    aItemRow = rinner;
                                    break;
                                }
                            }


                            if (aItemRow == null)
                            {
                                continue;
                            }
                            if (!OnExit)
                            {
                                TeldgView.Rows[r.Index].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString()), 3);

                                SubtotalTemp = Math.Round(double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString()), 3);
                                PriceLevelTemp = SubtotalTemp;
                                if (PriceLevelComboBox.SelectedValue != null)
                                {

                                    DataRow aSpecialPrice = null;// = SpecialPricesMgmt.SelectSpecialPricebyItemIDandPriceLevelID(int.Parse(aItemRow["ID"].ToString()), int.Parse(PriceLevelComboBox.SelectedValue.ToString()));
                                    foreach (DataRow aSpecialPriceRow in SpecialPricesTable.Rows)
                                    {
                                        if (aSpecialPriceRow["ItemID"].ToString() == aItemRow["ID"].ToString() && aSpecialPriceRow["PriceLevelID"].ToString() == PriceLevelComboBox.SelectedValue.ToString())
                                        {
                                            aSpecialPrice = aSpecialPriceRow;
                                            break;
                                        }
                                    }

                                    if (aSpecialPrice != null)
                                    {
                                        if (aSpecialPrice != null)
                                        {
                                            double OldPrice = double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString());
                                            double NewPrice = double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * double.Parse(aSpecialPrice["Price"].ToString());
                                            PriceLevelTemp = NewPrice;
                                            TotalPriceLevelDiscount += OldPrice - NewPrice;
                                            PriceLvlDiscountTemp = OldPrice - NewPrice;
                                        }
                                    }
                                }
                                //updates                    
                                Subtotal += SubtotalTemp;
                                TaxTemp = double.Parse(TeldgView.Rows[r.Index].Cells["Tax"].Value.ToString());
                                //TotalTax += (TaxTemp / 100) * PriceLevelTemp; //Net amount = (Selling Price - Sales Price)*Tax
                                TotalCost = Math.Round(TotalCost + double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString()) * Convert.ToDouble(aItemRow["AvgUnitCost"].ToString()), 3);
                                double Level1Discount = PriceLvlDiscountTemp;
                                double Level2Discount = (SubtotalTemp - Level1Discount) * double.Parse(DiscountPercTxtBox.Text) / 100;
                                TotalTax += (TaxTemp / 100) * (SubtotalTemp - Level2Discount - Level1Discount);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }

                    double TestParser = 0;
                    if (double.TryParse(DiscountPercTxtBox.Text, out TestParser))
                    {
                        DiscountBillTxtBox.Text = Math.Round((double.Parse(DiscountPercTxtBox.Text) / 100 * (Subtotal - TotalPriceLevelDiscount)), 3).ToString();
                    }
                    else
                    {
                        DiscountBillTxtBox.Text = "0.00";
                    }
                    double NetAmount = Subtotal - double.Parse(DiscountBillTxtBox.Text) - TotalPriceLevelDiscount;

                    TotalPriceLevelDiscount = Math.Round(TotalPriceLevelDiscount, 3);
                    TotalCost = Math.Round(TotalCost, 3);
                    NetAmountTxtBox.Text = NetAmount.ToString();

                    Subtotal = Math.Round(Subtotal, 3);
                    SubtotalTxtBox.Text = Subtotal.ToString();

                    TotalPriceLevelDiscount = Math.Round(TotalPriceLevelDiscount, 3);
                    PriceLevelDiscount.Text = TotalPriceLevelDiscount.ToString();

                    TotalDiscountTxtBox.Text = Math.Round(double.Parse(DiscountBillTxtBox.Text) + TotalPriceLevelDiscount, 3).ToString(); //TxtBox insured to be double from above

                    TotalTax = Math.Round(TotalTax, 3);
                    TaxTxtBox.Text = TotalTax.ToString();


                    TotalTxtBox.Text = Math.Round((NetAmount + TotalTax), 3).ToString();//TxtBox insured to be double from above

                    if (double.TryParse(CashInTxtBox.Text, out TestParser) && double.TryParse(BuyRateTxtBox.Text, out TestParser))
                    {
                        ExchangeTxtBox.Text = Math.Round((double.Parse(CashInTxtBox.Text) * double.Parse(BuyRateTxtBox.Text) - double.Parse(TotalTxtBox.Text)), 3).ToString();
                    }
                    else
                    {
                        ExchangeTxtBox.Text = MsgTxt.CannotBeCalculatedTxt;
                    }
                }
                //TimeSpan ts = DateTime.Now.Subtract(StartTime);
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                //        ts.Hours, ts.Minutes, ts.Seconds,
                //        ts.Milliseconds / 10);
                // MessageBox.Show("UPDATECASH=" + elapsedTime);
                semaphore = false;
                if (CustomerScreenChkBox.Checked)
                {
                    AddDataToCustomerScreen();
                }
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "{TouchScreen:IN:UPDATE CASH EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void TeldgView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!semaphore && !IsLoading && !OnExit && !IsAddingItem)
                {
                    if (TeldgView.Rows.Count == 0)
                    {
                        return;
                    }
                    if (!double.TryParse(TeldgView.Rows[e.RowIndex].Cells["Qty"].Value.ToString(), out OverrideError))
                    {
                        TeldgView.Rows[e.RowIndex].Cells["Qty"].Value = 1;
                    }

                    TeldgView.Rows[e.RowIndex].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value.ToString()), 3);
                    UpdateCash();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "{TouchScreen:IN:TeldgView_CellValueChanged EXCEPTION:}" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CurrencyComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading && CurrencyComboBox.SelectedValue != null)
                {
                    //if (AccountsMgmt.SelectAccountCurrencyByID(int.Parse(AccountComboBox.SelectedValue.ToString())) == int.Parse(CurrencyComboBox.SelectedValue.ToString()))
                    //{
                    BuyRateTxtBox.Text = CurrencyMgmt.SelectBuyRateByID(int.Parse(CurrencyComboBox.SelectedValue.ToString())).ToString();
                    SellRateTxtBox.Text = CurrencyMgmt.SelectSellRateByID(int.Parse(CurrencyComboBox.SelectedValue.ToString())).ToString();
                    CashInCurrency.Text = CurrencyComboBox.Text;
                    UpdateCash();
                    //}
                    //else
                    //{
                    //    CurrencyComboBox.SelectedValue = AccountsMgmt.SelectAccountCurrencyByID(int.Parse(AccountComboBox.SelectedValue.ToString())).ToString();
                    //    MessageBox.Show("The Account " + AccountComboBox.Name + " Dont Allow This currency Transactions");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CurrencyComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.TouchScreenFormName;
                PaymentMethodLbl.Text = UiText.TchScrPaymentMethodLbl;
                AccountLbl.Text = UiText.TchScrAccountLbl;
                CustomerPhoneLbl.Text = UiText.TchScrCustomerPhoneLbl;
                CustomerNameLbl.Text = UiText.TchScrCustomerNameLbl;
                CustomersAccountAmount.Text = UiText.TchScrCustomersAccountAmount;
                CashPaymentGB.Text = UiText.TchScrCashPaymentGB;
                CashMethodLbl.Text = UiText.TchScrCashMethodLbl;
                CashInLbl.Text = UiText.TchScrCashInLbl;
                ExchangeLbl.Text = UiText.TchScrExchangeLbl;
                CurrencyLbl.Text = UiText.TchScrCurrencyLbl;
                SellPriceLbl.Text = UiText.TchScrSellPriceLbl;
                BuyRateLbl.Text = UiText.TchScrBuyRateLbl;
                IsCreditLbl.Text = UiText.TchScrIsCreditLbl;
                CheckGB.Text = UiText.TchScrCheckGB;
                CheckNumber.Text = UiText.TchScrCheckNumber;
                CheckHolderNameLbl.Text = UiText.TchScrCheckHolderNameLbl;
                PaymentDateLbl.Text = UiText.TchScrPaymentDateLbl;
                CheckCommentsLbl.Text = UiText.TchScrCheckCommentsLbl;
                PayInVisaGB.Text = UiText.TchScrPayInVisaGB;
                PaymentCommentsLbl.Text = UiText.TchScrPaymentCommentsLbl;
                EnableNumpadChkBox.Text = UiText.TchScrEnableNumpadChkBox;
                BillNumberLbl.Text = UiText.TchScrBillNumberLbl;
                SubtotalLbl.Text = UiText.TchScrSubtotalLbl;
                DiscountBillPercLbl.Text = UiText.TchScrDiscountBillPercLbl;
                DiscountOnBillLbl.Text = UiText.TchScrDiscountOnBillLbl;
                PriceLevelLbl.Text = UiText.TchScrPriceLevelLbl;
                PriceLvlDiscountLbl.Text = UiText.TchScrPriceLvlDiscountLbl;
                TotalDiscountLbl.Text = UiText.TchScrTotalDiscountLbl;
                NetAmountLbl.Text = UiText.TchScrNetAmountLbl;
                TotalTaxlbl.Text = UiText.TchScrTotalTaxlbl;
                TotalBillLbl.Text = UiText.TchScrTotalBillLbl;
                CommentsLbl.Text = UiText.TchScrCommentsLbl;
                CancleBtn.Text = UiText.TchScrCancleBtn + " (ESC)";
                PaymentOnlyBtn.Text = UiText.TchScrPaymentOnlyBtn + " (F4)";
                PaymentAndPrintBtn.Text = UiText.TchScrPaymentAndPrintBtn + " (F2)";
                OpenCashBtn.Text = UiText.TchScrOpenCashBtnTxt + " (F6)";
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                semaphore = false;
                UpdateCash();
                //TimeSpan ts = DateTime.Now.Subtract(StartTime);
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                //        ts.Hours, ts.Minutes, ts.Seconds,
                //        ts.Milliseconds / 10);
                // MessageBox.Show("IncreaseBtn_Click=" + elapsedTime);
                
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [POS:IncreaseBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [POS:DecreaseBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[POS:DeleteItemsBtn_Click [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void reloadwindow()
        {
            try
            {
                IsLoading = true;
                CashMethodComboBox.SelectedIndex = 0;
                //Default Currency
                CheckDatePicker.MinDate = DateTime.Today;
                int DefaultCurrencyID = CurrencyMgmt.SelectDefaultCurrencyID();
                CurrencyComboBox.SelectedValue = DefaultCurrencyID.ToString();
                SellRateTxtBox.Text = CurrencyMgmt.SelectSellRateByID(DefaultCurrencyID).ToString();
                BuyRateTxtBox.Text = CurrencyMgmt.SelectBuyRateByID(DefaultCurrencyID).ToString();
                CashInCurrency.Text = CurrencyMgmt.SelectCurrencyNameByID(DefaultCurrencyID);

                //Default Account
                int DefaultAccountID = AccountsMgmt.SelectDefaultAccountID();
                AccountComboBox.SelectedValue = DefaultAccountID.ToString();
                AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(DefaultAccountID);

                //Default Customer Name
                PhoneTxtBox.Text = "00";
                CustomerNameTxtBox.Text = "CASH";
                if (ReturnChkBox.Checked)
                {
                    InvoiceNumTxtBox.Text = ReturnItemsCustGeneralMGMT.NextBillNumber().ToString();
                }
                else
                {
                    InvoiceNumTxtBox.Text = BillGeneralMgmt.NextBillNumber().ToString();
                }
                // fillBy1ToolStripButton.PerformClick();
                IsLoading = false;
                //Default Payment Method
                DataRow aPaymentMethodRow = PaymentMethodMgmt.SelectDefaultPaymentMethod();
                PaymentMethodCheckBox.Text = aPaymentMethodRow["Name"].ToString();
                PaymentMethodCheckBox.SelectedValue = aPaymentMethodRow["ID"].ToString();
                PaymentMethodDescripTxtBox.Text = aPaymentMethodRow["Description"].ToString();
                TeldgView.Rows.Clear();
                CashInTxtBox.Text = "00.0";
                UpdateCash();
                aCustomerScreenDataTable.Rows.Clear();
                AddDataToCustomerScreen();
            }
            catch (Exception ex)
            {
                IsLoading = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TouchScreen:reloadwindow [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.F4:
                    //Process action here.
                    PaymentOnlyBtn.PerformClick();
                    break;
                case Keys.F2:
                    //Process action here.
                    PaymentAndPrintBtn.PerformClick();
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
            }
            return base.ProcessCmdKey(ref message, keys);
        }
        private void PaymentMethodCheckBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading && PaymentMethodCheckBox.SelectedValue != null && !OnExit)
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

                    UpdateCash();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TouchScreen:PaymentMethodCheckBox_SelectedValueChanged [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                        CurrencyComboBox.SelectedValue = aAccountRow["CurrencyID"];
                        AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aAccountRow["ID"].ToString()));
                        UpdateCash();
                    }
                    else
                    {
                        MessageBox.Show("Account " + AccountComboBox.Text + "Do Not Accept" + PaymentMethodCheckBox.Text);
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

                        UpdateCash();

                    }

                }
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TouchScreen:AccountComboBox_SelectedValueChanged [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CashMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CashMethodComboBox.SelectedIndex == 1)
                {
                    //CustomerAccountAmountlbl.Show();
                    CustomersAccountAmountTxtBox.Show();
                    CustomersAccountAmount.Show();
                    int CustomerID = CustomerMgmt.SelectCustomerIDByPhone1(PhoneTxtBox.Text);
                    aCustomerAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                    if (CustomerID == -1)
                    {
                        MessageBox.Show("DB-ERROR: CustomerID==-1 --> Occured in POS: CashMethodComboBox_SelectedIndexChanged", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (aCustomerAccount != null)
                    {
                        CustomersAccountAmountTxtBox.Text = aCustomerAccount["Amount"].ToString();
                        CashInTxtBox.Hide();
                        ExchangeTxtBox.Hide();
                        CashInLbl.Hide();
                        ExchangeLbl.Hide();
                        JODstatic.Hide();
                        CurrencyLbl.Hide();

                        IsCreditLbl.Show();
                        CashInCurrency.Hide();

                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.CustomerTxt + " " + CustomerNameTxtBox.Text + " " + MsgTxt.DoNotHaveAccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        CashMethodComboBox.SelectedIndex = 0;
                    }
                }
                else
                {
                    //CustomerAccountAmountlbl.Hide();
                    CustomersAccountAmountTxtBox.Hide();
                    CustomersAccountAmount.Hide();
                    CashInTxtBox.Show();
                    ExchangeTxtBox.Show();
                    CashInLbl.Show();
                    ExchangeLbl.Show();
                    JODstatic.Show();
                    CurrencyLbl.Show();

                    IsCreditLbl.Hide();
                    CashInCurrency.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TouchScreen:CashMethodComboBox_SelectedIndexChanged [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CashInTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                UpdateCash();
                ExchangeTxtBox.Focus();
            }
            // ExchangeTxtBox.Text = (double.Parse(CashInTxtBox.Text) - double.Parse(TotalTxtBox.Text)).ToString();
        }

        private void CancleBtn_Click(object sender, EventArgs e)
        {
            reloadwindow();
        }

        private bool print_receipt()
        {
            try
            {
                
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                #region Calculating Tax Based On Levels
                DataTable TaxLevels = new DataTable();
                TaxLevels.Columns.Add("TaxLevel");
                TaxLevels.Columns.Add("Amount");
                #endregion Calculating Tax Based On Levels
                aDataTable1.Columns.Add("[border=true1]<th width=35%>" + ReceiptText.RctTxtItemName);
                aDataTable1.Columns.Add(ReceiptText.RctTxtUnitPrice);
                aDataTable1.Columns.Add("<th width=15%>" + ReceiptText.RctTxtQty);
                //aDataTable1.Columns.Add(ReceiptText.RctTxtTax);
                aDataTable1.Columns.Add(ReceiptText.RctTxtTotal);

                foreach (DataGridViewRow aRow in TeldgView.Rows)
                {
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[aRow.Index][0] = aRow.Cells["Description"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][1] = Math.Round(double.Parse(aRow.Cells["PricePerUnit"].Value.ToString()), 3);
                    aDataTable1.Rows[aRow.Index][2] = Math.Round(double.Parse(aRow.Cells["Qty"].Value.ToString()), 3);
                  //  aDataTable1.Rows[aRow.Index][ReceiptText.RctTxtTax] = aRow.Cells["Tax"].Value.ToString() + " %";
                    aDataTable1.Rows[aRow.Index][ReceiptText.RctTxtTotal] = Math.Round(double.Parse(aRow.Cells["PriceTotal"].Value.ToString()), 3);
                    #region Calculating Tax Based On Levels
                    bool TaxExistInTbl = false;
                    foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                    {
                        if (aTaxLevelRow["TaxLevel"].ToString()==aRow.Cells["Tax"].Value.ToString())
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
                        DataRow NewTaxRow=TaxLevels.Rows.Add();
                        NewTaxRow["TaxLevel"] = aRow.Cells["Tax"].Value.ToString() ;
                        NewTaxRow["Amount"] = Math.Round((double.Parse(aRow.Cells["Tax"].Value.ToString()) / 100 * double.Parse(aRow.Cells["PriceTotal"].Value.ToString())), 3).ToString() ;
                    }
                    else
                    {

                    }
                    #endregion Calculating Tax Based On Levels
                }

              
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                int RowCnt = 0;

                #region Adding Tax Based On TaxLevels
                foreach (DataRow aTaxLevelRow in TaxLevels.Rows)
                {
                    aDataTable3.Rows.Add();
                    aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax +" "+ aTaxLevelRow["TaxLevel"].ToString() +" %";
                    aDataTable3.Rows[RowCnt++][1] = aTaxLevelRow["Amount"].ToString() + "<b> JOD";
                }
                #endregion Adding Tax Based On TaxLevels
                //aDataTable3.Rows.Add();
                //aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtTax;
                //aDataTable3.Rows[RowCnt++][1] = TaxTxtBox.Text + "<b> JOD";

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
                aDataTable3.Rows[RowCnt][0] = "<td style=\"background-color:#000;color:#fff;border-right-color:#fff;\"><b><font size=4> *** " + ReceiptText.RctTxtToPayAmount + " *** </font>";
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
                        if (double.TryParse(CustomersAccountAmountTxtBox.Text, out CustomerAccountAmountParserChk))
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
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                if (PhoneTxtBox.Text != "00")
                {
                    aStringList.Add(ReceiptText.RctTxtCustomer + ":&nbsp;&nbsp;" + CustomerNameTxtBox.Text);
                }

                aStringList.Add(ReceiptText.RctTxtInvoiceNum + ":&nbsp; " + InvoiceNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf", false, "", false, PrintingThermalA4ChkBox.Checked);
                if (PrintingThermalA4ChkBox.Checked)
                {
                   Process.Start(ReportsHelper.TempPDFOutputPath);
                    
                    
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[TOUCHSCREEN:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                    if (PriceLevelComboBox.SelectedValue == null)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.PriceLevelsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }

                    DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                    //aMethodRow = null;
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
                                BillGeneral aBillGeneral = new BillGeneral();
                                InvoiceNumTxtBox.Text = BillGeneralMgmt.NextBillNumber().ToString();
                                aBillGeneral.Bill_General_Number = int.Parse(InvoiceNumTxtBox.Text);
                                aBillGeneral.Bill_General_Date = DateTime.Now.ToShortDateString();
                                aBillGeneral.Bill_General_Time = DateTime.Now.ToShortTimeString();
                                aBillGeneral.Bill_General_TotalItems = TeldgView.Rows.Count;
                                aBillGeneral.Bill_General_TotalTax = double.Parse(TaxTxtBox.Text);
                                aBillGeneral.Bill_General_TotalPrice = double.Parse(TotalTxtBox.Text);
                                aBillGeneral.Bill_General_TotalCost = TotalCost;
                                aBillGeneral.Bill_General_TellerID = Convert.ToInt32(UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName()).ToString()); //for now
                                aBillGeneral.Bill_General_CustomerID = CustomerMgmt.SelectCustomerIDByPhone1(PhoneTxtBox.Text);
                                if (aBillGeneral.Bill_General_CustomerID == -1)
                                {
                                    aBillGeneral.Bill_General_CustomerID = CustomerMgmt.SelectCustomerIDByPhone1("00");
                                }
                                aBillGeneral.Bill_General_PriceLevel = int.Parse(PriceLevelComboBox.SelectedValue.ToString());
                                //payment method to last
                                aBillGeneral.Bill_General_Comments = CommentsTxtBox.Text;
                                aBillGeneral.Bill_General_SalesDiscount = Convert.ToDouble(PriceLevelDiscount.Text.ToString());
                                aBillGeneral.Bill_General_DiscountPerc = Convert.ToDouble(DiscountPercTxtBox.Text.ToString());
                                aBillGeneral.Bill_General_CashIn = Convert.ToDouble(CashInTxtBox.Text.ToString());
                                aBillGeneral.Bill_General_TotalDiscount = Convert.ToDouble(TotalDiscountTxtBox.Text.ToString());
                                //Credit card info to last
                                if (CurrencyComboBox.SelectedValue == null)
                                {
                                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.CurrencyTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return false;
                                }
                                aBillGeneral.Bill_General_CurrencyID = int.Parse(CurrencyComboBox.SelectedValue.ToString());

                                if (AccountComboBox.SelectedValue == null)
                                {
                                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.AccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    return false;
                                }
                                aBillGeneral.Bill_General_AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                aBillGeneral.Bill_General_NetAmount = double.Parse(NetAmountTxtBox.Text);
                                //DEFINITION [TOLAST]
                                aBillGeneral.Bill_General_PaymentMethodID = int.Parse(PaymentMethodCheckBox.SelectedValue.ToString());
                                aBillGeneral.Bill_General_Currency = CurrencyComboBox.Text;
                                aBillGeneral.Bill_General_SubTotal = double.Parse(SubtotalTxtBox.Text);
                                Checks aCheck = new Checks();
                                //--------------------------------------------START METHOD
                                if (aMethodRow["IsCash"].ToString() == "1")
                                {
                                    aBillGeneral.Bill_General_CreditCardInfo = "NOT-CREDIT";
                                    if (CashMethodComboBox.SelectedIndex == 1)//THEMAM
                                    {
                                        aBillGeneral.Bill_General_IsCashCredit = 1;//themam
                                        aBillGeneral.Bill_General_CashIn = 0;
                                        double OldAmount = double.Parse(aCustomerAccount["Amount"].ToString());
                                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text);
                                        int CusAccountID = int.Parse(aCustomerAccount["ID"].ToString());
                                        aBillGeneral.CustomerAccountAmountOld = OldAmount;
                                        CustomersAccountsMgmt.UpdateAccountAmountByAccountID(CusAccountID, NewAmount);
                                    }//here it is cash we dont care about vendor/customer account OLD amount
                                    else //CASH
                                    {
                                        aBillGeneral.Bill_General_IsCashCredit = 0;
                                        aBillGeneral.CustomerAccountAmountOld = 0;
                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text); ;
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }


                                }
                                else if (aMethodRow["IsCredit"].ToString() == "1")
                                {
                                    if (CreditCardInfoTxtBox.Text.Trim() != "")
                                    {
                                        aBillGeneral.Bill_General_CreditCardInfo = CreditCardInfoTxtBox.Text;
                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text); ;
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.PleaseAddCreditCardInfoTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        CreditCardInfoTxtBox.Focus();
                                        return false;
                                    }
                                }
                                else //CHEQUE
                                {
                                    aBillGeneral.Bill_General_CreditCardInfo = "NOT-CREDIT";
                                    //its check
                                    NextCheckNumber = ChecksMgmt.NextCheckNumber();
                                    if (NextCheckNumber == 0)
                                    {
                                        MessageBox.Show(MsgTxt.UnexpectedError + "DB-ERROR IN : ChecksMgmt.NextCheckNumber", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        return false;
                                    }
                                    aBillGeneral.Bill_General_CheckNumber = NextCheckNumber;
                                    // aCheck.Chekcs_BankName = BanksComboBox.Text;
                                    if (HolderNameTxtBox.Text.Trim() != "")
                                    {
                                        aCheck.Chekcs_HolderName = HolderNameTxtBox.Text;
                                        int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                                        DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                                        double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                                        double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text); ;
                                        AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.CheckHolderNameTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        HolderNameTxtBox.Focus();
                                        return false;
                                    }

                                    aCheck.Chekcs_PaymentDate = CheckDatePicker.Value.ToShortDateString();
                                    aCheck.Chekcs_IsBill = 1;
                                    aCheck.Chekcs_GeneralBillNumber = int.Parse(InvoiceNumTxtBox.Text);
                                    aCheck.Chekcs_IsPurchaseVoucher = 0;
                                    //aCheck.Chekcs_PurchaseVoucherNumber = ;
                                    aCheck.Chekcs_AccountID = aBillGeneral.Bill_General_AccountID;
                                    aCheck.Chekcs_Comments = CheckCommentsTxtBox.Text;
                                    aCheck.Chekcs_Amount = aBillGeneral.Bill_General_TotalPrice;
                                    aCheck.Chekcs_IsPaid = 0;
                                    aCheck.CheckNumber = NextCheckNumber;
                                    aCheck.AddingDate = DateTime.Now.ToShortDateString();
                                    aCheck.Chekcs_PaymentDate = CheckDatePicker.Text;
                                    ChecksMgmt.InsertCheck(aCheck);
                                }
                                //---------------------------------END METHOD
                                if (BillGeneralMgmt.InsertBill(aBillGeneral))
                                {
                                    BillDetailed aBillDetailed = new BillDetailed();
                                    foreach (DataGridViewRow r in TeldgView.Rows)
                                    {
                                        if (!r.IsNewRow)
                                        {
                                            aBillDetailed.Bill_Detailed_ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                            aBillDetailed.Bill_Detailed_ItemDescription = TeldgView.Rows[r.Index].Cells["Description"].Value.ToString();
                                            aBillDetailed.Bill_Detailed_OldAvaQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvalQty"].Value.ToString());
                                            double TestParser = 0;
                                            if (double.TryParse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString(), out TestParser))
                                            {
                                                aBillDetailed.Bill_Detailed_Qty = TestParser;//double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                                            }
                                            else
                                            {
                                                TestParser = 1;
                                            }
                                            aBillDetailed.Bill_Detailed_SellPrice = double.Parse(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                            aBillDetailed.Bill_Detailed_TotalPerUnit = double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString());
                                            aBillDetailed.Bill_Detailed_Number = aBillGeneral.Bill_General_Number;
                                            aBillDetailed.Bill_Detailed_OldAvgUnitCost = ItemsMgmt.SelectItemCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                            BillDetailedMgmt.InsertItem(aBillDetailed);
                                            string Barcode = TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString();
                                            ItemsMgmt.UpdateItemQtyByBarcode(Barcode, ItemsMgmt.SelectItemQtyByBarcode(Barcode), (0 - TestParser));//0-qty wich is negative to be subtracted from orginnal
                                        }
                                    }
                                }
                                else
                                {
                                    if (NextCheckNumber != -1)
                                    {
                                        ChecksMgmt.DeleteCheckByCheckNumber(NextCheckNumber);
                                    }
                                    BillGeneralMgmt.DeleteBill(aBillGeneral.Bill_General_Number);
                                    BillDetailedMgmt.DeleteByGeneralBillNumber(aBillGeneral.Bill_General_Number);
                                    MessageBox.Show(MsgTxt.TransactionNotAddedSuccessfullyTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
                                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CashInTxtBox.BackColor = Color.White;
                                return true;
                            }
                            else//DIALOG
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[POS:AddPayment [EXCEPTION IS]] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PaymentOnlyBtn_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (ReturnChkBox.Checked)
            {
                if (AddReturnPayment())
                {
                    reloadwindow();
                    if (CustomerScreenChkBox.Checked)
                    {
                        __CustomerScreen.SetThankYouImage();
                    }

                }
                else
                {
                    // MessageBox.Show("Try Again Later");
                }
            }
            else
            {
                if (Add_payment())
                {
                    reloadwindow();
                    if (CustomerScreenChkBox.Checked)
                    {
                        __CustomerScreen.SetThankYouImage();
                    }
                }
                else
                {
                    // MessageBox.Show("Try Again Later");
                }
            }
            this.UseWaitCursor = false;


        }
        private void PaymentAndPrintBtn_Click(object sender, EventArgs e)
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
                    if (CustomerScreenChkBox.Checked)
                    {
                        __CustomerScreen.SetThankYouImage();
                    }
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
                    if (CustomerScreenChkBox.Checked)
                    {
                        __CustomerScreen.SetThankYouImage();
                    }
                }
            }
            this.UseWaitCursor = false;


        }
        private void PhoneTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                DataRow DR = CustomerMgmt.SelectCustomerByPhone1(PhoneTxtBox.Text);
                if (DR != null)
                {
                    CustomerNameTxtBox.Text = DR["Name"].ToString();
                    AddDataToCustomerScreen();
                }
                else
                {
                    MessageBox.Show(MsgTxt.CustomerTxt + " " + MsgTxt.NotFoundTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    PhoneTxtBox.Text = "00";
                    CustomerNameTxtBox.Text = "CASH";
                }

            }
        }


        private void DiscountPercTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (int)Keys.Return)
            //{

            //    DiscountBillTxtBox.Text = (double.Parse(DiscountPercTxtBox.Text) / 100 * double.Parse(SubtotalTxtBox.Text)).ToString();
            //    TotalDiscountTxtBox.Text = (double.Parse(DiscountBillTxtBox.Text) + double.Parse(PriceLevelDiscount.Text)).ToString();
            //    TotalTxtBox.Text = (Subtotal + TotalTax - double.Parse(TotalDiscountTxtBox.Text)).ToString();
            //    ExchangeTxtBox.Text = (double.Parse(CashInTxtBox.Text) - double.Parse(TotalTxtBox.Text)).ToString();
            //    UpdateCash();
            //}

            if (IsLoading || semaphore)
            {
                return;
            }

            if (!IsDiscountEnabled())
            {
                DiscountPercTxtBox.Text = "0.00";
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (int)Keys.Return)
            {
                double TestParser = 0.00;
                if (double.TryParse(DiscountPercTxtBox.Text, out TestParser) && double.TryParse(SubtotalTxtBox.Text, out TestParser))
                {
                    DiscountBillTxtBox.Text = (double.Parse(DiscountPercTxtBox.Text) / 100 * double.Parse(SubtotalTxtBox.Text)).ToString();
                    if (double.TryParse(PriceLevelDiscount.Text, out TestParser))
                    {
                        //TotalDiscountTxtBox.Text = (double.Parse(DiscountBillTxtBox.Text) + double.Parse(PriceLevelDiscount.Text)).ToString();
                        //TotalTxtBox.Text = (Subtotal + TotalTax - double.Parse(TotalDiscountTxtBox.Text)).ToString();
                        //if (double.TryParse(CashInTxtBox.Text, out TestParser))
                        //{
                        //    ExchangeTxtBox.Text = (double.Parse(CashInTxtBox.Text) - double.Parse(TotalTxtBox.Text)).ToString();

                        //}
                        //else
                        //{
                        //    ExchangeTxtBox.Text = MsgTxt.CannotBeCalculatedTxt;
                        //}
                        UpdateCash();
                    }
                }
            }

        }

        private void ShowNumpad(object sender, EventArgs e)
        {
            TextBox aTextBox = (TextBox)sender;

            if (!semaphore && EnableNumpadChkBox.Checked)
            {
                semaphore = true;
                Numpad.Visible = true;
                semaphore = false;
            }

        }
        private void HideNumpad(object sender, EventArgs e)
        {
            if (!semaphore && EnableNumpadChkBox.Checked)
            {
                semaphore = true;
                Numpad.Visible = false;
                UpdateCash();
                semaphore = false;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                __CustomerScreen.Dispose();
                __CustomerScreen.Close();
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
        private void Numpad_ButtonPressed(object sender, KeyPressEventArgs e)
        {
            SendKeys.Send(e.KeyChar.ToString());
        }

        #region Returns
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
            CurrencyComboBox.Enabled = false;
            InvoiceNumTxtBox.Text = ReturnItemsCustGeneralMGMT.NextBillNumber().ToString();
        }

        private void TransformToSale()
        {
            this.BackColor = aThisBGColor;
           
            AccountComboBox.Enabled = true;
            PaymentMethodCheckBox.Enabled = true;

            CashInTxtBox.Enabled = true;
            ExchangeTxtBox.Enabled = true;
            CurrencyComboBox.Enabled = true;

            InvoiceNumTxtBox.Text = BillGeneralMgmt.NextBillNumber().ToString();
        }

        private ReturnItemsCustGeneral PreperaReturnClassObject()
        {
            try
            {
                ReturnItemsCustGeneral aReturnCusGeneral = new ReturnItemsCustGeneral();
                aReturnCusGeneral.Number = ReturnItemsCustGeneralMGMT.NextBillNumber();
                aReturnCusGeneral.Date = DateTime.Now.ToShortDateString();
                aReturnCusGeneral.Time = DateTime.Now.ToShortTimeString();
                aReturnCusGeneral.TotalTax = double.Parse(TaxTxtBox.Text);
                aReturnCusGeneral.TotalPrice = double.Parse(TotalTxtBox.Text);
                aReturnCusGeneral.TotalCost = TotalCost;
                aReturnCusGeneral.TellerID = Convert.ToInt32(UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName()).ToString()); //for now
                aReturnCusGeneral.CustomerID = CustomerMgmt.SelectCustomerIDByPhone1(PhoneTxtBox.Text);
                if (aReturnCusGeneral.CustomerID == -1)
                {
                    aReturnCusGeneral.CustomerID = CustomerMgmt.SelectCustomerIDByPhone1("00");
                }

                aReturnCusGeneral.PriceLevel = int.Parse(PriceLevelComboBox.SelectedValue.ToString());
                //payment method to last
                aReturnCusGeneral.Comments = CommentsTxtBox.Text;

                aReturnCusGeneral.DiscountPerc = Convert.ToDouble(DiscountPercTxtBox.Text.ToString());
                aReturnCusGeneral.TotalDiscount = Convert.ToDouble(TotalDiscountTxtBox.Text.ToString());
                //Credit card info to last

                if (AccountComboBox.SelectedValue == null)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.AccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return null;
                }

                aReturnCusGeneral.AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                aReturnCusGeneral.NetAmount = double.Parse(NetAmountTxtBox.Text);
                //DEFINITION [TOLAST]
                aReturnCusGeneral.SubTotal = double.Parse(SubtotalTxtBox.Text);
                if (CashMethodComboBox.SelectedIndex == 1)//THEMAM
                {
                    aReturnCusGeneral.IsCashCredit = 1;//themam                
                    double OldAmount = double.Parse(aCustomerAccount["Amount"].ToString());
                    double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text);
                    int CusAccountID = int.Parse(aCustomerAccount["ID"].ToString());
                    aReturnCusGeneral.CustomerAccountAmountOld = OldAmount;
                    CustomersAccountsMgmt.UpdateAccountAmountByAccountID(CusAccountID, NewAmount);
                }//here it is cash we dont care about vendor/customer account OLD amount
                else //CASH
                {
                    aReturnCusGeneral.IsCashCredit = 0;
                    aReturnCusGeneral.CustomerAccountAmountOld = 0;
                    int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(AccountID);
                    double OldAmount = double.Parse(aAccountRow["Amount"].ToString());
                    double NewAmount = OldAmount + double.Parse(TotalTxtBox.Text); ;
                    AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                }

                return aReturnCusGeneral;
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
                if (TeldgView.Rows.Count > 0)
                {
                    if (PriceLevelComboBox.SelectedValue == null)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.PriceLevelsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                    DialogResult ret;
                    ret = MessageBox.Show(MsgTxt.SureToTakePaymentTxt, MsgTxt.SureToTakePaymentTxt.ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    if (ret == DialogResult.Yes)
                    {
                        ReturnItemsCustGeneral aReturnGeneral = PreperaReturnClassObject();
                        if (aReturnGeneral == null)
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return false;
                        }

                        if (ReturnItemsCustGeneralMGMT.InsertBill(aReturnGeneral))
                        {
                            ReturnItemsCustDetailed aReturnDetailed = new ReturnItemsCustDetailed();
                            foreach (DataGridViewRow r in TeldgView.Rows)
                            {
                                if (!r.IsNewRow)
                                {
                                    aReturnDetailed.ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                    aReturnDetailed.ItemDescription = TeldgView.Rows[r.Index].Cells["Description"].Value.ToString();
                                    aReturnDetailed.OldAvaQty = Convert.ToDouble(TeldgView.Rows[r.Index].Cells["AvalQty"].Value.ToString());
                                    double TestParser = 0;
                                    if (double.TryParse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString(), out TestParser))
                                    {
                                        aReturnDetailed.Qty = TestParser;//double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                                    }
                                    else
                                    {
                                        aReturnDetailed.Qty = TestParser = 1;
                                    }
                                    aReturnDetailed.SellPrice = double.Parse(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                                    aReturnDetailed.TotalPerUnit = double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString());
                                    aReturnDetailed.Number = aReturnGeneral.Number;
                                    aReturnDetailed.OldAvgUnitCost = ItemsMgmt.SelectItemCostByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                                    ReturnItemsCustDetailedMGMT.InsertItem(aReturnDetailed);
                                    string Barcode = TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString();
                                    ItemsMgmt.UpdateItemQtyByBarcode(Barcode, ItemsMgmt.SelectItemQtyByBarcode(Barcode),  TestParser);//0-qty wich is negative to be subtracted from orginnal
                                }
                            }
                        }
                        else
                        {
                            ReturnItemsCustGeneralMGMT.DeleteBill(aReturnGeneral.Number);
                            MessageBox.Show(MsgTxt.TransactionNotAddedSuccessfullyTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else//DIALOG
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
            }
        }

        private bool PrintReturnReceipt()
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]<th width=35%>" + ReceiptText.RctTxtItemName);
                aDataTable1.Columns.Add(ReceiptText.RctTxtUnitPrice);
                aDataTable1.Columns.Add("<th width=15%>" + ReceiptText.RctTxtQty);
              //aDataTable1.Columns.Add(ReceiptText.RctTxtTax);
                aDataTable1.Columns.Add(ReceiptText.RctTxtTotal);

                #region Calculating Tax Based On Levels
                DataTable TaxLevels = new DataTable();
                TaxLevels.Columns.Add("TaxLevel");
                TaxLevels.Columns.Add("Amount");
                #endregion Calculating Tax Based On Levels

                foreach (DataGridViewRow aRow in TeldgView.Rows)
                {
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[aRow.Index][0] = aRow.Cells["Description"].Value.ToString();
                    aDataTable1.Rows[aRow.Index][1] = Math.Round(double.Parse(aRow.Cells["PricePerUnit"].Value.ToString()), 3);
                    aDataTable1.Rows[aRow.Index][2] = Math.Round(double.Parse(aRow.Cells["Qty"].Value.ToString()), 3);
                   // aDataTable1.Rows[aRow.Index][ReceiptText.RctTxtTax] = aRow.Cells["Tax"].Value.ToString() + " %";
                    aDataTable1.Rows[aRow.Index][ReceiptText.RctTxtTotal] = Math.Round(double.Parse(aRow.Cells["PriceTotal"].Value.ToString()), 3);

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
                DataTable aDataTable3 = new DataTable();
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtSubTotal);
                aDataTable3.Columns.Add(SubtotalTxtBox.Text + "JOD");
                int RowCnt = 0;

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
                //aDataTable3.Rows[RowCnt++][1] = TaxTxtBox.Text + "<b> JOD";

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
                aDataTable3.Rows[RowCnt][0] = "<td style=\"background-color:#000;color:#fff;border-right-color:#fff;\"><b><font size=4>" + ReceiptText.RctTxtToPayAmount + "</font>";
                aDataTable3.Rows[RowCnt++][1] = "<td style=\"background-color:#000;color:#fff;border-left-color:#fff\"><b><font size=5>" + "-" + TotalTxtBox.Text + " JOD </font>";

                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayMethod;
                aDataTable3.Rows[RowCnt++][1] = PaymentMethodCheckBox.Text;
                if (PaymentMethodCheckBox.Text.ToUpper() == "CASH")
                {
                    if (CashMethodComboBox.Text == "Invoice")
                    {
                        aDataTable3.Rows.Add();
                        aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtPayable;
                        double CustomerAccountAmountParserChk = 0;
                        if (double.TryParse(CustomersAccountAmountTxtBox.Text, out CustomerAccountAmountParserChk))
                        {
                            aDataTable3.Rows[RowCnt++][1] = ReceiptText.RctTxtOldBalance + " = " + CustomerAccountAmountParserChk + "&nbsp;&nbsp;" + SharedVariables.Line_Solid_10px_Black +
                                     ReceiptText.RctTxtNewBalance + " = " + Math.Round((CustomerAccountAmountParserChk - double.Parse(TotalTxtBox.Text)), 3);
                        }
                    }
                }

                aDataTableList.Add(aDataTable1);
                // aDataTableList.Add(aDataTable2);
                aDataTableList.Add(aDataTable3);

                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsCustomerReturns);
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                if (PhoneTxtBox.Text != "00")
                {
                    aStringList.Add(ReceiptText.RctTxtCustomer + ":&nbsp;&nbsp;" + CustomerNameTxtBox.Text);
                }

                aStringList.Add(ReceiptText.RctTxtInvoiceNum + ":&nbsp; " + InvoiceNumTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf", false, "", false, PrintingThermalA4ChkBox.Checked);
                if (PrintingThermalA4ChkBox.Checked)
                {
                   Process.Start(ReportsHelper.TempPDFOutputPath);

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[POS:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion Returns
        #region MultiScreen
        Screen[] Screens;

        CustomerScreen.CustomerScreenFrm __CustomerScreen = new CustomerScreen.CustomerScreenFrm();
        private void CustomerScreenChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerScreenChkBox.Checked)
            {
                Screens = Screen.AllScreens;
                if (Screen.AllScreens.Count() > 1)
                {
                    var myScreen = Screen.FromControl(this);
                    var otherScreen = Screen.AllScreens[0];
                    if (otherScreen.Primary == true)
                    {
                        otherScreen = Screen.AllScreens[1];
                    }

                    __CustomerScreen.Left = otherScreen.WorkingArea.Left + 120;
                    __CustomerScreen.Top = otherScreen.WorkingArea.Top + 120;
                    __CustomerScreen.FormBorderStyle = FormBorderStyle.None;
                    __CustomerScreen.StartPosition = FormStartPosition.Manual;
                    __CustomerScreen.WindowState = FormWindowState.Maximized;
                    __CustomerScreen.Activate();
                    __CustomerScreen.Show();
                    AddDataToCustomerScreen();
                }
                else
                {
                    MessageBox.Show("You dont have second screen", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CustomerScreenChkBox.Checked = false;
                    __CustomerScreen.Hide();
                }
            }
            else
            {
                __CustomerScreen.Hide();
            }
        }
        private void AddDataToCustomerScreen()
        {
            try
            {
                CustomerScreen.CustomerScreenFrm.CustomerScreenData aData = new CustomerScreen.CustomerScreenFrm.CustomerScreenData();
                if (aCustomerScreenDataTable.Rows.Count == 0)
                {
                    aData.SetIdle = true;
                    if (!__CustomerScreen.IsDisposed)
                    {
                        __CustomerScreen.UpdateScreen(aData);
                    }
                }
                else
                {
                    if (CustomerScreenChkBox.Checked)
                    {
                        aData.__DGViewItems = PrepareDGViewTable();
                        if (aData.__DGViewItems.Rows.Count == 0)
                        {
                            return;
                        }
                        CustomerScreen.CustomerScreenFrm.CustomerInfo aCustomerInfo = new CustomerScreen.CustomerScreenFrm.CustomerInfo();
                        aCustomerInfo.CustomerAccountAmoutn = (CustomersAccountAmountTxtBox != null) ? (CustomersAccountAmountTxtBox.Text) : "";
                        aCustomerInfo.CustomerName = (CustomerNameTxtBox != null) ? CustomerNameTxtBox.Text : "";
                        aCustomerInfo.CustomerPhone = (PhoneTxtBox != null) ? PhoneTxtBox.Text : "";
                        if (PhoneTxtBox.Text == "00")
                        {
                            aCustomerInfo.Enabled = false;
                        }
                        else
                        {
                            aCustomerInfo.Enabled = true;
                        }
                        aData.__CustomerInfo = aCustomerInfo;
                        aData.__Subtotal = SubtotalTxtBox.Text;
                        aData.__PriceLevel = PriceLevelComboBox.Text;
                        aData.__PriceLevelDiscount = PriceLevelDiscount.Text;
                        aData.__DiscountPerc = DiscountPercTxtBox.Text;
                        aData.__DiscountBillAmt = DiscountBillTxtBox.Text;
                        aData.__TotalDiscount = TotalDiscountTxtBox.Text;
                        aData.__Tax = TaxTxtBox.Text;
                        aData.__TotBefTax = NetAmountTxtBox.Text;
                        aData.__TotAmt = TotalTxtBox.Text;

                        aData.SetIdle = false;
                        if (!__CustomerScreen.IsDisposed)
                        {
                            __CustomerScreen.UpdateScreen(aData);
                        }
                    }
                    else
                    {
                        aData.SetIdle = true;
                        if (!__CustomerScreen.IsDisposed)
                        {
                            __CustomerScreen.UpdateScreen(aData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message + ex.ToString());
            }
        }
        private DataTable PrepareDGViewTable()
        {
            return aCustomerScreenDataTable;
        }
        #endregion MultiScreen

        private void CashInTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            CashInTxtBox.SelectAll();
        }

        private void PriceLevelComboBox_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedValue == null) return;
            if (semaphore || IsLoading)
            {
                return;
            }

            if (!IsDiscountEnabled())
            {
                semaphore = true;
                PriceLevelComboBox.SelectedIndex = 0;
                semaphore = false;
                return;
            }
            UpdateCash();
        }
        private bool IsDiscountEnabled()
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.Discount) == EventStatus.Permit)
            {
                return true;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        private void PhoneTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            PhoneTxtBox.SelectAll();
        }

        private void DiscountPercTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            DiscountPercTxtBox.SelectAll();
        }


        private void OpenCashBtn_Click(object sender, EventArgs e)
        {
            PrintingManager.Instance.OpenCashDrawer();
        }

        private void BarcodeTxtBox_MouseClick(object sender, MouseEventArgs e)
        {
            BarcodeTxtBox.Text = string.Empty; 
        }

        private void BarcodeTxtBox_MouseLeave(object sender, EventArgs e)
        {
           
        }

     

     
      
   
    }
}
