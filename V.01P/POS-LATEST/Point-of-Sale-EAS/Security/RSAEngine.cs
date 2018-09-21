using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Numerics;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Calcium_RMS.Security
{
    public static class RSAEngine
    {
        /// <summary>
        /// SHA 512 , Modulos 6144, Key Added By Sari Sultan On Septemper 24.
        /// </summary>
        public static string RMSv01PublicKey = "<RSAKeyValue><Modulus>n9FvsP3rmVULO5/kQdZ5Y3ZJ8FAn/ABjbkAHqpcHNd18OnlR47icFXgzKdE9D9pZbUQnF+GgWzGp6xCUmOaH68lP0/hGpJY38a54bYLfUqDpGK1+7qga+7pJ10+/QT7TYMqt16gmeOaGq1JsH5p0xN8YIfygCKZozQqKceaZN+jT9SlVx/AFBAq4biANr3+vtBjDY4sAPIL+8g8GZNiB8FFNEeRvsSzxC9N/hCARFpuhMYcM2Xi9aJPWe5GY4IGas+vcKgkJc2S3DQFYwx72iOZD6W4Gim/UOHglSORg6fAJtDJo7Wvj8UyUs8ZHDZM+BMQkMR4w1EpeJ8gClnzkxUkn3AyeIoI64lHyIG/MfiDtNL3sKX0nLeMYYM52WGOrVKs2908jGYJBiA8QmpNAAe26F6aFICkablAoOcyKwpEOLnh5J2hqubExRxh7L3FFn+cVGdzkHig7nRbm4cYrVRHt09hIv7qxqWaKLFaKaQ3EWmy8bpYNO2yrLiigK9LeqyXvwfZYS/Lr9h2IEI3vBwSyaQAuYV638KSimZ+kL1EFcfbgBL4X7kJrCqjIxgxU8ydgjfbcDdnP5FzwLWvwJYGPb1JM6VH7A4QSqacnoHY2oJhotm0hVSxZdkiASVYncLQb+mNSFUBMIwmrhdXDfCpFrIRhjTvhSEOv5BW7M+srFLNIYy/7vw4CbXihvkZ98q9Jp7wqdmvtc/0vL0+xrZQ6oTHyi1wgkrDSGwAhvkFpMyM8C7pZNWb/YRgKq/z2lx4OBcs3UVW6wrpxgbZ1p9E4RLIy7KKW7EoXZDtJcmm5bq2ZtJTBckrqhN2LhzNoCdV21qtx3xKFNehbKplOlpiM605aCijZCAngPEInNQAJq8Qj1mpcZZSTU68MMBm8xs/BVlfewAD7DWfjLNqf9quGvSPPcEfbiBAB+84uqfae3PPO82FJ/pJg++NMcYyMW+6YM1mQOEd865yqWp9uZPw1WJ2hwwZaYNSe9DrTvVTCZv93jJdP+/2x2j1wLETn</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        public static int RSAModulos = 6144;
        public static string EncryptUsingPublicKey(string PublicKey,int ModulosSize,string DataToEncrypt)
        {
            try
            {                
                RSAx rsax = new RSAx(PublicKey,ModulosSize);
                rsax.RSAxHashAlgorithm = RSAxParameters.RSAxHashAlgorithm.SHA512;// ha_types[comboBox_OAEP_Hash.SelectedIndex];
                byte[] CT = rsax.Encrypt(Encoding.UTF8.GetBytes(DataToEncrypt), false, false);
                return Convert.ToBase64String(CT);                 
            }
            catch (System.Exception ex)
            {
                throw new CryptographicException("Exception while Encryption: " + ex.Message);
            }
        }

        public static string EncryptUsingPrivateKey(string PrivateKey, int ModulosSize, string DataToEncrypt)
        {
            try
            {
                RSAx rsax = new RSAx(PrivateKey, ModulosSize);
                rsax.RSAxHashAlgorithm = RSAxParameters.RSAxHashAlgorithm.SHA512;// ha_types[comboBox_OAEP_Hash.SelectedIndex];
                byte[] CT = rsax.Encrypt(Encoding.UTF8.GetBytes(DataToEncrypt), true, false);
                return Convert.ToBase64String(CT);
            }
            catch (System.Exception ex)
            {
                throw new CryptographicException("Exception while Encryption: " + ex.Message);
            }
        }

        public static string DecryptUsingPublicKey(string PublicKey, int ModulosSize, string DataToDecrypt)
        {
            try
            {
                RSAx rsax = new RSAx(PublicKey, ModulosSize);
                rsax.RSAxHashAlgorithm = RSAxParameters.RSAxHashAlgorithm.SHA512;// ha_types[comboBox_OAEP_Hash.SelectedIndex];
                byte[] PT = rsax.Decrypt(Convert.FromBase64String(DataToDecrypt), false ,false);
                return Encoding.UTF8.GetString(PT);
            }
            catch (System.Exception ex)
            {
                throw new CryptographicException ("Exception while Decryption: " + ex.Message);
            }
        }

        public static string DecryptUsingPrivateKey(string PrivateKey, int ModulosSize, string DataToDecrypt)
        {
            try
            {
                RSAx rsax = new RSAx(PrivateKey, ModulosSize);
                rsax.RSAxHashAlgorithm = RSAxParameters.RSAxHashAlgorithm.SHA512;// ha_types[comboBox_OAEP_Hash.SelectedIndex];
                byte[] PT = rsax.Decrypt(Convert.FromBase64String(DataToDecrypt), true, false);
                return Encoding.UTF8.GetString(PT);
            }
            catch (System.Exception ex)
            {
                throw new CryptographicException("Exception while Decryption: " + ex.Message);
            }
        }
    }

    /// <summary>
    /// The main RSAx Class
    /// </summary>
    public class RSAx : IDisposable
    {
        private RSAxParameters rsaParams;
        private RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        /// <summary>
        /// Initialize the RSA class.
        /// </summary>
        /// <param name="rsaParams">Preallocated RSAxParameters containing the required keys.</param>
        public RSAx(RSAxParameters rsaParams)
        {
            this.rsaParams = rsaParams;
            UseCRTForPublicDecryption = true;
        }

        /// <summary>
        /// Initialize the RSA class from a XML KeyInfo string.
        /// </summary>
        /// <param name="keyInfo">XML Containing Key Information</param>
        /// <param name="ModulusSize">Length of RSA Modulus in bits.</param>
        public RSAx(String keyInfo, int ModulusSize)
        {
            this.rsaParams = RSAxUtils.GetRSAxParameters(keyInfo, ModulusSize);
            UseCRTForPublicDecryption = true;
        }

        /// <summary>
        /// Hash Algorithm to be used for OAEP encoding.
        /// </summary>
        public RSAxParameters.RSAxHashAlgorithm RSAxHashAlgorithm
        {
            set
            {
                rsaParams.HashAlgorithm = value;
            }
        }

        /// <summary>
        /// If True, and if the parameters are available, uses CRT for private key decryption. (Much Faster)
        /// </summary>
        public bool UseCRTForPublicDecryption
        {
            get;
            set;
        }

        /// <summary>
        /// Releases all the resources.
        /// </summary>
        public void Dispose()
        {
            rsaParams.Dispose();
        }

        #region PRIVATE FUNCTIONS

        /// <summary>
        /// Low level RSA Process function for use with private key.
        /// Should never be used; Because without padding RSA is vulnerable to attacks.  Use with caution.
        /// </summary>
        /// <param name="PlainText">Data to encrypt. Length must be less than Modulus size in octets.</param>
        /// <param name="usePrivate">True to use Private key, else Public.</param>
        /// <returns>Encrypted Data</returns>
        public byte[] RSAProcess(byte[] PlainText, bool usePrivate)
        {

            if (usePrivate && (!rsaParams.Has_PRIVATE_Info))
            {
                throw new CryptographicException("RSA Process: Incomplete Private Key Info");
            }

            if ((usePrivate == false) && (!rsaParams.Has_PUBLIC_Info))
            {
                throw new CryptographicException("RSA Process: Incomplete Public Key Info");
            }

            BigInteger _E;
            if (usePrivate)
                _E = rsaParams.D;
            else
                _E = rsaParams.E;

            BigInteger PT = RSAxUtils.OS2IP(PlainText, false);
            BigInteger M = BigInteger.ModPow(PT, _E, rsaParams.N);

            if (M.Sign == -1)
                return RSAxUtils.I2OSP(M + rsaParams.N, rsaParams.OctetsInModulus, false);
            else
                return RSAxUtils.I2OSP(M, rsaParams.OctetsInModulus, false);
        }

        /// <summary>
        /// Low level RSA Decryption function for use with private key. Uses CRT and is Much faster.
        /// Should never be used; Because without padding RSA is vulnerable to attacks. Use with caution.
        /// </summary>
        /// <param name="Data">Data to encrypt. Length must be less than Modulus size in octets.</param>
        /// <returns>Encrypted Data</returns>
        public byte[] RSADecryptPrivateCRT(byte[] Data)
        {
            if (rsaParams.Has_PRIVATE_Info && rsaParams.HasCRTInfo)
            {
                BigInteger C = RSAxUtils.OS2IP(Data, false);

                BigInteger M1 = BigInteger.ModPow(C, rsaParams.DP, rsaParams.P);
                BigInteger M2 = BigInteger.ModPow(C, rsaParams.DQ, rsaParams.Q);
                BigInteger H = ((M1 - M2) * rsaParams.InverseQ) % rsaParams.P;
                BigInteger M = (M2 + (rsaParams.Q * H));

                if (M.Sign == -1)
                    return RSAxUtils.I2OSP(M + rsaParams.N, rsaParams.OctetsInModulus, false);
                else
                    return RSAxUtils.I2OSP(M, rsaParams.OctetsInModulus, false);
            }
            else
            {
                throw new CryptographicException("RSA Decrypt CRT: Incomplete Key Info");
            }
        }

        private byte[] RSAProcessEncodePKCS(byte[] Message, bool usePrivate)
        {
            if (Message.Length > rsaParams.OctetsInModulus - 11)
            {
                throw new ArgumentException("Message too long.");
            }
            else
            {
                // RFC3447 : Page 24. [RSAES-PKCS1-V1_5-ENCRYPT ((n, e), M)]
                // EM = 0x00 || 0x02 || PS || 0x00 || Msg 

                List<byte> PCKSv15_Msg = new List<byte>();

                PCKSv15_Msg.Add(0x00);
                PCKSv15_Msg.Add(0x02);

                int PaddingLength = rsaParams.OctetsInModulus - Message.Length - 3;

                byte[] PS = new byte[PaddingLength];
                rng.GetNonZeroBytes(PS);

                PCKSv15_Msg.AddRange(PS);
                PCKSv15_Msg.Add(0x00);

                PCKSv15_Msg.AddRange(Message);

                return RSAProcess(PCKSv15_Msg.ToArray(), usePrivate);
            }
        }

        /// <summary>
        /// Mask Generation Function
        /// </summary>
        /// <param name="Z">Initial pseudorandom Seed.</param>
        /// <param name="l">Length of output required.</param>
        /// <returns></returns>
        private byte[] MGF(byte[] Z, int l)
        {
            if (l > (Math.Pow(2, 32)))
            {
                throw new ArgumentException("Mask too long.");
            }
            else
            {
                List<byte> result = new List<byte>();
                for (int i = 0; i <= l / rsaParams.hLen; i++)
                {
                    List<byte> data = new List<byte>();
                    data.AddRange(Z);
                    data.AddRange(RSAxUtils.I2OSP(i, 4, false));
                    result.AddRange(rsaParams.ComputeHash(data.ToArray()));
                }

                if (l <= result.Count)
                {
                    return result.GetRange(0, l).ToArray();
                }
                else
                {
                    throw new ArgumentException("Invalid Mask Length.");
                }
            }
        }


        private byte[] RSAProcessEncodeOAEP(byte[] M, byte[] P, bool usePrivate)
        {
            //                           +----------+---------+-------+
            //                      DB = |  lHash   |    PS   |   M   |
            //                           +----------+---------+-------+
            //                                          |
            //                +----------+              V
            //                |   seed   |--> MGF ---> XOR
            //                +----------+              |
            //                      |                   |
            //             +--+     V                   |
            //             |00|    XOR <----- MGF <-----|
            //             +--+     |                   |
            //               |      |                   |
            //               V      V                   V
            //             +--+----------+----------------------------+
            //       EM =  |00|maskedSeed|          maskedDB          |
            //             +--+----------+----------------------------+

            int mLen = M.Length;
            if (mLen > rsaParams.OctetsInModulus - 2 * rsaParams.hLen - 2)
            {
                throw new ArgumentException("Message too long.");
            }
            else
            {
                byte[] PS = new byte[rsaParams.OctetsInModulus - mLen - 2 * rsaParams.hLen - 2];
                //4. pHash = Hash(P),
                byte[] pHash = rsaParams.ComputeHash(P);

                //5. DB = pHash||PS||01||M.
                List<byte> _DB = new List<byte>();
                _DB.AddRange(pHash);
                _DB.AddRange(PS);
                _DB.Add(0x01);
                _DB.AddRange(M);
                byte[] DB = _DB.ToArray();

                //6. Generate a random octet string seed of length hLen.                
                byte[] seed = new byte[rsaParams.hLen];
                rng.GetBytes(seed);

                //7. dbMask = MGF(seed, k - hLen -1).
                byte[] dbMask = MGF(seed, rsaParams.OctetsInModulus - rsaParams.hLen - 1);

                //8. maskedDB = DB XOR dbMask
                byte[] maskedDB = RSAxUtils.XOR(DB, dbMask);

                //9. seedMask = MGF(maskedDB, hLen)
                byte[] seedMask = MGF(maskedDB, rsaParams.hLen);

                //10. maskedSeed = seed XOR seedMask.
                byte[] maskedSeed = RSAxUtils.XOR(seed, seedMask);

                //11. EM = 0x00 || maskedSeed || maskedDB.
                List<byte> result = new List<byte>();
                result.Add(0x00);
                result.AddRange(maskedSeed);
                result.AddRange(maskedDB);

                return RSAProcess(result.ToArray(), usePrivate);
            }
        }


        private byte[] Decrypt(byte[] Message, byte[] Parameters, bool usePrivate, bool fOAEP)
        {
            byte[] EM = new byte[0];
            try
            {
                if ((usePrivate == true) && (UseCRTForPublicDecryption) && (rsaParams.HasCRTInfo))
                {
                    EM = RSADecryptPrivateCRT(Message);
                }
                else
                {
                    EM = RSAProcess(Message, usePrivate);
                }
            }
            catch (CryptographicException ex)
            {
                throw new CryptographicException("Exception while Decryption: " + ex.Message);
            }
            catch
            {
                throw new Exception("Exception while Decryption: ");
            }

            try
            {
                if (fOAEP) //DECODE OAEP
                {
                    if ((EM.Length == rsaParams.OctetsInModulus) && (EM.Length > (2 * rsaParams.hLen + 1)))
                    {
                        byte[] maskedSeed;
                        byte[] maskedDB;
                        byte[] pHash = rsaParams.ComputeHash(Parameters);
                        if (EM[0] == 0) // RFC3447 Format : http://tools.ietf.org/html/rfc3447
                        {
                            maskedSeed = EM.ToList().GetRange(1, rsaParams.hLen).ToArray();
                            maskedDB = EM.ToList().GetRange(1 + rsaParams.hLen, EM.Length - rsaParams.hLen - 1).ToArray();
                            byte[] seedMask = MGF(maskedDB, rsaParams.hLen);
                            byte[] seed = RSAxUtils.XOR(maskedSeed, seedMask);
                            byte[] dbMask = MGF(seed, rsaParams.OctetsInModulus - rsaParams.hLen - 1);
                            byte[] DB = RSAxUtils.XOR(maskedDB, dbMask);

                            if (DB.Length >= (rsaParams.hLen + 1))
                            {
                                byte[] _pHash = DB.ToList().GetRange(0, rsaParams.hLen).ToArray();
                                List<byte> PS_M = DB.ToList().GetRange(rsaParams.hLen, DB.Length - rsaParams.hLen);
                                int pos = PS_M.IndexOf(0x01);
                                if (pos >= 0 && (pos < PS_M.Count))
                                {
                                    List<byte> _01_M = PS_M.GetRange(pos, PS_M.Count - pos);
                                    byte[] M;
                                    if (_01_M.Count > 1)
                                    {
                                        M = _01_M.GetRange(1, _01_M.Count - 1).ToArray();
                                    }
                                    else
                                    {
                                        M = new byte[0];
                                    }
                                    bool success = true;
                                    for (int i = 0; i < rsaParams.hLen; i++)
                                    {
                                        if (_pHash[i] != pHash[i])
                                        {
                                            success = false;
                                            break;
                                        }
                                    }

                                    if (success)
                                    {
                                        return M;
                                    }
                                    else
                                    {
                                        M = new byte[rsaParams.OctetsInModulus]; //Hash Match Failure.
                                        throw new CryptographicException("OAEP Decode Error");
                                    }
                                }
                                else
                                {// #3: Invalid Encoded Message Length.
                                    throw new CryptographicException("OAEP Decode Error");
                                }
                            }
                            else
                            {// #2: Invalid Encoded Message Length.
                                throw new CryptographicException("OAEP Decode Error");
                            }
                        }
                        else // Standard : ftp://ftp.rsasecurity.com/pub/rsalabs/rsa_algorithm/rsa-oaep_spec.pdf
                        {//OAEP : THIS STADNARD IS NOT IMPLEMENTED
                            throw new CryptographicException("OAEP Decode Error");
                        }
                    }
                    else
                    {// #1: Invalid Encoded Message Length.
                        throw new CryptographicException("OAEP Decode Error");
                    }
                }
                else // DECODE PKCS v1.5
                {
                    if (EM.Length >= 11)
                    {
                        if ((EM[0] == 0x00) && (EM[1] == 0x02))
                        {
                            int startIndex = 2;
                            List<byte> PS = new List<byte>();
                            for (int i = startIndex; i < EM.Length; i++)
                            {
                                if (EM[i] != 0)
                                {
                                    PS.Add(EM[i]);
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (PS.Count >= 8)
                            {
                                int DecodedDataIndex = startIndex + PS.Count + 1;
                                if (DecodedDataIndex < (EM.Length - 1))
                                {
                                    List<byte> DATA = new List<byte>();
                                    for (int i = DecodedDataIndex; i < EM.Length; i++)
                                    {
                                        DATA.Add(EM[i]);
                                    }
                                    return DATA.ToArray();
                                }
                                else
                                {
                                    return new byte[0];
                                    //throw new CryptographicException("PKCS v1.5 Decode Error #4: No Data");
                                }
                            }
                            else
                            {// #3: Invalid Key / Invalid Random Data Length
                                throw new CryptographicException("PKCS v1.5 Decode Error");
                            }
                        }
                        else
                        {// #2: Invalid Key / Invalid Identifiers
                            throw new CryptographicException("PKCS v1.5 Decode Error");
                        }
                    }
                    else
                    {// #1: Invalid Key / PKCS Encoding
                        throw new CryptographicException("PKCS v1.5 Decode Error");
                    }

                }
            }
            catch (CryptographicException ex)
            {
                throw new CryptographicException("Exception while decoding: " + ex.Message);
            }
            catch
            {
                throw new CryptographicException("Exception while decoding");
            }


        }

        #endregion

        #region PUBLIC FUNCTIONS

        /// <summary>
        /// Encrypts the given message with RSA, performs OAEP Encoding.
        /// </summary>
        /// <param name="Message">Message to Encrypt. Maximum message length is (ModulusLengthInOctets - 2 * HashLengthInOctets - 2)</param>
        /// <param name="OAEP_Params">Optional OAEP parameters. Normally Empty. But, must match the parameters while decryption.</param>
        /// <param name="usePrivate">True to use Private key for encryption. False to use Public key.</param>
        /// <returns>Encrypted message.</returns>
        public byte[] Encrypt(byte[] Message, byte[] OAEP_Params, bool usePrivate)
        {
            return RSAProcessEncodeOAEP(Message, OAEP_Params, usePrivate);
        }

        /// <summary>
        /// Encrypts the given message with RSA.
        /// </summary>
        /// <param name="Message">Message to Encrypt. Maximum message length is For OAEP [ModulusLengthInOctets - (2 * HashLengthInOctets) - 2] and for PKCS [ModulusLengthInOctets - 11]</param>
        /// <param name="usePrivate">True to use Private key for encryption. False to use Public key.</param>
        /// <param name="fOAEP">True to use OAEP encoding (Recommended), False to use PKCS v1.5 Padding.</param>
        /// <returns>Encrypted message.</returns>
        public byte[] Encrypt(byte[] Message, bool usePrivate, bool fOAEP)
        {
            if (fOAEP)
            {
                return RSAProcessEncodeOAEP(Message, new byte[0], usePrivate);
            }
            else
            {
                return RSAProcessEncodePKCS(Message, usePrivate);
            }
        }

        /// <summary>
        /// Encrypts the given message using RSA Public Key.
        /// </summary>
        /// <param name="Message">Message to Encrypt. Maximum message length is For OAEP [ModulusLengthInOctets - (2 * HashLengthInOctets) - 2] and for PKCS [ModulusLengthInOctets - 11]</param>
        /// <param name="fOAEP">True to use OAEP encoding (Recommended), False to use PKCS v1.5 Padding.</param>
        /// <returns>Encrypted message.</returns>
        public byte[] Encrypt(byte[] Message, bool fOAEP)
        {
            if (fOAEP)
            {
                return RSAProcessEncodeOAEP(Message, new byte[0], false);
            }
            else
            {
                return RSAProcessEncodePKCS(Message, false);
            }
        }

        /// <summary>
        /// Decrypts the given RSA encrypted message.
        /// </summary>
        /// <param name="Message">The encrypted message.</param>
        /// <param name="usePrivate">True to use Private key for decryption. False to use Public key.</param>
        /// <param name="fOAEP">True to use OAEP.</param>
        /// <returns>Encrypted byte array.</returns>
        public byte[] Decrypt(byte[] Message, bool usePrivate, bool fOAEP)
        {
            return Decrypt(Message, new byte[0], usePrivate, fOAEP);
        }

        /// <summary>
        /// Decrypts the given RSA encrypted message.
        /// </summary>
        /// <param name="Message">The encrypted message.</param>
        /// <param name="OAEP_Params">Parameters to the OAEP algorithm (Must match the parameter while Encryption).</param>
        /// <param name="usePrivate">True to use Private key for decryption. False to use Public key.</param>
        /// <returns>Encrypted byte array.</returns>
        public byte[] Decrypt(byte[] Message, byte[] OAEP_Params, bool usePrivate)
        {
            return Decrypt(Message, OAEP_Params, usePrivate, true);
        }

        /// <summary>
        /// Decrypts the given RSA encrypted message using Private key.
        /// </summary>
        /// <param name="Message">The encrypted message.</param>
        /// <param name="fOAEP">True to use OAEP.</param>
        /// <returns>Encrypted byte array.</returns>
        public byte[] Decrypt(byte[] Message, bool fOAEP)
        {
            return Decrypt(Message, new byte[0], true, fOAEP);
        }

        #endregion

    }

    /// <summary>
    /// Class to keep the basic RSA parameters like Keys, and other information.
    /// </summary>
    public class RSAxParameters : IDisposable
    {
        private int _ModulusOctets;
        private BigInteger _N;
        private BigInteger _P;
        private BigInteger _Q;
        private BigInteger _DP;
        private BigInteger _DQ;
        private BigInteger _InverseQ;
        private BigInteger _E;
        private BigInteger _D;
        private HashAlgorithm ha = SHA1Managed.Create();
        private int _hLen = 20;
        private bool _Has_CRT_Info = false;
        private bool _Has_PRIVATE_Info = false;
        private bool _Has_PUBLIC_Info = false;

        public enum RSAxHashAlgorithm { SHA1, SHA256, SHA512, UNDEFINED };

        public void Dispose()
        {
            ha.Dispose();
        }

        /// <summary>
        /// Computes the hash from the given data.
        /// </summary>
        /// <param name="data">The data to hash.</param>
        /// <returns>Hash of the data.</returns>
        public byte[] ComputeHash(byte[] data)
        {
            return ha.ComputeHash(data);
        }

        /// <summary>
        /// Gets and sets the HashAlgorithm for RSA-OAEP padding.
        /// </summary>
        public RSAxHashAlgorithm HashAlgorithm
        {
            get
            {
                RSAxHashAlgorithm al = RSAxHashAlgorithm.UNDEFINED;
                switch (ha.GetType().ToString())
                {
                    case "SHA1":
                        al = RSAxHashAlgorithm.SHA1;
                        break;

                    case "SHA256":
                        al = RSAxHashAlgorithm.SHA256;
                        break;

                    case "SHA512":
                        al = RSAxHashAlgorithm.SHA512;
                        break;
                }
                return al;
            }

            set
            {
                switch (value)
                {
                    case RSAxHashAlgorithm.SHA1:
                        ha = SHA1Managed.Create();
                        _hLen = 20;
                        break;

                    case RSAxHashAlgorithm.SHA256:
                        ha = SHA256Managed.Create();
                        _hLen = 32;
                        break;

                    case RSAxHashAlgorithm.SHA512:
                        ha = SHA512Managed.Create();
                        _hLen = 64;
                        break;
                }
            }
        }

        public bool HasCRTInfo
        {
            get
            {
                return _Has_CRT_Info;
            }
        }

        public bool Has_PRIVATE_Info
        {
            get
            {
                return _Has_PRIVATE_Info;
            }
        }

        public bool Has_PUBLIC_Info
        {
            get
            {
                return _Has_PUBLIC_Info;
            }
        }

        public int OctetsInModulus
        {
            get
            {
                return _ModulusOctets;
            }
        }

        public BigInteger N
        {
            get
            {
                return _N;
            }
        }

        public int hLen
        {
            get
            {
                return _hLen;
            }
        }

        public BigInteger P
        {
            get
            {
                return _P;
            }
        }

        public BigInteger Q
        {
            get
            {
                return _Q;
            }
        }

        public BigInteger DP
        {
            get
            {
                return _DP;
            }
        }

        public BigInteger DQ
        {
            get
            {
                return _DQ;
            }
        }

        public BigInteger InverseQ
        {
            get
            {
                return _InverseQ;
            }
        }

        public BigInteger E
        {
            get
            {
                return _E;
            }
        }

        public BigInteger D
        {
            get
            {
                return _D;
            }
        }

        /// <summary>
        /// Initialize the RSA class. It's assumed that both the Public and Extended Private info are there. 
        /// </summary>
        /// <param name="rsaParams">Preallocated RSAParameters containing the required keys.</param>
        /// <param name="ModulusSize">Modulus size in bits</param>
        public RSAxParameters(RSAParameters rsaParams, int ModulusSize)
        {
            // rsaParams;
            _ModulusOctets = ModulusSize / 8;
            _E = RSAxUtils.OS2IP(rsaParams.Exponent, false);
            _D = RSAxUtils.OS2IP(rsaParams.D, false);
            _N = RSAxUtils.OS2IP(rsaParams.Modulus, false);
            _P = RSAxUtils.OS2IP(rsaParams.P, false);
            _Q = RSAxUtils.OS2IP(rsaParams.Q, false);
            _DP = RSAxUtils.OS2IP(rsaParams.DP, false);
            _DQ = RSAxUtils.OS2IP(rsaParams.DQ, false);
            _InverseQ = RSAxUtils.OS2IP(rsaParams.InverseQ, false);
            _Has_CRT_Info = true;
            _Has_PUBLIC_Info = true;
            _Has_PRIVATE_Info = true;
        }

        /// <summary>
        /// Initialize the RSA class. Only the public parameters.
        /// </summary>
        /// <param name="Modulus">Modulus of the RSA key.</param>
        /// <param name="Exponent">Exponent of the RSA key</param>
        /// <param name="ModulusSize">Modulus size in number of bits. Ex: 512, 1024, 2048, 4096 etc.</param>
        public RSAxParameters(byte[] Modulus, byte[] Exponent, int ModulusSize)
        {
            // rsaParams;
            _ModulusOctets = ModulusSize / 8;
            _E = RSAxUtils.OS2IP(Exponent, false);
            _N = RSAxUtils.OS2IP(Modulus, false);
            _Has_PUBLIC_Info = true;
        }

        /// <summary>
        /// Initialize the RSA class.
        /// </summary>
        /// <param name="Modulus">Modulus of the RSA key.</param>
        /// <param name="Exponent">Exponent of the RSA key</param>
        /// /// <param name="D">Exponent of the RSA key</param>
        /// <param name="ModulusSize">Modulus size in number of bits. Ex: 512, 1024, 2048, 4096 etc.</param>
        public RSAxParameters(byte[] Modulus, byte[] Exponent, byte[] D, int ModulusSize)
        {
            // rsaParams;
            _ModulusOctets = ModulusSize / 8;
            _E = RSAxUtils.OS2IP(Exponent, false);
            _N = RSAxUtils.OS2IP(Modulus, false);
            _D = RSAxUtils.OS2IP(D, false);
            _Has_PUBLIC_Info = true;
            _Has_PRIVATE_Info = true;
        }

        /// <summary>
        /// Initialize the RSA class. For CRT.
        /// </summary>
        /// <param name="Modulus">Modulus of the RSA key.</param>
        /// <param name="Exponent">Exponent of the RSA key</param>
        /// /// <param name="D">Exponent of the RSA key</param>
        /// <param name="P">P paramater of RSA Algorithm.</param>
        /// <param name="Q">Q paramater of RSA Algorithm.</param>
        /// <param name="DP">DP paramater of RSA Algorithm.</param>
        /// <param name="DQ">DQ paramater of RSA Algorithm.</param>
        /// <param name="InverseQ">InverseQ paramater of RSA Algorithm.</param>
        /// <param name="ModulusSize">Modulus size in number of bits. Ex: 512, 1024, 2048, 4096 etc.</param>
        public RSAxParameters(byte[] Modulus, byte[] Exponent, byte[] D, byte[] P, byte[] Q, byte[] DP, byte[] DQ, byte[] InverseQ, int ModulusSize)
        {
            // rsaParams;
            _ModulusOctets = ModulusSize / 8;
            _E = RSAxUtils.OS2IP(Exponent, false);
            _N = RSAxUtils.OS2IP(Modulus, false);
            _D = RSAxUtils.OS2IP(D, false);
            _P = RSAxUtils.OS2IP(P, false);
            _Q = RSAxUtils.OS2IP(Q, false);
            _DP = RSAxUtils.OS2IP(DP, false);
            _DQ = RSAxUtils.OS2IP(DQ, false);
            _InverseQ = RSAxUtils.OS2IP(InverseQ, false);
            _Has_CRT_Info = true;
            _Has_PUBLIC_Info = true;
            _Has_PRIVATE_Info = true;
        }

    }


    /// <summary>
    /// Utility class for RSAx
    /// </summary>
    public class RSAxUtils
    {
        /// <summary>
        /// Creates a RSAxParameters class from a given XMLKeyInfo string.
        /// </summary>
        /// <param name="XMLKeyInfo">Key Data.</param>
        /// <param name="ModulusSize">RSA Modulus Size</param>
        /// <returns>RSAxParameters class</returns>
        public static RSAxParameters GetRSAxParameters(string XMLKeyInfo, int ModulusSize)
        {
            bool Has_CRT_Info = false;
            bool Has_PRIVATE_Info = false;
            bool Has_PUBLIC_Info = false;

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(XMLKeyInfo);
            }
            catch (System.Exception ex)
            {
                throw new Exception("Malformed KeyInfo XML: " + ex.Message);
            }

            byte[] Modulus = new byte[0];
            byte[] Exponent = new byte[0];
            byte[] D = new byte[0];
            byte[] P = new byte[0];
            byte[] Q = new byte[0];
            byte[] DP = new byte[0];
            byte[] DQ = new byte[0];
            byte[] InverseQ = new byte[0];

            try
            {
                Modulus = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Modulus").InnerText);
                Exponent = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Exponent").InnerText);
                Has_PUBLIC_Info = true;
            }
            catch { }

            try
            {
                Modulus = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Modulus").InnerText);
                D = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("D").InnerText);
                Exponent = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Exponent").InnerText);
                Has_PRIVATE_Info = true;
            }
            catch { }

            try
            {
                Modulus = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Modulus").InnerText);
                P = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("P").InnerText);
                Q = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("Q").InnerText);
                DP = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("DP").InnerText);
                DQ = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("DQ").InnerText);
                InverseQ = Convert.FromBase64String(doc.DocumentElement.SelectSingleNode("InverseQ").InnerText);
                Has_CRT_Info = true;
            }
            catch { }

            if (Has_CRT_Info && Has_PRIVATE_Info)
            {
                return new RSAxParameters(Modulus, Exponent, D, P, Q, DP, DQ, InverseQ, ModulusSize);
            }
            else if (Has_PRIVATE_Info)
            {
                return new RSAxParameters(Modulus, Exponent, D, ModulusSize);
            }
            else if (Has_PUBLIC_Info)
            {
                return new RSAxParameters(Modulus, Exponent, ModulusSize);
            }

            throw new Exception("Could not process XMLKeyInfo. Incomplete key information.");


        }

        /// <summary>
        /// Converts a non-negative integer to an octet string of a specified length.
        /// </summary>
        /// <param name="x">The integer to convert.</param>
        /// <param name="xLen">Length of output octets.</param>
        /// <param name="makeLittleEndian">If True little-endian converntion is followed, big-endian otherwise.</param>
        /// <returns></returns>
        public static byte[] I2OSP(BigInteger x, int xLen, bool makeLittleEndian)
        {
            byte[] result = new byte[xLen];
            int index = 0;
            while ((x > 0) && (index < result.Length))
            {
                result[index++] = (byte)(x % 256);
                x /= 256;
            }
            if (!makeLittleEndian)
                Array.Reverse(result);
            return result;
        }

        /// <summary>
        /// Converts a byte array to a non-negative integer.
        /// </summary>
        /// <param name="data">The number in the form of a byte array.</param>
        /// <param name="isLittleEndian">Endianness of the byte array.</param>
        /// <returns>An non-negative integer from the byte array of the specified endianness.</returns>
        public static BigInteger OS2IP(byte[] data, bool isLittleEndian)
        {
            BigInteger bi = 0;
            if (isLittleEndian)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    bi += BigInteger.Pow(256, i) * data[i];
                }
            }
            else
            {
                for (int i = 1; i <= data.Length; i++)
                {
                    bi += BigInteger.Pow(256, i - 1) * data[data.Length - i];
                }
            }
            return bi;
        }

        /// <summary>
        /// Performs Bitwise Ex-OR operation to two given byte arrays.
        /// </summary>
        /// <param name="A">The first byte array.</param>
        /// <param name="B">The second byte array.</param>
        /// <returns>The bitwise Ex-OR result.</returns>
        public static byte[] XOR(byte[] A, byte[] B)
        {
            if (A.Length != B.Length)
            {
                throw new ArgumentException("XOR: Parameter length mismatch");
            }
            else
            {
                byte[] R = new byte[A.Length];

                for (int i = 0; i < A.Length; i++)
                {
                    R[i] = (byte)(A[i] ^ B[i]);
                }
                return R;
            }
        }

        internal static void FixByteArraySign(ref byte[] bytes)
        {
            if ((bytes[bytes.Length - 1] & 0x80) > 0)
            {
                byte[] temp = new byte[bytes.Length];
                Array.Copy(bytes, temp, bytes.Length);
                bytes = new byte[temp.Length + 1];
                Array.Copy(temp, bytes, temp.Length);
            }
        }


    }
}
