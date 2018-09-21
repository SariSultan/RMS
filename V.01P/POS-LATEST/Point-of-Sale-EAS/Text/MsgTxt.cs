using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calcium_RMS.Text
{
    public static class MsgTxt
    {
        #region [V01A-V01D]
        public static string ErrorCaption = "Error!";
        public static string ErrorPleaseEnterCorrectAmount = " Please Enter Correct Amount"; //something                
        public static string UnexpectedError = "UnExpected Error!";
        public static string WarningCaption = "Warning!";
        public static string InformationCaption = "Information!";
        public static string ErrorLoadingFrom = "Error Loading Form";
        public static string DataBaseErrorTxt = "Data Base Error";
        public static string PleaseTryAgainLaterTxt = "Please Try Again";
        public static string UpdateSuccessfully = "Updated Successfully";
        public static string AddedSuccessfully = "Added Successfully";
        public static string PhoneInUse = "Phone Already In Use";
        public static string PleaseAddAllRequiredFields = "Please Insert All Required Fields *";
        public static string PleaseSelectCorrectAmountTxt = "Please Select Appropriate Amount";
        public static string AlreadyUsedTxt = "Already Used";
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
        public static string AddNewTxt = "Add New";
        public static string BillNumberNotExistTxt = "Bill Number Do not Exist";
        public static string ItemNotFoundTxt = "Item Not Found";
        public static string CannotChangeAdminTxt = "You Cannot change [Admin] Priviliges";
        #endregion [V01A-V01D]

        #region [V01E-V01F]
        /// <-- Ayman Work Ends Here -->
        /// New Version 01E Added On august 17 2013 by Sari Sultan
        /// 
 
        public static string AlreadyCheckedTxt = "Already Checked";
        public static string AlreadyReversedTxt = "Already Reversed";

        public static string CheckedSuccesfullyTxt = "Checked Successfully";
        public static string ReversedSuccessfullyTxt = "Reversed Successfully";

        public static string NotUsedTxt = "Not Used";
        public static string ItemTxt = "Item";
        public static string PrivUserNotAllowedTxt = "Current User Doesn't Have Privilige! \n Please Contact Your System Administrator";
        public static string PhoneTxt = "Phone Number";
        public static string CompanyTxt = "Company Name";
        public static string ShouldNotBeLessThanTxt = "Should Not Be Less Than ";
        public static string AlreadyTempUserTxt = "You Are Already Loged As Temp User ";
        public static string NotFoundTxt = "Not Found ";

        public static string IncorrectTxt = " Incorrect!";
        public static string OrTxt = "Or ";
        public static string UsrNameTxt = "User Name";
        public static string PasswordTxt = "Password";
        public static string CannotBeCalculatedTxt = "Cannot Be Calculated";
        public static string DoNotHaveAccountTxt = " Do Not Have Account";
        public static string PaymentMethodTxt = " Payment Method";
        public static string NotItemsTxt = "No Items";
        public static string CashLargerThanTotAmtTxt = "Cash in should be larger than total amount";
        public static string SureToTakePaymentTxt = "Are you sure you want to take this transaction";
        public static string TotalAmountTxt = "Total Amount";
        public static string ExchangeTxt = "Exchange";
        public static string CurrencyTxt = "Currency";
        public static string TransactionNotAddedSuccessfullyTxt = "Opps! Transaction Not Added Successfully";
        public static string PrintingErrorTxt = "Printing Error";
        public static string ChequeTxt = "Cheque";
        public static string NotAddedTxt = "Not Added";
        public static string ReportTxt = "Report";
        public static string NoDataTxt = "No Data";
        public static string DateFromTxt = "Date From";
        public static string DateToTxt = "Date To";
        public static string NumberOfItemsPerPageTxt = "Number Of Items Per Page";
        public static string DesiredListTxt = "Desired List e.g. Day-by-Day Month-by-Month";
        public static string PleaseCheckSQLServiceTxt = "Please Make Sure that the SQL server service is Running";
        public static string UnregisteredVersionTxt = "Unregistered Version";
        public static string RegisteredToTxt = "Registred To";
        public static string TrialTxt = "Trial";
        public static string YouReachedTxt = "Your Reached ";
        public static string CannotAddMoreItmsForTrialVersionTxt = "Cannot Add More Items Form Trial Version";
        public static string TrialAllowedItemsTxt = "Trial Maximum Allowed Items";
        public static string YouShouldActivateNowTxt = "You Should Activate Now";
 

        #endregion [V01E-V01F]


        #region ADDED IN V01M
        public static string OpeningBalTxt = "Opening Balance";
        #endregion ADDE IN V01M
        public static void TranslateMsgsTxt()
        {
            #region [V01A-V01D Translation]
            AccountTxt = ResourcesManager.GetString("MsgAccountTxt");
            AddAnotherItemTxt = ResourcesManager.GetString("MsgAddAnotherItemTxt");
            AddedSuccessfully = ResourcesManager.GetString("MsgAddedSuccessfully");
            AddNewTxt = ResourcesManager.GetString("MsgAddNewTxt");
            AlreadyUsedTxt = ResourcesManager.GetString("MsgAlreadyUsedTxt");
            BarcodeTxt = ResourcesManager.GetString("MsgBarcodeTxt");
            BillNumberNotExistTxt = ResourcesManager.GetString("MsgBillNumberNotExistTxt");
            CannotChangeAdminTxt = ResourcesManager.GetString("MsgCannotChangeAdminTxt");
            CannotFindTxt = ResourcesManager.GetString("MsgCannotFindTxt");
            CheckHolderNameTxt = ResourcesManager.GetString("MsgCheckHolderNameTxt");
            CustomerTxt = ResourcesManager.GetString("MsgCustomerTxt");
            DataBaseErrorTxt = ResourcesManager.GetString("MsgDataBaseErrorTxt");
            DescriptionTxt = ResourcesManager.GetString("MsgDescriptionTxt");
            DidnotAdded = ResourcesManager.GetString("MsgDidnotAdded");
            DisposalReasonTxt = ResourcesManager.GetString("MsgDisposalReasonTxt");
            DoNotAcceptTxt = ResourcesManager.GetString("MsgDoNotAcceptTxt");
            ErrorCaption = ResourcesManager.GetString("MsgErrorCaption");
            ErrorLoadingFrom = ResourcesManager.GetString("MsgErrorLoadingFrom");
            ErrorPleaseEnterCorrectAmount = ResourcesManager.GetString("MsgErrorPleaseEnterCorrectAmount");
            FormWillCloseNowTxt = ResourcesManager.GetString("MsgFormWillCloseNowTxt");
            IfNotBarChkWithoutBarcodeTxt = ResourcesManager.GetString("MsgIfNotBarChkWithoutBarcodeTxt");
            InformationCaption = ResourcesManager.GetString("MsgInformationCaption");
            ItemCategoryTxt = ResourcesManager.GetString("MsgItemCategoryTxt");
            ItemNotFoundTxt = ResourcesManager.GetString("MsgItemNotFoundTxt");
            ItemTypeTxt = ResourcesManager.GetString("MsgItemTypeTxt");
            NameTxt = ResourcesManager.GetString("MsgNameTxt");
            PercentageTxt = ResourcesManager.GetString("MsgPercentageTxt");
            PhoneInUse = ResourcesManager.GetString("MsgPhoneInUse");
            PleaseAddAllRequiredFields = ResourcesManager.GetString("MsgPleaseAddAllRequiredFields");
            PleaseAddCreditCardInfoTxt = ResourcesManager.GetString("MsgPleaseAddCreditCardInfoTxt");
            PleaseSelectCorrectAmountTxt = ResourcesManager.GetString("MsgPleaseSelectCorrectAmountTxt");
            PleaseSelectTxt = ResourcesManager.GetString("MsgPleaseSelectTxt");
            PleaseTryAgainLaterTxt = ResourcesManager.GetString("MsgPleaseTryAgainLaterTxt");
            PriceLevelsTxt = ResourcesManager.GetString("MsgPriceLevelsTxt");
            RenderPointTxt = ResourcesManager.GetString("MsgRenderPointTxt");
            SellingPriceTxt = ResourcesManager.GetString("MsgSellingPriceTxt");
            UnexpectedError = ResourcesManager.GetString("MsgUnexpectedError");
            UnitCostTxt = ResourcesManager.GetString("MsgUnitCostTxt");
            UpdateSuccessfully = ResourcesManager.GetString("MsgUpdateSuccessfully");
            UserTxt = ResourcesManager.GetString("MsgUserTxt");
            ValidAccountTxt = ResourcesManager.GetString("MsgValidAccountTxt");
            ValidQtyTxt = ResourcesManager.GetString("MsgValidQtyTxt");
            VendorTxt = ResourcesManager.GetString("MsgVendorTxt");
            WarningCaption = ResourcesManager.GetString("MsgWarningCaption");
            #endregion [V01A-V01D Translation]



            #region [V01E-V01F Translation]
            // Translation of region [**START**] [V01E-V01F] Added on October 2 2013 By Ayman Al-Marashdeh
            AlreadyCheckedTxt = ResourcesManager.GetString("MsgAlreadyCheckedTxt");
            AlreadyReversedTxt = ResourcesManager.GetString("MsgAlreadyReversedTxt");
            CheckedSuccesfullyTxt = ResourcesManager.GetString("MsgCheckedSuccesfullyTxt");
            ReversedSuccessfullyTxt = ResourcesManager.GetString("MsgReversedSuccessfullyTxt");
            NotUsedTxt = ResourcesManager.GetString("MsgNotUsedTxt");
            ItemTxt = ResourcesManager.GetString("MsgItemTxt");
            PrivUserNotAllowedTxt = ResourcesManager.GetString("MsgPrivUserNotAllowedTxt");
            PhoneTxt = ResourcesManager.GetString("MsgPhoneTxt");
            CompanyTxt = ResourcesManager.GetString("MsgCompanyTxt");
            ShouldNotBeLessThanTxt = ResourcesManager.GetString("MsgShouldNotBeLessThanTxt");
            AlreadyTempUserTxt = ResourcesManager.GetString("MsgAlreadyTempUserTxt");
            NotFoundTxt = ResourcesManager.GetString("MsgNotFoundTxt");
            IncorrectTxt = ResourcesManager.GetString("MsgIncorrectTxt");
            OrTxt = ResourcesManager.GetString("MsgOrTxt");
            UsrNameTxt = ResourcesManager.GetString("MsgUsrNameTxt");
            PasswordTxt = ResourcesManager.GetString("MsgPasswordTxt");
            CannotBeCalculatedTxt = ResourcesManager.GetString("MsgCannotBeCalculatedTxt");
            DoNotHaveAccountTxt = ResourcesManager.GetString("MsgDoNotHaveAccountTxt");
            PaymentMethodTxt = ResourcesManager.GetString("MsgPaymentMethodTxt");
            NotItemsTxt = ResourcesManager.GetString("MsgNotItemsTxt");
            CashLargerThanTotAmtTxt = ResourcesManager.GetString("MsgCashLargerThanTotAmtTxt");
            SureToTakePaymentTxt = ResourcesManager.GetString("MsgSureToTakePaymentTxt");
            TotalAmountTxt = ResourcesManager.GetString("MsgTotalAmountTxt");
            ExchangeTxt = ResourcesManager.GetString("MsgExchangeTxt");
            CurrencyTxt = ResourcesManager.GetString("MsgCurrencyTxt");
            TransactionNotAddedSuccessfullyTxt = ResourcesManager.GetString("MsgTransactionNotAddedSuccessfullyTxt");
            PrintingErrorTxt = ResourcesManager.GetString("MsgPrintingErrorTxt");
            ChequeTxt = ResourcesManager.GetString("MsgChequeTxt");
            NotAddedTxt = ResourcesManager.GetString("MsgNotAddedTxt");
            ReportTxt = ResourcesManager.GetString("MsgReportTxt");
            NoDataTxt = ResourcesManager.GetString("MsgNoDataTxt");
            DateFromTxt = ResourcesManager.GetString("MsgDateFromTxt");
            DateToTxt = ResourcesManager.GetString("MsgDateToTxt");
            NumberOfItemsPerPageTxt = ResourcesManager.GetString("MsgNumberOfItemsPerPageTxt");
            DesiredListTxt = ResourcesManager.GetString("MsgDesiredListTxt");
            PleaseCheckSQLServiceTxt = ResourcesManager.GetString("MsgPleaseCheckSQLServicTxt");
            UnregisteredVersionTxt = ResourcesManager.GetString("MsgUnregisteredVersionTxt");
            RegisteredToTxt = ResourcesManager.GetString("MsgRegisteredToTxt");
            TrialTxt = ResourcesManager.GetString("MsgTrialTxt");
            YouReachedTxt = ResourcesManager.GetString("MsgYouReachedTxt");
            CannotAddMoreItmsForTrialVersionTxt = ResourcesManager.GetString("MsgCannotAddMoreItmsForTrialVersionTxt");
            TrialAllowedItemsTxt = ResourcesManager.GetString("MsgTrialAllowedItemsTxt");
            YouShouldActivateNowTxt = ResourcesManager.GetString("MsgYouShouldActivateNowTxt");
            // Translation of region [**END**] [V01E-V01F] Added on October 2 2013 By Ayman Al-Marashdeh
            #endregion [V01E-V01F Translation]
            
        }

    }
}
