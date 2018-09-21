using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class Users
    {
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public string User_Address { get; set; }
        public string User_Phone1 { get; set; }
        public string User_Phone2 { get; set; }
        public string User_UserName { get; set; }
        public string User_Password { get; set; }
        public string User_Description { get; set; }
        public int User_IsAdmin { get; set; }

        public Users()
        {

        }
    }
}
