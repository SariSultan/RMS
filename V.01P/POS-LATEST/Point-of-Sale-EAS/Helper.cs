using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
namespace Calcium_RMS
{
    public class Helper
    {
        public static string __ConnectionString=null;
        public static void SetConnectionString()
        {           
             __ConnectionString = ConfigurationHelper.GetConnString();                         
        }
        public static bool TestConnectionString()
        {
            try
            {
                if (__ConnectionString.Contains("ERROR"))
                {
                    return false;
                }
                SqlConnection aTestCon = new SqlConnection(__ConnectionString);                
                aTestCon.Open();
                aTestCon.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public delegate void voidEvent();

        static Helper instance;
        public static Helper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Helper();
                }
                return instance;
            }
        }
        private Helper()
        {
           /* con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=" 
                + Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                + @"\DB.mdf;Integrated Security=True;User Instance=True");*/
                con = new SqlConnection(__ConnectionString);//@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Sari\DB.mdf;Integrated Security=True;User Instance=True");
            //con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\DB.mdf.mdf;Integrated Security=True;User Instance=True");
        }

        public readonly SqlConnection con;

        public login ActiveLoginWindow { get; private set; }
        public void SetLoginWindow(login aLogin)
        {
            ActiveLoginWindow = aLogin;
        }
        //public Main2 ActiveMainWindow
        //{
        //    get;
        //    private set;
        //}
        //public void SetMainWindow(Main2 aMain)
        //{
        //    ActiveMainWindow = aMain;
        //}
    }
}

