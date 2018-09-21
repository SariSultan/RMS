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
namespace Calcium_RMS
{
    public partial class CustomerDebitCredit : Form
    {
        int RowNumCredit = 0;
        Int64 pagesnumberCredit;
        int ItemsPerPageCredit = 10;
        int currentpageCredit = 1;

        bool semaphore = false;
        int CustomerID3 = 1;

        int RowNumDebit = 0;
        int pagesnumberDebit;
        int ItemsPerPageDebit = 10;
        int currentpageDebit = 1;

        bool CustomerDoNotHaveAccount = true;
        double Balance = 0;
        int CustomerID2 = 0;

        DataRow aCustomerRow = null;
        DataRow aCusomerAccountRow = null;

        DataTable aBillsDataTable = null;
        DataTable aCusPaymentDataTable = null;
        DataTable aCusReturnDataTable = null;
        DataTable aTotalCreditDataTable = null;

        DataTable aCustomerTable;
        DataTable aCurrencyTable;
        DataTable aUsersTable;
        DataTable aAccountsTable;
        DataTable aPriceLevelTable;
        DataTable aPaymentMethodTable;

        public CustomerDebitCredit()
        {
            InitializeComponent();
            //   TranslateUI();
        }

        private void ListDCBtn_Click(object sender, EventArgs e)
        {
            #region Initializing Options
            DebitDGView.SuspendDrawing();
            DebitDGView.SuspendLayout();
            int FilterCustomerID = CustomerMgmt.SelectCustomerIDByPhone1(CustomerPhoneTxtBox.Text);

            aCustomerTable = CustomerMgmt.SelectAllCustomers();
            aCurrencyTable = CurrencyMgmt.SelectAll();
            aUsersTable = UsersMgmt.SelectAllUsers();
            aAccountsTable = AccountsMgmt.SelectAll();
            aPriceLevelTable = PriceLevelsMgmt.SelectAll();
            aPaymentMethodTable = PaymentMethodMgmt.SelectAll();

            DebitDGView.Rows.Clear();
            CreditDGView.Rows.Clear();

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

            bool FilterCheckedBills = CheckChkBox.Checked;
            bool FilterIsRevised = RevisedChkBox.Checked;

            bool FilterUnCheckedBills = UnCheckedChkBox.Checked;
            bool FilterUnRevisedBills = UnRevisedChkBox.Checked;
            bool FilterBillCashCredit = CreditBillsChkBox.Checked;
            #endregion Initializing Options

            #region Listing Debit
            aBillsDataTable = BillGeneralMgmt.SelectAllBills(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterCustomerID, FilterBillCashCredit);
            TotalITemsTxtBoxDebit.Text = aBillsDataTable.Rows.Count.ToString();
            TotalDebitPriceTxtBox.Text = "0";
            if (aBillsDataTable.Rows.Count > 0)
            {
                double TotalDebitPrice = 0;               
                RowNumDebit = 0;
                if (DebitDGView.Rows.Count < ItemsPerPageDebit)
                {
                    //TestingFor Paging
                    pagesnumberDebit = (int)aBillsDataTable.Rows.Count / ItemsPerPageDebit;
                    if ((double.Parse(aBillsDataTable.Rows.Count.ToString()) / ItemsPerPageDebit - int.Parse(aBillsDataTable.Rows.Count.ToString()) / ItemsPerPageDebit) > 0)
                        pagesnumberDebit++;
                    foreach (DataRow r in aBillsDataTable.Rows)
                    {
                        if (r["IsRevised"].ToString() == "0")
                        {
                            TotalDebitPrice += double.Parse(r["TotalPrice"].ToString());
                        } 
                        if (DebitDGView.Rows.Count < ItemsPerPageDebit)
                        {
                            DebitDGView.Rows.Add();
                            DebitDGView.Rows[RowNumDebit].Cells["TypeDbt"].Value = "Invoice";
                            DebitDGView.Rows[RowNumDebit].Cells["Number"].Value = r["Number"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Date"].Value = DateTime.Parse(r["Date"].ToString()).ToShortDateString();
                            DebitDGView.Rows[RowNumDebit].Cells["BillTime"].Value = r["BillTime"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalItems"].Value = r["TotalItems"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalTax"].Value = r["TotalTax"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalPrice"].Value = r["TotalPrice"].ToString();
                            
                            for (int i = 0; i < aUsersTable.Rows.Count; i++)
                            {                               
                                if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(r["TellerID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["TellerID"].Value = aUsersTable.Rows[i]["UserName"].ToString();//aBillsDataTable.Rows[RowNum]["TellerID"].ToString();
                                    break;
                                }
                            }

                            for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                            {
                                if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["CustomerID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["CustomerID"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < aPriceLevelTable.Rows.Count; i++)
                            {
                                if (int.Parse(aPriceLevelTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["PriceLevelID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["PriceLevelID"].Value = aPriceLevelTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }

                            for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                            {
                                if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["PaymentMethodID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["PaymentMethodID"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["TotalCost"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalCost"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Comments"].Value = aBillsDataTable.Rows[RowNumDebit]["Comments"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["SalesDiscount"].Value = aBillsDataTable.Rows[RowNumDebit]["SalesDiscount"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["DiscountPerc"].Value = aBillsDataTable.Rows[RowNumDebit]["DiscountPerc"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["CashIn"].Value = aBillsDataTable.Rows[RowNumDebit]["CashIn"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalDiscount"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalDiscount"].ToString();

                            if (aBillsDataTable.Rows[RowNumDebit]["IsChecked"].ToString() == "0")
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsChecked"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                            }
                            else
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsChecked"].Value = "YES";
                            }

                            if (aBillsDataTable.Rows[RowNumDebit]["IsRevised"].ToString() == "0")
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsRevised"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                            }
                            else
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsRevised"].Value = "YES";
                                DebitDGView.Rows[RowNumDebit].DefaultCellStyle.BackColor = Color.Red;
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["CheckedDate"].Value = aBillsDataTable.Rows[RowNumDebit]["CheckedDate"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["CheckedBy"].Value = aBillsDataTable.Rows[RowNumDebit]["CheckedBy"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["ReviseDate"].Value = aBillsDataTable.Rows[RowNumDebit]["ReviseDate"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["RevisedBy"].Value = aBillsDataTable.Rows[RowNumDebit]["RevisedBy"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["ReviseLoss"].Value = aBillsDataTable.Rows[RowNumDebit]["ReviseLoss"].ToString();
                            RowNumDebit++;
                        }
                    }
                    TotalDebitPriceTxtBox.Text = TotalDebitPrice.ToString();
                    PageOfTotalTxtBoxDebit.Text = "1/" + pagesnumberDebit.ToString();
                    currentpageDebit = 1;
                }
            }
            DebitDGView.ResumeDrawing();
            DebitDGView.ResumeLayout();
            #endregion LISTING BILLS

            #region Listing Credit
            aCusPaymentDataTable = CustomersPaymentsMgmt.SelectAll(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterCustomerID);
            aCusReturnDataTable = ReturnItemsCustGeneralMGMT.SelectAllBills(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterCustomerID,CreditBillsChkBox.Checked);
            Int64 TotalInCreditTables = aCusPaymentDataTable.Rows.Count + aCusReturnDataTable.Rows.Count;

            if (TotalInCreditTables==0)
            {
                return;
            }
            aTotalCreditDataTable = new DataTable();
            aTotalCreditDataTable.Columns.Add("Type");
            aTotalCreditDataTable.Columns.Add("Total");
            aTotalCreditDataTable.Columns.Add("PaymentNumber");
            aTotalCreditDataTable.Columns.Add("CustomerID");
            aTotalCreditDataTable.Columns.Add("Date");
            aTotalCreditDataTable.Columns.Add("Time");
            aTotalCreditDataTable.Columns.Add("TellerID");
            aTotalCreditDataTable.Columns.Add("IsRevised");
            aTotalCreditDataTable.Columns.Add("RevisedBy");
            aTotalCreditDataTable.Columns.Add("ReviseDate");
            aTotalCreditDataTable.Columns.Add("ReviseTime");
            aTotalCreditDataTable.Columns.Add("IsChecked");
            aTotalCreditDataTable.Columns.Add("CheckedBy");
            aTotalCreditDataTable.Columns.Add("CheckDate");
            aTotalCreditDataTable.Columns.Add("CheckTime");
            aTotalCreditDataTable.Columns.Add("OldCusAmount");
            aTotalCreditDataTable.Columns.Add("Comments");
            int TotalCrdtRowNum = 0;
            foreach (DataRow r in aCusPaymentDataTable.Rows)
            {
                aTotalCreditDataTable.Rows.Add();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Type"] = "Customer Payment";
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Total"] = r["Amount"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["PaymentNumber"] = r["PaymentNumber"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CustomerID"] = r["CustomerID"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Date"] = r["Date"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Time"] = r["Time"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["TellerID"] = r["TellerID"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["IsRevised"] = r["IsRevised"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["RevisedBy"] = r["RevisedBy"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["ReviseDate"] = r["ReviseDate"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["ReviseTime"] = r["ReviseTime"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["IsChecked"] = r["IsChecked"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckDate"] = r["CheckDate"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckedBy"] = r["CheckedBy"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckTime"] = r["CheckTime"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["OldCusAmount"] = r["OldUsrAccountAmount"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Comments"] = r["Comments"].ToString();
                TotalCrdtRowNum++;
            }
            foreach (DataRow r in aCusReturnDataTable.Rows)
            {
                aTotalCreditDataTable.Rows.Add();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Type"] = "Customer Returns";
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Total"] = r["TotalPrice"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["PaymentNumber"] = r["Number"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CustomerID"] = r["CustomerID"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Date"] = r["Date"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Time"] = r["Time"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["TellerID"] = r["TellerID"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["IsRevised"] = r["IsRevised"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["RevisedBy"] = r["RevisedBy"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["ReviseDate"] = r["ReviseDate"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["ReviseTime"] = r["ReviseTime"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["IsChecked"] = r["IsChecked"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckedBy"] = r["CheckedBy"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckDate"] = r["CheckDate"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["CheckTime"] = r["CheckTime"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["OldCusAmount"] = r["CustomerAccountAmountOld"].ToString();
                aTotalCreditDataTable.Rows[TotalCrdtRowNum]["Comments"] = r["Comments"].ToString();
                TotalCrdtRowNum++;
            }

            aTotalCreditDataTable.DefaultView.Sort = "Date ASC";

            aTotalCreditDataTable = aTotalCreditDataTable.DefaultView.ToTable();

            TotalITemsTxtBoxCredit.Text = TotalInCreditTables.ToString();

            TotalCreditTxtBox.Text = "0";
            if (TotalInCreditTables>0)
            {
                double TotalCredit = 0;
                RowNumCredit = 0;
                if (CreditDGView.Rows.Count < ItemsPerPageCredit)
                {
                    //TestingFor Paging
                    pagesnumberCredit = TotalInCreditTables / ItemsPerPageCredit;

                    if ((double.Parse(TotalInCreditTables.ToString()) / ItemsPerPageCredit - TotalInCreditTables / ItemsPerPageCredit) > 0)
                        pagesnumberCredit++;


                    foreach (DataRow r in aTotalCreditDataTable.Rows)
                    {
                        if (r["IsRevised"].ToString()=="0")
                        {
                            TotalCredit += double.Parse(r["Total"].ToString());
                        }

                        if (CreditDGView.Rows.Count < ItemsPerPageCredit)
                        {
                            CreditDGView.Rows.Add();
                            CreditDGView.Rows[RowNumCredit].Cells["TypeCredit"].Value = r["Type"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["PaymentNumber"].Value = r["PaymentNumber"].ToString();
                            for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                            {
                                if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(r["CustomerID"].ToString()))
                                {
                                    CreditDGView.Rows[RowNumCredit].Cells["CustomerIDCredit"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["DateCredit"].Value = r["Date"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["TimeCredit"].Value = r["Time"].ToString();
                            for (int i = 0; i < aUsersTable.Rows.Count; i++)
                            {
                                if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(r["TellerID"].ToString()))
                                {
                                    CreditDGView.Rows[RowNumCredit].Cells["TellerCredit"].Value = aUsersTable.Rows[i]["UserName"].ToString();
                                    break;
                                }
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["AmountCredit"].Value = r["Total"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["OldAmountCredit"].Value = r["OldCusAmount"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CommentsCredit"].Value = r["Comments"].ToString();



                            if (r["IsChecked"].ToString() == "0")
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsCheckedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                            }
                            else
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsCheckedCredit"].Value = "YES";
                            }

                            if (r["IsRevised"].ToString() == "0")
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsRevisedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                            }
                            else
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsRevisedCredit"].Value = "YES";
                                CreditDGView.Rows[RowNumCredit].DefaultCellStyle.BackColor = Color.Red;
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["CheckDateCredit"].Value = r["CheckDate"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CheckTimeCredit"].Value = r["CheckTime"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CheckedByCredit"].Value = r["CheckedBy"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["ReviseDateCredit"].Value = r["ReviseDate"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["ReviseTimeCredit"].Value = r["ReviseTime"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["RevisedByCredit"].Value = r["RevisedBy"].ToString();
                            RowNumCredit++;
                        }
                    }
                    PageOfTotalTxtBoxCredit.Text = "1/" + pagesnumberCredit.ToString();
                    currentpageCredit = 1;
                    TotalCreditTxtBox.Text = TotalCredit.ToString();
                }
                
            }
            #endregion Listing Credit

        }
        #region DEBIT FUNCTIONS
        //DEBIT FUNCTIONS
        private void pageDebit(int pagenumber)
        {
            //DateTime StartTime = DateTime.Now;
            this.Cursor = Cursors.WaitCursor;
            if (DebitDGView.Rows.Count > 0)
            {
                int dgrow = 0;

                DebitDGView.Rows.Clear();
                //TestingFor Paging                
                for (RowNumDebit = (pagenumber - 1) * ItemsPerPageDebit; RowNumDebit < (pagenumber - 1) * ItemsPerPageDebit + (ItemsPerPageDebit); RowNumDebit++)
                {
                    if (DebitDGView.Rows.Count < ItemsPerPageDebit && RowNumDebit < aBillsDataTable.Rows.Count)
                    {
                        DebitDGView.Rows.Add();
                        DebitDGView.Rows[dgrow].Cells["TypeDbt"].Value = "Invoice";
                        DebitDGView.Rows[dgrow].Cells["Number"].Value = aBillsDataTable.Rows[RowNumDebit]["Number"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Date"].Value = DateTime.Parse(aBillsDataTable.Rows[RowNumDebit]["Date"].ToString()).ToShortDateString();
                        DebitDGView.Rows[dgrow].Cells["BillTime"].Value = aBillsDataTable.Rows[RowNumDebit]["BillTime"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalItems"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalItems"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalTax"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalTax"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalPrice"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalPrice"].ToString();
                        for (int i = 0; i < aUsersTable.Rows.Count; i++)
                        {
                            if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["TellerID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["TellerID"].Value = aUsersTable.Rows[i]["UserName"].ToString();//aBillsDataTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }

                        for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                        {
                            if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["CustomerID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["CustomerID"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                break;
                            }
                        }
                        for (int i = 0; i < aPriceLevelTable.Rows.Count; i++)
                        {
                            if (int.Parse(aPriceLevelTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["PriceLevelID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["PriceLevelID"].Value = aPriceLevelTable.Rows[i]["Name"].ToString();
                                break;
                            }
                        }

                        for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                        {
                            if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aBillsDataTable.Rows[RowNumDebit]["PaymentMethodID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["PaymentMethodID"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();
                                break;
                            }
                        }
                        DebitDGView.Rows[dgrow].Cells["TotalCost"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalCost"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Comments"].Value = aBillsDataTable.Rows[RowNumDebit]["Comments"].ToString();
                        DebitDGView.Rows[dgrow].Cells["SalesDiscount"].Value = aBillsDataTable.Rows[RowNumDebit]["SalesDiscount"].ToString();
                        DebitDGView.Rows[dgrow].Cells["DiscountPerc"].Value = aBillsDataTable.Rows[RowNumDebit]["DiscountPerc"].ToString();
                        DebitDGView.Rows[dgrow].Cells["CashIn"].Value = aBillsDataTable.Rows[RowNumDebit]["CashIn"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalDiscount"].Value = aBillsDataTable.Rows[RowNumDebit]["TotalDiscount"].ToString();

                        if (aBillsDataTable.Rows[RowNumDebit]["IsChecked"].ToString() == "0")
                        {
                            DebitDGView.Rows[dgrow].Cells["IsChecked"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                        }
                        else
                        {
                            DebitDGView.Rows[dgrow].Cells["IsChecked"].Value = "YES";
                        }

                        if (aBillsDataTable.Rows[RowNumDebit]["IsRevised"].ToString() == "0")
                        {
                            DebitDGView.Rows[dgrow].Cells["IsRevised"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                        }
                        else
                        {
                            DebitDGView.Rows[dgrow].Cells["IsRevised"].Value = "YES";
                            DebitDGView.Rows[dgrow].DefaultCellStyle.BackColor = Color.Red;
                        }
                        DebitDGView.Rows[dgrow].Cells["CheckedDate"].Value = aBillsDataTable.Rows[RowNumDebit]["CheckedDate"].ToString();
                        DebitDGView.Rows[dgrow].Cells["CheckedBy"].Value = aBillsDataTable.Rows[RowNumDebit]["CheckedBy"].ToString();
                        DebitDGView.Rows[dgrow].Cells["ReviseDate"].Value = aBillsDataTable.Rows[RowNumDebit]["ReviseDate"].ToString();
                        DebitDGView.Rows[dgrow].Cells["RevisedBy"].Value = aBillsDataTable.Rows[RowNumDebit]["RevisedBy"].ToString();
                        DebitDGView.Rows[dgrow].Cells["ReviseLoss"].Value = aBillsDataTable.Rows[RowNumDebit]["ReviseLoss"].ToString();


                        dgrow++;
                    }
                }

            }
            this.Cursor = Cursors.Default;
            // TimeSpan ts = DateTime.Now.Subtract(StartTime);
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //        ts.Hours, ts.Minutes, ts.Seconds,
            //        ts.Milliseconds / 10);
            //MessageBox.Show("Time=" + elapsedTime);
        }
        private void NextPageBtnDebit_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                if (int.TryParse(textBox1Debit.Text, out TestParser))
                {
                    if (TestParser <= pagesnumberDebit && TestParser > 0)
                    {
                        currentpageDebit = TestParser;
                        pageDebit(currentpageDebit);
                        PageOfTotalTxtBoxDebit.Text = currentpageDebit.ToString() + "/" + pagesnumberDebit.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerdebitCredit:NextPageBtnDebit_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        private void PreviousPageDebit_Click(object sender, EventArgs e)
        {
            if (currentpageDebit - 1 <= pagesnumberDebit && currentpageDebit - 1 >= 1)
            {
                pageDebit(--currentpageDebit);
                PageOfTotalTxtBoxDebit.Text = currentpageDebit.ToString() + "/" + pagesnumberDebit.ToString();
            }
        }
        private void NextPageDebit_Click(object sender, EventArgs e)
        {
            if (currentpageDebit + 1 <= pagesnumberDebit)
            {
                pageDebit(++currentpageDebit);
                PageOfTotalTxtBoxDebit.Text = currentpageDebit.ToString() + "/" + pagesnumberDebit.ToString();
            }
        }
        private void ItemsPerPageBtnDebit_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                ListDCBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBoxDebit.Text, out TestParser) && aBillsDataTable != null)
                {
                    if (TestParser > 0 && DebitDGView.Rows.Count > 0)
                    {
                        ItemsPerPageDebit = TestParser;
                        if (ItemsPerPageDebit <= 100)
                        {
                            pagesnumberDebit = (int)aBillsDataTable.Rows.Count / ItemsPerPageDebit;
                            if ((double.Parse(aBillsDataTable.Rows.Count.ToString()) / ItemsPerPageDebit - int.Parse(aBillsDataTable.Rows.Count.ToString()) / ItemsPerPageDebit) > 0)
                                pagesnumberDebit++;
                            PageOfTotalTxtBoxDebit.Text = "1/" + pagesnumberDebit.ToString();
                            pageDebit(1);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerDebitCredit:ItemsPerPageBtnDebit_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }
        private void DebitDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditBills) == EventStatus.Permit)
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                else
                {
                    DataTable aDataTableToPass = BillDetailedMgmt.SelectBillByBillNumber(int.Parse(DebitDGView.Rows[e.RowIndex].Cells["Number"].Value.ToString()));
                    EditBill aEditBill = new EditBill();
                    //  aEditBill.MdiParent = Helper.Instance.ActiveMainWindow;
                    aEditBill.AddDgView(aDataTableToPass);

                    DataRow aGeneralBillDataRow = BillGeneralMgmt.SelectBillByNumber(int.Parse(DebitDGView.Rows[e.RowIndex].Cells["Number"].Value.ToString()));

                    aEditBill.UpdateVariables(aGeneralBillDataRow);
                    aEditBill.Dock = DockStyle.Fill;
                    aEditBill.Show();
                }
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion DEBIT FUNCTIONS
        #region CREDIT FUNCTIONS
        private void pageCredit(int pagenumber)
        {

            if (CreditDGView.Rows.Count > 0)
            {
                int dgrow = 0;
                CreditDGView.Rows.Clear();
                //TestingFor Paging                
                for (RowNumCredit = (pagenumber - 1) * ItemsPerPageCredit; RowNumCredit < (pagenumber - 1) * ItemsPerPageCredit + (ItemsPerPageCredit); RowNumCredit++)
                {
                    if (CreditDGView.Rows.Count < ItemsPerPageCredit && RowNumCredit < aTotalCreditDataTable.Rows.Count)
                    {
                        CreditDGView.Rows.Add();
                        CreditDGView.Rows[dgrow].Cells["TypeCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["Type"].ToString();
                        CreditDGView.Rows[dgrow].Cells["PaymentNumber"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["PaymentNumber"].ToString();
                        for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                        {
                            if (int.Parse(aCustomerTable.Rows[i]["ID"].ToString()) == int.Parse(aTotalCreditDataTable.Rows[RowNumCredit]["CustomerID"].ToString()))
                            {
                                CreditDGView.Rows[dgrow].Cells["CustomerIDCredit"].Value = aCustomerTable.Rows[i]["Name"].ToString();
                                break;
                            }
                        }
                        CreditDGView.Rows[dgrow].Cells["DateCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["Date"].ToString();
                        CreditDGView.Rows[dgrow].Cells["TimeCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["Time"].ToString();
                        for (int i = 0; i < aUsersTable.Rows.Count; i++)
                        {
                            if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aTotalCreditDataTable.Rows[RowNumCredit]["TellerID"].ToString()))
                            {
                                CreditDGView.Rows[dgrow].Cells["TellerCredit"].Value = aUsersTable.Rows[i]["UserName"].ToString();
                                break;
                            }
                        }
                        CreditDGView.Rows[dgrow].Cells["AmountCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["Total"].ToString();
                        CreditDGView.Rows[dgrow].Cells["OldAmountCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["OldCusAmount"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CommentsCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["Comments"].ToString();



                        if (aTotalCreditDataTable.Rows[RowNumCredit]["IsChecked"].ToString() == "0")
                        {
                            CreditDGView.Rows[dgrow].Cells["IsCheckedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                        }
                        else
                        {
                            CreditDGView.Rows[dgrow].Cells["IsCheckedCredit"].Value = "YES";
                        }

                        if (aTotalCreditDataTable.Rows[RowNumCredit]["IsRevised"].ToString() == "0")
                        {
                            CreditDGView.Rows[dgrow].Cells["IsRevisedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                        }
                        else
                        {
                            CreditDGView.Rows[dgrow].Cells["IsRevisedCredit"].Value = "YES";
                            CreditDGView.Rows[dgrow].DefaultCellStyle.BackColor = Color.Red;
                        }
                        CreditDGView.Rows[dgrow].Cells["CheckDateCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["CheckDate"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CheckTimeCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["CheckTime"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CheckedByCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["CheckedBy"].ToString();
                        CreditDGView.Rows[dgrow].Cells["ReviseDateCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["ReviseDate"].ToString();
                        CreditDGView.Rows[dgrow].Cells["ReviseTimeCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["ReviseTime"].ToString();
                        CreditDGView.Rows[dgrow].Cells["RevisedByCredit"].Value = aTotalCreditDataTable.Rows[RowNumCredit]["RevisedBy"].ToString();
                        dgrow++;
                    }
                }

            }
        }

        private void NextPageBtnCredit_Click(object sender, EventArgs e)
        {

            if (int.Parse(textBox1Credit.Text.ToString()) <= pagesnumberCredit && int.Parse(textBox1Credit.Text.ToString()) > 0)
            {
                currentpageCredit = int.Parse(textBox1Credit.Text.ToString());
                pageCredit(currentpageCredit);
                PageOfTotalTxtBoxCredit.Text = currentpageCredit.ToString() + "/" + pagesnumberCredit.ToString();
            }
        }

        private void PreviousPageCredit_Click(object sender, EventArgs e)
        {
            if (currentpageCredit - 1 <= pagesnumberCredit && currentpageCredit - 1 >= 1)
            {
                pageCredit(--currentpageCredit);
                PageOfTotalTxtBoxCredit.Text = currentpageCredit.ToString() + "/" + pagesnumberCredit.ToString();
            }
        }

        private void NextPageCredit_Click(object sender, EventArgs e)
        {
            if (currentpageCredit + 1 <= pagesnumberCredit)
            {
                pageCredit(++currentpageCredit);
                PageOfTotalTxtBoxCredit.Text = currentpageCredit.ToString() + "/" + pagesnumberCredit.ToString();
            }
        }

        private void ItemsPerPageBtnCredit_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParser;
                ListDCBtn.PerformClick();
                if (int.TryParse(ItemsPerPageTxtBoxCredit.Text, out TestParser) && aTotalCreditDataTable != null)
                {
                    if (TestParser > 0 && CreditDGView.Rows.Count > 0)
                    {
                        ItemsPerPageCredit = TestParser;
                        if (ItemsPerPageCredit <= 100)
                        {
                            pagesnumberCredit = (int)aTotalCreditDataTable.Rows.Count / ItemsPerPageCredit;
                            if ((double.Parse(aTotalCreditDataTable.Rows.Count.ToString()) / ItemsPerPageCredit - int.Parse(aTotalCreditDataTable.Rows.Count.ToString()) / ItemsPerPageCredit) > 0)
                                pagesnumberCredit++;
                            PageOfTotalTxtBoxCredit.Text = "1/" + pagesnumberCredit.ToString();
                            pageCredit(1);
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerDebitCredit:ItemsPerPageBtnCredit_Click()] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }

        }

        private void CreditDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==-1)
            {
                return;
            }
            if (CreditDGView.Rows[e.RowIndex].Cells["TypeCredit"].Value.ToString()=="Customer Returns")
            {
                return;
            }
            {
                DataRow aCustomerPaymentToPass = CustomersPaymentsMgmt.SelectPaymentRow(int.Parse(CreditDGView.Rows[e.RowIndex].Cells["PaymentNumber"].Value.ToString()));
                EditCustomerPayment aEditCustomerPayment = new EditCustomerPayment();
                //aEditCustomerPayment.MdiParent = Helper.Instance.ActiveMainWindow;
                aEditCustomerPayment.Show();
                aEditCustomerPayment.UpdateVariables(aCustomerPaymentToPass);
            }
        }
        #endregion CREDIT FUNCTIONS
        private void CustomerDebitCredit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
            // TODO: This line of code loads data into the 'dBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dBDataSet.Customer);

        }
        private void CustomerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomerNameComboBox.SelectedValue != null)
                {
                    semaphore = true;
                    CustomerPhoneTxtBox.Text = CustomerNameComboBox.SelectedValue.ToString();
                    aCusomerAccountRow = null;
                    aCustomerRow = CustomerMgmt.SelectCustomerRowByPhone1(CustomerPhoneTxtBox.Text);

                    if (aCustomerRow == null) // No Customer
                    {
                        CustomerNameComboBox.Text = string.Empty;
                        CustomerBalanceTxtBox.Text = string.Empty;
                        //
                        // CommentsTxtBox.ReadOnly = true;
                        CustomerDoNotHaveAccount = true;
                        //PaymentAmountTxtBox.Enabled = false;
                    }
                    else
                    {
                        string CustomerName = aCustomerRow["Name"].ToString();
                        CustomerID3 = int.Parse(aCustomerRow["ID"].ToString());
                        aCusomerAccountRow = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID3);
                        if (aCusomerAccountRow == null)
                        {
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = UiText.CustomerDoNotHaveAccountTxt;
                            CustomerDoNotHaveAccount = true;
                            //
                            //CommentsTxtBox.ReadOnly = true;
                            //PaymentAmountTxtBox.Enabled = false;
                        }
                        else
                        {
                            Balance = Double.Parse(aCusomerAccountRow["Amount"].ToString());
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = Balance.ToString();
                            //CommentsTxtBox.ReadOnly = false;
                            CustomerDoNotHaveAccount = false;
                            //PaymentAmountTxtBox.Enabled = true;
                        }
                    }
                    //semaphore = false;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerNameComboBox_SelectedIndexChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally { semaphore = false; }
        }
        private void CustomerPhoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!semaphore)
                {
                    semaphore = true;
                    aCusomerAccountRow = null;
                    aCustomerRow = CustomerMgmt.SelectCustomerRowByPhone1(CustomerPhoneTxtBox.Text);
                    if (aCustomerRow == null) //there is no customer
                    {
                        CustomerNameComboBox.Text = string.Empty;
                        CustomerBalanceTxtBox.Text = string.Empty;
                        CustomerDoNotHaveAccount = true;
                    }
                    else
                    {
                        string CustomerName = aCustomerRow["Name"].ToString();
                        CustomerID2 = int.Parse(aCustomerRow["ID"].ToString());
                        aCusomerAccountRow = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID2);
                        if (aCusomerAccountRow == null)
                        {
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = UiText.CustomerDoNotHaveAccountTxt;
                            //                            
                            CustomerDoNotHaveAccount = true;
                        }
                        else //He Have Account
                        {
                            Balance = Double.Parse(aCusomerAccountRow["Amount"].ToString());

                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = Balance.ToString();
                            CustomerDoNotHaveAccount = false;
                        }
                    }
                }
            }
            catch (Exception ex)//UnExpected Error IN [CustomerPhoneTxtBox_TextChanged]
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerPhoneTxtBox_TextChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            finally { semaphore = false; }
        }
        //MAKE THE BORDERLESS MOVABLE
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        private void MatchBalanceButton_Click(object sender, EventArgs e)
        {
            if (CustomerDoNotHaveAccount)
            {
                MessageBox.Show("Please Select Valid User WHO HAVE ACCOUNT");
            }
            else
            {
                UnRevisedChkBox.Checked = true;
                CreditBillsChkBox.Checked = true;
                ListDCBtn.PerformClick();
                double currentbalance =0;
                double totalbillsprice=0;
                double totalpayments  =0;
                double temptemp = 0;
                if (double.TryParse(CustomerBalanceTxtBox.Text, out currentbalance))
                {
                    currentbalance = Math.Round(currentbalance, 3);
                }
                if (double.TryParse(TotalDebitPriceTxtBox.Text, out totalbillsprice))
                {
                    totalbillsprice = Math.Round(totalbillsprice, 3);
                }
                if (double.TryParse(TotalCreditTxtBox.Text, out totalpayments))
                {
                    totalpayments = Math.Round(totalpayments, 3);
                }
               
                 temptemp         = Math.Round((totalbillsprice - totalpayments), 3);
                if (currentbalance == temptemp)
                {
                    MessageBox.Show("الحساب مطابق");

                }
                else if (currentbalance > (totalbillsprice - totalpayments))
                {
                    MessageBox.Show("الحساب غير مطابق , يجب على الزبون دفع مبلغ" + ((totalbillsprice - totalpayments)));
                }
                else
                {
                    MessageBox.Show("الحساب غير مطابق , يجب ان تدفع للزبون  مبلغ" + ((totalbillsprice - totalpayments)));
                }

            }


        }
        protected override void OnResize(EventArgs e)
        {
            panel2.Width = this.Width / 2;
            panel3.Width = this.Width / 2;
            base.OnResize(e);
        }
        private void DateCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            DateFrompicker.Enabled = DateCheckBox.Checked;
            DateToPicker.Enabled = DateCheckBox.Checked;

        }
        private void TellerNameChkBox_CheckedChanged(object sender, EventArgs e)
        {
            TellerNameComboBox.Enabled = TellerNameChkBox.Checked;
        }

        private void TranslateUI()
        {
            this.Text = "Customer Reconsilation";
            CustomerNameLbl.Text = UiText.CDCCustomerNameLbl;
            CustomerPhoneLbl.Text = UiText.CDCCustomerPhoneLbl;
            AccountBalnaceLbl.Text = UiText.CDCAccountBalnaceLbl;
            FiltersGB.Text = UiText.CDCFiltersGB;
            DateCheckBox.Text = UiText.CDCDateCheckBox;
            TellerNameChkBox.Text = UiText.CDCTellerNameChkBox;
            DateFromLbl.Text = UiText.CDCDateFromLbl;
            DateToLbl.Text = UiText.CDCDateToLbl;
            UnCheckedChkBox.Text = UiText.CDCUnCheckedChkBox;
            UnRevisedChkBox.Text = UiText.CDCUnRevisedChkBox;
            CheckChkBox.Text = UiText.CDCCheckChkBox;
            RevisedChkBox.Text = UiText.CDCRevisedChkBox;
            CreditBillsChkBox.Text = UiText.CDCCreditBillsChkBox;
            ListDCBtn.Text = UiText.CDCListDCBtn;
            MatchBalanceButton.Text = UiText.CDCMatchBalanceButton;
            TotalBillsPriceLbl.Text = UiText.CDCTotalBillsPriceLbl;
            label1.Text = UiText.CDClabel1;
            label2.Text = UiText.CDClabel2;
            ItemsPerPageBtnDebit.Text = UiText.CDCItemsPerPageBtnDebit;
            NextPageBtnDebit.Text = UiText.CDCNextPageBtnDebit;
            DebitLbl.Text = UiText.CDCDebitLbl;
            label3.Text = UiText.CDClabel3;
            TotalCreditLbl.Text = UiText.CDCTotalCreditLbl;
            TotalItemsLbl.Text = UiText.CDCTotalItemsLbl;
            CreditLbl.Text = UiText.CDCCreditLbl;
            ItemsPerPageLbl.Text = UiText.CDCItemsPerPageLbl;
            ItemsPerPageBtnCredit.Text = UiText.CDCItemsPerPageBtnCredit;
            NextPageBtnCredit.Text = UiText.CDCNextPageBtnCredit;
            TotalPagesLbl.Text = UiText.CDCTotalPagesLbl;
            AddCustomerLbl.Text = UiText.CDCAddCustomerLbl;

        }

    }
}

