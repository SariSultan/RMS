using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using WkHtmlToXSharp;

namespace Calcium_RMS
{
    public class PrintingThreadObjects
    {
        public string Name;

        public string Result;

        public bool OpenCash;
    }

    public delegate void ResultDelegate(PrintingThreadObjects printingthreadobject);

    public class PrintingManager
    {
        public event ResultDelegate resultDelegate;

        static PrintingManager instance;
        public static PrintingManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PrintingManager();
                }
                return instance;
            }
        }

        private PrintingManager()
        {
            resultDelegate += new ResultDelegate(resultValue);
        }

        void resultValue(PrintingThreadObjects threadObject)
        {
            // MessageBox.Show("Thread Name : " + threadObject.Name + " Thread Result : " + threadObject.Result);
        }

        void printTable(DataTable aDataTable, string aFileName, bool aIsThermal)
        {
            StreamWriter sr = new StreamWriter(aFileName, true, UTF8Encoding.UTF8);
            string ClassName;
            if (aDataTable.Rows.Count == 0 && aDataTable.Columns.Count == 1)
            {
                sr.WriteLine("<table class=\"TableHeaderOnly\">");
                foreach (DataColumn col in aDataTable.Columns)
                {
                    sr.WriteLine("<th>" + col.ColumnName + "</th>");
                }
                sr.WriteLine("</table>");
                sr.Close();
                return;
            }

            int isborder = 0;
            if (aDataTable.Columns[0].ToString().IndexOf("[") != -1)
            {
                isborder = (aDataTable.Columns[0].ToString().Substring(aDataTable.Columns[0].ToString().IndexOf("[") + 1, aDataTable.Columns[0].ToString().LastIndexOf("]") - 1).ToUpper() == "BORDER=TRUE1" ? 1 : 0);
                aDataTable.Columns[0].ColumnName = aDataTable.Columns[0].ToString().Substring(aDataTable.Columns[0].ToString().IndexOf("]") + 1, aDataTable.Columns[0].ToString().Length - 14).ToString();
            }

            if (aIsThermal)
            {
                if (isborder == 1)
                {
                    ClassName = "ThermalBorder";
                }
                else
                {
                    ClassName = "ThermalNoBorder";
                }

            }
            else
            {
                if (isborder == 1)
                {
                    ClassName = "TableStyle1";
                }
                else
                {
                    ClassName = "TableStyle1NoBorder";
                }

            }
            sr.WriteLine("<table class=\"" + ClassName + "\">");

            sr.WriteLine("<tr>");
            foreach (DataColumn col in aDataTable.Columns)
            {
                if (col.ColumnName.IndexOf("<th") == -1)
                {
                    sr.WriteLine("<th>");
                }
                sr.WriteLine(col.ColumnName + "</th>"); //first th is added in the column name to control the width manually
            }
            sr.WriteLine("</tr>");
            foreach (DataRow row in aDataTable.Rows)
            {
                sr.WriteLine("<tr>");
                for (int i = 0; i < aDataTable.Columns.Count; i++)
                {
                    string temp;
                    if (row[i] != null)
                    {
                        temp = row[i].ToString();
                        if (temp.IndexOf("<td") >= 0)
                        {
                            sr.WriteLine(temp);
                        }
                        else
                        {
                            sr.WriteLine("<td>" + temp + "</td>");
                        }
                    }
                    else
                    {
                        continue;
                    }

                }
                sr.WriteLine("</tr>");
            }

            sr.WriteLine(@"</table>");

            sr.Close();


        }

        void ExportToHTML(List<DataTable> aTables, List<string> aDetails, List<string> aFooter, string aFilePath, bool aIsThermal = false, bool ArabicFlowDirection = false, bool colored = false)
        {

            StreamWriter sr = new StreamWriter(aFilePath, false, UTF8Encoding.UTF8);
            string Width = aIsThermal ? " width: 350px ;" : "; width:100% ;";
            string direction = ArabicFlowDirection ? "rtl" : "ltr";
            /// Printing Headers and linking style
            sr.Write(@"<!DOCTYPE html>
            <html lang='en'>
            <head>
            <meta charset=""UTF-8"" />

            </head> ");
            //          <title> Sari Title </title> 
            //<link rel=""stylesheet"" href=""style.css"">
            #region STYLESHEET
            sr.Write("<style>/*CALCIUM|RMS REPORTING STYLE ALL RIGHT RESERVERED 2013 CALCIUM */table.TableStyle1 { table-layout: fixed;width:100%;font-family: \"simplified arabic\",arial,sans-serif;color:#333333;border-width: 1px;border-color: #a9c6c9;border-collapse: collapse;  }table.TableStyle1 th {color:#000 ;border-width: 1px;padding: 2px;border-color: #a9c6c9 ;	word-wrap:break-word;font-size:14pt;font-family:\"simplified arabic\",sans-serif;border-style: solid;}table.TableStyle1 td{text-align:center;border-width: 1px;padding: 2px;border-style: solid;border-color: #a9c6c9;word-wrap:break-word;	font-family:\"century gothic\",sans-serif;font-size:12pt;}table.TableStyle1NoBorder { table-layout: fixed;width:100%;font-family: \"simplified arabic\",arial,sans-serif;color:#333333;  }table.TableStyle1NoBorder th {color:#000 ;padding: 2px;word-wrap:break-word;font-size:14pt;font-family:\"simplified arabic\",sans-serif;}table.TableStyle1NoBorder td{text-align:center;padding: 2px;word-wrap:break-word;	font-family:\"century gothic\",sans-serif;font-size:12pt;}table.ThermalNoBorder { table-layout: fixed;width:100%;font-family: arial,sans-serif;color:#000;}table.ThermalNoBorder th {color:#000 ;text-decoration:underline;padding: 2px;word-wrap:break-word;font-size:14pt;font-weight:bold;font-family:arial,sans-serif;}table.ThermalNoBorder td{padding: 2px;word-wrap:break-word;	font-family:arial,sans-serif;font-size:12pt;font-weight:bold;}	table.ThermalBorder { table-layout: fixed;width:100%;font-family: sans-serif;color:#000;border-width: 1px;border-color: #000;border-collapse: collapse;  }table.ThermalBorder th {color:#000 ;border-width: 1px;padding: 2px;border-color: #000 ;	word-wrap:break-word;font-size:14pt;font-family:sans-serif,sans-serif;border-style: solid;font-weight:bold;}table.ThermalBorder td{border-width: 1px;padding: 2px;border-style: solid;border-color: #000;word-wrap:break-word;	font-family:arial,sans-serif;font-size:12pt;font-weight:bold;}	table.TableIsHeaderOnly { table-layout: fixed;width:100%;font-family: verdana,arial,sans-serif;}table.TableIsHeaderOnly th{color:#000000 ;width:100%;			text-decoration:underline;word-wrap:break-word;font-size:12pt;font-family: arial,sans-serif;text-align:center;}h1{width:100%;margin:0;margin-bottom:1px;font-family:  arial,tahoma,sans-serif;font-size:14pt;text-align:center;word-wrap:break-word;font-weight:bold;}h2 {width:100%;margin:0;margin-bottom:1px;font-family:  arial,tahoma,sans-serif;font-size:12pt;text-align:left;word-wrap:break-word;font-weight:normal;}h3 {width:100%;margin:0;margin-bottom:1px;font-family: tahoma,sans-serif;font-size:11pt;;text-align:left;word-wrap:break-word;font-weight:normal;}footer {footer-layout: fixed;<!--background: #ccc;-->width:100%;}footer p{<!--color:#000;-->font-size:14pt;font-weight:bold;font-family: tahoma, sans-serif;text-align:center;margin:1;padding:10px ;}hr {border: 0;border-bottom: 1px dashed #000;background: #fff;	}.oddrowcolor{background-color:#d4e3e5;/*d4e3e5*/}.evenrowcolor{background-color:#c3dde0;/*#c3dde0*/}</style>");

            #endregion STYLESHEET
            sr.WriteLine("<body dir=\"" + direction + "\">");
            sr.WriteLine("<center>");
            sr.WriteLine("<div style=\"" + Width + "\" >");
            if (ConfigurationHelper.IsPrintLogoEnabled()) //LOGO
            {
                sr.WriteLine("<div style=\"text-align: center\">");
                sr.WriteLine("<img src=\"" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\logo.jpg\" style=\"float: middle;\" alt=\"logo\" />");
                sr.WriteLine("</div>");
            }
            List<string> details = new List<string>(aDetails);

            for (int i = 0; i < details.Count; i++)
            {
                if (details[i] == null) //bug fix V01I Septemper 18 2013 By Sari Sultan
                {
                    continue;
                }
                if (details[i].ToString().IndexOf("<h") != -1)
                {
                    sr.WriteLine(details[i]);
                }
                else
                {
                    sr.WriteLine("<h1> " + details[i] + " </h1>");
                }

            }
            sr.Close();
            foreach (DataTable dt in aTables)
            {
                printTable(dt, aFilePath, aIsThermal);
                sr = new StreamWriter(aFilePath, true, UTF8Encoding.UTF8);
                sr.Close();
            }

            sr = new StreamWriter(aFilePath, true, UTF8Encoding.UTF8);
            List<string> dd = new List<string>(aFooter);
            sr.WriteLine("<footer>");
            sr.WriteLine("<br><br>");
            for (int i = 0; i < dd.Count; i++)
            {
                sr.WriteLine("<h1> " + dd[i] + "</h1>");
            }
            sr.WriteLine("</footer>");

            sr.WriteLine("</center>");
            if (colored && !aIsThermal)
            {
                //sr.WriteLine("<script src=\"AlternateColors.js\"></script>");
                sr.WriteLine("<script> function altRows(table){ if(document.getElementsByTagName){ var table = table; if(table.rows.length==1) { table.className=\"TableIsHeaderOnly\"; } else {var rows = table.getElementsByTagName(\"tr\"); 	for(i = 0; i < rows.length; i++){ if(i % 2 == 0 ){rows[i].className = \"evenrowcolor\";} else{rows[i].className = \"oddrowcolor\";} } }}} window.onload=function(){ var tables = document.getElementsByTagName(\"TABLE\"); for (var i=tables.length-1; i>=0;i-=1) if (tables[i]) altRows(tables[i]); } </script>");
            }
            sr.WriteLine("</body>");
            sr.WriteLine("</html>");

            
            sr.Close();
            using (StreamReader areader=new StreamReader(aFilePath,UTF8Encoding.UTF8))
            { Reports.ReportsHelper.__HTMLPage = areader.ReadToEnd(); }

        }

        public void PrintTables(List<DataTable> aTables, List<string> aDetails, List<string> aFooter, string aLogoPath, string aFilePath, bool aIsThermal = false, bool print = false, bool savepdf = false, string pdfdir = "", bool saveexcel2003 = false, string excel2003dir = "", bool colored = false, bool ForceRTL = false)
        {
            try
            {
                DateTime StartTime = DateTime.Now;
                ExportToHTML(aTables, aDetails, aFooter, aFilePath, aIsThermal, (aIsThermal || ForceRTL) ? Reports.ReportsHelper.ReceiptRTL : Reports.ReportsHelper.RTL, colored);
                //Process p = new Process();
                if (print || savepdf)
                {
                    using (var sr = new StreamReader(aFilePath))
                    {
                        var str = sr.ReadToEnd();
                        sr.Close();
                        using (var wk = new MultiplexingConverter())
                        {
                            var tmp = wk.Convert(str);
                            if (print)
                            {
                               string  PDFFilePath = aFilePath.Replace(".html", ".pdf");
                               File.WriteAllBytes(PDFFilePath, tmp);
                               PrintPDFs(PDFFilePath);
                            }
                            else if (savepdf)
                            {
                                pdfdir = pdfdir.Replace(".html", "");
                                File.WriteAllBytes(pdfdir, tmp);
                            }
                            wk.Dispose();                           
                        }
                    }
                    //p.StartInfo.FileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\wkhtmltopdf.exe";
                    //p.StartInfo.CreateNoWindow = true;
                    //p.StartInfo.UseShellExecute = false;
                    //if (print)
                    //{
                    //    p.StartInfo.Arguments = "-q \"" + aFilePath + "\" \"" + aFilePath + ".pdf\"";
                    //    p.Start();
                    //    p.WaitForExit(1000);
                    //    PrintPDFs(aFilePath + ".pdf");
                    //}
                    //else if (savepdf)
                    //{
                    //    p.StartInfo.Arguments = "\"" + aFilePath + "\" \"" + pdfdir + "\"";
                    //    p.Start();
                    //    p.WaitForExit();
                    //}
                }
                else if (saveexcel2003)
                {
                    System.IO.File.Copy(aFilePath, excel2003dir, true);
                }

                //TimeSpan ts = DateTime.Now.Subtract(StartTime);
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                //        ts.Hours, ts.Minutes, ts.Seconds,
                //        ts.Milliseconds / 10);
                //MessageBox.Show("IncreaseBtn_Click=" + elapsedTime);
                File.Delete(aFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing Manager ERROR"+ex.Message+ex.ToString());
            }
        }

        public void OpenCashDrawer()
        {
            PrintDocument aEmptyDocument = new PrintDocument();
            // aEmptyDocument.PrintPage += new PrintPageEventHandler(aPrintDocument_PrintPage);
            aEmptyDocument.Print();
            //string aFilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Empty.html";
            //StreamWriter sr = new StreamWriter(aFilePath, true, UTF8Encoding.UTF8);
            //sr.Close();
            //Process p = new Process();
            //p.StartInfo.FileName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\wkhtmltopdf.exe";
            //p.StartInfo.CreateNoWindow = true;
            //p.StartInfo.UseShellExecute = false;
            //p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //p.StartInfo.Arguments = "-q \"" + aFilePath + "\" \"" + aFilePath + ".pdf\"";
            //p.Start();
            //p.WaitForExit();
            //PrintPDFs(aFilePath + ".pdf",true);

        }

        void aPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            DateTime starttime = DateTime.Now;
            Graphics _agraphic = e.Graphics;

            _agraphic.PageScale = 0;
            _agraphic.PixelOffsetMode = 0;
            //Font _font = new Font("Tahoma", 12);

            //float _fontHeight = Font.GetHeight();

            //int _startX = 10;
            //int _startY = 10;
            //int _offset = 40;
            //PointF _x = new PointF();
            //_x.X = _startX;
            //_x.Y = _startY + _offset;

            //PointF _y = new PointF();
            //_y.X = _startX + 300;
            //_y.Y = _startY + _offset;

            //_agraphic.DrawString("Welcome To Saritoz Supermarket", new Font("Century Gothic", 12), new SolidBrush(Color.Black), _startX, _startY);
            //_agraphic.DrawLine(new Pen(Color.Black), _x, _y);
            //_offset += 5;
            //foreach (string _string in _List)
            //{
            //    _agraphic.DrawString(_string, _font, new SolidBrush(Color.Black), _startX, _startY + _offset);
            //    _offset += (int)FontHeight + 5;
            //}
            //_offset += 20;
            //_agraphic.DrawString("Thanks you Missu".PadRight(30) + string.Format("{0:c}", 200), _font, new SolidBrush(Color.Black), _startX, _startY + _offset);

            //TimeSpan ts = DateTime.Now.Subtract(starttime);
            //string et = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);



        }

        public void PrintPDFs(string pdfFileName, bool OpenCash = false)
        {
            PrintingThreadObjects firstThreadObject = new PrintingThreadObjects();
            firstThreadObject.Name = pdfFileName;

            Thread PrintThread = new Thread(PrintingThreadFunc);
            PrintThread.Start(firstThreadObject);

        }

        private void PrintingThreadFunc(object parameter)
        {
            PrintingThreadObjects threadObject = parameter as PrintingThreadObjects;
            try
            {
                Process proc = new Process();
                //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                // proc.StartInfo.Verb = "print";
                //Define location of adobe reader/command line
                //switches to launch adobe in "print" mode
                PrinterSettings settings = new PrinterSettings();
                proc.StartInfo = new ProcessStartInfo(threadObject.Name);
                proc.StartInfo.Arguments = settings.PrinterName;
                proc.StartInfo.Verb = "print";
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //  proc.StartInfo.FileName = threadObject.Name;// @"C:\Program Files (x86)\Foxit Software\Foxit Reader\Foxit Reader.exe";
                // @"C:\Program Files (x86)\Adobe\Reader 11.0\Reader\AcroRd32.exe";
                //  proc.StartInfo.Arguments = string.Format(@"-p");
                proc.Start();
                //proc.StartInfo.UseShellExecute = false;
                //proc.StartInfo.CreateNoWindow = true;
                //proc.StartInfo.Arguments = String.Format(@"/p /h {0}", threadObject.Name);
                //proc.Start();
                //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {
                    proc.WaitForExit(10000);
                }
                //proc.EnableRaisingEvents = true;
                //proc.Close();
                //KillAdobe("AcroRd32");
                threadObject.Result = "Done Successfully";
                resultValue(threadObject);
            }
            catch (Exception ex)
            {
                threadObject.Result = "Thread Error! {EXCEPTION}\n" + ex.Message;
                resultValue(threadObject);
            }
        }

        private static bool KillAdobe(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses().Where(
                         clsProcess => clsProcess.ProcessName.StartsWith(name)))
            {
                clsProcess.Kill();
                return true;
            }
            return false;
        }

    }

}