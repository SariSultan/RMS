namespace Calcium_RMS
{
    partial class ListVouchers
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
            this.components = new System.ComponentModel.Container();
            this.ListVouchersDGView = new System.Windows.Forms.DataGridView();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFreeItemsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItemsDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditCardInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCashCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorAccountAmountOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRevised = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListVouchersLbl = new System.Windows.Forms.Label();
            this.ListVouchersBtn = new System.Windows.Forms.Button();
            this.FiltersGB = new System.Windows.Forms.GroupBox();
            this.VendorsComboBox = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.ByVendorNameChkBox = new System.Windows.Forms.CheckBox();
            this.UnRevisedChkBox = new System.Windows.Forms.CheckBox();
            this.UncheckedVouchersChkBox = new System.Windows.Forms.CheckBox();
            this.IsRevisedChkBox = new System.Windows.Forms.CheckBox();
            this.CheckedChkBox = new System.Windows.Forms.CheckBox();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.DateFrompicker = new System.Windows.Forms.DateTimePicker();
            this.DateToLbl = new System.Windows.Forms.Label();
            this.DateFromLbl = new System.Windows.Forms.Label();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.TellerNameComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TellerNameChkBox = new System.Windows.Forms.CheckBox();
            this.usersTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.UsersTableAdapter();
            this.vendorsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.VendorsTableAdapter();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.TotalITemsTxtBox = new System.Windows.Forms.TextBox();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalItemsLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListVouchersDGView)).BeginInit();
            this.FiltersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListVouchersDGView
            // 
            this.ListVouchersDGView.AllowUserToAddRows = false;
            this.ListVouchersDGView.AllowUserToDeleteRows = false;
            this.ListVouchersDGView.BackgroundColor = System.Drawing.Color.White;
            this.ListVouchersDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListVouchersDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListVouchersDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListVouchersDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vendor,
            this.VoucherNumber,
            this.Date,
            this.Time,
            this.Subtotal,
            this.TotalTax,
            this.TotalCost,
            this.Teller,
            this.PaymentMethod,
            this.Comments,
            this.TotalFreeItemsQty,
            this.TotalItemsDiscount,
            this.DiscountPerc,
            this.TotalDiscount,
            this.CreditCardInfo,
            this.Currency,
            this.CheckNumber,
            this.IsCashCredit,
            this.VendorAccountAmountOld,
            this.Fees,
            this.Account,
            this.IsChecked,
            this.CheckedBy,
            this.CheckDate,
            this.CheckTime,
            this.IsRevised,
            this.RevisedBy,
            this.ReviseDate,
            this.ReviseTime,
            this.ReviseLoss});
            this.ListVouchersDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListVouchersDGView.Location = new System.Drawing.Point(0, 208);
            this.ListVouchersDGView.Name = "ListVouchersDGView";
            this.ListVouchersDGView.ReadOnly = true;
            this.ListVouchersDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListVouchersDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ListVouchersDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListVouchersDGView.Size = new System.Drawing.Size(962, 411);
            this.ListVouchersDGView.TabIndex = 24;
            this.ListVouchersDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListVouchersDGView_CellDoubleClick);
            // 
            // Vendor
            // 
            this.Vendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 66;
            // 
            // VoucherNumber
            // 
            this.VoucherNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VoucherNumber.HeaderText = "Bill #";
            this.VoucherNumber.Name = "VoucherNumber";
            this.VoucherNumber.ReadOnly = true;
            this.VoucherNumber.Width = 55;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 55;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 54;
            // 
            // Subtotal
            // 
            this.Subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 72;
            // 
            // TotalTax
            // 
            this.TotalTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalTax.HeaderText = "Tax";
            this.TotalTax.Name = "TotalTax";
            this.TotalTax.ReadOnly = true;
            this.TotalTax.Width = 50;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalCost.HeaderText = "Amount";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 69;
            // 
            // Teller
            // 
            this.Teller.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Teller.HeaderText = "Teller";
            this.Teller.Name = "Teller";
            this.Teller.ReadOnly = true;
            this.Teller.Width = 58;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentMethod.HeaderText = "PaymentMethod";
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Width = 110;
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 82;
            // 
            // TotalFreeItemsQty
            // 
            this.TotalFreeItemsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalFreeItemsQty.HeaderText = "TotalFreeItemsQty";
            this.TotalFreeItemsQty.Name = "TotalFreeItemsQty";
            this.TotalFreeItemsQty.ReadOnly = true;
            this.TotalFreeItemsQty.Visible = false;
            // 
            // TotalItemsDiscount
            // 
            this.TotalItemsDiscount.HeaderText = "TotalItemsDiscount";
            this.TotalItemsDiscount.Name = "TotalItemsDiscount";
            this.TotalItemsDiscount.ReadOnly = true;
            this.TotalItemsDiscount.Visible = false;
            // 
            // DiscountPerc
            // 
            this.DiscountPerc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiscountPerc.HeaderText = "DiscountPerc";
            this.DiscountPerc.Name = "DiscountPerc";
            this.DiscountPerc.ReadOnly = true;
            this.DiscountPerc.Visible = false;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalDiscount.HeaderText = "TotalDiscount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            this.TotalDiscount.Visible = false;
            // 
            // CreditCardInfo
            // 
            this.CreditCardInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreditCardInfo.HeaderText = "CreditCardInfo";
            this.CreditCardInfo.Name = "CreditCardInfo";
            this.CreditCardInfo.ReadOnly = true;
            this.CreditCardInfo.Visible = false;
            // 
            // Currency
            // 
            this.Currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Visible = false;
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckNumber.HeaderText = "CheckNumber";
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.ReadOnly = true;
            this.CheckNumber.Visible = false;
            // 
            // IsCashCredit
            // 
            this.IsCashCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsCashCredit.HeaderText = "IsCashCredit";
            this.IsCashCredit.Name = "IsCashCredit";
            this.IsCashCredit.ReadOnly = true;
            this.IsCashCredit.Visible = false;
            // 
            // VendorAccountAmountOld
            // 
            this.VendorAccountAmountOld.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VendorAccountAmountOld.HeaderText = "Vendor Old Account Amount";
            this.VendorAccountAmountOld.Name = "VendorAccountAmountOld";
            this.VendorAccountAmountOld.ReadOnly = true;
            this.VendorAccountAmountOld.Visible = false;
            // 
            // Fees
            // 
            this.Fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fees.HeaderText = "Fees";
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            // 
            // Account
            // 
            this.Account.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 71;
            // 
            // IsChecked
            // 
            this.IsChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsChecked.HeaderText = "IsChecked";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.ReadOnly = true;
            this.IsChecked.Width = 82;
            // 
            // CheckedBy
            // 
            this.CheckedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckedBy.HeaderText = "CheckedBy";
            this.CheckedBy.Name = "CheckedBy";
            this.CheckedBy.ReadOnly = true;
            this.CheckedBy.Width = 85;
            // 
            // CheckDate
            // 
            this.CheckDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckDate.HeaderText = "CheckDate";
            this.CheckDate.Name = "CheckDate";
            this.CheckDate.ReadOnly = true;
            this.CheckDate.Width = 84;
            // 
            // CheckTime
            // 
            this.CheckTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CheckTime.HeaderText = "CheckTime";
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.ReadOnly = true;
            this.CheckTime.Width = 83;
            // 
            // IsRevised
            // 
            this.IsRevised.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IsRevised.HeaderText = "IsRevised";
            this.IsRevised.Name = "IsRevised";
            this.IsRevised.ReadOnly = true;
            this.IsRevised.Width = 79;
            // 
            // RevisedBy
            // 
            this.RevisedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RevisedBy.HeaderText = "RevisedBy";
            this.RevisedBy.Name = "RevisedBy";
            this.RevisedBy.ReadOnly = true;
            this.RevisedBy.Width = 82;
            // 
            // ReviseDate
            // 
            this.ReviseDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReviseDate.HeaderText = "ReviseDate";
            this.ReviseDate.Name = "ReviseDate";
            this.ReviseDate.ReadOnly = true;
            this.ReviseDate.Width = 87;
            // 
            // ReviseTime
            // 
            this.ReviseTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReviseTime.HeaderText = "ReviseTime";
            this.ReviseTime.Name = "ReviseTime";
            this.ReviseTime.ReadOnly = true;
            this.ReviseTime.Width = 86;
            // 
            // ReviseLoss
            // 
            this.ReviseLoss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReviseLoss.HeaderText = "ReviseLoss";
            this.ReviseLoss.Name = "ReviseLoss";
            this.ReviseLoss.ReadOnly = true;
            this.ReviseLoss.Width = 85;
            // 
            // ListVouchersLbl
            // 
            this.ListVouchersLbl.AutoSize = true;
            this.ListVouchersLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVouchersLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ListVouchersLbl.Location = new System.Drawing.Point(4, 4);
            this.ListVouchersLbl.Name = "ListVouchersLbl";
            this.ListVouchersLbl.Size = new System.Drawing.Size(83, 25);
            this.ListVouchersLbl.TabIndex = 23;
            this.ListVouchersLbl.Text = "List Bills";
            // 
            // ListVouchersBtn
            // 
            this.ListVouchersBtn.BackColor = System.Drawing.Color.Indigo;
            this.ListVouchersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListVouchersBtn.FlatAppearance.BorderSize = 0;
            this.ListVouchersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListVouchersBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVouchersBtn.ForeColor = System.Drawing.Color.White;
            this.ListVouchersBtn.Location = new System.Drawing.Point(565, 51);
            this.ListVouchersBtn.Name = "ListVouchersBtn";
            this.ListVouchersBtn.Size = new System.Drawing.Size(120, 132);
            this.ListVouchersBtn.TabIndex = 25;
            this.ListVouchersBtn.Text = "List Bills";
            this.ListVouchersBtn.UseVisualStyleBackColor = false;
            this.ListVouchersBtn.Click += new System.EventHandler(this.ListVouchersBtn_Click);
            // 
            // FiltersGB
            // 
            this.FiltersGB.Controls.Add(this.VendorsComboBox);
            this.FiltersGB.Controls.Add(this.ByVendorNameChkBox);
            this.FiltersGB.Controls.Add(this.UnRevisedChkBox);
            this.FiltersGB.Controls.Add(this.UncheckedVouchersChkBox);
            this.FiltersGB.Controls.Add(this.IsRevisedChkBox);
            this.FiltersGB.Controls.Add(this.CheckedChkBox);
            this.FiltersGB.Controls.Add(this.DateToPicker);
            this.FiltersGB.Controls.Add(this.DateFrompicker);
            this.FiltersGB.Controls.Add(this.DateToLbl);
            this.FiltersGB.Controls.Add(this.DateFromLbl);
            this.FiltersGB.Controls.Add(this.DateCheckBox);
            this.FiltersGB.Controls.Add(this.TellerNameComboBox);
            this.FiltersGB.Controls.Add(this.TellerNameChkBox);
            this.FiltersGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersGB.ForeColor = System.Drawing.Color.Indigo;
            this.FiltersGB.Location = new System.Drawing.Point(3, 45);
            this.FiltersGB.Name = "FiltersGB";
            this.FiltersGB.Size = new System.Drawing.Size(556, 138);
            this.FiltersGB.TabIndex = 44;
            this.FiltersGB.TabStop = false;
            this.FiltersGB.Text = "Filters";
            // 
            // VendorsComboBox
            // 
            this.VendorsComboBox.DataSource = this.vendorsBindingSource;
            this.VendorsComboBox.DisplayMember = "Name";
            this.VendorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorsComboBox.Enabled = false;
            this.VendorsComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.VendorsComboBox.FormattingEnabled = true;
            this.VendorsComboBox.Location = new System.Drawing.Point(350, 38);
            this.VendorsComboBox.Name = "VendorsComboBox";
            this.VendorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.VendorsComboBox.TabIndex = 53;
            this.VendorsComboBox.ValueMember = "ID";
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ByVendorNameChkBox
            // 
            this.ByVendorNameChkBox.AutoSize = true;
            this.ByVendorNameChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ByVendorNameChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.ByVendorNameChkBox.Location = new System.Drawing.Point(350, 17);
            this.ByVendorNameChkBox.Name = "ByVendorNameChkBox";
            this.ByVendorNameChkBox.Size = new System.Drawing.Size(114, 18);
            this.ByVendorNameChkBox.TabIndex = 51;
            this.ByVendorNameChkBox.Text = "ByVendor Name";
            this.ByVendorNameChkBox.UseVisualStyleBackColor = true;
            this.ByVendorNameChkBox.CheckedChanged += new System.EventHandler(this.VendorNameChkBox_CheckedChanged);
            // 
            // UnRevisedChkBox
            // 
            this.UnRevisedChkBox.AutoSize = true;
            this.UnRevisedChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnRevisedChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.UnRevisedChkBox.Location = new System.Drawing.Point(20, 104);
            this.UnRevisedChkBox.Name = "UnRevisedChkBox";
            this.UnRevisedChkBox.Size = new System.Drawing.Size(104, 18);
            this.UnRevisedChkBox.TabIndex = 50;
            this.UnRevisedChkBox.Text = "UnRevised Bills";
            this.UnRevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // UncheckedVouchersChkBox
            // 
            this.UncheckedVouchersChkBox.AutoSize = true;
            this.UncheckedVouchersChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UncheckedVouchersChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.UncheckedVouchersChkBox.Location = new System.Drawing.Point(150, 104);
            this.UncheckedVouchersChkBox.Name = "UncheckedVouchersChkBox";
            this.UncheckedVouchersChkBox.Size = new System.Drawing.Size(143, 18);
            this.UncheckedVouchersChkBox.TabIndex = 50;
            this.UncheckedVouchersChkBox.Text = "UnChecked Vouchers";
            this.UncheckedVouchersChkBox.UseVisualStyleBackColor = true;
            // 
            // IsRevisedChkBox
            // 
            this.IsRevisedChkBox.AutoSize = true;
            this.IsRevisedChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsRevisedChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.IsRevisedChkBox.Location = new System.Drawing.Point(20, 80);
            this.IsRevisedChkBox.Name = "IsRevisedChkBox";
            this.IsRevisedChkBox.Size = new System.Drawing.Size(122, 18);
            this.IsRevisedChkBox.TabIndex = 50;
            this.IsRevisedChkBox.Text = "Revised Vouchers";
            this.IsRevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // CheckedChkBox
            // 
            this.CheckedChkBox.AutoSize = true;
            this.CheckedChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.CheckedChkBox.Location = new System.Drawing.Point(153, 80);
            this.CheckedChkBox.Name = "CheckedChkBox";
            this.CheckedChkBox.Size = new System.Drawing.Size(128, 18);
            this.CheckedChkBox.TabIndex = 49;
            this.CheckedChkBox.Text = "Checked Vouchers";
            this.CheckedChkBox.UseVisualStyleBackColor = true;
            // 
            // DateToPicker
            // 
            this.DateToPicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateToPicker.Enabled = false;
            this.DateToPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToPicker.Location = new System.Drawing.Point(236, 51);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(89, 21);
            this.DateToPicker.TabIndex = 48;
            // 
            // DateFrompicker
            // 
            this.DateFrompicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateFrompicker.Enabled = false;
            this.DateFrompicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrompicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrompicker.Location = new System.Drawing.Point(64, 53);
            this.DateFrompicker.Name = "DateFrompicker";
            this.DateFrompicker.Size = new System.Drawing.Size(89, 21);
            this.DateFrompicker.TabIndex = 48;
            // 
            // DateToLbl
            // 
            this.DateToLbl.AutoSize = true;
            this.DateToLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DateToLbl.Location = new System.Drawing.Point(204, 55);
            this.DateToLbl.Name = "DateToLbl";
            this.DateToLbl.Size = new System.Drawing.Size(22, 14);
            this.DateToLbl.TabIndex = 47;
            this.DateToLbl.Text = "To";
            // 
            // DateFromLbl
            // 
            this.DateFromLbl.AutoSize = true;
            this.DateFromLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFromLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DateFromLbl.Location = new System.Drawing.Point(18, 56);
            this.DateFromLbl.Name = "DateFromLbl";
            this.DateFromLbl.Size = new System.Drawing.Size(34, 14);
            this.DateFromLbl.TabIndex = 47;
            this.DateFromLbl.Text = "From";
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCheckBox.ForeColor = System.Drawing.Color.Indigo;
            this.DateCheckBox.Location = new System.Drawing.Point(20, 33);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(52, 18);
            this.DateCheckBox.TabIndex = 46;
            this.DateCheckBox.Text = "Date";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // TellerNameComboBox
            // 
            this.TellerNameComboBox.BackColor = System.Drawing.Color.White;
            this.TellerNameComboBox.DataSource = this.usersBindingSource;
            this.TellerNameComboBox.DisplayMember = "UserName";
            this.TellerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TellerNameComboBox.Enabled = false;
            this.TellerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TellerNameComboBox.FormattingEnabled = true;
            this.TellerNameComboBox.Location = new System.Drawing.Point(350, 84);
            this.TellerNameComboBox.Name = "TellerNameComboBox";
            this.TellerNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.TellerNameComboBox.TabIndex = 45;
            this.TellerNameComboBox.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBDataSet;
            // 
            // TellerNameChkBox
            // 
            this.TellerNameChkBox.AutoSize = true;
            this.TellerNameChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerNameChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.TellerNameChkBox.Location = new System.Drawing.Point(350, 62);
            this.TellerNameChkBox.Name = "TellerNameChkBox";
            this.TellerNameChkBox.Size = new System.Drawing.Size(87, 18);
            this.TellerNameChkBox.TabIndex = 44;
            this.TellerNameChkBox.Text = "TellerName";
            this.TellerNameChkBox.UseVisualStyleBackColor = true;
            this.TellerNameChkBox.CheckedChanged += new System.EventHandler(this.TellerNameChkBox_CheckedChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.Indigo;
            this.ItemsPerPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(445, 22);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(106, 47);
            this.ItemsPerPageBtn.TabIndex = 55;
            this.ItemsPerPageBtn.Text = "Change Items Per Page";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(556, 46);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(130, 20);
            this.ItemsPerPageTxtBox.TabIndex = 53;
            // 
            // TotalITemsTxtBox
            // 
            this.TotalITemsTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.TotalITemsTxtBox.Location = new System.Drawing.Point(309, 48);
            this.TotalITemsTxtBox.Name = "TotalITemsTxtBox";
            this.TotalITemsTxtBox.ReadOnly = true;
            this.TotalITemsTxtBox.Size = new System.Drawing.Size(130, 20);
            this.TotalITemsTxtBox.TabIndex = 54;
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.Indigo;
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(153, 47);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 51;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.Indigo;
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(281, 47);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 52;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(177, 47);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PageOfTotalTxtBox.TabIndex = 50;
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.BackColor = System.Drawing.Color.White;
            this.GotoPageTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.GotoPageTxtBox.Location = new System.Drawing.Point(20, 47);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(120, 20);
            this.GotoPageTxtBox.TabIndex = 49;
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.Indigo;
            this.TotalPagesLbl.Location = new System.Drawing.Point(208, 23);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(41, 16);
            this.TotalPagesLbl.TabIndex = 48;
            this.TotalPagesLbl.Text = "Page";
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.Indigo;
            this.GoToPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(19, 20);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(120, 24);
            this.GoToPageBtn.TabIndex = 47;
            this.GoToPageBtn.Text = "GoToPage";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(559, 28);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(115, 16);
            this.ItemsPerPageLbl.TabIndex = 45;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.Indigo;
            this.TotalItemsLbl.Location = new System.Drawing.Point(338, 25);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(73, 16);
            this.TotalItemsLbl.TabIndex = 46;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ListVouchersBtn);
            this.panel1.Controls.Add(this.ListVouchersLbl);
            this.panel1.Controls.Add(this.FiltersGB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 208);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ItemsPerPageBtn);
            this.panel2.Controls.Add(this.ItemsPerPageTxtBox);
            this.panel2.Controls.Add(this.TotalITemsTxtBox);
            this.panel2.Controls.Add(this.PreviousPage);
            this.panel2.Controls.Add(this.NextPage);
            this.panel2.Controls.Add(this.PageOfTotalTxtBox);
            this.panel2.Controls.Add(this.GotoPageTxtBox);
            this.panel2.Controls.Add(this.TotalPagesLbl);
            this.panel2.Controls.Add(this.GoToPageBtn);
            this.panel2.Controls.Add(this.ItemsPerPageLbl);
            this.panel2.Controls.Add(this.TotalItemsLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 619);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 81);
            this.panel2.TabIndex = 57;
            // 
            // ListVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(962, 700);
            this.Controls.Add(this.ListVouchersDGView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ListVouchers";
            this.Text = "ListVouchers";
            this.Load += new System.EventHandler(this.ListVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListVouchersDGView)).EndInit();
            this.FiltersGB.ResumeLayout(false);
            this.FiltersGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListVouchersDGView;
        private System.Windows.Forms.Label ListVouchersLbl;
        private System.Windows.Forms.Button ListVouchersBtn;
        private System.Windows.Forms.GroupBox FiltersGB;
        private System.Windows.Forms.CheckBox ByVendorNameChkBox;
        private System.Windows.Forms.CheckBox UnRevisedChkBox;
        private System.Windows.Forms.CheckBox UncheckedVouchersChkBox;
        private System.Windows.Forms.CheckBox IsRevisedChkBox;
        private System.Windows.Forms.CheckBox CheckedChkBox;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.DateTimePicker DateFrompicker;
        private System.Windows.Forms.Label DateToLbl;
        private System.Windows.Forms.Label DateFromLbl;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.ComboBox TellerNameComboBox;
        private System.Windows.Forms.CheckBox TellerNameChkBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ComboBox VendorsComboBox;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private DBDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.TextBox TotalITemsTxtBox;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalItemsLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teller;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFreeItemsQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItemsDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditCardInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCashCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorAccountAmountOld;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRevised;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseLoss;
    }
}