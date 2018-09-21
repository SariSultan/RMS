using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
   public class CustomersPayments
    {
       public int Customer_Payment_CustomerID { get; set; }
       public int Customer_Payment_PaymentNumber { get; set; }
       public string Customer_Payment_Date { get; set; }
       public string Customer_Payment_Time { get; set; }
       public int Customer_Payment_TellerID { get; set; }
       public double Customer_Payment_Amount { get; set; }

       public double Customer_Payment_OldAmount { get; set; }
       public int Customer_Payment_IsChecked { get; set; }
       public int Customer_Payment_IsRevised { get; set; }
       public string Customer_Payment_Comments { get; set; }

       public int IsCreditCard { get; set; }
       public string CreditCardInfo { get; set; }

       public int PaymentMethodID { get; set; }
       public int CheckNumber { get; set; }

       public int AccountID { get; set; }
    }
}
