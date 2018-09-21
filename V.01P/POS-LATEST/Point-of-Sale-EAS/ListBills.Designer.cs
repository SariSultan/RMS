namespace Calcium_RMS
{
    partial class ListBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBills));
            this.ListBillsDGView = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRevised = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListBillsBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalItemsLbl = new System.Windows.Forms.Label();
            this.FiltersGB = new System.Windows.Forms.GroupBox();
            this.CreditBillsChkBox = new System.Windows.Forms.CheckBox();
            this.CustomerNameChkBox = new System.Windows.Forms.CheckBox();
            this.UnRevisedChkBox = new System.Windows.Forms.CheckBox();
            this.UncheckedBillChkBox = new System.Windows.Forms.CheckBox();
            this.IsRevisedChkBox = new System.Windows.Forms.CheckBox();
            this.CkeckedBillsChkBox = new System.Windows.Forms.CheckBox();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.DateFrompicker = new System.Windows.Forms.DateTimePicker();
            this.DateToLbl = new System.Windows.Forms.Label();
            this.DateFromLbl = new System.Windows.Forms.Label();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.TellerNameComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.TellerNameChkBox = new System.Windows.Forms.CheckBox();
            this.CustomerPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.usersTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.UsersTableAdapter();
            this.ListVouchersLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.TotalITemsTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListBillsDGView)).BeginInit();
            this.FiltersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBillsDGView
            // 
            this.ListBillsDGView.AllowUserToAddRows = false;
            this.ListBillsDGView.AllowUserToDeleteRows = false;
            this.ListBillsDGView.BackgroundColor = System.Drawing.Color.White;
            this.ListBillsDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListBillsDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListBillsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListBillsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Number,
            this.Date,
            this.BillTime,
            this.TellerID,
            this.TotalPrice,
            this.TotalItems,
            this.TotalCost,
            this.TotalTax,
            this.PriceLevelID,
            this.DiscountPerc,
            this.SalesDiscount,
            this.TotalDiscount,
            this.PaymentMethodID,
            this.Comments,
            this.CashIn,
            this.IsChecked,
            this.IsRevised,
            this.CheckedBy,
            this.CheckedDate,
            this.ReviseDate,
            this.RevisedBy,
            this.ReviseLoss});
            this.ListBillsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBillsDGView.Location = new System.Drawing.Point(0, 208);
            this.ListBillsDGView.Name = "ListBillsDGView";
            this.ListBillsDGView.ReadOnly = true;
            this.ListBillsDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListBillsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ListBillsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListBillsDGView.Size = new System.Drawing.Size(727, 412);
            this.ListBillsDGView.TabIndex = 27;
            this.ListBillsDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListBillsDGView_CellDoubleClick);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.HeaderText = "Customer";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 78;
            // 
            // Number
            // 
            this.Number.HeaderText = "Invoice Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 55;
            // 
            // BillTime
            // 
            this.BillTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillTime.HeaderText = "Time";
            this.BillTime.Name = "BillTime";
            this.BillTime.ReadOnly = true;
            this.BillTime.Width = 54;
            // 
            // TellerID
            // 
            this.TellerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TellerID.HeaderText = "Teller Name";
            this.TellerID.Name = "TellerID";
            this.TellerID.ReadOnly = true;
            this.TellerID.Width = 81;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 76;
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalItems.HeaderText = "TotalItems";
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.ReadOnly = true;
            this.TotalItems.Width = 83;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalCost.HeaderText = "Total Cost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Width = 75;
            // 
            // TotalTax
            // 
            this.TotalTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalTax.HeaderText = "Total Tax";
            this.TotalTax.Name = "TotalTax";
            this.TotalTax.ReadOnly = true;
            this.TotalTax.Width = 71;
            // 
            // PriceLevelID
            // 
            this.PriceLevelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceLevelID.HeaderText = "Price Level";
            this.PriceLevelID.Name = "PriceLevelID";
            this.PriceLevelID.ReadOnly = true;
            this.PriceLevelID.Width = 77;
            // 
            // DiscountPerc
            // 
            this.DiscountPerc.HeaderText = "Discount Percentage %";
            this.DiscountPerc.Name = "DiscountPerc";
            this.DiscountPerc.ReadOnly = true;
            // 
            // SalesDiscount
            // 
            this.SalesDiscount.HeaderText = "Discount On Voucher";
            this.SalesDiscount.Name = "SalesDiscount";
            this.SalesDiscount.ReadOnly = true;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.HeaderText = "Total Discount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            // 
            // PaymentMethodID
            // 
            this.PaymentMethodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentMethodID.HeaderText = "PaymentMethodID";
            this.PaymentMethodID.Name = "PaymentMethodID";
            this.PaymentMethodID.ReadOnly = true;
            this.PaymentMethodID.Width = 121;
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 82;
            // 
            // CashIn
            // 
            this.CashIn.HeaderText = "CashIn";
            this.CashIn.Name = "CashIn";
            this.CashIn.ReadOnly = true;
            // 
            // IsChecked
            // 
            this.IsChecked.HeaderText = "IsChecked";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.ReadOnly = true;
            // 
            // IsRevised
            // 
            this.IsRevised.HeaderText = "IsRevised";
            this.IsRevised.Name = "IsRevised";
            this.IsRevised.ReadOnly = true;
            // 
            // CheckedBy
            // 
            this.CheckedBy.HeaderText = "CheckedBy";
            this.CheckedBy.Name = "CheckedBy";
            this.CheckedBy.ReadOnly = true;
            // 
            // CheckedDate
            // 
            this.CheckedDate.HeaderText = "CheckedDate";
            this.CheckedDate.Name = "CheckedDate";
            this.CheckedDate.ReadOnly = true;
            // 
            // ReviseDate
            // 
            this.ReviseDate.HeaderText = "ReviseDate";
            this.ReviseDate.Name = "ReviseDate";
            this.ReviseDate.ReadOnly = true;
            // 
            // RevisedBy
            // 
            this.RevisedBy.HeaderText = "RevisedBy";
            this.RevisedBy.Name = "RevisedBy";
            this.RevisedBy.ReadOnly = true;
            // 
            // ReviseLoss
            // 
            this.ReviseLoss.HeaderText = "ReviseLoss";
            this.ReviseLoss.Name = "ReviseLoss";
            this.ReviseLoss.ReadOnly = true;
            // 
            // ListBillsBtn
            // 
            this.ListBillsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ListBillsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListBillsBtn.FlatAppearance.BorderSize = 0;
            this.ListBillsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListBillsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBillsBtn.ForeColor = System.Drawing.Color.White;
            this.ListBillsBtn.Location = new System.Drawing.Point(582, 53);
            this.ListBillsBtn.Name = "ListBillsBtn";
            this.ListBillsBtn.Size = new System.Drawing.Size(120, 128);
            this.ListBillsBtn.TabIndex = 28;
            this.ListBillsBtn.Text = "List Invoices";
            this.ListBillsBtn.UseVisualStyleBackColor = false;
            this.ListBillsBtn.Click += new System.EventHandler(this.ListBillsBtn_Click);
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(315, 49);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(60, 20);
            this.ItemsPerPageTxtBox.TabIndex = 40;
            this.ItemsPerPageTxtBox.Text = "10";
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(153, 47);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 38;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(281, 47);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 39;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(177, 47);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PageOfTotalTxtBox.TabIndex = 37;
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.BackColor = System.Drawing.Color.White;
            this.GotoPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.GotoPageTxtBox.Location = new System.Drawing.Point(20, 47);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(120, 20);
            this.GotoPageTxtBox.TabIndex = 36;
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalPagesLbl.Location = new System.Drawing.Point(208, 23);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(34, 14);
            this.TotalPagesLbl.TabIndex = 35;
            this.TotalPagesLbl.Text = "Page";
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(19, 20);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(120, 24);
            this.GoToPageBtn.TabIndex = 34;
            this.GoToPageBtn.Text = "GoToPage";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(323, 27);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(104, 14);
            this.ItemsPerPageLbl.TabIndex = 32;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalItemsLbl.Location = new System.Drawing.Point(591, 27);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(66, 14);
            this.TotalItemsLbl.TabIndex = 33;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // FiltersGB
            // 
            this.FiltersGB.Controls.Add(this.CreditBillsChkBox);
            this.FiltersGB.Controls.Add(this.CustomerNameChkBox);
            this.FiltersGB.Controls.Add(this.UnRevisedChkBox);
            this.FiltersGB.Controls.Add(this.UncheckedBillChkBox);
            this.FiltersGB.Controls.Add(this.IsRevisedChkBox);
            this.FiltersGB.Controls.Add(this.CkeckedBillsChkBox);
            this.FiltersGB.Controls.Add(this.DateToPicker);
            this.FiltersGB.Controls.Add(this.DateFrompicker);
            this.FiltersGB.Controls.Add(this.DateToLbl);
            this.FiltersGB.Controls.Add(this.DateFromLbl);
            this.FiltersGB.Controls.Add(this.DateCheckBox);
            this.FiltersGB.Controls.Add(this.TellerNameComboBox);
            this.FiltersGB.Controls.Add(this.TellerNameChkBox);
            this.FiltersGB.Controls.Add(this.CustomerPhoneTxtBox);
            this.FiltersGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.FiltersGB.Location = new System.Drawing.Point(20, 45);
            this.FiltersGB.Name = "FiltersGB";
            this.FiltersGB.Size = new System.Drawing.Size(556, 138);
            this.FiltersGB.TabIndex = 43;
            this.FiltersGB.TabStop = false;
            this.FiltersGB.Text = "Filters";
            // 
            // CreditBillsChkBox
            // 
            this.CreditBillsChkBox.AutoSize = true;
            this.CreditBillsChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditBillsChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CreditBillsChkBox.Location = new System.Drawing.Point(165, 78);
            this.CreditBillsChkBox.Name = "CreditBillsChkBox";
            this.CreditBillsChkBox.Size = new System.Drawing.Size(80, 18);
            this.CreditBillsChkBox.TabIndex = 53;
            this.CreditBillsChkBox.Text = "Credit Bills";
            this.CreditBillsChkBox.UseVisualStyleBackColor = true;
            // 
            // CustomerNameChkBox
            // 
            this.CustomerNameChkBox.AutoSize = true;
            this.CustomerNameChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerNameChkBox.Location = new System.Drawing.Point(361, 33);
            this.CustomerNameChkBox.Name = "CustomerNameChkBox";
            this.CustomerNameChkBox.Size = new System.Drawing.Size(126, 18);
            this.CustomerNameChkBox.TabIndex = 51;
            this.CustomerNameChkBox.Text = "ByCustomerPhone";
            this.CustomerNameChkBox.UseVisualStyleBackColor = true;
            this.CustomerNameChkBox.CheckedChanged += new System.EventHandler(this.CustomerNameChkBox_CheckedChanged);
            // 
            // UnRevisedChkBox
            // 
            this.UnRevisedChkBox.AutoSize = true;
            this.UnRevisedChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnRevisedChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.UnRevisedChkBox.Location = new System.Drawing.Point(20, 102);
            this.UnRevisedChkBox.Name = "UnRevisedChkBox";
            this.UnRevisedChkBox.Size = new System.Drawing.Size(104, 18);
            this.UnRevisedChkBox.TabIndex = 50;
            this.UnRevisedChkBox.Text = "UnRevised Bills";
            this.UnRevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // UncheckedBillChkBox
            // 
            this.UncheckedBillChkBox.AutoSize = true;
            this.UncheckedBillChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UncheckedBillChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.UncheckedBillChkBox.Location = new System.Drawing.Point(20, 56);
            this.UncheckedBillChkBox.Name = "UncheckedBillChkBox";
            this.UncheckedBillChkBox.Size = new System.Drawing.Size(106, 18);
            this.UncheckedBillChkBox.TabIndex = 50;
            this.UncheckedBillChkBox.Text = "UnCheckedBills";
            this.UncheckedBillChkBox.UseVisualStyleBackColor = true;
            // 
            // IsRevisedChkBox
            // 
            this.IsRevisedChkBox.AutoSize = true;
            this.IsRevisedChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsRevisedChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.IsRevisedChkBox.Location = new System.Drawing.Point(20, 78);
            this.IsRevisedChkBox.Name = "IsRevisedChkBox";
            this.IsRevisedChkBox.Size = new System.Drawing.Size(89, 18);
            this.IsRevisedChkBox.TabIndex = 50;
            this.IsRevisedChkBox.Text = "Revised Bills";
            this.IsRevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // CkeckedBillsChkBox
            // 
            this.CkeckedBillsChkBox.AutoSize = true;
            this.CkeckedBillsChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkeckedBillsChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CkeckedBillsChkBox.Location = new System.Drawing.Point(165, 56);
            this.CkeckedBillsChkBox.Name = "CkeckedBillsChkBox";
            this.CkeckedBillsChkBox.Size = new System.Drawing.Size(95, 18);
            this.CkeckedBillsChkBox.TabIndex = 49;
            this.CkeckedBillsChkBox.Text = "Checked Bills";
            this.CkeckedBillsChkBox.UseVisualStyleBackColor = true;
            // 
            // DateToPicker
            // 
            this.DateToPicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateToPicker.Enabled = false;
            this.DateToPicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToPicker.Location = new System.Drawing.Point(226, 28);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(89, 23);
            this.DateToPicker.TabIndex = 48;
            // 
            // DateFrompicker
            // 
            this.DateFrompicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateFrompicker.Enabled = false;
            this.DateFrompicker.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrompicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrompicker.Location = new System.Drawing.Point(108, 28);
            this.DateFrompicker.Name = "DateFrompicker";
            this.DateFrompicker.Size = new System.Drawing.Size(89, 23);
            this.DateFrompicker.TabIndex = 48;
            // 
            // DateToLbl
            // 
            this.DateToLbl.AutoSize = true;
            this.DateToLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DateToLbl.Location = new System.Drawing.Point(223, 8);
            this.DateToLbl.Name = "DateToLbl";
            this.DateToLbl.Size = new System.Drawing.Size(22, 14);
            this.DateToLbl.TabIndex = 47;
            this.DateToLbl.Text = "To";
            // 
            // DateFromLbl
            // 
            this.DateFromLbl.AutoSize = true;
            this.DateFromLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFromLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DateFromLbl.Location = new System.Drawing.Point(105, 10);
            this.DateFromLbl.Name = "DateFromLbl";
            this.DateFromLbl.Size = new System.Drawing.Size(34, 14);
            this.DateFromLbl.TabIndex = 47;
            this.DateFromLbl.Text = "From";
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
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
            this.TellerNameComboBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TellerNameComboBox.FormattingEnabled = true;
            this.TellerNameComboBox.Location = new System.Drawing.Point(361, 100);
            this.TellerNameComboBox.Name = "TellerNameComboBox";
            this.TellerNameComboBox.Size = new System.Drawing.Size(121, 22);
            this.TellerNameComboBox.TabIndex = 45;
            this.TellerNameComboBox.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TellerNameChkBox
            // 
            this.TellerNameChkBox.AutoSize = true;
            this.TellerNameChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerNameChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TellerNameChkBox.Location = new System.Drawing.Point(361, 78);
            this.TellerNameChkBox.Name = "TellerNameChkBox";
            this.TellerNameChkBox.Size = new System.Drawing.Size(87, 18);
            this.TellerNameChkBox.TabIndex = 44;
            this.TellerNameChkBox.Text = "TellerName";
            this.TellerNameChkBox.UseVisualStyleBackColor = true;
            this.TellerNameChkBox.CheckedChanged += new System.EventHandler(this.TellerNameChkBox_CheckedChanged);
            // 
            // CustomerPhoneTxtBox
            // 
            this.CustomerPhoneTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomerPhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerPhoneTxtBox.Location = new System.Drawing.Point(361, 54);
            this.CustomerPhoneTxtBox.Name = "CustomerPhoneTxtBox";
            this.CustomerPhoneTxtBox.Size = new System.Drawing.Size(121, 22);
            this.CustomerPhoneTxtBox.TabIndex = 52;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // ListVouchersLbl
            // 
            this.ListVouchersLbl.AutoSize = true;
            this.ListVouchersLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVouchersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ListVouchersLbl.Location = new System.Drawing.Point(322, 11);
            this.ListVouchersLbl.Name = "ListVouchersLbl";
            this.ListVouchersLbl.Size = new System.Drawing.Size(131, 25);
            this.ListVouchersLbl.TabIndex = 44;
            this.ListVouchersLbl.Text = "List Invoices";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ListVouchersLbl);
            this.panel1.Controls.Add(this.FiltersGB);
            this.panel1.Controls.Add(this.ListBillsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 208);
            this.panel1.TabIndex = 45;
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
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 80);
            this.panel2.TabIndex = 46;
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(381, 46);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(173, 24);
            this.ItemsPerPageBtn.TabIndex = 42;
            this.ItemsPerPageBtn.Text = "Change Items Per Page";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // TotalITemsTxtBox
            // 
            this.TotalITemsTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalITemsTxtBox.Location = new System.Drawing.Point(562, 48);
            this.TotalITemsTxtBox.Name = "TotalITemsTxtBox";
            this.TotalITemsTxtBox.ReadOnly = true;
            this.TotalITemsTxtBox.Size = new System.Drawing.Size(130, 20);
            this.TotalITemsTxtBox.TabIndex = 41;
            // 
            // ListBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(727, 700);
            this.Controls.Add(this.ListBillsDGView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListBills";
            this.Text = "ListBills";
            this.Load += new System.EventHandler(this.ListBills_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBillsDGView)).EndInit();
            this.FiltersGB.ResumeLayout(false);
            this.FiltersGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListBillsDGView;
        private System.Windows.Forms.Button ListBillsBtn;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalItemsLbl;
        private System.Windows.Forms.GroupBox FiltersGB;
        private System.Windows.Forms.ComboBox TellerNameComboBox;
        private System.Windows.Forms.CheckBox TellerNameChkBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.DateTimePicker DateFrompicker;
        private System.Windows.Forms.Label DateToLbl;
        private System.Windows.Forms.Label DateFromLbl;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.CheckBox CkeckedBillsChkBox;
        private System.Windows.Forms.CheckBox IsRevisedChkBox;
        private System.Windows.Forms.CheckBox UnRevisedChkBox;
        private System.Windows.Forms.CheckBox UncheckedBillChkBox;
        private System.Windows.Forms.TextBox CustomerPhoneTxtBox;
        private System.Windows.Forms.CheckBox CustomerNameChkBox;
        private System.Windows.Forms.CheckBox CreditBillsChkBox;
        private System.Windows.Forms.Label ListVouchersLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.TextBox TotalITemsTxtBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TellerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRevised;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseLoss;
    }
}