using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
  public  class PurchaseVoucherDetailed
    {
      public int Purchase_Voucher_Detailed_ID { get; set; } 
      public int Purchase_Voucher_Detailed_ItemID { get; set; }
      public double Purchase_Voucher_Detailed_Qty { get; set; }
      public double Purchase_Voucher_Detailed_ItemCost { get; set; }
      public double Purchase_Voucher_Detailed_Discount { get; set; }
      public double Purchase_Voucher_Detailed_FreeItemsQty { get; set; }
      public int Purchase_Voucher_Detailed_VoucherNumber { get; set; }
      public double Purchase_Voucher_Detailed_OldAvgUnitCost { get; set; }

      public double Purchase_Voucher_Detailed_OldAvaQty { get; set; }
      public int Purchase_Voucher_Detailed_IsRevised { get; set; }





      //public bool Purchase_Voucher_Detailed_Spread { get; set; } //Neglected for Now 
      public PurchaseVoucherDetailed()
      {

      }
    }
}
