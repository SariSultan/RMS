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
using System.Diagnostics;

namespace Calcium_RMS
{
    public partial class ListItems : Form
    {
        public DateTime StartTime;
        public DataTable ItemsDatatable;
        public DataTable TaxLevelDataTable;
        public DataTable ItemCategoryDataTable;
        public DataTable VendorsDataTable;
        public DataTable ItemsTypeDataTalbe;

        int taxlevelrowsnumber;
        int itemcategoryrowsnumber;
        int vendorrowsnumber;
        int typerowsnumber;
        int pagesnumber;
        int ItemsPerPage = 50;
        int currentpage;
        public ListItems()
        {
            InitializeComponent();
            TranslateUI();
            GotoPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
            ItemsPerPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
        }

        int RowNum = 0;

        private void ListItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ListItemsDgView.Rows.Clear();
                if (RndrPointChkBox.Checked)
                {
                    ItemsDatatable = ItemsMgmt.RenderPoint();
                }
                else
                {
                    ItemsDatatable = ItemsMgmt.SelectAllItems();
                }

                if (ItemsDatatable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItemsBtn_Click:DB-ERROR  ItemsDatatable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                TotalITemsTxtBox.Text = ItemsDatatable.Rows.Count.ToString();

                TaxLevelDataTable = ItemTaxLevelMgmt.SelectAll();
                ItemCategoryDataTable = ItemCategoryMgmt.SelectAll();
                VendorsDataTable = VendorsMgmt.SelectAllVendors();
                ItemsTypeDataTalbe = ItemTypeMgmt.SelectAll();
                if (TaxLevelDataTable == null || ItemCategoryDataTable == null || VendorsDataTable == null || ItemsTypeDataTalbe == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItemsBtn_Click:DB-ERROR  TaxLevelDataTable=null ||ItemCategoryDataTable=null || VendorsDataTable==null ||  ItemsTypeDataTalbe==null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                taxlevelrowsnumber = TaxLevelDataTable.Rows.Count;
                itemcategoryrowsnumber = ItemCategoryDataTable.Rows.Count;
                vendorrowsnumber = VendorsDataTable.Rows.Count;
                typerowsnumber = ItemsTypeDataTalbe.Rows.Count;

                if (ItemsDatatable.Rows.Count > 0)
                {

                    //TestingFor Paging
                    pagesnumber = (int)ItemsDatatable.Rows.Count / ItemsPerPage;
                    if ((double.Parse(ItemsDatatable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(ItemsDatatable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                        pagesnumber++;

                    RowNum = 0;
                    ListItemsDgView.Rows.Clear();
                    foreach (DataRow r in ItemsDatatable.Rows)
                    {
                        if (ListItemsDgView.Rows.Count < ItemsPerPage)
                        {
                            ListItemsDgView.Rows.Add();
                            // TRIAL 2 CODE
                            ListItemsDgView.Rows[RowNum].Cells["Barcode"].Value = ItemsDatatable.Rows[RowNum]["Barcode"].ToString();
                            for (int i = 0; i < typerowsnumber; i++)
                            {
                                if (int.Parse(ItemsTypeDataTalbe.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Type"].ToString()))
                                {
                                    ListItemsDgView.Rows[RowNum].Cells["Type"].Value = ItemsTypeDataTalbe.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < itemcategoryrowsnumber; i++)
                            {
                                if (int.Parse(ItemCategoryDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Category"].ToString()))
                                {
                                    ListItemsDgView.Rows[RowNum].Cells["Category"].Value = ItemCategoryDataTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < taxlevelrowsnumber; i++)
                            {
                                if (int.Parse(TaxLevelDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["TaxLevel"].ToString()))
                                {
                                    ListItemsDgView.Rows[RowNum].Cells["TaxLevel"].Value = TaxLevelDataTable.Rows[i]["Percentage"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < vendorrowsnumber; i++)
                            {
                                if (int.Parse(VendorsDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Vendor"].ToString()))
                                {
                                    ListItemsDgView.Rows[RowNum].Cells["Vendor"].Value = VendorsDataTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            ListItemsDgView.Rows[RowNum].Cells["Description"].Value = ItemsDatatable.Rows[RowNum]["Description"].ToString();
                            ListItemsDgView.Rows[RowNum].Cells["Qty"].Value = ItemsDatatable.Rows[RowNum]["Qty"].ToString();
                            ListItemsDgView.Rows[RowNum].Cells["AvgUnitCost"].Value = Math.Round(double.Parse( ItemsDatatable.Rows[RowNum]["AvgUnitCost"].ToString()),3);
                            ListItemsDgView.Rows[RowNum].Cells["SellPrice"].Value = ItemsDatatable.Rows[RowNum]["SellPrice"].ToString();
                            ListItemsDgView.Rows[RowNum].Cells["RenderPoint"].Value = ItemsDatatable.Rows[RowNum]["RenderPoint"].ToString();
                            ListItemsDgView.Rows[RowNum].Cells["Margincol"].Value = (Convert.ToDouble(ListItemsDgView.Rows[RowNum].Cells["SellPrice"].Value) - Convert.ToDouble(ListItemsDgView.Rows[RowNum].Cells["AvgUnitCost"].Value)) / Convert.ToDouble(ListItemsDgView.Rows[RowNum].Cells["AvgUnitCost"].Value) * 100;
                            ListItemsDgView.Rows[RowNum].Cells["DateAdded"].Value = ItemsDatatable.Rows[RowNum]["EntryDate"].ToString();
                            RowNum++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomersBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            /* TimeSpan ts = DateTime.Now.Subtract(StartTime);
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds / 10);*/
            PageOfTotalTxtBox.Text = "1/" + pagesnumber.ToString();
            currentpage = 1;
            // Console.WriteLine(elapsedTime, "RunTime");

            // MessageBox.Show("Elasped Time in Seconds for [[1,300]] items [TRIAL 2 new code] is =" + elapsedTime);


        }

        private void page(int pagenumber)
        {
            StartTime = DateTime.Now;
            try
            {
                if (ItemsDatatable.Rows.Count > 0)
                {
                    int dgrow = 0;
                    ListItemsDgView.Rows.Clear();
                    //TestingFor Paging                
                    for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                    {
                        if (ListItemsDgView.Rows.Count < ItemsPerPage && RowNum < ItemsDatatable.Rows.Count)
                        {
                            ListItemsDgView.Rows.Add();
                            // TRIAL 2 CODE
                            ListItemsDgView.Rows[dgrow].Cells["Barcode"].Value = ItemsDatatable.Rows[RowNum]["Barcode"].ToString();
                            for (int i = 0; i < typerowsnumber; i++)
                            {
                                if (int.Parse(ItemsTypeDataTalbe.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Type"].ToString()))
                                {
                                    ListItemsDgView.Rows[dgrow].Cells["Type"].Value = ItemsTypeDataTalbe.Rows[i]["Name"].ToString();
                                    break;
                                }
                                //else
                                //{ MessageBox.Show("ERROR"); }
                            }
                            for (int i = 0; i < itemcategoryrowsnumber; i++)
                            {
                                if (int.Parse(ItemCategoryDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Category"].ToString()))
                                {
                                    ListItemsDgView.Rows[dgrow].Cells["Category"].Value = ItemCategoryDataTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < taxlevelrowsnumber; i++)
                            {
                                if (int.Parse(TaxLevelDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["TaxLevel"].ToString()))
                                {
                                    ListItemsDgView.Rows[dgrow].Cells["TaxLevel"].Value = TaxLevelDataTable.Rows[i]["Percentage"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < vendorrowsnumber; i++)
                            {
                                if (int.Parse(VendorsDataTable.Rows[i]["ID"].ToString()) == int.Parse(ItemsDatatable.Rows[RowNum]["Vendor"].ToString()))
                                {
                                    ListItemsDgView.Rows[dgrow].Cells["Vendor"].Value = VendorsDataTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            ListItemsDgView.Rows[dgrow].Cells["Description"].Value = ItemsDatatable.Rows[RowNum]["Description"].ToString();
                            ListItemsDgView.Rows[dgrow].Cells["Qty"].Value = ItemsDatatable.Rows[RowNum]["Qty"].ToString();
                            ListItemsDgView.Rows[dgrow].Cells["AvgUnitCost"].Value = Math.Round(double.Parse(ItemsDatatable.Rows[RowNum]["AvgUnitCost"].ToString()), 3); 
                            ListItemsDgView.Rows[dgrow].Cells["SellPrice"].Value = ItemsDatatable.Rows[RowNum]["SellPrice"].ToString();
                            ListItemsDgView.Rows[dgrow].Cells["RenderPoint"].Value = ItemsDatatable.Rows[RowNum]["RenderPoint"].ToString();
                            ListItemsDgView.Rows[dgrow].Cells["Margincol"].Value = (Convert.ToDouble(ListItemsDgView.Rows[dgrow].Cells["SellPrice"].Value) - Convert.ToDouble(ListItemsDgView.Rows[dgrow].Cells["AvgUnitCost"].Value)) / Convert.ToDouble(ListItemsDgView.Rows[dgrow].Cells["SellPrice"].Value);
                            ListItemsDgView.Rows[dgrow].Cells["DateAdded"].Value = ItemsDatatable.Rows[RowNum]["EntryDate"].ToString();
                            //  ListItemsDgView.Rows[dgrow].Cells["SalesPrice"].Value = ItemsDatatable.Rows[RowNum]["SalesPrice"].ToString();
                            dgrow++;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:page()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            //TimeSpan ts = DateTime.Now.Subtract(StartTime);
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //        ts.Hours, ts.Minutes, ts.Seconds,
            //        ts.Milliseconds / 10);
            //// Console.WriteLine(elapsedTime, "RunTime");

            //MessageBox.Show("Elasped Time in Seconds for " + ItemsPerPage + " items [TRIAL 2 new code] is =" + elapsedTime);

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
                ListItemsBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && ItemsDatatable != null)
                {
                    if (TestParser > 0 && ListItemsDgView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage < 100)
                        {
                            pagesnumber = (int)ItemsDatatable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(ItemsDatatable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(ItemsDatatable.Rows.Count.ToString()) / ItemsPerPage) > 0)
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

        private void ListItemsDgView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow aItemrow = ItemsMgmt.SelectItemRowByBarcode(ListItemsDgView.Rows[e.RowIndex].Cells["Barcode"].Value.ToString());
                if (aItemrow == null)
                {
                    return;
                }
                EditItems aEditItems = new EditItems();
                aEditItems.Show();
                aEditItems.TopLevel = true;
                aEditItems.UpdateVariables(aItemrow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListItems:ListItemsDgView_CellDoubleClick()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListItemsFormName;
                ///   this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //// this.RightToLeftLayout = true;
                ItemsPerPageBtn.Text = UiText.LstItmItemsPerPageBtn;
                ItemsPerPageLbl.Text = UiText.LstItmItemsPerPageLbl;
                ListItemsBtn.Text = UiText.LstItmListItemsBtn;
                // GoToPageBtn.Text = UiText.LstItmNextPageBtn;//GoToPageBtn.Text = @AYMAN-V01F this was NextPageBtn we need to make it go to page
                RndrPointChkBox.Text = UiText.LstItmRndrPointChkBox;
                TotalItemsLbl.Text = UiText.LstItmTotalItemsLbl;
                TotalPagesLbl.Text = UiText.LstItmTotalPagesLbl;
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

        private void ExportPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog aDial = new SaveFileDialog();
                aDial.Filter = "PDF Files (*.PDF) | *.PDF";
                aDial.FileName = "Items_List_" + DateTime.Now.ToShortDateString().Replace("\\", "").Replace("/", "");
                if (aDial.ShowDialog() == DialogResult.OK)
                {
                    if (Reports.ItemsReports.Instance.PrintItemsList(RndrPointChkBox.Checked, false, true, false, aDial.FileName, TableBorderChkBox.Checked, false, ColoredChkBox.Checked)) 
                    {
                        Process.Start(aDial.FileName);
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


    }
}
