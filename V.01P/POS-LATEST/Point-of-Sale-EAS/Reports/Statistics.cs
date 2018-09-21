using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Excel = Microsoft.Office.Interop.Excel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
//[assembly: Obfuscation(Feature = "all /type:Microsoft.Office.Interop.Excel",ApplyToMembers=true)]
//[assembly: Obfuscation(Feature = "all /type:Excel", ApplyToMembers = true)]
namespace Calcium_RMS.Reports
{
    
    //[Obfuscation(Feature="all",ApplyToMembers=true)]
    public class Statistics
    {
        //EXCEL VARIABLES
        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range oRng;
        object misValue = System.Reflection.Missing.Value;
        //end
        static Statistics instance;
        public static Statistics Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Statistics();
                }
                return instance;
            }
        }

        public string FastMoveItems(bool FastOrSlowReport, int NumberOfItems, string DateFrom, string DateTo, bool ExportToExcel = false, string ExportPath = "")
        {
            try
            {
                Excel.Range chartRange;
                xlApp = new Excel.Application();
                xlApp.DisplayAlerts = false;
                xlApp.Visible = false;
                xlApp.SheetsInNewWorkbook = 1;
                xlWorkBook = xlApp.Workbooks.Add(misValue);//misValue

                string ReportName = (FastOrSlowReport ? "Fast Move Items Report" : "Slow Move Items Report");

                DataTable aTable = ReportsMgmt.FastMovItemBasedOnQty(NumberOfItems, DateFrom, DateTo, FastOrSlowReport);

                if (aTable.Rows.Count > 0)
                {
                    

                    int RowCnt = 1;
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = ReportName;

                    List<string> aHeader = ReportsHelper.ImportReportHeader(0, 1);
                    List<string> aFooter = ReportsHelper.ImportReportHeader(1, 1);
                    for (int i = 0; i < aHeader.Count; i++)
                    {
                        string astringss = aHeader[i];
                        xlWorkSheet.Cells[RowCnt, 2] = aHeader[i];
                        RowCnt++;
                    }
                    xlWorkSheet.Cells[RowCnt++, 1] = ReportName;

                    xlWorkSheet.Cells[RowCnt, 2] = "Date From:\t" + DateFrom;
                    xlWorkSheet.Cells[RowCnt, 3] = "Date To:\t" + DateTo;
                    RowCnt++;
                    xlWorkSheet.Cells[RowCnt, 1] = "Item Description";
                    xlWorkSheet.Cells[RowCnt, 2] = "Qty Sold";

                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).Font.Bold = true;
                    //xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).WrapText = true;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    RowCnt++;
                    int DataStart = RowCnt;
                    foreach (DataRow aRow in aTable.Rows)
                    {
                        xlWorkSheet.Cells[RowCnt, 1] = aRow["ItemDescription"].ToString();
                        xlWorkSheet.Cells[RowCnt, 2] = aRow["Summation"].ToString();
                        RowCnt++;
                    }
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    oRng = xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString());
                    oRng.EntireColumn.AutoFit();
                    Excel.ChartObjects myCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);

                    xlWorkSheet.DisplayRightToLeft = false;
                    int size = aTable.Rows.Count * 100;
                    if (size >= 600)
                    {
                        size = 600;
                    }
                    if (size < 300)
                    {
                        size = 300;
                    }
                    Excel.ChartObject myChart = (Excel.ChartObject)myCharts.Add(0, RowCnt * 15, size, 300);
                    Excel.Chart chartPage = myChart.Chart;
                    Excel.SeriesCollection seriesCollection = chartPage.SeriesCollection();
                    Excel.Series series1 = seriesCollection.NewSeries();

                    RowCnt--; //because we started from 1 suppose to be 0
                    series1.Name = ReportName;
                    series1.XValues = xlWorkSheet.Range["A" + DataStart.ToString(), "A" + RowCnt.ToString()];
                    series1.Values = xlWorkSheet.Range["B" + DataStart.ToString(), "B" + RowCnt.ToString()];


                    chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

                    Excel.Axis axis = chartPage.Axes(Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary) as Excel.Axis;

                    series1.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowBubbleSizes);



                    object format = Microsoft.Office.Interop.Excel.XlFileFormat.xlHtml;
                    xlWorkSheet.SaveAs(ReportsHelper.TempOutputPath, format);
                    if (ExportToExcel)
                    {
                        format = Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7;
                        xlWorkSheet.SaveAs(ExportPath, format);
                    }


                    xlApp.UserControl = false;

                    return "TRUE";
                }
                else
                {
                    return "EMPTY";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return "ERROR";
            }
            finally
            {
                //Once done close and quit Excel
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
              
                
            }
        }

        //highest slowest revenues
        public string HighestRevenuesItems(bool FastOrSlowReport, int NumberOfItems, string DateFrom, string DateTo, bool ExportToExcel = false, string ExportPath = "")
        {
            try
            {
                xlApp = new Excel.Application();
                xlApp.DisplayAlerts = false;
                xlApp.Visible = false;
                xlApp.SheetsInNewWorkbook = 1;
                xlWorkBook = xlApp.Workbooks.Add(misValue);//misValue

                string ReportName = (FastOrSlowReport ? "Highest Revenues Items Report" : "Lowest Revenues Items Report");

                DataTable aTable = ReportsMgmt.HighestRevenuesItems(NumberOfItems, DateFrom, DateTo, FastOrSlowReport);

                if (aTable.Rows.Count > 0)
                {
                   
                    int RowCnt = 1;
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = ReportName;

                    List<string> aHeader = ReportsHelper.ImportReportHeader(0, 1);
                    List<string> aFooter = ReportsHelper.ImportReportHeader(1, 1);
                    for (int i = 0; i < aHeader.Count; i++)
                    {
                        xlWorkSheet.Cells[RowCnt, 2] = aHeader[i];
                        RowCnt++;
                    }
                    xlWorkSheet.Cells[RowCnt++, 1] = ReportName;

                    xlWorkSheet.Cells[RowCnt, 2] = "Date From:\t" + DateFrom;
                    xlWorkSheet.Cells[RowCnt, 3] = "Date To:\t" + DateTo;
                    RowCnt++;
                    xlWorkSheet.Cells[RowCnt, 1] = "Item Description";
                    xlWorkSheet.Cells[RowCnt, 2] = "Total Revenue JOD";

                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).Font.Bold = true;
                    //xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).WrapText = true;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    RowCnt++;
                    int DataStart = RowCnt;
                    foreach (DataRow aRow in aTable.Rows)
                    {
                        xlWorkSheet.Cells[RowCnt, 1] = aRow["ItemDescription"].ToString();
                        xlWorkSheet.Cells[RowCnt, 2] = aRow["Summation"].ToString();
                        RowCnt++;
                    }
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    oRng = xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString());
                    oRng.EntireColumn.AutoFit();
                    Excel.ChartObjects myCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);

                    xlWorkSheet.DisplayRightToLeft = false;
                    int size = aTable.Rows.Count * 100;
                    if (size >= 600)
                    {
                        size = 600;
                    }
                    if (size < 300)
                    {
                        size = 300;
                    }
                    Excel.ChartObject myChart = (Excel.ChartObject)myCharts.Add(0, RowCnt * 15, size, 300);
                    Excel.Chart chartPage = myChart.Chart;
                    Excel.SeriesCollection seriesCollection = chartPage.SeriesCollection();
                    Excel.Series series1 = seriesCollection.NewSeries();

                    RowCnt--; //because we started from 1 suppose to be 0
                    series1.Name = ReportName;
                    series1.XValues = xlWorkSheet.Range["A" + DataStart.ToString(), "A" + RowCnt.ToString()];
                    series1.Values = xlWorkSheet.Range["B" + DataStart.ToString(), "B" + RowCnt.ToString()];


                    chartPage.ChartType = Excel.XlChartType.xlColumnClustered;

                    Excel.Axis axis = chartPage.Axes(Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary) as Excel.Axis;

                    series1.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowBubbleSizes);



                    object format = Microsoft.Office.Interop.Excel.XlFileFormat.xlHtml;
                    xlWorkSheet.SaveAs(ReportsHelper.TempOutputPath, format);
                    
                    if (ExportToExcel)
                    {
                        format = Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7;
                        xlWorkSheet.SaveAs(ExportPath, format);
                    }


                    xlApp.UserControl = false;



                    return "TRUE";
                }
                else
                {
                    return "EMPTY";
                }

            }
            catch (Exception)
            {

                return "ERROR";
            }
            finally
            {
                //Once done close and quit Excel
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
               
            }
        }

        //Revenues Comparison 
        public string RevenuesComparison(int ByDDMMYYYY, string DateFrom, string DateTo, bool ExportToExcel = false, string ExportPath = "")
        {
            try
            {
                string ReportName = "Revenues Comparison Report";

                DataTable aTable = ReportsMgmt.RevenuesComparions(ByDDMMYYYY, DateFrom, DateTo);

                if (aTable.Rows.Count > 0)
                {
                    xlApp = new Excel.Application();
                    xlApp.DisplayAlerts = false;
                    xlApp.Visible = false;
                    xlApp.SheetsInNewWorkbook = 1;
                    xlWorkBook = xlApp.Workbooks.Add(misValue);//misValue

                    int RowCnt = 1;
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    xlWorkSheet.Name = ReportName;

                    List<string> aHeader = ReportsHelper.ImportReportHeader(0, 1);
                    List<string> aFooter = ReportsHelper.ImportReportHeader(1, 1);
                    for (int i = 0; i < aHeader.Count; i++)
                    {
                        xlWorkSheet.Cells[RowCnt, 2] = aHeader[i];
                        RowCnt++;
                    }
                    xlWorkSheet.Cells[RowCnt++, 1] = ReportName;

                    xlWorkSheet.Cells[RowCnt, 2] = "Date From:\t" + DateFrom;
                    xlWorkSheet.Cells[RowCnt, 3] = "Date To:\t" + DateTo;
                    RowCnt++;
                    xlWorkSheet.Cells[RowCnt, 1] = "Date";
                    xlWorkSheet.Cells[RowCnt, 2] = "Total Cost JOD";
                    xlWorkSheet.Cells[RowCnt, 3] = "Total Sales JOD";
                    xlWorkSheet.Cells[RowCnt, 4] = "Gross Profit JOD";

                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).Font.Bold = true;
                    //xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).WrapText = true;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    RowCnt++;
                    int DataStart = RowCnt;
                    foreach (DataRow aRow in aTable.Rows)
                    {
                        if (ByDDMMYYYY == 0) //BY DAY
                        {
                            xlWorkSheet.Cells[RowCnt, 1] = aRow["Day"].ToString() + '\\' + aRow["Month"].ToString() + "\\" + aRow["Year"].ToString();
                        }
                        else if (ByDDMMYYYY == 1)//BY MONTH
                        {
                            xlWorkSheet.Cells[RowCnt, 1] = aRow["Month"].ToString() + '\\' + aRow["Year"].ToString();
                        }
                        else //BY YEAR
                        {
                            xlWorkSheet.Cells[RowCnt, 1] = aRow["Year"].ToString();
                        }
                        xlWorkSheet.Cells[RowCnt, 2] = Math.Round(double.Parse(aRow["TotalCost"].ToString()), 2);
                        xlWorkSheet.Cells[RowCnt, 3] = Math.Round(double.Parse(aRow["TotalPrice"].ToString()), 2);
                        xlWorkSheet.Cells[RowCnt, 4] = Math.Round(double.Parse(aRow["TotalProfit"].ToString()), 2);
                        RowCnt++;
                    }
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).HorizontalAlignment = Excel.XlVAlign.xlVAlignCenter;
                    xlWorkSheet.get_Range("A" + DataStart.ToString(), "K" + RowCnt.ToString()).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    oRng = xlWorkSheet.get_Range("A1", "K" + RowCnt.ToString());
                    oRng.EntireColumn.AutoFit();
                    Excel.ChartObjects myCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);

                    xlWorkSheet.DisplayRightToLeft = false;
                    int size = aTable.Rows.Count * 100;
                    if (size > 600)
                    {
                        size = 600;
                    }
                    if (size < 300)
                    {
                        size = 300;
                    }
                    Excel.ChartObject myChart = (Excel.ChartObject)myCharts.Add(0, RowCnt * 15, size, 300);
                    Excel.Chart chartPage = myChart.Chart;
                    Excel.SeriesCollection seriesCollection = chartPage.SeriesCollection();
                    Excel.Series series1 = seriesCollection.NewSeries();
                    Excel.Series series2 = seriesCollection.NewSeries();
                    Excel.Series series3 = seriesCollection.NewSeries();

                    RowCnt--; //because we started from 1 suppose to be 0
                    series1.Name = "Total Cost";
                    series1.XValues = xlWorkSheet.Range["A" + DataStart.ToString(), "A" + RowCnt.ToString()];
                    series1.Values = xlWorkSheet.Range["B" + DataStart.ToString(), "B" + RowCnt.ToString()];

                    series2.Name = "Total Sales";
                    series2.XValues = xlWorkSheet.Range["A" + DataStart.ToString(), "A" + RowCnt.ToString()];
                    series2.Values = xlWorkSheet.Range["C" + DataStart.ToString(), "C" + RowCnt.ToString()];

                    series3.Name = "Gross Profit";
                    series3.XValues = xlWorkSheet.Range["A" + DataStart.ToString(), "A" + RowCnt.ToString()];
                    series3.Values = xlWorkSheet.Range["D" + DataStart.ToString(), "D" + RowCnt.ToString()];


                    chartPage.ChartType = Excel.XlChartType.xlLineMarkers;

                    Excel.Axis axis = chartPage.Axes(Excel.XlAxisType.xlValue, Microsoft.Office.Interop.Excel.XlAxisGroup.xlPrimary) as Excel.Axis;

                    series1.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowBubbleSizes);
                    series2.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowBubbleSizes);
                    series3.ApplyDataLabels(Excel.XlDataLabelsType.xlDataLabelsShowBubbleSizes);

                    object format = Microsoft.Office.Interop.Excel.XlFileFormat.xlHtml;
                    xlWorkSheet.SaveAs(ReportsHelper.TempOutputPath, format);
                    if (ExportToExcel)
                    {
                        format = Microsoft.Office.Interop.Excel.XlFileFormat.xlExcel7;
                        xlWorkSheet.SaveAs(ExportPath, format);
                        
                    }

                    xlApp.UserControl = false;
                    //Once done close and quit Excel

                    return "TRUE";
                }
                else
                {
                    return "EMPTY";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("{EXCEPTION in Revenues Comparison}"+ex.Message +ex.ToString());
                return "ERROR " + ex.Message;
            }
            finally
            {
                //Once done close and quit Excel
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                // MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
