using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class Priviliges
    {
       public int Priviliges_ID { get; set; }
       public string Priviliges_Name { get; set; }
       public string Priviliges_Description { get; set; }



       public int Priviliges_UserID { get; set; }
       public int Priviliges_EventID { get; set; }

       public Priviliges()
       {

       }
    }
}
