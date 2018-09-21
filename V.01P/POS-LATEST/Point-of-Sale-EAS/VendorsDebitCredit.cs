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
namespace Calcium_RMS
{
    public partial class VendorsDebitCredit : Form
    {
        protected override void OnResize(EventArgs e)
        {
            panel2.Width = this.Width / 2;
            panel4.Width = this.Width / 2;
            base.OnResize(e);
        }

        int RowNumCredit = 0;
        int pagesnumberCredit;
        int ItemsPerPageCredit = 10;
        int currentpageCredit = 1;


        int RowNumDebit = 0;
        int pagesnumberDebit;
        int ItemsPerPageDebit = 10;
        int currentpageDebit = 1;

        bool CustomerDoNotHaveAccount = true;
        double Balance = 0;
        int CustomerID2 = 0;

        DataTable aVendorTable;
        DataTable aCurrencyTable;
        DataTable aUsersTable;
        DataTable aAccountsTable;
        DataTable aPaymentMethodTable;


        DataTable aPurchaseVoucherTable = null;
        DataTable aVendorPaymentTable = null;

        private void VendorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VendorNameComboBox.SelectedValue==null)
            {
                return;
            }
            DataRow aVendorRow = VendorsMgmt.SelectVendorRowByID(int.Parse(VendorNameComboBox.SelectedValue.ToString()));
            VendorCompanyTxtBox.Text = aVendorRow["Company"].ToString();

