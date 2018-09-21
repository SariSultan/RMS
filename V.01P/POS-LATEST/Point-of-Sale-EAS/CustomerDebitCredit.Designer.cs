namespace Calcium_RMS
{
    partial class CustomerDebitCredit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AccountBalnaceLbl = new System.Windows.Forms.Label();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.CustomerBalanceTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.FiltersGB = new System.Windows.Forms.GroupBox();
            this.UnRevisedChkBox = new System.Windows.Forms.CheckBox();
            this.UnCheckedChkBox = new System.Windows.Forms.CheckBox();
            this.RevisedChkBox = new System.Windows.Forms.CheckBox();
            this.CheckChkBox = new System.Windows.Forms.CheckBox();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.DateFrompicker = new System.Windows.Forms.DateTimePicker();
            this.DateToLbl = new System.Windows.Forms.Label();
            this.DateFromLbl = new System.Windows.Forms.Label();
            this.DateCheckBox = new System.Windows.Forms.CheckBox();
            this.TellerNameComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.CreditBillsChkBox = new System.Windows.Forms.CheckBox();
            this.TellerNameChkBox = new System.Windows.Forms.CheckBox();
            this.ListDCBtn = new System.Windows.Forms.Button();
            this.CreditDGView = new System.Windows.Forms.DataGridView();
            this.TypeCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentsCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIDCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TellerCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldAmountCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsCheckedCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedByCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckDateCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckTimeCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRevisedCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisedByCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseDateCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseTimeCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemsPerPageBtnCredit = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBoxCredit = new System.Windows.Forms.TextBox();
            this.TotalITemsTxtBoxCredit = new System.Windows.Forms.TextBox();
            this.PreviousPageCredit = new System.Windows.Forms.Button();
            this.NextPageCredit = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBoxCredit = new System.Windows.Forms.TextBox();
            this.textBox1Credit = new System.Windows.Forms.TextBox();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.NextPageBtnCredit = new System.Windows.Forms.Button();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalItemsLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextPageBtnDebit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Debit = new System.Windows.Forms.TextBox();
            this.PageOfTotalTxtBoxDebit = new System.Windows.Forms.TextBox();
            this.NextPageDebit = new System.Windows.Forms.Button();
            this.PreviousPageDebit = new System.Windows.Forms.Button();
            this.TotalITemsTxtBoxDebit = new System.Windows.Forms.TextBox();
            this.ItemsPerPageTxtBoxDebit = new System.Windows.Forms.TextBox();
            this.ItemsPerPageBtnDebit = new System.Windows.Forms.Button();
            this.DebitDGView = new System.Windows.Forms.DataGridView();
            this.TypeDbt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TellerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceLevelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethodID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRevised = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsChecked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviseLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillsPriceLbl = new System.Windows.Forms.Label();
            this.TotalDebitPriceTxtBox = new System.Windows.Forms.TextBox();
            this.TotalCreditTxtBox = new System.Windows.Forms.TextBox();
            this.TotalCreditLbl = new System.Windows.Forms.Label();
            this.MatchBalanceButton = new System.Windows.Forms.Button();
            this.CustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CustomerTableAdapter();
            this.AddCustomerLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CreditLbl = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DebitLbl = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.usersTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.UsersTableAdapter();
            this.FiltersGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitDGView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountBalnaceLbl
            // 
            this.AccountBalnaceLbl.AutoSize = true;
            this.AccountBalnaceLbl.ForeColor = System.Drawing.Color.Crimson;
            this.AccountBalnaceLbl.Location = new System.Drawing.Point(477, 32);
            this.AccountBalnaceLbl.Name = "AccountBalnaceLbl";
            this.AccountBalnaceLbl.Size = new System.Drawing.Size(44, 13);
            this.AccountBalnaceLbl.TabIndex = 5;
            this.AccountBalnaceLbl.Text = "Balance";
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerNameLbl.Location = new System.Drawing.Point(112, 32);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(83, 13);
            this.CustomerNameLbl.TabIndex = 6;
            this.CustomerNameLbl.Text = "Customer Name";
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(341, 32);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(86, 13);
            this.CustomerPhoneLbl.TabIndex = 7;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // CustomerBalanceTxtBox
            // 
            this.CustomerBalanceTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomerBalanceTxtBox.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerBalanceTxtBox.Location = new System.Drawing.Point(469, 48);
            this.CustomerBalanceTxtBox.Name = "CustomerBalanceTxtBox";
            this.CustomerBalanceTxtBox.ReadOnly = true;
            this.CustomerBalanceTxtBox.Size = new System.Drawing.Size(149, 20);
            this.CustomerBalanceTxtBox.TabIndex = 2;
            // 
            // CustomerPhoneTxtBox
            // 
            this.CustomerPhoneTxtBox.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerPhoneTxtBox.Location = new System.Drawing.Point(306, 48);
            this.CustomerPhoneTxtBox.Name = "CustomerPhoneTxtBox";
            this.CustomerPhoneTxtBox.Size = new System.Drawing.Size(160, 20);
            this.CustomerPhoneTxtBox.TabIndex = 4;
            this.CustomerPhoneTxtBox.TextChanged += new System.EventHandler(this.CustomerPhoneTxtBox_TextChanged);
            // 
            // FiltersGB
            // 
            this.FiltersGB.Controls.Add(this.UnRevisedChkBox);
            this.FiltersGB.Controls.Add(this.UnCheckedChkBox);
            this.FiltersGB.Controls.Add(this.RevisedChkBox);
            this.FiltersGB.Controls.Add(this.CheckChkBox);
            this.FiltersGB.Controls.Add(this.DateToPicker);
            this.FiltersGB.Controls.Add(this.DateFrompicker);
            this.FiltersGB.Controls.Add(this.DateToLbl);
            this.FiltersGB.Controls.Add(this.DateFromLbl);
            this.FiltersGB.Controls.Add(this.DateCheckBox);
            this.FiltersGB.Controls.Add(this.TellerNameComboBox);
            this.FiltersGB.Controls.Add(this.CreditBillsChkBox);
            this.FiltersGB.Controls.Add(this.TellerNameChkBox);
            this.FiltersGB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltersGB.ForeColor = System.Drawing.Color.Crimson;
            this.FiltersGB.Location = new System.Drawing.Point(12, 73);
            this.FiltersGB.Name = "FiltersGB";
            this.FiltersGB.Size = new System.Drawing.Size(606, 95);
            this.FiltersGB.TabIndex = 46;
            this.FiltersGB.TabStop = false;
            this.FiltersGB.Text = "Filters";
            // 
            // UnRevisedChkBox
            // 
            this.UnRevisedChkBox.AutoSize = true;
            this.UnRevisedChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.UnRevisedChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.UnRevisedChkBox.Location = new System.Drawing.Point(352, 62);
            this.UnRevisedChkBox.Name = "UnRevisedChkBox";
            this.UnRevisedChkBox.Size = new System.Drawing.Size(77, 17);
            this.UnRevisedChkBox.TabIndex = 50;
            this.UnRevisedChkBox.Text = "UnRevised";
            this.UnRevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // UnCheckedChkBox
            // 
            this.UnCheckedChkBox.AutoSize = true;
            this.UnCheckedChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.UnCheckedChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.UnCheckedChkBox.Location = new System.Drawing.Point(352, 39);
            this.UnCheckedChkBox.Name = "UnCheckedChkBox";
            this.UnCheckedChkBox.Size = new System.Drawing.Size(80, 17);
            this.UnCheckedChkBox.TabIndex = 50;
            this.UnCheckedChkBox.Text = "UnChecked";
            this.UnCheckedChkBox.UseVisualStyleBackColor = true;
            // 
            // RevisedChkBox
            // 
            this.RevisedChkBox.AutoSize = true;
            this.RevisedChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.RevisedChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.RevisedChkBox.Location = new System.Drawing.Point(438, 62);
            this.RevisedChkBox.Name = "RevisedChkBox";
            this.RevisedChkBox.Size = new System.Drawing.Size(64, 17);
            this.RevisedChkBox.TabIndex = 50;
            this.RevisedChkBox.Text = "Revised";
            this.RevisedChkBox.UseVisualStyleBackColor = true;
            // 
            // CheckChkBox
            // 
            this.CheckChkBox.AutoSize = true;
            this.CheckChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.CheckChkBox.Location = new System.Drawing.Point(438, 39);
            this.CheckChkBox.Name = "CheckChkBox";
            this.CheckChkBox.Size = new System.Drawing.Size(67, 17);
            this.CheckChkBox.TabIndex = 49;
            this.CheckChkBox.Text = "Checked";
            this.CheckChkBox.UseVisualStyleBackColor = true;
            // 
            // DateToPicker
            // 
            this.DateToPicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateToPicker.Enabled = false;
            this.DateToPicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToPicker.Location = new System.Drawing.Point(217, 34);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(129, 20);
            this.DateToPicker.TabIndex = 48;
            // 
            // DateFrompicker
            // 
            this.DateFrompicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateFrompicker.Enabled = false;
            this.DateFrompicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DateFrompicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrompicker.Location = new System.Drawing.Point(75, 33);
            this.DateFrompicker.Name = "DateFrompicker";
            this.DateFrompicker.Size = new System.Drawing.Size(136, 20);
            this.DateFrompicker.TabIndex = 48;
            // 
            // DateToLbl
            // 
            this.DateToLbl.AutoSize = true;
            this.DateToLbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DateToLbl.ForeColor = System.Drawing.Color.Crimson;
            this.DateToLbl.Location = new System.Drawing.Point(272, 18);
            this.DateToLbl.Name = "DateToLbl";
            this.DateToLbl.Size = new System.Drawing.Size(19, 13);
            this.DateToLbl.TabIndex = 47;
            this.DateToLbl.Text = "To";
            // 
            // DateFromLbl
            // 
            this.DateFromLbl.AutoSize = true;
            this.DateFromLbl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DateFromLbl.ForeColor = System.Drawing.Color.Crimson;
            this.DateFromLbl.Location = new System.Drawing.Point(115, 18);
            this.DateFromLbl.Name = "DateFromLbl";
            this.DateFromLbl.Size = new System.Drawing.Size(31, 13);
            this.DateFromLbl.TabIndex = 47;
            this.DateFromLbl.Text = "From";
            // 
            // DateCheckBox
            // 
            this.DateCheckBox.AutoSize = true;
            this.DateCheckBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.DateCheckBox.ForeColor = System.Drawing.Color.Crimson;
            this.DateCheckBox.Location = new System.Drawing.Point(20, 33);
            this.DateCheckBox.Name = "DateCheckBox";
            this.DateCheckBox.Size = new System.Drawing.Size(49, 17);
            this.DateCheckBox.TabIndex = 46;
            this.DateCheckBox.Text = "Date";
            this.DateCheckBox.UseVisualStyleBackColor = true;
            this.DateCheckBox.CheckedChanged += new System.EventHandler(this.DateCheckBox_CheckedChanged);
            // 
            // TellerNameComboBox
            // 
            this.TellerNameComboBox.BackColor = System.Drawing.Color.Lavender;
            this.TellerNameComboBox.DataSource = this.usersBindingSource;
            this.TellerNameComboBox.DisplayMember = "UserName";
            this.TellerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TellerNameComboBox.Enabled = false;
            this.TellerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TellerNameComboBox.FormattingEnabled = true;
            this.TellerNameComboBox.Location = new System.Drawing.Point(105, 62);
            this.TellerNameComboBox.Name = "TellerNameComboBox";
            this.TellerNameComboBox.Size = new System.Drawing.Size(241, 21);
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
            // CreditBillsChkBox
            // 
            this.CreditBillsChkBox.AutoSize = true;
            this.CreditBillsChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CreditBillsChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.CreditBillsChkBox.Location = new System.Drawing.Point(525, 62);
            this.CreditBillsChkBox.Name = "CreditBillsChkBox";
            this.CreditBillsChkBox.Size = new System.Drawing.Size(75, 17);
            this.CreditBillsChkBox.TabIndex = 44;
            this.CreditBillsChkBox.Text = "Credit Bills";
            this.CreditBillsChkBox.UseVisualStyleBackColor = true;
            // 
            // TellerNameChkBox
            // 
            this.TellerNameChkBox.AutoSize = true;
            this.TellerNameChkBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TellerNameChkBox.ForeColor = System.Drawing.Color.Crimson;
            this.TellerNameChkBox.Location = new System.Drawing.Point(20, 66);
            this.TellerNameChkBox.Name = "TellerNameChkBox";
            this.TellerNameChkBox.Size = new System.Drawing.Size(79, 17);
            this.TellerNameChkBox.TabIndex = 44;
            this.TellerNameChkBox.Text = "TellerName";
            this.TellerNameChkBox.UseVisualStyleBackColor = true;
            this.TellerNameChkBox.CheckedChanged += new System.EventHandler(this.TellerNameChkBox_CheckedChanged);
            // 
            // ListDCBtn
            // 
            this.ListDCBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ListDCBtn.BackColor = System.Drawing.Color.Crimson;
            this.ListDCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListDCBtn.FlatAppearance.BorderSize = 0;
            this.ListDCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListDCBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDCBtn.ForeColor = System.Drawing.Color.White;
            this.ListDCBtn.Location = new System.Drawing.Point(782, 85);
            this.ListDCBtn.Name = "ListDCBtn";
            this.ListDCBtn.Size = new System.Drawing.Size(121, 83);
            this.ListDCBtn.TabIndex = 45;
            this.ListDCBtn.Text = "List";
            this.ListDCBtn.UseVisualStyleBackColor = false;
            this.ListDCBtn.Click += new System.EventHandler(this.ListDCBtn_Click);
            // 
            // CreditDGView
            // 
            this.CreditDGView.AllowUserToAddRows = false;
            this.CreditDGView.AllowUserToDeleteRows = false;
            this.CreditDGView.BackgroundColor = System.Drawing.Color.White;
            this.CreditDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreditDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCredit,
            this.PaymentNumber,
            this.DateCredit,
            this.AmountCredit,
            this.CommentsCredit,
            this.CustomerIDCredit,
            this.TimeCredit,
            this.TellerCredit,
            this.OldAmountCredit,
            this.IsCheckedCredit,
            this.CheckedByCredit,
            this.CheckDateCredit,
            this.CheckTimeCredit,
            this.IsRevisedCredit,
            this.RevisedByCredit,
            this.ReviseDateCredit,
            this.ReviseTimeCredit});
            this.CreditDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreditDGView.Location = new System.Drawing.Point(0, 57);
            this.CreditDGView.Name = "CreditDGView";
            this.CreditDGView.ReadOnly = true;
            this.CreditDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CreditDGView.Size = new System.Drawing.Size(498, 412);
            this.CreditDGView.TabIndex = 47;
            this.CreditDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreditDGView_CellDoubleClick);
            // 
            // TypeCredit
            // 
            this.TypeCredit.HeaderText = "Type";
            this.TypeCredit.Name = "TypeCredit";
            this.TypeCredit.ReadOnly = true;
            // 
            // PaymentNumber
            // 
            this.PaymentNumber.HeaderText = "Reference #";
            this.PaymentNumber.Name = "PaymentNumber";
            this.PaymentNumber.ReadOnly = true;
            // 
            // DateCredit
            // 
            this.DateCredit.HeaderText = "Date";
            this.DateCredit.Name = "DateCredit";
            this.DateCredit.ReadOnly = true;
            // 
            // AmountCredit
            // 
            this.AmountCredit.HeaderText = "Amount";
            this.AmountCredit.Name = "AmountCredit";
            this.AmountCredit.ReadOnly = true;
            // 
            // CommentsCredit
            // 
            this.CommentsCredit.HeaderText = "Comments";
            this.CommentsCredit.Name = "CommentsCredit";
            this.CommentsCredit.ReadOnly = true;
            // 
            // CustomerIDCredit
            // 
            this.CustomerIDCredit.HeaderText = "Customer Name";
            this.CustomerIDCredit.Name = "CustomerIDCredit";
            this.CustomerIDCredit.ReadOnly = true;
            // 
            // TimeCredit
            // 
            this.TimeCredit.HeaderText = "Time";
            this.TimeCredit.Name = "TimeCredit";
            this.TimeCredit.ReadOnly = true;
            // 
            // TellerCredit
            // 
            this.TellerCredit.HeaderText = "Teller Name";
            this.TellerCredit.Name = "TellerCredit";
            this.TellerCredit.ReadOnly = true;
            // 
            // OldAmountCredit
            // 
            this.OldAmountCredit.HeaderText = "Old Amount";
            this.OldAmountCredit.Name = "OldAmountCredit";
            this.OldAmountCredit.ReadOnly = true;
            // 
            // IsCheckedCredit
            // 
            this.IsCheckedCredit.HeaderText = "Checked";
            this.IsCheckedCredit.Name = "IsCheckedCredit";
            this.IsCheckedCredit.ReadOnly = true;
            // 
            // CheckedByCredit
            // 
            this.CheckedByCredit.HeaderText = "Checked By";
            this.CheckedByCredit.Name = "CheckedByCredit";
            this.CheckedByCredit.ReadOnly = true;
            // 
            // CheckDateCredit
            // 
            this.CheckDateCredit.HeaderText = "Check Date";
            this.CheckDateCredit.Name = "CheckDateCredit";
            this.CheckDateCredit.ReadOnly = true;
            // 
            // CheckTimeCredit
            // 
            this.CheckTimeCredit.HeaderText = "Check time";
            this.CheckTimeCredit.Name = "CheckTimeCredit";
            this.CheckTimeCredit.ReadOnly = true;
            // 
            // IsRevisedCredit
            // 
            this.IsRevisedCredit.HeaderText = "Reversed";
            this.IsRevisedCredit.Name = "IsRevisedCredit";
            this.IsRevisedCredit.ReadOnly = true;
            // 
            // RevisedByCredit
            // 
            this.RevisedByCredit.HeaderText = "Reversed By";
            this.RevisedByCredit.Name = "RevisedByCredit";
            this.RevisedByCredit.ReadOnly = true;
            // 
            // ReviseDateCredit
            // 
            this.ReviseDateCredit.HeaderText = "Reverse Date";
            this.ReviseDateCredit.Name = "ReviseDateCredit";
            this.ReviseDateCredit.ReadOnly = true;
            // 
            // ReviseTimeCredit
            // 
            this.ReviseTimeCredit.HeaderText = "Reverse Time";
            this.ReviseTimeCredit.Name = "ReviseTimeCredit";
            this.ReviseTimeCredit.ReadOnly = true;
            // 
            // ItemsPerPageBtnCredit
            // 
            this.ItemsPerPageBtnCredit.BackColor = System.Drawing.Color.Crimson;
            this.ItemsPerPageBtnCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemsPerPageBtnCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtnCredit.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtnCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtnCredit.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtnCredit.Location = new System.Drawing.Point(80, 23);
            this.ItemsPerPageBtnCredit.Name = "ItemsPerPageBtnCredit";
            this.ItemsPerPageBtnCredit.Size = new System.Drawing.Size(61, 24);
            this.ItemsPerPageBtnCredit.TabIndex = 58;
            this.ItemsPerPageBtnCredit.Text = "Change";
            this.ItemsPerPageBtnCredit.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtnCredit.Click += new System.EventHandler(this.ItemsPerPageBtnCredit_Click);
            // 
            // ItemsPerPageTxtBoxCredit
            // 
            this.ItemsPerPageTxtBoxCredit.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBoxCredit.ForeColor = System.Drawing.Color.Crimson;
            this.ItemsPerPageTxtBoxCredit.Location = new System.Drawing.Point(14, 26);
            this.ItemsPerPageTxtBoxCredit.Name = "ItemsPerPageTxtBoxCredit";
            this.ItemsPerPageTxtBoxCredit.Size = new System.Drawing.Size(60, 20);
            this.ItemsPerPageTxtBoxCredit.TabIndex = 56;
            this.ItemsPerPageTxtBoxCredit.Text = "10";
            // 
            // TotalITemsTxtBoxCredit
            // 
            this.TotalITemsTxtBoxCredit.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBoxCredit.ForeColor = System.Drawing.Color.Crimson;
            this.TotalITemsTxtBoxCredit.Location = new System.Drawing.Point(241, 20);
            this.TotalITemsTxtBoxCredit.Name = "TotalITemsTxtBoxCredit";
            this.TotalITemsTxtBoxCredit.ReadOnly = true;
            this.TotalITemsTxtBoxCredit.Size = new System.Drawing.Size(128, 20);
            this.TotalITemsTxtBoxCredit.TabIndex = 57;
            // 
            // PreviousPageCredit
            // 
            this.PreviousPageCredit.BackColor = System.Drawing.Color.Crimson;
            this.PreviousPageCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousPageCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPageCredit.FlatAppearance.BorderSize = 0;
            this.PreviousPageCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPageCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPageCredit.ForeColor = System.Drawing.Color.White;
            this.PreviousPageCredit.Location = new System.Drawing.Point(320, 24);
            this.PreviousPageCredit.Name = "PreviousPageCredit";
            this.PreviousPageCredit.Size = new System.Drawing.Size(31, 23);
            this.PreviousPageCredit.TabIndex = 54;
            this.PreviousPageCredit.Text = "<";
            this.PreviousPageCredit.UseVisualStyleBackColor = false;
            this.PreviousPageCredit.Click += new System.EventHandler(this.PreviousPageCredit_Click);
            // 
            // NextPageCredit
            // 
            this.NextPageCredit.BackColor = System.Drawing.Color.Crimson;
            this.NextPageCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPageCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageCredit.FlatAppearance.BorderSize = 0;
            this.NextPageCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageCredit.ForeColor = System.Drawing.Color.White;
            this.NextPageCredit.Location = new System.Drawing.Point(439, 24);
            this.NextPageCredit.Name = "NextPageCredit";
            this.NextPageCredit.Size = new System.Drawing.Size(30, 23);
            this.NextPageCredit.TabIndex = 55;
            this.NextPageCredit.Text = ">";
            this.NextPageCredit.UseVisualStyleBackColor = false;
            this.NextPageCredit.Click += new System.EventHandler(this.NextPageCredit_Click);
            // 
            // PageOfTotalTxtBoxCredit
            // 
            this.PageOfTotalTxtBoxCredit.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBoxCredit.ForeColor = System.Drawing.Color.Crimson;
            this.PageOfTotalTxtBoxCredit.Location = new System.Drawing.Point(357, 25);
            this.PageOfTotalTxtBoxCredit.Name = "PageOfTotalTxtBoxCredit";
            this.PageOfTotalTxtBoxCredit.ReadOnly = true;
            this.PageOfTotalTxtBoxCredit.Size = new System.Drawing.Size(76, 20);
            this.PageOfTotalTxtBoxCredit.TabIndex = 53;
            // 
            // textBox1Credit
            // 
            this.textBox1Credit.BackColor = System.Drawing.Color.White;
            this.textBox1Credit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.textBox1Credit.Location = new System.Drawing.Point(161, 26);
            this.textBox1Credit.Name = "textBox1Credit";
            this.textBox1Credit.Size = new System.Drawing.Size(61, 20);
            this.textBox1Credit.TabIndex = 52;
            this.textBox1Credit.Text = "1";
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalPagesLbl.Location = new System.Drawing.Point(380, 6);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(31, 13);
            this.TotalPagesLbl.TabIndex = 51;
            this.TotalPagesLbl.Text = "Page";
            // 
            // NextPageBtnCredit
            // 
            this.NextPageBtnCredit.BackColor = System.Drawing.Color.Crimson;
            this.NextPageBtnCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPageBtnCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageBtnCredit.FlatAppearance.BorderSize = 0;
            this.NextPageBtnCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBtnCredit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageBtnCredit.ForeColor = System.Drawing.Color.White;
            this.NextPageBtnCredit.Location = new System.Drawing.Point(228, 24);
            this.NextPageBtnCredit.Name = "NextPageBtnCredit";
            this.NextPageBtnCredit.Size = new System.Drawing.Size(61, 23);
            this.NextPageBtnCredit.TabIndex = 50;
            this.NextPageBtnCredit.Text = "Go";
            this.NextPageBtnCredit.UseVisualStyleBackColor = false;
            this.NextPageBtnCredit.Click += new System.EventHandler(this.NextPageBtnCredit_Click);
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.Crimson;
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(14, 7);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(91, 13);
            this.ItemsPerPageLbl.TabIndex = 48;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalItemsLbl.Location = new System.Drawing.Point(245, 4);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(58, 13);
            this.TotalItemsLbl.TabIndex = 49;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(214, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "TotalItems";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "# Items Per Page";
            // 
            // NextPageBtnDebit
            // 
            this.NextPageBtnDebit.BackColor = System.Drawing.Color.Crimson;
            this.NextPageBtnDebit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPageBtnDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageBtnDebit.FlatAppearance.BorderSize = 0;
            this.NextPageBtnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageBtnDebit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageBtnDebit.ForeColor = System.Drawing.Color.White;
            this.NextPageBtnDebit.Location = new System.Drawing.Point(199, 21);
            this.NextPageBtnDebit.Name = "NextPageBtnDebit";
            this.NextPageBtnDebit.Size = new System.Drawing.Size(60, 23);
            this.NextPageBtnDebit.TabIndex = 50;
            this.NextPageBtnDebit.Text = "Go";
            this.NextPageBtnDebit.UseVisualStyleBackColor = false;
            this.NextPageBtnDebit.Click += new System.EventHandler(this.NextPageBtnDebit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(331, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Page";
            // 
            // textBox1Debit
            // 
            this.textBox1Debit.BackColor = System.Drawing.Color.White;
            this.textBox1Debit.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1Debit.Location = new System.Drawing.Point(135, 22);
            this.textBox1Debit.Name = "textBox1Debit";
            this.textBox1Debit.Size = new System.Drawing.Size(60, 20);
            this.textBox1Debit.TabIndex = 52;
            this.textBox1Debit.Text = "1";
            // 
            // PageOfTotalTxtBoxDebit
            // 
            this.PageOfTotalTxtBoxDebit.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBoxDebit.ForeColor = System.Drawing.Color.Crimson;
            this.PageOfTotalTxtBoxDebit.Location = new System.Drawing.Point(317, 22);
            this.PageOfTotalTxtBoxDebit.Name = "PageOfTotalTxtBoxDebit";
            this.PageOfTotalTxtBoxDebit.ReadOnly = true;
            this.PageOfTotalTxtBoxDebit.Size = new System.Drawing.Size(57, 20);
            this.PageOfTotalTxtBoxDebit.TabIndex = 53;
            // 
            // NextPageDebit
            // 
            this.NextPageDebit.BackColor = System.Drawing.Color.Crimson;
            this.NextPageDebit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextPageDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPageDebit.FlatAppearance.BorderSize = 0;
            this.NextPageDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPageDebit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageDebit.ForeColor = System.Drawing.Color.White;
            this.NextPageDebit.Location = new System.Drawing.Point(377, 21);
            this.NextPageDebit.Name = "NextPageDebit";
            this.NextPageDebit.Size = new System.Drawing.Size(30, 23);
            this.NextPageDebit.TabIndex = 55;
            this.NextPageDebit.Text = ">";
            this.NextPageDebit.UseVisualStyleBackColor = false;
            this.NextPageDebit.Click += new System.EventHandler(this.NextPageDebit_Click);
            // 
            // PreviousPageDebit
            // 
            this.PreviousPageDebit.BackColor = System.Drawing.Color.Crimson;
            this.PreviousPageDebit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousPageDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPageDebit.FlatAppearance.BorderSize = 0;
            this.PreviousPageDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPageDebit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPageDebit.ForeColor = System.Drawing.Color.White;
            this.PreviousPageDebit.Location = new System.Drawing.Point(283, 21);
            this.PreviousPageDebit.Name = "PreviousPageDebit";
            this.PreviousPageDebit.Size = new System.Drawing.Size(31, 23);
            this.PreviousPageDebit.TabIndex = 54;
            this.PreviousPageDebit.Text = "<";
            this.PreviousPageDebit.UseVisualStyleBackColor = false;
            this.PreviousPageDebit.Click += new System.EventHandler(this.PreviousPageDebit_Click);
            // 
            // TotalITemsTxtBoxDebit
            // 
            this.TotalITemsTxtBoxDebit.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBoxDebit.ForeColor = System.Drawing.Color.Crimson;
            this.TotalITemsTxtBoxDebit.Location = new System.Drawing.Point(209, 25);
            this.TotalITemsTxtBoxDebit.Name = "TotalITemsTxtBoxDebit";
            this.TotalITemsTxtBoxDebit.ReadOnly = true;
            this.TotalITemsTxtBoxDebit.Size = new System.Drawing.Size(124, 20);
            this.TotalITemsTxtBoxDebit.TabIndex = 57;
            // 
            // ItemsPerPageTxtBoxDebit
            // 
            this.ItemsPerPageTxtBoxDebit.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBoxDebit.ForeColor = System.Drawing.Color.Crimson;
            this.ItemsPerPageTxtBoxDebit.Location = new System.Drawing.Point(10, 22);
            this.ItemsPerPageTxtBoxDebit.Name = "ItemsPerPageTxtBoxDebit";
            this.ItemsPerPageTxtBoxDebit.Size = new System.Drawing.Size(57, 20);
            this.ItemsPerPageTxtBoxDebit.TabIndex = 56;
            this.ItemsPerPageTxtBoxDebit.Text = "10";
            // 
            // ItemsPerPageBtnDebit
            // 
            this.ItemsPerPageBtnDebit.BackColor = System.Drawing.Color.Crimson;
            this.ItemsPerPageBtnDebit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemsPerPageBtnDebit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtnDebit.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtnDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtnDebit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtnDebit.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtnDebit.Location = new System.Drawing.Point(71, 21);
            this.ItemsPerPageBtnDebit.Name = "ItemsPerPageBtnDebit";
            this.ItemsPerPageBtnDebit.Size = new System.Drawing.Size(60, 22);
            this.ItemsPerPageBtnDebit.TabIndex = 58;
            this.ItemsPerPageBtnDebit.Text = "Change";
            this.ItemsPerPageBtnDebit.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtnDebit.Click += new System.EventHandler(this.ItemsPerPageBtnDebit_Click);
            // 
            // DebitDGView
            // 
            this.DebitDGView.AllowUserToAddRows = false;
            this.DebitDGView.AllowUserToDeleteRows = false;
            this.DebitDGView.BackgroundColor = System.Drawing.Color.White;
            this.DebitDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DebitDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DebitDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DebitDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeDbt,
            this.Number,
            this.Date,
            this.BillTime,
            this.TotalCost,
            this.TotalPrice,
            this.Comments,
            this.CustomerID,
            this.TotalItems,
            this.TellerID,
            this.TotalTax,
            this.PriceLevelID,
            this.PaymentMethodID,
            this.SalesDiscount,
            this.DiscountPerc,
            this.CashIn,
            this.TotalDiscount,
            this.IsRevised,
            this.IsChecked,
            this.CheckedBy,
            this.CheckedDate,
            this.ReviseDate,
            this.RevisedBy,
            this.ReviseLoss});
            this.DebitDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebitDGView.Location = new System.Drawing.Point(0, 57);
            this.DebitDGView.Name = "DebitDGView";
            this.DebitDGView.ReadOnly = true;
            this.DebitDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DebitDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DebitDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DebitDGView.Size = new System.Drawing.Size(427, 412);
            this.DebitDGView.TabIndex = 59;
            this.DebitDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DebitDGView_CellDoubleClick);
            // 
            // TypeDbt
            // 
            this.TypeDbt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TypeDbt.HeaderText = "Type";
            this.TypeDbt.Name = "TypeDbt";
            this.TypeDbt.ReadOnly = true;
            this.TypeDbt.Width = 56;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.DefaultCellStyle = dataGridViewCellStyle1;
            this.Number.HeaderText = "Invoice #";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 72;
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
            this.BillTime.HeaderText = "BillTime";
            this.BillTime.Name = "BillTime";
            this.BillTime.ReadOnly = true;
            this.BillTime.Visible = false;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalCost.HeaderText = "TotalCost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            this.TotalCost.Visible = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalPrice.HeaderText = "Amount";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 69;
            // 
            // Comments
            // 
            this.Comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Comments.HeaderText = "Comments";
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 82;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.HeaderText = "Customer Name";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Width = 99;
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalItems.HeaderText = "TotalItems";
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.ReadOnly = true;
            this.TotalItems.Visible = false;
            // 
            // TellerID
            // 
            this.TellerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TellerID.HeaderText = "Teller";
            this.TellerID.Name = "TellerID";
            this.TellerID.ReadOnly = true;
            this.TellerID.Width = 58;
            // 
            // TotalTax
            // 
            this.TotalTax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalTax.HeaderText = "TotalTax";
            this.TotalTax.Name = "TotalTax";
            this.TotalTax.ReadOnly = true;
            this.TotalTax.Visible = false;
            // 
            // PriceLevelID
            // 
            this.PriceLevelID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceLevelID.HeaderText = "PriceLevelID";
            this.PriceLevelID.Name = "PriceLevelID";
            this.PriceLevelID.ReadOnly = true;
            this.PriceLevelID.Visible = false;
            // 
            // PaymentMethodID
            // 
            this.PaymentMethodID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaymentMethodID.HeaderText = "Payment Method";
            this.PaymentMethodID.Name = "PaymentMethodID";
            this.PaymentMethodID.ReadOnly = true;
            this.PaymentMethodID.Width = 104;
            // 
            // SalesDiscount
            // 
            this.SalesDiscount.HeaderText = "SalesDiscount";
            this.SalesDiscount.Name = "SalesDiscount";
            this.SalesDiscount.ReadOnly = true;
            this.SalesDiscount.Visible = false;
            // 
            // DiscountPerc
            // 
            this.DiscountPerc.HeaderText = "DiscountPerc";
            this.DiscountPerc.Name = "DiscountPerc";
            this.DiscountPerc.ReadOnly = true;
            this.DiscountPerc.Visible = false;
            // 
            // CashIn
            // 
            this.CashIn.HeaderText = "CashIn";
            this.CashIn.Name = "CashIn";
            this.CashIn.ReadOnly = true;
            this.CashIn.Visible = false;
            // 
            // TotalDiscount
            // 
            this.TotalDiscount.HeaderText = "TotalDiscount";
            this.TotalDiscount.Name = "TotalDiscount";
            this.TotalDiscount.ReadOnly = true;
            this.TotalDiscount.Visible = false;
            // 
            // IsRevised
            // 
            this.IsRevised.HeaderText = "Reversed";
            this.IsRevised.Name = "IsRevised";
            this.IsRevised.ReadOnly = true;
            // 
            // IsChecked
            // 
            this.IsChecked.HeaderText = "Checked";
            this.IsChecked.Name = "IsChecked";
            this.IsChecked.ReadOnly = true;
            // 
            // CheckedBy
            // 
            this.CheckedBy.HeaderText = "Checked By";
            this.CheckedBy.Name = "CheckedBy";
            this.CheckedBy.ReadOnly = true;
            // 
            // CheckedDate
            // 
            this.CheckedDate.HeaderText = "Check Date";
            this.CheckedDate.Name = "CheckedDate";
            this.CheckedDate.ReadOnly = true;
            // 
            // ReviseDate
            // 
            this.ReviseDate.HeaderText = "Reverse Date";
            this.ReviseDate.Name = "ReviseDate";
            this.ReviseDate.ReadOnly = true;
            // 
            // RevisedBy
            // 
            this.RevisedBy.HeaderText = "Reversed By";
            this.RevisedBy.Name = "RevisedBy";
            this.RevisedBy.ReadOnly = true;
            // 
            // ReviseLoss
            // 
            this.ReviseLoss.HeaderText = "Reverse Loss";
            this.ReviseLoss.Name = "ReviseLoss";
            this.ReviseLoss.ReadOnly = true;
            // 
            // TotalBillsPriceLbl
            // 
            this.TotalBillsPriceLbl.AutoSize = true;
            this.TotalBillsPriceLbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalBillsPriceLbl.Location = new System.Drawing.Point(86, 7);
            this.TotalBillsPriceLbl.Name = "TotalBillsPriceLbl";
            this.TotalBillsPriceLbl.Size = new System.Drawing.Size(99, 13);
            this.TotalBillsPriceLbl.TabIndex = 60;
            this.TotalBillsPriceLbl.Text = "Total Debit Amount";
            // 
            // TotalDebitPriceTxtBox
            // 
            this.TotalDebitPriceTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalDebitPriceTxtBox.ForeColor = System.Drawing.Color.Crimson;
            this.TotalDebitPriceTxtBox.Location = new System.Drawing.Point(82, 25);
            this.TotalDebitPriceTxtBox.Name = "TotalDebitPriceTxtBox";
            this.TotalDebitPriceTxtBox.Size = new System.Drawing.Size(123, 20);
            this.TotalDebitPriceTxtBox.TabIndex = 52;
            this.TotalDebitPriceTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalCreditTxtBox
            // 
            this.TotalCreditTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalCreditTxtBox.ForeColor = System.Drawing.Color.Crimson;
            this.TotalCreditTxtBox.Location = new System.Drawing.Point(108, 20);
            this.TotalCreditTxtBox.Name = "TotalCreditTxtBox";
            this.TotalCreditTxtBox.Size = new System.Drawing.Size(127, 20);
            this.TotalCreditTxtBox.TabIndex = 52;
            // 
            // TotalCreditLbl
            // 
            this.TotalCreditLbl.AutoSize = true;
            this.TotalCreditLbl.ForeColor = System.Drawing.Color.Crimson;
            this.TotalCreditLbl.Location = new System.Drawing.Point(110, 6);
            this.TotalCreditLbl.Name = "TotalCreditLbl";
            this.TotalCreditLbl.Size = new System.Drawing.Size(103, 13);
            this.TotalCreditLbl.TabIndex = 60;
            this.TotalCreditLbl.Text = "Total Credit Amount";
            // 
            // MatchBalanceButton
            // 
            this.MatchBalanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MatchBalanceButton.BackColor = System.Drawing.Color.Crimson;
            this.MatchBalanceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MatchBalanceButton.FlatAppearance.BorderSize = 0;
            this.MatchBalanceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatchBalanceButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchBalanceButton.ForeColor = System.Drawing.Color.White;
            this.MatchBalanceButton.Location = new System.Drawing.Point(647, 85);
            this.MatchBalanceButton.Name = "MatchBalanceButton";
            this.MatchBalanceButton.Size = new System.Drawing.Size(121, 83);
            this.MatchBalanceButton.TabIndex = 61;
            this.MatchBalanceButton.Text = "Reconcile Now";
            this.MatchBalanceButton.UseVisualStyleBackColor = false;
            this.MatchBalanceButton.Click += new System.EventHandler(this.MatchBalanceButton_Click);
            // 
            // CustomerNameComboBox
            // 
            this.CustomerNameComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerNameComboBox.DataSource = this.customerBindingSource;
            this.CustomerNameComboBox.DisplayMember = "Name";
            this.CustomerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerNameComboBox.ForeColor = System.Drawing.Color.Crimson;
            this.CustomerNameComboBox.FormattingEnabled = true;
            this.CustomerNameComboBox.Location = new System.Drawing.Point(10, 47);
            this.CustomerNameComboBox.Name = "CustomerNameComboBox";
            this.CustomerNameComboBox.Size = new System.Drawing.Size(287, 21);
            this.CustomerNameComboBox.TabIndex = 116;
            this.CustomerNameComboBox.ValueMember = "Phone1";
            this.CustomerNameComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomerNameComboBox_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dBDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomerLbl
            // 
            this.AddCustomerLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCustomerLbl.AutoSize = true;
            this.AddCustomerLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerLbl.ForeColor = System.Drawing.Color.Crimson;
            this.AddCustomerLbl.Location = new System.Drawing.Point(645, 43);
            this.AddCustomerLbl.Name = "AddCustomerLbl";
            this.AddCustomerLbl.Size = new System.Drawing.Size(258, 25);
            this.AddCustomerLbl.TabIndex = 62;
            this.AddCustomerLbl.Text = "Customer Reconciliation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.CustomerNameComboBox);
            this.panel1.Controls.Add(this.AddCustomerLbl);
            this.panel1.Controls.Add(this.MatchBalanceButton);
            this.panel1.Controls.Add(this.FiltersGB);
            this.panel1.Controls.Add(this.ListDCBtn);
            this.panel1.Controls.Add(this.AccountBalnaceLbl);
            this.panel1.Controls.Add(this.CustomerNameLbl);
            this.panel1.Controls.Add(this.CustomerPhoneLbl);
            this.panel1.Controls.Add(this.CustomerBalanceTxtBox);
            this.panel1.Controls.Add(this.CustomerPhoneTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 182);
            this.panel1.TabIndex = 117;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CreditDGView);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(429, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 518);
            this.panel2.TabIndex = 118;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.TotalCreditLbl);
            this.panel4.Controls.Add(this.CreditLbl);
            this.panel4.Controls.Add(this.TotalITemsTxtBoxCredit);
            this.panel4.Controls.Add(this.TotalCreditTxtBox);
            this.panel4.Controls.Add(this.TotalItemsLbl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 57);
            this.panel4.TabIndex = 61;
            // 
            // CreditLbl
            // 
            this.CreditLbl.AutoSize = true;
            this.CreditLbl.BackColor = System.Drawing.Color.Transparent;
            this.CreditLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditLbl.ForeColor = System.Drawing.Color.Crimson;
            this.CreditLbl.Location = new System.Drawing.Point(17, 17);
            this.CreditLbl.Name = "CreditLbl";
            this.CreditLbl.Size = new System.Drawing.Size(59, 21);
            this.CreditLbl.TabIndex = 62;
            this.CreditLbl.Text = "Credit";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.ItemsPerPageBtnCredit);
            this.panel8.Controls.Add(this.NextPageBtnCredit);
            this.panel8.Controls.Add(this.TotalPagesLbl);
            this.panel8.Controls.Add(this.ItemsPerPageTxtBoxCredit);
            this.panel8.Controls.Add(this.textBox1Credit);
            this.panel8.Controls.Add(this.ItemsPerPageLbl);
            this.panel8.Controls.Add(this.PageOfTotalTxtBoxCredit);
            this.panel8.Controls.Add(this.NextPageCredit);
            this.panel8.Controls.Add(this.PreviousPageCredit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 469);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(498, 49);
            this.panel8.TabIndex = 62;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DebitDGView);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 518);
            this.panel3.TabIndex = 119;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.TotalBillsPriceLbl);
            this.panel5.Controls.Add(this.DebitLbl);
            this.panel5.Controls.Add(this.TotalITemsTxtBoxDebit);
            this.panel5.Controls.Add(this.TotalDebitPriceTxtBox);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 57);
            this.panel5.TabIndex = 61;
            // 
            // DebitLbl
            // 
            this.DebitLbl.AutoSize = true;
            this.DebitLbl.BackColor = System.Drawing.Color.Transparent;
            this.DebitLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitLbl.ForeColor = System.Drawing.Color.Crimson;
            this.DebitLbl.Location = new System.Drawing.Point(14, 17);
            this.DebitLbl.Name = "DebitLbl";
            this.DebitLbl.Size = new System.Drawing.Size(53, 21);
            this.DebitLbl.TabIndex = 62;
            this.DebitLbl.Text = "Debit";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.NextPageBtnDebit);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.ItemsPerPageBtnDebit);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.ItemsPerPageTxtBoxDebit);
            this.panel7.Controls.Add(this.textBox1Debit);
            this.panel7.Controls.Add(this.PageOfTotalTxtBoxDebit);
            this.panel7.Controls.Add(this.PreviousPageDebit);
            this.panel7.Controls.Add(this.NextPageDebit);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 469);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(427, 49);
            this.panel7.TabIndex = 62;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 182);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(927, 518);
            this.panel6.TabIndex = 120;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerDebitCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(927, 700);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CustomerDebitCredit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Reconciliation";
            this.Load += new System.EventHandler(this.CustomerDebitCredit_Load);
            this.FiltersGB.ResumeLayout(false);
            this.FiltersGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitDGView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AccountBalnaceLbl;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.TextBox CustomerBalanceTxtBox;
        private System.Windows.Forms.TextBox CustomerPhoneTxtBox;
        private System.Windows.Forms.GroupBox FiltersGB;
        private System.Windows.Forms.CheckBox UnRevisedChkBox;
        private System.Windows.Forms.CheckBox UnCheckedChkBox;
        private System.Windows.Forms.CheckBox RevisedChkBox;
        private System.Windows.Forms.CheckBox CheckChkBox;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.DateTimePicker DateFrompicker;
        private System.Windows.Forms.Label DateToLbl;
        private System.Windows.Forms.Label DateFromLbl;
        private System.Windows.Forms.CheckBox DateCheckBox;
        private System.Windows.Forms.ComboBox TellerNameComboBox;
        private System.Windows.Forms.CheckBox TellerNameChkBox;
        private System.Windows.Forms.Button ListDCBtn;
        private System.Windows.Forms.DataGridView CreditDGView;
        private System.Windows.Forms.Button ItemsPerPageBtnCredit;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBoxCredit;
        private System.Windows.Forms.TextBox TotalITemsTxtBoxCredit;
        private System.Windows.Forms.Button PreviousPageCredit;
        private System.Windows.Forms.Button NextPageCredit;
        private System.Windows.Forms.TextBox PageOfTotalTxtBoxCredit;
        private System.Windows.Forms.TextBox textBox1Credit;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Button NextPageBtnCredit;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalItemsLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextPageBtnDebit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Debit;
        private System.Windows.Forms.TextBox PageOfTotalTxtBoxDebit;
        private System.Windows.Forms.Button NextPageDebit;
        private System.Windows.Forms.Button PreviousPageDebit;
        private System.Windows.Forms.TextBox TotalITemsTxtBoxDebit;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBoxDebit;
        private System.Windows.Forms.Button ItemsPerPageBtnDebit;
        private System.Windows.Forms.DataGridView DebitDGView;
        private System.Windows.Forms.CheckBox CreditBillsChkBox;
        private System.Windows.Forms.Label TotalBillsPriceLbl;
        private System.Windows.Forms.TextBox TotalDebitPriceTxtBox;
        private System.Windows.Forms.TextBox TotalCreditTxtBox;
        private System.Windows.Forms.Label TotalCreditLbl;
        private System.Windows.Forms.Button MatchBalanceButton;
        private System.Windows.Forms.ComboBox CustomerNameComboBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Label AddCustomerLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label CreditLbl;
        private System.Windows.Forms.Label DebitLbl;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentsCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIDCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TellerCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldAmountCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsCheckedCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedByCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckDateCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckTimeCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRevisedCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisedByCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseDateCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseTimeCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDbt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn TellerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceLevelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethodID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRevised;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReviseLoss;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}