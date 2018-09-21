using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Management;
using System.Data;

namespace Calcium_RMS.Reports
{
    public class ReportsHelper
    {
        public static bool RTL = false;
        public static bool ReceiptRTL = false;
        public static string MANUAL_TD_OPTION_START = "<td style=\"";
        public static string MANUAL_TD_OPTION_END = "\">";
        public static string MANUAL_TD_END = "</td>";
        public static string UNDERLINE = "text-decoration:underline;";
        public static string BOLD = "font-weight:bold;";
        public static string NOBORDER = " border:0px; background-color:#FFFFFF;";


        public static readonly string TempOutputPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\sa.html";
        public static readonly string TempOutputPathExcel = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\saExcel.xls";
        public static readonly string TempPDFOutputPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\sa.pdf";
        public static string __HTMLPage = "<h1>NO DATA TO PREVIEW</h1>";
        public static void SET_HTML_DEFAUL_PAGE()
        { __HTMLPage = "<h1>NO DATA TO PREVIEW</h1>"; }
        public static List<string> ImportReportHeader(int HeaderOrFooter, int BillOrReport)
        {
            List<string> aHeaderList = new List<string>();
            List<string> aFooterList = new List<string>();
            if (BillOrReport == 0)
            {
                if (HeaderOrFooter == 0)
                {
                    DataTable aBillHeader = PrintingSettingsMgmt.SelectBillsHeaders(0, 0);
                    if (aBillHeader != null)
                    {
                        foreach (DataRow aRow in aBillHeader.Rows)
                        {
                            if (aRow["Data"].ToString().Trim() != "")
                            {
                                aHeaderList.Add(aRow["Data"].ToString());
                            }

                        }
                        return aHeaderList;
                    }
                }
                else if (HeaderOrFooter == 1)
                {
                    DataTable aBillFooter = PrintingSettingsMgmt.SelectBillsHeaders(1, 0);
                    if (aBillFooter != null)
                    {

                        foreach (DataRow aRow in aBillFooter.Rows)
                        {
                            if (aRow["Data"].ToString().Trim() != "")
                            {
                                aFooterList.Add(aRow["Data"].ToString());
                            }

                        }
                        return aFooterList;
                    }
                }
            }
            else if (BillOrReport == 1)
            {
                if (HeaderOrFooter == 0)
                {
                    DataTable aReportHeader = PrintingSettingsMgmt.SelectBillsHeaders(0, 1);
                    if (aReportHeader != null)
                    {
                        foreach (DataRow aRow in aReportHeader.Rows)
                        {
                            if (aRow["Data"].ToString().Trim() != "")
                            {
                                aHeaderList.Add(aRow["Data"].ToString());
                            }

                        }
                        return aHeaderList;
                    }
                }
                else if (HeaderOrFooter == 1)
                {
                    DataTable aReportFooter = PrintingSettingsMgmt.SelectBillsHeaders(1, 1);
                    if (aReportFooter != null)
                    {
                        foreach (DataRow aRow in aReportFooter.Rows)
                        {
                            if (aRow["Data"].ToString().Trim() != "")
                            {
                                aFooterList.Add(aRow["Data"].ToString());
                            }

                        }
                        return aFooterList;
                    }
                }
            }
            return null;
        }

        public static string FindData(DataTable OrgTable, string OrgCol, string NeededCol, string Key)
        {
            try
            {
                if (OrgTable == null)
                {
                    return "0";
                }
                foreach (DataRow aRow in OrgTable.Rows)
                {
                    if (aRow[OrgCol].ToString() == Key)
                    {
                        return aRow[NeededCol].ToString();
                    }
                }
                return "0";
            }
            catch { return "0"; }
        }

    }
}
