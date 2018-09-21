using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS
{
    class SharedFunctions
    {
        public  static string ReturnLoggedUserName()
        {
            if (!PrivilegesManager.IsTempActive)
                return SharedVariables.user_logged_name;
            else
                return SharedVariables.temp_logged_name;
        }
        
        public static bool tobool(string s)
        {
            if (s == "0")
                return false;
            else
                return true;
        }
        public static string DeterminePriv(string m)
        {
            if (m == "1")
                return "نعم";
            else
                return "لا";
        }
        public SharedFunctions()
        { }
    }
}
