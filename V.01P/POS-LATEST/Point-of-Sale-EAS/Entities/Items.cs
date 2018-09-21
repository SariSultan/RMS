using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class Items
    {
       public int Item_ID { get; set; }
       public int Item_Type { get; set; }                  // foriegn key
       public int Item_Category { get; set; }             // foriegn key to ItemCategory Table     
       public int Vendor { get; set; }                   // foriegn key to Ventor Table
       public string Item_Barcode { get; set; }            
       public string Item_Description { get; set; }
       public double Avalable_Qty { get; set; }
       public double Render_Point { get; set; }
       public double Sell_Price { get; set; }
       public double Avg_Unit_Cost { get; set; }
       public string Entry_Date { get; set; }
       public int Item_Tax_Level { get; set; }       // foriegn key
       public int PriceLevelID { get; set; }
       public double OnHandQty { get; set; }
       

       public int IsWithoutBarcode { get; set; }
       public int TouchScreen { get; set; }


       public int IsWeight { get; set; }
    }
}
