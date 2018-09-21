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
    public partial class ListVendors : Form
    {
        int RowNum = 0;
        int pagesnumber;
        int ItemsPerPage =50;
        int currentpage = 1;

        DataTable aVendorTable;
        DataTable aVendorAccountTable;
        public ListVendors()
        {
            InitializeComponent();
            TranslateUI();

            GotoPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
            ItemsPerPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
        }

        private void ListVendorsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                aVendorTable = VendorsMgmt.SelectAllVendors();
                if (aVendorTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendorsBtn_Click:DB-ERROR  aVendorTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                aVendorAccountTable = VendorsAccountsMgmt.SelectAll();
                if (aVendorAccountTable == null && aVendorTable.Rows.Count != 0)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendorsBtn_Click:DB-ERROR  aVendorAccountTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TotalITemsTxtBox.Text = aVendorTable.Rows.Count.ToString();
                if (aVendorTable.Rows.Count > 0)
                {
                    pagesnumber = (int)aVendorTable.Rows.Count / ItemsPerPage;
                    if ((double.Parse(aVendorTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aVendorTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                        pagesnumber++;

                    RowNum = 0;
                    ListVendorsDGView.Rows.Clear();

                    foreach (DataRow r in aVendorTable.Rows)
                    {
                        if (ListVendorsDGView.Rows.Count < ItemsPerPage)
                        {
                            ListVendorsDGView.Rows.Add();
                            ListVendorsDGView.Rows[RowNum].Cells["Namecol"].Value = aVendorTable.Rows[RowNum]["Name"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["Locationcol"].Value = aVendorTable.Rows[RowNum]["Location"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["Phone1"].Value = aVendorTable.Rows[RowNum]["Phone1"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["Phone2"].Value = aVendorTable.Rows[RowNum]["Phone2"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["Email"].Value = aVendorTable.Rows[RowNum]["Email"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["Company"].Value = aVendorTable.Rows[RowNum]["Company"].ToString();
                            ListVendorsDGView.Rows[RowNum].Cells["StartDate"].Value = Convert.ToDateTime(aVendorTable.Rows[RowNum]["StartDate"].ToString()).ToShortDateString();
                            if (aVendorTable != null)
                            {
                                for (int i = 0; i < aVendorAccountTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aVendorTable.Rows[RowNum]["ID"].ToString()) == int.Parse(aVendorAccountTable.Rows[i]["VendorID"].ToString()))
                                    {
                                        ListVendorsDGView.Rows[RowNum].Cells["AccountAmount"].Value = aVendorAccountTable.Rows[i]["Amount"].ToString();
                                    }
                                }
                            }
                            RowNum++;
                        }
                    }
                    PageOfTotalTxtBox.Text = "1/" + pagesnumber.ToString();
                    currentpage = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendorsBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void ListVendorsDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditVendors) == EventStatus.Permit)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataRow aVendorDataRow = VendorsMgmt.SelectVendorRowByName(ListVendorsDGView.Rows[e.RowIndex].Cells["Namecol"].Value.ToString());
                        if (aVendorDataRow == null)
                        {
                            ListVendorsBtn.PerformClick();
                        }
                        else
                        {
                            EditVendor aEditVendor = new EditVendor();
                            aEditVendor.TopMost = true;
                            aEditVendor.UpdateVariables(aVendorDataRow);
                            aEditVendor.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:ListVendorsDGView_CellDoubleClick()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void ListVendors_Load(object sender, EventArgs e)
        {

        }

        private void page(int pagenumber)
        {
            try
            {
                if (ListVendorsDGView.Rows.Count > 0)
                {
                    int dgrow = 0;
                    ListVendorsDGView.Rows.Clear();
                    //TestingFor Paging                
                    for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                    {
                        if (ListVendorsDGView.Rows.Count < ItemsPerPage && RowNum < aVendorTable.Rows.Count)
                        {
                            ListVendorsDGView.Rows.Add();
                            ListVendorsDGView.Rows[dgrow].Cells["Namecol"].Value = aVendorTable.Rows[RowNum]["Name"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["Locationcol"].Value = aVendorTable.Rows[RowNum]["Location"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["Phone1"].Value = aVendorTable.Rows[RowNum]["Phone1"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["Phone2"].Value = aVendorTable.Rows[RowNum]["Phone2"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["Email"].Value = aVendorTable.Rows[RowNum]["Email"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["Company"].Value = aVendorTable.Rows[RowNum]["Company"].ToString();
                            ListVendorsDGView.Rows[dgrow].Cells["StartDate"].Value = Convert.ToDateTime(aVendorTable.Rows[RowNum]["StartDate"].ToString()).ToShortDateString();
                            if (aVendorTable != null)
                            {
                                for (int i = 0; i < aVendorAccountTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aVendorTable.Rows[dgrow]["ID"].ToString()) == int.Parse(aVendorAccountTable.Rows[i]["VendorID"].ToString()))
                                    {
                                        ListVendorsDGView.Rows[dgrow].Cells["AccountAmount"].Value = aVendorAccountTable.Rows[i]["Amount"].ToString();
                                    }
                                }
                            }
                            dgrow++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:page()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:GoToPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:PreviousPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:NextPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void ItemsPerPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                ListVendorsBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aVendorTable != null)
                {
                    if (TestParser > 0 && ListVendorsDGView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage < 100)
                        {
                            pagesnumber = (int)aVendorTable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aVendorTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aVendorTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVendors:ItemsPerPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListVendorsFormName;
                //  this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                // this.RightToLeftLayout = true;
                ItemsPerPageBtn.Text = UiText.LstVndItemsPerPageBtn;
                ItemsPerPageLbl.Text = UiText.LstVndItemsPerPageLbl;
                ListVendorsBtn.Text = UiText.LstVndListVendorsBtn;
                GoToPageBtn.Text = UiText.LstVndNextPageBtn;
                TotalItemsLbl.Text = UiText.LstVndTotalItemsLbl;
                TotalPagesLbl.Text = UiText.LstVndTotalPagesLbl;
                // GoToPageBtn.Text = UiText.LstVndNextPageBtn;//GoToPageBtn.Text = @AYMAN-V01F this was NextPageBtn we need to make it go to page
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

        private void ExportToPdfBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string SaveAsPath = "";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF file|*.pdf";
                saveFileDialog1.Title = "Save Report (A4)";
                saveFileDialog1.FileName = "Vendors List" + DateTime.Now.ToShortDateString();
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"/", "-");
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"\\", "-");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveAsPath = saveFileDialog1.FileName;
                    VendorsReports.Instance.VendorsListReport(false, true, false, SaveAsPath, true, false, true);
                    Process.Start(SaveAsPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
