using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class PurchaseVoucherGeneral
    {

        public int VoucherNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int VendorID { get; set; }
        //public double TotalItems { get; set; }


        public double TotalFreeItemsQty { get; set; }
        public double TotalTax { get; set; }
        public double Subtotal { get; set; }
        public double DiscountPerc { get; set; }
        public double TotalDiscount { get; set; }

        public double TotalCost { get; set; }
        public int PaymentMethodID { get; set; }
        public int TellerID { get; set; }
        public string Comments { get; set; }
        public string CreditCardInfo { get; set; }

        public int CurrencyID { get; set; }
        public int AccountID { get; set; }
        public int CheckNumber { get; set; }
        public int IsCashCredit { get; set; }
        public double VendorAccountAmountOld { get; set; }
        public int IsChecked { get; set; }

        public string CheckedBy { get; set; }
        public string CheckDate { get; set; }
        public string CheckTime { get; set; }
        public int IsRevised { get; set; }
        public string RevisedBy { get; set; }

        public string ReviseDate { get; set; }
        public string ReviseTime { get; set; }
        public double ReviseLoss { get; set; }
        public double Fees { get; set; }


        public double TotalItemsDiscount { get; set; }
      
        public PurchaseVoucherGeneral()
        {

        }
    }
}
