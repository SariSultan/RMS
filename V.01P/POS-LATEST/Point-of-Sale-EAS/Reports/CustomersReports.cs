using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;
using System.Windows.Forms;

namespace Calcium_RMS.Reports
{
    public class CustomersReports
    {
        static CustomersReports instance;
        public static CustomersReports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomersReports();
                }
                return instance;
            }
        }

        public bool CustomerListReport(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            List<DataTable> aDTlist = new List<DataTable>();
            DataTable allCustomerTable = CustomerMgmt.SelectAllCustomers();
            allCustomerTable.Columns.Remove("ID");
            if (TableBorder)
            {
                allCustomerTable.Columns[0].ColumnName = "[Border=true1]" + allCustomerTable.Columns[0].ColumnName;
            }

            //REMOVING EMPTY COLUMNS
            List<string> aColumnsToRemove = new List<string>();
            foreach (DataColumn aColumn in allCustomerTable.Columns)
            {
                bool ColumnEmpty = false;
                for (int i = 0; i < allCustomerTable.Rows.Count; i++)
                {
                    if (allCustomerTable.Rows[i][aColumn].ToString().Trim() == "")
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
                allCustomerTable.Columns.Remove(aColumnsToRemove[i]);
            }
            //END REMOVING EMPTY COLUMNS
            aDTlist.Add(allCustomerTable);
            List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);


            aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
            aHeaderList.Add("<b><font size=4>" + Text.ReportsNames.CustomersListRepNm + " </font>");
            aHeaderList.Add("<b><font size=4>" + Text.ReportsText.DateRepTxt + ": " + DateTime.Now.ToShortDateString() + " </font>");
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

        public bool CutomerBalanceListReport(bool PrintToThermal, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool TableBorder = false, bool Preview = false, bool colored = false)
        {
            List<DataTable> aDTlist = new List<DataTable>();

            DataTable aCustomerTable = CustomerMgmt.SelectAllCustomers();
            aCustomerTable.Columns.Add("Balance");

            Ordercolumns.SetColumnsOrder(aCustomerTable, new string[] { "ID", "Name", "Balance", "Phone1", "Email", "Address" });
            DataTable aCustomerAccountTable = CustomersAccountsMgmt.SelectAll();

            if (aCustomerTable.Rows.Count > 0)
            {
                int RowNum = 0;
                foreach (DataRow r in aCustomerTable.Rows)
                {
                    if (aCustomerAccountTable != null)
                    {
                        for (int i = 0; i < aCustomerAccountTable.Rows.Count; i++)
                        {
                            if (int.Parse(aCustomerTable.Rows[RowNum]["ID"].ToString()) == int.Parse(aCustomerAccountTable.Rows[i]["CustomerID"].ToString()))
                            {
                                aCustomerTable.Rows[RowNum]["Balance"] = aCustomerAccountTable.Rows[i]["Amount"].ToString();
                            }
                        }
                    }
                    RowNum++;
                }

                aCustomerTable.Columns.Remove("ID");
                if (TableBorder)
                {
                    aCustomerTable.Columns[0].ColumnName = "[Border=true1]" + aCustomerTable.Columns[0].ColumnName;
                }


                //REMOVING EMPTY COLUMNS
                List<string> aColumnsToRemove = new List<string>();
                foreach (DataColumn aColumn in aCustomerTable.Columns)
                {
                    bool ColumnEmpty = false;
                    for (int i = 0; i < aCustomerTable.Rows.Count; i++)
                    {
                        if (aCustomerTable.Rows[i][aColumn].ToString().Trim() == "")
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
                    aCustomerTable.Columns.Remove(aColumnsToRemove[i]);
                }
                //END REMOVING EMPTY COLUMNS              
                aDTlist.Add(aCustomerTable);

                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);
                aHeaderList.Add("<td>" + SharedVariables.Line_Solid_10px_Black);
                aHeaderList.Add("<b><font size=4>" + "Customers Balance Summary" + " </font>");
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

        public string CustomerBalanceStatement(int CustomerID, string DateFrom, string DateTo, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {
            bool aRevisedExist = false;
            List<DataTable> aDTlist = new List<DataTable>();
            DataTable aBillDataTable = ReportsMgmt.SelectCustomerBillINVOICEsByIDandDate(CustomerID, DateFrom, DateTo);
            DataTable aPaymentDataTable = ReportsMgmt.SelectCustomerPaymentsByIDandDate(CustomerID, DateFrom, DateTo);
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
                ConcatTable.Rows[Cnt]["Credit"] = aRow["Amount"];
                ConcatTable.Rows[Cnt]["Debit"] = "-";
                Cnt++;
                if (int.Parse(aRow["IsRevised"].ToString()) == 1)
                {
                    ConcatTable.Rows.Add();
                    ConcatTable.Rows[Cnt]["Description"] = "Reversed Payment";
                    ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + aRow["ReviseTime"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                    ConcatTable.Rows[Cnt]["#"] = aRow["PaymentNumber"];
                    ConcatTable.Rows[Cnt]["Credit"] = "-";
                    ConcatTable.Rows[Cnt]["Debit"] = double.Parse(aRow["Amount"].ToString());
                    Cnt++;
                }
            }
            foreach (DataRow aRow in aBillDataTable.Rows)
            {
                ConcatTable.Rows.Add();
                ConcatTable.Rows[Cnt]["Description"] = "Invoice";
                ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["Date"]).ToShortDateString() + " " + aRow["BillTime"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                ConcatTable.Rows[Cnt]["#"] = aRow["Number"];
                ConcatTable.Rows[Cnt]["Credit"] = "-";
                ConcatTable.Rows[Cnt]["Debit"] = aRow["TotalPrice"];
                Cnt++;
                if (int.Parse(aRow["IsRevised"].ToString()) == 1)
                {
                    ConcatTable.Rows.Add();
                    ConcatTable.Rows[Cnt]["Description"] = "Reversed Invoice";
                    ConcatTable.Rows[Cnt]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aRow["ReviseDate"]).ToShortDateString() + " " + aRow["BillTime"].ToString().ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM")));
                    ConcatTable.Rows[Cnt]["#"] = aRow["Number"];
                    ConcatTable.Rows[Cnt]["Credit"] = double.Parse(aRow["TotalPrice"].ToString());
                    ConcatTable.Rows[Cnt]["Debit"] = "-";
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
                aMergedTable.Rows[0]["Date"] = Convert.ToDateTime((Convert.ToDateTime(aBillDataTable.Rows[0]["Date"]).ToShortDateString() + " " + aBillDataTable.Rows[0]["BillTime"].ToString()).ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM"));
                aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aBillDataTable.Rows[0]["CustomerAccountAmountOld"].ToString()), 2);
            }
            if (aPaymentDataTable.Rows.Count > 0)
            {
                DateTime tempdt = Convert.ToDateTime((Convert.ToDateTime(aPaymentDataTable.Rows[0]["Date"]).ToShortDateString() + " " + aPaymentDataTable.Rows[0]["Time"].ToString()).ToString().Replace((string)(AM + ""), "AM").Replace((string)(PM + ""), "PM"));
                if (aBillDataTable.Rows.Count > 0)
                {
                    if (tempdt < Convert.ToDateTime(aMergedTable.Rows[0]["Date"]))
                    {
                        aMergedTable.Rows[0]["Date"] = tempdt;
                        aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aPaymentDataTable.Rows[0]["OldUsrAccountAmount"].ToString()), 2);
                    }

                }
                else
                {
                    aMergedTable.Rows[0]["Date"] = tempdt;
                    aMergedTable.Rows[0]["Balance"] = Math.Round(double.Parse(aPaymentDataTable.Rows[0]["OldUsrAccountAmount"].ToString()), 2);
                }

            }

            double FinalAmount = 0.00;
            double.TryParse(aMergedTable.Rows[0]["Balance"].ToString(), out FinalAmount);
            int aCounter = 1;
            foreach (DataRow aRow in ConcatTable.Rows)
            {

                aMergedTable.Rows.Add();
                aMergedTable.Rows[aCounter]["Description"] = aRow["Description"];
                aMergedTable.Rows[aCounter]["Date"] = aRow["Date"];
                aMergedTable.Rows[aCounter]["#"] = aRow["#"];
                if (aRow["Debit"].ToString()!="-")
                {
                  aMergedTable.Rows[aCounter]["Credit"] = "-";
                  aMergedTable.Rows[aCounter]["Debit"] = aRow["Debit"];
                  FinalAmount += double.Parse(aRow["Debit"].ToString());
                }
                else
                {
                    aMergedTable.Rows[aCounter]["Credit"] = aRow["Credit"];
                    aMergedTable.Rows[aCounter]["Debit"] = "-";
                    FinalAmount -= double.Parse(aRow["Credit"].ToString());
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
                    aMergedTable.Columns[0].ColumnName = "[Border=true1]<th style=\"width:15%\";>" + aMergedTable.Columns[0].ColumnName;
                }
                else
                {
                    aMergedTable.Columns[0].ColumnName = "<th style=\"width:15%\";>" + aMergedTable.Columns[0].ColumnName;
                }
                aMergedTable.Columns[1].ColumnName = "<th style=\"width:27%\";>" + aMergedTable.Columns[1].ColumnName;
                aMergedTable.Columns[2].ColumnName = "<th style=\"width:15%\";>" + aMergedTable.Columns[2].ColumnName;

                double prevrow;
                double row;
                double data;

                List<string> aHeaderList = ReportsHelper.ImportReportHeader(0, 1);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);
                aHeaderList.Add(SharedVariables.Line_Solid_10px_Black);
                aHeaderList.Add("Customer Balance Statement");
                DataRow aCustomerRow = CustomerMgmt.SelectCustomerRowByID(CustomerID);
                aHeaderList.Add("<h2>Phone: <b>" + aCustomerRow["Phone1"].ToString() + "</b>  Name:<b> " + aCustomerRow["Name"].ToString() + "</b></h2>");
                aHeaderList.Add("<h2>From:" + DateFrom + " &nbsp; To:" + DateTo + "</h2>");
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
                return "ERROR";
            }


        }

    }
    public static class Ordercolumns
    {
        public static void SetColumnsOrder(this DataTable table, params String[] columnNames)
        {
            try
            {
                for (int columnIndex = 0; columnIndex < columnNames.Length; columnIndex++)
                {
                    table.Columns[columnNames[columnIndex]].SetOrdinal(columnIndex);
                }
            }
            catch
            { }
        }
    }
}
