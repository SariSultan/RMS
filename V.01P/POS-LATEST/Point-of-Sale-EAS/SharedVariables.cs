using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using Calcium_RMS.Text;


namespace Calcium_RMS
{
    class SharedVariables
    {
        public static readonly Color TxtBoxRequiredColor = Color.FromArgb(255, 0, 0);

        public static bool is_user_logged = false;

        public static string user_logged_name = UiText.NotLoggedOnTxt;
        public static string user_logged_name_name = "";
        public static string temp_logged_name = "";
        public static string temp_logged_name_name = "";
        public static bool IsStartup = true;

   
        public static readonly string Line_Solid_10px_Black = "<hr>";

        public SharedVariables()
        { }
    }
}
