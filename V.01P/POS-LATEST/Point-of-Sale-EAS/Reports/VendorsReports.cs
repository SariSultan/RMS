using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;
using System.Windows.Forms;

namespace Calcium_RMS.Reports
{
    public class VendorsReports
    {
        static VendorsReports instance;
        public static VendorsReports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new VendorsReports();
                }
                return instance;
            }
        }

        public bool VendorsListReport(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            List<DataTable> aDTlist = new List<DataTable>();
            DataTable allVendorsTable = VendorsMgmt.SelectAllVendors();
            allVendorsTable.Columns.Remove("ID");
            if (TableBorder)
            {
                allVendorsTable.Columns[0].ColumnName = "[Border=true1]" + allVendorsTable.Columns[0].ColumnName;
            }

            //REMOVING EMPTY COLUMNS
            List<string> aColumnsToRemove = new List<string>();
            foreach (DataColumn aColumn in allVendorsTable.Columns)
            {
                bool ColumnEmpty = false;
                for (int i = 0; i < allVendorsTable.Rows.Count - 1; i++)
                {
                    if (allVendorsTable.Rows[i][aColumn].ToString().Trim() == "")
                    {
                        ColumnEmpty = true;
                    }
                    else
                    {
                        ColumnEmpty = false;
                        break;
                    }
                }
                if (ColumnEmpty)
                {
                    aColumnsToRemove.Add(aColumn.ColumnName);
                }
            }
            for (int i = 0; i < aColumnsToRemove.Count; i++)
            {
                allVendorsTable.Columns.Remove(aColumnsToRemove[i]);
            }
            //END REMOVING EMPTY COLUMNS

            aDTlist.Add(allVendorsTable);
            List<string> aHeaderList = ReportsHelper.ImportReportHeader(0,1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);


            aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
            aHeaderList.Add("<b><font size=4>" + "Vendors List Contact" + " </font>");
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
                PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool VendorsBalanceListReport(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            List<DataTable> aDTlist = new List<DataTable>();

            DataTable aVendorsTable = VendorsMgmt.SelectAllVendors();
            aVendorsTable.Columns.Add("Balance");
            DataTable aVendorAccountTable = VendorsAccountsMgmt.SelectAll();

            if (aVendorsTable.Rows.Count > 0)
            {
                int RowNum = 0;
                foreach (DataRow r in aVendorsTable.Rows)
                {
                    if (aVendorAccountTable != null)
                    {
                        for (int i = 0; i < aVendorAccountTable.Rows.Count; i++)
                        {
                            if (int.Parse(aVendorsTable.Rows[RowNum]["ID"].ToString()) == int.Parse(aVendorAccountTable.Rows[i]["VendorID"].ToString()))
                            {
                                aVendorsTable.Rows[RowNum]["Balance"] = aVendorAccountTable.Rows[i]["Amount"].ToString();
                            }
                        }
                    }
                    RowNum++;
                }
                aVendorsTable.Columns.Remove("ID");
                if (TableBorder)
                {
                    aVendorsTable.Columns[0].ColumnName = "[Border=true1]" + aVendorsTable.Columns[0].ColumnName;
                }

                //REMOVING EMPTY COLUMNS
                List<string> aColumnsToRemove = new List<string>();
                foreach (DataColumn aColumn in aVendorsTable.Columns)
                {
                    bool ColumnEmpty = false;
                    for (int i = 0; i < aVendorsTable.Rows.Count - 1; i++)
                    {
                        if (aVendorsTable.Rows[i][aColumn].ToString().Trim() == "")
                        {
                            ColumnEmpty = true;
                        }
                        else
                        {
                            ColumnEmpty = false;
                            break;
                        }
                    }
                    if (ColumnEmpty)
                    {
                        aColumnsToRemove.Add(aColumn.ColumnName);
                    }
                }
                for (int i = 0; i < aColumnsToRemove.Count; i++)
                {
                    aVendorsTable.Columns.Remove(aColumnsToRemove[i]);
                }
                //END REMOVING EMPTY COLUMNS


                aDTlist.Add(aVendorsTable);

                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0,1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);
                aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
                aHeaderList.Add("<b><font size=4>" + "Vendors Balances List" + " </font>");
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
                    PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false; //there is no items in the customer table 
            }
        }

        public string VendorBalanceStatement(int VendorID, string DateFrom, string DateTo, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {
            List<DataTable> aDTlist = new List<DataTable>();
            bool aRevisedExist = false;
            DataTable aBillDataTable = ReportsMgmt.SelectVendorPurchaseINVOICEsByIDandDate(VendorID, DateFrom, DateTo);
            DataTable aPaymentDataTable = ReportsMgmt.SelectVendorPaymentsByIDandDate(VendorID, DateFrom, DateTo);
            #region ConcatTables
            DataTable ConcatTable = new DataTable();
            ConcatTable.Columns.Add("Description");
            ConcatTable.Columns.Add("Date", typeof(DateTime));
            ConcatTable.Columns.Add("#");
            ConcatTable.Columns.Add("Debit");
            ConcatTable.Columns.Add("Credit");
            int Cnt = 0;
            char AM = (char)1589;
            char PM = (char)1605;
            foreach (DataRow aRow in aPaymentDataTable.Rows)
            {
                ConcatTable.Rows.Add();
                ConcatTable.Rows[Cnt]["Description"] = "Payment";
                ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["Date"]).ToShortDateString() + " " + aRow["Time"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                ConcatTable.Rows[Cnt]["#"] = aRow["PaymentNumber"];
                ConcatTable.Rows[Cnt]["Credit"] = "-";
                ConcatTable.Rows[Cnt]["Debit"] =  aRow["Amount"];
                Cnt++;
                if (int.Parse(aRow["IsRevised"].ToString()) == 1)
                {
                    ConcatTable.Rows.Add();
                    ConcatTable.Rows[Cnt]["Description"] = "Reversed Payment";
                    ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + aRow["ReviseTime"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                    ConcatTable.Rows[Cnt]["#"] = aRow["PaymentNumber"];
                    ConcatTable.Rows[Cnt]["Credit"] =  double.Parse(aRow["Amount"].ToString());
                    ConcatTable.Rows[Cnt]["Debit"] = "-";
                    Cnt++;
                }
            }
            foreach (DataRow aRow in aBillDataTable.Rows)
            {
                ConcatTable.Rows.Add();
                ConcatTable.Rows[Cnt]["Description"] = "Bill";
                ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["Date"]).ToShortDateString() + " " + aRow["Time"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                ConcatTable.Rows[Cnt]["#"] = aRow["VoucherNumber"];
                ConcatTable.Rows[Cnt]["Credit"] = aRow["TotalCost"];
                ConcatTable.Rows[Cnt]["Debit"] = "-";
                Cnt++;
                if (int.Parse(aRow["IsRevised"].ToString()) == 1)
                {
                    ConcatTable.Rows.Add();
                    ConcatTable.Rows[Cnt]["Description"] = "Reversed Bill";
                    ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + aRow["ReviseTime"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                    ConcatTable.Rows[Cnt]["#"] = aRow["VoucherNumber"];
                    ConcatTable.Rows[Cnt]["Credit"] = "-";
                    ConcatTable.Rows[Cnt]["Debit"] =  double.Parse(aRow["TotalCost"].ToString());
                    Cnt++;
                }
            }

            ConcatTable.DefaultView.Sort = "Date ASC";
            ConcatTable = ConcatTable.DefaultView.ToTable();
            #endregion ConcatTables
            DataTable aMergedTable = new DataTable();
            aMergedTable.Columns.Add("Description");
            aMergedTable.Columns.Add("Date", typeof(DateTime));
            aMergedTable.Columns.Add("#");
            aMergedTable.Columns.Add("Debit");
            aMergedTable.Columns.Add("Credit");
            aMergedTable.Columns.Add("Balance");
            aMergedTable.Rows.Add(); //for startign balance
            aMergedTable.Rows[0]["Description"] = "Opening Balance";
            aMergedTable.Rows[0]["#"] = "-";
            aMergedTable.Rows[0]["Debit"] = "-";
            aMergedTable.Rows[0]["Credit"] = "-";
            if (aBillDataTable.Rows.Count > 0)
            {
                aMergedTable.Rows[0]["Date"] = Convert.ToDateTime(Convert.ToDateTime(aBillDataTable.Rows[0]["Date"]).ToShortDateString() + " " + Convert.ToDateTime(aBillDataTable.Rows[0]["Time"].ToString()).ToShortTimeString());
                aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aBillDataTable.Rows[0]["VendorAccountAmountOld"].ToString()), 2);
            }
            if (aPaymentDataTable.Rows.Count > 0)
            {
                DateTime tempdt = Convert.ToDateTime(Convert.ToDateTime(aPaymentDataTable.Rows[0]["Date"]).ToShortDateString() + " " + Convert.ToDateTime(aPaymentDataTable.Rows[0]["Time"].ToString()).ToShortTimeString());
                if (aBillDataTable.Rows.Count > 0)
                {
                    if (tempdt < Convert.ToDateTime(aMergedTable.Rows[0]["Date"]))
                    {
                        aMergedTable.Rows[0]["Date"] = tempdt;
                        aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aPaymentDataTable.Rows[0]["OldVendorAccountAmount"].ToString()), 2);
                    }
                }
                else
                {
                    aMergedTable.Rows[0]["Date"] = tempdt;
                    aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aPaymentDataTable.Rows[0]["OldVendorAccountAmount"].ToString()), 2);
                }
            }

            double FinalAmount = 0.00;
            double.TryParse(aMergedTable.Rows[0]["Balance"].ToString(), out FinalAmount);
            int aCounter = 1;
            #region OLDCODE
            //foreach (DataRow aRow in aPaymentDataTable.Rows)
            //{

            //    aMergedTable.Rows.Add();
            //    aMergedTable.Rows[aCounter]["Description"] = "Payment";
            //    aMergedTable.Rows[aCounter]["Date"] = Convert.ToDateTime(Convert.ToDateTime(aRow["Date"]).ToShortDateString() + " " + Convert.ToDateTime(aRow["Time"].ToString()).ToShortTimeString());
            //    aMergedTable.Rows[aCounter]["#"] = aRow["PaymentNumber"];
            //    aMergedTable.Rows[aCounter]["Debit"] = aRow["Amount"];
            //    aMergedTable.Rows[aCounter]["Credit"] = "-";
            //    aMergedTable.Rows[aCounter]["Balance"] = Math.Round((double.Parse(aRow["OldVendorAccountAmount"].ToString()) - double.Parse(aMergedTable.Rows[aCounter]["Debit"].ToString())), 2);
            //    aCounter++;

            //    if (int.Parse(aRow["IsRevised"].ToString()) == 1)
            //    {
            //        aRevisedExist = true;
            //        aMergedTable.Rows.Add();
            //        aMergedTable.Rows[aCounter]["Description"] = "Reversed Invoice";
            //        aMergedTable.Rows[aCounter]["Date"] = Convert.ToDateTime(Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + Convert.ToDateTime(aRow["ReviseTime"].ToString()).ToShortTimeString());
            //        aMergedTable.Rows[aCounter]["#"] = aRow["PaymentNumber"];
            //        aMergedTable.Rows[aCounter]["Credit"] = double.Parse(aRow["Amount"].ToString());
            //        aMergedTable.Rows[aCounter]["Debit"] = "-";
            //        aMergedTable.Rows[aCounter]["Balance"] = Math.Round((double.Parse(aMergedTable.Rows[aCounter - 1]["Balance"].ToString()) + double.Parse(aMergedTable.Rows[aCounter]["Credit"].ToString())), 2);
            //        aCounter++;
            //    }
            //}

            //foreach (DataRow aRow in aBillDataTable.Rows)
            //{

            //    aMergedTable.Rows.Add();
            //    aMergedTable.Rows[aCounter]["Description"] = "Bill";
            //    aMergedTable.Rows[aCounter]["Date"] = Convert.ToDateTime(Convert.ToDateTime(aRow["Date"]).ToShortDateString() + " " + Convert.ToDateTime(aRow["Time"].ToString()).ToShortTimeString());
            //    aMergedTable.Rows[aCounter]["#"] = aRow["VoucherNumber"];
            //    aMergedTable.Rows[aCounter]["Debit"] = "-";
            //    aMergedTable.Rows[aCounter]["Credit"] = aRow["TotalCost"];
            //    aMergedTable.Rows[aCounter]["Balance"] = Math.Round((double.Parse(aRow["VendorAccountAmountOld"].ToString()) + double.Parse(aMergedTable.Rows[aCounter]["Credit"].ToString())), 2);
            //    aCounter++;

            //    if (int.Parse(aRow["IsRevised"].ToString()) == 1)
            //    {
            //        aRevisedExist = true;
            //        aMergedTable.Rows.Add();
            //        aMergedTable.Rows[aCounter]["Description"] = "Reversed Bill";
            //        aMergedTable.Rows[aCounter]["Date"] = Convert.ToDateTime(Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + Convert.ToDateTime(aRow["ReviseTime"].ToString()).ToShortTimeString());
            //        aMergedTable.Rows[aCounter]["#"] = aRow["VoucherNumber"];
            //        aMergedTable.Rows[aCounter]["Credit"] = "-";
            //        aMergedTable.Rows[aCounter]["Debit"] = double.Parse(aRow["TotalCost"].ToString());
            //        aMergedTable.Rows[aCounter]["Balance"] = Math.Round((double.Parse(aMergedTable.Rows[aCounter - 1]["Balance"].ToString()) - double.Parse(aMergedTable.Rows[aCounter]["Debit"].ToString())), 2);
            //        aCounter++;
            //    }

            //}

            //aMergedTable.DefaultView.Sort = "Date ASC";

            //aMergedTable = aMergedTable.DefaultView.ToTable();
            #endregion OLDCODE
            foreach (DataRow aRow in ConcatTable.Rows)
            {

                aMergedTable.Rows.Add();
                aMergedTable.Rows[aCounter]["Description"] = aRow["Description"];
                aMergedTable.Rows[aCounter]["Date"] = aRow["Date"];
                aMergedTable.Rows[aCounter]["#"] = aRow["#"];
                if (aRow["Debit"].ToString() != "-")
                {
                    aMergedTable.Rows[aCounter]["Credit"] = "-";
                    aMergedTable.Rows[aCounter]["Debit"] = aRow["Debit"];
                    FinalAmount -= double.Parse(aRow["Debit"].ToString());
                }
                else
                {
                    aMergedTable.Rows[aCounter]["Credit"] = aRow["Credit"];
                    aMergedTable.Rows[aCounter]["Debit"] = "-";
                    FinalAmount += double.Parse(aRow["Credit"].ToString());
                }
                aMergedTable.Rows[aCounter]["Balance"] = Math.Round(FinalAmount, 3);
                aCounter++;
            }
            aMergedTable.Rows.Add();
            aMergedTable.Rows[aCounter]["Description"] = "Total";
            aMergedTable.Rows[aCounter]["Balance"] = FinalAmount;
            if (aMergedTable.Rows.Count > 1)
            {
                aDTlist.Add(aMergedTable);
                if (TableBorder)
                {
                    aMergedTable.Columns[0].ColumnName = "[Border=true1]<th style=\"width:18%\";>" + aMergedTable.Columns[0].ColumnName;
                }
                else
                {
                    aMergedTable.Columns[0].ColumnName = "<th style=\"width:18%\";>" + aMergedTable.Columns[0].ColumnName;
                }
                aMergedTable.Columns[1].ColumnName = "<th style=\"width:27%\";>" + aMergedTable.Columns[1].ColumnName;
                aMergedTable.Columns[2].ColumnName = "<th style=\"width:15%\";>" + aMergedTable.Columns[2].ColumnName;
                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0,1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);

                double prevrow;
                double row;
                double data;
                if (aRevisedExist)
                {


                    for (int i = 1; i < aMergedTable.Rows.Count; i++)
                    {
                        if (double.TryParse(aMergedTable.Rows[i - 1]["Balance"].ToString(), out prevrow))
                        {
                            if (double.TryParse(aMergedTable.Rows[i]["Balance"].ToString(), out row))
                            {
                                //debit
                                if (double.TryParse(aMergedTable.Rows[i]["Debit"].ToString(), out data))
                                {
                                    aMergedTable.Rows[i]["Balance"] = prevrow - data;
                                }
                                //credit
                                else if (double.TryParse(aMergedTable.Rows[i]["Credit"].ToString(), out data))
                                {
                                    aMergedTable.Rows[i]["Balance"] = prevrow + data;
                                }
                                else
                                {
                                    //TOTAL FINALLY
                                    aMergedTable.Rows[i]["Balance"] = prevrow;
                                }
                                

                            }
                        }
                    }
                }
                aHeaderList.Add(SharedVariables.Line_Solid_10px_Black);
                aHeaderList.Add(Text.ReportsNames.VenStatementOfAcctRepNm);
                DataRow vendorName = VendorsMgmt.SelectVendorRowByID(VendorID);
                //DataRow aCustomerRow = CustomerMgmt.SelectCustomerRowByID(VendorID);
                aHeaderList.Add(" <h2>Phone:<b>" + vendorName["Phone1"].ToString() + "</b> &nbsp;Name: <b>" + vendorName["Name"].ToString() + "</b></h2>");
                aHeaderList.Add("<h2> From: " + DateFrom + " &nbsp; To:" + DateTo + "</h2>");
                aHeaderList.Add("<h3>Print By: <b>" + SharedFunctions.ReturnLoggedUserName() + "</b> On <b>" + DateTime.Now + "</b></h3>");
                aHeaderList.Add(SharedVariables.Line_Solid_10px_Black);

                if (Preview)
                {
                    PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", false, "", colored);
                    return "True";
                }
                else if (ExportToPdf)
                {
                    PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, true, ExportPath, false, "", colored);
                    return "True";
                }
                else if (ExportToExcel)
                {
                    PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", true, ExportPath, colored);
                    return "True";
                }
                else if (PrintToThermal)
                {
                    PrintingManager.Instance.PrintTables(aDTlist, aHeaderList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                    return "True";
                }
                else
                {
                    return "True";
                }

            }
            else
            {
                return "No-Data";
            }


        }

    }
}
