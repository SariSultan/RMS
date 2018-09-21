using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class Checks
    {

        public int Chekcs_ID { get; set; }

       // public string Chekcs_BankName { get; set; }
        public string Chekcs_HolderName { get; set; }
        public string Chekcs_PaymentDate { get; set; }
        public int Chekcs_IsBill { get; set; }
        public int Chekcs_GeneralBillNumber { get; set; }
        public int Chekcs_IsPurchaseVoucher { get; set; }
        public int Chekcs_PurchaseVoucherNumber { get; set; }
        public int Chekcs_AccountID { get; set; }
        public string Chekcs_Comments { get; set; }

        public double Chekcs_Amount { get; set; }
        public int Chekcs_IsPaid { get; set; }

        public int CheckNumber { get; set; }
        public string AddingDate { get; set; }

        public int Chekcs_IsCustomerPayment { get; set; }
        public int Chekcs_CustomerPaymentNumber { get; set; }

        public int Chekcs_IsVendorPayment { get; set; }
        public int Chekcs_VendorPaymentNumber { get; set; }



    }
}
