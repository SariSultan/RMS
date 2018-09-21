namespace Calcium_RMS
{
    partial class PurchaseVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseVoucher));
            this.FeesLbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.AddVoucherNoPrintBtn = new System.Windows.Forms.Button();
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.DiscountLbl = new System.Windows.Forms.Label();
            this.DiscountTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.FeesTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FreeItemsQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddVoucherAndPrintBtn = new System.Windows.Forms.Button();
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.DiscountOnVouPercLbl = new System.Windows.Forms.Label();
            this.DiscountPercTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTaxTxtBox = new System.Windows.Forms.TextBox();
            this.TaxLbl = new System.Windows.Forms.Label();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.VendorsTableAdapter();
            this.ItemsDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsDiscountLbl = new System.Windows.Forms.Label();
            this.TotalDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.TotalDiscountLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet2 = new Calcium_RMS.DBDataSet();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.VendorsComboBox = new System.Windows.Forms.ComboBox();
            this.ItemDescriptionLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.VendorLbl = new System.Windows.Forms.Label();
            this.PurchaseVoucherNumTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaymentMethodCheckBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentMethodDescripTxtBox = new System.Windows.Forms.TextBox();
            this.AccountDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentMethodLbl = new System.Windows.Forms.Label();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.CashPaymentGB = new System.Windows.Forms.GroupBox();
            this.IsCreditLbl = new System.Windows.Forms.Label();
            this.CashMethodComboBox = new System.Windows.Forms.ComboBox();
            this.CashInCurrency = new System.Windows.Forms.Label();
            this.CashMethodLbl = new System.Windows.Forms.Label();
            this.JODstatic = new System.Windows.Forms.Label();
            this.ExchangeTxtBox = new System.Windows.Forms.TextBox();
            this.ExchangeLbl = new System.Windows.Forms.Label();
            this.CashInTxtBox = new System.Windows.Forms.TextBox();
            this.CashInLbl = new System.Windows.Forms.Label();
            this.PayInVisaGB = new System.Windows.Forms.GroupBox();
            this.CreditCardInfoTxtBox = new System.Windows.Forms.TextBox();
            this.PaymentCommentsLbl = new System.Windows.Forms.Label();
            this.CheckGB = new System.Windows.Forms.GroupBox();
            this.CheckDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckCommentsTxtBox = new System.Windows.Forms.TextBox();
            this.HolderNameTxtBox = new System.Windows.Forms.TextBox();
            this.CheckCommentsLbl = new System.Windows.Forms.Label();
            this.CheckNumberTxtBox = new System.Windows.Forms.TextBox();
            this.CheckHolderNameLbl = new System.Windows.Forms.Label();
            this.PaymentDateLbl = new System.Windows.Forms.Label();
            this.CheckNumber = new System.Windows.Forms.Label();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendorAccountAmountLbl = new System.Windows.Forms.Label();
            this.VendorAccountAmountTxtBox = new System.Windows.Forms.TextBox();
            this.accountsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.AccountsTableAdapter();
            this.paymentMethodTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PaymentMethodTableAdapter();
            this.currencyTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CurrencyTableAdapter();
            this.VoucherNumberLbl = new System.Windows.Forms.Label();
            this.VendorDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.CompanyLbl = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.ItemsWithoutBarcodeLbl = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            this.AddNewItemLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WithoutAddBtn = new System.Windows.Forms.Button();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionAddBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.OpenCashBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PrintingThermalA4ChkBox = new System.Windows.Forms.CheckBox();
            this.ReturnChkBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.CashPaymentGB.SuspendLayout();
            this.PayInVisaGB.SuspendLayout();
            this.CheckGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FeesLbl
            // 
            this.FeesLbl.AutoSize = true;
            this.FeesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesLbl.ForeColor = System.Drawing.Color.Indigo;
            this.FeesLbl.Location = new System.Drawing.Point(12, 175);
            this.FeesLbl.Name = "FeesLbl";
            this.FeesLbl.Size = new System.Drawing.Size(32, 14);
            this.FeesLbl.TabIndex = 27;
            this.FeesLbl.Text = "Fees";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.Indigo;
            this.SubtotalLbl.Location = new System.Drawing.Point(12, 5);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(53, 14);
            this.SubtotalLbl.TabIndex = 25;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // AddVoucherNoPrintBtn
            // 
            this.AddVoucherNoPrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVoucherNoPrintBtn.BackColor = System.Drawing.Color.Indigo;
            this.AddVoucherNoPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVoucherNoPrintBtn.FlatAppearance.BorderSize = 0;
            this.AddVoucherNoPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVoucherNoPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVoucherNoPrintBtn.ForeColor = System.Drawing.Color.White;
            this.AddVoucherNoPrintBtn.Location = new System.Drawing.Point(502, 81);
            this.AddVoucherNoPrintBtn.Name = "AddVoucherNoPrintBtn";
            this.AddVoucherNoPrintBtn.Size = new System.Drawing.Size(173, 24);
            this.AddVoucherNoPrintBtn.TabIndex = 2;
            this.AddVoucherNoPrintBtn.Text = "Save";
            this.AddVoucherNoPrintBtn.UseVisualStyleBackColor = false;
            this.AddVoucherNoPrintBtn.Click += new System.EventHandler(this.AddVoucherNoPrintBtn_Click);
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.Indigo;
            this.TotalBillLbl.Location = new System.Drawing.Point(132, 197);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(80, 25);
            this.TotalBillLbl.TabIndex = 24;
            this.TotalBillLbl.Text = "TOTAL";
            // 
            // DiscountLbl
            // 
            this.DiscountLbl.AutoSize = true;
            this.DiscountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DiscountLbl.Location = new System.Drawing.Point(12, 91);
            this.DiscountLbl.Name = "DiscountLbl";
            this.DiscountLbl.Size = new System.Drawing.Size(54, 14);
            this.DiscountLbl.TabIndex = 26;
            this.DiscountLbl.Text = "Discount";
            // 
            // DiscountTxtBox
            // 
            this.DiscountTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.DiscountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.DiscountTxtBox.Location = new System.Drawing.Point(167, 89);
            this.DiscountTxtBox.Name = "DiscountTxtBox";
            this.DiscountTxtBox.ReadOnly = true;
            this.DiscountTxtBox.Size = new System.Drawing.Size(162, 21);
            this.DiscountTxtBox.TabIndex = 21;
            this.DiscountTxtBox.Text = "0";
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.TotalTxtBox.Location = new System.Drawing.Point(0, 225);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(336, 43);
            this.TotalTxtBox.TabIndex = 22;
            this.TotalTxtBox.Text = "0.00";
            this.TotalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FeesTxtBox
            // 
            this.FeesTxtBox.BackColor = System.Drawing.Color.White;
            this.FeesTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeesTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.FeesTxtBox.Location = new System.Drawing.Point(167, 173);
            this.FeesTxtBox.Name = "FeesTxtBox";
            this.FeesTxtBox.Size = new System.Drawing.Size(162, 21);
            this.FeesTxtBox.TabIndex = 1;
            this.FeesTxtBox.Text = "0";
            this.FeesTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateCashBtns);
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.SubtotalTxtBox.Location = new System.Drawing.Point(167, 3);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(162, 21);
            this.SubtotalTxtBox.TabIndex = 20;
            this.SubtotalTxtBox.Text = "0";
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
            this.TeldgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeldgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeldgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.Qty,
            this.PricePerUnit,
            this.DiscountPerc,
            this.Tax,
            this.PriceTotal,
            this.AvalQty,
            this.AvgUnitCost,
            this.FreeItemsQty});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle9;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.Location = new System.Drawing.Point(48, 0);
            this.TeldgView.Name = "TeldgView";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(633, 514);
            this.TeldgView.TabIndex = 19;
            this.TeldgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeldgView_CellValueChanged);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 85;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.PricePerUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.PricePerUnit.HeaderText = "UnitCost";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.Width = 73;
            // 
            // DiscountPerc
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.DiscountPerc.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiscountPerc.HeaderText = "Discount%";
            this.DiscountPerc.Name = "DiscountPerc";
            // 
            // Tax
            // 
            this.Tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tax.HeaderText = "Tax%";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 61;
            // 
            // PriceTotal
            // 
            this.PriceTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.PriceTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.PriceTotal.HeaderText = "Cost*Qty";
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.ReadOnly = true;
            this.PriceTotal.Width = 78;
            // 
            // AvalQty
            // 
            this.AvalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.AvalQty.DefaultCellStyle = dataGridViewCellStyle6;
            this.AvalQty.HeaderText = "AvalQty";
            this.AvalQty.Name = "AvalQty";
            this.AvalQty.ReadOnly = true;
            this.AvalQty.Width = 71;
            // 
            // AvgUnitCost
            // 
            this.AvgUnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.AvgUnitCost.DefaultCellStyle = dataGridViewCellStyle7;
            this.AvgUnitCost.HeaderText = "AvgUnitCost";
            this.AvgUnitCost.Name = "AvgUnitCost";
            this.AvgUnitCost.ReadOnly = true;
            this.AvgUnitCost.Width = 92;
            // 
            // FreeItemsQty
            // 
            this.FreeItemsQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.FreeItemsQty.DefaultCellStyle = dataGridViewCellStyle8;
            this.FreeItemsQty.HeaderText = "FreeItemsQty";
            this.FreeItemsQty.Name = "FreeItemsQty";
            // 
            // AddVoucherAndPrintBtn
            // 
            this.AddVoucherAndPrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVoucherAndPrintBtn.BackColor = System.Drawing.Color.Indigo;
            this.AddVoucherAndPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVoucherAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.AddVoucherAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddVoucherAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVoucherAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.AddVoucherAndPrintBtn.Location = new System.Drawing.Point(502, 111);
            this.AddVoucherAndPrintBtn.Name = "AddVoucherAndPrintBtn";
            this.AddVoucherAndPrintBtn.Size = new System.Drawing.Size(173, 24);
            this.AddVoucherAndPrintBtn.TabIndex = 28;
            this.AddVoucherAndPrintBtn.Text = "Save && Print";
            this.AddVoucherAndPrintBtn.UseVisualStyleBackColor = false;
            this.AddVoucherAndPrintBtn.Click += new System.EventHandler(this.AddVoucherAndPrintBtn_Click);
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiscountOnVouPercLbl
            // 
            this.DiscountOnVouPercLbl.AutoSize = true;
            this.DiscountOnVouPercLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountOnVouPercLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DiscountOnVouPercLbl.Location = new System.Drawing.Point(12, 61);
            this.DiscountOnVouPercLbl.Name = "DiscountOnVouPercLbl";
            this.DiscountOnVouPercLbl.Size = new System.Drawing.Size(137, 14);
            this.DiscountOnVouPercLbl.TabIndex = 32;
            this.DiscountOnVouPercLbl.Text = "Discount Percentage %";
            // 
            // DiscountPercTxtBox
            // 
            this.DiscountPercTxtBox.BackColor = System.Drawing.Color.White;
            this.DiscountPercTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPercTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.DiscountPercTxtBox.Location = new System.Drawing.Point(167, 59);
            this.DiscountPercTxtBox.Name = "DiscountPercTxtBox";
            this.DiscountPercTxtBox.Size = new System.Drawing.Size(162, 23);
            this.DiscountPercTxtBox.TabIndex = 0;
            this.DiscountPercTxtBox.Text = "0";
            this.DiscountPercTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateCashBtns);
            // 
            // TotalTaxTxtBox
            // 
            this.TotalTaxTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.TotalTaxTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.TotalTaxTxtBox.Location = new System.Drawing.Point(167, 145);
            this.TotalTaxTxtBox.Name = "TotalTaxTxtBox";
            this.TotalTaxTxtBox.ReadOnly = true;
            this.TotalTaxTxtBox.Size = new System.Drawing.Size(162, 21);
            this.TotalTaxTxtBox.TabIndex = 23;
            this.TotalTaxTxtBox.Text = "0";
            // 
            // TaxLbl
            // 
            this.TaxLbl.AutoSize = true;
            this.TaxLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLbl.ForeColor = System.Drawing.Color.Indigo;
            this.TaxLbl.Location = new System.Drawing.Point(12, 147);
            this.TaxLbl.Name = "TaxLbl";
            this.TaxLbl.Size = new System.Drawing.Size(63, 14);
            this.TaxLbl.TabIndex = 27;
            this.TaxLbl.Text = "Total Tax ";
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.dBDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsDiscountTxtBox
            // 
            this.ItemsDiscountTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.ItemsDiscountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDiscountTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsDiscountTxtBox.Location = new System.Drawing.Point(167, 31);
            this.ItemsDiscountTxtBox.Name = "ItemsDiscountTxtBox";
            this.ItemsDiscountTxtBox.ReadOnly = true;
            this.ItemsDiscountTxtBox.Size = new System.Drawing.Size(163, 21);
            this.ItemsDiscountTxtBox.TabIndex = 31;
            this.ItemsDiscountTxtBox.Text = "0";
            // 
            // ItemsDiscountLbl
            // 
            this.ItemsDiscountLbl.AutoSize = true;
            this.ItemsDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDiscountLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsDiscountLbl.Location = new System.Drawing.Point(12, 33);
            this.ItemsDiscountLbl.Name = "ItemsDiscountLbl";
            this.ItemsDiscountLbl.Size = new System.Drawing.Size(121, 14);
            this.ItemsDiscountLbl.TabIndex = 32;
            this.ItemsDiscountLbl.Text = "Total Items Discount";
            // 
            // TotalDiscountTxtBox
            // 
            this.TotalDiscountTxtBox.BackColor = System.Drawing.Color.LightGray;
            this.TotalDiscountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.TotalDiscountTxtBox.Location = new System.Drawing.Point(167, 117);
            this.TotalDiscountTxtBox.Name = "TotalDiscountTxtBox";
            this.TotalDiscountTxtBox.ReadOnly = true;
            this.TotalDiscountTxtBox.Size = new System.Drawing.Size(162, 21);
            this.TotalDiscountTxtBox.TabIndex = 23;
            this.TotalDiscountTxtBox.Text = "0";
            // 
            // TotalDiscountLbl
            // 
            this.TotalDiscountLbl.AutoSize = true;
            this.TotalDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountLbl.ForeColor = System.Drawing.Color.Indigo;
            this.TotalDiscountLbl.Location = new System.Drawing.Point(12, 119);
            this.TotalDiscountLbl.Name = "TotalDiscountLbl";
            this.TotalDiscountLbl.Size = new System.Drawing.Size(86, 14);
            this.TotalDiscountLbl.TabIndex = 27;
            this.TotalDiscountLbl.Text = "Total Discount";
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.DataSource = this.itemsBindingSource;
            this.ItemDescriptionComboBox.DisplayMember = "Description";
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(6, 101);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(260, 24);
            this.ItemDescriptionComboBox.TabIndex = 15;
            this.ItemDescriptionComboBox.ValueMember = "Barcode";
            this.ItemDescriptionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemDescriptionComboBox_KeyPress);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dBDataSet2;
            // 
            // DBDataSet
            // 
            this.dBDataSet2.DataSetName = "DBDataSet";
            this.dBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dBDataSet;
            // 
            // VendorsComboBox
            // 
            this.VendorsComboBox.DataSource = this.vendorsBindingSource;
            this.VendorsComboBox.DisplayMember = "Name";
            this.VendorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorsComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.VendorsComboBox.FormattingEnabled = true;
            this.VendorsComboBox.Location = new System.Drawing.Point(314, 58);
            this.VendorsComboBox.Name = "VendorsComboBox";
            this.VendorsComboBox.Size = new System.Drawing.Size(140, 21);
            this.VendorsComboBox.TabIndex = 18;
            this.VendorsComboBox.ValueMember = "ID";
            this.VendorsComboBox.SelectedValueChanged += new System.EventHandler(this.VendorsComboBox_SelectedValueChanged);
            // 
            // ItemDescriptionLbl
            // 
            this.ItemDescriptionLbl.AutoSize = true;
            this.ItemDescriptionLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ItemDescriptionLbl.Location = new System.Drawing.Point(6, 84);
            this.ItemDescriptionLbl.Name = "ItemDescriptionLbl";
            this.ItemDescriptionLbl.Size = new System.Drawing.Size(97, 14);
            this.ItemDescriptionLbl.TabIndex = 17;
            this.ItemDescriptionLbl.Text = "Item Description";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.Indigo;
            this.BarcodeLbl.Location = new System.Drawing.Point(6, 43);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(99, 14);
            this.BarcodeLbl.TabIndex = 16;
            this.BarcodeLbl.Text = "Barcode Scanner";
            // 
            // VendorLbl
            // 
            this.VendorLbl.AutoSize = true;
            this.VendorLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorLbl.ForeColor = System.Drawing.Color.Indigo;
            this.VendorLbl.Location = new System.Drawing.Point(314, 38);
            this.VendorLbl.Name = "VendorLbl";
            this.VendorLbl.Size = new System.Drawing.Size(47, 14);
            this.VendorLbl.TabIndex = 16;
            this.VendorLbl.Text = "Vendor";
            // 
            // PurchaseVoucherNumTxtBox
            // 
            this.PurchaseVoucherNumTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseVoucherNumTxtBox.BackColor = System.Drawing.Color.White;
            this.PurchaseVoucherNumTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseVoucherNumTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.PurchaseVoucherNumTxtBox.Location = new System.Drawing.Point(502, 26);
            this.PurchaseVoucherNumTxtBox.Name = "PurchaseVoucherNumTxtBox";
            this.PurchaseVoucherNumTxtBox.ReadOnly = true;
            this.PurchaseVoucherNumTxtBox.Size = new System.Drawing.Size(173, 21);
            this.PurchaseVoucherNumTxtBox.TabIndex = 30;
            this.PurchaseVoucherNumTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaymentMethodCheckBox);
            this.groupBox1.Controls.Add(this.PaymentMethodDescripTxtBox);
            this.groupBox1.Controls.Add(this.AccountDescriptionTxtBox);
            this.groupBox1.Controls.Add(this.AccountComboBox);
            this.groupBox1.Controls.Add(this.PaymentMethodLbl);
            this.groupBox1.Controls.Add(this.AccountLbl);
            this.groupBox1.Controls.Add(this.CashPaymentGB);
            this.groupBox1.Controls.Add(this.PayInVisaGB);
            this.groupBox1.Controls.Add(this.CheckGB);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(7, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 325);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // PaymentMethodCheckBox
            // 
            this.PaymentMethodCheckBox.DataSource = this.paymentMethodBindingSource;
            this.PaymentMethodCheckBox.DisplayMember = "Name";
            this.PaymentMethodCheckBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodCheckBox.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentMethodCheckBox.FormattingEnabled = true;
            this.PaymentMethodCheckBox.Location = new System.Drawing.Point(12, 84);
            this.PaymentMethodCheckBox.Name = "PaymentMethodCheckBox";
            this.PaymentMethodCheckBox.Size = new System.Drawing.Size(121, 21);
            this.PaymentMethodCheckBox.TabIndex = 20;
            this.PaymentMethodCheckBox.ValueMember = "ID";
            this.PaymentMethodCheckBox.SelectedValueChanged += new System.EventHandler(this.PaymentMethodCheckBox_SelectedValueChanged);
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBDataSet;
            // 
            // PaymentMethodDescripTxtBox
            // 
            this.PaymentMethodDescripTxtBox.BackColor = System.Drawing.Color.White;
            this.PaymentMethodDescripTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodDescripTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentMethodDescripTxtBox.Location = new System.Drawing.Point(139, 84);
            this.PaymentMethodDescripTxtBox.Name = "PaymentMethodDescripTxtBox";
            this.PaymentMethodDescripTxtBox.ReadOnly = true;
            this.PaymentMethodDescripTxtBox.Size = new System.Drawing.Size(149, 21);
            this.PaymentMethodDescripTxtBox.TabIndex = 19;
            // 
            // AccountDescriptionTxtBox
            // 
            this.AccountDescriptionTxtBox.BackColor = System.Drawing.Color.White;
            this.AccountDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDescriptionTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.AccountDescriptionTxtBox.Location = new System.Drawing.Point(139, 37);
            this.AccountDescriptionTxtBox.Name = "AccountDescriptionTxtBox";
            this.AccountDescriptionTxtBox.ReadOnly = true;
            this.AccountDescriptionTxtBox.Size = new System.Drawing.Size(149, 21);
            this.AccountDescriptionTxtBox.TabIndex = 19;
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DataSource = this.accountsBindingSource;
            this.AccountComboBox.DisplayMember = "Name";
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(12, 37);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(121, 21);
            this.AccountComboBox.TabIndex = 8;
            this.AccountComboBox.ValueMember = "ID";
            this.AccountComboBox.SelectedValueChanged += new System.EventHandler(this.AccountComboBox_SelectedValueChanged);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dBDataSet;
            // 
            // PaymentMethodLbl
            // 
            this.PaymentMethodLbl.AutoSize = true;
            this.PaymentMethodLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLbl.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentMethodLbl.Location = new System.Drawing.Point(16, 66);
            this.PaymentMethodLbl.Name = "PaymentMethodLbl";
            this.PaymentMethodLbl.Size = new System.Drawing.Size(97, 14);
            this.PaymentMethodLbl.TabIndex = 12;
            this.PaymentMethodLbl.Text = "PaymentMethod";
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.Indigo;
            this.AccountLbl.Location = new System.Drawing.Point(24, 18);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(84, 14);
            this.AccountLbl.TabIndex = 12;
            this.AccountLbl.Text = "From Account";
            // 
            // CashPaymentGB
            // 
            this.CashPaymentGB.Controls.Add(this.IsCreditLbl);
            this.CashPaymentGB.Controls.Add(this.CashMethodComboBox);
            this.CashPaymentGB.Controls.Add(this.CashInCurrency);
            this.CashPaymentGB.Controls.Add(this.CashMethodLbl);
            this.CashPaymentGB.Controls.Add(this.JODstatic);
            this.CashPaymentGB.Controls.Add(this.ExchangeTxtBox);
            this.CashPaymentGB.Controls.Add(this.ExchangeLbl);
            this.CashPaymentGB.Controls.Add(this.CashInTxtBox);
            this.CashPaymentGB.Controls.Add(this.CashInLbl);
            this.CashPaymentGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentGB.ForeColor = System.Drawing.Color.Indigo;
            this.CashPaymentGB.Location = new System.Drawing.Point(13, 112);
            this.CashPaymentGB.Name = "CashPaymentGB";
            this.CashPaymentGB.Size = new System.Drawing.Size(298, 207);
            this.CashPaymentGB.TabIndex = 11;
            this.CashPaymentGB.TabStop = false;
            this.CashPaymentGB.Text = "PayInCash";
            // 
            // IsCreditLbl
            // 
            this.IsCreditLbl.AutoSize = true;
            this.IsCreditLbl.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsCreditLbl.ForeColor = System.Drawing.Color.Indigo;
            this.IsCreditLbl.Location = new System.Drawing.Point(88, 65);
            this.IsCreditLbl.Name = "IsCreditLbl";
            this.IsCreditLbl.Size = new System.Drawing.Size(125, 42);
            this.IsCreditLbl.TabIndex = 19;
            this.IsCreditLbl.Text = "Credit";
            this.IsCreditLbl.Visible = false;
            // 
            // CashMethodComboBox
            // 
            this.CashMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CashMethodComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.CashMethodComboBox.FormattingEnabled = true;
            this.CashMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Invoice"});
            this.CashMethodComboBox.Location = new System.Drawing.Point(6, 161);
            this.CashMethodComboBox.Name = "CashMethodComboBox";
            this.CashMethodComboBox.Size = new System.Drawing.Size(276, 33);
            this.CashMethodComboBox.TabIndex = 18;
            this.CashMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.CashMethodComboBox_SelectedIndexChanged);
            // 
            // CashInCurrency
            // 
            this.CashInCurrency.AutoSize = true;
            this.CashInCurrency.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInCurrency.ForeColor = System.Drawing.Color.Indigo;
            this.CashInCurrency.Location = new System.Drawing.Point(263, 49);
            this.CashInCurrency.Name = "CashInCurrency";
            this.CashInCurrency.Size = new System.Drawing.Size(29, 14);
            this.CashInCurrency.TabIndex = 8;
            this.CashInCurrency.Text = "JOD";
            // 
            // CashMethodLbl
            // 
            this.CashMethodLbl.AutoSize = true;
            this.CashMethodLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CashMethodLbl.Location = new System.Drawing.Point(10, 140);
            this.CashMethodLbl.Name = "CashMethodLbl";
            this.CashMethodLbl.Size = new System.Drawing.Size(100, 19);
            this.CashMethodLbl.TabIndex = 8;
            this.CashMethodLbl.Text = "Cash Method";
            // 
            // JODstatic
            // 
            this.JODstatic.AutoSize = true;
            this.JODstatic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JODstatic.ForeColor = System.Drawing.Color.Indigo;
            this.JODstatic.Location = new System.Drawing.Point(263, 113);
            this.JODstatic.Name = "JODstatic";
            this.JODstatic.Size = new System.Drawing.Size(29, 14);
            this.JODstatic.TabIndex = 8;
            this.JODstatic.Text = "JOD";
            // 
            // ExchangeTxtBox
            // 
            this.ExchangeTxtBox.BackColor = System.Drawing.Color.White;
            this.ExchangeTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.ExchangeTxtBox.Location = new System.Drawing.Point(9, 104);
            this.ExchangeTxtBox.Name = "ExchangeTxtBox";
            this.ExchangeTxtBox.ReadOnly = true;
            this.ExchangeTxtBox.Size = new System.Drawing.Size(245, 33);
            this.ExchangeTxtBox.TabIndex = 0;
            this.ExchangeTxtBox.TabStop = false;
            // 
            // ExchangeLbl
            // 
            this.ExchangeLbl.AutoSize = true;
            this.ExchangeLbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ExchangeLbl.Location = new System.Drawing.Point(6, 76);
            this.ExchangeLbl.Name = "ExchangeLbl";
            this.ExchangeLbl.Size = new System.Drawing.Size(114, 29);
            this.ExchangeLbl.TabIndex = 6;
            this.ExchangeLbl.Text = "Exhcange";
            // 
            // CashInTxtBox
            // 
            this.CashInTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.CashInTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.CashInTxtBox.Location = new System.Drawing.Point(6, 42);
            this.CashInTxtBox.Name = "CashInTxtBox";
            this.CashInTxtBox.Size = new System.Drawing.Size(251, 33);
            this.CashInTxtBox.TabIndex = 8;
            this.CashInTxtBox.Text = "0.00";
            this.CashInTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashInTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashInTxtBox_KeyPress);
            // 
            // CashInLbl
            // 
            this.CashInLbl.AutoSize = true;
            this.CashInLbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CashInLbl.Location = new System.Drawing.Point(9, 15);
            this.CashInLbl.Name = "CashInLbl";
            this.CashInLbl.Size = new System.Drawing.Size(94, 29);
            this.CashInLbl.TabIndex = 6;
            this.CashInLbl.Text = "Cash In";
            // 
            // PayInVisaGB
            // 
            this.PayInVisaGB.Controls.Add(this.CreditCardInfoTxtBox);
            this.PayInVisaGB.Controls.Add(this.PaymentCommentsLbl);
            this.PayInVisaGB.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayInVisaGB.ForeColor = System.Drawing.Color.Indigo;
            this.PayInVisaGB.Location = new System.Drawing.Point(13, 112);
            this.PayInVisaGB.Name = "PayInVisaGB";
            this.PayInVisaGB.Size = new System.Drawing.Size(298, 207);
            this.PayInVisaGB.TabIndex = 11;
            this.PayInVisaGB.TabStop = false;
            this.PayInVisaGB.Text = "Pay Using Credit Card";
            // 
            // CreditCardInfoTxtBox
            // 
            this.CreditCardInfoTxtBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardInfoTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.CreditCardInfoTxtBox.Location = new System.Drawing.Point(11, 55);
            this.CreditCardInfoTxtBox.Multiline = true;
            this.CreditCardInfoTxtBox.Name = "CreditCardInfoTxtBox";
            this.CreditCardInfoTxtBox.Size = new System.Drawing.Size(277, 125);
            this.CreditCardInfoTxtBox.TabIndex = 7;
            // 
            // PaymentCommentsLbl
            // 
            this.PaymentCommentsLbl.AutoSize = true;
            this.PaymentCommentsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCommentsLbl.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentCommentsLbl.Location = new System.Drawing.Point(133, 36);
            this.PaymentCommentsLbl.Name = "PaymentCommentsLbl";
            this.PaymentCommentsLbl.Size = new System.Drawing.Size(32, 16);
            this.PaymentCommentsLbl.TabIndex = 6;
            this.PaymentCommentsLbl.Text = "Info";
            // 
            // CheckGB
            // 
            this.CheckGB.Controls.Add(this.CheckDatePicker);
            this.CheckGB.Controls.Add(this.CheckCommentsTxtBox);
            this.CheckGB.Controls.Add(this.HolderNameTxtBox);
            this.CheckGB.Controls.Add(this.CheckCommentsLbl);
            this.CheckGB.Controls.Add(this.CheckNumberTxtBox);
            this.CheckGB.Controls.Add(this.CheckHolderNameLbl);
            this.CheckGB.Controls.Add(this.PaymentDateLbl);
            this.CheckGB.Controls.Add(this.CheckNumber);
            this.CheckGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGB.ForeColor = System.Drawing.Color.Indigo;
            this.CheckGB.Location = new System.Drawing.Point(13, 112);
            this.CheckGB.Name = "CheckGB";
            this.CheckGB.Size = new System.Drawing.Size(298, 207);
            this.CheckGB.TabIndex = 11;
            this.CheckGB.TabStop = false;
            this.CheckGB.Text = "Pay Using Credit Card";
            // 
            // CheckDatePicker
            // 
            this.CheckDatePicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckDatePicker.Location = new System.Drawing.Point(156, 42);
            this.CheckDatePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.Name = "CheckDatePicker";
            this.CheckDatePicker.Size = new System.Drawing.Size(131, 21);
            this.CheckDatePicker.TabIndex = 8;
            // 
            // CheckCommentsTxtBox
            // 
            this.CheckCommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.CheckCommentsTxtBox.Location = new System.Drawing.Point(9, 138);
            this.CheckCommentsTxtBox.Multiline = true;
            this.CheckCommentsTxtBox.Name = "CheckCommentsTxtBox";
            this.CheckCommentsTxtBox.Size = new System.Drawing.Size(278, 59);
            this.CheckCommentsTxtBox.TabIndex = 7;
            // 
            // HolderNameTxtBox
            // 
            this.HolderNameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolderNameTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.HolderNameTxtBox.Location = new System.Drawing.Point(9, 89);
            this.HolderNameTxtBox.Name = "HolderNameTxtBox";
            this.HolderNameTxtBox.Size = new System.Drawing.Size(278, 21);
            this.HolderNameTxtBox.TabIndex = 7;
            // 
            // CheckCommentsLbl
            // 
            this.CheckCommentsLbl.AutoSize = true;
            this.CheckCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CheckCommentsLbl.Location = new System.Drawing.Point(114, 118);
            this.CheckCommentsLbl.Name = "CheckCommentsLbl";
            this.CheckCommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CheckCommentsLbl.TabIndex = 6;
            this.CheckCommentsLbl.Text = "Comments";
            // 
            // CheckNumberTxtBox
            // 
            this.CheckNumberTxtBox.BackColor = System.Drawing.Color.White;
            this.CheckNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumberTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.CheckNumberTxtBox.Location = new System.Drawing.Point(9, 42);
            this.CheckNumberTxtBox.Name = "CheckNumberTxtBox";
            this.CheckNumberTxtBox.ReadOnly = true;
            this.CheckNumberTxtBox.Size = new System.Drawing.Size(131, 21);
            this.CheckNumberTxtBox.TabIndex = 7;
            // 
            // CheckHolderNameLbl
            // 
            this.CheckHolderNameLbl.AutoSize = true;
            this.CheckHolderNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHolderNameLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CheckHolderNameLbl.Location = new System.Drawing.Point(101, 70);
            this.CheckHolderNameLbl.Name = "CheckHolderNameLbl";
            this.CheckHolderNameLbl.Size = new System.Drawing.Size(77, 14);
            this.CheckHolderNameLbl.TabIndex = 6;
            this.CheckHolderNameLbl.Text = "Holder Name";
            // 
            // PaymentDateLbl
            // 
            this.PaymentDateLbl.AutoSize = true;
            this.PaymentDateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDateLbl.ForeColor = System.Drawing.Color.Indigo;
            this.PaymentDateLbl.Location = new System.Drawing.Point(172, 24);
            this.PaymentDateLbl.Name = "PaymentDateLbl";
            this.PaymentDateLbl.Size = new System.Drawing.Size(85, 14);
            this.PaymentDateLbl.TabIndex = 6;
            this.PaymentDateLbl.Text = "Payment Date";
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSize = true;
            this.CheckNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber.ForeColor = System.Drawing.Color.Indigo;
            this.CheckNumber.Location = new System.Drawing.Point(23, 24);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(83, 14);
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.Text = "CheckNumber";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.dBDataSet;
            // 
            // VendorAccountAmountLbl
            // 
            this.VendorAccountAmountLbl.AutoSize = true;
            this.VendorAccountAmountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorAccountAmountLbl.ForeColor = System.Drawing.Color.Indigo;
            this.VendorAccountAmountLbl.Location = new System.Drawing.Point(314, 133);
            this.VendorAccountAmountLbl.Name = "VendorAccountAmountLbl";
            this.VendorAccountAmountLbl.Size = new System.Drawing.Size(101, 14);
            this.VendorAccountAmountLbl.TabIndex = 16;
            this.VendorAccountAmountLbl.Text = "Account Amount";
            // 
            // VendorAccountAmountTxtBox
            // 
            this.VendorAccountAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorAccountAmountTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.VendorAccountAmountTxtBox.Location = new System.Drawing.Point(314, 153);
            this.VendorAccountAmountTxtBox.Name = "VendorAccountAmountTxtBox";
            this.VendorAccountAmountTxtBox.Size = new System.Drawing.Size(140, 21);
            this.VendorAccountAmountTxtBox.TabIndex = 31;
            this.VendorAccountAmountTxtBox.Text = "0";
            this.VendorAccountAmountTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateCashBtns);
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // VoucherNumberLbl
            // 
            this.VoucherNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VoucherNumberLbl.AutoSize = true;
            this.VoucherNumberLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoucherNumberLbl.ForeColor = System.Drawing.Color.Indigo;
            this.VoucherNumberLbl.Location = new System.Drawing.Point(499, 9);
            this.VoucherNumberLbl.Name = "VoucherNumberLbl";
            this.VoucherNumberLbl.Size = new System.Drawing.Size(67, 14);
            this.VoucherNumberLbl.TabIndex = 17;
            this.VoucherNumberLbl.Text = "Bill Number";
            // 
            // VendorDescriptionTxtBox
            // 
            this.VendorDescriptionTxtBox.BackColor = System.Drawing.Color.White;
            this.VendorDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorDescriptionTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.VendorDescriptionTxtBox.Location = new System.Drawing.Point(314, 105);
            this.VendorDescriptionTxtBox.Name = "VendorDescriptionTxtBox";
            this.VendorDescriptionTxtBox.ReadOnly = true;
            this.VendorDescriptionTxtBox.Size = new System.Drawing.Size(140, 22);
            this.VendorDescriptionTxtBox.TabIndex = 31;
            this.VendorDescriptionTxtBox.Text = "0";
            this.VendorDescriptionTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UpdateCashBtns);
            // 
            // CompanyLbl
            // 
            this.CompanyLbl.AutoSize = true;
            this.CompanyLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CompanyLbl.Location = new System.Drawing.Point(314, 85);
            this.CompanyLbl.Name = "CompanyLbl";
            this.CompanyLbl.Size = new System.Drawing.Size(47, 14);
            this.CompanyLbl.TabIndex = 16;
            this.CompanyLbl.Text = "Vendor";
            // 
            // ItemsWithoutBarcodeComboBox
            // 
            this.ItemsWithoutBarcodeComboBox.DataSource = this.itemsBindingSource1;
            this.ItemsWithoutBarcodeComboBox.DisplayMember = "Description";
            this.ItemsWithoutBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsWithoutBarcodeComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeComboBox.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsWithoutBarcodeComboBox.FormattingEnabled = true;
            this.ItemsWithoutBarcodeComboBox.Location = new System.Drawing.Point(6, 145);
            this.ItemsWithoutBarcodeComboBox.Name = "ItemsWithoutBarcodeComboBox";
            this.ItemsWithoutBarcodeComboBox.Size = new System.Drawing.Size(260, 24);
            this.ItemsWithoutBarcodeComboBox.TabIndex = 18;
            this.ItemsWithoutBarcodeComboBox.ValueMember = "Barcode";
            this.ItemsWithoutBarcodeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsWithoutBarcodeComboBox_KeyPress);
            // 
            // ItemsWithoutBarcodeLbl
            // 
            this.ItemsWithoutBarcodeLbl.AutoSize = true;
            this.ItemsWithoutBarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeLbl.ForeColor = System.Drawing.Color.Indigo;
            this.ItemsWithoutBarcodeLbl.Location = new System.Drawing.Point(6, 128);
            this.ItemsWithoutBarcodeLbl.Name = "ItemsWithoutBarcodeLbl";
            this.ItemsWithoutBarcodeLbl.Size = new System.Drawing.Size(127, 14);
            this.ItemsWithoutBarcodeLbl.TabIndex = 16;
            this.ItemsWithoutBarcodeLbl.Text = "ItemsWithoutBarcode";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // AddNewItemLbl
            // 
            this.AddNewItemLbl.AutoSize = true;
            this.AddNewItemLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewItemLbl.ForeColor = System.Drawing.Color.Indigo;
            this.AddNewItemLbl.Location = new System.Drawing.Point(264, 0);
            this.AddNewItemLbl.Name = "AddNewItemLbl";
            this.AddNewItemLbl.Size = new System.Drawing.Size(199, 25);
            this.AddNewItemLbl.TabIndex = 101;
            this.AddNewItemLbl.Text = "Purchase Voucher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(573, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 14);
            this.label1.TabIndex = 102;
            this.label1.Text = "JOD";
            // 
            // WithoutAddBtn
            // 
            this.WithoutAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.WithoutAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WithoutAddBtn.BackgroundImage")));
            this.WithoutAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithoutAddBtn.FlatAppearance.BorderSize = 0;
            this.WithoutAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithoutAddBtn.Location = new System.Drawing.Point(269, 144);
            this.WithoutAddBtn.Name = "WithoutAddBtn";
            this.WithoutAddBtn.Size = new System.Drawing.Size(25, 25);
            this.WithoutAddBtn.TabIndex = 144;
            this.WithoutAddBtn.UseVisualStyleBackColor = false;
            this.WithoutAddBtn.Click += new System.EventHandler(this.WithoutAddBtn_Click);
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.BarcodeTxtBox.Location = new System.Drawing.Point(6, 60);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(291, 21);
            this.BarcodeTxtBox.TabIndex = 102;
            this.BarcodeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTxtBox_KeyPress);
            // 
            // DescriptionAddBtn
            // 
            this.DescriptionAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DescriptionAddBtn.BackgroundImage")));
            this.DescriptionAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescriptionAddBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionAddBtn.Location = new System.Drawing.Point(269, 100);
            this.DescriptionAddBtn.Name = "DescriptionAddBtn";
            this.DescriptionAddBtn.Size = new System.Drawing.Size(25, 25);
            this.DescriptionAddBtn.TabIndex = 143;
            this.DescriptionAddBtn.UseVisualStyleBackColor = false;
            this.DescriptionAddBtn.Click += new System.EventHandler(this.DescriptionAddBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.CommentsLbl);
            this.panel1.Controls.Add(this.CommentsTxtBox);
            this.panel1.Controls.Add(this.MinimizePB);
            this.panel1.Controls.Add(this.ExitPB);
            this.panel1.Controls.Add(this.SubtotalLbl);
            this.panel1.Controls.Add(this.DiscountLbl);
            this.panel1.Controls.Add(this.TaxLbl);
            this.panel1.Controls.Add(this.TotalDiscountLbl);
            this.panel1.Controls.Add(this.FeesLbl);
            this.panel1.Controls.Add(this.TotalBillLbl);
            this.panel1.Controls.Add(this.ItemsDiscountLbl);
            this.panel1.Controls.Add(this.DiscountOnVouPercLbl);
            this.panel1.Controls.Add(this.DiscountTxtBox);
            this.panel1.Controls.Add(this.TotalTaxTxtBox);
            this.panel1.Controls.Add(this.TotalTxtBox);
            this.panel1.Controls.Add(this.TotalDiscountTxtBox);
            this.panel1.Controls.Add(this.FeesTxtBox);
            this.panel1.Controls.Add(this.SubtotalTxtBox);
            this.panel1.Controls.Add(this.ItemsDiscountTxtBox);
            this.panel1.Controls.Add(this.DiscountPercTxtBox);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(681, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 700);
            this.panel1.TabIndex = 145;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.Color.Indigo;
            this.CommentsLbl.Location = new System.Drawing.Point(6, 271);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CommentsLbl.TabIndex = 148;
            this.CommentsLbl.Text = "Comments";
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.Indigo;
            this.CommentsTxtBox.Location = new System.Drawing.Point(3, 289);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(335, 36);
            this.CommentsTxtBox.TabIndex = 149;
            this.CommentsTxtBox.TabStop = false;
            // 
            // MinimizePB
            // 
            this.MinimizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePB.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePB.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.MinimizePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Location = new System.Drawing.Point(592, 4);
            this.MinimizePB.Name = "MinimizePB";
            this.MinimizePB.Size = new System.Drawing.Size(15, 15);
            this.MinimizePB.TabIndex = 116;
            this.MinimizePB.TabStop = false;
            this.MinimizePB.Visible = false;
            // 
            // ExitPB
            // 
            this.ExitPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitPB.BackColor = System.Drawing.Color.Transparent;
            this.ExitPB.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon;
            this.ExitPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPB.Location = new System.Drawing.Point(613, 4);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(15, 15);
            this.ExitPB.TabIndex = 115;
            this.ExitPB.TabStop = false;
            this.ExitPB.Visible = false;
            // 
            // OpenCashBtn
            // 
            this.OpenCashBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenCashBtn.BackColor = System.Drawing.Color.Indigo;
            this.OpenCashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCashBtn.FlatAppearance.BorderSize = 0;
            this.OpenCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCashBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenCashBtn.ForeColor = System.Drawing.Color.White;
            this.OpenCashBtn.Location = new System.Drawing.Point(502, 50);
            this.OpenCashBtn.Name = "OpenCashBtn";
            this.OpenCashBtn.Size = new System.Drawing.Size(173, 24);
            this.OpenCashBtn.TabIndex = 148;
            this.OpenCashBtn.Text = "Open Cash";
            this.OpenCashBtn.UseVisualStyleBackColor = false;
            this.OpenCashBtn.Click += new System.EventHandler(this.OpenCashBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.PrintingThermalA4ChkBox);
            this.panel2.Controls.Add(this.ReturnChkBox);
            this.panel2.Controls.Add(this.OpenCashBtn);
            this.panel2.Controls.Add(this.WithoutAddBtn);
            this.panel2.Controls.Add(this.PurchaseVoucherNumTxtBox);
            this.panel2.Controls.Add(this.VoucherNumberLbl);
            this.panel2.Controls.Add(this.AddNewItemLbl);
            this.panel2.Controls.Add(this.VendorAccountAmountTxtBox);
            this.panel2.Controls.Add(this.DescriptionAddBtn);
            this.panel2.Controls.Add(this.VendorsComboBox);
            this.panel2.Controls.Add(this.BarcodeTxtBox);
            this.panel2.Controls.Add(this.CompanyLbl);
            this.panel2.Controls.Add(this.VendorAccountAmountLbl);
            this.panel2.Controls.Add(this.VendorLbl);
            this.panel2.Controls.Add(this.VendorDescriptionTxtBox);
            this.panel2.Controls.Add(this.AddVoucherAndPrintBtn);
            this.panel2.Controls.Add(this.ItemsWithoutBarcodeLbl);
            this.panel2.Controls.Add(this.AddVoucherNoPrintBtn);
            this.panel2.Controls.Add(this.BarcodeLbl);
            this.panel2.Controls.Add(this.ItemDescriptionLbl);
            this.panel2.Controls.Add(this.ItemsWithoutBarcodeComboBox);
            this.panel2.Controls.Add(this.ItemDescriptionComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(102)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 186);
            this.panel2.TabIndex = 145;
            // 
            // PrintingThermalA4ChkBox
            // 
            this.PrintingThermalA4ChkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintingThermalA4ChkBox.AutoSize = true;
            this.PrintingThermalA4ChkBox.ForeColor = System.Drawing.Color.Black;
            this.PrintingThermalA4ChkBox.Location = new System.Drawing.Point(501, 145);
            this.PrintingThermalA4ChkBox.Name = "PrintingThermalA4ChkBox";
            this.PrintingThermalA4ChkBox.Size = new System.Drawing.Size(125, 18);
            this.PrintingThermalA4ChkBox.TabIndex = 158;
            this.PrintingThermalA4ChkBox.Text = "Export As PDF File";
            this.PrintingThermalA4ChkBox.UseVisualStyleBackColor = true;
            // 
            // ReturnChkBox
            // 
            this.ReturnChkBox.AutoSize = true;
            this.ReturnChkBox.BackColor = System.Drawing.Color.Transparent;
            this.ReturnChkBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnChkBox.ForeColor = System.Drawing.Color.Indigo;
            this.ReturnChkBox.Location = new System.Drawing.Point(14, 4);
            this.ReturnChkBox.Name = "ReturnChkBox";
            this.ReturnChkBox.Size = new System.Drawing.Size(122, 29);
            this.ReturnChkBox.TabIndex = 149;
            this.ReturnChkBox.Text = "Credit Bill";
            this.ReturnChkBox.UseVisualStyleBackColor = false;
            this.ReturnChkBox.CheckedChanged += new System.EventHandler(this.ReturnChkBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.TeldgView);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 514);
            this.panel3.TabIndex = 146;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DecreaseBtn);
            this.panel4.Controls.Add(this.DeleteItemsBtn);
            this.panel4.Controls.Add(this.IncreaseBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 514);
            this.panel4.TabIndex = 20;
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Yellowish;
            this.DecreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Location = new System.Drawing.Point(6, 239);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.DecreaseBtn.TabIndex = 58;
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Delete_Res1;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(6, 279);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(35, 35);
            this.DeleteItemsBtn.TabIndex = 56;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            this.DeleteItemsBtn.Click += new System.EventHandler(this.DeleteItemsBtn_Click);
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green;
            this.IncreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Location = new System.Drawing.Point(6, 199);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.IncreaseBtn.TabIndex = 57;
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click);
            // 
            // PurchaseVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "PurchaseVoucher";
            this.Text = "Purchase_Voucher";
            this.Load += new System.EventHandler(this.Purchase_Voucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.CashPaymentGB.ResumeLayout(false);
            this.CashPaymentGB.PerformLayout();
            this.PayInVisaGB.ResumeLayout(false);
            this.PayInVisaGB.PerformLayout();
            this.CheckGB.ResumeLayout(false);
            this.CheckGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FeesLbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.Button AddVoucherNoPrintBtn;
        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.Label DiscountLbl;
        private System.Windows.Forms.TextBox DiscountTxtBox;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.TextBox FeesTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.Button AddVoucherAndPrintBtn;
        private System.Windows.Forms.Label DiscountOnVouPercLbl;
        private System.Windows.Forms.TextBox DiscountPercTxtBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.TextBox TotalTaxTxtBox;
        private System.Windows.Forms.Label TaxLbl;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private DBDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.TextBox ItemsDiscountTxtBox;
        private System.Windows.Forms.Label ItemsDiscountLbl;
        private System.Windows.Forms.TextBox TotalDiscountTxtBox;
        private System.Windows.Forms.Label TotalDiscountLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn FreeItemsQty;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.ComboBox VendorsComboBox;
        private System.Windows.Forms.Label ItemDescriptionLbl;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label VendorLbl;
        private System.Windows.Forms.TextBox PurchaseVoucherNumTxtBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox CashPaymentGB;
        private System.Windows.Forms.Label IsCreditLbl;
        private System.Windows.Forms.ComboBox CashMethodComboBox;
        private System.Windows.Forms.Label CashInCurrency;
        private System.Windows.Forms.Label CashMethodLbl;
        private System.Windows.Forms.Label JODstatic;
        private System.Windows.Forms.TextBox ExchangeTxtBox;
        private System.Windows.Forms.Label ExchangeLbl;
        private System.Windows.Forms.TextBox CashInTxtBox;
        private System.Windows.Forms.Label CashInLbl;
        private System.Windows.Forms.ComboBox PaymentMethodCheckBox;
        private System.Windows.Forms.TextBox PaymentMethodDescripTxtBox;
        private System.Windows.Forms.GroupBox CheckGB;
        private System.Windows.Forms.DateTimePicker CheckDatePicker;
        private System.Windows.Forms.TextBox CheckCommentsTxtBox;
        private System.Windows.Forms.TextBox HolderNameTxtBox;
        private System.Windows.Forms.Label CheckCommentsLbl;
        private System.Windows.Forms.TextBox CheckNumberTxtBox;
        private System.Windows.Forms.Label CheckHolderNameLbl;
        private System.Windows.Forms.Label PaymentDateLbl;
        private System.Windows.Forms.Label CheckNumber;
        private System.Windows.Forms.TextBox AccountDescriptionTxtBox;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label PaymentMethodLbl;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.GroupBox PayInVisaGB;
        private System.Windows.Forms.TextBox CreditCardInfoTxtBox;
        private System.Windows.Forms.Label PaymentCommentsLbl;
        private System.Windows.Forms.Label VendorAccountAmountLbl;
        private System.Windows.Forms.TextBox VendorAccountAmountTxtBox;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DBDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBDataSetTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DBDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.Label VoucherNumberLbl;
        private System.Windows.Forms.TextBox VendorDescriptionTxtBox;
        private System.Windows.Forms.Label CompanyLbl;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.ComboBox ItemsWithoutBarcodeComboBox;
        private System.Windows.Forms.Label ItemsWithoutBarcodeLbl;
        private DBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private DBDataSet dBDataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.Label AddNewItemLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.Button WithoutAddBtn;
        private System.Windows.Forms.Button DescriptionAddBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Button OpenCashBtn;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.CheckBox ReturnChkBox;
        private System.Windows.Forms.CheckBox PrintingThermalA4ChkBox;
    }
}