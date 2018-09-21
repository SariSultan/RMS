using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class PriceLevels
    {
       public int Price_Level_ID { get; set; }
       public string Price_Level_Name { get; set; }
       public string Price_Level_Description { get; set; }
       public double Price_Level_Discount { get; set; } 

       public PriceLevels()
       {

       }
    }
}
