using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;

namespace Calcium_RMS.Reports
{
    public class ItemsReports
    {
        static ItemsReports instance;
        public static ItemsReports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ItemsReports();
                }
                return instance;
            }
        }

        public bool PrintItemsList(bool RenderPoint, bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            try
            {
                List<DataTable> aDTlist = new List<DataTable>();
                DataTable ItemsDatatable = null;

                if (RenderPoint)
                {
                    ItemsDatatable = ItemsMgmt.RenderPoint();
                }
                else
                {
                    ItemsDatatable = ItemsMgmt.SelectAllItems();
                }
                if (ItemsDatatable == null)
                {
                    return false;
                }
                else
                {
                    if (ItemsDatatable.Rows.Count == 0)
                    {
                        return false;
                    }
                }

                DataTable ItemCategoryDataTable = ItemCategoryMgmt.SelectAll();
                DataTable VendorsDataTable = VendorsMgmt.SelectAllVendors();
                DataTable ItemsTypeDataTalbe = ItemTypeMgmt.SelectAll();
                int itemcategoryrowsnumber = ItemCategoryDataTable.Rows.Count;
                int vendorrowsnumber = VendorsDataTable.Rows.Count;
                int typerowsnumber = ItemsTypeDataTalbe.Rows.Count;

                DataTable ToPrintTable = new DataTable();
                ToPrintTable.Columns.Add("Barcode");
                ToPrintTable.Columns.Add("Description");
                ToPrintTable.Columns.Add("Ava.Qty");
                ToPrintTable.Columns.Add("Avg Cost");
                ToPrintTable.Columns.Add("Type");
                ToPrintTable.Columns.Add("Category");
                ToPrintTable.Columns.Add("Pref.Vendor");
                if (RenderPoint)
                {
                    ToPrintTable.Columns.Add("Phone");
                }

                foreach (DataRow r in ItemsDatatable.Rows)
                {
                    DataRow aRow = ToPrintTable.Rows.Add();
                    aRow["Barcode"] = r["Barcode"];
                    aRow["Description"] = r["Description"];
                    aRow["Ava.Qty"] = Math.Round(double.Parse(r["Qty"].ToString()), 3);
                    aRow["Avg Cost"] = Math.Round(double.Parse(r["AvgUnitCost"].ToString()), 3);
                    for (int i = 0; i < typerowsnumber; i++)
                    {
                        if (int.Parse(ItemsTypeDataTalbe.Rows[i]["ID"].ToString()) == int.Parse(r["Type"].ToString()))
                        {
                            aRow["Type"] = ItemsTypeDataTalbe.Rows[i]["Name"].ToString();
                            break;
                        }
                    }
                    for (int i = 0; i < itemcategoryrowsnumber; i++)
                    {
                        if (int.Parse(ItemCategoryDataTable.Rows[i]["ID"].ToString()) == int.Parse(r["Category"].ToString()))
                        {
                            aRow["Category"] = ItemCategoryDataTable.Rows[i]["Name"].ToString();
                            break;
                        }
                    }

                    for (int i = 0; i < vendorrowsnumber; i++)
                    {
                        if (int.Parse(VendorsDataTable.Rows[i]["ID"].ToString()) == int.Parse(r["Vendor"].ToString()))
                        {
                            aRow["Pref.Vendor"] = VendorsDataTable.Rows[i]["Name"].ToString();
                            if (RenderPoint)
                            {
                                aRow["Phone"] = VendorsDataTable.Rows[i]["Phone1"].ToString();
                            }
                            break;
                        }
                    }

                }

                if (TableBorder)
                {
                    ToPrintTable.Columns[0].ColumnName = "[Border=true1]" + ToPrintTable.Columns[0].ColumnName;
                }
                if (RenderPoint)
                {
                    ToPrintTable.Columns.Remove("Category");
                }
                ToPrintTable.Columns["Description"].ColumnName=("<th width=30%> Description");
                ToPrintTable.Columns.Remove("Type");
                aDTlist.Add(ToPrintTable);
                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

                aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
                if (RenderPoint)
                {
                    aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.RenPointListRepNm + " </font>");
                }
                else
                {
                    aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.ItemsListRepNm + " </font>");
                }

                aHeaderList.Add("<b><font size=2>" + Text.ReportsText.DateRepTxt + ": " + DateTime.Now.ToShortDateString() + " </font>");
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool PrintPhysicalItemsStatus(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            try
            {
                List<DataTable> aDTlist = new List<DataTable>();
                DataTable ItemsDatatable = ItemsMgmt.SelectAllItems();

                if (ItemsDatatable == null)
                {
                    return false;
                }
                else
                {
                    if (ItemsDatatable.Rows.Count == 0)
                    {
                        return false;
                    }
                }

                DataTable ToPrintTable = new DataTable();
                ToPrintTable.Columns.Add("Barcode");
                ToPrintTable.Columns.Add("Description");
                ToPrintTable.Columns.Add("Ava.Qty");
                ToPrintTable.Columns.Add("Physical Count");

                foreach (DataRow r in ItemsDatatable.Rows)
                {
                    DataRow aRow = ToPrintTable.Rows.Add();
                    aRow["Barcode"] = r["Barcode"];
                    aRow["Description"] = r["Description"];
                    aRow["Ava.Qty"] = Math.Round(double.Parse(r["Qty"].ToString()), 3);
                    aRow["Physical Count"] = "________";

                }

                if (TableBorder)
                {
                    ToPrintTable.Columns[0].ColumnName = "[Border=true1]" + ToPrintTable.Columns[0].ColumnName;
                }

                aDTlist.Add(ToPrintTable);
                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

                aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);

                aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.PhysicalInvWorksheetRepNm + " </font>");

                aHeaderList.Add("<b><font size=2>" + Text.ReportsText.DateRepTxt + ": " + DateTime.Now.ToShortDateString() + " </font>");
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool InvValuationSummaryStatus(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            try
            {
                List<DataTable> aDTlist = new List<DataTable>();

               DataTable ItemsDatatable = ItemsMgmt.SelectAllItems();

                if (ItemsDatatable == null)
                {
                    return false;
                }
                else
                {
                    if (ItemsDatatable.Rows.Count == 0)
                    {
                        return false;
                    }
                }


                DataTable ToPrintTable = new DataTable();
                ToPrintTable.Columns.Add("Name");
                ToPrintTable.Columns.Add("Ava Qty");
                ToPrintTable.Columns.Add("Avg Cost");

                ToPrintTable.Columns.Add("Inventory Value");
                ToPrintTable.Columns.Add("% of Tot Inventory");

                ToPrintTable.Columns.Add("Selling Price");
                ToPrintTable.Columns.Add("Retail Value");
                ToPrintTable.Columns.Add("% of Tot Retail");

                double AvgCost=0.00,AvaQty=0.00,SellingPrice=0.00;
                double TotalInvValue = 0.00;/*this to be used in the second loop*/
                double TotalRetailValue = 0.00;/*this to be used in the second loop*/
                double TotalQty = 0.00;
                foreach (DataRow r in ItemsDatatable.Rows)
                {
                    AvgCost = double.Parse(r["AvgUnitCost"].ToString());
                    AvaQty = double.Parse(r["Qty"].ToString());
                    SellingPrice = double.Parse(r["SellPrice"].ToString());

                    if (AvaQty <= 0)
                    {
                        continue;
                    }

                    TotalRetailValue += (SellingPrice * AvaQty);
                    TotalInvValue += (AvgCost * AvaQty);
                }

                foreach (DataRow r in ItemsDatatable.Rows)
                {
                    AvgCost = double.Parse(r["AvgUnitCost"].ToString());
                    AvaQty = double.Parse(r["Qty"].ToString());
                    TotalQty += AvaQty;
                    if (AvaQty<=0)
                    {
                        continue;
                    }
                    DataRow aRow = ToPrintTable.Rows.Add();
                    aRow["Name"] = r["Description"];
                    aRow["Ava Qty"] =  Math.Round(AvaQty, 3);
                    aRow["Avg Cost"] =  Math.Round(AvgCost, 3);
                    aRow["Inventory Value"] =  Math.Round(AvgCost * AvaQty, 3);
                    SellingPrice = double.Parse(r["SellPrice"].ToString());
                    aRow["Selling Price"] =  Math.Round(SellingPrice, 3);
                    aRow["Retail Value"] =  Math.Round(SellingPrice * AvaQty, 3);
                    aRow["% of Tot Inventory"] =Math.Round(((AvgCost * AvaQty) / TotalInvValue) * 100, 3).ToString() + " %";
                    aRow["% of Tot Retail"] =  Math.Round(((SellingPrice * AvaQty) / TotalRetailValue) * 100, 3).ToString() + " %";
                }

                DataRow FinalRow = ToPrintTable.Rows.Add();
                FinalRow["Name"] = "<td style=\"text-decoration:underline;\">" + "T O T A L";
                FinalRow["Ava Qty"] = "<td style=\"text-decoration:underline;\">" + Math.Round(TotalQty, 3);
                FinalRow["Avg Cost"] = "<td style=\"text-decoration:underline;\">" + " ";
                FinalRow["Selling Price"] = "<td style=\"text-decoration:underline;\">" + " ";
                FinalRow["Inventory Value"] = "<td style=\"text-decoration:underline;\">" + Math.Round(TotalInvValue, 3);
                FinalRow["Retail Value"] = "<td style=\"text-decoration:underline;\">" + Math.Round(TotalRetailValue, 3);
                FinalRow["% of Tot Inventory"] = "<td style=\"text-decoration:underline;\">" + "100%";
                FinalRow["% of Tot Retail"] = "<td style=\"text-decoration:underline;\">" + "100%";

                if (TableBorder)
                {
                    ToPrintTable.Columns[0].ColumnName = "[Border=true1]" + ToPrintTable.Columns[0].ColumnName;
                }

                aDTlist.Add(ToPrintTable);
                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

                aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);

                aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.InvvaluationSummaryRepNm + " </font>");

                aHeaderList.Add("<b><font size=2>" + Text.ReportsText.DateRepTxt + ": " + DateTime.Now.ToShortDateString() + " </font>");
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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
