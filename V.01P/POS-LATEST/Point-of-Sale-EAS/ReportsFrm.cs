using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Reports;
using System.IO;
using System.Diagnostics;
using Calcium_RMS.Text;
using Calcium_RMS.Management;
namespace Calcium_RMS
{

    public partial class ReportsFrm : Form
    {
        private string ReportName = "";
        bool ExportToPdf = false;
        bool ExportToExcel = false;
        string ExportPath = "";
        bool PrintToThermal = false;
        bool OnlyExcel = false;

        public ReportsFrm()
        {
            InitializeComponent();
            webBrowser1.IsWebBrowserContextMenuEnabled = false;
            TranslateUI();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
        }

        private void ReportsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dBDataSet.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
                // TODO: This line of code loads data into the 'dBDataSet.Customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.dBDataSet.Customer);
                // TODO: This line of code loads data into the 'dBDataSet.Users' table. You can move, or remove it, as needed.
                this.usersTableAdapter.Fill(this.dBDataSet.Users);

                NumberOfItemsTxtBox.TextChanged += new EventHandler(Validators.TextBoxIntInputChange);
                DisableCustomerOptions();
                DisableDateOption();
                DisableTellerOption();
                DisableVendorOptions();
                DisableStatisticsOptions();
                DisableInventoryOptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[POS_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #region [OPTIONS]
        private void EnableTellerOption()
        {
            AllTellersChkBox.Enabled = true;
            TellerNameComboBox.Enabled = true;
            TellerGB.Show();
        }
        private void DisableTellerOption()
        {
            AllTellersChkBox.Enabled = false;
            TellerNameComboBox.Enabled = false;
            TellerGB.Hide();
        }

        private void EnableDateOption()
        {
            DateFrompicker.Enabled = true;
            DateToPicker.Enabled = true;
            DateLbl.Enabled = true;
            DateToLbl.Enabled = true;
        }
        private void DisableDateOption()
        {
            DateFrompicker.Enabled = false;
            DateToPicker.Enabled = false;
            DateLbl.Enabled = false;
            DateToLbl.Enabled = false;
        }

        private void EnableCustomerOptions()
        {
            CustomerNamechkBox.Enabled = true;
            Phone1ComboBox.Enabled = true;
            CustomerNamechkBox.Checked = false;

            CustomerPhoneLbl.Enabled = true;
            CustomerNameLbl.Enabled = true;
            CustomerOptionsGB.Show();
        }
        private void DisableCustomerOptions()
        {
            CustomerNamechkBox.Enabled = false;
            CustomerNameComboBox.Enabled = false;
            Phone1ComboBox.Enabled = false;
            CustomerPhoneLbl.Enabled = false;
            CustomerNameLbl.Enabled = false;
            CustomerOptionsGB.Hide();
        }


        private void EnableVendorOptions()
        {
            VendorNameComboBox.Enabled = true;
            VendorNameLbl.Enabled = true;
            VendorsOptionsGB.Show();
        }
        private void DisableVendorOptions()
        {
            VendorNameComboBox.Enabled = false;
            VendorNameLbl.Enabled = false;
            VendorsOptionsGB.Hide();
        }

        private void EnableStatisticsOptions()
        {
            OnlyExcel = true;
            StatisticsGB.Enabled = true;
            PrintToThermalBtn.Enabled = false;

            StatisticsGB.Show();
        }
        private void DisableStatisticsOptions()
        {
            OnlyExcel = false;
            StatisticsGB.Enabled = false;
            PrintToThermalBtn.Enabled = true;

            StatisticsGB.Hide();
        }

        private void EnableInventoryOptions()
        {
            DataTable aItemsTable = ItemsMgmt.SelectAllItems();
            ItemDescriptionComboBox.DataSource = aItemsTable;
            ItemDescriptionComboBox.DisplayMember = "Description";
            ItemDescriptionComboBox.ValueMember = "ID";
            ItemDescriptionComboBox.Enabled = true;
            InventoryOptionsGB.Visible = true;
            InventoryOptionsGB.Show();
            InventoryOptionsGB.BringToFront();
            EnableDateOption();
        }
        private void DisableInventoryOptions()
        {
            CustomerNamechkBox.Enabled = false;
            InventoryOptionsGB.Visible = false;
            InventoryOptionsGB.Hide();
        }
        #endregion [OPTIONS]
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "ListCustomersRepBtn")
            {
                DisableInventoryOptions();
                DisableDateOption();
                DisableTellerOption();
                DisableCustomerOptions();
                DisableVendorOptions();
                DisableStatisticsOptions();
                ReportName = "ListCustomers";
            }
            else if (treeView1.SelectedNode.Name == "ListCustBalanceBtn")
            {
                DisableInventoryOptions();
                DisableDateOption();
                DisableTellerOption();
                DisableCustomerOptions();
                DisableVendorOptions();
                DisableStatisticsOptions();
                ReportName = "ListCustomersBalnaces";
            }
            else if (treeView1.SelectedNode.Name == "CustomerBalanceStatementBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableCustomerOptions();
                DisableTellerOption();
                DisableVendorOptions();
                DisableStatisticsOptions();
                ReportName = "CustomerBalanceStatement";
            }
            else if (treeView1.SelectedNode.Name == "EndofPeriodReportsBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                DisableCustomerOptions();
                EnableTellerOption();
                DisableVendorOptions();
                DisableStatisticsOptions();
                ReportName = "EndOfPeriod";
            }
            else if (treeView1.SelectedNode.Name == "ListVendorsBtn")
            {
                DisableInventoryOptions();
                EnableVendorOptions();

                DisableDateOption();
                DisableCustomerOptions();
                DisableTellerOption();
                DisableStatisticsOptions();
                ReportName = "ListVendors";

            }
            else if (treeView1.SelectedNode.Name == "ListVendorsBalancesBtn")
            {
                DisableInventoryOptions();
                EnableVendorOptions();

                DisableDateOption();
                DisableCustomerOptions();
                DisableTellerOption();
                DisableStatisticsOptions();
                ReportName = "ListVendorsBalances";
            }
            else if (treeView1.SelectedNode.Name == "VendorBalanceStatementBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                DisableStatisticsOptions();
                ReportName = "VendorBalanceStatement";
            }
            else if (treeView1.SelectedNode.Name == "FastMoveItemBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableStatisticsOptions();

                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();

                ReportName = "FastMoveItem";
            }
            else if (treeView1.SelectedNode.Name == "SlowMoveItemsBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableStatisticsOptions();

                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();

                ReportName = "SlowMoveItems";
            }
            else if (treeView1.SelectedNode.Name == "HighestRevenuesBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableStatisticsOptions();

                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();

                ReportName = "HighestRevenues";
            }
            else if (treeView1.SelectedNode.Name == "LowestRevenuesBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableStatisticsOptions();

                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();

                ReportName = "LowestRevenues";
            }
            else if (treeView1.SelectedNode.Name == "RevenuesComparisonBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                EnableStatisticsOptions();

                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();

                ReportName = "RevenuesComparison";
            }
            else if (treeView1.SelectedNode.Name == "SalesPurchaseTaxBtn")
            {
                DisableInventoryOptions();
                EnableDateOption();
                DisableStatisticsOptions();
                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                ReportName = "SalePurchaseTax";
            }
            else if (treeView1.SelectedNode.Name == "PhysicalInvWorksheetBtn")
            {
                DisableInventoryOptions();
                DisableDateOption();
                DisableStatisticsOptions();
                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                ReportName = "PhysicalInvWorksheet";
            }
            else if (treeView1.SelectedNode.Name == "InvValSummaryBtn")
            {
                DisableInventoryOptions();
                DisableDateOption();
                DisableStatisticsOptions();
                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                ReportName = "InvValSummary";
            }
            else if (treeView1.SelectedNode.Name == "ItemStatusRepBtn")
            {
                DisableDateOption();
                DisableStatisticsOptions();
                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                EnableInventoryOptions();
                ReportName = "ItemStatusReport";
            }
            else if (treeView1.SelectedNode.Name == "AdjustInvBtn")
            {
                DisableDateOption();
                DisableStatisticsOptions();
                DisableVendorOptions();
                DisableCustomerOptions();
                DisableTellerOption();
                EnableInventoryOptions();
                ReportName = "AdjustInv";
            }
            else
            {
                ReportName = "";
            }
            // ReportNameLbl.Text = treeView1.SelectedNode.Text;
        }

