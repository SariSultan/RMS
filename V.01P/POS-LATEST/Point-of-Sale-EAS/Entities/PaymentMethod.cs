using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class PaymentMethod
    {


       public int Payment_Method_ID { get; set; }
       public string Payment_Method_Name { get; set; }
       public string Payment_Method_Description { get; set; }

       public PaymentMethod()
       {

       }
    }
}
