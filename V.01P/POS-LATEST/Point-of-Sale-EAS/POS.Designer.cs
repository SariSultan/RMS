namespace Calcium_RMS
{
    partial class POS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumTxtBox = new System.Windows.Forms.TextBox();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionLbl = new System.Windows.Forms.Label();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.TotalDiscountLbl = new System.Windows.Forms.Label();
            this.DiscountOnBillLbl = new System.Windows.Forms.Label();
            this.TotalTaxlbl = new System.Windows.Forms.Label();
            this.PriceLevelLbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.TaxTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.TotalDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.PriceLvlDiscountLbl = new System.Windows.Forms.Label();
            this.DiscountBillPercLbl = new System.Windows.Forms.Label();
            this.DiscountBillTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.PriceLevelComboBox = new System.Windows.Forms.ComboBox();
            this.priceLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet2 = new Calcium_RMS.DBDataSet();
            this.PriceLevelDiscount = new System.Windows.Forms.TextBox();
            this.DiscountPercTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
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
            this.CashInCurrency = new System.Windows.Forms.Label();
            this.CashMethodComboBox = new System.Windows.Forms.ComboBox();
            this.JODstatic = new System.Windows.Forms.Label();
            this.CashMethodLbl = new System.Windows.Forms.Label();
            this.SellPriceLbl = new System.Windows.Forms.Label();
            this.BuyRateLbl = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CurrencyLbl = new System.Windows.Forms.Label();
            this.SellRateTxtBox = new System.Windows.Forms.TextBox();
            this.ExchangeTxtBox = new System.Windows.Forms.TextBox();
            this.ExchangeLbl = new System.Windows.Forms.Label();
            this.BuyRateTxtBox = new System.Windows.Forms.TextBox();
            this.CashInTxtBox = new System.Windows.Forms.TextBox();
            this.CashInLbl = new System.Windows.Forms.Label();
            this.CheckGB = new System.Windows.Forms.GroupBox();
            this.CheckDatePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckCommentsTxtBox = new System.Windows.Forms.TextBox();
            this.HolderNameTxtBox = new System.Windows.Forms.TextBox();
            this.CheckCommentsLbl = new System.Windows.Forms.Label();
            this.CheckNumberTxtBox = new System.Windows.Forms.TextBox();
            this.CheckHolderNameLbl = new System.Windows.Forms.Label();
            this.PaymentDateLbl = new System.Windows.Forms.Label();
            this.CheckNumber = new System.Windows.Forms.Label();
            this.PayInVisaGB = new System.Windows.Forms.GroupBox();
            this.CreditCardInfoTxtBox = new System.Windows.Forms.TextBox();
            this.PaymentCommentsLbl = new System.Windows.Forms.Label();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.PaymentOnlyBtn = new System.Windows.Forms.Button();
            this.PaymentAndPrintBtn = new System.Windows.Forms.Button();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.BillNumberLbl = new System.Windows.Forms.Label();
            this.NetAmountTxtBox = new System.Windows.Forms.TextBox();
            this.NetAmountLbl = new System.Windows.Forms.Label();
            this.SavePaymentNoPrint = new System.Windows.Forms.Label();
            this.SavePaymnetandPrint = new System.Windows.Forms.Label();
            this.CancelPayment = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeLbl = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            this.accountsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.AccountsTableAdapter();
            this.paymentMethodTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PaymentMethodTableAdapter();
            this.priceLevelsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PriceLevelsTableAdapter();
            this.currencyTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CurrencyTableAdapter();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.WithoutAddBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.ReturnChkBox = new System.Windows.Forms.CheckBox();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.DescriptionAddBtn = new System.Windows.Forms.Button();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerScreenChkBox = new System.Windows.Forms.CheckBox();
            this.DecreaseLbl = new System.Windows.Forms.Label();
            this.IncreaseLbl = new System.Windows.Forms.Label();
            this.CustomersAccountAmountTxtBox = new System.Windows.Forms.TextBox();
            this.CustomersAccountAmount = new System.Windows.Forms.Label();
            this.rigthPanel = new System.Windows.Forms.Panel();
            this.PrintingThermalA4ChkBox = new System.Windows.Forms.CheckBox();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.OpenCashBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.Inner_left_down_panel = new System.Windows.Forms.Panel();
            this.F2ShortcutLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.F4ShortcutLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.EscShortcutLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.WithoutBarcodeTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.CashPaymentGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.CheckGB.SuspendLayout();
            this.PayInVisaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.rigthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.Inner_left_down_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.TeldgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeldgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
            this.TeldgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeldgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.TeldgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeldgView.ColumnHeadersHeight = 28;
            this.TeldgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TeldgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.Qty,
            this.PricePerUnit,
            this.Tax,
            this.PriceTotal,
            this.AvalQty});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle4;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.TeldgView.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.TeldgView.Location = new System.Drawing.Point(264, 0);
            this.TeldgView.Name = "TeldgView";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TeldgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(520, 513);
            this.TeldgView.StandardTab = true;
            this.TeldgView.TabIndex = 5;
            this.TeldgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeldgView_CellValueChanged);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Visible = false;
            this.Barcode.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle3;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 50;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PricePerUnit.HeaderText = "PriceUnit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.Width = 74;
            // 
            // Tax
            // 
            this.Tax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.Width = 50;
            // 
            // PriceTotal
            // 
            this.PriceTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceTotal.HeaderText = "Price*Qty";
            this.PriceTotal.Name = "PriceTotal";
            this.PriceTotal.Width = 79;
            // 
            // AvalQty
            // 
            this.AvalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AvalQty.HeaderText = "AvalQty";
            this.AvalQty.Name = "AvalQty";
            this.AvalQty.Width = 71;
            // 
            // InvoiceNumTxtBox
            // 
            this.InvoiceNumTxtBox.BackColor = System.Drawing.Color.White;
            this.InvoiceNumTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.InvoiceNumTxtBox.Location = new System.Drawing.Point(3, 31);
            this.InvoiceNumTxtBox.Name = "InvoiceNumTxtBox";
            this.InvoiceNumTxtBox.ReadOnly = true;
            this.InvoiceNumTxtBox.Size = new System.Drawing.Size(157, 33);
            this.InvoiceNumTxtBox.TabIndex = 0;
            this.InvoiceNumTxtBox.TabStop = false;
            this.InvoiceNumTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.BarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BarcodeLbl.Location = new System.Drawing.Point(5, 108);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(109, 14);
            this.BarcodeLbl.TabIndex = 16;
            this.BarcodeLbl.Text = "Barcode Scanner";
            // 
            // ItemDescriptionLbl
            // 
            this.ItemDescriptionLbl.AutoSize = true;
            this.ItemDescriptionLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemDescriptionLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ItemDescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemDescriptionLbl.Location = new System.Drawing.Point(4, 17);
            this.ItemDescriptionLbl.Name = "ItemDescriptionLbl";
            this.ItemDescriptionLbl.Size = new System.Drawing.Size(109, 14);
            this.ItemDescriptionLbl.TabIndex = 17;
            this.ItemDescriptionLbl.Text = "Item Description";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.DataSource = this.itemsBindingSource;
            this.ItemDescriptionComboBox.DisplayMember = "Description";
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(171, 10);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(400, 27);
            this.ItemDescriptionComboBox.TabIndex = 1;
            this.ItemDescriptionComboBox.ValueMember = "Barcode";
            this.ItemDescriptionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemDescriptionComboBox_KeyPress);
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalBillLbl.Location = new System.Drawing.Point(3, 319);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(73, 23);
            this.TotalBillLbl.TabIndex = 0;
            this.TotalBillLbl.Text = "TOTAL";
            // 
            // TotalDiscountLbl
            // 
            this.TotalDiscountLbl.AutoSize = true;
            this.TotalDiscountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalDiscountLbl.Location = new System.Drawing.Point(61, 207);
            this.TotalDiscountLbl.Name = "TotalDiscountLbl";
            this.TotalDiscountLbl.Size = new System.Drawing.Size(100, 16);
            this.TotalDiscountLbl.TabIndex = 45;
            this.TotalDiscountLbl.Text = "Total Discount";
            // 
            // DiscountOnBillLbl
            // 
            this.DiscountOnBillLbl.AutoSize = true;
            this.DiscountOnBillLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountOnBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountOnBillLbl.Location = new System.Drawing.Point(61, 130);
            this.DiscountOnBillLbl.Name = "DiscountOnBillLbl";
            this.DiscountOnBillLbl.Size = new System.Drawing.Size(99, 16);
            this.DiscountOnBillLbl.TabIndex = 42;
            this.DiscountOnBillLbl.Text = "Dicount On Bill";
            // 
            // TotalTaxlbl
            // 
            this.TotalTaxlbl.AutoSize = true;
            this.TotalTaxlbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TotalTaxlbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalTaxlbl.Location = new System.Drawing.Point(61, 283);
            this.TotalTaxlbl.Name = "TotalTaxlbl";
            this.TotalTaxlbl.Size = new System.Drawing.Size(62, 16);
            this.TotalTaxlbl.TabIndex = 43;
            this.TotalTaxlbl.Text = "TotalTax";
            // 
            // PriceLevelLbl
            // 
            this.PriceLevelLbl.AutoSize = true;
            this.PriceLevelLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceLevelLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLevelLbl.Location = new System.Drawing.Point(13, 86);
            this.PriceLevelLbl.Name = "PriceLevelLbl";
            this.PriceLevelLbl.Size = new System.Drawing.Size(78, 16);
            this.PriceLevelLbl.TabIndex = 48;
            this.PriceLevelLbl.Text = "Price Level";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SubtotalLbl.Location = new System.Drawing.Point(97, 3);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(63, 16);
            this.SubtotalLbl.TabIndex = 47;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // TaxTxtBox
            // 
            this.TaxTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TaxTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxtBox.ForeColor = System.Drawing.Color.White;
            this.TaxTxtBox.Location = new System.Drawing.Point(61, 298);
            this.TaxTxtBox.Name = "TaxTxtBox";
            this.TaxTxtBox.ReadOnly = true;
            this.TaxTxtBox.Size = new System.Drawing.Size(133, 21);
            this.TaxTxtBox.TabIndex = 41;
            this.TaxTxtBox.TabStop = false;
            this.TaxTxtBox.Text = "0";
            this.TaxTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.White;
            this.TotalTxtBox.Location = new System.Drawing.Point(3, 344);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(236, 43);
            this.TotalTxtBox.TabIndex = 0;
            this.TotalTxtBox.TabStop = false;
            this.TotalTxtBox.Text = "0.00";
            this.TotalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TotalDiscountTxtBox
            // 
            this.TotalDiscountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalDiscountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTxtBox.ForeColor = System.Drawing.Color.White;
            this.TotalDiscountTxtBox.Location = new System.Drawing.Point(61, 223);
            this.TotalDiscountTxtBox.Name = "TotalDiscountTxtBox";
            this.TotalDiscountTxtBox.ReadOnly = true;
            this.TotalDiscountTxtBox.Size = new System.Drawing.Size(133, 21);
            this.TotalDiscountTxtBox.TabIndex = 36;
            this.TotalDiscountTxtBox.TabStop = false;
            this.TotalDiscountTxtBox.Text = "0";
            this.TotalDiscountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceLvlDiscountLbl
            // 
            this.PriceLvlDiscountLbl.AutoSize = true;
            this.PriceLvlDiscountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceLvlDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLvlDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLvlDiscountLbl.Location = new System.Drawing.Point(61, 168);
            this.PriceLvlDiscountLbl.Name = "PriceLvlDiscountLbl";
            this.PriceLvlDiscountLbl.Size = new System.Drawing.Size(138, 16);
            this.PriceLvlDiscountLbl.TabIndex = 46;
            this.PriceLvlDiscountLbl.Text = "Price Level Discount";
            // 
            // DiscountBillPercLbl
            // 
            this.DiscountBillPercLbl.AutoSize = true;
            this.DiscountBillPercLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiscountBillPercLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBillPercLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountBillPercLbl.Location = new System.Drawing.Point(11, 42);
            this.DiscountBillPercLbl.Name = "DiscountBillPercLbl";
            this.DiscountBillPercLbl.Size = new System.Drawing.Size(147, 16);
            this.DiscountBillPercLbl.TabIndex = 49;
            this.DiscountBillPercLbl.Text = "Dicount On Invoice %";
            // 
            // DiscountBillTxtBox
            // 
            this.DiscountBillTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountBillTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBillTxtBox.ForeColor = System.Drawing.Color.White;
            this.DiscountBillTxtBox.Location = new System.Drawing.Point(61, 145);
            this.DiscountBillTxtBox.Name = "DiscountBillTxtBox";
            this.DiscountBillTxtBox.ReadOnly = true;
            this.DiscountBillTxtBox.Size = new System.Drawing.Size(133, 21);
            this.DiscountBillTxtBox.TabIndex = 38;
            this.DiscountBillTxtBox.TabStop = false;
            this.DiscountBillTxtBox.Text = "0";
            this.DiscountBillTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.White;
            this.SubtotalTxtBox.Location = new System.Drawing.Point(61, 19);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(133, 21);
            this.SubtotalTxtBox.TabIndex = 40;
            this.SubtotalTxtBox.TabStop = false;
            this.SubtotalTxtBox.Text = "0";
            this.SubtotalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PriceLevelComboBox
            // 
            this.PriceLevelComboBox.DataSource = this.priceLevelsBindingSource;
            this.PriceLevelComboBox.DisplayMember = "Name";
            this.PriceLevelComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelComboBox.FormattingEnabled = true;
            this.PriceLevelComboBox.Location = new System.Drawing.Point(9, 108);
            this.PriceLevelComboBox.Name = "PriceLevelComboBox";
            this.PriceLevelComboBox.Size = new System.Drawing.Size(207, 21);
            this.PriceLevelComboBox.TabIndex = 8;
            this.PriceLevelComboBox.ValueMember = "ID";
            this.PriceLevelComboBox.SelectedValueChanged += new System.EventHandler(this.PriceLevelComboBox_SelectedValueChanged);
            // 
            // priceLevelsBindingSource
            // 
            this.priceLevelsBindingSource.DataMember = "PriceLevels";
            this.priceLevelsBindingSource.DataSource = this.dBDataSet2;
            // 
            // DBDataSet
            // 
            this.dBDataSet2.DataSetName = "DBDataSet";
            this.dBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriceLevelDiscount
            // 
            this.PriceLevelDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLevelDiscount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelDiscount.ForeColor = System.Drawing.Color.White;
            this.PriceLevelDiscount.Location = new System.Drawing.Point(61, 185);
            this.PriceLevelDiscount.Name = "PriceLevelDiscount";
            this.PriceLevelDiscount.ReadOnly = true;
            this.PriceLevelDiscount.Size = new System.Drawing.Size(133, 21);
            this.PriceLevelDiscount.TabIndex = 39;
            this.PriceLevelDiscount.TabStop = false;
            this.PriceLevelDiscount.Text = "0";
            this.PriceLevelDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscountPercTxtBox
            // 
            this.DiscountPercTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPercTxtBox.Location = new System.Drawing.Point(9, 62);
            this.DiscountPercTxtBox.Name = "DiscountPercTxtBox";
            this.DiscountPercTxtBox.Size = new System.Drawing.Size(207, 21);
            this.DiscountPercTxtBox.TabIndex = 7;
            this.DiscountPercTxtBox.Text = "0";
            this.DiscountPercTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscountPercTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountPercTxtBox_KeyPress);
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerNameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(3, 137);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.ReadOnly = true;
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(258, 21);
            this.CustomerNameTxtBox.TabIndex = 0;
            this.CustomerNameTxtBox.TabStop = false;
            // 
            // PaymentMethodCheckBox
            // 
            this.PaymentMethodCheckBox.DataSource = this.paymentMethodBindingSource;
            this.PaymentMethodCheckBox.DisplayMember = "Name";
            this.PaymentMethodCheckBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodCheckBox.FormattingEnabled = true;
            this.PaymentMethodCheckBox.Location = new System.Drawing.Point(3, 22);
            this.PaymentMethodCheckBox.Name = "PaymentMethodCheckBox";
            this.PaymentMethodCheckBox.Size = new System.Drawing.Size(93, 21);
            this.PaymentMethodCheckBox.TabIndex = 9;
            this.PaymentMethodCheckBox.ValueMember = "ID";
            this.PaymentMethodCheckBox.SelectedValueChanged += new System.EventHandler(this.PaymentMethodCheckBox_SelectedValueChanged);
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBDataSet2;
            // 
            // PaymentMethodDescripTxtBox
            // 
            this.PaymentMethodDescripTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentMethodDescripTxtBox.ForeColor = System.Drawing.Color.White;
            this.PaymentMethodDescripTxtBox.Location = new System.Drawing.Point(98, 23);
            this.PaymentMethodDescripTxtBox.Name = "PaymentMethodDescripTxtBox";
            this.PaymentMethodDescripTxtBox.ReadOnly = true;
            this.PaymentMethodDescripTxtBox.Size = new System.Drawing.Size(166, 20);
            this.PaymentMethodDescripTxtBox.TabIndex = 0;
            this.PaymentMethodDescripTxtBox.TabStop = false;
            // 
            // AccountDescriptionTxtBox
            // 
            this.AccountDescriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.AccountDescriptionTxtBox.ForeColor = System.Drawing.Color.White;
            this.AccountDescriptionTxtBox.Location = new System.Drawing.Point(101, 64);
            this.AccountDescriptionTxtBox.Name = "AccountDescriptionTxtBox";
            this.AccountDescriptionTxtBox.ReadOnly = true;
            this.AccountDescriptionTxtBox.Size = new System.Drawing.Size(161, 20);
            this.AccountDescriptionTxtBox.TabIndex = 0;
            this.AccountDescriptionTxtBox.TabStop = false;
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DataSource = this.accountsBindingSource;
            this.AccountComboBox.DisplayMember = "Name";
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(3, 62);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(93, 21);
            this.AccountComboBox.TabIndex = 10;
            this.AccountComboBox.ValueMember = "ID";
            this.AccountComboBox.SelectedValueChanged += new System.EventHandler(this.AccountComboBox_SelectedValueChanged);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dBDataSet2;
            // 
            // PaymentMethodLbl
            // 
            this.PaymentMethodLbl.AutoSize = true;
            this.PaymentMethodLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentMethodLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentMethodLbl.Location = new System.Drawing.Point(6, 5);
            this.PaymentMethodLbl.Name = "PaymentMethodLbl";
            this.PaymentMethodLbl.Size = new System.Drawing.Size(109, 14);
            this.PaymentMethodLbl.TabIndex = 0;
            this.PaymentMethodLbl.Text = "PaymentMethod";
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.AccountLbl.Location = new System.Drawing.Point(7, 45);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(58, 14);
            this.AccountLbl.TabIndex = 0;
            this.AccountLbl.Text = "Account";
            // 
            // CashPaymentGB
            // 
            this.CashPaymentGB.Controls.Add(this.IsCreditLbl);
            this.CashPaymentGB.Controls.Add(this.CashInCurrency);
            this.CashPaymentGB.Controls.Add(this.CashMethodComboBox);
            this.CashPaymentGB.Controls.Add(this.JODstatic);
            this.CashPaymentGB.Controls.Add(this.CashMethodLbl);
            this.CashPaymentGB.Controls.Add(this.SellPriceLbl);
            this.CashPaymentGB.Controls.Add(this.BuyRateLbl);
            this.CashPaymentGB.Controls.Add(this.CurrencyComboBox);
            this.CashPaymentGB.Controls.Add(this.CurrencyLbl);
            this.CashPaymentGB.Controls.Add(this.SellRateTxtBox);
            this.CashPaymentGB.Controls.Add(this.ExchangeTxtBox);
            this.CashPaymentGB.Controls.Add(this.ExchangeLbl);
            this.CashPaymentGB.Controls.Add(this.BuyRateTxtBox);
            this.CashPaymentGB.Controls.Add(this.CashInTxtBox);
            this.CashPaymentGB.Controls.Add(this.CashInLbl);
            this.CashPaymentGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashPaymentGB.Location = new System.Drawing.Point(14, 203);
            this.CashPaymentGB.Name = "CashPaymentGB";
            this.CashPaymentGB.Size = new System.Drawing.Size(237, 283);
            this.CashPaymentGB.TabIndex = 11;
            this.CashPaymentGB.TabStop = false;
            this.CashPaymentGB.Text = "PayInCash";
            // 
            // IsCreditLbl
            // 
            this.IsCreditLbl.AutoSize = true;
            this.IsCreditLbl.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsCreditLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.IsCreditLbl.Location = new System.Drawing.Point(64, 105);
            this.IsCreditLbl.Name = "IsCreditLbl";
            this.IsCreditLbl.Size = new System.Drawing.Size(114, 45);
            this.IsCreditLbl.TabIndex = 0;
            this.IsCreditLbl.Text = "Credit";
            this.IsCreditLbl.Visible = false;
            // 
            // CashInCurrency
            // 
            this.CashInCurrency.AutoSize = true;
            this.CashInCurrency.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashInCurrency.Location = new System.Drawing.Point(191, 88);
            this.CashInCurrency.Name = "CashInCurrency";
            this.CashInCurrency.Size = new System.Drawing.Size(29, 14);
            this.CashInCurrency.TabIndex = 0;
            this.CashInCurrency.Text = "JOD";
            // 
            // CashMethodComboBox
            // 
            this.CashMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CashMethodComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodComboBox.FormattingEnabled = true;
            this.CashMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Invoice"});
            this.CashMethodComboBox.Location = new System.Drawing.Point(12, 34);
            this.CashMethodComboBox.Name = "CashMethodComboBox";
            this.CashMethodComboBox.Size = new System.Drawing.Size(218, 21);
            this.CashMethodComboBox.TabIndex = 11;
            this.CashMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.CashMethodComboBox_SelectedIndexChanged);
            // 
            // JODstatic
            // 
            this.JODstatic.AutoSize = true;
            this.JODstatic.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JODstatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.JODstatic.Location = new System.Drawing.Point(191, 159);
            this.JODstatic.Name = "JODstatic";
            this.JODstatic.Size = new System.Drawing.Size(29, 14);
            this.JODstatic.TabIndex = 0;
            this.JODstatic.Text = "JOD";
            // 
            // CashMethodLbl
            // 
            this.CashMethodLbl.AutoSize = true;
            this.CashMethodLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashMethodLbl.Location = new System.Drawing.Point(9, 17);
            this.CashMethodLbl.Name = "CashMethodLbl";
            this.CashMethodLbl.Size = new System.Drawing.Size(78, 14);
            this.CashMethodLbl.TabIndex = 0;
            this.CashMethodLbl.Text = "Cash Method";
            // 
            // SellPriceLbl
            // 
            this.SellPriceLbl.AutoSize = true;
            this.SellPriceLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SellPriceLbl.Location = new System.Drawing.Point(12, 239);
            this.SellPriceLbl.Name = "SellPriceLbl";
            this.SellPriceLbl.Size = new System.Drawing.Size(55, 14);
            this.SellPriceLbl.TabIndex = 0;
            this.SellPriceLbl.Text = "Sell Price";
            // 
            // BuyRateLbl
            // 
            this.BuyRateLbl.AutoSize = true;
            this.BuyRateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyRateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BuyRateLbl.Location = new System.Drawing.Point(131, 239);
            this.BuyRateLbl.Name = "BuyRateLbl";
            this.BuyRateLbl.Size = new System.Drawing.Size(56, 14);
            this.BuyRateLbl.TabIndex = 0;
            this.BuyRateLbl.Text = "Buy Rate";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.BackColor = System.Drawing.Color.White;
            this.CurrencyComboBox.DataSource = this.currencyBindingSource;
            this.CurrencyComboBox.DisplayMember = "Name";
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyComboBox.ForeColor = System.Drawing.Color.Crimson;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(15, 215);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(194, 21);
            this.CurrencyComboBox.TabIndex = 12;
            this.CurrencyComboBox.ValueMember = "ID";
            this.CurrencyComboBox.SelectedValueChanged += new System.EventHandler(this.CurrencyComboBox_SelectedValueChanged);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.dBDataSet2;
            // 
            // CurrencyLbl
            // 
            this.CurrencyLbl.AutoSize = true;
            this.CurrencyLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CurrencyLbl.Location = new System.Drawing.Point(19, 198);
            this.CurrencyLbl.Name = "CurrencyLbl";
            this.CurrencyLbl.Size = new System.Drawing.Size(55, 14);
            this.CurrencyLbl.TabIndex = 0;
            this.CurrencyLbl.Text = "Currency";
            // 
            // SellRateTxtBox
            // 
            this.SellRateTxtBox.BackColor = System.Drawing.Color.White;
            this.SellRateTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SellRateTxtBox.Location = new System.Drawing.Point(8, 256);
            this.SellRateTxtBox.Name = "SellRateTxtBox";
            this.SellRateTxtBox.ReadOnly = true;
            this.SellRateTxtBox.Size = new System.Drawing.Size(86, 21);
            this.SellRateTxtBox.TabIndex = 0;
            this.SellRateTxtBox.TabStop = false;
            // 
            // ExchangeTxtBox
            // 
            this.ExchangeTxtBox.BackColor = System.Drawing.Color.White;
            this.ExchangeTxtBox.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ExchangeTxtBox.Location = new System.Drawing.Point(12, 141);
            this.ExchangeTxtBox.Name = "ExchangeTxtBox";
            this.ExchangeTxtBox.ReadOnly = true;
            this.ExchangeTxtBox.Size = new System.Drawing.Size(173, 40);
            this.ExchangeTxtBox.TabIndex = 0;
            this.ExchangeTxtBox.TabStop = false;
            this.ExchangeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExchangeLbl
            // 
            this.ExchangeLbl.AutoSize = true;
            this.ExchangeLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ExchangeLbl.Location = new System.Drawing.Point(8, 122);
            this.ExchangeLbl.Name = "ExchangeLbl";
            this.ExchangeLbl.Size = new System.Drawing.Size(76, 19);
            this.ExchangeLbl.TabIndex = 0;
            this.ExchangeLbl.Text = "Exhcange";
            // 
            // BuyRateTxtBox
            // 
            this.BuyRateTxtBox.BackColor = System.Drawing.Color.White;
            this.BuyRateTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyRateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BuyRateTxtBox.Location = new System.Drawing.Point(127, 256);
            this.BuyRateTxtBox.Name = "BuyRateTxtBox";
            this.BuyRateTxtBox.ReadOnly = true;
            this.BuyRateTxtBox.Size = new System.Drawing.Size(93, 21);
            this.BuyRateTxtBox.TabIndex = 0;
            this.BuyRateTxtBox.TabStop = false;
            // 
            // CashInTxtBox
            // 
            this.CashInTxtBox.BackColor = System.Drawing.Color.White;
            this.CashInTxtBox.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashInTxtBox.Location = new System.Drawing.Point(12, 79);
            this.CashInTxtBox.Name = "CashInTxtBox";
            this.CashInTxtBox.Size = new System.Drawing.Size(173, 40);
            this.CashInTxtBox.TabIndex = 13;
            this.CashInTxtBox.Text = "0.00";
            this.CashInTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashInTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashInTxtBox_KeyPress);
            // 
            // CashInLbl
            // 
            this.CashInLbl.AutoSize = true;
            this.CashInLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashInLbl.Location = new System.Drawing.Point(11, 59);
            this.CashInLbl.Name = "CashInLbl";
            this.CashInLbl.Size = new System.Drawing.Size(63, 19);
            this.CashInLbl.TabIndex = 0;
            this.CashInLbl.Text = "Cash In";
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
            this.CheckGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckGB.Location = new System.Drawing.Point(14, 204);
            this.CheckGB.Name = "CheckGB";
            this.CheckGB.Size = new System.Drawing.Size(237, 278);
            this.CheckGB.TabIndex = 11;
            this.CheckGB.TabStop = false;
            this.CheckGB.Text = "Check Information";
            // 
            // CheckDatePicker
            // 
            this.CheckDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckDatePicker.Location = new System.Drawing.Point(12, 135);
            this.CheckDatePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.Name = "CheckDatePicker";
            this.CheckDatePicker.Size = new System.Drawing.Size(191, 22);
            this.CheckDatePicker.TabIndex = 8;
            this.CheckDatePicker.TabStop = false;
            // 
            // CheckCommentsTxtBox
            // 
            this.CheckCommentsTxtBox.BackColor = System.Drawing.Color.White;
            this.CheckCommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckCommentsTxtBox.Location = new System.Drawing.Point(6, 188);
            this.CheckCommentsTxtBox.Multiline = true;
            this.CheckCommentsTxtBox.Name = "CheckCommentsTxtBox";
            this.CheckCommentsTxtBox.Size = new System.Drawing.Size(203, 75);
            this.CheckCommentsTxtBox.TabIndex = 7;
            this.CheckCommentsTxtBox.TabStop = false;
            // 
            // HolderNameTxtBox
            // 
            this.HolderNameTxtBox.BackColor = System.Drawing.Color.White;
            this.HolderNameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolderNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.HolderNameTxtBox.Location = new System.Drawing.Point(12, 82);
            this.HolderNameTxtBox.Name = "HolderNameTxtBox";
            this.HolderNameTxtBox.Size = new System.Drawing.Size(191, 21);
            this.HolderNameTxtBox.TabIndex = 0;
            this.HolderNameTxtBox.TabStop = false;
            // 
            // CheckCommentsLbl
            // 
            this.CheckCommentsLbl.AutoSize = true;
            this.CheckCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsLbl.Location = new System.Drawing.Point(69, 169);
            this.CheckCommentsLbl.Name = "CheckCommentsLbl";
            this.CheckCommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CheckCommentsLbl.TabIndex = 6;
            this.CheckCommentsLbl.Text = "Comments";
            // 
            // CheckNumberTxtBox
            // 
            this.CheckNumberTxtBox.BackColor = System.Drawing.Color.White;
            this.CheckNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumberTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckNumberTxtBox.Location = new System.Drawing.Point(12, 32);
            this.CheckNumberTxtBox.Name = "CheckNumberTxtBox";
            this.CheckNumberTxtBox.ReadOnly = true;
            this.CheckNumberTxtBox.Size = new System.Drawing.Size(191, 21);
            this.CheckNumberTxtBox.TabIndex = 0;
            this.CheckNumberTxtBox.TabStop = false;
            // 
            // CheckHolderNameLbl
            // 
            this.CheckHolderNameLbl.AutoSize = true;
            this.CheckHolderNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHolderNameLbl.Location = new System.Drawing.Point(60, 64);
            this.CheckHolderNameLbl.Name = "CheckHolderNameLbl";
            this.CheckHolderNameLbl.Size = new System.Drawing.Size(77, 14);
            this.CheckHolderNameLbl.TabIndex = 6;
            this.CheckHolderNameLbl.Text = "Holder Name";
            // 
            // PaymentDateLbl
            // 
            this.PaymentDateLbl.AutoSize = true;
            this.PaymentDateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDateLbl.Location = new System.Drawing.Point(58, 117);
            this.PaymentDateLbl.Name = "PaymentDateLbl";
            this.PaymentDateLbl.Size = new System.Drawing.Size(85, 14);
            this.PaymentDateLbl.TabIndex = 6;
            this.PaymentDateLbl.Text = "Payment Date";
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSize = true;
            this.CheckNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber.Location = new System.Drawing.Point(56, 13);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(83, 14);
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.Text = "CheckNumber";
            // 
            // PayInVisaGB
            // 
            this.PayInVisaGB.Controls.Add(this.CreditCardInfoTxtBox);
            this.PayInVisaGB.Controls.Add(this.PaymentCommentsLbl);
            this.PayInVisaGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayInVisaGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PayInVisaGB.Location = new System.Drawing.Point(13, 205);
            this.PayInVisaGB.Name = "PayInVisaGB";
            this.PayInVisaGB.Size = new System.Drawing.Size(237, 286);
            this.PayInVisaGB.TabIndex = 11;
            this.PayInVisaGB.TabStop = false;
            this.PayInVisaGB.Text = "Pay Using Credit Card";
            // 
            // CreditCardInfoTxtBox
            // 
            this.CreditCardInfoTxtBox.BackColor = System.Drawing.Color.White;
            this.CreditCardInfoTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardInfoTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CreditCardInfoTxtBox.Location = new System.Drawing.Point(6, 38);
            this.CreditCardInfoTxtBox.Multiline = true;
            this.CreditCardInfoTxtBox.Name = "CreditCardInfoTxtBox";
            this.CreditCardInfoTxtBox.Size = new System.Drawing.Size(225, 135);
            this.CreditCardInfoTxtBox.TabIndex = 7;
            this.CreditCardInfoTxtBox.TabStop = false;
            // 
            // PaymentCommentsLbl
            // 
            this.PaymentCommentsLbl.AutoSize = true;
            this.PaymentCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentCommentsLbl.Location = new System.Drawing.Point(18, 21);
            this.PaymentCommentsLbl.Name = "PaymentCommentsLbl";
            this.PaymentCommentsLbl.Size = new System.Drawing.Size(29, 14);
            this.PaymentCommentsLbl.TabIndex = 6;
            this.PaymentCommentsLbl.Text = "Info";
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Delete_Res1;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.DeleteItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(8, 102);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(35, 35);
            this.DeleteItemsBtn.TabIndex = 51;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            this.DeleteItemsBtn.Click += new System.EventHandler(this.DeleteItemsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(504, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Remove";
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CancleBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Cancel_New;
            this.CancleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancleBtn.FlatAppearance.BorderSize = 0;
            this.CancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(3, 540);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(236, 50);
            this.CancleBtn.TabIndex = 16;
            this.CancleBtn.Text = "Clear";
            this.CancleBtn.UseVisualStyleBackColor = false;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // PaymentOnlyBtn
            // 
            this.PaymentOnlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentOnlyBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.SaveOnly_New;
            this.PaymentOnlyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentOnlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentOnlyBtn.FlatAppearance.BorderSize = 0;
            this.PaymentOnlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentOnlyBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOnlyBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentOnlyBtn.Location = new System.Drawing.Point(3, 489);
            this.PaymentOnlyBtn.Name = "PaymentOnlyBtn";
            this.PaymentOnlyBtn.Size = new System.Drawing.Size(236, 50);
            this.PaymentOnlyBtn.TabIndex = 14;
            this.PaymentOnlyBtn.Text = "Save && New";
            this.PaymentOnlyBtn.UseVisualStyleBackColor = false;
            this.PaymentOnlyBtn.Click += new System.EventHandler(this.PaymentOnlyBtn_Click);
            // 
            // PaymentAndPrintBtn
            // 
            this.PaymentAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentAndPrintBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.SavePrint_New;
            this.PaymentAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentAndPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.PaymentAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentAndPrintBtn.Location = new System.Drawing.Point(3, 438);
            this.PaymentAndPrintBtn.Name = "PaymentAndPrintBtn";
            this.PaymentAndPrintBtn.Size = new System.Drawing.Size(236, 50);
            this.PaymentAndPrintBtn.TabIndex = 15;
            this.PaymentAndPrintBtn.Text = "Save && Print";
            this.PaymentAndPrintBtn.UseVisualStyleBackColor = false;
            this.PaymentAndPrintBtn.Click += new System.EventHandler(this.PaymentAndPrintBtn_Click);
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PhoneTxtBox.Location = new System.Drawing.Point(4, 104);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(255, 30);
            this.PhoneTxtBox.TabIndex = 4;
            this.PhoneTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxtBox_KeyPress);
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(3, 403);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(236, 32);
            this.CommentsTxtBox.TabIndex = 6;
            this.CommentsTxtBox.TabStop = false;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CommentsLbl.Location = new System.Drawing.Point(6, 388);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CommentsLbl.TabIndex = 0;
            this.CommentsLbl.Text = "Comments";
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(6, 86);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(109, 14);
            this.CustomerPhoneLbl.TabIndex = 0;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // BillNumberLbl
            // 
            this.BillNumberLbl.AutoSize = true;
            this.BillNumberLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BillNumberLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BillNumberLbl.Location = new System.Drawing.Point(2, 10);
            this.BillNumberLbl.Name = "BillNumberLbl";
            this.BillNumberLbl.Size = new System.Drawing.Size(108, 16);
            this.BillNumberLbl.TabIndex = 0;
            this.BillNumberLbl.Text = "Invoice Number";
            // 
            // NetAmountTxtBox
            // 
            this.NetAmountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.NetAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetAmountTxtBox.ForeColor = System.Drawing.Color.White;
            this.NetAmountTxtBox.Location = new System.Drawing.Point(61, 262);
            this.NetAmountTxtBox.Name = "NetAmountTxtBox";
            this.NetAmountTxtBox.ReadOnly = true;
            this.NetAmountTxtBox.Size = new System.Drawing.Size(133, 21);
            this.NetAmountTxtBox.TabIndex = 40;
            this.NetAmountTxtBox.TabStop = false;
            this.NetAmountTxtBox.Text = "0";
            this.NetAmountTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NetAmountLbl
            // 
            this.NetAmountLbl.AutoSize = true;
            this.NetAmountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetAmountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetAmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.NetAmountLbl.Location = new System.Drawing.Point(61, 245);
            this.NetAmountLbl.Name = "NetAmountLbl";
            this.NetAmountLbl.Size = new System.Drawing.Size(113, 16);
            this.NetAmountLbl.TabIndex = 47;
            this.NetAmountLbl.Text = "Total Before Tax";
            // 
            // SavePaymentNoPrint
            // 
            this.SavePaymentNoPrint.AutoSize = true;
            this.SavePaymentNoPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymentNoPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymentNoPrint.Location = new System.Drawing.Point(347, 417);
            this.SavePaymentNoPrint.Name = "SavePaymentNoPrint";
            this.SavePaymentNoPrint.Size = new System.Drawing.Size(65, 16);
            this.SavePaymentNoPrint.TabIndex = 0;
            this.SavePaymentNoPrint.Text = "Save Only";
            // 
            // SavePaymnetandPrint
            // 
            this.SavePaymnetandPrint.AutoSize = true;
            this.SavePaymnetandPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymnetandPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymnetandPrint.Location = new System.Drawing.Point(569, 440);
            this.SavePaymnetandPrint.Name = "SavePaymnetandPrint";
            this.SavePaymnetandPrint.Size = new System.Drawing.Size(91, 16);
            this.SavePaymnetandPrint.TabIndex = 0;
            this.SavePaymnetandPrint.Text = "Save and Print";
            // 
            // CancelPayment
            // 
            this.CancelPayment.AutoSize = true;
            this.CancelPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPayment.ForeColor = System.Drawing.Color.Indigo;
            this.CancelPayment.Location = new System.Drawing.Point(569, 397);
            this.CancelPayment.Name = "CancelPayment";
            this.CancelPayment.Size = new System.Drawing.Size(46, 16);
            this.CancelPayment.TabIndex = 0;
            this.CancelPayment.Text = "Cancle";
            // 
            // ItemsWithoutBarcodeLbl
            // 
            this.ItemsWithoutBarcodeLbl.AutoSize = true;
            this.ItemsWithoutBarcodeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsWithoutBarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ItemsWithoutBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsWithoutBarcodeLbl.Location = new System.Drawing.Point(4, 66);
            this.ItemsWithoutBarcodeLbl.Name = "ItemsWithoutBarcodeLbl";
            this.ItemsWithoutBarcodeLbl.Size = new System.Drawing.Size(142, 14);
            this.ItemsWithoutBarcodeLbl.TabIndex = 54;
            this.ItemsWithoutBarcodeLbl.Text = "ItemsWithoutBarcode";
            // 
            // ItemsWithoutBarcodeComboBox
            // 
            this.ItemsWithoutBarcodeComboBox.DataSource = this.itemsBindingSource1;
            this.ItemsWithoutBarcodeComboBox.DisplayMember = "Description";
            this.ItemsWithoutBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsWithoutBarcodeComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsWithoutBarcodeComboBox.FormattingEnabled = true;
            this.ItemsWithoutBarcodeComboBox.Location = new System.Drawing.Point(171, 55);
            this.ItemsWithoutBarcodeComboBox.Name = "ItemsWithoutBarcodeComboBox";
            this.ItemsWithoutBarcodeComboBox.Size = new System.Drawing.Size(400, 27);
            this.ItemsWithoutBarcodeComboBox.TabIndex = 3;
            this.ItemsWithoutBarcodeComboBox.ValueMember = "Barcode";
            this.ItemsWithoutBarcodeComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsWithoutBarcodeComboBox_KeyPress);
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dBDataSet2;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // priceLevelsTableAdapter
            // 
            this.priceLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.Controls.Add(this.WithoutAddBtn);
            this.HeaderPanel.Controls.Add(this.panel3);
            this.HeaderPanel.Controls.Add(this.DescriptionAddBtn);
            this.HeaderPanel.Controls.Add(this.BarcodeTxtBox);
            this.HeaderPanel.Controls.Add(this.ItemsWithoutBarcodeLbl);
            this.HeaderPanel.Controls.Add(this.ItemsWithoutBarcodeComboBox);
            this.HeaderPanel.Controls.Add(this.BarcodeLbl);
            this.HeaderPanel.Controls.Add(this.ItemDescriptionLbl);
            this.HeaderPanel.Controls.Add(this.ItemDescriptionComboBox);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(784, 152);
            this.HeaderPanel.TabIndex = 127;
            // 
            // WithoutAddBtn
            // 
            this.WithoutAddBtn.BackColor = System.Drawing.Color.Lavender;
            this.WithoutAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green1;
            this.WithoutAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithoutAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithoutAddBtn.FlatAppearance.BorderSize = 0;
            this.WithoutAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithoutAddBtn.Location = new System.Drawing.Point(577, 50);
            this.WithoutAddBtn.Name = "WithoutAddBtn";
            this.WithoutAddBtn.Size = new System.Drawing.Size(32, 32);
            this.WithoutAddBtn.TabIndex = 142;
            this.WithoutAddBtn.UseVisualStyleBackColor = false;
            this.WithoutAddBtn.Click += new System.EventHandler(this.WithoutAddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DecreaseBtn);
            this.panel3.Controls.Add(this.InvoiceNumTxtBox);
            this.panel3.Controls.Add(this.BillNumberLbl);
            this.panel3.Controls.Add(this.ReturnChkBox);
            this.panel3.Controls.Add(this.DeleteItemsBtn);
            this.panel3.Controls.Add(this.IncreaseBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(621, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 152);
            this.panel3.TabIndex = 127;
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Yellowish;
            this.DecreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Location = new System.Drawing.Point(64, 102);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.DecreaseBtn.TabIndex = 55;
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // ReturnChkBox
            // 
            this.ReturnChkBox.AutoSize = true;
            this.ReturnChkBox.BackColor = System.Drawing.Color.Transparent;
            this.ReturnChkBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ReturnChkBox.Location = new System.Drawing.Point(9, 69);
            this.ReturnChkBox.Name = "ReturnChkBox";
            this.ReturnChkBox.Size = new System.Drawing.Size(150, 27);
            this.ReturnChkBox.TabIndex = 143;
            this.ReturnChkBox.Text = "Sales Return";
            this.ReturnChkBox.UseVisualStyleBackColor = false;
            this.ReturnChkBox.CheckedChanged += new System.EventHandler(this.ReturnChkBox_CheckedChanged);
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green1;
            this.IncreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Location = new System.Drawing.Point(122, 102);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.IncreaseBtn.TabIndex = 53;
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click);
            // 
            // DescriptionAddBtn
            // 
            this.DescriptionAddBtn.BackColor = System.Drawing.Color.Lavender;
            this.DescriptionAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green1;
            this.DescriptionAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescriptionAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescriptionAddBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionAddBtn.Location = new System.Drawing.Point(577, 8);
            this.DescriptionAddBtn.Name = "DescriptionAddBtn";
            this.DescriptionAddBtn.Size = new System.Drawing.Size(32, 32);
            this.DescriptionAddBtn.TabIndex = 141;
            this.DescriptionAddBtn.UseVisualStyleBackColor = false;
            this.DescriptionAddBtn.Click += new System.EventHandler(this.DescriptionAddBtn_Click);
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(171, 96);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(400, 33);
            this.BarcodeTxtBox.TabIndex = 129;
            this.BarcodeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTxtBox_KeyPress);
            // 
            // CustomerScreenChkBox
            // 
            this.CustomerScreenChkBox.AutoSize = true;
            this.CustomerScreenChkBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerScreenChkBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerScreenChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerScreenChkBox.Location = new System.Drawing.Point(11, 487);
            this.CustomerScreenChkBox.Name = "CustomerScreenChkBox";
            this.CustomerScreenChkBox.Size = new System.Drawing.Size(172, 27);
            this.CustomerScreenChkBox.TabIndex = 143;
            this.CustomerScreenChkBox.Text = "Customer Screen";
            this.CustomerScreenChkBox.UseVisualStyleBackColor = false;
            this.CustomerScreenChkBox.CheckedChanged += new System.EventHandler(this.CustomerScreenChkBox_CheckedChanged);
            // 
            // DecreaseLbl
            // 
            this.DecreaseLbl.AutoSize = true;
            this.DecreaseLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DecreaseLbl.Location = new System.Drawing.Point(632, 183);
            this.DecreaseLbl.Name = "DecreaseLbl";
            this.DecreaseLbl.Size = new System.Drawing.Size(69, 16);
            this.DecreaseLbl.TabIndex = 56;
            this.DecreaseLbl.Text = "Decrease";
            // 
            // IncreaseLbl
            // 
            this.IncreaseLbl.AutoSize = true;
            this.IncreaseLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.IncreaseLbl.Location = new System.Drawing.Point(551, 246);
            this.IncreaseLbl.Name = "IncreaseLbl";
            this.IncreaseLbl.Size = new System.Drawing.Size(64, 16);
            this.IncreaseLbl.TabIndex = 54;
            this.IncreaseLbl.Text = "Increase";
            // 
            // CustomersAccountAmountTxtBox
            // 
            this.CustomersAccountAmountTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomersAccountAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomersAccountAmountTxtBox.Location = new System.Drawing.Point(3, 177);
            this.CustomersAccountAmountTxtBox.Name = "CustomersAccountAmountTxtBox";
            this.CustomersAccountAmountTxtBox.ReadOnly = true;
            this.CustomersAccountAmountTxtBox.Size = new System.Drawing.Size(258, 21);
            this.CustomersAccountAmountTxtBox.TabIndex = 0;
            this.CustomersAccountAmountTxtBox.TabStop = false;
            // 
            // CustomersAccountAmount
            // 
            this.CustomersAccountAmount.AutoSize = true;
            this.CustomersAccountAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersAccountAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.CustomersAccountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomersAccountAmount.Location = new System.Drawing.Point(6, 161);
            this.CustomersAccountAmount.Name = "CustomersAccountAmount";
            this.CustomersAccountAmount.Size = new System.Drawing.Size(121, 14);
            this.CustomersAccountAmount.TabIndex = 0;
            this.CustomersAccountAmount.Text = "Customer Account";
            // 
            // rigthPanel
            // 
            this.rigthPanel.BackColor = System.Drawing.Color.Transparent;
            this.rigthPanel.Controls.Add(this.PrintingThermalA4ChkBox);
            this.rigthPanel.Controls.Add(this.MinimizePB);
            this.rigthPanel.Controls.Add(this.ExitPB);
            this.rigthPanel.Controls.Add(this.OpenCashBtn);
            this.rigthPanel.Controls.Add(this.CancleBtn);
            this.rigthPanel.Controls.Add(this.PaymentOnlyBtn);
            this.rigthPanel.Controls.Add(this.PaymentAndPrintBtn);
            this.rigthPanel.Controls.Add(this.CommentsLbl);
            this.rigthPanel.Controls.Add(this.CommentsTxtBox);
            this.rigthPanel.Controls.Add(this.TotalBillLbl);
            this.rigthPanel.Controls.Add(this.TotalDiscountLbl);
            this.rigthPanel.Controls.Add(this.DiscountOnBillLbl);
            this.rigthPanel.Controls.Add(this.TotalTaxlbl);
            this.rigthPanel.Controls.Add(this.PriceLevelLbl);
            this.rigthPanel.Controls.Add(this.NetAmountLbl);
            this.rigthPanel.Controls.Add(this.SubtotalLbl);
            this.rigthPanel.Controls.Add(this.TaxTxtBox);
            this.rigthPanel.Controls.Add(this.TotalDiscountTxtBox);
            this.rigthPanel.Controls.Add(this.PriceLvlDiscountLbl);
            this.rigthPanel.Controls.Add(this.DiscountBillPercLbl);
            this.rigthPanel.Controls.Add(this.NetAmountTxtBox);
            this.rigthPanel.Controls.Add(this.DiscountBillTxtBox);
            this.rigthPanel.Controls.Add(this.SubtotalTxtBox);
            this.rigthPanel.Controls.Add(this.PriceLevelComboBox);
            this.rigthPanel.Controls.Add(this.PriceLevelDiscount);
            this.rigthPanel.Controls.Add(this.DiscountPercTxtBox);
            this.rigthPanel.Controls.Add(this.TotalTxtBox);
            this.rigthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rigthPanel.Location = new System.Drawing.Point(784, 0);
            this.rigthPanel.Name = "rigthPanel";
            this.rigthPanel.Size = new System.Drawing.Size(242, 665);
            this.rigthPanel.TabIndex = 128;
            // 
            // PrintingThermalA4ChkBox
            // 
            this.PrintingThermalA4ChkBox.AutoSize = true;
            this.PrintingThermalA4ChkBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingThermalA4ChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PrintingThermalA4ChkBox.Location = new System.Drawing.Point(4, 642);
            this.PrintingThermalA4ChkBox.Name = "PrintingThermalA4ChkBox";
            this.PrintingThermalA4ChkBox.Size = new System.Drawing.Size(141, 20);
            this.PrintingThermalA4ChkBox.TabIndex = 157;
            this.PrintingThermalA4ChkBox.Text = "Export As PDF File";
            this.PrintingThermalA4ChkBox.UseVisualStyleBackColor = true;
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
            this.OpenCashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.OpenCashBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.OpenCash_New;
            this.OpenCashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCashBtn.FlatAppearance.BorderSize = 0;
            this.OpenCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCashBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenCashBtn.ForeColor = System.Drawing.Color.White;
            this.OpenCashBtn.Location = new System.Drawing.Point(3, 592);
            this.OpenCashBtn.Name = "OpenCashBtn";
            this.OpenCashBtn.Size = new System.Drawing.Size(236, 50);
            this.OpenCashBtn.TabIndex = 16;
            this.OpenCashBtn.Text = "Open Cash";
            this.OpenCashBtn.UseVisualStyleBackColor = false;
            this.OpenCashBtn.Click += new System.EventHandler(this.OpenCashBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(667, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "JOD";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel.Controls.Add(this.TeldgView);
            this.LeftPanel.Controls.Add(this.DecreaseLbl);
            this.LeftPanel.Controls.Add(this.CancelPayment);
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.IncreaseLbl);
            this.LeftPanel.Controls.Add(this.SavePaymentNoPrint);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.SavePaymnetandPrint);
            this.LeftPanel.Controls.Add(this.Inner_left_down_panel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 152);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(784, 513);
            this.LeftPanel.TabIndex = 54;
            // 
            // Inner_left_down_panel
            // 
            this.Inner_left_down_panel.Controls.Add(this.CustomerNameTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodCheckBox);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodDescripTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomerScreenChkBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomersAccountAmountTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.PhoneTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.AccountDescriptionTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomersAccountAmount);
            this.Inner_left_down_panel.Controls.Add(this.AccountComboBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomerPhoneLbl);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodLbl);
            this.Inner_left_down_panel.Controls.Add(this.AccountLbl);
            this.Inner_left_down_panel.Controls.Add(this.CashPaymentGB);
            this.Inner_left_down_panel.Controls.Add(this.CheckGB);
            this.Inner_left_down_panel.Controls.Add(this.PayInVisaGB);
            this.Inner_left_down_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Inner_left_down_panel.Location = new System.Drawing.Point(0, 0);
            this.Inner_left_down_panel.Name = "Inner_left_down_panel";
            this.Inner_left_down_panel.Size = new System.Drawing.Size(264, 513);
            this.Inner_left_down_panel.TabIndex = 33;
            // 
            // F2ShortcutLbl
            // 
            this.F2ShortcutLbl.Name = "F2ShortcutLbl";
            this.F2ShortcutLbl.Size = new System.Drawing.Size(165, 25);
            this.F2ShortcutLbl.Text = "F2=Save and Print";
            // 
            // F4ShortcutLbl
            // 
            this.F4ShortcutLbl.Name = "F4ShortcutLbl";
            this.F4ShortcutLbl.Size = new System.Drawing.Size(165, 25);
            this.F4ShortcutLbl.Text = "| F4=Save no Print";
            // 
            // EscShortcutLbl
            // 
            this.EscShortcutLbl.Name = "EscShortcutLbl";
            this.EscShortcutLbl.Size = new System.Drawing.Size(134, 25);
            this.EscShortcutLbl.Text = "| ESC = Cancle";
            // 
            // WithoutBarcodeTableAdapter
            // 
            this.WithoutBarcodeTableAdapter.ClearBeforeFill = true;
            // 
            // POS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.rigthPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.CashPaymentGB.ResumeLayout(false);
            this.CashPaymentGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.CheckGB.ResumeLayout(false);
            this.CheckGB.PerformLayout();
            this.PayInVisaGB.ResumeLayout(false);
            this.PayInVisaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.rigthPanel.ResumeLayout(false);
            this.rigthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.Inner_left_down_panel.ResumeLayout(false);
            this.Inner_left_down_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.TextBox InvoiceNumTxtBox;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label ItemDescriptionLbl;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.Label TotalDiscountLbl;
        private System.Windows.Forms.Label DiscountOnBillLbl;
        private System.Windows.Forms.Label TotalTaxlbl;
        private System.Windows.Forms.Label PriceLevelLbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.TextBox TaxTxtBox;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.TextBox TotalDiscountTxtBox;
        private System.Windows.Forms.Label PriceLvlDiscountLbl;
        private System.Windows.Forms.Label DiscountBillPercLbl;
        private System.Windows.Forms.TextBox DiscountBillTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.ComboBox PriceLevelComboBox;
        private System.Windows.Forms.TextBox PriceLevelDiscount;
        private System.Windows.Forms.TextBox DiscountPercTxtBox;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.GroupBox CashPaymentGB;
        private System.Windows.Forms.TextBox ExchangeTxtBox;
        private System.Windows.Forms.Label ExchangeLbl;
        private System.Windows.Forms.TextBox CashInTxtBox;
        private System.Windows.Forms.Label CashInLbl;
        private System.Windows.Forms.Button CancleBtn;
        private System.Windows.Forms.Button PaymentOnlyBtn;
        private System.Windows.Forms.Button PaymentAndPrintBtn;
        private System.Windows.Forms.GroupBox PayInVisaGB;
        private System.Windows.Forms.TextBox CreditCardInfoTxtBox;
        private System.Windows.Forms.Label PaymentCommentsLbl;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.Label BillNumberLbl;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.TextBox NetAmountTxtBox;
        private System.Windows.Forms.Label NetAmountLbl;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.Label CurrencyLbl;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label SellPriceLbl;
        private System.Windows.Forms.Label BuyRateLbl;
        private System.Windows.Forms.TextBox SellRateTxtBox;
        private System.Windows.Forms.TextBox BuyRateTxtBox;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.TextBox AccountDescriptionTxtBox;
        private System.Windows.Forms.Label CashInCurrency;
        private System.Windows.Forms.Label JODstatic;
        private System.Windows.Forms.ComboBox PaymentMethodCheckBox;
        private System.Windows.Forms.Label PaymentMethodLbl;
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
        private System.Windows.Forms.Label SavePaymentNoPrint;
        private System.Windows.Forms.Label SavePaymnetandPrint;
        private System.Windows.Forms.Label CancelPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CashMethodComboBox;
        private System.Windows.Forms.Label CashMethodLbl;
        private System.Windows.Forms.Label IsCreditLbl;
        private System.Windows.Forms.Label ItemsWithoutBarcodeLbl;
        private System.Windows.Forms.ComboBox ItemsWithoutBarcodeComboBox;
        private DBDataSet dBDataSet=null;        
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private DBDataSet dBDataSet2=null;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DBDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBDataSetTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private System.Windows.Forms.BindingSource priceLevelsBindingSource;
        private DBDataSetTableAdapters.PriceLevelsTableAdapter priceLevelsTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DBDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel rigthPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Label CustomersAccountAmount;
        private System.Windows.Forms.TextBox CustomersAccountAmountTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Inner_left_down_panel;
        private System.Windows.Forms.ToolStripStatusLabel F2ShortcutLbl;
        private System.Windows.Forms.ToolStripStatusLabel F4ShortcutLbl;
        private DBDataSetTableAdapters.ItemsTableAdapter WithoutBarcodeTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Label DecreaseLbl;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.Label IncreaseLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripStatusLabel EscShortcutLbl;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.Button WithoutAddBtn;
        private System.Windows.Forms.Button DescriptionAddBtn;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Button OpenCashBtn;
        private System.Windows.Forms.CheckBox ReturnChkBox;
        private System.Windows.Forms.CheckBox PrintingThermalA4ChkBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private System.Windows.Forms.CheckBox CustomerScreenChkBox;
    }
}