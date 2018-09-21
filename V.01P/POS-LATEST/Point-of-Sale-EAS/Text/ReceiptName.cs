using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Text
{
    public static class ReceiptName
    {
        /* This is Bullshit :P Fuck you dolphiiiiiiiiins 
   
        public static string SalesRctNm     =   "Sale Invoice"; //فاتورة بيع
        public static string PurchaseRctNm  = "Purchase Invoice"; //فاتورة شراء
        public static string CustomerPayRctNm = "Customer Payment";
        public static string VendorPayRctNm = "Vendor Payment";

        #region V01H Added Data
        public static string DisposeitemsRctNm = "Dispose Items";
        public static string CustomerReturnsRctNm = "Customer Returns";
        public static string VendorReturnsRctNm = "Vendors Returns";
        #endregion V01H Added Data
        */

         
        
        /// <summary>
        /// V.01-H Ayman
        /// </summary>
        /////////////////////////////////////////////////////////////////////////////////////////////////

        public static string RctNmsSales;
        public static string RctNmsPurchase;
        public static string RctNmsCustomerPay;
        public static string RctNmsVendorPay;
        public static string RctNmsDisposeitems;
        public static string RctNmsCustomerReturns;
        public static string RctNmsVendorReturns;

        public static void TranslateReceiptText()
        {
            RctNmsSales = ResourcesManager.GetString("RctNmsSalesTxt");
            RctNmsPurchase = ResourcesManager.GetString("RctNmsPurchaseTxt");
            RctNmsCustomerPay = ResourcesManager.GetString("RctNmsCustomerPayTxt");
            RctNmsVendorPay = ResourcesManager.GetString("RctNmsVendorPayTxt");
            RctNmsDisposeitems = ResourcesManager.GetString("RctNmsDisposeitemsTxt");
            RctNmsCustomerReturns = ResourcesManager.GetString("RctNmsCustomerReturnsTxt");
            RctNmsVendorReturns = ResourcesManager.GetString("RctNmsVendorReturnsTxt");       
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// V.01-H Ayman
        /// </summary>


    }
}
