using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calcium_RMS.Text
{
    public static class FormsNames
    {
        
        public static string AccountsFormName = "Accounts Management";

        public static string AddCustomerFormName = "Add New Customer";

        public static string AddCustomerPaymentFormName = "Add Customer Payment";

        public static string AddDisposalReasonFormName  = "Add Disposal Reason";

        public static string AddNewCatFormName          = "Add New Category";

        public static string AddNewItemFormName         = "Add New Item";

        public static string AddNewTypeFormName         ="Add New Item Type";

        public static string AddNewPriceLevelFormName   = "Add New Price Level";

        public static string AddNewUserFormName         = "Add New User";

        public static string AddNewTaxLevelFormName     = "Add New Tax Level";

        public static string AddNewVednorFormName       = "Add New Tax Level";

        public static string AddNewVendorPaymentFormName= "Add New Vendor Payment";

        public static string ChooseBillToEditFormName   = "Edit Bill";

        public static string DisposeItemsFormName       = "Dispose Items";

        public static string EditAdminsFormName         = "Edit Admins";

        public static string EditBillFormName           = "Edit Bill";

        public static string EditCustomerFormName       = "Edit Customer";

        public static string EditCustomerPaymentFormName= "Edit Customer Payment";

        public static string EditDisposeItemsFormName   = "Edit Dispose Items";

        public static string EditItemsFormName          = "Edit Items";

        public static string EditReturnItemsCustFormName= "Edit Return Items Customer";

        public static string EditReturnItemsVendFormName= "Edit Return Items Vendor";

        public static string EditTouchScreenItmsFormName= "Edit  Touch Screen Items";

        public static string EditUserFormName           = "Edit User";

        public static string EditVendorFormName         = "Edit Vendor";

        public static string EditVendorPaymentFormName  = "Edit Vendor Payment";

        public static string EditPurchaseVoucherFormName= "Edit Purchase Voucher";

        public static string ListBillsFormName          = "List Bills";

        public static string ListCustomersFormName      = "List Customers";

        public static string ListItemsFormName          = "Items List";

        public static string ListUsersFormName          = "List Users";

        public static string ListVendorsFormName        = "List Vendors";

        public static string ListVouchersFormName       = "List Vouchers";

        public static string LoginFormName              = "Login";

        public static string MainDockFormName           = "Home Screen";

        public static string POSFormName                = "Point Of Sale";

        public static string PrintingSettingFormName    = "Printing Settings";

        public static string PurchaseVoucherFormName    = "Purchase Voucher";

        public static string ReportsFormName            = "Reports";

        public static string ReturnItemsCustomerFormName= "Return Items From Customer";

        public static string ReturnItemsVendorFormName  = "Return Items To Vendor";

        public static string TouchScreenFormName        = "POS-Touch Screen";

        public static string WeightConfigFormName       = "Weight Config";

       
        /// <-- Ayman Work Starts Here -->
        public static void TranslateFormsNames() 
        {
            // TAG: [FrmNm] //

            AccountsFormName = ResourcesManager.GetString("FrmNmAccntMgmt");//"AccountsManagement";

            AddCustomerFormName = ResourcesManager.GetString("FrmNmAddNewCustomer");//"AddNewCustomer";

            AddCustomerPaymentFormName = ResourcesManager.GetString("FrmNmAddCustomerPayment");//"AddCustomerPayment";

            AddDisposalReasonFormName = ResourcesManager.GetString("FrmNmAddDisposalReason");//"AddDisposalReason";

            AddNewCatFormName = ResourcesManager.GetString("FrmNmAddNewCategory");//"AddNewCategory";

            AddNewItemFormName = ResourcesManager.GetString("FrmNmAddNewItem");//"AddNewItem";

            AddNewTypeFormName = ResourcesManager.GetString("FrmNmAddNewItemType");//"AddNewItemType";

            AddNewPriceLevelFormName = ResourcesManager.GetString("FrmNmAddNewPriceLevel");//"AddNewPriceLevel";

            AddNewUserFormName = ResourcesManager.GetString("FrmNmAddNewUser");//"AddNewUser";

            AddNewTaxLevelFormName = ResourcesManager.GetString("FrmNmAddNewTaxLevel");//"AddNewTaxLevel";

            AddNewVednorFormName = ResourcesManager.GetString("FrmNmAddNewVendor");//"AddNewTaxLevel";

            AddNewVendorPaymentFormName = ResourcesManager.GetString("FrmNmAddNewVendorPayment");//"AddNewVendorPayment";

            ChooseBillToEditFormName = ResourcesManager.GetString("FrmNmEditBill");//"EditBill";

            DisposeItemsFormName = ResourcesManager.GetString("FrmNmDisposeItems");//"DisposeItems";

            EditAdminsFormName = ResourcesManager.GetString("FrmNmEditAdmins");//"EditAdmins";

            EditBillFormName = ResourcesManager.GetString("FrmNmEditBill");//"EditBill";

            EditCustomerFormName = ResourcesManager.GetString("FrmNmEditCustomer");//"EditCustomer";

            EditCustomerPaymentFormName = ResourcesManager.GetString("FrmNmEditCustomerPayment");//"EditCustomerPayment";

            EditDisposeItemsFormName = ResourcesManager.GetString("FrmNmEditDisposeItems");//"EditDisposeItems";

            EditItemsFormName = ResourcesManager.GetString("FrmNmEditItems");//"EditItems";

            EditReturnItemsCustFormName = ResourcesManager.GetString("FrmNmEditReturnItemsCustomer");//"EditReturnItemsCustomer";

            EditReturnItemsVendFormName = ResourcesManager.GetString("FrmNmEditReturnItemsVendor");//"EditReturnItemsVendor";

            EditTouchScreenItmsFormName = ResourcesManager.GetString("FrmNmEditReturnTouchScreenItems");//"EditReturnTouchScreenItems";

            EditUserFormName = ResourcesManager.GetString("FrmNmEditUser");//"EditUser";

            EditVendorFormName = ResourcesManager.GetString("FrmNmEditVendor");//"EditVendor";

            EditVendorPaymentFormName = ResourcesManager.GetString("FrmNmEditVendorPayment");//"EditVendorPayment";

            EditPurchaseVoucherFormName = ResourcesManager.GetString("FrmNmEditPurchaseVoucher");//"EditPurchaseVoucher";

            ListBillsFormName = ResourcesManager.GetString("FrmNmListBills");//"ListBills";

            ListCustomersFormName = ResourcesManager.GetString("FrmNmListCustomers");//"ListCustomers";

            ListItemsFormName = ResourcesManager.GetString("FrmNmListItems");//"ListItems";

            ListUsersFormName = ResourcesManager.GetString("FrmNmListUsers");//"ListUsers";

            ListVendorsFormName = ResourcesManager.GetString("FrmNmListVendors");//"ListVendors";

            ListVouchersFormName = ResourcesManager.GetString("FrmNmListVouchers");//"ListVouchers";

            LoginFormName = ResourcesManager.GetString("FrmNmLogin");//"Login";

            MainDockFormName = ResourcesManager.GetString("FrmNmHomeScreen");//"HomeScreen";

            POSFormName = ResourcesManager.GetString("FrmNmPointOfSale");//"PointOfSale";

            PrintingSettingFormName = ResourcesManager.GetString("FrmNmPrintingSettings");//"PrintingSettings";

            PurchaseVoucherFormName = ResourcesManager.GetString("FrmNmPurchaseVoucher");//"PurchaseVoucher";

            ReportsFormName = ResourcesManager.GetString("FrmNmReports");//"Reports";

            ReturnItemsCustomerFormName = ResourcesManager.GetString("FrmNmReturnItemsFromCustomer");//"ReturnItemsFromCustomer";

            ReturnItemsVendorFormName = ResourcesManager.GetString("FrmNmReturnItemsToVendor");//"ReturnItemsToVendor";

            TouchScreenFormName = ResourcesManager.GetString("FrmNmPOSTouchScreen");//"POS-TouchScreen";

            WeightConfigFormName = ResourcesManager.GetString("FrmNmWeightConfig");//"WeightConfig";
        }
        /// <-- Ayman Work Ends Here -->
    }
}
