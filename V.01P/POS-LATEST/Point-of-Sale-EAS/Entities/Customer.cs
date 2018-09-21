using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class Customer
    {
        public int Customer_ID { get; set; } 
        public string Customer_Name { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Address { get; set; }
        public string Customer_Phone1 { get; set; }
        public string Customer_Phone2 { get; set; }

        public Customer()
        {

        }
    }
}
