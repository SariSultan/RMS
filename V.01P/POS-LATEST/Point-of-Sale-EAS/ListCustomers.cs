using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Reports;
using System.IO;
using System.Diagnostics;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class ListCustomers : Form
    {
        int RowNum = 0;
        int pagesnumber;
        int ItemsPerPage = 50;
        int currentpage = 1;
        DataTable aCustomerTable;
        DataTable aCustomerAccountTable;
        public ListCustomers()
        {
            InitializeComponent();
            TranslateUI();
            GotoPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
            ItemsPerPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
        }
        private void ListCustomersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                aCustomerTable = CustomerMgmt.SelectAllCustomers();
                aCustomerAccountTable = CustomersAccountsMgmt.SelectAll();
                if (aCustomerTable != null)
                {
                    //if (aCustomerTable.Rows.Count>1&& aCustomerAccountTable == null)
                    //{
                    //    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomersBtn:DB-ERROR   aCustomerAccountTable=null] \n Exception: \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    TotalITemsTxtBox.Text = aCustomerTable.Rows.Count.ToString();
                    if (aCustomerTable.Rows.Count > 0)
                    {
                        pagesnumber = (int)aCustomerTable.Rows.Count / ItemsPerPage;
                        if ((double.Parse(aCustomerTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aCustomerTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                            pagesnumber++;

                        RowNum = 0;
                        ListCustomersDGView.Rows.Clear();
                        foreach (DataRow r in aCustomerTable.Rows)
                        {
                            if (ListCustomersDGView.Rows.Count < ItemsPerPage)
                            {
                                ListCustomersDGView.Rows.Add();
                                ListCustomersDGView.Rows[RowNum].Cells["Namecol"].Value = aCustomerTable.Rows[RowNum]["Name"].ToString();
                                ListCustomersDGView.Rows[RowNum].Cells["Email"].Value = aCustomerTable.Rows[RowNum]["Email"].ToString();
                                ListCustomersDGView.Rows[RowNum].Cells["Address"].Value = aCustomerTable.Rows[RowNum]["Address"].ToString();
                                ListCustomersDGView.Rows[RowNum].Cells["Phone1"].Value = aCustomerTable.Rows[RowNum]["Phone1"].ToString();
                                if (aCustomerAccountTable != null)
                                {
                                    for (int i = 0; i < aCustomerAccountTable.Rows.Count; i++)
                                    {
                                        if (int.Parse(aCustomerTable.Rows[RowNum]["ID"].ToString()) == int.Parse(aCustomerAccountTable.Rows[i]["CustomerID"].ToString()))
                                        {
                                            ListCustomersDGView.Rows[RowNum].Cells["AccountAmount"].Value = aCustomerAccountTable.Rows[i]["Amount"].ToString();
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
                else
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomersBtn:DB-ERROR  aCustomerTable=null  \n Exception: \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomersBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:GoToPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void page(int pagenumber)
        {
            try
            {
                if (ListCustomersDGView.Rows.Count > 0)
                {
                    int dgrow = 0;
                    ListCustomersDGView.Rows.Clear();
                    //TestingFor Paging                
                    for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                    {
                        if (ListCustomersDGView.Rows.Count < ItemsPerPage && RowNum < aCustomerTable.Rows.Count)
                        {
                            ListCustomersDGView.Rows.Add();
                            ListCustomersDGView.Rows[dgrow].Cells["Namecol"].Value = aCustomerTable.Rows[RowNum]["Name"].ToString();
                            ListCustomersDGView.Rows[dgrow].Cells["Email"].Value = aCustomerTable.Rows[RowNum]["Email"].ToString();
                            ListCustomersDGView.Rows[dgrow].Cells["Address"].Value = aCustomerTable.Rows[RowNum]["Address"].ToString();
                            ListCustomersDGView.Rows[dgrow].Cells["Phone1"].Value = aCustomerTable.Rows[RowNum]["Phone1"].ToString();
                            if (aCustomerAccountTable != null)
                            {
                                for (int i = 0; i < aCustomerAccountTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aCustomerTable.Rows[dgrow]["ID"].ToString()) == int.Parse(aCustomerAccountTable.Rows[i]["CustomerID"].ToString()))
                                    {
                                        ListCustomersDGView.Rows[dgrow].Cells["AccountAmount"].Value = aCustomerAccountTable.Rows[i]["Amount"].ToString();
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:page()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:PreviousPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:NextPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ItemsPerPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                ListCustomersBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aCustomerTable != null)
                {
                    if (TestParser > 0 && ListCustomersDGView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage <= 100)
                        {
                            pagesnumber = (int)aCustomerTable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aCustomerTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aCustomerTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:ItemsPerPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void ListCustomersDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow aCustomerRowToPass = CustomerMgmt.SelectCustomerRowByID(int.Parse(aCustomerTable.Rows[e.RowIndex]["ID"].ToString()));
                if (aCustomerRowToPass != null)
                {
                    EditCustomer aEditCustomer = new EditCustomer();
                    //  aEditCustomer.MdiParent = Helper.Instance.ActiveMainWindow;
                    aEditCustomer.Show();
                    aEditCustomer.UpdateVariables(aCustomerRowToPass);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListCustomers:ListCustomersDGView_CellDoubleClick()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListCustomersFormName;
                //  this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                // this.RightToLeftLayout = true;
                ItemsPerPageBtn.Text = UiText.LstCstItemsPerPageBtn;
                ItemsPerPageLbl.Text = UiText.LstCstItemsPerPageLbl;
                ListCustomersBtn.Text = UiText.LstCstListCustomersBtn;
                ListCustomersLbl.Text = UiText.LstCstListCustomersLbl;
                //GoToPageBtn.Text = UiText.; //GoToPageBtn.Text = @AYMAN-V01F this was NextPageBtn we need to make it go to page
                TotalItemsLbl.Text = UiText.LstCstTotalItemsLbl;
                TotalPagesLbl.Text = UiText.LstCstTotalPagesLbl;
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

        private void GotoPageTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                GoToPageBtn.PerformClick();
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
                saveFileDialog1.FileName = "Customers List" + DateTime.Now.ToShortDateString();
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"/", "-");
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"\\", "-");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveAsPath = saveFileDialog1.FileName;
                    CustomersReports.Instance.CustomerListReport(false, true, false, SaveAsPath, true, false, true);
                    Process.Start(SaveAsPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsPerPageTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (e.KeyChar == (int)Keys.Return)
            {
                ItemsPerPageBtn.PerformClick();
            }        
        }

      

    }
}