        /// <summary>
        /// this is the most stupid function i ever wrote damn it 
        /// flyshhad el taree5 inni donkey august 27,2013
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [global::System.Reflection.Obfuscation(Feature = "disable-all")]
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportName == "")
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.ReportTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (ReportName == "ListCustomers")
                {
                    if (ExportToPdf)
                    {
                        CustomersReports.Instance.CustomerListReport(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        CustomersReports.Instance.CustomerListReport(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        CustomersReports.Instance.CustomerListReport(true, false, false, "", TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                    }
                    else
                    {
                        CustomersReports.Instance.CustomerListReport(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }
                else if (ReportName == "ListCustomersBalnaces")
                {
                    if (ExportToPdf)
                    {
                        CustomersReports.Instance.CutomerBalanceListReport(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        CustomersReports.Instance.CutomerBalanceListReport(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        CustomersReports.Instance.CutomerBalanceListReport(true, false, false, "", TableBorderChkBox.Checked);
                    }
                    else
                    {
                        CustomersReports.Instance.CutomerBalanceListReport(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }
                else if (ReportName == "CustomerBalanceStatement")
                {
                    int CustomerID = -1;
                    if (CustomerNamechkBox.Checked)
                    {
                        if (CustomerNameComboBox.SelectedValue != null)
                        {
                            CustomerID = int.Parse(CustomerNameComboBox.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.CustomerTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            CustomerNameComboBox.Focus();
                            return;
                        }
                    }
                    else
                    {
                        if (Phone1ComboBox.SelectedValue != null)
                        {
                            CustomerID = int.Parse(Phone1ComboBox.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.CustomerTxt + " " + MsgTxt.PhoneTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            Phone1ComboBox.Focus();
                            return;
                        }
                    }

                    string retval = "";
                    if (ExportToPdf)
                    {
                        retval = CustomersReports.Instance.CustomerBalanceStatement(CustomerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = CustomersReports.Instance.CustomerBalanceStatement(CustomerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = CustomersReports.Instance.CustomerBalanceStatement(CustomerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, true, false, false, "", ColorsChkBox.Checked);
                    }
                    else
                    {
                        retval = CustomersReports.Instance.CustomerBalanceStatement(CustomerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval != "ERROR")
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;

                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.CustomerTxt + " " + MsgTxt.DoNotHaveAccountTxt + " " + MsgTxt.OrTxt + " " + MsgTxt.NoDataTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        webBrowser1.Navigate("about:blank");
                    }

                } // END OF CUSTOMER BALANCE STATEMENT REPORT
                else if (ReportName == "EndOfPeriod")
                {
                    int TellerID = -1;
                    string TellerName = "ALL";
                    if (AllTellersChkBox.Checked == false)
                    {
                        if (TellerNameComboBox.SelectedValue != null)
                        {
                            TellerID = int.Parse(TellerNameComboBox.SelectedValue.ToString());
                            TellerName = TellerNameComboBox.Text;
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.UserTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            return;
                        }
                    }
                    string retval = "";
                    if (ExportToPdf)
                    {
                        retval = BillsReports.Instance.EndOfPeriodReport(TellerName, TellerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = BillsReports.Instance.EndOfPeriodReport(TellerName, TellerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = BillsReports.Instance.EndOfPeriodReport(TellerName, TellerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, true);
                    }
                    else //view
                    {
                        retval = BillsReports.Instance.EndOfPeriodReport(TellerName, TellerID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval != "ERROR")
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        webBrowser1.Navigate("about:blank");
                    }
                }// END OF ENDOFPERIOD REPORT
                else if (ReportName == "ListVendors")//ListVendors
                {
                    if (ExportToPdf)
                    {
                        VendorsReports.Instance.VendorsListReport(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        VendorsReports.Instance.VendorsListReport(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        VendorsReports.Instance.VendorsListReport(true, false, false, "", TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                    }
                    else
                    {
                        VendorsReports.Instance.VendorsListReport(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }//end LIST VENDORS REPORT
                else if (ReportName == "ListVendorsBalances")//LIST VENDORS BALANCES
                {
                    if (ExportToPdf)
                    {
                        VendorsReports.Instance.VendorsBalanceListReport(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        VendorsReports.Instance.VendorsBalanceListReport(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        VendorsReports.Instance.VendorsBalanceListReport(true, false, false, "", TableBorderChkBox.Checked);
                    }
                    else
                    {
                        VendorsReports.Instance.VendorsBalanceListReport(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }//END LIST VENDORS BALANCES
                else if (ReportName == "VendorBalanceStatement")
                {
                    int VendorID = -1;
                    if (VendorNameComboBox.SelectedValue != null)
                    {
                        VendorID = int.Parse(VendorNameComboBox.SelectedValue.ToString());
                    }
                    else
                    {

                        MessageBox.Show(MsgTxt.PleaseSelectTxt + " " + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        VendorNameComboBox.Focus();
                        return;
                    }

                    string retval = "";
                    if (ExportToPdf)
                    {
                        retval = VendorsReports.Instance.VendorBalanceStatement(VendorID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = VendorsReports.Instance.VendorBalanceStatement(VendorID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = VendorsReports.Instance.VendorBalanceStatement(VendorID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, true);
                    }
                    else
                    {
                        retval = VendorsReports.Instance.VendorBalanceStatement(VendorID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval != "No-Data")
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt + "\n" + MsgTxt.PleaseAddAllRequiredFields + "\n1)" + MsgTxt.DateFromTxt +
                        "\n2)" + MsgTxt.DateToTxt + "\n3)" + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // MessageBox.Show("No-Data \n Please Check \n 1) Date From Option is Correct \n 2)Date To Option is Correct \n 3) Vendor Name Option ");
                        webBrowser1.Navigate("about:blank");
                    }

                } // END OF Vendor BALANCE STATEMENT REPORT
                else if (ReportName == "FastMoveItem") //FAST MOVE ITEMS
                {
                    string retval = "";
                    int NumberOfItems = 10;
                    int.TryParse(NumberOfItemsTxtBox.Text, out NumberOfItems);
                    if (NumberOfItems < 0)
                    {
                        NumberOfItems = (-1 * NumberOfItems);
                    }
                    if (NumberOfItems == 0)
                    {
                        NumberOfItems = 10;
                    }

                    if (ExportToExcel)
                    {
                        retval = Statistics.Instance.FastMoveItems(true, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), true, ExportPath);//, TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath);
                    }
                    else
                    {
                        retval = Statistics.Instance.FastMoveItems(true, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString());//, TableBorderChkBox.Checked,true, ThermalPrinterChkBox.Checked, false, false, ExportPath);
                    }

                    if (retval != "ERROR" && retval != "EMPTY")
                    {
                        if (ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.Navigate(ReportsHelper.TempOutputPath);
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt + "\n" + MsgTxt.PleaseAddAllRequiredFields + "\n1)" + MsgTxt.DateFromTxt +
                        "\n2)" + MsgTxt.DateToTxt + "\n3)" + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        webBrowser1.Navigate("about:blank");
                    }
                } //END OF FAST MOVE ITEMS
                else if (ReportName == "SlowMoveItems") //FAST MOVE ITEMS
                {
                    string retval = "";
                    int NumberOfItems = 10;
                    int.TryParse(NumberOfItemsTxtBox.Text, out NumberOfItems);
                    if (NumberOfItems < 0)
                    {
                        NumberOfItems = (-1 * NumberOfItems);
                    }
                    if (NumberOfItems == 0)
                    {
                        NumberOfItems = 10;
                    }

                    if (ExportToExcel)
                    {
                        retval = Statistics.Instance.FastMoveItems(false, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), true, ExportPath);//, TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath);

                    }
                    else
                    {
                        retval = Statistics.Instance.FastMoveItems(false, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString());//, TableBorderChkBox.Checked,true, ThermalPrinterChkBox.Checked, false, false, ExportPath);
                    }

                    if (retval != "ERROR" && retval != "EMPTY")
                    {
                        if (ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.Navigate(ReportsHelper.TempOutputPath);
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt + "\n" + MsgTxt.PleaseAddAllRequiredFields + "\n1)" + MsgTxt.DateFromTxt +
                         "\n2)" + MsgTxt.DateToTxt + "\n3)" + MsgTxt.VendorTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        webBrowser1.Navigate("about:blank");
                    }
                } //END OFFAST MOVE ITEMS
                else if (ReportName == "HighestRevenues" || ReportName == "LowestRevenues") //START HIGHEST REVENUES
                {
                    bool RepFlag = true;
                    if (ReportName == "LowestRevenues")
                    {
                        RepFlag = false;
                    }
                    string retval = "";
                    int NumberOfItems = 10;
                    int.TryParse(NumberOfItemsTxtBox.Text, out NumberOfItems);
                    if (NumberOfItems < 0)
                    {
                        NumberOfItems = (-1 * NumberOfItems);
                    }
                    if (NumberOfItems == 0)
                    {
                        NumberOfItems = 10;
                    }

                    if (ExportToExcel)
                    {
                        retval = Statistics.Instance.HighestRevenuesItems(RepFlag, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), true, ExportPath);//, TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath);

                    }
                    else
                    {
                        retval = Statistics.Instance.HighestRevenuesItems(RepFlag, NumberOfItems, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString());//, TableBorderChkBox.Checked,true, ThermalPrinterChkBox.Checked, false, false, ExportPath);
                    }

                    if (retval != "ERROR" && retval != "EMPTY")
                    {
                        if (ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.Navigate(ReportsHelper.TempOutputPath);
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt + "\n" + MsgTxt.PleaseAddAllRequiredFields + "\n1)" + MsgTxt.DateFromTxt +
                        "\n2)" + MsgTxt.DateToTxt + "\n3)" + MsgTxt.NumberOfItemsPerPageTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        webBrowser1.Navigate("about:blank");
                    }
                } //END HIGHEST REVENUES
                else if (ReportName == "RevenuesComparison") //REVENUES COMPARISON
                {
                    string retval = "";

                    int BYDDMMYYYY = RevenuesComparisonComboBox.SelectedIndex;
                    if (BYDDMMYYYY == -1)
                    {
                        RevenuesComparisonComboBox.SelectedIndex = 0;
                        BYDDMMYYYY = 0;
                    }
                    if (ExportToExcel)
                    {
                        retval = Statistics.Instance.RevenuesComparison(BYDDMMYYYY, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), true, ExportPath);//, TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath);
                    }
                    else
                    {
                        retval = Statistics.Instance.RevenuesComparison(BYDDMMYYYY, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString());//, TableBorderChkBox.Checked,true, ThermalPrinterChkBox.Checked, false, false, ExportPath);
                    }

                    if (retval != "ERROR" && retval != "EMPTY")
                    {
                        if (ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }

                        webBrowser1.Navigate(ReportsHelper.TempOutputPath);
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NoDataTxt + "\n" + MsgTxt.PleaseAddAllRequiredFields + "\n1)" + MsgTxt.DateFromTxt +
                        "\n2)" + MsgTxt.DateToTxt + "\n3)" + MsgTxt.DesiredListTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        webBrowser1.Navigate("about:blank");
                    }
                } //END RevenuesComparison 
                #region SalePurchaseTax
                else if (ReportName == "SalePurchaseTax") //SalePurchaseTax
                {
                    //  DateTime __StartTime = DateTime.Now;
                    string retval = "";
                    if (ExportToPdf)
                    {
                        retval = TaxReports.TaxReport(DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = TaxReports.TaxReport(DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, ThermalPrinterChkBox.Checked, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = TaxReports.TaxReport(DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, true);
                    }
                    else //view
                    {
                        retval = TaxReports.TaxReport(DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval != "ERROR")
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;

                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        webBrowser1.Navigate("about:blank");
                    }
                    //TimeSpan __TimeSpan = DateTime.Now.Subtract(__StartTime);
                    //string __ET = string.Format("{0:00}.{1:00}.{2:00}:{3:000}", __TimeSpan.Hours, __TimeSpan.Minutes, __TimeSpan.Seconds, __TimeSpan.Milliseconds);
                    //MessageBox.Show("ET=" + __ET);
                }// END OF SalePurchaseTax
                #endregion SalePurchaseTax
                #region INVENTORY

                else if (ReportName == "PhysicalInvWorksheet") //Physical Worksheet   
                {
                    if (ExportToPdf)
                    {
                        ItemsReports.Instance.PrintPhysicalItemsStatus(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);

                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        ItemsReports.Instance.PrintPhysicalItemsStatus(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        ItemsReports.Instance.PrintPhysicalItemsStatus(true, false, false, "", TableBorderChkBox.Checked);
                    }
                    else
                    {
                        ItemsReports.Instance.PrintPhysicalItemsStatus(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }//END PHYSICAL WORKSHEET
                else if (ReportName == "InvValSummary") //INVENTORY VALUATION SUMMARY 
                {
                    if (ExportToPdf)
                    {
                        ItemsReports.Instance.InvValuationSummaryStatus(ThermalPrinterChkBox.Checked, true, false, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);

                        Process.Start(ExportPath);
                    }
                    else if (ExportToExcel)
                    {
                        ItemsReports.Instance.InvValuationSummaryStatus(ThermalPrinterChkBox.Checked, false, true, ExportPath, TableBorderChkBox.Checked, false, ColorsChkBox.Checked);
                        Process.Start(ExportPath);
                    }
                    else if (PrintToThermal)
                    {
                        ItemsReports.Instance.InvValuationSummaryStatus(true, false, false, "", TableBorderChkBox.Checked);
                    }
                    else
                    {
                        ItemsReports.Instance.InvValuationSummaryStatus(ThermalPrinterChkBox.Checked, false, false, "", TableBorderChkBox.Checked, true, ColorsChkBox.Checked);
                    }
                    webBrowser1.DocumentText = ReportsHelper.__HTMLPage;
                }//END INVENTORY VALUATION SUMMARY
                else if (ReportName == "ItemStatusReport")
                {
                    if ( ItemDescriptionComboBox.SelectedValue==null)
                    {
                        return;
                    }
                    int aItemID =int.Parse( ItemDescriptionComboBox.SelectedValue.ToString());

                    bool retval;
                    if (ExportToPdf)
                    {
                        retval = InventoryReports.ItemStatusReport(aItemID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, false, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = InventoryReports.ItemStatusReport(aItemID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, false, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = InventoryReports.ItemStatusReport(aItemID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, false, true, false, false, "", ColorsChkBox.Checked);
                    }
                    else
                    {
                        retval = InventoryReports.ItemStatusReport(aItemID, DateFrompicker.Value.ToShortDateString(), DateToPicker.Value.ToShortDateString(), TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval )
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;

                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.CustomerTxt + " " + MsgTxt.DoNotHaveAccountTxt + " " + MsgTxt.OrTxt + " " + MsgTxt.NoDataTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        webBrowser1.Navigate("about:blank");
                    }

                } //ITEM STATUS SUMMARY
                else if (ReportName == "AdjustInv") //ADJUST INVENTORY
                {
                    int ReferenceNumber = 0;
                    if (!int.TryParse(RefNumTxtBox.Text, out ReferenceNumber))
                    {
                        MessageBox.Show("Please Select Reference Number You Want To View",MsgTxt.InformationCaption,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }

                    bool retval;
                    if (ExportToPdf)
                    {
                        retval = InventoryReports.InventoryAdjustReport(ReferenceNumber, TableBorderChkBox.Checked, false, false, true, false, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (ExportToExcel)
                    {
                        retval = InventoryReports.InventoryAdjustReport(ReferenceNumber,  TableBorderChkBox.Checked, false, false, false, true, ExportPath, ColorsChkBox.Checked);
                    }
                    else if (PrintToThermal)
                    {
                        retval = InventoryReports.InventoryAdjustReport(ReferenceNumber,  TableBorderChkBox.Checked, false, true, false, false, "", ColorsChkBox.Checked);
                    }
                    else
                    {
                        retval = InventoryReports.InventoryAdjustReport(ReferenceNumber,  TableBorderChkBox.Checked, true, ThermalPrinterChkBox.Checked, false, false, "", ColorsChkBox.Checked);
                    }

                    if (retval )
                    {
                        if (ExportToPdf || ExportToExcel)
                        {
                            Process.Start(ExportPath);
                        }
                        webBrowser1.DocumentText = ReportsHelper.__HTMLPage;

                    }
                    else
                    {
                        MessageBox.Show( MsgTxt.NoDataTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        webBrowser1.Navigate("about:blank");
                    }

                } //ADJUST INVENTORY
                

                #endregion INVENTORY
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ViewBtn_Click] \n Exception: \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string SaveAsPath = "";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (OnlyExcel)
                {
                    saveFileDialog1.Filter = "Excel Sheet|*.xls";
                }
                else
                {
                    saveFileDialog1.Filter = "PDF file|*.pdf|Excel Sheet|*.xls";
                }
                saveFileDialog1.Title = "Save Report (A4)";
                saveFileDialog1.FileName = treeView1.SelectedNode.Text + DateTime.Now.ToShortDateString();
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"/", "-");
                saveFileDialog1.FileName = saveFileDialog1.FileName.ToString().Replace(@"\\", "-");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SaveAsPath = saveFileDialog1.FileName;
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            if (OnlyExcel)
                            {
                                ExportToExcel = true;
                                ExportPath = SaveAsPath;
                                ViewBtn.PerformClick();
                                ExportToExcel = false;
                            }
                            else
                            {
                                ExportToPdf = true;
                                ExportPath = SaveAsPath;
                                ViewBtn.PerformClick();
                                ExportToPdf = false;
                            }
                            break;
                        case 2: //THIS IS ONLY EXCEL
                            ExportToExcel = true;
                            ExportPath = SaveAsPath;
                            ViewBtn.PerformClick();
                            ExportToExcel = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [SaveAsBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintToThermalBtn_Click(object sender, EventArgs e)
        {
            PrintToThermal = true;
            ViewBtn.PerformClick();
            PrintToThermal = false;
        }

        private void CustomerNamechkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomerNamechkBox.Checked)
            {
                CustomerNameComboBox.Enabled = true;
                Phone1ComboBox.Enabled = false;
            }
            else
            {
                CustomerNameComboBox.Enabled = false;
                Phone1ComboBox.Enabled = true;
            }
        }

        private void AllTellersChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AllTellersChkBox.Checked)
            {
                TellerNameComboBox.Enabled = false;
            }
            else
            {
                TellerNameComboBox.Enabled = true;
            }
        }

        private void RTLChkBox_CheckedChanged(object sender, EventArgs e)
        {
            ReportsHelper.RTL = RTLChkBox.Checked;
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.ReportsFormName;
                AllTellersChkBox.Text = UiText.ReprtAllTellersChkBox;
                ColorsChkBox.Text = UiText.ReprtColorsChkBox;
                ComparisonLbl.Text = UiText.ReprtComparisonLbl;
                CustomerNamechkBox.Text = UiText.ReprtCustomerNamechkBox;
                CustomerNameLbl.Text = UiText.ReprtCustomerNameLbl;
                CustomerOptionsGB.Text = UiText.ReprtCustomerOptionsGB;
                CustomerPhoneLbl.Text = UiText.ReprtCustomerPhoneLbl;
                DateLbl.Text = UiText.ReprtDateLbl;
                DateToLbl.Text = UiText.ReprtDateToLbl;
                LayoutOptions.Text = UiText.ReprtLayoutOptions;
                NumberOfItemsLbl.Text = UiText.ReprtNumberOfItemsLbl;
                PrintToThermalBtn.Text = UiText.ReprtPrintToThermalBtn;
                //ReportNameLbl.Text = UiText.ReprtReportNameLbl;
                RTLChkBox.Text = UiText.ReprtRTLChkBox;
                SaveAsBtn.Text = UiText.ReprtSaveAsBtn;
                StatisticsGB.Text = UiText.ReprtStatisticsGB;
                TableBorderChkBox.Text = UiText.ReprtTableBorderChkBox;
                TellerGB.Text = UiText.ReprtTellerGB;
                ThermalPrinterChkBox.Text = UiText.ReprtThermalPrinterChkBox;
                VendorNameLbl.Text = UiText.ReprtVendorNameLbl;
                VendorsOptionsGB.Text = UiText.ReprtVendorsOptionsGB;
                ViewBtn.Text = UiText.ReprtViewBtn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
    }
}
