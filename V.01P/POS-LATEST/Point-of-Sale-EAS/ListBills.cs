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

namespace Calcium_RMS
{
    public partial class ListBills : Form
    {
        int RowNum = 0;
        int pagesnumber;
        int ItemsPerPage = 50;
        int currentpage = 1;
        DataTable aBillTable;
        DataTable aCustomerTable;
        DataTable aCurrencyTable;
        DataTable aUsersTable;
        DataTable aAccountsTable;
        DataTable aPriceLevelTable;
        DataTable aPaymentMethodTable;

        DateTime StartTime;

        public ListBills()
        {
            InitializeComponent();
            TranslateUI();
            GotoPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
            ItemsPerPageTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
        }
        private void ListBills_Load(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.Fill(this.dBDataSet.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[ListBills_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void ListBillsBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int FilterCustomerID = -1;
                if (CustomerNameChkBox.Checked)
                {
                    FilterCustomerID = CustomerMgmt.SelectCustomerIDByPhone1(CustomerPhoneTxtBox.Text);
                    if (FilterCustomerID == -1)
                    {
                        MessageBox.Show("Customer Not Found");
                    }
                }

                aCustomerTable = CustomerMgmt.SelectAllCustomers();
                aCurrencyTable = CurrencyMgmt.SelectAll();
                aUsersTable = UsersMgmt.SelectAllUsers();
                aAccountsTable = AccountsMgmt.SelectAll();
                aPriceLevelTable = PriceLevelsMgmt.SelectAll();
                aPaymentMethodTable = PaymentMethodMgmt.SelectAll();

                ListBillsDGView.Rows.Clear();
                int FilterTellerNameID = 0;
                if (TellerNameChkBox.Checked && TellerNameComboBox.SelectedValue != null)
                {
                    FilterTellerNameID = int.Parse(TellerNameComboBox.SelectedValue.ToString());
                }

                string FilterDateFrom = "";
                string FilterDateTo = "";
                if (DateCheckBox.Checked)
                {
                    FilterDateFrom = DateFrompicker.Value.ToShortDateString();
                    FilterDateTo = DateToPicker.Value.ToShortDateString();
                }

                bool FilterCheckedBills = CkeckedBillsChkBox.Checked;
                bool FilterIsRevised = IsRevisedChkBox.Checked;

                bool FilterUnCheckedBills = UncheckedBillChkBox.Checked;
                bool FilterUnRevisedBills = UnRevisedChkBox.Checked;
                bool FilterCashCreditBills = CreditBillsChkBox.Checked;

                aBillTable = BillGeneralMgmt.SelectAllBills(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterCustomerID, FilterCashCreditBills);
                if (aBillTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBillsBtn_Click:DB-ERROR  aBillTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TotalITemsTxtBox.Text = aBillTable.Rows.Count.ToString();

                if (aBillTable.Rows.Count > 0)
                {
                    RowNum = 0;
                    if (ListBillsDGView.Rows.Count < ItemsPerPage)
                    {
                        //TestingFor Paging
                        pagesnumber = (int)aBillTable.Rows.Count / ItemsPerPage;
                        if ((double.Parse(aBillTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aBillTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                            pagesnumber++;
                        foreach (DataRow r in aBillTable.Rows)
                        {
                            if (ListBillsDGView.Rows.Count < ItemsPerPage)
                            {
                                ListBillsDGView.Rows.Add();
                                ListBillsDGView.Rows[RowNum].Cells["Number"].Value = aBillTable.Rows[RowNum]["Number"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["Date"].Value = aBillTable.Rows[RowNum]["Date"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["BillTime"].Value = aBillTable.Rows[RowNum]["BillTime"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["TotalItems"].Value = aBillTable.Rows[RowNum]["TotalItems"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["TotalTax"].Value = aBillTable.Rows[RowNum]["TotalTax"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["TotalPrice"].Value = aBillTable.Rows[RowNum]["TotalPrice"].ToString();
                                for (int i = 0; i < aUsersTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["TellerID"].ToString()))
                                    {
                                        ListBillsDGView.Rows[RowNum].Cells["TellerID"].Value = aUsersTable.Rows[i]["UserName"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["CustomerID"].ToString()))
                                    {
                                        ListBillsDGView.Rows[RowNum].Cells["CustomerID"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                        break;
                                    }
                                }
                                for (int i = 0; i < aPriceLevelTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aPriceLevelTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["PriceLevelID"].ToString()))
                                    {
                                        ListBillsDGView.Rows[RowNum].Cells["PriceLevelID"].Value = aPriceLevelTable.Rows[i]["Name"].ToString();
                                        break;
                                    }
                                }

                                for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["PaymentMethodID"].ToString()))
                                    {
                                        ListBillsDGView.Rows[RowNum].Cells["PaymentMethodID"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();
                                        break;
                                    }
                                }
                                ListBillsDGView.Rows[RowNum].Cells["TotalCost"].Value = aBillTable.Rows[RowNum]["TotalCost"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["Comments"].Value = aBillTable.Rows[RowNum]["Comments"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["SalesDiscount"].Value = aBillTable.Rows[RowNum]["SalesDiscount"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["DiscountPerc"].Value = aBillTable.Rows[RowNum]["DiscountPerc"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["CashIn"].Value = aBillTable.Rows[RowNum]["CashIn"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["TotalDiscount"].Value = aBillTable.Rows[RowNum]["TotalDiscount"].ToString();

                                if (aBillTable.Rows[RowNum]["IsChecked"].ToString() == "0")
                                {
                                    ListBillsDGView.Rows[RowNum].Cells["IsChecked"].Value = UiText.NoTxt;
                                }
                                else
                                {
                                    ListBillsDGView.Rows[RowNum].Cells["IsChecked"].Value = UiText.YesTxt;
                                }

                                if (aBillTable.Rows[RowNum]["IsRevised"].ToString() == "0")
                                {
                                    ListBillsDGView.Rows[RowNum].Cells["IsRevised"].Value = UiText.NoTxt;
                                }
                                else
                                {
                                    ListBillsDGView.Rows[RowNum].Cells["IsRevised"].Value = UiText.YesTxt;
                                }
                                ListBillsDGView.Rows[RowNum].Cells["CheckedDate"].Value = aBillTable.Rows[RowNum]["CheckedDate"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["CheckedBy"].Value = aBillTable.Rows[RowNum]["CheckedBy"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["ReviseDate"].Value = aBillTable.Rows[RowNum]["ReviseDate"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["RevisedBy"].Value = aBillTable.Rows[RowNum]["RevisedBy"].ToString();
                                ListBillsDGView.Rows[RowNum].Cells["ReviseLoss"].Value = aBillTable.Rows[RowNum]["ReviseLoss"].ToString();
                                RowNum++;
                            }
                        }
                        PageOfTotalTxtBox.Text = "1/" + pagesnumber.ToString();
                        currentpage = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBillsBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void page(int pagenumber)
        {
            try
            {
                if (ListBillsDGView.Rows.Count > 0)
                {
                    int dgrow = 0;
                    ListBillsDGView.Rows.Clear();
                    //TestingFor Paging                
                    for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                    {
                        if (ListBillsDGView.Rows.Count < ItemsPerPage && RowNum < aBillTable.Rows.Count)
                        {
                            ListBillsDGView.Rows.Add();
                            ListBillsDGView.Rows[dgrow].Cells["Number"].Value = aBillTable.Rows[RowNum]["Number"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["Date"].Value = aBillTable.Rows[RowNum]["Date"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["BillTime"].Value = aBillTable.Rows[RowNum]["BillTime"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["TotalItems"].Value = aBillTable.Rows[RowNum]["TotalItems"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["TotalTax"].Value = aBillTable.Rows[RowNum]["TotalTax"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["TotalPrice"].Value = aBillTable.Rows[RowNum]["TotalPrice"].ToString();
                            for (int i = 0; i < aUsersTable.Rows.Count; i++)
                            {
                                if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["TellerID"].ToString()))
                                {
                                    ListBillsDGView.Rows[dgrow].Cells["TellerID"].Value = aUsersTable.Rows[i]["UserName"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                            {
                                if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["CustomerID"].ToString()))
                                {
                                    ListBillsDGView.Rows[dgrow].Cells["CustomerID"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < aPriceLevelTable.Rows.Count; i++)
                            {
                                if (int.Parse(aPriceLevelTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["PriceLevelID"].ToString()))
                                {
                                    ListBillsDGView.Rows[dgrow].Cells["PriceLevelID"].Value = aPriceLevelTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }

                            for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                            {
                                if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aBillTable.Rows[RowNum]["PaymentMethodID"].ToString()))
                                {
                                    ListBillsDGView.Rows[dgrow].Cells["PaymentMethodID"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            ListBillsDGView.Rows[dgrow].Cells["TotalCost"].Value = aBillTable.Rows[RowNum]["TotalCost"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["Comments"].Value = aBillTable.Rows[RowNum]["Comments"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["SalesDiscount"].Value = aBillTable.Rows[RowNum]["SalesDiscount"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["DiscountPerc"].Value = aBillTable.Rows[RowNum]["DiscountPerc"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["CashIn"].Value = aBillTable.Rows[RowNum]["CashIn"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["TotalDiscount"].Value = aBillTable.Rows[RowNum]["TotalDiscount"].ToString();

                            if (aBillTable.Rows[RowNum]["IsChecked"].ToString() == "0")
                            {
                                ListBillsDGView.Rows[dgrow].Cells["IsChecked"].Value = UiText.NoTxt;//aBillTable.Rows[RowNum]["IsChecked"].ToString();
                            }
                            else
                            {
                                ListBillsDGView.Rows[dgrow].Cells["IsChecked"].Value = UiText.YesTxt;
                            }

                            if (aBillTable.Rows[RowNum]["IsRevised"].ToString() == "0")
                            {
                                ListBillsDGView.Rows[dgrow].Cells["IsRevised"].Value = UiText.NoTxt;//aBillTable.Rows[RowNum]["IsRevised"].ToString();
                            }
                            else
                            {
                                ListBillsDGView.Rows[dgrow].Cells["IsRevised"].Value = UiText.YesTxt;
                            }
                            ListBillsDGView.Rows[dgrow].Cells["CheckedDate"].Value = aBillTable.Rows[RowNum]["CheckedDate"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["CheckedBy"].Value = aBillTable.Rows[RowNum]["CheckedBy"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["ReviseDate"].Value = aBillTable.Rows[RowNum]["ReviseDate"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["RevisedBy"].Value = aBillTable.Rows[RowNum]["RevisedBy"].ToString();
                            ListBillsDGView.Rows[dgrow].Cells["ReviseLoss"].Value = aBillTable.Rows[RowNum]["ReviseLoss"].ToString();
                            dgrow++;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:page()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:GoToPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:PreviousPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:NextPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }
        private void ItemsPerPageBtn_Click(object sender, EventArgs e)
        {
            // StartTime = DateTime.Now;
            try
            {
                int TestParser;
                ListBillsBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aBillTable != null)
                {
                    if (TestParser > 0 && ListBillsDGView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage < 100)
                        {
                            pagesnumber = (int)aBillTable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aBillTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aBillTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:ItemsPerPageBtn_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            /* TimeSpan ts = DateTime.Now.Subtract(StartTime);
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds / 10);
             MessageBox.Show("Time=" + elapsedTime);*/
        }

        private void TellerNameChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TellerNameChkBox.Checked == true)
            {
                TellerNameComboBox.Enabled = true;
            }
            else
            {
                TellerNameComboBox.Enabled = false;
            }
        }
        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DateFrompicker.Enabled = DateCheckBox.Checked;
            DateToPicker.Enabled = DateCheckBox.Checked;
        }
        private void CustomerNameChkBox_CheckedChanged(object sender, EventArgs e)
        {
            CustomerPhoneTxtBox.Enabled = CustomerNameChkBox.Checked;
        }
        private void ListBillsDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditBills) == EventStatus.Permit)
                {
                    if (e.RowIndex < 0)
                    {
                        return;
                    }
                    else
                    {
                        DataTable aDataTableToPass = BillDetailedMgmt.SelectBillByBillNumber(int.Parse(ListBillsDGView.Rows[e.RowIndex].Cells["Number"].Value.ToString()));
                        if (aDataTableToPass != null)
                        {
                            EditBill aEditBill = new EditBill();
                            //  aEditBill.Parent = Helper.Instance.ActiveMainWindow;
                            aEditBill.AddDgView(aDataTableToPass);
                            DataRow aGeneralBillDataRow = BillGeneralMgmt.SelectBillByNumber(int.Parse(ListBillsDGView.Rows[e.RowIndex].Cells["Number"].Value.ToString()));
                            if (aGeneralBillDataRow != null)
                            {
                                aEditBill.UpdateVariables(aGeneralBillDataRow);
                                aEditBill.Dock = DockStyle.Fill;
                                aEditBill.Show();
                            }
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:ListBillsDGView_CellDoubleClick()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListBillsFormName;
                CkeckedBillsChkBox.Text = UiText.LstBllCkeckedBillsChkBox;
                CreditBillsChkBox.Text = UiText.LstBllCreditBillsChkBox;
                CustomerNameChkBox.Text = UiText.LstBllCustomerNameChkBox;
                DateCheckBox.Text = UiText.LstBllDateCheckBox;
                DateFromLbl.Text = UiText.LstBllDateFromLbl;
                DateToLbl.Text = UiText.LstBllDateToLbl;
                FiltersGB.Text = UiText.LstBllFiltersGB;
                IsRevisedChkBox.Text = UiText.LstBllIsRevisedChkBox;
                ItemsPerPageBtn.Text = UiText.LstBllItemsPerPageBtn;
                ItemsPerPageLbl.Text = UiText.LstBllItemsPerPageLbl;
                ListBillsBtn.Text = UiText.LstBllListBillsBtn;
                ListVouchersLbl.Text = UiText.LstBllListVouchersLbl;
                //GoToPageBtn.Text = @AYMAN-V01F this was NextPageBtn we need to make it go to page
                TellerNameChkBox.Text = UiText.LstBllTellerNameChkBox;
                TotalItemsLbl.Text = UiText.LstBllTotalItemsLbl;
                TotalPagesLbl.Text = UiText.LstBllTotalPagesLbl;
                UncheckedBillChkBox.Text = UiText.LstBllUncheckedBillChkBox;
                UnRevisedChkBox.Text = UiText.LstBllUnRevisedChkBox;
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

    }
}
