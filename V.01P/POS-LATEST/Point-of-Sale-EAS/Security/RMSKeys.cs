using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Security
{
   public static  class RMSKeys
    {
       private static string TripleDESEncryptedKey="ZuciragVZEC2AbSEMHkvuqw9KJ8siJMzOo4Cw9KVn0iYJG1SWhC0oQ+Cif84f0B4bUZ2Waj0d1nwhQzfUhkmKywVIUjq/Vq5M/M5588vNuxnRosh25Q1UiQPk9jDjqO2Kkq3dXHKnolX1DdTCVEDE/ctkNaXwdbyNb16yzjzV2wLZpYi1hv6N3FD9eArAbDpk9o/7E1yt0cyTJ0LeWLSmLESz6NpwUCWz1dLJp1YHvzRC00viaGkK4V61NhIAGjpk5V+nOhr4bqwYSKXjjB8irn5r3FG13qV8nNL7pt86fMd4Bg511UQY9C9lSH0b9TE68ui57VPyvVNPKaXHHwa17Rw8HnSqisvUq0leN5+6lLTqH+b9t2C173ZMqvRNo4pCmvks4EtkPg3f3GHSDizhnxIdWtEJCBKDrafOwX/02QPwBQEW19/OvnnQSXC3VrjAcOmqYhW12IQLZZd3OIqho4IssTPsr157tmcYKo0zSfbh3n4KUmF/uWgm6zbHN1xCg8CAZR5KJypvjmlAI3SXtpYqgRdRMH6MSOwFTRu2GiT29QreFRAS36SdeIyYrR680VAZ2si6/t3wUrt96vnfu3WPUilE6cLfaGVNvPECz45FHTFF2t7+Po4qRWVGcL8NkQqsdNFm66nwfEwhwvaElKgTJuyA9S/VlnGF90Og+pzDMF7V3oo0nU1zxeGzlIH7p52Vt6Ims8wayqlLngumvM+AVvgkQUmonm07LmfBn1Yytolgt6DEDEVcFLqBjCIX7BovVBoYlPZlN/zcwNuzj/15Hxiu1yhIs8Hp8F35r+QgZvYqZLmiQkcbuOfSo8kf5oOCI6YuqEYjtPf39A4URMp6A9S06z3Nl3KivTbSToRb+D8BORZ+pLOPgAyfWRu9wdaryLZljfj4mZ/CobFIULoQJqdLS6hak1+O5VFJrqdNlb5rogTj4Jd2t5gu5FE1tkpBN9bgmPL/Q4Twi1pVlZqLddSuSLaGN/UnPUSSDNZ+MCOfX6mrznLDtfTlimz";

       public static string GetTripleDESKey()
       {
           try
           {
               return RSAEngine.DecryptUsingPublicKey(RSAEngine.RMSv01PublicKey, RSAEngine.RSAModulos, TripleDESEncryptedKey);
               
           }
           catch(Exception ex)
           {
              throw new Exception("ENCRYPTION ERROR IN RMSKEYS\n" +ex.Message);
           }
       }

    }
}
