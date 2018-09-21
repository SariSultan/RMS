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
    public partial class ListVouchers : Form
    {
        int RowNum = 0;
        int pagesnumber;
        int ItemsPerPage = 50;
        int currentpage = 1;

        DataTable aVendorTable;
        DataTable aCurrencyTable;
        DataTable aUsersTable;
        DataTable aAccountsTable;
        DataTable aPaymentMethodTable;
        DataTable aVouchersTable;

        public ListVouchers()
        {
            InitializeComponent();
            TranslateUI();
        }

        private void ListVouchersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int FilterVendorID = -1;
                if (ByVendorNameChkBox.Checked && VendorsComboBox.SelectedValue != null)
                {
                    FilterVendorID = int.Parse(VendorsComboBox.SelectedValue.ToString());//VendorsMgmt.SelectVendorIDByName(VendorNameTxtBox.Text);
                    // CustomerMgmt.SelectCustomerIDByPhone1(CustomerPhoneTxtBox.Text);
                    if (FilterVendorID == -1)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + " " + MsgTxt.VendorTxt + " " + VendorsComboBox.Text + " " + MsgTxt.NotFoundTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                aVendorTable = VendorsMgmt.SelectAllVendors();
                if (aVendorTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVouchersBtn_Click:DB-ERROR  aVendorTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                aCurrencyTable = CurrencyMgmt.SelectAll();
                if (aCurrencyTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [aCurrencyTable:DB-ERROR  aCurrencyTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                aUsersTable = UsersMgmt.SelectAllUsers();
                if (aUsersTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [aUsersTable:DB-ERROR  aUsersTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                aAccountsTable = AccountsMgmt.SelectAll();
                if (aAccountsTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [aAccountsTable:DB-ERROR  aAccountsTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                aPaymentMethodTable = PaymentMethodMgmt.SelectAll();
                if (aPaymentMethodTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [aPaymentMethodTable:DB-ERROR  aPaymentMethodTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //aVouchersTable = PurchaseVoucherGeneralMgmt.SelectAllVouchers();



                int FilterTellerID = 0;
                if (TellerNameChkBox.Checked && TellerNameComboBox.SelectedValue != null)
                {
                    FilterTellerID = int.Parse(TellerNameComboBox.SelectedValue.ToString());
                }

                string FilterDateFrom = "";
                string FilterDateTo = "";
                if (DateCheckBox.Checked)
                {
                    FilterDateFrom = DateFrompicker.Value.ToShortDateString();
                    FilterDateTo = DateToPicker.Value.ToShortDateString();
                }

                bool FilterChecked = CheckedChkBox.Checked;
                bool FilterRevised = IsRevisedChkBox.Checked;

                bool FilterUnChecked = UncheckedVouchersChkBox.Checked;
                bool FilterUnRevised = UnRevisedChkBox.Checked;

                aVouchersTable = PurchaseVoucherGeneralMgmt.SelectAllVouchers(FilterTellerID, FilterDateFrom, FilterDateTo, FilterChecked, FilterRevised, FilterUnChecked, FilterUnRevised, FilterVendorID, false);
                if (aVouchersTable == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [aVouchersTable:DB-ERROR  aVouchersTable=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TotalITemsTxtBox.Text = aVouchersTable.Rows.Count.ToString();
                ListVouchersDGView.Rows.Clear();
                if (aVouchersTable.Rows.Count > 0)
                {
                    RowNum = 0;
                    if (ListVouchersDGView.Rows.Count < ItemsPerPage)
                    {
                        //TestingFor Paging
                        pagesnumber = (int)aVouchersTable.Rows.Count / ItemsPerPage;
                        if ((double.Parse(aVouchersTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aVouchersTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
                            pagesnumber++;
                        foreach (DataRow r in aVouchersTable.Rows)
                        {
                            if (ListVouchersDGView.Rows.Count < ItemsPerPage)
                            {
                                ListVouchersDGView.Rows.Add();
                                ListVouchersDGView.Rows[RowNum].Cells["VoucherNumber"].Value = aVouchersTable.Rows[RowNum]["VoucherNumber"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["Date"].Value = aVouchersTable.Rows[RowNum]["Date"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["Time"].Value = aVouchersTable.Rows[RowNum]["Time"].ToString();
                                for (int i = 0; i < aVendorTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["VendorID"].ToString()))
                                    {
                                        ListVouchersDGView.Rows[RowNum].Cells["Vendor"].Value = aVendorTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                ListVouchersDGView.Rows[RowNum].Cells["TotalFreeITemsQty"].Value = aVouchersTable.Rows[RowNum]["TotalFreeITemsQty"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["TotalTax"].Value = aVouchersTable.Rows[RowNum]["TotalTax"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["Subtotal"].Value = aVouchersTable.Rows[RowNum]["Subtotal"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["DiscountPerc"].Value = aVouchersTable.Rows[RowNum]["DiscountPerc"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["TotalItemsDiscount"].Value = aVouchersTable.Rows[RowNum]["TotalItemsDiscount"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["TotalDiscount"].Value = aVouchersTable.Rows[RowNum]["TotalDiscount"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["TotalCost"].Value = aVouchersTable.Rows[RowNum]["TotalCost"].ToString();
                                for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["PaymentMethodID"].ToString()))
                                    {
                                        ListVouchersDGView.Rows[RowNum].Cells["PaymentMethod"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                ListVouchersDGView.Rows[RowNum].Cells["Comments"].Value = aVouchersTable.Rows[RowNum]["Comments"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["CreditCardInfo"].Value = aVouchersTable.Rows[RowNum]["CreditCardInfo"].ToString();
                                for (int i = 0; i < aCurrencyTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aCurrencyTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["CurrencyID"].ToString()))
                                    {
                                        ListVouchersDGView.Rows[RowNum].Cells["Currency"].Value = aCurrencyTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                for (int i = 0; i < aAccountsTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aAccountsTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["AccountID"].ToString()))
                                    {
                                        ListVouchersDGView.Rows[RowNum].Cells["Currency"].Value = aAccountsTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                for (int i = 0; i < aUsersTable.Rows.Count; i++)
                                {
                                    if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["TellerID"].ToString()))
                                    {
                                        ListVouchersDGView.Rows[RowNum].Cells["Teller"].Value = aUsersTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                        break;
                                    }
                                }
                                ListVouchersDGView.Rows[RowNum].Cells["CheckNumber"].Value = aVouchersTable.Rows[RowNum]["CheckNumber"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["IsCashCredit"].Value = aVouchersTable.Rows[RowNum]["IsCashCredit"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["VendorAccountAmountOld"].Value = aVouchersTable.Rows[RowNum]["VendorAccountAmountOld"].ToString();
                                if (aVouchersTable.Rows[RowNum]["IsChecked"].ToString() == "0")
                                {
                                    ListVouchersDGView.Rows[RowNum].Cells["IsChecked"].Value = "NO";//aBillTable.Rows[RowNum]["IsChecked"].ToString();
                                }
                                else
                                {
                                    ListVouchersDGView.Rows[RowNum].Cells["IsChecked"].Value = "YES";
                                }
                                ListVouchersDGView.Rows[RowNum].Cells["CheckedBy"].Value = aVouchersTable.Rows[RowNum]["CheckedBy"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["CheckDate"].Value = aVouchersTable.Rows[RowNum]["CheckDate"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["CheckTime"].Value = aVouchersTable.Rows[RowNum]["CheckTime"].ToString();
                                if (aVouchersTable.Rows[RowNum]["IsRevised"].ToString() == "0")
                                {
                                    ListVouchersDGView.Rows[RowNum].Cells["IsRevised"].Value = "NO";//aBillTable.Rows[RowNum]["IsChecked"].ToString();
                                }
                                else
                                {
                                    ListVouchersDGView.Rows[RowNum].Cells["IsRevised"].Value = "YES";
                                }
                                ListVouchersDGView.Rows[RowNum].Cells["RevisedBy"].Value = aVouchersTable.Rows[RowNum]["RevisedBy"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["ReviseDate"].Value = aVouchersTable.Rows[RowNum]["ReviseDate"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["ReviseTime"].Value = aVouchersTable.Rows[RowNum]["ReviseTime"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["ReviseLoss"].Value = aVouchersTable.Rows[RowNum]["ReviseLoss"].ToString();
                                ListVouchersDGView.Rows[RowNum].Cells["Fees"].Value = aVouchersTable.Rows[RowNum]["Fees"].ToString();
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVouchersBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void ListVouchersDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditVouchers) == EventStatus.Permit)
            {
                if (e.RowIndex < 0)
                    return;

                DataTable aDataTableToPass = PurchaseVoucherDetailedMgmt.SelectVoucherByVoucherNumber(int.Parse(ListVouchersDGView.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString()));
                if (aDataTableToPass==null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVouchersDGView_CellDoubleClick:DB-ERROR  aDataTableToPass=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
               

                DataRow aGeneralVoucherDataRow = PurchaseVoucherGeneralMgmt.SelectGeneralVoucherByNumber(int.Parse(ListVouchersDGView.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString()));
                if (aDataTableToPass == null)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListVouchersDGView_CellDoubleClick:DB-ERROR  aDataTableToPass=null] \n  \n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                EditVoucher aEditVoucher = new EditVoucher();
                aEditVoucher.AddDGView(aDataTableToPass);
                aEditVoucher.UpdateVariables(aGeneralVoucherDataRow);
                //aEditVoucher.TopLevel = true;
                aEditVoucher.TopMost = true;
                aEditVoucher.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListVouchers_Load(object sender, EventArgs e)
        {
            try
            {


                // TODO: This line of code loads data into the 'dBDataSet.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
                // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.dBDataSet.Users);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[ListVouchers_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        //Filters functions

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
        private void VendorNameChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ByVendorNameChkBox.Checked == true)
            {
                VendorsComboBox.Enabled = true;
            }
            else
            {
                VendorsComboBox.Enabled = false;
            }
        }
        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DateFrompicker.Enabled = DateCheckBox.Checked;
            DateToPicker.Enabled = DateCheckBox.Checked;
        }

        //Paging Functions
        private void page(int pagenumber)
        {

            if (ListVouchersDGView.Rows.Count > 0)
            {
                int dgrow = 0;
                ListVouchersDGView.Rows.Clear();
                //TestingFor Paging                
                for (RowNum = (pagenumber - 1) * ItemsPerPage; RowNum < (pagenumber - 1) * ItemsPerPage + (ItemsPerPage); RowNum++)
                {
                    if (ListVouchersDGView.Rows.Count < ItemsPerPage && RowNum < aVouchersTable.Rows.Count)
                    {

                        ListVouchersDGView.Rows.Add();
                        ListVouchersDGView.Rows[dgrow].Cells["VoucherNumber"].Value = aVouchersTable.Rows[RowNum]["VoucherNumber"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["Date"].Value = aVouchersTable.Rows[RowNum]["Date"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["Time"].Value = aVouchersTable.Rows[RowNum]["Time"].ToString();
                        for (int i = 0; i < aVendorTable.Rows.Count; i++)
                        {
                            if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["VendorID"].ToString()))
                            {
                                ListVouchersDGView.Rows[dgrow].Cells["Vendor"].Value = aVendorTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        ListVouchersDGView.Rows[dgrow].Cells["TotalFreeITemsQty"].Value = aVouchersTable.Rows[RowNum]["TotalFreeITemsQty"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["TotalTax"].Value = aVouchersTable.Rows[RowNum]["TotalTax"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["Subtotal"].Value = aVouchersTable.Rows[RowNum]["Subtotal"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["DiscountPerc"].Value = aVouchersTable.Rows[RowNum]["DiscountPerc"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["TotalItemsDiscount"].Value = aVouchersTable.Rows[RowNum]["TotalItemsDiscount"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["TotalDiscount"].Value = aVouchersTable.Rows[RowNum]["TotalDiscount"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["TotalCost"].Value = aVouchersTable.Rows[RowNum]["TotalCost"].ToString();
                        for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                        {
                            if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["PaymentMethodID"].ToString()))
                            {
                                ListVouchersDGView.Rows[dgrow].Cells["PaymentMethod"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        ListVouchersDGView.Rows[dgrow].Cells["Comments"].Value = aVouchersTable.Rows[RowNum]["Comments"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["CreditCardInfo"].Value = aVouchersTable.Rows[RowNum]["CreditCardInfo"].ToString();
                        for (int i = 0; i < aCurrencyTable.Rows.Count; i++)
                        {
                            if (int.Parse(aCurrencyTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["CurrencyID"].ToString()))
                            {
                                ListVouchersDGView.Rows[dgrow].Cells["Currency"].Value = aCurrencyTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        for (int i = 0; i < aAccountsTable.Rows.Count; i++)
                        {
                            if (int.Parse(aAccountsTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["AccountID"].ToString()))
                            {
                                ListVouchersDGView.Rows[dgrow].Cells["Currency"].Value = aAccountsTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        for (int i = 0; i < aUsersTable.Rows.Count; i++)
                        {
                            if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aVouchersTable.Rows[RowNum]["TellerID"].ToString()))
                            {
                                ListVouchersDGView.Rows[dgrow].Cells["Teller"].Value = aUsersTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        ListVouchersDGView.Rows[dgrow].Cells["CheckNumber"].Value = aVouchersTable.Rows[RowNum]["CheckNumber"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["IsCashCredit"].Value = aVouchersTable.Rows[RowNum]["IsCashCredit"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["VendorAccountAmountOld"].Value = aVouchersTable.Rows[RowNum]["VendorAccountAmountOld"].ToString();
                        if (aVouchersTable.Rows[RowNum]["IsChecked"].ToString() == "0")
                        {
                            ListVouchersDGView.Rows[dgrow].Cells["IsChecked"].Value = "NO";//aBillTable.Rows[RowNum]["IsChecked"].ToString();
                        }
                        else
                        {
                            ListVouchersDGView.Rows[dgrow].Cells["IsChecked"].Value = "YES";
                        }
                        ListVouchersDGView.Rows[dgrow].Cells["CheckedBy"].Value = aVouchersTable.Rows[RowNum]["CheckedBy"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["CheckDate"].Value = aVouchersTable.Rows[RowNum]["CheckDate"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["CheckTime"].Value = aVouchersTable.Rows[RowNum]["CheckTime"].ToString();
                        if (aVouchersTable.Rows[RowNum]["IsRevised"].ToString() == "0")
                        {
                            ListVouchersDGView.Rows[dgrow].Cells["IsRevised"].Value = "NO";//aBillTable.Rows[RowNum]["IsChecked"].ToString();
                        }
                        else
                        {
                            ListVouchersDGView.Rows[dgrow].Cells["IsRevised"].Value = "YES";
                        }
                        ListVouchersDGView.Rows[dgrow].Cells["RevisedBy"].Value = aVouchersTable.Rows[RowNum]["RevisedBy"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["ReviseDate"].Value = aVouchersTable.Rows[RowNum]["ReviseDate"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["ReviseTime"].Value = aVouchersTable.Rows[RowNum]["ReviseTime"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["ReviseLoss"].Value = aVouchersTable.Rows[RowNum]["ReviseLoss"].ToString();
                        ListVouchersDGView.Rows[dgrow].Cells["Fees"].Value = aVouchersTable.Rows[RowNum]["Fees"].ToString();



                        dgrow++;
                    }
                }

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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:PreviousPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ListBills:NextPage_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
        private void ItemsPerPageBtn_Click(object sender, EventArgs e)
        {
            // StartTime = DateTime.Now;
            try
            {
                int TestParser;
                ListVouchersBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBox.Text, out TestParser) && aVouchersTable != null)
                {
                    if (TestParser > 0 && ListVouchersDGView.Rows.Count > 0)
                    {
                        ItemsPerPage = TestParser;
                        if (ItemsPerPage < 100)
                        {
                            pagesnumber = (int)aVouchersTable.Rows.Count / ItemsPerPage;
                            if ((double.Parse(aVouchersTable.Rows.Count.ToString()) / ItemsPerPage - int.Parse(aVouchersTable.Rows.Count.ToString()) / ItemsPerPage) > 0)
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
                throw;
            }
            /* TimeSpan ts = DateTime.Now.Subtract(StartTime);
             string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                     ts.Hours, ts.Minutes, ts.Seconds,
                     ts.Milliseconds / 10);
             MessageBox.Show("Time=" + elapsedTime);*/
        }


        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ListVouchersFormName;
                // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //// this.RightToLeftLayout = true;
                ByVendorNameChkBox.Text = UiText.LstVchByVendorNameChkBox;
                CheckedChkBox.Text = UiText.LstVchCheckedChkBox;
                DateCheckBox.Text = UiText.LstVchDateCheckBox;
                FiltersGB.Text = UiText.LstVchFiltersGB;
                IsRevisedChkBox.Text = UiText.LstVchIsRevisedChkBox;
                ItemsPerPageBtn.Text = UiText.LstVchItemsPerPageBtn;
                ItemsPerPageLbl.Text = UiText.LstVchItemsPerPageLbl;
                ListVouchersBtn.Text = UiText.LstVchListVouchersBtn;
                ListVouchersLbl.Text = UiText.LstVchListVouchersLbl;
                //GoToPageBtn.Text = UiText.LstVchNextPageBtn;  @AYMAN-V01F this was NextPageBtn we need to make it go to page
                TellerNameChkBox.Text = UiText.LstVchTellerNameChkBox;
                TotalItemsLbl.Text = UiText.LstVchTotalItemsLbl;
                TotalPagesLbl.Text = UiText.LstVchTotalPagesLbl;
                UncheckedVouchersChkBox.Text = UiText.LstVchUncheckedVouchersChkBox;
                UnRevisedChkBox.Text = UiText.LstVchUnRevisedChkBox;
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
