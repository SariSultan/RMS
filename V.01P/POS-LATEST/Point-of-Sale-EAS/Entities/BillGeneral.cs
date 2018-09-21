using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Entities
{
    public class BillGeneral
    {
        public int Bill_General_ID { get; set; } //Masterkey to bill detailed ID

        public int Bill_General_TellerID { get; set; }
        public int Bill_General_CustomerID { get; set; }
        public int Bill_General_PriceLevel { get; set; }
        public int Bill_General_PaymentMethodID { get; set; }
        public double Bill_General_TotalPrice { get; set; }
        public string Bill_General_Comments { get; set; }
        public double Bill_General_TotalCost { get; set; }
        public double Bill_General_TotalItems { get; set; }
        public string Bill_General_Date { get; set; }
        public int Bill_General_Number { get; set; }
        public string Bill_General_Time { get; set; }
        public double Bill_General_TotalTax { get; set; }
        public double Bill_General_SalesDiscount { get; set; }
        public double Bill_General_DiscountPerc { get; set; }
        public double Bill_General_CashIn { get; set; }
        public double Bill_General_TotalDiscount { get; set; }
        public string Bill_General_CreditCardInfo { get; set; }
        public int Bill_General_CurrencyID { get; set; }
        public int Bill_General_AccountID { get; set; }
        public double Bill_General_NetAmount { get; set; }
        public int Bill_General_CheckNumber { get; set; }
        public string Bill_General_Currency { get; set; }
        public double Bill_General_SubTotal { get; set; }
        public int Bill_General_IsCashCredit { get; set; }
        public double CustomerAccountAmountOld { get; set; }
        public BillGeneral()
        {
                
        }
    }
}
