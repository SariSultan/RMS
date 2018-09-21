using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Management;
using System.Data;

namespace Calcium_RMS
{
    public enum EventStatus
    {
        Permit,
        Deny
    }

    public enum Events : int
    {
        //Customers
        AddCustomer=1,
        AddCustomerPayment,
        CustomerDebitCredit,
        ListCustomers,
        EditCustomerPayment,
        EditCustomers,
        //Vendors
        AddVendor,
        AddVendorPayment,
        VendorDebitCredit,
        EditVendors,
        ListVendors,
        EditVendorPayment,
        PurchaseVoucher,
        ListVouchers,
        EditVouchers,
        //POS
        POS,
        TouchScreen,
        ListBills,
        EditBills,        
        //Inventory
        AddNewItem,
        AddItemType,
        AddDisposalReason,
        AddNewCategory,
        AddNewPriceLevel,
        DisposeItems,
        AddNewTaxLevel,
        EditItems,
        WeightEditing,
        ListItems,
        //Reports
        Reports,
        //Administration
        EditAccounts,
        AddNewUser,
        EditUsers,
        ListUsers,
        PrintingSettings,
        EditAdmins,
        //POS
        EditTouchScreenItems,
        //TOOLS
        DataBaseSettings,
        /*Inventory Added New V01O*/
        AdjustItems,
        EditAdjustItems,
        Discount,
        ListAdjustItems,
    }

    public static class PrivilegesManager
    {

        static PrivilegesTemplate AdminTemplate;

        static PrivilegesTemplate CurrentUserTemplate;

        static PrivilegesTemplate TempUserTemplate;

        static PrivilegesTemplate CurrentActiveTemplate { get; set; }

        static PrivilegesManager()
        {
            AdminTemplate = new PrivilegesTemplate();

            CurrentUserTemplate = new PrivilegesTemplate();

            TempUserTemplate = new PrivilegesTemplate();

        }

        public static EventStatus GetEventStatues(Events aEvent)
        {
            if (!IsTempActive)
            {
                if (IsCurrentUserAdmin)
                {
                    if (aEvent == Events.EditAdmins)
                    {
                        return AdminTemplate.GetStatus(aEvent);
                    }

                    else
                    {
                        return EventStatus.Permit;
                    }
                }
            }
            else
            {
                if (IsTempUserAdmin)
                {
                    if (aEvent == Events.EditAdmins)
                    {
                        return TempUserTemplate.GetStatus(aEvent);
                    }

                    else
                    {
                        return EventStatus.Permit;
                    }
                }
            }
            return CurrentActiveTemplate.GetStatus(aEvent);
        }
        static bool isTempActive = false;
        public static bool IsTempActive
        {
            get { return isTempActive; }
            set
            {
                isTempActive = value;
                if (isTempActive)
                {
                    SetActiveTemplate(2);
                }
                else
                {
                    SetActiveTemplate(0);
                }
            }
        }
        static bool isAdminActive = false;
        public static bool IsAdminActive
        {
            get { return isAdminActive; }
            set
            {
                isAdminActive = value;
                if (isAdminActive)
                {
                    SetActiveTemplate(1);
                }
                else
                {
                    SetActiveTemplate(0);
                }
            }
        }

        static void SetActiveTemplate(int aTempID)
        {
            switch (aTempID)
            {
                case 0:
                    CurrentActiveTemplate = CurrentUserTemplate;
                    break;
                case 1:
                    CurrentActiveTemplate = AdminTemplate;
                    break;
                case 2:
                    CurrentActiveTemplate = TempUserTemplate;
                    break;
                default:
                    break;
            }
        }
        public static bool IsCurrentUserAdmin { get; set; }
        public static bool IsTempUserAdmin { get; set; }
        public static void FillTemplate(int UserID, bool isTemp = false)
        {
            if (IsCurrentUserAdmin && !isTemp)
            {
                CurrentActiveTemplate = AdminTemplate;
                CurrentActiveTemplate.ClearPermittedEvents();
                DataTable dtEvets = PriviligesMgmt.SelectEventIDbyUserID(UserID);
                foreach (DataRow dr in dtEvets.Rows)
                {
                    CurrentActiveTemplate.AddPermittedEvent((Events)dr[0]);
                }
            }
            else if (!isTemp)
            {
                CurrentActiveTemplate = CurrentUserTemplate;
                CurrentActiveTemplate.ClearPermittedEvents();
                DataTable dtEvets = PriviligesMgmt.SelectEventIDbyUserID(UserID);
                foreach (DataRow dr in dtEvets.Rows)
                {
                    CurrentActiveTemplate.AddPermittedEvent((Events)dr[0]);
                }
            }
            else
            {
                CurrentActiveTemplate = TempUserTemplate;
                CurrentActiveTemplate.ClearPermittedEvents();
                DataTable dtEvets = PriviligesMgmt.SelectEventIDbyUserID(UserID);
                foreach (DataRow dr in dtEvets.Rows)
                {
                    CurrentActiveTemplate.AddPermittedEvent((Events)dr[0]);
                }
            }
        }

        public static void ClearCurrentTemplate()
        {
            CurrentActiveTemplate.ClearPermittedEvents();
        }

        public static void ClearTempTemplate()
        {
            TempUserTemplate.ClearPermittedEvents();
        }
    }

    public class PrivilegesTemplate
    {
        List<Events> PermittedEvents;
        public PrivilegesTemplate()
        {
            PermittedEvents = new List<Events>();
        }
        public void AddPermittedEvent(Events aEvent)
        {
            if (PermittedEvents.Contains(aEvent))
            {
                return;
            }
            else
            {
                PermittedEvents.Add(aEvent);
            }
        }

        public void ClearPermittedEvents()
        {
            PermittedEvents.Clear();
        }

        public EventStatus GetStatus(Events aEvent)
        {
            if (PermittedEvents.Contains(aEvent))
            {
                return EventStatus.Permit;
            }
            else
            {
                return EventStatus.Deny;
            }
        }

    }
}
