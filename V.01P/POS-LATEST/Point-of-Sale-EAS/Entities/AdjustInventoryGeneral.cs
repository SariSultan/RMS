using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class AdjustInventoryGeneral
    {
       public int ID { get; set; }
       public int Number { get; set; }
       public int TellerID { get; set; }
       public string Date { get; set; }
       public int IsChecked { get; set; }
       public string CheckedBy { get; set; }
       public string CheckDate { get; set; }
       public string CheckTime { get; set; }

    }
}
