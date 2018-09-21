using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public  class ReturnItemsVendorDetailed
    {
      public int    ID { get; set; } 
      public int    ItemID { get; set; }
      public double ItemCost { get; set; }
      public double Qty { get; set; }
      public double Discount { get; set; }
      public double FreeItemsQty { get; set; }
      public int    Number { get; set; }
      public double OldAvgUnitCost { get; set; }
      public double OldAvaQty { get; set; }
      public int    IsRevised { get; set; }

      public ReturnItemsVendorDetailed()
      {

      }
    }
}
