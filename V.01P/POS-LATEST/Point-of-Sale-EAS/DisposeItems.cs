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
    public partial class DisposeItems : Form
    {

       // DataRow aCustomerAccount = null;
        int DivisionScale = 1;
        int BarcodeLength = 1;
        bool aThereIsWeigth = false;

        bool semaphore = false;
        bool OnExit = false;
        bool IsAddingItem = false;
        double SubtotalTemp = 0, Subtotal = 0, TaxTemp = 0, TotalTax = 0;
        double OverrideError;
        public DisposeItems()
        {
            InitializeComponent();
            TranslateUI();
            try
            {
                DataRow aWeightRow = WeightMgmt.SelectWeightRow();
                if (int.TryParse(aWeightRow["DivisionScale"].ToString(), out DivisionScale)
                && int.TryParse(aWeightRow["BarcodeLength"].ToString(), out BarcodeLength)
                    )
                { aThereIsWeigth = true; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR LOADING WEIGTH");
            }

        }
        private void DisposeItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.DisposalReason' table. You can move, or remove it, as needed.
            this.disposalReasonTableAdapter.Fill(this.dBDataSet.DisposalReason);
            // TODO: This line of code loads data into the 'dBDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.WithoutBarcode(this.dbDataSet1.Items);
            this.itemsTableAdapter.WithBarcode(this.dBDataSet.Items);
            SetNextNumber();
            DisposalReasonComboBox.SelectedIndex = 0;
            DisposalReasonComboBox_SelectedIndexChanged(DisposalReasonComboBox, null);
            TeldgView.Columns["Barcode"].ReadOnly = true;
            TeldgView.Columns["Description"].ReadOnly = true;
            TeldgView.Columns["Qty"].ReadOnly = false;
            TeldgView.Columns["PricePerUnit"].ReadOnly = true;
            TeldgView.Columns["PriceTotal"].ReadOnly = true;
            TeldgView.Columns["Tax"].ReadOnly = true;
            TeldgView.Columns["AvalQty"].ReadOnly = true;


        }

        //[BARCODE FUNCTIONS]
        /// <summary>
        /// ADD ITEM USING BARCODE
        /// this is one of the major function which is used to add item using its barcode to the 
        /// TELDGVIEW with the following columns
        /// [Barcode] [Qty] [Description] [PricePerUnit] [Tax]  [PriceTotal] [AvalQty]
        /// And this function loocks a bool called IsAddingItem
        /// Function Version 1.00
        /// Last Edited By Sari Sultan On October,7,2013
        /// changed sell price to AvgUnitCost TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["AvgUnitCost"].ToString();
        /// </summary>
        /// <param name="aBarcode"></param>
        /// <param name="IsFromGun"></param>
        private void AddItemUsingBarcode(string aBarcode, bool IsFromGun = false)
        {
            try
            {
                double TotwgtPrice = 0;
                bool dowgt = false;
                DataTable aItemTable = null;

                if (aThereIsWeigth && IsFromGun)
                {
                    if (aBarcode.Length > BarcodeLength)
                    {
                        aBarcode = aBarcode.Substring(0, BarcodeLength);
                        if (ItemsMgmt.IsItemWgtExist(aBarcode))
                        {
                            aItemTable = ItemsMgmt.SelectItemByBarCode(aBarcode);
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
                    if (aItemTable.Rows.Count == 1)
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
                                return;
                            }
                        }
                        IsAddingItem = true;
                        TeldgView.ClearSelection();
                        int RowNum = TeldgView.Rows.Add();
                        TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
                        TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
                        TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["AvgUnitCost"].ToString();
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
        }
        private void BarcodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DateTime StartTime = DateTime.Now;
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
            ////ADDING ITEM STATISTICS
            //TimeSpan ts = DateTime.Now.Subtract(StartTime);
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //        ts.Hours, ts.Minutes, ts.Seconds,
            //        ts.Milliseconds / 10);
            ////MessageBox.Show("Elasped Time in Seconds for Select Barcode from [10,000] items [TRIAL 2 new code] is =" + elapsedTime);
        }
        private void DescriptionAddBtn_Click(object sender, EventArgs e)
        {
            AddItemUsingBarcode(ItemDescriptionComboBox.SelectedValue.ToString());
            UpdateCash();

        }
        private void WithoutAddBtn_Click(object sender, EventArgs e)
        {
            AddItemUsingBarcode(ItemsWithoutBarcodeComboBox.SelectedValue.ToString());
            UpdateCash();
        }
        //[/BARCODE FUNCTIONS]
        private void UpdateCash()
        {
            SubtotalTemp = 0; TaxTemp = 0; Subtotal = 0; TotalTax = 0;
            if (!semaphore && !OnExit)
            {
                semaphore = true;
                foreach (DataGridViewRow r in TeldgView.Rows)
                {
                    if (!r.IsNewRow && !OnExit)
                    {
                        try
                        {   //PriceLevelSelection
                            DataRow aItemRow = ItemsMgmt.SelectItemRowByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                            SubtotalTemp = Math.Round(double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString()), 3);
                            Subtotal += SubtotalTemp;
                            TaxTemp = double.Parse(TeldgView.Rows[r.Index].Cells["Tax"].Value.ToString());
                            TotalTax += (TaxTemp / 100) * SubtotalTemp; //Net amount = (Selling Price - Sales Price)*Tax
                            //updates                    
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("UPDATE CASH ERROR IN [DISPOSE ITEMS] Exception:" + ex.ToString());
                            return;
                        }
                    }
                }
                TotalTxtBox.Text = Math.Round(Subtotal + TotalTax, 2).ToString();
                Subtotal = Math.Round(Subtotal, 2);
                SubtotalTxtBox.Text = Subtotal.ToString();
                TotalTax = Math.Round(TotalTax, 3);
                TaxTxtBox.Text = TotalTax.ToString();
                semaphore = false;
            }

        }

        private void DisposalReasonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!semaphore && !OnExit && DisposalReasonComboBox.SelectedValue != null)
                {
                    semaphore = true;
                    string IsSelectDescriptionOK = DisposalReasonMgmt.SelectDescriptionByID(int.Parse(DisposalReasonComboBox.SelectedValue.ToString()));

                    if (IsSelectDescriptionOK == "-1")
                    {
                        MessageBox.Show("Description Cannot Be Found ! " + "\n" + "Either it have been Changed Or Removed, Please close the page and try again", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (IsSelectDescriptionOK == "0")
                    {
                        MessageBox.Show("Error, The Page Will Close Now ! " + "\n" + "Try Later ON", "Disposal Reason Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (IsSelectDescriptionOK == null)
                    {
                        MessageBox.Show("The Connection To The DB is Already Open!" + "\n" + "Please Close The Page and Try Later ON", "Disposal Reason Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DisposalReasonDescriptionTxtBox.Text = IsSelectDescriptionOK;
                    }
                    semaphore = false;
                }
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DisposalReasonComboBox_SelectedIndexChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AddNewDisposalReasonBtn_Click(object sender, EventArgs e)
        {
            try
            {
                semaphore = true;
                AddDisposalReason aAddDisposalReason = new AddDisposalReason();
                aAddDisposalReason.ShowDialog();
                this.disposalReasonTableAdapter.Fill(this.dBDataSet.DisposalReason);
                semaphore = false;
            }
            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewDisposalReasonBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void TeldgView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TeldgView.Rows.Count == 0)
            {
                return;
            }
            try
            {
                if (!semaphore && !OnExit && !IsAddingItem)
                {
                    TeldgView.Rows[e.RowIndex].Cells["PriceTotal"].Value = Math.Round(Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["Qty"].Value.ToString()) * Convert.ToDouble(TeldgView.Rows[e.RowIndex].Cells["PricePerUnit"].Value.ToString()), 3);
                    UpdateCash();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[TeldgView_CellValueChanged] \n" + ex.ToString() + "\n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void IncreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                UpdateCash();

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[IncreaseBtn_Click] \n" + ex.ToString() + "\n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void DecreaseBtn_Click(object sender, EventArgs e)
        {
            try
            {
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
                UpdateCash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[DecreaseBtn_Click] \n" + ex.ToString() + "\n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void DeleteItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in TeldgView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        TeldgView.Rows.Remove(row);
                    }
                }
                UpdateCash();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[DeleteItemsBtn_Click] \n" + ex.ToString() + "\n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.DisposeItemsFormName;
                AddNewDisposalReasonBtn.Text = UiText.DisItmAddNewDisposalReasonBtn;
                BarcodeLbl.Text = UiText.DisItmBarcodeLbl;
                BillNumberLbl.Text = UiText.DisItmBillNumberLbl;
                CancleBtn.Text = UiText.DisItmCancleBtn + " (ESC)";
                DisposalReasonLbl.Text = UiText.DisItmDisposalReasonLbl;
                DisposeItemsLbl.Text = UiText.DisItmDisposeItemsLbl;                
                ItemDescriptionLbl.Text = UiText.DisItmItemDescriptionLbl;
                ItemsWithoutBarcodeLbl.Text = UiText.DisItmItemsWithoutBarcodeLbl;
                PaymentAndPrintBtn.Text = UiText.DisItmPaymentAndPrintBtn +" (F2)"                    ;
                PaymentOnlyBtn.Text = UiText.DisItmPaymentOnlyBtn +" (F4)";
                SubtotalLbl.Text = UiText.DisItmSubtotalLbl;
                TotalBillLbl.Text = UiText.DisItmTotalBillLbl;
                TotalTaxlbl.Text = UiText.DisItmTotalTaxlbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {               
                case Keys.F2:
                    //Process action here.
                    PaymentAndPrintBtn.PerformClick();
                    break;
                case Keys.F4:
                    //Process action here.
                    PaymentOnlyBtn.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
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

        #region DISPOSAL FUNCTIONS
        private int GetNextDisposalNumber()
        {
            return DisposalGeneralMgmt.NextDisposalNumber();
        }
        private void SetNextNumber()
        {
            InvoiceNumTxtBox.Text = GetNextDisposalNumber().ToString();
        }

        private DisposalGeneral FillDisposalGeneral()
        {
            try
            {
                DisposalGeneral aDisposalGeneral = new DisposalGeneral();
                aDisposalGeneral.Disposal_General_Date = DateTime.Now.ToShortDateString();
                aDisposalGeneral.Disposal_General_Time = DateTime.Now.ToShortTimeString();
                aDisposalGeneral.Disposal_General_Reason = int.Parse(DisposalReasonComboBox.SelectedValue.ToString());
                aDisposalGeneral.Disposal_General_Number = GetNextDisposalNumber();
                aDisposalGeneral.Disposal_General_TotalCost = double.Parse(TotalTxtBox.Text);
                aDisposalGeneral.Disposal_General_TotalTax = double.Parse(TaxTxtBox.Text);
                aDisposalGeneral.Disposal_General_Comments = CommentsTxtBox.Text;
                aDisposalGeneral.Disposal_General_TellerID  = Convert.ToInt32(UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName()).ToString()); //for now
                return aDisposalGeneral;
            }
            catch
            {
                return null;
            }
        }

        private bool AddDisposalGeneral()
        {
            if (TeldgView.Rows.Count > 0)
            {
                if (DisposalReasonComboBox.SelectedValue == null)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.DisposalReasonTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return false;
                }

                DisposalGeneral aDisposalGeneral = FillDisposalGeneral();
                if (aDisposalGeneral == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!DisposalGeneralMgmt.InsertDisposal(aDisposalGeneral))
                {
                    return false;
                }
                DisposalDetailed aDisposalDetailed = new DisposalDetailed();
                foreach (DataGridViewRow r in TeldgView.Rows)
                {
                    if (!r.IsNewRow)
                    {
                        aDisposalDetailed.Disposal_Detailed_ItemID = ItemsMgmt.SelectItemIDByBarcode(TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString());
                        aDisposalDetailed.Disposal_Detailed_ItemDescription = TeldgView.Rows[r.Index].Cells["Description"].Value.ToString();
                        aDisposalDetailed.Disposal_Detailed_Date = DateTime.Now.ToShortDateString();
                        double TestParser = 0;
                        if (double.TryParse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString(), out TestParser))
                        {
                            aDisposalDetailed.Disposal_Detailed_Qty = TestParser;//double.Parse(TeldgView.Rows[r.Index].Cells["Qty"].Value.ToString());
                        }
                        else
                        {
                            TestParser = 1;
                        }
                        aDisposalDetailed.Disposal_Detailed_UnitCost = double.Parse(TeldgView.Rows[r.Index].Cells["PricePerUnit"].Value.ToString());
                        aDisposalDetailed.Disposal_Detailed_TotalPerUnit = double.Parse(TeldgView.Rows[r.Index].Cells["PriceTotal"].Value.ToString());
                        aDisposalDetailed.Disposal_Detailed_GeneralNumber = aDisposalGeneral.Disposal_General_Number;
                        DisposalDetailedMgmt.InsertDisposalItem(aDisposalDetailed);
                        string Barcode = TeldgView.Rows[r.Index].Cells["Barcode"].Value.ToString();
                        ItemsMgmt.UpdateItemQtyByBarcode(Barcode, ItemsMgmt.SelectItemQtyByBarcode(Barcode), (0 - TestParser));//0-qty wich is negative to be subtracted from orginnal

                    }
                }
                return true;
            }
            else
            {
                MessageBox.Show(MsgTxt.NotItemsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private bool print_receipt()
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]<th width=45%>" + ReceiptText.RctTxtItemName);
                aDataTable1.Columns.Add(ReceiptText.RctTxtUnitCost);
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
                aDataTable3.Columns.Add("[border=true1]<th>" + ReceiptText.RctTxtTax);
                aDataTable3.Columns.Add(TaxTxtBox.Text + "JOD");
                RowCnt = 0;


                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = "<td style=\"background-color:#000;color:#fff;border-right-color:#fff;\"><b><font size=4>" + ReceiptText.RctTxtTotal + "</font>";
                aDataTable3.Rows[RowCnt++][1] = "<td style=\"background-color:#000;color:#fff;border-left-color:#fff\"><b><font size=5>" + TotalTxtBox.Text + " JOD </font>";

                aDataTable3.Rows.Add();
                aDataTable3.Rows[RowCnt][0] = ReceiptText.RctTxtDisposalReason;
                aDataTable3.Rows[RowCnt++][1] = DisposalReasonComboBox.Text;

                aDataTableList.Add(aDataTable1);
                // aDataTableList.Add(aDataTable2);
                aDataTableList.Add(aDataTable3);

                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsDisposeitems);
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

                aStringList.Add(ReceiptText.RctTxtDisposeInvNumber + ":&nbsp; " + InvoiceNumTxtBox.Text);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[DisposeItems:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion DISPOSAL FUNCTIONS

        private void PaymentAndPrintBtn_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (AddDisposalGeneral())
            {
                if (!print_receipt())
                {
                    MessageBox.Show(MsgTxt.PrintingErrorTxt + " " + MsgTxt.AddedSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    this.TeldgView.Rows.Clear();
                    this.UpdateCash();
                }
                else
                {
                    this.Close();
                }
            }
            this.UseWaitCursor = false;
        }


        private void CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaymentOnlyBtn_Click(object sender, EventArgs e)
        {
            if (AddDisposalGeneral())
            {
                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    this.TeldgView.Rows.Clear();
                    this.UpdateCash();
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
    }
}