            DataRow aVendorAccountRow = VendorsAccountsMgmt.SelectVendorAccountRowByVendorID(int.Parse(VendorNameComboBox.SelectedValue.ToString()));
            if (aVendorAccountRow == null)
            {
                VendorAccountBalanceTxtBox.Text = "Vendor Have No Account";
                CustomerDoNotHaveAccount = true;
            }
            else
            {
                VendorAccountBalanceTxtBox.Text = aVendorAccountRow["Amount"].ToString();
                CustomerDoNotHaveAccount = false;
            }

        }
        public VendorsDebitCredit()
        {
            InitializeComponent();

   
            //Add this Line To Each Constructor To Disable Maximize
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void VendorsDebitCredit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dBDataSet.Users);
            // TODO: This line of code loads data into the 'dBDataSet.Vendors' table. You can move, or remove it, as needed.
            this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);

        }

        private void ListDCBtn_Click(object sender, EventArgs e)
        {
            int FilterVendorID = int.Parse(VendorNameComboBox.SelectedValue.ToString());

            aCurrencyTable = CurrencyMgmt.SelectAll();
            aUsersTable = UsersMgmt.SelectAllUsers();
            aAccountsTable = AccountsMgmt.SelectAll();
            aPaymentMethodTable = PaymentMethodMgmt.SelectAll();
            aAccountsTable = AccountsMgmt.SelectAll();
            aVendorTable = VendorsMgmt.SelectAllVendors();

            DebitDGView.Rows.Clear();
            CreditDGView.Rows.Clear();

            int FilterTellerNameID = 0;
            if (TellerNameChkBox.Checked)
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

            //LISTING BILLS
            aPurchaseVoucherTable = PurchaseVoucherGeneralMgmt.SelectAllVouchers(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterVendorID, FilterBillCashCredit);
            TotalITemsTxtBoxDebit.Text = aPurchaseVoucherTable.Rows.Count.ToString();

            TotalDebitPriceTxtBox.Text = "0";
            if (aPurchaseVoucherTable.Rows.Count > 0)
            {
                double TotalDebitPrice = 0;
                for (int i = 0; i < aPurchaseVoucherTable.Rows.Count; i++)
                {
                    TotalDebitPrice += double.Parse(aPurchaseVoucherTable.Rows[i]["TotalCost"].ToString());
                }
                TotalDebitPriceTxtBox.Text = TotalDebitPrice.ToString();
                RowNumDebit = 0;
                if (DebitDGView.Rows.Count < ItemsPerPageDebit)
                {
                    //TestingFor Paging
                    pagesnumberDebit = (int)aPurchaseVoucherTable.Rows.Count / ItemsPerPageDebit;
                    if ((double.Parse(aPurchaseVoucherTable.Rows.Count.ToString()) / ItemsPerPageDebit - int.Parse(aPurchaseVoucherTable.Rows.Count.ToString()) / ItemsPerPageDebit) > 0)
                        pagesnumberDebit++;
                    foreach (DataRow r in aPurchaseVoucherTable.Rows)
                    {
                        if (DebitDGView.Rows.Count < ItemsPerPageDebit)
                        {
                            DebitDGView.Rows.Add();
                            DebitDGView.Rows[RowNumDebit].Cells["VoucherNumber"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["VoucherNumber"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Date"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Date"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Time"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Time"].ToString();
                            for (int i = 0; i < aVendorTable.Rows.Count; i++)
                            {
                                if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["VendorID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["Vendor"].Value = aVendorTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                    break;
                                }
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["TotalFreeITemsQty"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalFreeITemsQty"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalTax"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalTax"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Subtotal"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Subtotal"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["DiscountPerc"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["DiscountPerc"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalItemsDiscount"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalItemsDiscount"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalDiscount"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalDiscount"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["TotalCost"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalCost"].ToString();
                            for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                            {
                                if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["PaymentMethodID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["PaymentMethod"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                    break;
                                }
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["Comments"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Comments"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["CreditCardInfo"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CreditCardInfo"].ToString();
                            for (int i = 0; i < aCurrencyTable.Rows.Count; i++)
                            {
                                if (int.Parse(aCurrencyTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["CurrencyID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["Currency"].Value = aCurrencyTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < aAccountsTable.Rows.Count; i++)
                            {
                                if (int.Parse(aAccountsTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["AccountID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["Currency"].Value = aAccountsTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                    break;
                                }
                            }
                            for (int i = 0; i < aUsersTable.Rows.Count; i++)
                            {
                                if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["TellerID"].ToString()))
                                {
                                    DebitDGView.Rows[RowNumDebit].Cells["Teller"].Value = aUsersTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                    break;
                                }
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["CheckNumber"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckNumber"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["IsCashCredit"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["IsCashCredit"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["VendorAccountAmountOld"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["VendorAccountAmountOld"].ToString();
                            if (aPurchaseVoucherTable.Rows[RowNumDebit]["IsChecked"].ToString() == "0")
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsChecked"].Value = "NO";//aBillTable.Rows[RowNumDebit]["IsChecked"].ToString();
                            }
                            else
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsChecked"].Value = "YES";
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["CheckedBy"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckedBy"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["CheckDate"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckDate"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["CheckTime"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckTime"].ToString();
                            if (aPurchaseVoucherTable.Rows[RowNumDebit]["IsRevised"].ToString() == "0")
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsRevised"].Value = "NO";//aBillTable.Rows[RowNumDebit]["IsChecked"].ToString();
                            }
                            else
                            {
                                DebitDGView.Rows[RowNumDebit].Cells["IsRevised"].Value = "YES";
                            }
                            DebitDGView.Rows[RowNumDebit].Cells["RevisedBy"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["RevisedBy"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["ReviseDate"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseDate"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["ReviseTime"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseTime"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["ReviseLoss"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseLoss"].ToString();
                            DebitDGView.Rows[RowNumDebit].Cells["Fees"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Fees"].ToString();
                            RowNumDebit++;
                        }
                    }
                    PageOfTotalTxtBoxDebit.Text = "1/" + pagesnumberDebit.ToString();
                    currentpageDebit = 1;
                }

            }

            //LISTING PAYMENTS
            //LISTING PAYMENTS CREDIT
            aVendorPaymentTable = VendorsPaymentsMgmt.SelectAll(FilterTellerNameID, FilterDateFrom, FilterDateTo, FilterCheckedBills, FilterIsRevised, FilterUnCheckedBills, FilterUnRevisedBills, FilterVendorID);
            TotalITemsTxtBoxCredit.Text = aVendorPaymentTable.Rows.Count.ToString();

            TotalCreditTxtBox.Text = "0";
            if (aVendorPaymentTable.Rows.Count > 0)
            {
                double TotalCredit = 0;
                for (int i = 0; i < aVendorPaymentTable.Rows.Count; i++)
                {
                    TotalCredit += double.Parse(aVendorPaymentTable.Rows[i]["Amount"].ToString());
                }
                TotalCreditTxtBox.Text = TotalCredit.ToString();
                RowNumCredit = 0;
                if (CreditDGView.Rows.Count < ItemsPerPageCredit)
                {
                    //TestingFor Paging
                    pagesnumberCredit = (int)aVendorPaymentTable.Rows.Count / ItemsPerPageCredit;
                    if ((double.Parse(aVendorPaymentTable.Rows.Count.ToString()) / ItemsPerPageCredit - int.Parse(aVendorPaymentTable.Rows.Count.ToString()) / ItemsPerPageCredit) > 0)
                        pagesnumberCredit++;
                    foreach (DataRow r in aVendorPaymentTable.Rows)
                    {
                        if (CreditDGView.Rows.Count < ItemsPerPageCredit)
                        {
                            CreditDGView.Rows.Add();
                            CreditDGView.Rows[RowNumCredit].Cells["PaymentNumber"].Value = aVendorPaymentTable.Rows[RowNumCredit]["PaymentNumber"].ToString();
                            for (int i = 0; i < aVendorTable.Rows.Count; i++)
                            {
                                if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aVendorPaymentTable.Rows[RowNumCredit]["VendorID"].ToString()))
                                {
                                    CreditDGView.Rows[RowNumCredit].Cells["VendorIDCredit"].Value = aVendorTable.Rows[i]["Name"].ToString();
                                    break;
                                }
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["DateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Date"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["TimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Time"].ToString();
                            for (int i = 0; i < aUsersTable.Rows.Count; i++)
                            {
                                if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aVendorPaymentTable.Rows[RowNumCredit]["TellerID"].ToString()))
                                {
                                    CreditDGView.Rows[RowNumCredit].Cells["TellerCredit"].Value = aUsersTable.Rows[i]["UserName"].ToString();
                                    break;
                                }
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["AmountCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Amount"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["OldAmountCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["OldVendorAccountAmount"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CommentsCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Comments"].ToString();



                            if (aVendorPaymentTable.Rows[RowNumCredit]["IsChecked"].ToString() == "0")
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsCheckedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                            }
                            else
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsCheckedCredit"].Value = "YES";
                            }

                            if (aVendorPaymentTable.Rows[RowNumCredit]["IsRevised"].ToString() == "0")
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsRevisedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                            }
                            else
                            {
                                CreditDGView.Rows[RowNumCredit].Cells["IsRevisedCredit"].Value = "YES";
                            }
                            CreditDGView.Rows[RowNumCredit].Cells["CheckDateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckDate"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CheckTimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckTime"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["CheckedByCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckedBy"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["ReviseDateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["ReviseDate"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["ReviseTimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["ReviseTime"].ToString();
                            CreditDGView.Rows[RowNumCredit].Cells["RevisedByCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["RevisedBy"].ToString();
                            RowNumCredit++;
                        }
                        PageOfTotalTxtBoxCredit.Text = "1/" + pagesnumberCredit.ToString();
                        currentpageCredit = 1;
                    }
                }
            }

        }


        //DEBIT FUNCTIONS
        //DEBIT FUNCTIONS
        private void pageDebit(int pagenumber)
        {

            if (DebitDGView.Rows.Count > 0)
            {
                int dgrow = 0;

                DebitDGView.Rows.Clear();
                //TestingFor Paging                
                for (RowNumDebit = (pagenumber - 1) * ItemsPerPageDebit; RowNumDebit < (pagenumber - 1) * ItemsPerPageDebit + (ItemsPerPageDebit); RowNumDebit++)
                {
                    if (DebitDGView.Rows.Count < ItemsPerPageDebit && RowNumDebit < aPurchaseVoucherTable.Rows.Count)
                    {
                        DebitDGView.Rows.Add();
                        DebitDGView.Rows[dgrow].Cells["VoucherNumber"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["VoucherNumber"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Date"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Date"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Time"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Time"].ToString();
                        for (int i = 0; i < aVendorTable.Rows.Count; i++)
                        {
                            if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["VendorID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["Vendor"].Value = aVendorTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                break;
                            }
                        }
                        DebitDGView.Rows[dgrow].Cells["TotalFreeITemsQty"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalFreeITemsQty"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalTax"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalTax"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Subtotal"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Subtotal"].ToString();
                        DebitDGView.Rows[dgrow].Cells["DiscountPerc"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["DiscountPerc"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalItemsDiscount"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalItemsDiscount"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalDiscount"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalDiscount"].ToString();
                        DebitDGView.Rows[dgrow].Cells["TotalCost"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["TotalCost"].ToString();
                        for (int i = 0; i < aPaymentMethodTable.Rows.Count; i++)
                        {
                            if (int.Parse(aPaymentMethodTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["PaymentMethodID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["PaymentMethod"].Value = aPaymentMethodTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                break;
                            }
                        }
                        DebitDGView.Rows[dgrow].Cells["Comments"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Comments"].ToString();
                        DebitDGView.Rows[dgrow].Cells["CreditCardInfo"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CreditCardInfo"].ToString();
                        for (int i = 0; i < aCurrencyTable.Rows.Count; i++)
                        {
                            if (int.Parse(aCurrencyTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["CurrencyID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["Currency"].Value = aCurrencyTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                break;
                            }
                        }
                        for (int i = 0; i < aAccountsTable.Rows.Count; i++)
                        {
                            if (int.Parse(aAccountsTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["AccountID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["Currency"].Value = aAccountsTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNumDebit]["TellerID"].ToString();
                                break;
                            }
                        }
                        for (int i = 0; i < aUsersTable.Rows.Count; i++)
                        {
                            if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aPurchaseVoucherTable.Rows[RowNumDebit]["TellerID"].ToString()))
                            {
                                DebitDGView.Rows[dgrow].Cells["Teller"].Value = aUsersTable.Rows[i]["Name"].ToString();//aBillTable.Rows[RowNum]["TellerID"].ToString();
                                break;
                            }
                        }
                        DebitDGView.Rows[dgrow].Cells["CheckNumber"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckNumber"].ToString();
                        DebitDGView.Rows[dgrow].Cells["IsCashCredit"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["IsCashCredit"].ToString();
                        DebitDGView.Rows[dgrow].Cells["VendorAccountAmountOld"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["VendorAccountAmountOld"].ToString();
                        if (aPurchaseVoucherTable.Rows[RowNumDebit]["IsChecked"].ToString() == "0")
                        {
                            DebitDGView.Rows[dgrow].Cells["IsChecked"].Value = "NO";//aBillTable.Rows[RowNumDebit]["IsChecked"].ToString();
                        }
                        else
                        {
                            DebitDGView.Rows[dgrow].Cells["IsChecked"].Value = "YES";
                        }
                        DebitDGView.Rows[dgrow].Cells["CheckedBy"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckedBy"].ToString();
                        DebitDGView.Rows[dgrow].Cells["CheckDate"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckDate"].ToString();
                        DebitDGView.Rows[dgrow].Cells["CheckTime"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["CheckTime"].ToString();
                        if (aPurchaseVoucherTable.Rows[RowNumDebit]["IsRevised"].ToString() == "0")
                        {
                            DebitDGView.Rows[dgrow].Cells["IsRevised"].Value = "NO";//aBillTable.Rows[RowNumDebit]["IsChecked"].ToString();
                        }
                        else
                        {
                            DebitDGView.Rows[dgrow].Cells["IsRevised"].Value = "YES";
                        }
                        DebitDGView.Rows[dgrow].Cells["RevisedBy"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["RevisedBy"].ToString();
                        DebitDGView.Rows[dgrow].Cells["ReviseDate"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseDate"].ToString();
                        DebitDGView.Rows[dgrow].Cells["ReviseTime"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseTime"].ToString();
                        DebitDGView.Rows[dgrow].Cells["ReviseLoss"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["ReviseLoss"].ToString();
                        DebitDGView.Rows[dgrow].Cells["Fees"].Value = aPurchaseVoucherTable.Rows[RowNumDebit]["Fees"].ToString();
                        dgrow++;
                        //

                    }
                }

            }
        }
        private void NextPageBtnDebit_Click(object sender, EventArgs e)
        {

            if (int.Parse(textBox1Debit.Text.ToString()) <= pagesnumberDebit && int.Parse(textBox1Debit.Text.ToString()) > 0)
            {
                currentpageDebit = int.Parse(textBox1Debit.Text.ToString());
                pageDebit(currentpageDebit);
                PageOfTotalTxtBoxDebit.Text = currentpageDebit.ToString() + "/" + pagesnumberDebit.ToString();
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
            ListDCBtn.PerformClick();
            if (ItemsPerPageTxtBoxDebit.Text != "" && DebitDGView.Rows.Count > 0)
            {
                ItemsPerPageDebit = int.Parse(ItemsPerPageTxtBoxDebit.Text.ToString());
                if (ItemsPerPageDebit < 100)
                {
                    pagesnumberDebit = (int)aPurchaseVoucherTable.Rows.Count / ItemsPerPageDebit;
                    if ((double.Parse(aPurchaseVoucherTable.Rows.Count.ToString()) / ItemsPerPageDebit - int.Parse(aPurchaseVoucherTable.Rows.Count.ToString()) / ItemsPerPageDebit) > 0)
                        pagesnumberDebit++;

                    PageOfTotalTxtBoxDebit.Text = "1/" + pagesnumberDebit.ToString();
                    pageDebit(1);
                }
                else
                {
                    MessageBox.Show("Number should be less than 100");
                }
            }

        }


        //CREDIT FUNCTIONS
        //CREDIT FUNCTIONS
        private void pageCredit(int pagenumber)
        {

            if (CreditDGView.Rows.Count > 0)
            {
                int dgrow = 0;
                CreditDGView.Rows.Clear();
                //TestingFor Paging                
                for (RowNumCredit = (pagenumber - 1) * ItemsPerPageCredit; RowNumCredit < (pagenumber - 1) * ItemsPerPageCredit + (ItemsPerPageCredit); RowNumCredit++)
                {
                    if (CreditDGView.Rows.Count < ItemsPerPageCredit && RowNumCredit < aVendorPaymentTable.Rows.Count)
                    {
                        CreditDGView.Rows.Add();
                        CreditDGView.Rows[dgrow].Cells["PaymentNumber"].Value = aVendorPaymentTable.Rows[RowNumCredit]["PaymentNumber"].ToString();
                        for (int i = 0; i < aVendorTable.Rows.Count; i++)
                        {
                            if (int.Parse(aVendorTable.Rows[i]["ID"].ToString()) == int.Parse(aVendorPaymentTable.Rows[RowNumCredit]["VendorID"].ToString()))
                            {
                                CreditDGView.Rows[dgrow].Cells["VendorIDCredit"].Value = aVendorTable.Rows[i]["Name"].ToString();
                                break;
                            }
                        }
                        CreditDGView.Rows[dgrow].Cells["DateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Date"].ToString();
                        CreditDGView.Rows[dgrow].Cells["TimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Time"].ToString();
                        for (int i = 0; i < aUsersTable.Rows.Count; i++)
                        {
                            if (int.Parse(aUsersTable.Rows[i]["ID"].ToString()) == int.Parse(aVendorPaymentTable.Rows[RowNumCredit]["TellerID"].ToString()))
                            {
                                CreditDGView.Rows[dgrow].Cells["TellerCredit"].Value = aUsersTable.Rows[i]["UserName"].ToString();
                                break;
                            }
                        }
                        CreditDGView.Rows[dgrow].Cells["AmountCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Amount"].ToString();
                        CreditDGView.Rows[dgrow].Cells["OldAmountCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["OldVendorAccountAmount"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CommentsCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["Comments"].ToString();



                        if (aVendorPaymentTable.Rows[RowNumCredit]["IsChecked"].ToString() == "0")
                        {
                            CreditDGView.Rows[dgrow].Cells["IsCheckedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsChecked"].ToString();
                        }
                        else
                        {
                            CreditDGView.Rows[dgrow].Cells["IsCheckedCredit"].Value = "YES";
                        }

                        if (aVendorPaymentTable.Rows[RowNumCredit]["IsRevised"].ToString() == "0")
                        {
                            CreditDGView.Rows[dgrow].Cells["IsRevisedCredit"].Value = "NO";//aBillsDataTable.Rows[RowNum]["IsRevised"].ToString();
                        }
                        else
                        {
                            CreditDGView.Rows[dgrow].Cells["IsRevisedCredit"].Value = "YES";
                        }
                        CreditDGView.Rows[dgrow].Cells["CheckDateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckDate"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CheckTimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckTime"].ToString();
                        CreditDGView.Rows[dgrow].Cells["CheckedByCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["CheckedBy"].ToString();
                        CreditDGView.Rows[dgrow].Cells["ReviseDateCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["ReviseDate"].ToString();
                        CreditDGView.Rows[dgrow].Cells["ReviseTimeCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["ReviseTime"].ToString();
                        CreditDGView.Rows[dgrow].Cells["RevisedByCredit"].Value = aVendorPaymentTable.Rows[RowNumCredit]["RevisedBy"].ToString();
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
            ListDCBtn.PerformClick();
            if (ItemsPerPageTxtBoxCredit.Text != "" && CreditDGView.Rows.Count > 0)
            {
                ItemsPerPageCredit = int.Parse(ItemsPerPageTxtBoxCredit.Text.ToString());
                if (ItemsPerPageCredit < 100)
                {
                    pagesnumberCredit = (int)aVendorPaymentTable.Rows.Count / ItemsPerPageCredit;
                    if ((double.Parse(aVendorPaymentTable.Rows.Count.ToString()) / ItemsPerPageCredit - int.Parse(aVendorPaymentTable.Rows.Count.ToString()) / ItemsPerPageCredit) > 0)
                        pagesnumberCredit++;

                    PageOfTotalTxtBoxCredit.Text = "1/" + pagesnumberCredit.ToString();
                    pageCredit(1);
                }
                else
                {
                    MessageBox.Show("Number should be less than 100");
                }
            }

        }

        private void DebitDGView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditVouchers) == EventStatus.Permit)
            {
                if (e.RowIndex < 0)
                    return;
                DataTable aDataTableToPass = PurchaseVoucherDetailedMgmt.SelectVoucherByVoucherNumber(int.Parse(DebitDGView.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString()));
                EditVoucher aEditVoucher = new EditVoucher();
                aEditVoucher.AddDGView(aDataTableToPass);

                DataRow aGeneralVoucherDataRow = PurchaseVoucherGeneralMgmt.SelectGeneralVoucherByNumber(int.Parse(DebitDGView.Rows[e.RowIndex].Cells["VoucherNumber"].Value.ToString()));
                aEditVoucher.UpdateVariables(aGeneralVoucherDataRow);
               // aEditVoucher.MdiParent = Helper.Instance.ActiveMainWindow;
                aEditVoucher.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                double totalpayments = 0;
                if (double.TryParse(VendorAccountBalanceTxtBox.Text,out currentbalance ))
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

                if (currentbalance == (totalbillsprice - totalpayments))
                {
                    MessageBox.Show("الحساب مطابق");

                }
                else if (currentbalance > (totalbillsprice - totalpayments))
                {
                    MessageBox.Show("الحساب غير مطابق , يجب على التاجر دفع مبلغ    " + ((totalbillsprice - totalpayments)));
                }
                else
                {
                    MessageBox.Show("الحساب غير مطابق , يجب ان تدفع للتاجر  مبلغ    " + ((totalbillsprice - totalpayments)));
                }

            }


        }

        private void CreditDGView_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataRow aVendorPaymentToPass = VendorsPaymentsMgmt.SelectPaymentRow(int.Parse(CreditDGView.Rows[e.RowIndex].Cells["PaymentNumber"].Value.ToString()));
            EditVendorPayments aEditVendorPayment = new EditVendorPayments();
          //  aEditVendorPayment.MdiParent = Helper.Instance.ActiveMainWindow;
            aEditVendorPayment.Show();
            aEditVendorPayment.UpdateVariables(aVendorPaymentToPass);
        }

        private void TellerNameChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TellerNameChkBox.Checked)
            {
                TellerNameComboBox.Enabled = true;
            }
            else
            {
                TellerNameComboBox.Enabled = false;
            }


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


    }
}
