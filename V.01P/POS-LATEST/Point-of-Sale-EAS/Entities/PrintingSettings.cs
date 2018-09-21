using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class PrintingSettings
    {
       public int ID { get; set; } 
       public int HeaderOrFooter { get; set; } //Header =1; footer =0;
       public string Data { get; set; } // fk
       public int BillOrReport { get; set; }//bill=1 , report =0;
       public int Number { get; set; }//fk

       public PrintingSettings()
       {

       }
    }
}
