using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Text
{
    public static class ReceiptText
    {
        #region V01H
        public static string RctTxtItemName;
        public static string RctTxtUnitPrice;
        public static string RctTxtQty;
        public static string RctTxtTotal;
        public static string RctTxtSubTotal;
        public static string RctTxtTax;
        public static string RctTxtDisountInvoice;
        public static string RctTxtPriceLvlDiscount;
        public static string RctTxtToPayAmount;
        public static string RctTxtPayMethod;
        public static string RctTxtCashIn;
        public static string RctTxtExchange;
        public static string RctTxtReceivable;
        public static string RctTxtPayable;
        public static string RctTxtOldBalance;
        public static string RctTxtNewBalance;
        public static string RctTxtCurrenctBalance;
        public static string RctTxtDate;
        public static string RctTxtTime;
        public static string RctTxtOrgDate;
        public static string RctTxtOrgTime;
        public static string RctTxtTeller;
        public static string RctTxtOrgTeller;
        public static string RctTxtCustomer;
        public static string RctTxtVendor;
        public static string RctTxtInvoiceNum;
        public static string RctTxtPurchaseNumber;
        public static string RctTxtDuplicate;
        public static string RctTxtReprintedOn;
        public static string RctTxtReprintedBy;
        public static string RctTxtReversed;
        public static string RctTxtReversedBy;
        public static string RctTxtReversedOn;
        public static string RctTxtDiscount;
        public static string RctTxtVoucherDiscount;
        public static string RctTxtItemsDiscount;
        public static string RctTxtTotalDiscount;
        public static string RctTxtFees;
        public static string RctTxtPaymentNum;
        public static string RctTxtUnitCost;
        public static string RctTxtDisposalReason;
        public static string RctTxtDisposeInvNumber;
        public static string RctTxtRetVenInvNum;
        public static string RctTxtFreeItems;

#endregion V01H
        
        
        public static void TranslateReceiptText()
        {
            #region V01H-Translation
            RctTxtItemName = ResourcesManager.GetString("RctTxtItemNameTxt");
            RctTxtUnitPrice = ResourcesManager.GetString("RctTxtUnitPriceTxt");
            RctTxtQty = ResourcesManager.GetString("RctTxtQtyTxt");
            RctTxtTotal = ResourcesManager.GetString("RctTxtTotalTxt");
            RctTxtSubTotal = ResourcesManager.GetString("RctTxtSubTotalTxt");
            RctTxtTax = ResourcesManager.GetString("RctTxtTaxTxt");
            RctTxtDisountInvoice = ResourcesManager.GetString("RctTxtDisountInvoiceTxt");
            RctTxtPriceLvlDiscount = ResourcesManager.GetString("RctTxtPriceLvlDiscountTxt");
            RctTxtToPayAmount = ResourcesManager.GetString("RctTxtToPayAmountTxt");
            RctTxtPayMethod = ResourcesManager.GetString("RctTxtPayMethodTxt");
            RctTxtCashIn = ResourcesManager.GetString("RctTxtCashInTxt");
            RctTxtExchange = ResourcesManager.GetString("RctTxtExchangeTxt");
            RctTxtReceivable = ResourcesManager.GetString("RctTxtReceivableTxt");
            RctTxtPayable = ResourcesManager.GetString("RctTxtPayableTxt");
            RctTxtOldBalance = ResourcesManager.GetString("RctTxtOldBalanceTxt");
            RctTxtNewBalance = ResourcesManager.GetString("RctTxtNewBalanceTxt");
            RctTxtCurrenctBalance = ResourcesManager.GetString("RctTxtCurrenctBalanceTxt");
            RctTxtDate = ResourcesManager.GetString("RctTxtDateTxt");
            RctTxtTime = ResourcesManager.GetString("RctTxtTimeTxt");
            RctTxtOrgDate = ResourcesManager.GetString("RctTxtOrgDateTxt");
            RctTxtOrgTime = ResourcesManager.GetString("RctTxtOrgTimeTxt");
            RctTxtTeller = ResourcesManager.GetString("RctTxtTellerTxt");
            RctTxtOrgTeller = ResourcesManager.GetString("RctTxtOrgTellerTxt");
            RctTxtCustomer = ResourcesManager.GetString("RctTxtCustomerTxt");
            RctTxtVendor = ResourcesManager.GetString("RctTxtVendorTxt");
            RctTxtInvoiceNum = ResourcesManager.GetString("RctTxtInvoiceNumTxt");
            RctTxtPurchaseNumber = ResourcesManager.GetString("RctTxtPurchaseNumberTxt");
            RctTxtDuplicate = ResourcesManager.GetString("RctTxtDuplicateTxt");
            RctTxtReprintedOn = ResourcesManager.GetString("RctTxtReprintedOnTxt");
            RctTxtReprintedBy = ResourcesManager.GetString("RctTxtReprintedByTxt");
            RctTxtReversed = ResourcesManager.GetString("RctTxtReversedTxt");
            RctTxtReversedBy = ResourcesManager.GetString("RctTxtReversedByTxt");
            RctTxtReversedOn = ResourcesManager.GetString("RctTxtReversedOnTxt");
            RctTxtDiscount = ResourcesManager.GetString("RctTxtDiscountTxt");
            RctTxtVoucherDiscount = ResourcesManager.GetString("RctTxtVoucherDiscountTxt");
            RctTxtItemsDiscount = ResourcesManager.GetString("RctTxtItemsDiscountTxt");
            RctTxtTotalDiscount = ResourcesManager.GetString("RctTxtTotalDiscountTxt");
            RctTxtFees = ResourcesManager.GetString("RctTxtFeesTxt");
            RctTxtPaymentNum = ResourcesManager.GetString("RctTxtPaymentNumTxt");
            RctTxtUnitCost = ResourcesManager.GetString("RctTxtUnitCostTxt");
            RctTxtDisposalReason = ResourcesManager.GetString("RctTxtDisposalReasonTxt");
            RctTxtDisposeInvNumber = ResourcesManager.GetString("RctTxtDisposeInvNumberTxt");
            RctTxtRetVenInvNum = ResourcesManager.GetString("RctTxtRetVenInvNumTxt");
            RctTxtFreeItems = ResourcesManager.GetString("RctTxtFreeItemsTxt");
            #endregion V01H-Translation
        }
        
        
        


    }
}
