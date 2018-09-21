using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point_of_Sale_EAS.Text
{
    public static class MsgTxt
    {
        /// <summary>
        /// ERRORS MESSAGES
        ///  MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: \n"+ex.ToString(),MsgTxt.ErrorCaption,MessageBoxButtons.OK,MessageBoxIcon.Error);
        /// </summary>
        public static string ErrorCaption = "Error!";
        public static string ErrorPleaseEnterCorrectAmount = "Error! \n Please Enter Correct Amount"; //something                
        public static string UnexpectedError = "UnExpected Error!\n Please Try Again Later.";
        public static string WarningCaption = "Warning!";
        public static string InformationCaption = "Information!";
        public static string ErrorLoadingFrom = "Error Loading Form";
        public static string DataBaseErrorTxt = "Data Base Error";
        public static string PleaseTryAgainLaterTxt = "Please Try Again";

        /// <summary>
        /// ADDING AND UPDATING
        /// </summary>
        public static string UpdateSuccessfully = "Updated Successfully";
        public static string AddedSuccessfully = "Added Successfully";
        public static string PhoneInUse = "Phone Already In Use";
        public static string PleaseAddAllRequiredFields = "Please Insert All Required Fields *";
        public static string PleaseSelectCorrectAmountTxt = "Please Select Appropriate Amount";
        public static string AlreadyUsedTxt = "Already Used";

        /// 
        /// Various
        ///
        public static string AccountTxt = "Account";
        public static string DoNotAcceptTxt = "Do Not Accept";
        public static string PleaseSelectTxt = "Please Select";
        public static string ValidAccountTxt = "Valid Account";
        public static string CustomerTxt = "Customer";
        public static string FormWillCloseNowTxt = "Form Will Close Now";
        public static string PleaseAddCreditCardInfoTxt = "Please Add Credit Card Information";
        public static string CheckHolderNameTxt = "Please Insert Check Holder Name";

        public static string DisposalReasonTxt = "Disposal Reason ";
        public static string NameTxt = "Name";
        public static string DescriptionTxt = "Description";

        public static string ItemCategoryTxt = "Item Category";

        public static string ItemTypeTxt = "Item type";

        public static string PriceLevelsTxt = "Price Levels";
        public static string CannotFindTxt = " Cannot Find";

        public static string BarcodeTxt = "Barcode";
        public static string IfNotBarChkWithoutBarcodeTxt = " If this item without barcode please check the without barcode checkbox";
        public static string ValidQtyTxt = "Valid Quantity";
        public static string RenderPointTxt = "Render Point Quantity";
        public static string SellingPriceTxt = "Selling Price";
        public static string UnitCostTxt = "Unit Cost";
        public static string DidnotAdded = "Did not Added Successfully";
        public static string AddAnotherItemTxt = "Do you want to add another item";

        public static string UserTxt = "User";

        public static string PercentageTxt = "Percentage";

        public static string VendorTxt = "Vendor";

        




        
      

    }
}
