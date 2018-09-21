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
using System.Diagnostics;
namespace Calcium_RMS
{
    public partial class AdjustItemsFrm : Form
    {
        #region Controllers
        private bool SEMAPHORE = false;
        #endregion Controllers

        #region RUNNING_MODES
        private AdjustItemsFrmModes ACTIVE_MODE = AdjustItemsFrmModes.ADDING_MODE;/*default is adding*/
        public enum AdjustItemsFrmModes : int
        {
            ADDING_MODE = 1,
            EDIT_MODE = 2
        }
        public void SetActiveMode(AdjustItemsFrmModes aMode)
        {
            ACTIVE_MODE = aMode;
            Initialize();
        }
        #endregion RUNNING_MODES

        #region INITIALIZATION
        public AdjustItemsFrm()
        {
            SEMAPHORE = true;
            InitializeComponent();
            Initialize();
            SEMAPHORE = false;
        }
        private void Initialize()
        {
            SEMAPHORE = true;
            if (ACTIVE_MODE == AdjustItemsFrmModes.ADDING_MODE)
            {
                Initialize_Adding_Mode();
            }
            else
            {
                Initialize_Edit_Mode();
            }
            SEMAPHORE = false;
        }
        private void Initialize_Adding_Mode()
        {
            AdjustDgView.Rows.Clear();
            SaveAndPrintBtn.Text = "Save";
            ReferenceNumberTxtBox.Text = AdjustInventoryGeneralMgmt.NextBillNumber().ToString();
            AdjDatePicker.Text = DateTime.Today.ToShortDateString();
            ExportAsPdfBtn.Visible = false;
        }
        private void Initialize_Edit_Mode()
        {
            AdjustDgView.Rows.Clear();
            this.Text = "EDIT ADJUST ITEM";
            SaveAndPrintBtn.Text = "Update";
            OldAvgQtyCol.Visible = true;
            ExportAsPdfBtn.Visible = true;

            ListItemsBtn.Visible = false;
        }
        DataTable aAdjustGeneralList = null;
        DataRow aUserRow = null;
        DataTable AllItemsTable = null;
        public void InitializeWithGeneralNumber(int RefNumber)
        {
            SEMAPHORE = true;
            aAdjustGeneralList = AdjustInventoryGeneralMgmt.SelectAllAdjustsGeneral(RefNumber, string.Empty, string.Empty);
            aItemsTable = AdjustInventoryDetailedMgmt.SelectAllAdjustsDetailed(RefNumber, -1);
            AllItemsTable = ItemsMgmt.SelectAllItems();
            aUserRow = UsersMgmt.SelectUserInfoByID(int.Parse(aAdjustGeneralList.Rows[0]["TellerID"].ToString()));

            if (aItemsTable.Rows.Count > 0)
            {
                aItemsTable.Columns.Add("PhysicalCountColumn", typeof(double));
                aItemsTable.Columns.Add("DifferencesColumn", typeof(double));
                aItemsTable.Columns.Add("DiffValueColumn", typeof(double));

                page(1);
            }
            else
            {
                MatchLbl.Visible = true;
            }

            AdjDatePicker.Text = aAdjustGeneralList.Rows[0]["Date"].ToString();
            ReferenceNumberTxtBox.Text = aAdjustGeneralList.Rows[0]["Number"].ToString();
            SEMAPHORE = false;
        }
        #endregion INITIALIZATION
        private void ListItemsBtn_Click(object sender, EventArgs e)
        {
            if (ACTIVE_MODE == AdjustItemsFrmModes.ADDING_MODE)
            {
                aItemsTable = ItemsMgmt.SelectAllItems();
                aItemsTable.Columns.Add("PhysicalCountColumn", typeof(double));
                aItemsTable.Columns.Add("DifferencesColumn", typeof(double));
                aItemsTable.Columns.Add("DiffValueColumn", typeof(double));
                foreach (DataRow aRow in aItemsTable.Rows)/*validating sends error if it is not initialized*/
                {
                    if (aRow["PhysicalCountColumn"].ToString() == string.Empty) aRow["PhysicalCountColumn"] = aRow["Qty"].ToString();
                    if (aRow["DifferencesColumn"].ToString() == string.Empty) aRow["DifferencesColumn"] = "0.00";
                    if (aRow["DiffValueColumn"].ToString() == string.Empty) aRow["DiffValueColumn"] = "0.00";
                }

                AddItemsToDgview();
            }
            else if (ACTIVE_MODE == AdjustItemsFrmModes.EDIT_MODE)
            {
                /* The button will be hidden in this mode*/
            }
        }
        private void AddItemsToDgview()
        {
            page(1);
        }
        #region PAGING
        int RowNum = 0;
        int pagesnumber = 1;
        int ItemsPerPage = 50;
        int currentpage = 1;
        DataTable aItemsTable = null;
        private void page(int pagenumber)
        {
            try
            {
                SEMAPHORE = true;
                // if (AdjustDgView.Rows.Count > 0)
                // {
                int dgrow = 0;
                AdjustDgView.Rows.Clear();
                //TestingFor Paging                
                for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                {
                    if (AdjustDgView.Rows.Count < ItemsPerPage && RowNum < aItemsTable.Rows.Count)
                    {
                        AdjustDgView.Rows.Add();
                        if (ACTIVE_MODE == AdjustItemsFrmModes.ADDING_MODE)
                        {
                            AdjustDgView.Rows[dgrow].Cells["BarcodeColumn"].Value = aItemsTable.Rows[RowNum]["Barcode"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["DescriptionColumn"].Value = aItemsTable.Rows[RowNum]["Description"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["AvgCostColumn"].Value = Math.Round(double.Parse(aItemsTable.Rows[RowNum]["AvgUnitCost"].ToString()), 3);
                            AdjustDgView.Rows[dgrow].Cells["AvaQtyColumn"].Value = aItemsTable.Rows[RowNum]["Qty"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["PhysicalCountColumn"].Value = (aItemsTable.Rows[RowNum]["PhysicalCountColumn"].ToString() == string.Empty) ? aItemsTable.Rows[RowNum]["PhysicalCountColumn"] = aItemsTable.Rows[RowNum]["Qty"].ToString() : aItemsTable.Rows[RowNum]["PhysicalCountColumn"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["DifferencesColumn"].Value = (aItemsTable.Rows[RowNum]["DifferencesColumn"].ToString() == string.Empty) ? aItemsTable.Rows[RowNum]["DifferencesColumn"] = "0.00" : aItemsTable.Rows[RowNum]["DifferencesColumn"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["DiffValueColumn"].Value = (aItemsTable.Rows[RowNum]["DiffValueColumn"].ToString() == string.Empty) ? aItemsTable.Rows[RowNum]["DiffValueColumn"] = "0.00" : aItemsTable.Rows[RowNum]["DiffValueColumn"].ToString();
                            dgrow++;
                        }
                        else if (ACTIVE_MODE == AdjustItemsFrmModes.EDIT_MODE)
                        {
                            AdjustDgView.Rows[dgrow].Cells["BarcodeColumn"].Value = Reports.ReportsHelper.FindData(AllItemsTable, "ID", "Barcode", aItemsTable.Rows[RowNum]["ItemID"].ToString());
                            AdjustDgView.Rows[dgrow].Cells["DescriptionColumn"].Value = Reports.ReportsHelper.FindData(AllItemsTable, "ID", "Description", aItemsTable.Rows[RowNum]["ItemID"].ToString());
                            AdjustDgView.Rows[dgrow].Cells["AvgCostColumn"].Value = Math.Abs(Math.Round(double.Parse(aItemsTable.Rows[RowNum]["DifferenceValue"].ToString()) / double.Parse(aItemsTable.Rows[RowNum]["DifferenceQty"].ToString()), 3));
                            AdjustDgView.Rows[dgrow].Cells["AvaQtyColumn"].Value = Reports.ReportsHelper.FindData(AllItemsTable, "ID", "Qty", aItemsTable.Rows[RowNum]["ItemID"].ToString());
                            AdjustDgView.Rows[dgrow].Cells["OldAvgQtyCol"].Value = aItemsTable.Rows[RowNum]["OldQty"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["PhysicalCountColumn"].Value = aItemsTable.Rows[RowNum]["NewQty"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["DifferencesColumn"].Value = aItemsTable.Rows[RowNum]["DifferenceQty"].ToString();
                            AdjustDgView.Rows[dgrow].Cells["DiffValueColumn"].Value = aItemsTable.Rows[RowNum]["DifferenceValue"].ToString();
                            dgrow++;
                        }

                    }
                }
                pagesnumber = (int)aItemsTable.Rows.Count / ItemsPerPage;
                if ((double.Parse(aItemsTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aItemsTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                    pagesnumber++;
                PageOfTotalTxtBox.Text = currentpage.ToString() + "/" + pagesnumber.ToString();
                SEMAPHORE = false;
                // }
            }
            catch (Exception ex)
            {
                SEMAPHORE = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AdjustList:page()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        private void GoToPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                if (int.TryParse(GotoPageTxtBox.Text, out TestParser))
                {
                    if (TestParser <= pagesnumber && TestParser > 0)
                    {
                        currentpage = TestParser;
                        page(currentpage);
                        PageOfTotalTxtBox.Text = currentpage.ToString() + "/" + pagesnumber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:GoToPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void PreviousPage_Click(object sender, EventArgs e)
        {
            try
            {
                if ((currentpage - 1) <= pagesnumber && (currentpage - 1) >= 1)
                {
                    page(--currentpage);
                    PageOfTotalTxtBox.Text = currentpage.ToString() + "/" + pagesnumber.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:PreviousPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void NextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if ((currentpage + 1) <= pagesnumber)
                {
                    page(++currentpage);
                    PageOfTotalTxtBox.Text = currentpage.ToString() + "/" + pagesnumber.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:NextPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void ItemsPerPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aItemsTable != null)
                {
                    if (TestParser > 0 && AdjustDgView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage <= 100)
                        {
                            pagesnumber = (int)aItemsTable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aItemsTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aItemsTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                                pagesnumber++;
                            PageOfTotalTxtBox.Text = "1/" + pagesnumber.ToString();
                            page(1);
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.ShouldNotBeLessThanTxt + " 100", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:ItemsPerPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        #endregion PAGING
        private void SaveAndPrintBtn_Click(object sender, EventArgs e)
        {
            if (ACTIVE_MODE == AdjustItemsFrmModes.ADDING_MODE)
            {
                AddAdjustToDataBase(aItemsTable);
            }
            else
            {
               UpdateAdjustToDataBase(aItemsTable);
            }
        }
        private void AddAdjustToDataBase(DataTable aTable)
        {
            int GeneralNumber = AddAdjustGeneralEntry(aTable);
            if (-1 != GeneralNumber)
            {
                if (AddAdjustDetailedEntry(aTable, GeneralNumber))
                {

                    MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportToPDF(GeneralNumber);
                    Initialize();
                }
                else
                {
                    /*First added successfully , one or more in adjust detailed entry not added you should delete everything*/
                    MessageBox.Show("NOT_ADDED", MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdjustInventoryGeneralMgmt.DeleteAdjustEntry(GeneralNumber);
                    AdjustInventoryDetailedMgmt.DeleteDetailedEntries(GeneralNumber);
                }
            }
            else
            {
                //  MessageBox.Show(MsgTxt.UnexpectedError+"Please report it to calcium", MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int AddAdjustGeneralEntry(DataTable aTable)
        {
            try
            {
                if (!ValidateAdjustTable(aTable))
                {
                    return -1;
                }
                AdjustInventoryGeneral aAdjustGeneral = new AdjustInventoryGeneral();
                aAdjustGeneral.Number = AdjustInventoryGeneralMgmt.NextBillNumber();
                aAdjustGeneral.TellerID = Convert.ToInt32(UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName()).ToString());
                aAdjustGeneral.Date = DateTime.Now.ToShortDateString();
                aAdjustGeneral.IsChecked = 0;
                if (AdjustInventoryGeneralMgmt.AddAdjustGeneralItem(aAdjustGeneral))
                {
                    return aAdjustGeneral.Number;
                }
                else
                {
                    return aAdjustGeneral.Number;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("NOT ADDED \n ERROR IN ADJUSTITEMSFRM: FUNCTION:AddAdjustToDataBase {EXCEPTION }" + ex.ToString(), MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private bool AddAdjustDetailedEntry(DataTable aTable, int GeneralNumber)
        {
            try
            {
                AdjustInventoryDetailed aAdjustDetailed = new AdjustInventoryDetailed();
                foreach (DataRow aRow in aItemsTable.Rows)
                {
                    if (double.Parse(aRow["DifferencesColumn"].ToString()) == 0)
                    {
                        continue;
                    }
                    aAdjustDetailed.Number = GeneralNumber;
                    aAdjustDetailed.ItemID = int.Parse(aRow["ID"].ToString());
                    aAdjustDetailed.OldQty = double.Parse(aRow["Qty"].ToString());
                    aAdjustDetailed.NewQty = double.Parse(aRow["PhysicalCountColumn"].ToString());
                    aAdjustDetailed.DifferenceQty = double.Parse(aRow["DifferencesColumn"].ToString());
                    aAdjustDetailed.DifferenceValue = double.Parse(aRow["DiffValueColumn"].ToString());
                    if (AdjustInventoryDetailedMgmt.AddAdjustDetailedItem(aAdjustDetailed))
                    {
                        if (!ItemsMgmt.UpdateItemQtyByID(aAdjustDetailed.ItemID, aAdjustDetailed.NewQty))
                        {
                            return false;
                        }
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in AddAdjustDetailedEntry {EXCEPTION}" + ex.ToString(), "PLEASE CONTACT CALCIUM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void UpdateAdjustToDataBase(DataTable aTable)
        {
            int GeneralNumber = UpdateAdjustGeneralEntry(aTable);
            if (-1 != GeneralNumber)
            {
                if (UpdateAdjustDetailedEntry(aTable, GeneralNumber))
                {

                    MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportToPDF(GeneralNumber);
                    SEMAPHORE = true;
                    this.Close();
                }
                else
                {
                    /*First added successfully , one or more in adjust detailed entry not added you should delete everything*/
                    MessageBox.Show("NOT_UPDATED", MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //AdjustInventoryGeneralMgmt.DeleteAdjustEntry(GeneralNumber);
                   // AdjustInventoryDetailedMgmt.DeleteDetailedEntries(GeneralNumber);
                }
            }
            else
            {
                //  MessageBox.Show(MsgTxt.UnexpectedError+"Please report it to calcium", MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int UpdateAdjustGeneralEntry(DataTable aTable)
        {
            try
            {
                if (!ValidateAdjustTable(aTable))
                {
                    return -1;
                }
                //AdjustInventoryGeneral aAdjustGeneral = new AdjustInventoryGeneral();
                //aAdjustGeneral.Number = AdjustInventoryGeneralMgmt.NextBillNumber();
                //aAdjustGeneral.TellerID = Convert.ToInt32(UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName()).ToString());
                //aAdjustGeneral.Date = DateTime.Now.ToShortDateString();
                //aAdjustGeneral.IsChecked = 0;
                //if (AdjustInventoryGeneralMgmt.AddAdjustGeneralItem(aAdjustGeneral))
                //{
                //    return aAdjustGeneral.Number;
                //}
                //else
                //{
                //    return aAdjustGeneral.Number;
                //}
                return int.Parse(aTable.Rows[0]["Number"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("NOT ADDED \n ERROR IN ADJUSTITEMSFRM: FUNCTION:UpdateAdjustGeneralEntry {EXCEPTION }" + ex.ToString(), MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private bool UpdateAdjustDetailedEntry(DataTable aTable, int GeneralNumber)
        {
            try
            {
                AdjustInventoryDetailed aAdjustDetailed = new AdjustInventoryDetailed();
                foreach (DataRow aRow in aItemsTable.Rows)
                {
                    aAdjustDetailed.Number = GeneralNumber;
                    aAdjustDetailed.ItemID = int.Parse(aRow["ItemID"].ToString());
                    aAdjustDetailed.OldQty = double.Parse(aRow["NewQty"].ToString());/* bug it should be updated to the next one*/
                    aAdjustDetailed.NewQty = double.Parse(aRow["PhysicalCountColumn"].ToString());
                    aAdjustDetailed.DifferenceQty = double.Parse(aRow["DifferencesColumn"].ToString());
                    aAdjustDetailed.DifferenceValue = double.Parse(aRow["DiffValueColumn"].ToString());
                    double CurrentQty = double.Parse(ReportsHelper.FindData(AllItemsTable,"ID","Qty",aRow["ItemID"].ToString()));
                    if (AdjustInventoryDetailedMgmt.UpdateDetailedSingleEntry(aAdjustDetailed))
                    {
                        if (!ItemsMgmt.UpdateItemQtyByID(aAdjustDetailed.ItemID, (CurrentQty - (aAdjustDetailed.OldQty - aAdjustDetailed.NewQty))))
                        {
                            return false;
                        }
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception in UpdateAdjustDetailedEntry {EXCEPTION}" + ex.ToString(), "PLEASE CONTACT CALCIUM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ValidateAdjustTable(DataTable aTable)
        {
            if (aTable == null)
            {
                MessageBox.Show("WARNING - EMPTY TABLE", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (aTable.Rows.Count == 0)
            {
                MessageBox.Show("WARNING - EMPTY TABLE", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            double TestParser = 0.00;

            foreach (DataRow aRow in aTable.Rows)
            {
                if (!double.TryParse(aRow["PhysicalCountColumn"].ToString(), out TestParser))
                {
                    MessageBox.Show("WARNING - PLEASE FILL ALL FIELD BEFORE SAVING/UPDATING", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!double.TryParse(aRow["DifferencesColumn"].ToString(), out TestParser))
                {
                    MessageBox.Show("WARNING - PLEASE FILL ALL FIELD BEFORE SAVING/UPDATING", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (!double.TryParse(aRow["DiffValueColumn"].ToString(), out TestParser))
                {
                    MessageBox.Show("WARNING - PLEASE FILL ALL FIELD BEFORE SAVING/UPDATING", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void AdjustDgView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SEMAPHORE)
                {
                    return;
                }
                else
                {
                    bool __IS_ERROR__ = false;
                    DataGridViewCell CallerCell = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
                    int DatatableRowIndex = CallerCell.RowIndex + ((currentpage - 1) * (ItemsPerPage));
                    double TestParser = 0.00;
                    if (double.TryParse(CallerCell.Value.ToString(), out TestParser))
                    {
                        if (TestParser < 0)
                        {
                            __IS_ERROR__ = true;
                        }
                        else
                        {
                            SEMAPHORE = true;
                            if (ACTIVE_MODE==AdjustItemsFrmModes.ADDING_MODE)
                            {
                                aItemsTable.Rows[DatatableRowIndex][CallerCell.OwningColumn.Name] = Math.Round(TestParser, 3);
                                CallerCell.Value = Math.Round(TestParser, 3);
                                double difference = TestParser - double.Parse(aItemsTable.Rows[DatatableRowIndex]["Qty"].ToString());
                                aItemsTable.Rows[DatatableRowIndex]["DifferencesColumn"] = Math.Round(difference, 3);
                                AdjustDgView.Rows[e.RowIndex].Cells["DifferencesColumn"].Value = Math.Round(difference, 3);
                                double AvgUnitCost = double.Parse(aItemsTable.Rows[DatatableRowIndex]["AvgUnitCost"].ToString());
                                aItemsTable.Rows[DatatableRowIndex]["DiffValueColumn"] = Math.Round(difference * AvgUnitCost, 3);
                                AdjustDgView.Rows[e.RowIndex].Cells["DiffValueColumn"].Value = Math.Round(difference * AvgUnitCost, 3);
                            }
                            else/*EDIT MODE*/
                            {
                                aItemsTable.Rows[DatatableRowIndex][CallerCell.OwningColumn.Name] = Math.Round(TestParser, 3);
                                CallerCell.Value = Math.Round(TestParser, 3);
                                double difference = TestParser - double.Parse(AdjustDgView.Rows[e.RowIndex].Cells["AvaQtyColumn"].Value.ToString());//double.Parse(aItemsTable.Rows[DatatableRowIndex]["OldQty"].ToString());
                                aItemsTable.Rows[DatatableRowIndex]["DifferencesColumn"] = Math.Round(difference, 3);
                                AdjustDgView.Rows[e.RowIndex].Cells["DifferencesColumn"].Value = Math.Round(difference, 3);
                                double AvgUnitCost = 0;
                                if (double.Parse(aItemsTable.Rows[DatatableRowIndex]["DifferenceQty"].ToString()) != 0)
                                {
                                  AvgUnitCost= Math.Abs(Math.Round(double.Parse(aItemsTable.Rows[DatatableRowIndex]["DifferenceValue"].ToString()) / double.Parse(aItemsTable.Rows[DatatableRowIndex]["DifferenceQty"].ToString()),3));
                                }
                                aItemsTable.Rows[DatatableRowIndex]["DiffValueColumn"] = Math.Round(difference * AvgUnitCost, 3);
                                AdjustDgView.Rows[e.RowIndex].Cells["DiffValueColumn"].Value = Math.Round(difference * AvgUnitCost, 3);
                            }
                            
                            SEMAPHORE = false;
                        }
                    }
                    else
                    {
                        __IS_ERROR__ = true;

                    }


                    if (__IS_ERROR__)
                    {
                        SEMAPHORE = true;
                        aItemsTable.Rows[DatatableRowIndex][CallerCell.OwningColumn.Name] = aItemsTable.Rows[DatatableRowIndex]["Qty"].ToString();
                        CallerCell.Value = Math.Round(double.Parse(aItemsTable.Rows[DatatableRowIndex][CallerCell.OwningColumn.Name].ToString()), 3);
                        aItemsTable.Rows[DatatableRowIndex]["DifferencesColumn"] = 0.00;
                        AdjustDgView.Rows[e.RowIndex].Cells["DifferencesColumn"].Value = 0.00;
                        aItemsTable.Rows[DatatableRowIndex]["DiffValueColumn"] = 0.00;
                        AdjustDgView.Rows[e.RowIndex].Cells["DiffValueColumn"].Value = 0.00;
                        MessageBox.Show("Please enter correct value", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        SEMAPHORE = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #region REPORTING
        private bool ExportToPDF(int GeneralNumber)
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]" + "<th width=15%>" + ReportsText.BarcodeRepTxt);
                aDataTable1.Columns.Add("<th width=20%>" + ReportsText.DescriptionRepTxt);
                aDataTable1.Columns.Add("<th width=9%>" + ReportsText.AvgCostRepTxt);
                aDataTable1.Columns.Add("<th width=9%>" + ReportsText.AvaQtyRepTxt);
                aDataTable1.Columns.Add(ReportsText.PhysicalCountRepTxt);
                aDataTable1.Columns.Add(ReportsText.DifferencesRepTxt);
                aDataTable1.Columns.Add(ReportsText.DifferenceValueRepTxt);

                double TotalPositive = 0.00, TotalNegative = 0.00, ParsingTester = 0.00; ;
                foreach (DataRow aRow in aItemsTable.Rows)
                {
                    if (double.Parse(aRow["DifferencesColumn"].ToString()) == 0)
                    {
                        if (ACTIVE_MODE == AdjustItemsFrmModes.EDIT_MODE)
                        {
                            AdjustInventoryDetailedMgmt.DeleteDetailedEntries(GeneralNumber,int.Parse(aRow["ID"].ToString()));
                        }

                        continue;
                    }
                    DataRow aToAddRow = aDataTable1.Rows.Add();
                    if (ACTIVE_MODE==AdjustItemsFrmModes.ADDING_MODE)
                    {
                        aToAddRow[0] = aRow["Barcode"];
                        aToAddRow[1] = aRow["Description"];
                        aToAddRow[2] = Math.Round(double.Parse(aRow["AvgUnitCost"].ToString()), 3);
                        aToAddRow[3] = Math.Round(double.Parse(aRow["Qty"].ToString()), 3);
                        aToAddRow[4] = aRow["PhysicalCountColumn"];
                        aToAddRow[5] = aRow["DifferencesColumn"];
                        ParsingTester = double.Parse(aRow["DiffValueColumn"].ToString());
                        aToAddRow[6] = ParsingTester;  
                    }
                    else if (ACTIVE_MODE == AdjustItemsFrmModes.EDIT_MODE)
                    {
                        aToAddRow[0] = ReportsHelper.FindData(AllItemsTable, "ID", "Barcode", aRow["ItemID"].ToString());
                        aToAddRow[1] = ReportsHelper.FindData(AllItemsTable, "ID", "Description", aRow["ItemID"].ToString());
                        aToAddRow[2] = Math.Round(double.Parse(ReportsHelper.FindData(AllItemsTable, "ID", "AvgUnitCost", aRow["ItemID"].ToString())), 3);
                        aToAddRow[3] = Math.Round(double.Parse(ReportsHelper.FindData(AllItemsTable, "ID", "Qty", aRow["ItemID"].ToString())), 3);
                        aToAddRow[4] = aRow["PhysicalCountColumn"];
                        aToAddRow[5] = aRow["DifferencesColumn"];
                        ParsingTester = double.Parse(aRow["DiffValueColumn"].ToString());
                        aToAddRow[6] = ParsingTester; 
                    }
                    
                    if (ParsingTester > 0)
                    {
                        TotalPositive += ParsingTester;
                    }
                    else
                    {
                        TotalNegative += ParsingTester;
                    }
                }

                if (aDataTable1.Rows.Count == 0)
                {
                    DataTable aEmptyTable = new DataTable();
                    aEmptyTable.Columns.Add("INVENTORY STOCK AVAILABLE QTY MATCHES 100% THE PHYSICAL COUNT");
                    aDataTableList.Add(aEmptyTable);
                }
                else
                {

                    aDataTableList.Add(aDataTable1);
                    DataRow NetRow = aDataTable1.Rows.Add();
                    string EmptyNoborderRow = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                    NetRow[0] = EmptyNoborderRow;
                    NetRow[1] = EmptyNoborderRow;
                    NetRow[2] = EmptyNoborderRow;
                    NetRow[3] = EmptyNoborderRow;
                    NetRow[4] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.TotalRepTxt + ReportsHelper.MANUAL_TD_END;
                    NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.PosAdjValueRepTxt + ReportsHelper.MANUAL_TD_END;
                    NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + TotalPositive + ReportsHelper.MANUAL_TD_END;
                    NetRow = aDataTable1.Rows.Add();
                    NetRow[0] = EmptyNoborderRow;
                    NetRow[1] = EmptyNoborderRow;
                    NetRow[2] = EmptyNoborderRow;
                    NetRow[3] = EmptyNoborderRow;
                    NetRow[4] = EmptyNoborderRow;
                    NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.NegAdjValueRepTxt + ReportsHelper.MANUAL_TD_END;
                    NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + TotalNegative + ReportsHelper.MANUAL_TD_END;
                    NetRow = aDataTable1.Rows.Add();
                    NetRow[0] = EmptyNoborderRow;
                    NetRow[1] = EmptyNoborderRow;
                    NetRow[2] = EmptyNoborderRow;
                    NetRow[3] = EmptyNoborderRow;
                    NetRow[4] = EmptyNoborderRow;
                    NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + "<b>" + ReportsText.NetValueRepTxt + "<b>" + ReportsHelper.MANUAL_TD_END;
                    NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + (TotalNegative + TotalPositive) + ReportsHelper.MANUAL_TD_END;

                }
                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
              
                if (ACTIVE_MODE==AdjustItemsFrmModes.ADDING_MODE)
                {
                    aStringList.Add(ReportsNames.InventoryStockAdjustRepName);
                    aStringList.Add("<h2>" + ReportsText.PrintedOnrepTxt + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                    aStringList.Add("<h2> " + ReportsText.PrintedByrepTxt + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                }
                else
                {
                    aStringList.Add("Update "+ReportsNames.InventoryStockAdjustRepName );
                    aStringList.Add("<h2>" + ReceiptText.RctTxtOrgDate + " " +DateTime.Parse( aAdjustGeneralList.Rows[0]["Date"].ToString()).ToShortDateString() + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtOrgTeller + ":&nbsp;&nbsp;" +aUserRow["UserName"].ToString() + "</h2>");

                    aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                    aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                }

                aStringList.Add(ReceiptText.RctTxtInvoiceNum + ":&nbsp; " + GeneralNumber);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);

                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, false, false, !XlsChkBox.Checked, ReportsHelper.TempPDFOutputPath, XlsChkBox.Checked, ReportsHelper.TempOutputPathExcel, false, false);

                if (XlsChkBox.Checked)
                {
                    Process.Start(ReportsHelper.TempOutputPathExcel);
                }
                else
                {
                    Process.Start(ReportsHelper.TempPDFOutputPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[AdjustItemsFrm:ExportToPDF [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion REPORTING
    }
}
