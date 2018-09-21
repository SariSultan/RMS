namespace Calcium_RMS
{
    partial class MainDock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.POSGB = new System.Windows.Forms.GroupBox();
            this.ListBillsLbl = new System.Windows.Forms.Label();
            this.MakeSaleLbl = new System.Windows.Forms.Label();
            this.ListBillsBtn = new System.Windows.Forms.Button();
            this.MakeASaleBtn = new System.Windows.Forms.Button();
            this.InventoryGB = new System.Windows.Forms.GroupBox();
            this.ListItemsLbl = new System.Windows.Forms.Label();
            this.AddNewITemLbl = new System.Windows.Forms.Label();
            this.AddNewItemBtn = new System.Windows.Forms.Button();
            this.ListItemsBtn = new System.Windows.Forms.Button();
            this.CustomersGB = new System.Windows.Forms.GroupBox();
            this.ListCustomersBtn = new System.Windows.Forms.Button();
            this.EditCustomersLbl = new System.Windows.Forms.Label();
            this.ListCustomersLbl = new System.Windows.Forms.Label();
            this.AddCustomerLbl = new System.Windows.Forms.Label();
            this.EditCustomerBtn = new System.Windows.Forms.Button();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.VendorsGB = new System.Windows.Forms.GroupBox();
            this.ListVendorsBtn = new System.Windows.Forms.Button();
            this.AddVendorPaymentBtn = new System.Windows.Forms.Button();
            this.AddVendorBtn = new System.Windows.Forms.Button();
            this.AddVendorPaymentLbl = new System.Windows.Forms.Label();
            this.ListVendorsLbl = new System.Windows.Forms.Label();
            this.AddVendorLbl = new System.Windows.Forms.Label();
            this.ReportsGB = new System.Windows.Forms.GroupBox();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.ReportsLbl = new System.Windows.Forms.Label();
            this.POSGB.SuspendLayout();
            this.InventoryGB.SuspendLayout();
            this.CustomersGB.SuspendLayout();
            this.VendorsGB.SuspendLayout();
            this.ReportsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // POSGB
            // 
            this.POSGB.BackColor = System.Drawing.Color.White;
            this.POSGB.Controls.Add(this.ListBillsLbl);
            this.POSGB.Controls.Add(this.MakeSaleLbl);
            this.POSGB.Controls.Add(this.ListBillsBtn);
            this.POSGB.Controls.Add(this.MakeASaleBtn);
            this.POSGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.POSGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.POSGB.Location = new System.Drawing.Point(200, 18);
            this.POSGB.Name = "POSGB";
            this.POSGB.Size = new System.Drawing.Size(294, 180);
            this.POSGB.TabIndex = 0;
            this.POSGB.TabStop = false;
            this.POSGB.Text = "Point Of Sale";
            // 
            // ListBillsLbl
            // 
            this.ListBillsLbl.AutoSize = true;
            this.ListBillsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBillsLbl.Location = new System.Drawing.Point(163, 147);
            this.ListBillsLbl.Name = "ListBillsLbl";
            this.ListBillsLbl.Size = new System.Drawing.Size(92, 17);
            this.ListBillsLbl.TabIndex = 2;
            this.ListBillsLbl.Text = "Touch Screen";
            // 
            // MakeSaleLbl
            // 
            this.MakeSaleLbl.AutoSize = true;
            this.MakeSaleLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeSaleLbl.Location = new System.Drawing.Point(61, 147);
            this.MakeSaleLbl.Name = "MakeSaleLbl";
            this.MakeSaleLbl.Size = new System.Drawing.Size(45, 17);
            this.MakeSaleLbl.TabIndex = 2;
            this.MakeSaleLbl.Text = "P.O.S.";
            // 
            // ListBillsBtn
            // 
            this.ListBillsBtn.BackColor = System.Drawing.Color.Lavender;
            this.ListBillsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.TOUCH_SCREEN_ICON;
            this.ListBillsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListBillsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListBillsBtn.FlatAppearance.BorderSize = 0;
            this.ListBillsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListBillsBtn.Location = new System.Drawing.Point(160, 36);
            this.ListBillsBtn.Name = "ListBillsBtn";
            this.ListBillsBtn.Size = new System.Drawing.Size(100, 100);
            this.ListBillsBtn.TabIndex = 1;
            this.ListBillsBtn.UseVisualStyleBackColor = false;
            this.ListBillsBtn.Click += new System.EventHandler(this.ListBillsBtn_Click);
            // 
            // MakeASaleBtn
            // 
            this.MakeASaleBtn.BackColor = System.Drawing.Color.Lavender;
            this.MakeASaleBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.POS_ICON;
            this.MakeASaleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MakeASaleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeASaleBtn.FlatAppearance.BorderSize = 0;
            this.MakeASaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MakeASaleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MakeASaleBtn.Location = new System.Drawing.Point(33, 36);
            this.MakeASaleBtn.Name = "MakeASaleBtn";
            this.MakeASaleBtn.Size = new System.Drawing.Size(100, 100);
            this.MakeASaleBtn.TabIndex = 0;
            this.MakeASaleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MakeASaleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MakeASaleBtn.UseVisualStyleBackColor = false;
            this.MakeASaleBtn.Click += new System.EventHandler(this.MakeASaleBtn_Click);
            // 
            // InventoryGB
            // 
            this.InventoryGB.BackColor = System.Drawing.Color.White;
            this.InventoryGB.Controls.Add(this.ListItemsLbl);
            this.InventoryGB.Controls.Add(this.AddNewITemLbl);
            this.InventoryGB.Controls.Add(this.AddNewItemBtn);
            this.InventoryGB.Controls.Add(this.ListItemsBtn);
            this.InventoryGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.InventoryGB.Location = new System.Drawing.Point(453, 204);
            this.InventoryGB.Name = "InventoryGB";
            this.InventoryGB.Size = new System.Drawing.Size(294, 180);
            this.InventoryGB.TabIndex = 0;
            this.InventoryGB.TabStop = false;
            this.InventoryGB.Text = "Inventory";
            // 
            // ListItemsLbl
            // 
            this.ListItemsLbl.AutoSize = true;
            this.ListItemsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ListItemsLbl.Location = new System.Drawing.Point(163, 147);
            this.ListItemsLbl.Name = "ListItemsLbl";
            this.ListItemsLbl.Size = new System.Drawing.Size(95, 17);
            this.ListItemsLbl.TabIndex = 2;
            this.ListItemsLbl.Text = "Dispose Items";
            // 
            // AddNewITemLbl
            // 
            this.AddNewITemLbl.AutoSize = true;
            this.AddNewITemLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewITemLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.AddNewITemLbl.Location = new System.Drawing.Point(32, 147);
            this.AddNewITemLbl.Name = "AddNewITemLbl";
            this.AddNewITemLbl.Size = new System.Drawing.Size(102, 17);
            this.AddNewITemLbl.TabIndex = 2;
            this.AddNewITemLbl.Text = "Add New Item";
            // 
            // AddNewItemBtn
            // 
            this.AddNewItemBtn.BackColor = System.Drawing.Color.Linen;
            this.AddNewItemBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.ADD_ITEMS_ICON;
            this.AddNewItemBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewItemBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewItemBtn.FlatAppearance.BorderSize = 0;
            this.AddNewItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewItemBtn.Location = new System.Drawing.Point(33, 36);
            this.AddNewItemBtn.Name = "AddNewItemBtn";
            this.AddNewItemBtn.Size = new System.Drawing.Size(100, 100);
            this.AddNewItemBtn.TabIndex = 0;
            this.AddNewItemBtn.UseVisualStyleBackColor = false;
            this.AddNewItemBtn.Click += new System.EventHandler(this.AddNewItemBtn_Click);
            // 
            // ListItemsBtn
            // 
            this.ListItemsBtn.BackColor = System.Drawing.Color.Linen;
            this.ListItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.DISPOSE;
            this.ListItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListItemsBtn.FlatAppearance.BorderSize = 0;
            this.ListItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListItemsBtn.Location = new System.Drawing.Point(160, 36);
            this.ListItemsBtn.Name = "ListItemsBtn";
            this.ListItemsBtn.Size = new System.Drawing.Size(100, 100);
            this.ListItemsBtn.TabIndex = 1;
            this.ListItemsBtn.UseVisualStyleBackColor = false;
            this.ListItemsBtn.Click += new System.EventHandler(this.ListItems_Click);
            // 
            // CustomersGB
            // 
            this.CustomersGB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomersGB.Controls.Add(this.ListCustomersBtn);
            this.CustomersGB.Controls.Add(this.EditCustomersLbl);
            this.CustomersGB.Controls.Add(this.ListCustomersLbl);
            this.CustomersGB.Controls.Add(this.AddCustomerLbl);
            this.CustomersGB.Controls.Add(this.EditCustomerBtn);
            this.CustomersGB.Controls.Add(this.AddCustomerBtn);
            this.CustomersGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomersGB.Location = new System.Drawing.Point(17, 204);
            this.CustomersGB.Name = "CustomersGB";
            this.CustomersGB.Size = new System.Drawing.Size(423, 180);
            this.CustomersGB.TabIndex = 0;
            this.CustomersGB.TabStop = false;
            this.CustomersGB.Text = "Customers";
            // 
            // ListCustomersBtn
            // 
            this.ListCustomersBtn.BackColor = System.Drawing.Color.LightBlue;
            this.ListCustomersBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.ADD_CUSTOMER_PAYMENT_ICON;
            this.ListCustomersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListCustomersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListCustomersBtn.FlatAppearance.BorderSize = 0;
            this.ListCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListCustomersBtn.Location = new System.Drawing.Point(160, 36);
            this.ListCustomersBtn.Name = "ListCustomersBtn";
            this.ListCustomersBtn.Size = new System.Drawing.Size(100, 100);
            this.ListCustomersBtn.TabIndex = 2;
            this.ListCustomersBtn.UseVisualStyleBackColor = false;
            this.ListCustomersBtn.Click += new System.EventHandler(this.ListCustomersBtn_Click);
            // 
            // EditCustomersLbl
            // 
            this.EditCustomersLbl.AutoSize = true;
            this.EditCustomersLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.EditCustomersLbl.Location = new System.Drawing.Point(277, 138);
            this.EditCustomersLbl.Name = "EditCustomersLbl";
            this.EditCustomersLbl.Size = new System.Drawing.Size(116, 34);
            this.EditCustomersLbl.TabIndex = 2;
            this.EditCustomersLbl.Text = "Return Customer\r\nItems";
            this.EditCustomersLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListCustomersLbl
            // 
            this.ListCustomersLbl.AutoSize = true;
            this.ListCustomersLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ListCustomersLbl.Location = new System.Drawing.Point(159, 138);
            this.ListCustomersLbl.Name = "ListCustomersLbl";
            this.ListCustomersLbl.Size = new System.Drawing.Size(102, 34);
            this.ListCustomersLbl.TabIndex = 2;
            this.ListCustomersLbl.Text = "Add Customer\r\nPayment";
            this.ListCustomersLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCustomerLbl
            // 
            this.AddCustomerLbl.AutoSize = true;
            this.AddCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddCustomerLbl.Location = new System.Drawing.Point(48, 138);
            this.AddCustomerLbl.Name = "AddCustomerLbl";
            this.AddCustomerLbl.Size = new System.Drawing.Size(71, 34);
            this.AddCustomerLbl.TabIndex = 2;
            this.AddCustomerLbl.Text = "Add New\r\nCustomer";
            this.AddCustomerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditCustomerBtn
            // 
            this.EditCustomerBtn.BackColor = System.Drawing.Color.LightBlue;
            this.EditCustomerBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.RETURN_CUSTOMER_ITEM;
            this.EditCustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditCustomerBtn.FlatAppearance.BorderSize = 0;
            this.EditCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomerBtn.Location = new System.Drawing.Point(285, 36);
            this.EditCustomerBtn.Name = "EditCustomerBtn";
            this.EditCustomerBtn.Size = new System.Drawing.Size(100, 100);
            this.EditCustomerBtn.TabIndex = 1;
            this.EditCustomerBtn.UseVisualStyleBackColor = false;
            this.EditCustomerBtn.Click += new System.EventHandler(this.EditCustomerBtn_Click);
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.BackColor = System.Drawing.Color.LightBlue;
            this.AddCustomerBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.ADD_CUSTOMER_ICON;
            this.AddCustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCustomerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCustomerBtn.FlatAppearance.BorderSize = 0;
            this.AddCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerBtn.Location = new System.Drawing.Point(33, 36);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(100, 100);
            this.AddCustomerBtn.TabIndex = 0;
            this.AddCustomerBtn.UseVisualStyleBackColor = false;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // VendorsGB
            // 
            this.VendorsGB.BackColor = System.Drawing.Color.White;
            this.VendorsGB.Controls.Add(this.ListVendorsBtn);
            this.VendorsGB.Controls.Add(this.AddVendorPaymentBtn);
            this.VendorsGB.Controls.Add(this.AddVendorBtn);
            this.VendorsGB.Controls.Add(this.AddVendorPaymentLbl);
            this.VendorsGB.Controls.Add(this.ListVendorsLbl);
            this.VendorsGB.Controls.Add(this.AddVendorLbl);
            this.VendorsGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.VendorsGB.Location = new System.Drawing.Point(324, 390);
            this.VendorsGB.Name = "VendorsGB";
            this.VendorsGB.Size = new System.Drawing.Size(423, 180);
            this.VendorsGB.TabIndex = 1;
            this.VendorsGB.TabStop = false;
            this.VendorsGB.Text = "Vendors";
            // 
            // ListVendorsBtn
            // 
            this.ListVendorsBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ListVendorsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.PAYMENT_ICON;
            this.ListVendorsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListVendorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListVendorsBtn.FlatAppearance.BorderSize = 0;
            this.ListVendorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListVendorsBtn.Location = new System.Drawing.Point(160, 36);
            this.ListVendorsBtn.Name = "ListVendorsBtn";
            this.ListVendorsBtn.Size = new System.Drawing.Size(100, 100);
            this.ListVendorsBtn.TabIndex = 1;
            this.ListVendorsBtn.UseVisualStyleBackColor = false;
            this.ListVendorsBtn.Click += new System.EventHandler(this.ListVendorsBtn_Click);
            // 
            // AddVendorPaymentBtn
            // 
            this.AddVendorPaymentBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddVendorPaymentBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Return;
            this.AddVendorPaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddVendorPaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVendorPaymentBtn.FlatAppearance.BorderSize = 0;
            this.AddVendorPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVendorPaymentBtn.Location = new System.Drawing.Point(285, 36);
            this.AddVendorPaymentBtn.Name = "AddVendorPaymentBtn";
            this.AddVendorPaymentBtn.Size = new System.Drawing.Size(100, 100);
            this.AddVendorPaymentBtn.TabIndex = 1;
            this.AddVendorPaymentBtn.UseVisualStyleBackColor = false;
            this.AddVendorPaymentBtn.Click += new System.EventHandler(this.AddVendorPaymentBtn_Click);
            // 
            // AddVendorBtn
            // 
            this.AddVendorBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AddVendorBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.VOUCHER_ICON;
            this.AddVendorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddVendorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVendorBtn.FlatAppearance.BorderSize = 0;
            this.AddVendorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVendorBtn.Location = new System.Drawing.Point(33, 36);
            this.AddVendorBtn.Name = "AddVendorBtn";
            this.AddVendorBtn.Size = new System.Drawing.Size(100, 100);
            this.AddVendorBtn.TabIndex = 1;
            this.AddVendorBtn.UseVisualStyleBackColor = false;
            this.AddVendorBtn.Click += new System.EventHandler(this.AddVendorBtn_Click);
            // 
            // AddVendorPaymentLbl
            // 
            this.AddVendorPaymentLbl.AutoSize = true;
            this.AddVendorPaymentLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVendorPaymentLbl.Location = new System.Drawing.Point(285, 139);
            this.AddVendorPaymentLbl.Name = "AddVendorPaymentLbl";
            this.AddVendorPaymentLbl.Size = new System.Drawing.Size(100, 34);
            this.AddVendorPaymentLbl.TabIndex = 2;
            this.AddVendorPaymentLbl.Text = "Return Vendor\r\n Items";
            this.AddVendorPaymentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListVendorsLbl
            // 
            this.ListVendorsLbl.AutoSize = true;
            this.ListVendorsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVendorsLbl.Location = new System.Drawing.Point(152, 139);
            this.ListVendorsLbl.Name = "ListVendorsLbl";
            this.ListVendorsLbl.Size = new System.Drawing.Size(116, 34);
            this.ListVendorsLbl.TabIndex = 2;
            this.ListVendorsLbl.Text = "Add New\r\nVendor Payment";
            this.ListVendorsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddVendorLbl
            // 
            this.AddVendorLbl.AutoSize = true;
            this.AddVendorLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddVendorLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVendorLbl.Location = new System.Drawing.Point(40, 138);
            this.AddVendorLbl.Name = "AddVendorLbl";
            this.AddVendorLbl.Size = new System.Drawing.Size(97, 34);
            this.AddVendorLbl.TabIndex = 2;
            this.AddVendorLbl.Text = "Add Purchase\r\nVoucher";
            this.AddVendorLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportsGB
            // 
            this.ReportsGB.BackColor = System.Drawing.Color.White;
            this.ReportsGB.Controls.Add(this.ReportsBtn);
            this.ReportsGB.Controls.Add(this.ReportsLbl);
            this.ReportsGB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(39)))), ((int)(((byte)(156)))));
            this.ReportsGB.Location = new System.Drawing.Point(17, 390);
            this.ReportsGB.Name = "ReportsGB";
            this.ReportsGB.Size = new System.Drawing.Size(294, 180);
            this.ReportsGB.TabIndex = 3;
            this.ReportsGB.TabStop = false;
            this.ReportsGB.Text = "Reports";
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.Color.Linen;
            this.ReportsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.REPORT_ICON;
            this.ReportsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReportsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportsBtn.FlatAppearance.BorderSize = 0;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsBtn.Location = new System.Drawing.Point(96, 36);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(100, 100);
            this.ReportsBtn.TabIndex = 0;
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // ReportsLbl
            // 
            this.ReportsLbl.AutoSize = true;
            this.ReportsLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsLbl.Location = new System.Drawing.Point(120, 152);
            this.ReportsLbl.Name = "ReportsLbl";
            this.ReportsLbl.Size = new System.Drawing.Size(52, 16);
            this.ReportsLbl.TabIndex = 2;
            this.ReportsLbl.Text = "Reports";
            // 
            // MainDock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
           // this.BackgroundImage = global::Calcium_RMS.Properties.Resources.MAIN_Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 627);
            this.Controls.Add(this.ReportsGB);
            this.Controls.Add(this.VendorsGB);
            this.Controls.Add(this.InventoryGB);
            this.Controls.Add(this.POSGB);
            this.Controls.Add(this.CustomersGB);
            this.Name = "MainDock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.POSGB.ResumeLayout(false);
            this.POSGB.PerformLayout();
            this.InventoryGB.ResumeLayout(false);
            this.InventoryGB.PerformLayout();
            this.CustomersGB.ResumeLayout(false);
            this.CustomersGB.PerformLayout();
            this.VendorsGB.ResumeLayout(false);
            this.VendorsGB.PerformLayout();
            this.ReportsGB.ResumeLayout(false);
            this.ReportsGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox POSGB;
        private System.Windows.Forms.Button ListBillsBtn;
        private System.Windows.Forms.GroupBox InventoryGB;
        private System.Windows.Forms.GroupBox CustomersGB;
        private System.Windows.Forms.Button ListItemsBtn;
        private System.Windows.Forms.Button AddNewItemBtn;
        private System.Windows.Forms.Button ListCustomersBtn;
        private System.Windows.Forms.Button EditCustomerBtn;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.GroupBox VendorsGB;
        private System.Windows.Forms.Button AddVendorBtn;
        private System.Windows.Forms.Button ListVendorsBtn;
        private System.Windows.Forms.Button MakeASaleBtn;
        private System.Windows.Forms.Label ListBillsLbl;
        private System.Windows.Forms.Label MakeSaleLbl;
        private System.Windows.Forms.Label EditCustomersLbl;
        private System.Windows.Forms.Label ListCustomersLbl;
        private System.Windows.Forms.Label AddCustomerLbl;
        private System.Windows.Forms.Label AddVendorLbl;
        private System.Windows.Forms.Label ListVendorsLbl;
        private System.Windows.Forms.Label ListItemsLbl;
        private System.Windows.Forms.Label AddNewITemLbl;
        private System.Windows.Forms.Button AddVendorPaymentBtn;
        private System.Windows.Forms.Label AddVendorPaymentLbl;
        private System.Windows.Forms.GroupBox ReportsGB;
        private System.Windows.Forms.Button ReportsBtn;
        private System.Windows.Forms.Label ReportsLbl;
    }
}