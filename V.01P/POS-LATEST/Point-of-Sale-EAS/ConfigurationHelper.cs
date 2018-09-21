using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Windows.Forms;
namespace Calcium_RMS
{
    public static class ConfigurationHelper
    {
        public static string __ConfigFilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\RMSConfig.xml";
        #region ConfigFile
        private static bool IsConfigFileExist()
        {
            try
            {
                StreamReader aReader = new StreamReader(__ConfigFilePath);
                aReader.ReadToEnd();
                aReader.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static bool CreateNewConfigFile()
        {
            try
            {
                StreamWriter aWriter = new StreamWriter(__ConfigFilePath, false);
                aWriter.WriteLine("<RMS-Config>");
                aWriter.WriteLine("</RMS-Config>");
                aWriter.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion ConfigFile

        #region DataBase
        public static bool UpdateConnString(string aNewConnString)
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    if (!CreateNewConfigFile())
                    {
                        return false; //ERROR File Not Exist and Cannot add the file
                    }
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        aXmlDoc.Add(new XElement("RMS-Config"));
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("DB").Count() == 0)
                    {
                        Root.Add(new XElement("DB"));
                    }
                    XElement DB = Root.Element("DB");
                    string TripleDESKey = Calcium_RMS.Security.RMSKeys.GetTripleDESKey();
                    string __EncryptedConnString = Calcium_RMS.Security.TripleDESEngine.EncryptData(aNewConnString, TripleDESKey);
                    if (DB.Elements("ConnString").Count() == 0)
                    {
                       
                        DB.Add(new XElement("ConnString", __EncryptedConnString));
                    }
                    else
                    {
                        DB.Element("ConnString").Value = __EncryptedConnString;
                    }
                }
                aXmlDoc.Save(__ConfigFilePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
            return false;
        }
        public static string GetConnString()
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    return "ERROR:File Not Exist";
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        return "ERROR:RMS-Config Not Exist in Configuration File";
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("DB").Count() == 0)
                    {
                        return "ERROR:DB Not Exist In Root TAG";
                    }
                    XElement DB = Root.Element("DB");
                    if (DB.Elements("ConnString").Count() == 0)
                    {

                        return "ERROR:Connection String Not Exist In DB TAG";
                    }
                    else
                    {
                        string TripleDESKey = Calcium_RMS.Security.RMSKeys.GetTripleDESKey();
                        string __DecryptedConnString = Calcium_RMS.Security.TripleDESEngine.DecryptData(DB.Element("ConnString").Value, TripleDESKey);
                        return __DecryptedConnString;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
                return "ERROR: {Exception} " + ex.Message;
            }
        }
        #endregion DataBase

        #region UI
        public static bool UpdateLanguage(string aLanguage)
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    if (!CreateNewConfigFile())
                    {
                        return false; //ERROR File Not Exist and Cannot add the file
                    }
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        aXmlDoc.Add(new XElement("RMS-Config"));
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("UI").Count() == 0)
                    {
                        Root.Add(new XElement("UI"));
                    }
                    XElement UI = Root.Element("UI");
                    if (UI.Elements("Language").Count() == 0)
                    {

                        UI.Add(new XElement("Language", aLanguage));
                    }
                    else
                    {
                        UI.Element("Language").Value = aLanguage;
                    }
                }
                aXmlDoc.Save(__ConfigFilePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
            return false;
        }
        public static string GetLanguage()
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    return "ERROR:File Not Exist";
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        return "ERROR:RMS-Config Not Exist in Configuration File";
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("UI").Count() == 0)
                    {
                        return "ERROR:UI Not Exist In Root TAG";
                    }
                    XElement UI = Root.Element("UI");
                    if (UI.Elements("Language").Count() == 0)
                    {

                        return "ERROR:Language Not Exist In UI TAG";
                    }
                    else
                    {
                        return UI.Element("Language").Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
                return "ERROR: {Exception} " + ex.Message;
            }
        }
        #endregion UI

        #region Receipt

        public static bool UpdateReceiptLanguage(string aLanguage)
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    if (!CreateNewConfigFile())
                    {
                        return false; //ERROR File Not Exist and Cannot add the file
                    }
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        aXmlDoc.Add(new XElement("RMS-Config"));
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("Receipt").Count() == 0)
                    {
                        Root.Add(new XElement("Receipt"));
                    }
                    XElement RECEIPT = Root.Element("Receipt");
                    if (RECEIPT.Elements("Language").Count() == 0)
                    {

                        RECEIPT.Add(new XElement("Language", aLanguage));
                    }
                    else
                    {
                        RECEIPT.Element("Language").Value = aLanguage;
                    }
                }
                aXmlDoc.Save(__ConfigFilePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
            return false;
        }
        public static string GetReceiptLanguage()
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    return "ERROR:File Not Exist";
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        return "ERROR:RMS-Config Not Exist in Configuration File";
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("Receipt").Count() == 0)
                    {
                        return "ERROR:Receipt Not Exist In Root TAG";
                    }
                    XElement RECEIPT = Root.Element("Receipt");
                    if (RECEIPT.Elements("Language").Count() == 0)
                    {

                        return "ERROR:Language Not Exist In Receipt TAG";
                    }
                    else
                    {
                        return RECEIPT.Element("Language").Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
                return "ERROR: {Exception} " + ex.Message;
            }
        }

        #endregion Receipt

        #region PrintingSettings
        public static bool UpdateReceiptLogo(bool Enabled)
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    if (!CreateNewConfigFile())
                    {
                        return false; //ERROR File Not Exist and Cannot add the file
                    }
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        aXmlDoc.Add(new XElement("RMS-Config"));
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("PrintingSettings").Count() == 0)
                    {
                        Root.Add(new XElement("PrintingSettings"));
                    }
                    XElement PrintingSettings = Root.Element("PrintingSettings");
                    if (PrintingSettings.Elements("LogoEnabled").Count() == 0)
                    {

                        PrintingSettings.Add(new XElement("LogoEnabled", Enabled.ToString()));
                    }
                    else
                    {
                        PrintingSettings.Element("LogoEnabled").Value = Enabled.ToString();
                    }
                }
                aXmlDoc.Save(__ConfigFilePath);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
            return false;
        }
        public static bool IsPrintLogoEnabled()
        {
            try
            {
                if (!IsConfigFileExist())
                {
                    return true;
                }
                XDocument aXmlDoc;//= XDocument.Load(__ConfigFilePath);// .Parse(__ConfigFilePath);                
                using (StreamReader reader = File.OpenText(__ConfigFilePath))
                {
                    aXmlDoc = XDocument.Load(reader);
                    reader.Dispose();
                    if (aXmlDoc.Elements("RMS-Config").Count() == 0)
                    {
                        return true;
                    }
                    XElement Root = aXmlDoc.Element("RMS-Config");
                    if (Root.Elements("PrintingSettings").Count() == 0)
                    {
                        return true;
                    }
                    XElement PrintingSettings = Root.Element("PrintingSettings");
                    if (PrintingSettings.Elements("LogoEnabled").Count() == 0)
                    {

                        return true;
                    }
                    else
                    {
                        return Convert.ToBoolean(PrintingSettings.Element("LogoEnabled").Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
                return true;
            }
        }
        #endregion
    }
}
