using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class ReturnItemsCustGeneral
    {
        public int ID { get; set; } 
        public int TellerID { get; set; }
        public int CustomerID { get; set; }
        public int PriceLevel { get; set; }
        public double TotalPrice { get; set; }
        public string Comments { get; set; }
        public double TotalCost { get; set; }
        public double TotalItems { get; set; }
        public string Date { get; set; }
        public int Number { get; set; }
        public string Time { get; set; }
        public double TotalTax { get; set; }
        public double DiscountPerc { get; set; }
        public double TotalDiscount { get; set; }
        public int AccountID { get; set; }
        public double NetAmount { get; set; }
        public double SubTotal { get; set; }
        public int IsCashCredit { get; set; }
        public double CustomerAccountAmountOld { get; set; }

        public ReturnItemsCustGeneral()
        {
                
        }
    }
}
