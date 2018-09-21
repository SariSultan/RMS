using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Text;
using Calcium_RMS.Security;
using System.Drawing.Drawing2D;

namespace Calcium_RMS
{
    public partial class Main2 : RibbonForm
    {
        private bool semaphore = false;

        private bool MANUAL_MINIMIZE=false;

        #region TAB COLORS
        Color __POSColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(170)))));
        Color __InventoryColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(72)))), ((int)(((byte)(59)))));
        Color __PurchaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(16)))), ((int)(((byte)(148)))));
        Color __VendorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(102)))), ((int)(((byte)(63)))));
        Color __CustomersColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
        Color __ToolsColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(205)))), ((int)(((byte)(9)))));
        Color __LoginColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(208)))), ((int)(((byte)(9)))));
        Color __ReportsColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(205)))), ((int)(((byte)(9)))));

        #endregion TAB COLORS
        #region BOOTING FORM
        public Main2()
        {
            InitializeComponent();
            TranslateUI();

            aTabControl.MouseClick += new MouseEventHandler(TabControl_MouseClick);
            aTabControl.DoubleClick += new EventHandler(TabControl_MouseDoubleClick);
            ribbon1.Resize += new EventHandler(Ribbon_Resize);
            ribbon1.MouseDown += new MouseEventHandler(OnMouseDown);
            //   Helper.Instance.SetMainWindow(this);
            this.WindowState = FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main2_FormClosing);
            BackgroundTimer.Start();
        }

        private void Main2_Load(object sender, EventArgs e)
        {
            ribbon1.RightToLeft = FlowDirectionManager.GetFlowDirection();
            this.RightToLeft = ribbon1.RightToLeft;
            this.RightToLeftLayout = true;
            if (SharedVariables.is_user_logged)
            {
                LoggedUsrTxtLbl.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
                LogoutBtn.Visible = true;
            }

        }

        #endregion

        #region EVENTS HANDLERS
        private void TabControl_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var tabControl = sender as TabControl;
                var tabs = tabControl.TabPages;
                if (e.Button == MouseButtons.Middle)
                {
                    //tabs.Remove(tabs.Cast<TabPage>()
                    //        .Where((t, i) => tabControl.GetTabRect(i).Contains(e.Location))
                    //        .First()
                    //        );

                    TabPage aTabPage = tabs.Cast<TabPage>()
                           .Where((t, i) => tabControl.GetTabRect(i).Contains(e.Location))
                            .First();
                    if (aTabPage != null)
                    {
                        foreach (Control acontrol in aTabPage.Controls)
                        {
                            if (acontrol is Form)
                            {
                                (acontrol as Form).Close();
                            }
                        }
                        // aTabControl.TabPages.Remove(aTabControl.SelectedTab);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[TabControl_MouseClick] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void TabControl_MouseDoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (aTabControl.SelectedTab != null)
                {
                    foreach (Control acontrol in aTabControl.SelectedTab.Controls)
                    {
                        if (acontrol is Form)
                        {
                            (acontrol as Form).Close();
                        }
                    }
                    // aTabControl.TabPages.Remove(aTabControl.SelectedTab);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[TabControl_MouseDoubleClick] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
            }

        }
        private void Ribbon_Resize(object sender, EventArgs e)
        {
            if (!semaphore)
            {
                semaphore = true;
                MaximizeTPTimer.Start();
                semaphore = false;
            }
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Location.Y <= (20) && e.Location.X > 50 && e.Location.X < (this.Width - 150))
                {
                    this.Cursor = Cursors.SizeAll;
                    ControlHelper.MoveBorderless(this, e);
                    base.OnMouseDown(e);
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[OnMouseDown] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TabPage_MouseDoubleClick(object sender, EventArgs e)
        {
            try
            {
                TabPage atp = sender as TabPage;
                atp.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[TabPage_MouseDoubleClick] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void childForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Close Parent Tab
                Form aChildForm = sender as Form;
                aChildForm.Parent.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[childForm_FormClosing] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region UI CONTROLS METHODS
        private void MaximizeTPTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (aTabControl.SelectedTab == null)
                {
                    return;
                }
                foreach (Control aForm in aTabControl.SelectedTab.Controls)
                {
                    if (aForm is Form)
                    {

                        this.SuspendLayout();
                        ControlHelper.SuspendDrawing(this);
                        Form form = aForm as Form;
                        form.Dock = DockStyle.Fill;
                        form.Width = ((TabPage)form.Parent).ClientSize.Width;
                        form.Height = ((TabPage)form.Parent).ClientSize.Height;
                        form.WindowState = FormWindowState.Minimized;
                        while (true)
                        {
                            if (form.WindowState != FormWindowState.Maximized)
                            {
                                form.WindowState = FormWindowState.Maximized;
                            }
                            else
                            {
                                break;
                            }
                        }
                        ControlHelper.ResumeDrawing(this);
                        this.ResumeDrawing();
                        this.ResumeLayout();
                        //form.WindowState = FormWindowState.Maximized;
                    }
                }
                //foreach (TabPage atp in aTabControl.TabPages)
                //{
                //    foreach (Control acontrol in atp.Controls)
                //    {
                //        // acontrol.Dock = DockStyle.Fill;
                //        // acontrol.Refresh();
                //        if (acontrol is Form)
                //        {
                //            Form form = acontrol as Form;

                //            form.WindowState = FormWindowState.Normal;
                //            form.Width = ((TabPage)form.Parent).ClientSize.Width;
                //            form.Height = ((TabPage)form.Parent).ClientSize.Height;
                //            while (true)
                //            {
                //                if (form.WindowState != FormWindowState.Maximized)
                //                {
                //                    form.WindowState = FormWindowState.Maximized;
                //                    form.Refresh();
                //                }
                //                else
                //                {
                //                    break;
                //                }
                //            }
                //            //form.WindowState = FormWindowState.Maximized;
                //        }
                //    }
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[MaximizeTPTimer_Tick] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { MaximizeTPTimer.Stop(); }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }


        private void Main2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {

            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                Application.ExitThread();
                Application.Exit();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR ONCLOSED" + ex.Message);
            }
        }
        private void MaxMinBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void __AddTabPage(Form aForm, Color aColor)
        {
            try
            {
                pictureBox1.Hide();
                Font __fonttemp = aForm.Font;
                Color __backcolortemp = aForm.BackColor;
                Color __forcecolortemp = aForm.ForeColor;
                aForm.Activate();
                aForm.Visible = false;
                aForm.WindowState = FormWindowState.Maximized;
                aForm.FormBorderStyle = FormBorderStyle.None;
                aForm.FormClosing += new FormClosingEventHandler(childForm_FormClosing);
                //TopLevel for form is set to false
                aForm.TopLevel = false;
                //Added new TabPage
                TabPage tbp = new TabPage();
                tbp.MouseDoubleClick += new MouseEventHandler(TabControl_MouseDoubleClick);
                tbp.Text = aForm.Text;
                tbp.Text += "            ";
                tbp.BackColor = aColor;
                // tbp.ImageIndex = 0;              
                tbp.AutoScroll = true;
                aTabControl.TabPages.Add(tbp);
                aTabControl.Font = new Font("Tahoma", 12, FontStyle.Bold);

                tbp.ForeColor = Color.White;
                tbp.Controls.Add(aForm);
                aTabControl.SelectedTab = tbp;

                //Added form to tabpage
                aForm.WindowState = FormWindowState.Maximized;
                aForm.Font = __fonttemp;
                aForm.ForeColor = __forcecolortemp;
                aForm.BackColor = __backcolortemp;
                aForm.Activate();
                aForm.Visible = true;
                if (!MANUAL_MINIMIZE)
                {
                    ribbon1.Minimized = true; 
                }
            }
            catch (Exception ex)
            {
                aTabControl.TabPages.Remove(aTabControl.SelectedTab);
                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[AddTabPage] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        #region RIBBON BUTTONS FUNCTIONS
        #region POS TAB BUTTONS FUNCTIONS
        private void MakeSaleRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.POS) == EventStatus.Permit)
            {
                POS aPos = new POS();
                __AddTabPage(aPos, __POSColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ListBillsRibnBtn_Click(object sender, EventArgs e)
        {

            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListBills) == EventStatus.Permit)
            {
                ListBills aListBills = new ListBills();
                __AddTabPage(aListBills, __POSColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TouchScreenRibnBtn_Click(object sender, EventArgs e)
        {

            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.TouchScreen) == EventStatus.Permit)
            {
                TouchScreenFrm aTouchScreen = new TouchScreenFrm();
                __AddTabPage(aTouchScreen, __POSColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void EditBillRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditBills) == EventStatus.Permit)
            {
                ChooseBillToEdit aChooseBillToEdit = new ChooseBillToEdit();
                __AddTabPage(aChooseBillToEdit, __POSColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void EditTouchScreenRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditTouchScreenItems) == EventStatus.Permit)
            {
                EditTouchScreenItems aEditTouchScreenItems = new EditTouchScreenItems();
                __AddTabPage(aEditTouchScreenItems, __POSColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region INVENTORY TAB BUTTONS FUNCTIONS
        private void AddNewItemRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddNewItem) == EventStatus.Permit)
            {
                AddNewItem aAddNewItem = new AddNewItem();
                __AddTabPage(aAddNewItem, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ListItemsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListItems) == EventStatus.Permit)
            {
                ListItems aListItems = new ListItems();
                __AddTabPage(aListItems, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void DisposeItemsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.DisposeItems) == EventStatus.Permit)
            {
                DisposeItems aDisposeItems = new DisposeItems();
                __AddTabPage(aDisposeItems, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void AccountsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditAccounts) == EventStatus.Permit)
            {
                AccountsFrm aAccountsFrm = new AccountsFrm();
                __AddTabPage(aAccountsFrm, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void WeightSettingsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.WeightEditing) == EventStatus.Permit)
            {
                WeightConfig aWeightConfig = new WeightConfig();
                __AddTabPage(aWeightConfig, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditInventory_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditItems) == EventStatus.Permit)
            {
                EditItems aEditItems = new EditItems();
                __AddTabPage(aEditItems, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void AdjustInvRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AdjustItems) == EventStatus.Permit)
            {
                AdjustItemsFrm aAdjustItemsFrm = new AdjustItemsFrm();
                __AddTabPage(aAdjustItemsFrm, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ListAdjItemsRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListAdjustItems) == EventStatus.Permit)
            {
                ListAdjustItemsFrm aListAdjustItems = new ListAdjustItemsFrm();
                __AddTabPage(aListAdjustItems, __InventoryColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region PURCHASE TAB BUTTONS FUNCTIONS
        private void NewPurchaseVoucherRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.PurchaseVoucher) == EventStatus.Permit)
            {
                PurchaseVoucher aPurchaseVoucher = new PurchaseVoucher();
                __AddTabPage(aPurchaseVoucher, __PurchaseColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ListVouchersRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListVouchers) == EventStatus.Permit)
            {
                ListVouchers aListVouchers = new ListVouchers();
                __AddTabPage(aListVouchers, __PurchaseColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region VENDORS
        private void AddNewVendorRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddVendor) == EventStatus.Permit)
            {
                AddVendor aAddVendor = new AddVendor();
                __AddTabPage(aAddVendor, __VendorsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void AddVendorPaymentRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddVendorPayment) == EventStatus.Permit)
            {
                AddVendorPayment aAddVendorPayment = new AddVendorPayment();
                __AddTabPage(aAddVendorPayment, __VendorsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ListVendorsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListVendors) == EventStatus.Permit)
            {
                ListVendors aListVendor = new ListVendors();
                __AddTabPage(aListVendor, __VendorsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void VendorDebitCreditRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.VendorDebitCredit) == EventStatus.Permit)
            {
                VendorsDebitCredit aVendorDebitCredit = new VendorsDebitCredit();
                __AddTabPage(aVendorDebitCredit, __VendorsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region CUSTOMERS
        private void AddNewCustomerRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddCustomer) == EventStatus.Permit)
            {
                AddCustomer aAddCustomer = new AddCustomer();
                __AddTabPage(aAddCustomer, __CustomersColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void ListCustomersRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListCustomers) == EventStatus.Permit)
            {
                ListCustomers aListCustomers = new ListCustomers();
                __AddTabPage(aListCustomers, __CustomersColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddCustomerPaymentRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddCustomerPayment) == EventStatus.Permit)
            {
                AddCustomerPayment aAddCustomerPayment = new AddCustomerPayment();
                __AddTabPage(aAddCustomerPayment, __CustomersColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditCustomersRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditCustomers) == EventStatus.Permit)
            {
                EditCustomer aEditCustomer = new EditCustomer();
                __AddTabPage(aEditCustomer, __CustomersColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void CustDebitCreditRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.CustomerDebitCredit) == EventStatus.Permit)
            {
                CustomerDebitCredit aCustDebitCredit = new CustomerDebitCredit();
                __AddTabPage(aCustDebitCredit, __CustomersColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        #region TOOLS
        private void AddNewUserRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.AddNewUser) == EventStatus.Permit)
            {
                AddNewUser aAddNewUser = new AddNewUser();
                __AddTabPage(aAddNewUser, __ToolsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PrintingSettingsRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.PrintingSettings) == EventStatus.Permit)
            {
                PrintingSettingsFrm aPrintingSettingsFrm = new PrintingSettingsFrm();
                __AddTabPage(aPrintingSettingsFrm, __ToolsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditUsersRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.EditUsers) == EventStatus.Permit)
            {
                EditUser aEditUser = new EditUser();
                __AddTabPage(aEditUser, __ToolsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ListUsersRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.ListUsers) == EventStatus.Permit)
            {
                ListUsers aListUsers = new ListUsers();
                __AddTabPage(aListUsers, __ToolsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void DatabaseRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.DataBaseSettings) == EventStatus.Permit)
            {
                BackupManager.BackupFrm aBackupFrm = new BackupManager.BackupFrm();
                aBackupFrm.Show();
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConnStringRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.DataBaseSettings) == EventStatus.Permit)
            {
                ConnStringFrm aConnStringFrm = new ConnStringFrm();
                __AddTabPage(aConnStringFrm, __ToolsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        #region LOGIN
        private void TempLoginRibnBtn_Click(object sender, EventArgs e)
        {
            if (!PrivilegesManager.IsTempActive)
            {
                login logingWin = new login();
                logingWin.ShowDialog();
            }
            else
            {
                MessageBox.Show(MsgTxt.AlreadyTempUserTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            if (PrivilegesManager.IsTempActive)
            {
                LoggedUsrTxtLbl.Text = SharedVariables.temp_logged_name + ": " + SharedVariables.temp_logged_name_name;
                // LogotTemp.Visible = true;
                TempLogoutRibnBtn.Visible = true;
            }
            else
            {
                TempLogoutRibnBtn.Visible = false;
            }
        }
        private void TempLogoutRibnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.IsTempActive)
            {
                PrivilegesManager.IsTempActive = false;
                TempLogoutRibnBtn.Visible = false;
                PrivilegesManager.ClearTempTemplate();
                LoggedUsrTxtLbl.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
            }
        }
        #endregion

        #region REPORTS
        private void ReportsRbnBtn_Click(object sender, EventArgs e)
        {
            if (PrivilegesManager.GetEventStatues(Calcium_RMS.Events.Reports) == EventStatus.Permit)
            {
                ReportsFrm aReportsFrm = new ReportsFrm();
                __AddTabPage(aReportsFrm, __ReportsColor);
            }
            else
            {
                MessageBox.Show(MsgTxt.PrivUserNotAllowedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion



        #endregion

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("هل انت متأكد , سيتم اغلاق جميع المعاملات بدون حفط تلقائي؟", "تسجيل الخروج".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                SharedVariables.is_user_logged = false;
                LoggedUsrTxtLbl.Text = "Not Logged In";
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
        private void LoginAgainAfterLogout()
        {
            //Helper.Instance.ActiveLoginWindow.IsFirstLogin = true;
            SharedVariables.IsStartup = true;
            //Helper.Instance.ActiveLoginWindow.Show();
            this.Close();
            Application.Restart();

            //login login_form = new login();
            //login_form.IsFirstLogin = true;
            //login_form.Show();
            //Application.Restart();
            //if (SharedVariables.is_user_logged)
            //{
            //    LoggedUsrTxtLbl.Text = SharedVariables.user_logged_name + ": " + SharedVariables.user_logged_name_name;
            //    LogoutBtn.Visible = true;
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }

        private void ActivationRbnBtn_Click(object sender, EventArgs e)
        {
            ActivationFrm aActivationFrm = new ActivationFrm();
            aActivationFrm.ShowDialog();
        }

        private void ExitSelectedTabBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aTabControl.SelectedTab != null)
                {
                    foreach (Control acontrol in aTabControl.SelectedTab.Controls)
                    {
                        if (acontrol is Form)
                        {
                            (acontrol as Form).Close();
                        }
                    }
                    // aTabControl.TabPages.Remove(aTabControl.SelectedTab);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + " IN Main2[ExitSelectedTabBtn_Click] Exception " + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                // throw;
            }
        }

        private void CollapseRibbonBtn_Click(object sender, EventArgs e)
        {
            ribbon1.Minimized = !ribbon1.Minimized;
            MANUAL_MINIMIZE = !MANUAL_MINIMIZE;
        }

        private void LangComboBox_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            ConfigurationHelper.UpdateLanguage(e.Item.Text);
            string LangCheck = ConfigurationHelper.GetLanguage();
            if (!LangCheck.Contains("ERROR"))
            {
                if (LangCheck.ToUpper() == "ARABIC")
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-JO");
                    this.ribbon1.RightToLeft = RightToLeft.Yes;
                    this.RightToLeft = RightToLeft.Yes;
                }
                else
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    this.ribbon1.RightToLeft = RightToLeft.No;
                    this.RightToLeft = RightToLeft.No;
                }
            }

            UiText.TranslateUiText();
            MsgTxt.TranslateMsgsTxt();
            FormsNames.TranslateFormsNames();
            TranslateUI();
            this.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Testing aTest = new Testing();
            aTest.Show();
        }

        private void aTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!semaphore)
            {
                semaphore = true;
                MaximizeTPTimer.Start();
                semaphore = false;
            }
        }

        private void ExitToWindowsRibnBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoutRibnBtn_Click(object sender, EventArgs e)
        {
            LogoutBtn.PerformClick();
        }


        private void TranslateUI()
        {
            POSTAB.Text = UiText.MnFrmPOSTAB;
            MakeSaleRibnBtn.Text = UiText.MnFrmMakeSaleRibnBtn;
            ListBillsRibnBtn.Text = UiText.MnFrmListBillsRibnBtn;
            TouchScreenRibnBtn.Text = UiText.MnFrmTouchScreenRibnBtn;
            EditBillRibnBtn.Text = UiText.MnFrmEditBillRibnBtn;
            EditTouchScreenRibnBtn.Text = UiText.MnFrmEditTouchScreenRibnBtn;
            InventoryTAB.Text = UiText.MnFrmInventoryTAB;
            AddNewItemRibnBtn.Text = UiText.MnFrmAddNewItemRibnBtn;
            ListItemsRibnBtn.Text = UiText.MnFrmListItemsRibnBtn;
            DisposeItemsRibnBtn.Text = UiText.MnFrmDisposeItemsRibnBtn;
            AccountsRibnBtn.Text = UiText.MnFrmAccountsRibnBtn;
            WeightSettingsRibnBtn.Text = UiText.MnFrmWeightSettingsRibnBtn;
            EditInventory.Text = UiText.MnFrmEditInventory;
            PurchaseTAB.Text = UiText.MnFrmPurchaseTAB;
            NewPurchaseVoucherRbnBtn.Text = UiText.MnFrmNewPurchaseVoucherRbnBtn;
            ListVouchersRibnBtn.Text = UiText.MnFrmListVouchersRibnBtn;
            VendorsTAB.Text = UiText.MnFrmVendorsTAB;
            AddNewVendorRibnBtn.Text = UiText.MnFrmAddNewVendorRibnBtn;
            AddVendorPaymentRibnBtn.Text = UiText.MnFrmAddVendorPaymentRibnBtn;
            ListVendorsRibnBtn.Text = UiText.MnFrmListVendorsRibnBtn;
            VendorDebitCreditRbnBtn.Text = UiText.MnFrmVendorDebitCreditRbnBtn;
            CustomersTAB.Text = UiText.MnFrmCustomersTAB;
            AddNewCustomerRibnBtn.Text = UiText.MnFrmAddNewCustomerRibnBtn;
            ListCustomersRibnBtn.Text = UiText.MnFrmListCustomersRibnBtn;
            AddCustomerPaymentRibnBtn.Text = UiText.MnFrmAddCustomerPaymentRibnBtn;
            EditCustomersRibnBtn.Text = UiText.MnFrmEditCustomersRibnBtn;
            CustDebitCreditRbnBtn.Text = UiText.MnFrmCustDebitCreditRbnBtn;
            ToolsTAB.Text = UiText.MnFrmToolsTAB;
            AddNewUserRibnBtn.Text = UiText.MnFrmAddNewUserRibnBtn;
            PrintingSettingsRibnBtn.Text = UiText.MnFrmPrintingSettingsRibnBtn;
            ListUsersRbnBtn.Text = UiText.MnFrmListUsersRbnBtn;
            LangComboBox.Text = UiText.MnFrmLangComboBox;
            EditUsersRibnBtn.Text = UiText.MnFrmEditUsersRibnBtn;
            DatabaseRbnBtn.Text = UiText.MnFrmDatabaseRbnBtn;
            ConnStringRbnBtn.Text = UiText.MnFrmConnStringRbnBtn;
            LoginTAB.Text = UiText.MnFrmLoginTAB;
            TempLoginRibnBtn.Text = UiText.MnFrmTempLoginRibnBtn;
            ReportsTAB.Text = UiText.MnFrmReportsTAB;
            ReportsRbnBtn.Text = UiText.MnFrmReportsRbnBtn;
            GeneralPOS.Text = UiText.MnFrmGeneralPOS;
            EditPOS.Text = UiText.MnFrmEditPOS;
            GeneralInventory.Text = UiText.MnFrmGeneralInventory;
            EdtInventory.Text = UiText.MnFrmEdtInventory;
            GeneralPurchase.Text = UiText.MnFrmGeneralPurchase;
            GeneralVendors.Text = UiText.MnFrmGeneralVendors;
            EditVendorsTab.Text = UiText.MnFrmEditVendorsTab;


        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            AboutFrm aAboutFrm = new AboutFrm();
        
            aAboutFrm.ShowDialog();
        }


        protected override void OnResizeEnd(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.BringToFront();
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.TopMost = false;
            }
            base.OnResizeEnd(e);
        }

        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            if (aTabControl.TabCount == 0)
            {
                pictureBox1.Show();
            }

        }





    }
}
