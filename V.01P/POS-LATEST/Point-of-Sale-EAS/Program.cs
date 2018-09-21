using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Calcium_RMS.Text;
using Calcium_RMS.Security.V1;
using System.IO;
using Calcium_RMS.Management;
using System.ServiceProcess;
using System.Reflection;
namespace Calcium_RMS
{


    public static class StartUpHelper
    {

    }
    static class Program
    {

        public static Assembly ribbon = null;

        static void TestSqlService()
        {
            try
            {
                string SqlExpreesSrvName = "MSSQL$SQLEXPRESS"; //service name of SQL Server Express
                string SqlServSrvName = "MSSQLSERVER"; //service name of SQL Server Express
                string status = ""; //service status (For example, Running or Stopped)
                //StatusLbl.Text = "Service: " + SqlExpreesSrvName;
                //display service status: For example, Running, Stopped, or Paused
                ServiceController mySC = new ServiceController(SqlExpreesSrvName);
                try
                {
                    try
                    {
                        status = mySC.Status.ToString();
                    }
                    catch 
                    {
                        mySC = new ServiceController(SqlServSrvName);
                        status = mySC.Status.ToString();
                    }
                    //display service status: For example, Running, Stopped, or Paused
                    //StatusLbl.Text = ("Service status : " + status);
                    //if service is Stopped or StopPending, you can run it with the following code.
                    if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
                    {
                        try
                        {
                            //StatusLbl.Text = ("Starting the service...");
                            mySC.Start();
                            mySC.WaitForStatus(ServiceControllerStatus.Running);
                            //StatusLbl.Text = ("The service is now " + mySC.Status.ToString());
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error in starting the SQLEXPRESS service: /PLEASE TRY AGAIN" + ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("SQL Express Service Is Not Found, Please Install It And Rerun the Software. [exception=" + ex.Message + "]");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                /*  string resource = "Calcium_RMS.System.Windows.Forms.Ribbon35.dll";
                  using (Stream stm = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                  {
                      byte[] ba = new byte[(int)stm.Length];
                      stm.Read(ba, 0, (int)stm.Length);
                      ribbon = Assembly.Load(ba);
                  }
                  AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
                  */
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                try
                {
                    TestSqlService();
                    Helper.SetConnectionString();
                    if (!Helper.TestConnectionString())
                    {
                        if (Helper.__ConnectionString == "ERROR:File Not Exist")
                        {
                            string Ret = MessageBox.Show("Cannot Connect To Database \n If This Is Your First Run For the Program Press Yes To Create New DataBase \n WARNING: if you already have a database click no to protect your database from being removed", "DATABASE", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2).ToString();
                            if (Ret == "Yes")
                            {
                                try
                                {
                                    string ExecDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                                    string DBEmpDir = @"\RMSV1.1EmptyDB";
                                    File.Copy(ExecDir + DBEmpDir + @"\DB.mdf", ExecDir + @"\DataBase.mdf");
                                    File.Copy(ExecDir + DBEmpDir + @"\DB_log.ldf", ExecDir + @"\DataBase_log.ldf");
                                    string ConnStringnew = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + ExecDir + @"\Database.mdf;Integrated Security=True;User Instance=True";
                                    ConfigurationHelper.UpdateConnString(ConnStringnew);
                                    MessageBox.Show("New DataBase Created Successfully, Application will restart now default logins \n Username : Admin \n Password: Admin \n note: username and password are not case sensitive", "Created succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("It seems you have a working database\nTo prevent your data loss the program will not continue\nFailed To Create New Database, Please Contact System Administrator \n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    Application.ExitThread();
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.ExitThread();
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cannot Connect To Database Error In Connection String", "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Run(new ConnStringFrm());
                        }
                    }
                    else
                    {
                        Application.Run(new SplashFrm());
                        //DateTime __StartTime = DateTime.Now;
                        // Helper.SetConnectionString();
                        // Security.V1.ActivationCheck.TrialCheck();
                        string LangCheck;
                        LangCheck = ConfigurationHelper.GetReceiptLanguage();
                        if (!LangCheck.Contains("ERROR"))
                        {
                            if (LangCheck.ToUpper() == "ARABIC")
                            {
                                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-JO");
                                Reports.ReportsHelper.ReceiptRTL = true;
                                ReceiptName.TranslateReceiptText();
                                ReceiptText.TranslateReceiptText();
                                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                                //TRANSLATE RECIEPT
                            }
                            else
                            {
                                Reports.ReportsHelper.ReceiptRTL = false;
                                ReceiptName.TranslateReceiptText();
                                ReceiptText.TranslateReceiptText();
                            }
                        }
                        else
                        {
                            Reports.ReportsHelper.ReceiptRTL = false;
                            ReceiptName.TranslateReceiptText();
                            ReceiptText.TranslateReceiptText();
                        }
                        LangCheck = ConfigurationHelper.GetLanguage();
                        if (!LangCheck.Contains("ERROR"))
                        {
                            if (LangCheck.ToUpper() == "ARABIC")
                            {
                                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-JO");
                            }
                        }
                        UiText.TranslateUiText();
                        MsgTxt.TranslateMsgsTxt();
                        FormsNames.TranslateFormsNames();

                        //TimeSpan __TimeSpan = DateTime.Now.Subtract(__StartTime);
                        //string __ET = string.Format("{0:00}.{1:00}.{2:00}:{3:000}", __TimeSpan.Hours, __TimeSpan.Minutes, __TimeSpan.Seconds, __TimeSpan.Milliseconds);
                        //MessageBox.Show("ET=" + __ET);
                        Application.Run(new login());
                        int x = 100;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message \n" + ex.ToString());
            }
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("System.Windows.Forms.Ribbon35"))
            {
                return ribbon;
            }
            return null;
        }
    }
}
