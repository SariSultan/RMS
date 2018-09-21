using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;
namespace Calcium_RMS.Reports
{
    public static class TaxReports
    {

        public static string TaxReport(string FilterDateFrom, string FilterDateTo, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {
           // string RCV = "<b>recieved</b>";
           // string REV = "<b>reversed</b>";
            List<string> aStringList = ReportsHelper.ImportReportHeader(0, 1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

            aStringList.Add(SharedVariables.Line_Solid_10px_Black);
            aStringList.Add("تقرير الضريبة ");
            aStringList.Add("<h2> Date From:   " + FilterDateFrom + "</h2>");
            aStringList.Add("<h2> Date To  :   " + FilterDateTo + "</h2>");
            aStringList.Add("<h2>Printed on:" + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
            aStringList.Add("<h2>Printed By: <b>" + SharedFunctions.ReturnLoggedUserName() + "</b></h2>");
            aStringList.Add(SharedVariables.Line_Solid_10px_Black);

            //end headers and foters
            List<DataTable> aDTList = new List<DataTable>();
            DataTable TaxLevelsDT = ItemTaxLevelMgmt.SelectAll();
            if (TaxLevelsDT == null)
            {
                return "ERROR";
            }

            foreach (DataRow aRow in TaxLevelsDT.Rows)
            {
                DataTable TitleTable = new DataTable();
                TitleTable.Columns.Add("TaxLevel [ " + aRow["Percentage"].ToString() + "](" + aRow["Description"].ToString() + " )");
                aDTList.Add(TitleTable);
                DataTable aTaxTable = new DataTable();
                if (TableBorder)
                {
                    aTaxTable.Columns.Add("[border=true1]Description");
                }
                else
                {
                    aTaxTable.Columns.Add("[border=false]Description");
                }
                aTaxTable.Columns.Add("Total JOD");
                aTaxTable.Columns.Add("Tax JOD");

                double TotalSold = 0;
                double TotalCost = 0;

                double TotalCustReturnsSold = 0;
                double TotalCustReturnsCost = 0;


                double TotalPurchase = 0;
                double TotalVendorReturnCost = 0;
                #region Sales
                DataRow aSaleRow = ReportsMgmt.SelectSalesTax(int.Parse(aRow["ID"].ToString()), FilterDateFrom, FilterDateTo);
                if (aSaleRow != null)
                {
                    if (double.TryParse(aSaleRow["TotalSold"].ToString(), out TotalSold))
                    {
                        TotalSold = Math.Round(TotalSold, 3);
                    }
                    if (double.TryParse(aSaleRow["TotalCost"].ToString(), out TotalCost))
                    {
                        TotalCost = Math.Round(TotalCost, 3);
                    }
                }
                int RowCnt = 0;


                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Total Sales";
                aTaxTable.Rows[RowCnt][1] = TotalSold.ToString();
                double TestParser = 0;
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalSold * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Total Sales COST";
                aTaxTable.Rows[RowCnt][1] = TotalCost.ToString();
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalCost * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                #endregion Sales

                #region CustomersReturns
                DataRow aCustReturnsRow = ReportsMgmt.SelectCustomersReturnsTax(int.Parse(aRow["ID"].ToString()), FilterDateFrom, FilterDateTo);
                if (aCustReturnsRow != null)
                {
                    if (double.TryParse(aCustReturnsRow["TotalSold"].ToString(), out TotalCustReturnsSold))
                    {
                        TotalCustReturnsSold = Math.Round(TotalCustReturnsSold, 3);
                    }
                    if (double.TryParse(aCustReturnsRow["TotalCost"].ToString(), out TotalCustReturnsCost))
                    {
                        TotalCustReturnsCost = Math.Round(TotalCustReturnsCost, 3);
                    }
                }
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Customers Returns";
                aTaxTable.Rows[RowCnt][1] = TotalCustReturnsSold.ToString();
                TestParser = 0;
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalCustReturnsSold * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Customers Returns COST";
                aTaxTable.Rows[RowCnt][1] = TotalCustReturnsCost.ToString();
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalCustReturnsCost * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                #endregion CustomersReturns

                #region Purchase
                DataRow aPurchaseRow = ReportsMgmt.SelectPurchaseTax(int.Parse(aRow["ID"].ToString()), FilterDateFrom, FilterDateTo);
                if (aPurchaseRow != null)
                {
                    if (double.TryParse(aPurchaseRow["TotalCost"].ToString(), out TotalPurchase))
                    {
                        TotalPurchase = Math.Round(TotalPurchase, 3);
                    }
                }
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Total Purchase COST";
                aTaxTable.Rows[RowCnt][1] = TotalPurchase.ToString();
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalPurchase * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                #endregion Purchase

                #region VendorReturns
                DataRow aVendorReturnsRow = ReportsMgmt.SelectVendorsReturnsTax(int.Parse(aRow["ID"].ToString()), FilterDateFrom, FilterDateTo);
                if (aVendorReturnsRow != null)
                {
                    if (double.TryParse(aVendorReturnsRow["TotalCost"].ToString(), out TotalVendorReturnCost))
                    {
                        TotalVendorReturnCost = Math.Round(TotalVendorReturnCost, 3);
                    }
                }
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Vendors Returns COST";
                aTaxTable.Rows[RowCnt][1] = TotalVendorReturnCost.ToString();
                TestParser = 0;
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalVendorReturnCost * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;                
                #endregion VendorReturns
                #region Disposal
                DataRow aDisposalRow = ReportsMgmt.SelectDisposalTax(int.Parse(aRow["ID"].ToString()), FilterDateFrom, FilterDateTo);
                if (aDisposalRow != null)
                {
                    if (double.TryParse(aDisposalRow["TotalCost"].ToString(), out TotalCost))
                    {
                        TotalCost = Math.Round(TotalCost, 3);
                    }
                }
                aTaxTable.Rows.Add();
                aTaxTable.Rows[RowCnt][0] = "Total Disposals";
                aTaxTable.Rows[RowCnt][1] = TotalCost.ToString();
                if (double.TryParse(aRow["Percentage"].ToString(), out TestParser))
                {
                    aTaxTable.Rows[RowCnt][2] = Math.Round(TotalCost * TestParser / 100, 3);
                }
                else
                {
                    aTaxTable.Rows[RowCnt][2] = 0;
                }
                RowCnt++;
                #endregion Disposal
                aDTList.Add(aTaxTable);
            }
            if (Preview)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", false, "", colored);
                return "True";
            }
            else if (ExportToPdf)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, false, false, true, ExportPath, false, "", colored);
                return "True";
            }
            else if (ExportToExcel)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, false, false, false, "", ExportToExcel, ExportPath, colored);
                return "True";
            }
            else if (PrintToThermal)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, true);
                return "True";
            }
            else
            {
                return "ERROR";
            }

        }
    }
}
