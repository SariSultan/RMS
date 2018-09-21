using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace Calcium_RMS.Security
{
    
    public static class TripleDESEngine
    {
        private static byte[] encrypted;

        public static string EncryptData(string DataToEncrypt, string __EncryptionKey)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider aTDES = new TripleDESCryptoServiceProvider();
                aTDES.Key = md5.ComputeHash(utf8.GetBytes(__EncryptionKey));
                aTDES.Mode = CipherMode.ECB;
                aTDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform trans = aTDES.CreateEncryptor();
                encrypted = trans.TransformFinalBlock(utf8.GetBytes(DataToEncrypt), 0, utf8.GetBytes(DataToEncrypt).Length);
                string Result = BitConverter.ToString(encrypted);
                return Result;
            }
            catch (Exception ex)
            {
                throw new Exception("Calcium Security Provider Encryption Error {Exeption:}" + ex.Message);
            }
        }

        public static string DecryptData(string DataToDecrypt, string __DecryptionKey)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding utf8 = new UTF8Encoding();
                TripleDESCryptoServiceProvider aTDES = new TripleDESCryptoServiceProvider();
                aTDES.Key = md5.ComputeHash(utf8.GetBytes(__DecryptionKey));
                aTDES.Mode = CipherMode.ECB;
                aTDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform trans = aTDES.CreateDecryptor();
                String[] arr = DataToDecrypt.Split('-');

                byte[] EncryptedArray = new byte[arr.Length];

                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > 2)
                    {
                        arr[i] = arr[i].Substring(0, 2);
                    }
                    EncryptedArray[i] = Convert.ToByte(arr[i], 16);
                }
                string Result = utf8.GetString(trans.TransformFinalBlock(EncryptedArray, 0, EncryptedArray.Length));
                return Result;
            }
            catch (Exception ex)
            {
                throw new Exception("Calcium Security Provider Decryption Error {Exeption:}" + ex.Message);
            }
        }

    }
}
