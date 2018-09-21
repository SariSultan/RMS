using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class ReturnItemsCustDetailed
    {
        public int ID { get; set; } 
        public int ItemID { get; set; } 
        public string ItemDescription { get; set; } 
        public double Qty { get; set; }
        public double SellPrice { get; set; }
        public double TotalPerUnit { get; set; }
        public int Number { get; set; } 
        public double OldAvaQty { get; set; }
        public double OldAvgUnitCost { get; set; }

        public ReturnItemsCustDetailed()
        { }
    }
}
