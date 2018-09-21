using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class BillDetailed
    {
       public int Bill_Detailed_ID { get; set; } //fk to general
       public int Bill_Detailed_ItemID { get; set; } //foreign key
       public string Bill_Detailed_ItemDescription { get; set; } // fk
       public double Bill_Detailed_Qty { get; set; }
       public double Bill_Detailed_SellPrice { get; set; }//fk
       public double Bill_Detailed_TotalPerUnit { get; set; }
       public int Bill_Detailed_Number { get; set; } //fk
       public double Bill_Detailed_OldAvaQty { get; set; }
       public double Bill_Detailed_OldAvgUnitCost { get; set; }
       public BillDetailed()
       {

       }
    }
}
