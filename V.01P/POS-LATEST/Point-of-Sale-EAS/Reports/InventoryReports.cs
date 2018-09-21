using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;
using Calcium_RMS.Text;

namespace Calcium_RMS.Reports
{
    public static class InventoryReports
    {
        public static bool ItemStatusReport(int ItemID, string DateFrom, string DateTo, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {
            if (!ItemsMgmt.IsItemExistByID(ItemID))
            {
                return false;
            }
            string EmptyNoborderRow = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
            List<DataTable> aDTlist = new List<DataTable>();
            DataTable aTable1 = new DataTable();
            if (TableBorder)
            {
                aTable1.Columns.Add("[Border=true1]" + "Barcode");
            }
            else
            {
                aTable1.Columns.Add("Barcode");
            }
            aTable1.Columns.Add("Description");
            aTable1.Columns.Add("Type");
            aTable1.Columns.Add("Qty");

            DataRow aItemRow = ItemsMgmt.SelectItemRowByID(ItemID);
            bool AddEmpty = false;
            double NetTotal = 0.00;
            DataRow __PoorRow;

            double OnHandQty = double.Parse(aItemRow["OnHandQty"].ToString());
            double TotalBeforeBills = BillDetailedMgmt.SelectAllSoldQty(ItemID, DateFrom, DateTo, 0, true);
            double TotalBeforeAdjust = AdjustInventoryDetailedMgmt.SelectAllAdjustQty(ItemID, DateFrom, DateTo, -1, true);
            double TotalBeforeDispose = DisposalDetailedMgmt.SelectAllDisposedQty(ItemID, DateFrom, DateTo, 0, true);
            double TotalBeforePurchase = PurchaseVoucherDetailedMgmt.SelectAllPurchaseQty(ItemID, DateFrom, DateTo, 0, true);
            double TotalBeforeCusRet = ReturnItemsCustDetailedMGMT.SelectAllReturnedQty(ItemID, DateFrom, DateTo, 0, true);
            double TotalBeforeVenReturns = ReturnItemsVendorDetailedMgmt.SelectAllReturnedQty(ItemID, DateFrom, DateTo, 0, true);

            double BegginingQty = OnHandQty - TotalBeforeBills + TotalBeforeAdjust - TotalBeforeDispose + TotalBeforePurchase + TotalBeforeCusRet - TotalBeforeVenReturns;
            if (BegginingQty != 0)
            {
                NetTotal += BegginingQty;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Beginning Qty";
                __PoorRow[3] = Math.Round(BegginingQty, 3);
                AddEmpty = true;
            }

            double TotalBills = BillDetailedMgmt.SelectAllSoldQty(ItemID, DateFrom, DateTo, -1);
            double TotalReversedBills = BillDetailedMgmt.SelectAllSoldQty(ItemID, DateFrom, DateTo, 1);
            
            if (TotalBills != 0)
            {
                NetTotal -= TotalBills;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Sales";
                __PoorRow[3] = Math.Round(0.00-TotalBills, 3);
                AddEmpty = true;
            }
            if (TotalReversedBills != 0)
            {
                NetTotal += TotalReversedBills;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Reversed Sales";
                __PoorRow[3] = Math.Round(( TotalReversedBills), 3);
                AddEmpty = true;
            }

            double TotalAdjust = AdjustInventoryDetailedMgmt.SelectAllAdjustQty(ItemID, DateFrom, DateTo, -1);

            if (TotalAdjust != 0)
            {
                NetTotal += TotalAdjust;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Inventory Adjust";
                __PoorRow[3] = Math.Round(TotalAdjust, 3);
                AddEmpty = true;
            }
            double TotalDisposed = DisposalDetailedMgmt.SelectAllDisposedQty(ItemID, DateFrom, DateTo, -1);
            double TotalReversedDisposed = DisposalDetailedMgmt.SelectAllDisposedQty(ItemID, DateFrom, DateTo, 1);

            if (TotalDisposed != 0)
            {
                NetTotal -= TotalDisposed;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Disposed";
                __PoorRow[3] = Math.Round(0.00 - TotalDisposed, 3);
                AddEmpty = true;
            }
            if (TotalReversedDisposed != 0)
            {
                NetTotal += TotalReversedDisposed;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Reversed Disposals";
                __PoorRow[3] = Math.Round((0.00 - TotalReversedDisposed), 3);
                AddEmpty = true;
            }
            double TotalPurchase = PurchaseVoucherDetailedMgmt.SelectAllPurchaseQty(ItemID, DateFrom, DateTo, -1);
            double TotalReversedPurchase = PurchaseVoucherDetailedMgmt.SelectAllPurchaseQty(ItemID, DateFrom, DateTo, 1);

            if (TotalPurchase != 0)
            {
                NetTotal += TotalPurchase;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Purchase";
                __PoorRow[3] = Math.Round((TotalPurchase), 3);
                AddEmpty = true;
            }
            if (TotalReversedPurchase != 0)
            {
                NetTotal -= TotalReversedPurchase;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Reversed Purchase";
                __PoorRow[3] = Math.Round((0.00 - TotalReversedPurchase), 3);
                AddEmpty = true;
            }
            double TotalCustomerReturns = ReturnItemsCustDetailedMGMT.SelectAllReturnedQty(ItemID, DateFrom, DateTo, -1);
            double TotalReversedCustomerReturns = ReturnItemsCustDetailedMGMT.SelectAllReturnedQty(ItemID, DateFrom, DateTo, 1);

            if (TotalCustomerReturns != 0)
            {
                NetTotal += TotalCustomerReturns;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Customer Returns";
                __PoorRow[3] = Math.Round((TotalCustomerReturns), 3);
                AddEmpty = true;
            }
            if (TotalReversedCustomerReturns != 0)
            {
                NetTotal -= TotalReversedCustomerReturns;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Reversed Customer Returns";
                __PoorRow[3] = Math.Round((0.00 - TotalReversedCustomerReturns), 3);
                AddEmpty = true;
            }
            double TotalVendorReturns = ReturnItemsVendorDetailedMgmt.SelectAllReturnedQty(ItemID, DateFrom, DateTo, -1);
            double TotalReversedVendorReturns = ReturnItemsVendorDetailedMgmt.SelectAllReturnedQty(ItemID, DateFrom, DateTo, 1);
            if (TotalVendorReturns != 0)
            {
                NetTotal -= TotalVendorReturns;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Vendors Returns";
                __PoorRow[3] = Math.Round((0.00 - TotalVendorReturns), 3);
                AddEmpty = true;
            }
            if (TotalReversedVendorReturns != 0)
            {
                NetTotal += TotalReversedVendorReturns;
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = "Total Reversed Vendors Returns";
                __PoorRow[3] = Math.Round((TotalReversedVendorReturns), 3);
                AddEmpty = true;
            }

            if (NetTotal != 0)
            {
                __PoorRow = aTable1.Rows.Add();
                __PoorRow[0] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Barcode"].ToString();
                __PoorRow[1] = (AddEmpty) ? EmptyNoborderRow : aItemRow["Description"].ToString();
                __PoorRow[2] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + "TOTAL" + ReportsHelper.MANUAL_TD_END;
                __PoorRow[3] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + Math.Round((NetTotal), 3) + ReportsHelper.MANUAL_TD_END;
                AddEmpty = true;
            }
            aDTlist.Add(aTable1);

            List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

            aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
            aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.ItemSymmaryStatusRepName + " </font>");
            aHeaderList.Add("<b><font size=4>" + Text.ReportsText.DateRepTxt + ": " + DateTime.Now.ToShortDateString() + " </font>");
            aHeaderList.Add("<b><font size=4>" + Text.ReportsText.FromRepTxt + ": " + DateFrom + " " + Text.ReportsText.ToRepTxt + ": " + DateTo + " </font>");
            aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);

