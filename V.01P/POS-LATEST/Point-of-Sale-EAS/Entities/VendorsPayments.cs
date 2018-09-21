using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class VendorsPayments
    {
        public int Vendor_Payment_VendorID { get; set; }
        public int Vendor_Payment_PaymentNumber { get; set; }
        public string Vendor_Payment_Date { get; set; }
        public string Vendor_Payment_Time { get; set; }
        public int Vendor_Payment_TellerID { get; set; }
        public double Vendor_Payment_Amount { get; set; }

        public double Vendor_Payment_OldAmount { get; set; }
        public int Vendor_Payment_IsChecked { get; set; }
        public int Vendor_Payment_IsRevised { get; set; }
        public string Vendor_Payment_Comments { get; set; }

        public int MyAccountID { get; set; }

        public int IsCreditCard { get; set; }
        public string CreditCardInfo { get; set; }

        public int PaymentMethodID { get; set; }
        public int  CheckNumber { get; set; }
    }
}
