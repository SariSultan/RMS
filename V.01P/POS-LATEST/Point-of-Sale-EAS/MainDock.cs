using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class MainDock : Form
    {
        public MainDock()
        {
          
            InitializeComponent();
            
            TranslateUI();
           
        }
        private void AddNewItemBtn_Click(object sender, EventArgs e)
        {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddNewItem) == EventStatus.Permit)
                {
                    AddNewItem aAddNewItem = new AddNewItem();
                   
                   // aAddNewItem.MdiParent = Helper.Instance.ActiveMainWindow;
                    aAddNewItem.Show();
                }
                else
                {
                    MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditItems) == EventStatus.Permit)
            {
                EditItems aEditItem = new EditItems();
                aEditItem.Show();
                //aEditItem.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void ListItems_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListItems) == EventStatus.Permit)
            {
                ListItems aListItem = new ListItems();
                aListItem.Show();
               // aListItem.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddCustomer) == EventStatus.Permit)
            {
                AddCustomer aAddCustomer = new AddCustomer();
               // aAddCustomer.MdiParent = Helper.Instance.ActiveMainWindow;
                
                aAddCustomer.Show();
                
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditCustomers) == EventStatus.Permit)
            {
                EditCustomer aEditCustomer = new EditCustomer();
                aEditCustomer.Show();
               // aEditCustomer.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         
            

        }

        private void ListCustomersBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListCustomers) == EventStatus.Permit)
            {
                ListCustomers aListCustomers = new ListCustomers();
                aListCustomers.Show();
              //  aListCustomers.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void PointOfSaleBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.POS) == EventStatus.Permit)
            {
                POS aPOS = new POS();
                aPOS.Show();
                //aPOS.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PurchaseVoucherBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.PurchaseVoucher) == EventStatus.Permit)
            {
                PurchaseVoucher aPurchaseVoucher = new PurchaseVoucher();
                aPurchaseVoucher.StartPosition = FormStartPosition.CenterParent;
                aPurchaseVoucher.Show();
                
               // aPurchaseVoucher.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListVouchersBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListVouchers) == EventStatus.Permit)
            {
                ListVouchers aListVouchers = new ListVouchers();
                aListVouchers.Show();
               // aListVouchers.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListBillsBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListBills) == EventStatus.Permit)
            {
                ListBills aListBills = new ListBills();
                aListBills.Show();
              //  aListBills.MdiParent = Helper.Instance.ActiveMainWindow;
               // aListBills.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MakeASaleBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues( Calcium_RMS.Events.POS)== EventStatus.Permit )
            {
                POS aPOS = new POS();


                //aPOS.MdiParent = Helper.Instance.ActiveMainWindow;
                aPOS.WindowState = FormWindowState.Maximized;
                aPOS.Show();
               // aPOS.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddVendorBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddVendor) == EventStatus.Permit)
            {
                AddVendor aAddVendor = new AddVendor();
              //  aAddVendor.MdiParent = Helper.Instance.ActiveMainWindow;
                aAddVendor.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListVendorsBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListVendors) == EventStatus.Permit)
            {
                ListVendors aListVendors = new ListVendors();
               // aListVendors.MdiParent = Helper.Instance.ActiveMainWindow;
                aListVendors.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TranslateUI()
        {
           // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
           //// this.RightToLeftLayout = true;
            POSGB.Text = UiText.MainDkPOSGB;
            AddCustomerLbl.Text = UiText.MainDkAddCustomerLbl;
            AddNewITemLbl.Text = UiText.MainDkAddNewITemLbl;
            AddVendorLbl.Text = UiText.MainDkAddVendorLbl;
            AddVendorPaymentLbl.Text = UiText.MainDkAddVendorPaymentLbl;
            CustomersGB.Text = UiText.MainDkCustomersGB;
            EditCustomersLbl.Text = UiText.MainDkEditCustomersLbl;
            InventoryGB.Text = UiText.MainDkInventoryGB;
            ListBillsLbl.Text = UiText.MainDkListBillsLbl;
            ListCustomersLbl.Text = UiText.MainDkListCustomersLbl;
            ListItemsLbl.Text = UiText.MainDkListItemsLbl;
            ListVendorsLbl.Text = UiText.MainDkListVendorsLbl;
            MakeSaleLbl.Text = UiText.MainDkMakeSaleLbl;
            ReportsGB.Text = UiText.MainDkReportsGB;
            ReportsLbl.Text = UiText.MainDkReportsLbl;
            VendorsGB.Text = UiText.MainDkVendorsGB;
        }

        private void AddVendorPaymentBtn_Click(object sender, EventArgs e)
        {
            AddVendorPayment aAddVendorPayment = new AddVendorPayment();
           // aAddVendorPayment.MdiParent = Helper.Instance.ActiveMainWindow;
            aAddVendorPayment.Show();
        }

        private void ReportsBtn_Click(object sender, EventArgs e)
        {
            ReportsFrm aReport = new ReportsFrm();
           // aReport.MdiParent = Helper.Instance.ActiveMainWindow;
            aReport.WindowState = FormWindowState.Maximized;
            aReport.Show();
        }
       
    }
}
