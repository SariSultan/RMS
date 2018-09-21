using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class DisposalDetailed
    {
       public int Disposal_Detailed_ID { get; set; } 
       public int Disposal_Detailed_ItemID { get; set; }
       public string Disposal_Detailed_ItemDescription { get; set; }
       public double Disposal_Detailed_Qty { get; set; }
       public double Disposal_Detailed_UnitCost { get; set; }
       public string Disposal_Detailed_Date { get; set; }
       public double Disposal_Detailed_TotalPerUnit { get; set; }
       public int Disposal_Detailed_GeneralNumber { get; set; }
       public int Disposal_Detailed_IsRevised { get; set; }

       public DisposalDetailed()
       {

       }
    }
}
