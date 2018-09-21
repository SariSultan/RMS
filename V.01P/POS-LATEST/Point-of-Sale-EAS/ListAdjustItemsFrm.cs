using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Text;
using Calcium_RMS.Reports;
using System.Diagnostics;

namespace Calcium_RMS
{
    public partial class ListAdjustItemsFrm : Form
    {
        bool SEMAPHORE = false;
        public ListAdjustItemsFrm()
        {
            SEMAPHORE = true;
            InitializeComponent();
            SEMAPHORE = false ;
        }
        private void ListAdjustsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                aAdjustList = AdjustInventoryGeneralMgmt.SelectAllAdjustsGeneral(-1, string.Empty, string.Empty);
                aAdjustDetailedSumVal = AdjustInventoryDetailedMgmt.SelectAllAdjustsDetailedSUMValue(-1, -1);
                aUsersTable = UsersMgmt.SelectAllUsers();
                page(1);
            }
            catch (Exception ex)
            { MessageBox.Show("ERROR IN LIST ADJUST ITEMS" + ex.ToString(), MsgTxt.UnexpectedError, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #region PAGING
        int RowNum = 0;
        int pagesnumber = 1;
        int ItemsPerPage = 50;
        int currentpage = 1;
        DataTable aAdjustList = null;
        DataTable aAdjustDetailedSumVal = null;
        DataTable aUsersTable = null;
        private void page(int pagenumber)
        {
            try
            {
                SEMAPHORE = true;
                // if (AdjustDgView.Rows.Count > 0)
                // {
                int dgrow = 0;
                ListAdjustDgView.Rows.Clear();
                //TestingFor Paging                
                for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                {
                    if (ListAdjustDgView.Rows.Count < ItemsPerPage && RowNum < aAdjustList.Rows.Count)
                    {
                        ListAdjustDgView.Rows.Add();
                        ListAdjustDgView.Rows[dgrow].Cells["RefNumCol"].Value = aAdjustList.Rows[RowNum]["Number"].ToString();
                        string TellerID = aAdjustList.Rows[RowNum]["TellerID"].ToString();
                        ListAdjustDgView.Rows[dgrow].Cells["AddedByCol"].Value = Reports.ReportsHelper.FindData(aUsersTable, "ID", "UserName", TellerID);
                        ListAdjustDgView.Rows[dgrow].Cells["DateCol"].Value = aAdjustList.Rows[RowNum]["Date"].ToString();
                        double aValue=double.Parse(Reports.ReportsHelper.FindData(aAdjustDetailedSumVal, "Number", "DifferenceValue", aAdjustList.Rows[RowNum]["Number"].ToString()));
                        ListAdjustDgView.Rows[dgrow].Cells["TotalDiffValCol"].Value = aValue;
                        dgrow++;
                    }
                }
                pagesnumber = (int)aAdjustList.Rows.Count / ItemsPerPage;
                if ((double.Parse(aAdjustList.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aAdjustList.Rows.Count.ToString()) / ItemsPerPage) > 0)
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
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aAdjustList != null)
                {
                    if (TestParser > 0 && ListAdjustDgView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage <= 100)
                        {
                            pagesnumber = (int)aAdjustList.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aAdjustList.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aAdjustList.Rows.Count.ToString()) / ItemsPerPage) > 0)
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


        private void ExportAsBtn_Click(object sender, EventArgs e)
        {
            int GeneralNumber = -1;
            if (int.TryParse(RefNumberTxtBox.Text, out GeneralNumber))
            {
                /*OK DO NOTHING*/
            }
            else
            {
                MessageBox.Show("Please Select Reference Number by clicking on the desired row", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           /* if (ExportAsComboBox.Text == ExportAsComboBox.Items[0].ToString())/*PDF*/
           /* {

            }
            else if (ExportAsComboBox.Text == ExportAsComboBox.Items[1].ToString())/*Excel*/
            /*{

            }
            else
            {
                MessageBox.Show("Please Select Report Type", MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            string SaveAsPath = "",ExportPath="";
            bool ExportToPdf=false,ExportToExcel=false;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF file|*.pdf|Excel Sheet|*.xls";
            saveFileDialog1.Title = "Save Report (A4)";
            saveFileDialog1.FileName = "Adjust Inventory Report" + DateTime.Now.ToShortDateString();
            saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"/", "-");
            saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"\\", "-");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveAsPath = saveFileDialog1.FileName;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        ExportToPdf = true;
                        ExportPath = SaveAsPath;
                        break;
                    case 2: //THIS IS ONLY EXCEL
                        ExportToExcel = true;
                        ExportPath = SaveAsPath;
                        break;
                }
            }

            bool retval = false ;
            if (ExportToPdf)
            {
                retval = InventoryReports.InventoryAdjustReport(GeneralNumber, true, false, false, true, false, ExportPath, false);
            }
            else if (ExportToExcel)
            {
                retval = InventoryReports.InventoryAdjustReport(GeneralNumber, true, false, false, false, true, ExportPath, false);
            }


            if (retval)
            {
                if (ExportToPdf || ExportToExcel)
                {
                    Process.Start(ExportPath);
                }
            }
            else
            {
                MessageBox.Show(MsgTxt.NoDataTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void ListAdjustDgView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SEMAPHORE) return;
                RefNumberTxtBox.Text = ((DataGridView)sender).Rows[e.RowIndex].Cells[RefNumCol.Name].Value.ToString();
            }
            catch (Exception ex)
            { }
        }

        private void ListAdjustDgView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (SEMAPHORE) return;
                int refNum = int.Parse(RefNumberTxtBox.Text);

                AdjustItemsFrm aEditAdjustFrm = new AdjustItemsFrm();
                aEditAdjustFrm.SetActiveMode(AdjustItemsFrm.AdjustItemsFrmModes.EDIT_MODE);
                aEditAdjustFrm.InitializeWithGeneralNumber(refNum);
                aEditAdjustFrm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