            if (Preview)
            {
                PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", false, "", colored);
                return true;
            }

            else if (ExportToPdf)
            {
                PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, true, ExportPath, false, "", colored);
                return true;
            }
            else if (ExportToExcel)
            {
                PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", true, ExportPath, colored);
                return true;
            }
            else if (PrintToThermal)
            {
                PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true, false, "", false, "", colored);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool InventoryAdjustReport(int ReferenceNumber, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {

            bool GenerateReportIs100Matched = false;
            DataTable InventoryGeneral = AdjustInventoryGeneralMgmt.SelectAllAdjustsGeneral(ReferenceNumber, string.Empty, string.Empty);
            if (InventoryGeneral == null) { return false; }
            if (InventoryGeneral.Rows.Count == 0) { return false; }
            DataTable InventoryDetailedTable = AdjustInventoryDetailedMgmt.SelectAllAdjustsDetailed(ReferenceNumber, -1);
            if (InventoryDetailedTable == null) { GenerateReportIs100Matched = true; }
            if (InventoryDetailedTable.Rows.Count == 0) { GenerateReportIs100Matched = true; }

            List<DataTable> aDataTableList = new List<DataTable>();
            DataTable aDataTable1 = new DataTable();
            aDataTable1.Columns.Add("[border=true1]" + "<th width=15%>" + ReportsText.BarcodeRepTxt);
            aDataTable1.Columns.Add("<th width=20%>" + ReportsText.DescriptionRepTxt);
            aDataTable1.Columns.Add("<th width=9%>" + ReportsText.AvgCostRepTxt);
            aDataTable1.Columns.Add("<th width=9%>" + ReportsText.AvaQtyRepTxt);
            aDataTable1.Columns.Add(ReportsText.PhysicalCountRepTxt);
            aDataTable1.Columns.Add(ReportsText.DifferencesRepTxt);
            aDataTable1.Columns.Add(ReportsText.DifferenceValueRepTxt);

            double TotalPositive = 0.00, TotalNegative = 0.00, ParsingTester = 0.00; ;
            DataTable ItemsTable = ItemsMgmt.SelectAllItems();

            foreach (DataRow aRow in InventoryDetailedTable.Rows)
            {
                if (double.Parse(aRow["DifferenceQty"].ToString()) == 0)
                {
                    continue;
                }
                DataRow aToAddRow = aDataTable1.Rows.Add();
                aToAddRow[0] = ReportsHelper.FindData(ItemsTable, "ID", "Barcode", aRow["ItemID"].ToString());
                aToAddRow[1] = ReportsHelper.FindData(ItemsTable, "ID", "Description", aRow["ItemID"].ToString());
                aToAddRow[2] = Math.Round(double.Parse(ReportsHelper.FindData(ItemsTable, "ID", "AvgUnitCost", aRow["ItemID"].ToString())), 3);
                aToAddRow[3] = Math.Round(double.Parse(aRow["OldQty"].ToString()), 3);
                aToAddRow[4] = aRow["NewQty"];
                aToAddRow[5] = aRow["DifferenceQty"];
                ParsingTester = double.Parse(aRow["DifferenceValue"].ToString());
                aToAddRow[6] = ParsingTester;
                if (ParsingTester > 0)
                {
                    TotalPositive += ParsingTester;
                }
                else
                {
                    TotalNegative += ParsingTester;
                }
            }

            if (aDataTable1.Rows.Count == 0 || GenerateReportIs100Matched)
            {
                DataTable aEmptyTable = new DataTable();
                aEmptyTable.Columns.Add("INVENTORY STOCK AVAILABLE QTY MATCHES 100% THE PHYSICAL COUNT");
                aDataTableList.Add(aEmptyTable);
            }
            else
            {

                aDataTableList.Add(aDataTable1);
                DataRow NetRow = aDataTable1.Rows.Add();
                string EmptyNoborderRow = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                NetRow[0] = EmptyNoborderRow;
                NetRow[1] = EmptyNoborderRow;
                NetRow[2] = EmptyNoborderRow;
                NetRow[3] = EmptyNoborderRow;
                NetRow[4] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.TotalRepTxt + ReportsHelper.MANUAL_TD_END;
                NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.PosAdjValueRepTxt + ReportsHelper.MANUAL_TD_END;
                NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + TotalPositive + ReportsHelper.MANUAL_TD_END;
                NetRow = aDataTable1.Rows.Add();
                NetRow[0] = EmptyNoborderRow;
                NetRow[1] = EmptyNoborderRow;
                NetRow[2] = EmptyNoborderRow;
                NetRow[3] = EmptyNoborderRow;
                NetRow[4] = EmptyNoborderRow;
                NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + ReportsText.NegAdjValueRepTxt + ReportsHelper.MANUAL_TD_END;
                NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + TotalNegative + ReportsHelper.MANUAL_TD_END;
                NetRow = aDataTable1.Rows.Add();
                NetRow[0] = EmptyNoborderRow;
                NetRow[1] = EmptyNoborderRow;
                NetRow[2] = EmptyNoborderRow;
                NetRow[3] = EmptyNoborderRow;
                NetRow[4] = EmptyNoborderRow;
                NetRow[5] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + "<b>" + ReportsText.NetValueRepTxt + "<b>" + ReportsHelper.MANUAL_TD_END;
                NetRow[6] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.UNDERLINE + ReportsHelper.NOBORDER + ReportsHelper.MANUAL_TD_OPTION_END + (TotalNegative + TotalPositive) + ReportsHelper.MANUAL_TD_END;

            }
            List<string> aStringList = ReportsHelper.ImportReportHeader(0, 1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

            aStringList.Add(SharedVariables.Line_Solid_10px_Black);
            aStringList.Add(ReportsNames.InventoryStockAdjustRepName);
            aStringList.Add("<h2>" + "Added On" + " " + InventoryGeneral.Rows[0]["Date"].ToString() + "</h2>");
            aStringList.Add("<h2> " + "Added By" + ":&nbsp;&nbsp;" + UsersMgmt.SelectUserNameByID(int.Parse(InventoryGeneral.Rows[0]["TellerID"].ToString())) + "</h2>");

            aStringList.Add("<h2>" + ReceiptText.RctTxtReprintedOn + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
            aStringList.Add("<h2> " + ReceiptText.RctTxtReprintedBy + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");

            aStringList.Add(ReceiptText.RctTxtInvoiceNum + ":&nbsp; " + ReferenceNumber);
            aStringList.Add(SharedVariables.Line_Solid_10px_Black);

            if (Preview)
            {
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", false, "", colored);
                return true;
            }

            else if (ExportToPdf)
            {
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, true, ExportPath, false, "", colored);
                return true;
            }
            else if (ExportToExcel)
            {
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", true, ExportPath, colored);
                return true;
            }
            else if (PrintToThermal)
            {
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true, false, "", false, "", colored);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
