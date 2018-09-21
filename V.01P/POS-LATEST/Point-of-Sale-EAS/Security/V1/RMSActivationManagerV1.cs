using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Linq;
using System.Xml;


namespace Calcium_RMS.Security.V1
{
    public class RMSActivationManagerV1
    {
        private class Win32_BIOS
        {
            public ushort[] BiosCharacteristics;
            public string[] BIOSVersion;
            public string BuildNumber;
            public string Caption;
            public string CodeSet;
            public string CurrentLanguage;
            public string Description;
            public string IdentificationCode;
            public ushort? InstallableLanguages;
            public DateTime? InstallDate;
            public string LanguageEdition;
            public string[] ListOfLanguages;
            public string Manufacturer;
            public string Name;
            public string OtherTargetOS;
            public bool? PrimaryBIOS;
            public string ReleaseDate;
            public string SerialNumber;
            public string SMBIOSBIOSVersion;
            public ushort? SMBIOSMajorVersion;
            public ushort? SMBIOSMinorVersion;
            public bool? SMBIOSPresent;
            public string SoftwareElementID;
            public ushort? SoftwareElementState;
            public string Status;
            public ushort? TargetOperatingSystem;
            public string Version;
        }

        public class ClientInfo
        {
            public string ClientName { get; set; }
            public string CompanyName { get; set; }
            public string ClientEmail { get; set; }
            public string ClientPhone { get; set; }
            public string RequestDate { get; set; }
        }

        private static List<Win32_BIOS> GetBiosInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectCollection collection = searcher.Get();
            var items = new List<Win32_BIOS>();
            ushort _ObjCnt = 0;
            foreach (ManagementObject obj in collection)
            {
                var item = new Win32_BIOS();
                item.BiosCharacteristics = (ushort[])obj["BiosCharacteristics"];
                item.BIOSVersion = (string[])obj["BIOSVersion"];
                item.BuildNumber = (string)obj["BuildNumber"];
                item.Caption = (string)obj["Caption"];
                item.CodeSet = (string)obj["CodeSet"];
                item.CurrentLanguage = (string)obj["CurrentLanguage"];
                item.Description = (string)obj["Description"];
                item.IdentificationCode = (string)obj["IdentificationCode"];
                item.InstallableLanguages = (ushort?)obj["InstallableLanguages"];
                item.InstallDate = (DateTime?)obj["InstallDate"];
                item.LanguageEdition = (string)obj["LanguageEdition"];
                item.ListOfLanguages = (string[])obj["ListOfLanguages"];
                item.Manufacturer = (string)obj["Manufacturer"];
                item.Name = (string)obj["Name"];
                item.OtherTargetOS = (string)obj["OtherTargetOS"];
                item.PrimaryBIOS = (bool?)obj["PrimaryBIOS"];
                item.ReleaseDate = (string)obj["ReleaseDate"];
                item.SerialNumber = (string)obj["SerialNumber"];
                //rt.AppendText(item.SerialNumber);
                item.SMBIOSBIOSVersion = (string)obj["SMBIOSBIOSVersion"];
                item.SMBIOSMajorVersion = (ushort?)obj["SMBIOSMajorVersion"];
                item.SMBIOSMinorVersion = (ushort?)obj["SMBIOSMinorVersion"];
                item.SMBIOSPresent = (bool?)obj["SMBIOSPresent"];
                item.SoftwareElementID = (string)obj["SoftwareElementID"];
                item.SoftwareElementState = (ushort?)obj["SoftwareElementState"];
                item.Status = (string)obj["Status"];
                //  rt.AppendText(System.Environment.NewLine + item.Status);
                item.TargetOperatingSystem = (ushort?)obj["TargetOperatingSystem"];
                // rt.AppendText(System.Environment.NewLine + item.TargetOperatingSystem);
                item.Version = (string)obj["Version"];
                //  rt.AppendText(System.Environment.NewLine + item.Version);
                // BiosVersion = "BiosVersion=" + item.Version + "=BiosVersion";
                items.Add(item);
            }
            return items;
        }

        public static string GetBiosSerialNumber()
        {
            //List<Win32_BIOS> __BiosInfo = GetBiosInfo();
            //if (__BiosInfo != null)
            //{
            //    return __BiosInfo[0].SerialNumber;
            //}
            //else
            //{
            //    return null;
            //}
            return FingerPrint.GetUniqueIdentifier();
        }

       // private static string __EncDecKey = "RMSv1TestKey";

