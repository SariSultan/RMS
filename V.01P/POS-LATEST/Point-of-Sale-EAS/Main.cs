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
    public partial class Main : Form
    {


        
        public Main()
        {   
            InitializeComponent();
           // Helper.Instance.SetMainWindow(this);
            MdiClient ctlMDI;
        TranslateUI();
            
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;
                    // Set the BackColor of the MdiClient control.
                  //  ctlMDI.BackColor = Color.Aqua;               
                }
           
                catch { }
            }
            
           
        }

        private void mdiBackgroundPaint(object sender, PaintEventArgs e)
        {
           //var mdi = sender as MdiClient;
           //if (mdi == null) return;
           //e.Graphics.Clip = new System.Drawing.Region(mdi.ClientRectangle);
         //   e.Graphics.DrawString("*** Sari ***", this.Font, Brushes.Red, this.Height / 2, this.Width / 2);
            
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Mtile = DateTime.Now;
            toolTime.Text = Mtile.ToLongTimeString();
            toolDate.Text = Mtile.DayOfWeek.ToString() + ' ' + Mtile.ToShortDateString();
        }

        private void Main_Load(object sender, EventArgs e)
        {            
           // login login_form = new login();
         //   login_form.ShowDialog();
            if (SharedVariables.is_user_logged)
            {
                UserLoggedTxt.Text = SharedVariables.user_logged_name +": " +SharedVariables.user_logged_name_name;
                LogOutLabel.Visible = true;
              //  LogOutBtn.Visible = true;

                DateTime Date = DateTime.Now;
                toolDate.Text = Date.ToShortDateString();
                timer1.Start();
                UpdateMain();

                MainDock aMainDock = new MainDock();
                aMainDock.Text = "Home";
                aMainDock.WindowState = FormWindowState.Maximized;
                aMainDock.MdiParent = this;
                aMainDock.Show();

            }
            else
            {
                Application.Exit();
            }
        }

        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe");
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void titleHotizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void closeAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (childForm.Text != "Home")
                    childForm.Close();
            }
        }

        private void exitToWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("Are you want to Exit!", "Exit".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

       

        private void UpdateMain()
        {
            

        }


        private void EmpControl_Click(object sender, EventArgs e)
        {
       
        }

        private void POSBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddNewItemBtn_Click(object sender, EventArgs e)
        {
            AddNewItem aAddNewItem = new AddNewItem();
            aAddNewItem.Show();
            aAddNewItem.MdiParent = this;
            UpdateMain();
        }

        private void EditItemBtn_Click(object sender, EventArgs e)
        {
            EditItems aEditItem = new EditItems();
            aEditItem.Show();
            aEditItem.MdiParent = this;
            UpdateMain();
        }

        private void ListItems_Click(object sender, EventArgs e)
        {
            ListItems aListItem = new ListItems();
            aListItem.Show();
            aListItem.MdiParent = this;
            UpdateMain();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer aAddCustomer = new AddCustomer();
            aAddCustomer.Show();
            aAddCustomer.MdiParent = this;
            UpdateMain();
        }

        private void EditCustomerBtn_Click(object sender, EventArgs e)
        {
            EditCustomer aEditCustomer = new EditCustomer();
            aEditCustomer.Show();
            aEditCustomer.MdiParent = this;
            UpdateMain();

        }

        private void ListCustomersBtn_Click(object sender, EventArgs e)
        {
            ListCustomers aListCustomers = new ListCustomers();
            aListCustomers.Show();
            aListCustomers.MdiParent = this;
            UpdateMain();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Report aReport = new Report();
            //aReport.Show();
        }

        private void PointOfSaleBtn_Click(object sender, EventArgs e)
        {
            POS aPOS = new POS();
            aPOS.Show();
            aPOS.MdiParent = this;
            UpdateMain();
        }

        private void PurchaseVoucherBtn_Click(object sender, EventArgs e)
        {

            PurchaseVoucher aPurchaseVoucher = new PurchaseVoucher();
            aPurchaseVoucher.Show();
            //aPurchaseVoucher.MdiParent = this;
            UpdateMain();
        }

        private void ListVouchersBtn_Click(object sender, EventArgs e)
        {
            ListVouchers aListVouchers = new ListVouchers();
            aListVouchers.Show();
            aListVouchers.MdiParent = this;
            UpdateMain();
        }

        private void ListBillsBtn_Click(object sender, EventArgs e)
        {
            ListBills aListBills = new ListBills();
            aListBills.Show();
            aListBills.MdiParent = this;
            UpdateMain();
        }

        private void LogotTemp_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.IsTempActive)
            {
                PrivilegesManager.IsTempActive = false;
                //LogotTemp.Visible = false;
                PrivilegesManager.ClearTempTemplate();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!PrivilegesManager.IsTempActive)
            {
                login logingWin = new login();
                logingWin.ShowDialog();

            }
            else
            {
                MessageBox.Show("You are temp already");
            }

            if (PrivilegesManager.IsTempActive)
            {
                //LogotTemp.Visible = true;
            }
        }

        private void makeASaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.POS) == EventStatus.Permit)
            {
                POS aPOS = new POS();
             //   aPOS.MdiParent = Helper.Instance.ActiveMainWindow;
                aPOS.Visible = false;
                aPOS.Activate();
               // aPOS.Show();
                aPOS.Visible = true;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListBills) == EventStatus.Permit)
            {
                ListBills aListBills = new ListBills();
                aListBills.Show();
             //   aListBills.MdiParent = Helper.Instance.ActiveMainWindow;
                aListBills.Dock = DockStyle.Fill;
                aListBills.BringToFront();               
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addNewItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddNewItem) == EventStatus.Permit)
            {
                AddNewItem aAddNewItem = new AddNewItem();
                //aAddNewItem.MdiParent = Helper.Instance.ActiveMainWindow;
                aAddNewItem.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void InventoryBtn_Click(object sender, EventArgs e)
        {

        }

        private void editItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditItems) == EventStatus.Permit)
            {
                EditItems aEditItem = new EditItems();
                aEditItem.Show();
               // aEditItem.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListItems) == EventStatus.Permit)
            {
                ListItems aListItem = new ListItems();
                aListItem.Show();
             //   aListItem.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddCustomer) == EventStatus.Permit)
            {
                AddCustomer aAddCustomer = new AddCustomer();
             ///   aAddCustomer.MdiParent = Helper.Instance.ActiveMainWindow;
                aAddCustomer.Show();
              //  aAddCustomer.WindowState = FormWindowState.Normal;

                
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditCustomers) == EventStatus.Permit)
            {
                EditCustomer aEditCustomer = new EditCustomer();
                aEditCustomer.Show();
             //   aEditCustomer.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newPurchaseVoucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.PurchaseVoucher) == EventStatus.Permit)
            {
                PurchaseVoucher aPurchaseVoucher = new PurchaseVoucher();
                aPurchaseVoucher.Show();
              //  aPurchaseVoucher.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listVouchersToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void listCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListCustomers) == EventStatus.Permit)
            {
                ListCustomers aListCustomers = new ListCustomers();
                aListCustomers.Show();
               // aListCustomers.MdiParent = Helper.Instance.ActiveMainWindow;
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addNewVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddVendor) == EventStatus.Permit)
            {
                AddVendor aAddVendor = new AddVendor();
               // aAddVendor.MdiParent = Helper.Instance.ActiveMainWindow;
                aAddVendor.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listVendorsToolStripMenuItem_Click(object sender, EventArgs e)
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


        private void LoginAgainAfterLogout()
        {
            login login_form = new login();
            login_form.IsFirstLogin = true;
            login_form.Show();
            Application.Restart();
            if (SharedVariables.is_user_logged)
            {
                UserLoggedTxt.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
                LogOutLabel.Visible = true;
              //  LogOutBtn.Visible = true;

                DateTime Date = DateTime.Now;
                toolDate.Text = Date.ToShortDateString();
                timer1.Start();
                UpdateMain();


                MainDock aMainDock = new MainDock();
                aMainDock.Text = "aMainDock";
                aMainDock.MdiParent = this;
                aMainDock.Show();
                // aMainDock.FormBorderStyle = FormBorderStyle.None;
                //aMainDock.Dock = DockStyle.Fill;
                // aMainDock.Size = new Size(this.Width - 300, this.Height - 300);
               
            }
            else
            {
                Application.Exit();
            }
        }

        private void usersAndPriviligesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListUsers) == EventStatus.Permit)
            {
                ListUsers aListUser = new ListUsers();
               // aListUser.MdiParent = Helper.Instance.ActiveMainWindow;
                aListUser.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditUsers) == EventStatus.Permit)
            {
                EditUser aEditUser = new EditUser();
                aEditUser.Visible = false;
                //aEditUser.MdiParent = Helper.Instance.ActiveMainWindow;
                aEditUser.Activate();
                aEditUser.Visible = true;
//                aEditUser.Show();
                
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddNewUser) == EventStatus.Permit)
            {
                AddNewUser aAddNewUser = new AddNewUser();
              //  aAddNewUser.MdiParent = Helper.Instance.ActiveMainWindow;
                aAddNewUser.Show();

            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditBills) == EventStatus.Permit)
                {
                    ChooseBillToEdit aChooseBillToEdit = new ChooseBillToEdit();
                   // aChooseBillToEdit.MdiParent = Helper.Instance.ActiveMainWindow;
                    aChooseBillToEdit.Show();

                }
                else
                {
                    MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }



        private void addCustomerPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerPayment aAddCustomerPayment = new AddCustomerPayment();
           // aAddCustomerPayment.MdiParent = Helper.Instance.ActiveMainWindow;
            aAddCustomerPayment.Show();
        }

        private void customerDebitCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDebitCredit aCustomerDebitCredit = new CustomerDebitCredit();
            //aCustomerDebitCredit.MdiParent = Helper.Instance.ActiveMainWindow;
            aCustomerDebitCredit.WindowState = FormWindowState.Normal;

            aCustomerDebitCredit.Show();
        }

        private void vendorsDebitCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorsDebitCredit aVendorDebitCredit = new VendorsDebitCredit();
           // aVendorDebitCredit.MdiParent = Helper.Instance.ActiveMainWindow;
            
            aVendorDebitCredit.Show();
            aVendorDebitCredit.WindowState = FormWindowState.Normal;
        }

        private void addVendorPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVendorPayment aAddVendorPayment = new AddVendorPayment();
          //  aAddVendorPayment.MdiParent = Helper.Instance.ActiveMainWindow;
            aAddVendorPayment.Show();
            aAddVendorPayment.WindowState = FormWindowState.Normal;
        }

        private void disposeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisposeItems aDisposeItem = new DisposeItems();
           // aDisposeItem.MdiParent = Helper.Instance.ActiveMainWindow;
            aDisposeItem.Show();
            aDisposeItem.WindowState = FormWindowState.Normal;
        }

     




        private void tempLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!PrivilegesManager.IsTempActive)
            {
                login logingWin = new login();
                logingWin.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are temp already");
            }

            if (PrivilegesManager.IsTempActive)
            {
                UserLoggedTxt.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
                // LogotTemp.Visible = true;
                logoutTempToolStripMenuItem.Visible = true;
            }
        }

        private void logoutTempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.IsTempActive)
            {
                PrivilegesManager.IsTempActive = false;
                logoutTempToolStripMenuItem.Visible = false;
                PrivilegesManager.ClearTempTemplate();
                UserLoggedTxt.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
            }
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AccountsFrm aAccountsFrm = new AccountsFrm();
           // aAccountsFrm.MdiParent = Helper.Instance.ActiveMainWindow;
            aAccountsFrm.Show();
        }

        private void printingSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSettingsFrm aPrintingSettingForm = new PrintingSettingsFrm();
          //  aPrintingSettingForm.MdiParent = Helper.Instance.ActiveMainWindow;
            aPrintingSettingForm.Show();
        }

        private void editTouchScreenItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTouchScreenItems aEdit = new EditTouchScreenItems();
           // aEdit.MdiParent = Helper.Instance.ActiveMainWindow;
            aEdit.Show();
        }

        private void touchScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TouchScreenFrm aTouchScreen = new TouchScreenFrm();
            //aTouchScreen.MdiParent = Helper.Instance.ActiveMainWindow;
            aTouchScreen.Visible = false;
            aTouchScreen.Activate();
            aTouchScreen.Show();
            aTouchScreen.Visible = true;
        }

        private void weightSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WeightConfig aWeightConfig = new WeightConfig();
           // aWeightConfig.MdiParent = Helper.Instance.ActiveMainWindow;
            aWeightConfig.Show();

        }

        private void HomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainDock aMainDock = new MainDock();
           // aMainDock.MdiParent = Helper.Instance.ActiveMainWindow;
            aMainDock.Show();

        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("هل انت متأكد , سيتم اغلاق جميع المعاملات بدون حفط تلقائي؟", "تسجيل الخروج".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                SharedVariables.is_user_logged = false;
                UserLoggedTxt.Text = "Not Logged In";
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Dispose();
                    childForm.Close();
                }
                LoginAgainAfterLogout();
                //login aLogin = new login();
                //aLogin.IsFirstLogin = true;
                //aLogin.Show();
                PrivilegesManager.ClearCurrentTemplate();
            }
            else
            {
                return;
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("Are you want to Exit!", "Exit".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        //Garbage Collector
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                foreach (object obj in this.Controls)
                {
                    if (obj is IDisposable)
                    {
                        (obj as IDisposable).Dispose();
                    }
                }
                base.OnClosed(e);
                base.Dispose();
                this.Dispose();
                GC.Collect();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [OnClosed] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }
   
        private void TranslateUI()
        {
            POSBtn.Text = UiText.MainPOSBtn;
            makeASaleToolStripMenuItem.Text = UiText.MainmakeASaleToolStripMenuItem;
            listBillsToolStripMenuItem.Text = UiText.MainlistBillsToolStripMenuItem;
            editBillToolStripMenuItem.Text = UiText.MaineditBillToolStripMenuItem;
            editTouchScreenItemsToolStripMenuItem.Text = UiText.MaineditTouchScreenItemsToolStripMenuItem;
            touchScreenToolStripMenuItem.Text = UiText.MaintouchScreenToolStripMenuItem;
            InventoryBtn.Text = UiText.MainInventoryBtn;
            addNewItemToolStripMenuItem.Text = UiText.MainaddNewItemToolStripMenuItem;
            editItemsToolStripMenuItem.Text = UiText.MaineditItemsToolStripMenuItem;
            listItemsToolStripMenuItem.Text = UiText.MainlistItemsToolStripMenuItem;
            disposeItemsToolStripMenuItem.Text = UiText.MaindisposeItemsToolStripMenuItem;
            accountsToolStripMenuItem.Text = UiText.MainaccountsToolStripMenuItem;
            weightSettingsToolStripMenuItem.Text = UiText.MainweightSettingsToolStripMenuItem;
            purchaseOrderToolStripMenuItem.Text = UiText.MainpurchaseOrderToolStripMenuItem;
            newPurchaseVoucherToolStripMenuItem.Text = UiText.MainnewPurchaseVoucherToolStripMenuItem;
            listVouchersToolStripMenuItem.Text = UiText.MainlistVouchersToolStripMenuItem;
            EmpControl.Text = UiText.MainEmpControl;
            addNewVendorToolStripMenuItem.Text = UiText.MainaddNewVendorToolStripMenuItem;
            listVendorsToolStripMenuItem.Text = UiText.MainlistVendorsToolStripMenuItem;
            vendorsDebitCreditToolStripMenuItem.Text = UiText.MainvendorsDebitCreditToolStripMenuItem;
            addVendorPaymentToolStripMenuItem.Text = UiText.MainaddVendorPaymentToolStripMenuItem;
            customersToolStripMenuItem.Text = UiText.MaincustomersToolStripMenuItem;
            addNewCustomerToolStripMenuItem.Text = UiText.MainaddNewCustomerToolStripMenuItem;
            editCustomerToolStripMenuItem.Text = UiText.MaineditCustomerToolStripMenuItem;
            listCustomersToolStripMenuItem.Text = UiText.MainlistCustomersToolStripMenuItem;
            addCustomerPaymentToolStripMenuItem.Text = UiText.MainaddCustomerPaymentToolStripMenuItem;
            customerDebitCreditToolStripMenuItem.Text = UiText.MaincustomerDebitCreditToolStripMenuItem;
            toolsToolStripMenuItem.Text = UiText.MaintoolsToolStripMenuItem;
            usersAndPriviligesToolStripMenuItem.Text = UiText.MainusersAndPriviligesToolStripMenuItem;
            editUsersToolStripMenuItem.Text = UiText.MaineditUsersToolStripMenuItem;
            addNewUserToolStripMenuItem.Text = UiText.MainaddNewUserToolStripMenuItem;
            printingSettingsToolStripMenuItem.Text = UiText.MainprintingSettingsToolStripMenuItem;
            loginToolStripMenuItem.Text = UiText.MainloginToolStripMenuItem;
            tempLoginToolStripMenuItem.Text = UiText.MaintempLoginToolStripMenuItem;
            logoutTempToolStripMenuItem.Text = UiText.MainlogoutTempToolStripMenuItem;
            windowsToolStripMenuItem.Text = UiText.MainwindowsToolStripMenuItem;
            windowsExplorerToolStripMenuItem.Text = UiText.MainwindowsExplorerToolStripMenuItem;
            cascadeToolStripMenuItem.Text = UiText.MaincascadeToolStripMenuItem;
            titleVerticalToolStripMenuItem.Text = UiText.MaintitleVerticalToolStripMenuItem;
            titleHotizontalToolStripMenuItem.Text = UiText.MaintitleHotizontalToolStripMenuItem;
            HomeToolStripMenuItem.Text = UiText.MainHomeToolStripMenuItem;
            arrangeIconsToolStripMenuItem.Text = UiText.MainarrangeIconsToolStripMenuItem;
            closeAllToolStripMenuItem1.Text = UiText.MaincloseAllToolStripMenuItem1;
            logoutToolStripMenuItem.Text = UiText.MainlogoutToolStripMenuItem;
            exitToWindowsToolStripMenuItem.Text = UiText.MainexitToWindowsToolStripMenuItem;
            Title.Text = UiText.MainTitle;
            LogOutLabel.Text = UiText.MainLogOutLabel;
            UserLoggedTxt.Text = UiText.MainUserLoggedTxt;



        }
    }
}
