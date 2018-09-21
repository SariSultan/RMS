using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Text;
using System.IO;
namespace Calcium_RMS.Security.V1
{
	public static class ActivationCheck
	{
        public static bool __IsTrialVersion = true;
        public static bool __IsTrialValid = false;
        public static bool __IsRegisteredVersion = false;
        public static string __RegisteredTo;
        public static int TrialNumberOfItems = 15;
        public static int NumberOfItemsInTheSystem;
        public static void IsTrialValidTellNow()
        {
            Nullable<int> NumberOfItems = ItemsMgmt.SelectNumberOfItems();
            if (NumberOfItems == null)
            {
                MessageBox.Show("ERROR 0x01 " + MsgTxt.DataBaseErrorTxt + " " + MsgTxt.PleaseCheckSQLServiceTxt, MsgTxt.DataBaseErrorTxt, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
                Application.Exit();
            }
            else
            {
                NumberOfItemsInTheSystem = int.Parse(NumberOfItems.ToString());
                if (NumberOfItems < TrialNumberOfItems)
                {
                    __IsTrialValid = true;
                }
                else
                {
                    __IsTrialValid = false;
                }
            }
        }

        public static void TrialCheck()
        {
            StreamReader aReader = null;
            try
            {
                aReader = new StreamReader(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\\key.RMSKey");
            }
            catch (System.IO.FileNotFoundException)
            {
                __IsTrialVersion = true;
                IsTrialValidTellNow();
                return;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                __IsTrialVersion = true;
                IsTrialValidTellNow();
                return;

            }
            catch (Exception) //any exception happens
            {
                __IsTrialVersion = true;
                IsTrialValidTellNow();
                return;

            }
            string __ResponseKey = aReader.ReadToEnd();
            try
            {

                RMSActivationManagerV1.ReqKeyInfo __KeyInfo = RMSActivationManagerV1.DecodeRespKey(__ResponseKey);
                DateTime __StartTime = DateTime.Now;
                string aBiosSerial = RMSActivationManagerV1.GetBiosSerialNumber();
                TimeSpan __TimeSpan = DateTime.Now.Subtract(__StartTime);
                string __ET = string.Format("{0:00}.{1:00}.{2:00}:{3:000}", __TimeSpan.Hours, __TimeSpan.Minutes, __TimeSpan.Seconds, __TimeSpan.Milliseconds);
                //MessageBox.Show("ET=" + __ET);
                if (__KeyInfo != null)
                {
                    if (__KeyInfo.SerialNumber == aBiosSerial)
                    {
                        __IsRegisteredVersion = true;
                        __IsTrialVersion = false;
                        __RegisteredTo = __KeyInfo.ClientName + " " + __KeyInfo.CompanyName;
                    }
                    else
                    {
                        IsTrialValidTellNow();
                    }
                }
                else
                {

                    IsTrialValidTellNow();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                IsTrialValidTellNow();
            }
           
        }
	}
}