        #region RequestMessage
        public static bool GenerateRequestkey(ClientInfo aClientInfo, string SaveAsPath)
        {
            try
            {
                //throw new Exception("SARI KING");
                //List<Win32_BIOS> __BiosInfo = GetBiosInfo();
                string __ActivationInfo;
                string SoftwareName = "<SoftwareName>RMS</SoftwareName>";
                string SoftwareVersion = "<SoftwareVersion>1.00</SoftwareVersion>";
                string SerialNumber;
                string ClientName;
                string CompanyName;
                string ClientEmail;
                string ClientPhone;
                string RequestDate;


                SerialNumber = "<SerialNumber>" + GetBiosSerialNumber() + "</SerialNumber>";
                ClientName = "<ClientName>" + aClientInfo.ClientName + "</ClientName>";
                CompanyName = "<CompanyName>" + aClientInfo.CompanyName + "</CompanyName>";
                ClientPhone = "<ClientPhone>" + aClientInfo.ClientPhone + "</ClientPhone>";
                ClientEmail = "<ClientEmail>" + aClientInfo.ClientEmail + "</ClientEmail>";
                RequestDate = "<RequestDate>" + aClientInfo.RequestDate + "</RequestDate>";

                __ActivationInfo = "<RMS-REQUEST>" + SoftwareName + SoftwareVersion + SerialNumber + ClientName + CompanyName + ClientPhone + ClientEmail + RequestDate + "</RMS-REQUEST>";
                string __EncryptedActivationInfo = RSAEngine.EncryptUsingPublicKey(RSAEngine.RMSv01PublicKey, RSAEngine.RSAModulos, __ActivationInfo); //TripleDESEngine.EncryptData(__ActivationInfo, __EncDecKey);
                if (__EncryptedActivationInfo != null)
                {
                    StreamWriter _StreamWriter = new StreamWriter(SaveAsPath, false, UTF8Encoding.UTF8);
                    _StreamWriter.WriteLine(__EncryptedActivationInfo);
                    _StreamWriter.Close();
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
        #endregion RequestMessage

        #region RESPONSE
        public static ReqKeyInfo DecodeRespKey(string __EncryptedKey)
        {
            try
            {
                string DecodeMsg = RSAEngine.DecryptUsingPublicKey(RSAEngine.RMSv01PublicKey, RSAEngine.RSAModulos, __EncryptedKey);//TripleDESEngine.DecryptData(__EncryptedKey, __EncDecKey);
                return ParseRespKey(DecodeMsg);
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid Key Please Contact Your Reseller {EXCEPTION:}" + ex.Message); //this means Decryption Error
            }
        }
        public static ReqKeyInfo ParseRespKey(string aDecodedMsg)
        {
            ReqKeyInfo __ReqInfo = new ReqKeyInfo();
            var Fieldmapping = XDocument.Parse(aDecodedMsg);
            foreach (var fld in Fieldmapping.Elements("RMS-KEY"))
            {
                if (fld.Elements("SoftwareName").Count() > 0)
                {
                    __ReqInfo.SoftwareName = fld.Element("SoftwareName").Value;
                }

                if (fld.Elements("SoftwareVersion").Count() > 0)
                {
                    __ReqInfo.SoftwareVersion = fld.Element("SoftwareVersion").Value;
                }

                if (fld.Elements("SerialNumber").Count() > 0)
                {
                    __ReqInfo.SerialNumber = fld.Element("SerialNumber").Value;
                }
                if (fld.Elements("ClientName").Count() > 0)
                {
                    __ReqInfo.ClientName = fld.Element("ClientName").Value;
                }
                if (fld.Elements("CompanyName").Count() > 0)
                {
                    __ReqInfo.CompanyName = fld.Element("CompanyName").Value;
                }
                if (fld.Elements("ClientPhone").Count() > 0)
                {
                    __ReqInfo.ClientPhone = fld.Element("ClientPhone").Value;
                }
                if (fld.Elements("ClientEmail").Count() > 0)
                {
                    __ReqInfo.ClientEmail = fld.Element("ClientEmail").Value;
                }

                if (fld.Elements("RequestDate").Count() > 0)
                {
                    __ReqInfo.RequestDate = fld.Element("RequestDate").Value;
                }
            }
            return __ReqInfo;
        }
        #endregion RESPONSE

        public class ReqKeyInfo
        {
            public string SoftwareName;
            public string SoftwareVersion;
            public string SerialNumber;
            public string ClientName;
            public string CompanyName;
            public string ClientEmail;
            public string ClientPhone;
            public string RequestDate;
        }





        //---------------------
        /// <summary>
        /// Generates a 16 byte Unique Identification code of a computer
        /// Example: 4876-8DB5-EE85-69D3-FE52-8CF7-395D-2EA9
        /// </summary>
        public class FingerPrint
        {
            private static string fingerPrint = string.Empty;
            public static string GetUniqueIdentifier()
            {
                if (string.IsNullOrEmpty(fingerPrint))
                {
                    fingerPrint = GetHash("CPU >> " + cpuId() + "\nBIOS >> " +
                biosId() );//+"\nBASE >> " + baseId()
                               // + "\nDISK >> " + diskId() + "\nVIDEO >> " +
                //videoId() + "\nMAC >> " + macId()
                  //                       );
                }
                return fingerPrint;
            }
            private static string GetHash(string s)
            {
                MD5 sec = new MD5CryptoServiceProvider();
                ASCIIEncoding enc = new ASCIIEncoding();
                byte[] bt = enc.GetBytes(s);
                return GetHexString(sec.ComputeHash(bt));
            }
            private static string GetHexString(byte[] bt)
            {
                string s = string.Empty;
                for (int i = 0; i < bt.Length; i++)
                {
                    byte b = bt[i];
                    int n, n1, n2;
                    n = (int)b;
                    n1 = n & 15;
                    n2 = (n >> 4) & 15;
                    if (n2 > 9)
                        s += ((char)(n2 - 10 + (int)'A')).ToString();
                    else
                        s += n2.ToString();
                    if (n1 > 9)
                        s += ((char)(n1 - 10 + (int)'A')).ToString();
                    else
                        s += n1.ToString();
                    if ((i + 1) != bt.Length && (i + 1) % 2 == 0) s += "-";
                }
                return s;
            }
            #region Original Device ID Getting Code
            //Return a hardware identifier
            private static string identifier
            (string wmiClass, string wmiProperty, string wmiMustBeTrue)
            {
                string result = "";
                System.Management.ManagementClass mc =
            new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    if (mo[wmiMustBeTrue].ToString() == "True")
                    {
                        //Only get the first one
                        if (result == "")
                        {
                            try
                            {
                                result = mo[wmiProperty].ToString();
                                break;
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                return result;
            }
            //Return a hardware identifier
            private static string identifier(string wmiClass, string wmiProperty)
            {
                string result = "";
                System.Management.ManagementClass mc =
            new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementObject mo in moc)
                {
                    //Only get the first one
                    if (result == "")
                    {
                        try
                        {
                            if (mo[wmiProperty] != null)
                            {
                                result = mo[wmiProperty].ToString();
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            throw new Exception(ex.Message);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                return result;
            }
            private static string cpuId()
            {
                //Uses first CPU identifier available in order of preference
                //Don't get all identifiers, as it is very time consuming
                string retVal = identifier("Win32_Processor", "UniqueId");
                if (retVal == "") //If no UniqueID, use ProcessorID
                {
                    retVal = identifier("Win32_Processor", "ProcessorId");
                    if (retVal == "") //If no ProcessorId, use Name
                    {
                        retVal = identifier("Win32_Processor", "Name");
                        if (retVal == "") //If no Name, use Manufacturer
                        {
                            retVal = identifier("Win32_Processor", "Manufacturer");
                        }
                        //Add clock speed for extra security
                        retVal += identifier("Win32_Processor", "MaxClockSpeed");
                    }
                }
                return retVal;
            }
            //BIOS Identifier
            private static string biosId()
            {
                return identifier("Win32_BIOS", "Manufacturer")
                + identifier("Win32_BIOS", "SMBIOSBIOSVersion")
                + identifier("Win32_BIOS", "IdentificationCode")
                + identifier("Win32_BIOS", "SerialNumber")
                + identifier("Win32_BIOS", "ReleaseDate")
                + identifier("Win32_BIOS", "Version");
            }
            //Main physical hard drive ID
            private static string diskId()
            {
                return identifier("Win32_DiskDrive", "Model")
                + identifier("Win32_DiskDrive", "Manufacturer")
                + identifier("Win32_DiskDrive", "Signature")
                + identifier("Win32_DiskDrive", "TotalHeads");
            }
            //Motherboard ID
            private static string baseId()
            {
                return identifier("Win32_BaseBoard", "Model")
                + identifier("Win32_BaseBoard", "Manufacturer")
                + identifier("Win32_BaseBoard", "Name")
                + identifier("Win32_BaseBoard", "SerialNumber");
            }
            //Primary video controller ID
            private static string videoId()
            {
                return identifier("Win32_VideoController", "DriverVersion")
                + identifier("Win32_VideoController", "Name");
            }
            //First enabled network card ID
            private static string macId()
            {
                return identifier("Win32_NetworkAdapterConfiguration",
                    "MACAddress", "IPEnabled");
            }
            #endregion
        }
    }
}

