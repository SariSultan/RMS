namespace Calcium_RMS
{
    partial class TouchScreenFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelDown = new System.Windows.Forms.Panel();
            this.SavePaymnetandPrint = new System.Windows.Forms.Label();
            this.CashInCurrency = new System.Windows.Forms.Label();
            this.JODstatic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.SavePaymentNoPrint = new System.Windows.Forms.Label();
            this.CancelPayment = new System.Windows.Forms.Label();
            this.EnableNumpadChkBox = new System.Windows.Forms.CheckBox();
            this.ReturnChkBox = new System.Windows.Forms.CheckBox();
            this.CustomerScreenChkBox = new System.Windows.Forms.CheckBox();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.PrintingThermalA4ChkBox = new System.Windows.Forms.CheckBox();
            this.PaymentAndPrintBtn = new System.Windows.Forms.Button();
            this.PaymentOnlyBtn = new System.Windows.Forms.Button();
            this.OpenCashBtn = new System.Windows.Forms.Button();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.TotalDiscountLbl = new System.Windows.Forms.Label();
            this.DiscountOnBillLbl = new System.Windows.Forms.Label();
            this.TotalTaxlbl = new System.Windows.Forms.Label();
            this.PriceLevelLbl = new System.Windows.Forms.Label();
            this.NetAmountLbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.TaxTxtBox = new System.Windows.Forms.TextBox();
            this.TotalDiscountTxtBox = new System.Windows.Forms.TextBox();
            this.PriceLvlDiscountLbl = new System.Windows.Forms.Label();
            this.DiscountBillPercLbl = new System.Windows.Forms.Label();
            this.NetAmountTxtBox = new System.Windows.Forms.TextBox();
            this.DiscountBillTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.PriceLevelComboBox = new System.Windows.Forms.ComboBox();
            this.priceLevelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.PriceLevelDiscount = new System.Windows.Forms.TextBox();
            this.DiscountPercTxtBox = new System.Windows.Forms.TextBox();
            this.InvoiceNumTxtBox = new System.Windows.Forms.TextBox();
            this.BillNumberLbl = new System.Windows.Forms.Label();
            this.Inner_left_down_panel = new System.Windows.Forms.Panel();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.PaymentMethodCheckBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.PaymentMethodDescripTxtBox = new System.Windows.Forms.TextBox();
            this.CustomersAccountAmountTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CustomersAccountAmount = new System.Windows.Forms.Label();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.PaymentMethodLbl = new System.Windows.Forms.Label();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.AccountDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.CashPaymentGB = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IsCreditLbl = new System.Windows.Forms.Label();
            this.CashMethodComboBox = new System.Windows.Forms.ComboBox();
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
            this.paymentMethodTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PaymentMethodTableAdapter();
            this.accountsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.AccountsTableAdapter();
            this.currencyTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CurrencyTableAdapter();
            this.priceLevelsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PriceLevelsTableAdapter();
            this.Numpad = new CalciumsComponents.Numpad();
            this.atab = new FlatTabControl.FlatTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            this.PanelDown.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceLevelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.Inner_left_down_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.CashPaymentGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.CheckGB.SuspendLayout();
            this.PayInVisaGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            this.TeldgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
            this.TeldgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeldgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TeldgView.ColumnHeadersHeight = 28;
            this.TeldgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.Qty,
            this.PricePerUnit,
            this.Tax,
            this.PriceTotal,
            this.AvalQty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TeldgView.Location = new System.Drawing.Point(0, 0);
            this.TeldgView.Name = "TeldgView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TeldgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.TeldgView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(476, 248);
            this.TeldgView.StandardTab = true;
            this.TeldgView.TabIndex = 6;
            this.TeldgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeldgView_CellValueChanged);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Qty.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.AvalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AvalQty.HeaderText = "AvalQty";
            this.AvalQty.Name = "AvalQty";
            // 
            // PanelDown
            // 
            this.PanelDown.Controls.Add(this.TeldgView);
            this.PanelDown.Controls.Add(this.SavePaymnetandPrint);
            this.PanelDown.Controls.Add(this.CashInCurrency);
            this.PanelDown.Controls.Add(this.JODstatic);
            this.PanelDown.Controls.Add(this.panel1);
            this.PanelDown.Controls.Add(this.SavePaymentNoPrint);
            this.PanelDown.Controls.Add(this.CancelPayment);
            this.PanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelDown.Location = new System.Drawing.Point(256, 452);
            this.PanelDown.Name = "PanelDown";
            this.PanelDown.Size = new System.Drawing.Size(531, 248);
            this.PanelDown.TabIndex = 7;
            // 
            // SavePaymnetandPrint
            // 
            this.SavePaymnetandPrint.AutoSize = true;
            this.SavePaymnetandPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymnetandPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymnetandPrint.Location = new System.Drawing.Point(375, 97);
            this.SavePaymnetandPrint.Name = "SavePaymnetandPrint";
            this.SavePaymnetandPrint.Size = new System.Drawing.Size(79, 16);
            this.SavePaymnetandPrint.TabIndex = 0;
            this.SavePaymnetandPrint.Text = "Save && Print";
            // 
            // CashInCurrency
            // 
            this.CashInCurrency.AutoSize = true;
            this.CashInCurrency.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInCurrency.ForeColor = System.Drawing.Color.White;
            this.CashInCurrency.Location = new System.Drawing.Point(192, 46);
            this.CashInCurrency.Name = "CashInCurrency";
            this.CashInCurrency.Size = new System.Drawing.Size(34, 16);
            this.CashInCurrency.TabIndex = 0;
            this.CashInCurrency.Text = "JOD";
            // 
            // JODstatic
            // 
            this.JODstatic.AutoSize = true;
            this.JODstatic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JODstatic.ForeColor = System.Drawing.Color.White;
            this.JODstatic.Location = new System.Drawing.Point(89, 116);
            this.JODstatic.Name = "JODstatic";
            this.JODstatic.Size = new System.Drawing.Size(34, 16);
            this.JODstatic.TabIndex = 0;
            this.JODstatic.Text = "JOD";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.IncreaseBtn);
            this.panel1.Controls.Add(this.DecreaseBtn);
            this.panel1.Controls.Add(this.DeleteItemsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(476, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 248);
            this.panel1.TabIndex = 7;
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.Lavender;
            this.IncreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.TouchBtns_01;
            this.IncreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Location = new System.Drawing.Point(-1, 1);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(58, 83);
            this.IncreaseBtn.TabIndex = 73;
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click);
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Lavender;
            this.DecreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.TouchBtns_02;
            this.DecreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Location = new System.Drawing.Point(-1, 84);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(58, 83);
            this.DecreaseBtn.TabIndex = 75;
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Lavender;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.TouchBtns_03;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(-1, 167);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(58, 83);
            this.DeleteItemsBtn.TabIndex = 71;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            this.DeleteItemsBtn.Click += new System.EventHandler(this.DeleteItemsBtn_Click);
            // 
            // SavePaymentNoPrint
            // 
            this.SavePaymentNoPrint.AutoSize = true;
            this.SavePaymentNoPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymentNoPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymentNoPrint.Location = new System.Drawing.Point(307, 97);
            this.SavePaymentNoPrint.Name = "SavePaymentNoPrint";
            this.SavePaymentNoPrint.Size = new System.Drawing.Size(65, 16);
            this.SavePaymentNoPrint.TabIndex = 0;
            this.SavePaymentNoPrint.Text = "Save Only";
            // 
            // CancelPayment
            // 
            this.CancelPayment.AutoSize = true;
            this.CancelPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPayment.ForeColor = System.Drawing.Color.Indigo;
            this.CancelPayment.Location = new System.Drawing.Point(246, 97);
            this.CancelPayment.Name = "CancelPayment";
            this.CancelPayment.Size = new System.Drawing.Size(46, 16);
            this.CancelPayment.TabIndex = 0;
            this.CancelPayment.Text = "Cancle";
            // 
            // EnableNumpadChkBox
            // 
            this.EnableNumpadChkBox.AutoSize = true;
            this.EnableNumpadChkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EnableNumpadChkBox.Checked = true;
            this.EnableNumpadChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableNumpadChkBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EnableNumpadChkBox.FlatAppearance.BorderSize = 10;
            this.EnableNumpadChkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.EnableNumpadChkBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EnableNumpadChkBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.EnableNumpadChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableNumpadChkBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableNumpadChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.EnableNumpadChkBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnableNumpadChkBox.Location = new System.Drawing.Point(25, 657);
            this.EnableNumpadChkBox.Name = "EnableNumpadChkBox";
            this.EnableNumpadChkBox.Size = new System.Drawing.Size(107, 29);
            this.EnableNumpadChkBox.TabIndex = 17;
            this.EnableNumpadChkBox.Text = "Numpad";
            this.EnableNumpadChkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EnableNumpadChkBox.UseVisualStyleBackColor = true;
            // 
            // ReturnChkBox
            // 
            this.ReturnChkBox.AutoSize = true;
            this.ReturnChkBox.BackColor = System.Drawing.Color.Transparent;
            this.ReturnChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnChkBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ReturnChkBox.Location = new System.Drawing.Point(27, 608);
            this.ReturnChkBox.Name = "ReturnChkBox";
            this.ReturnChkBox.Size = new System.Drawing.Size(146, 29);
            this.ReturnChkBox.TabIndex = 144;
            this.ReturnChkBox.Text = "Sales Return";
            this.ReturnChkBox.UseVisualStyleBackColor = false;
            this.ReturnChkBox.CheckedChanged += new System.EventHandler(this.ReturnChkBox_CheckedChanged);
            // 
            // CustomerScreenChkBox
            // 
            this.CustomerScreenChkBox.AutoSize = true;
            this.CustomerScreenChkBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomerScreenChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerScreenChkBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerScreenChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerScreenChkBox.Location = new System.Drawing.Point(26, 631);
            this.CustomerScreenChkBox.Name = "CustomerScreenChkBox";
            this.CustomerScreenChkBox.Size = new System.Drawing.Size(188, 29);
            this.CustomerScreenChkBox.TabIndex = 145;
            this.CustomerScreenChkBox.Text = "Customer Screen";
            this.CustomerScreenChkBox.UseVisualStyleBackColor = false;
            this.CustomerScreenChkBox.CheckedChanged += new System.EventHandler(this.CustomerScreenChkBox_CheckedChanged);
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.Color.Transparent;
            this.PanelRight.Controls.Add(this.MinimizePB);
            this.PanelRight.Controls.Add(this.ExitPB);
            this.PanelRight.Controls.Add(this.panel5);
            this.PanelRight.Controls.Add(this.TotalTxtBox);
            this.PanelRight.Controls.Add(this.label2);
            this.PanelRight.Controls.Add(this.CommentsLbl);
            this.PanelRight.Controls.Add(this.CommentsTxtBox);
            this.PanelRight.Controls.Add(this.TotalBillLbl);
            this.PanelRight.Controls.Add(this.TotalDiscountLbl);
            this.PanelRight.Controls.Add(this.DiscountOnBillLbl);
            this.PanelRight.Controls.Add(this.TotalTaxlbl);
            this.PanelRight.Controls.Add(this.PriceLevelLbl);
            this.PanelRight.Controls.Add(this.NetAmountLbl);
            this.PanelRight.Controls.Add(this.SubtotalLbl);
            this.PanelRight.Controls.Add(this.TaxTxtBox);
            this.PanelRight.Controls.Add(this.TotalDiscountTxtBox);
            this.PanelRight.Controls.Add(this.PriceLvlDiscountLbl);
            this.PanelRight.Controls.Add(this.DiscountBillPercLbl);
            this.PanelRight.Controls.Add(this.NetAmountTxtBox);
            this.PanelRight.Controls.Add(this.DiscountBillTxtBox);
            this.PanelRight.Controls.Add(this.SubtotalTxtBox);
            this.PanelRight.Controls.Add(this.PriceLevelComboBox);
            this.PanelRight.Controls.Add(this.PriceLevelDiscount);
            this.PanelRight.Controls.Add(this.DiscountPercTxtBox);
            this.PanelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelRight.Location = new System.Drawing.Point(787, 0);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(233, 700);
            this.PanelRight.TabIndex = 7;
            // 
            // MinimizePB
            // 
            this.MinimizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePB.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePB.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.MinimizePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Location = new System.Drawing.Point(575, 4);
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
            this.ExitPB.Location = new System.Drawing.Point(596, 4);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(15, 15);
            this.ExitPB.TabIndex = 115;
            this.ExitPB.TabStop = false;
            this.ExitPB.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.PrintingThermalA4ChkBox);
            this.panel5.Controls.Add(this.PaymentAndPrintBtn);
            this.panel5.Controls.Add(this.PaymentOnlyBtn);
            this.panel5.Controls.Add(this.OpenCashBtn);
            this.panel5.Controls.Add(this.CancleBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 478);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(233, 222);
            this.panel5.TabIndex = 75;
            // 
            // PrintingThermalA4ChkBox
            // 
            this.PrintingThermalA4ChkBox.AutoSize = true;
            this.PrintingThermalA4ChkBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingThermalA4ChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(159)))));
            this.PrintingThermalA4ChkBox.Location = new System.Drawing.Point(22, 192);
            this.PrintingThermalA4ChkBox.Name = "PrintingThermalA4ChkBox";
            this.PrintingThermalA4ChkBox.Size = new System.Drawing.Size(178, 23);
            this.PrintingThermalA4ChkBox.TabIndex = 158;
            this.PrintingThermalA4ChkBox.Text = "Export As PDF File";
            this.PrintingThermalA4ChkBox.UseVisualStyleBackColor = true;
            // 
            // PaymentAndPrintBtn
            // 
            this.PaymentAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.PaymentAndPrintBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.SavePrint_New;
            this.PaymentAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentAndPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentAndPrintBtn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.PaymentAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.PaymentAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentAndPrintBtn.Location = new System.Drawing.Point(22, 9);
            this.PaymentAndPrintBtn.Name = "PaymentAndPrintBtn";
            this.PaymentAndPrintBtn.Size = new System.Drawing.Size(187, 40);
            this.PaymentAndPrintBtn.TabIndex = 15;
            this.PaymentAndPrintBtn.Text = "Save and Print|(F2)";
            this.PaymentAndPrintBtn.UseVisualStyleBackColor = false;
            this.PaymentAndPrintBtn.Click += new System.EventHandler(this.PaymentAndPrintBtn_Click);
            // 
            // PaymentOnlyBtn
            // 
            this.PaymentOnlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.PaymentOnlyBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.SaveOnly_New;
            this.PaymentOnlyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentOnlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaymentOnlyBtn.FlatAppearance.BorderSize = 0;
            this.PaymentOnlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentOnlyBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOnlyBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentOnlyBtn.Location = new System.Drawing.Point(22, 54);
            this.PaymentOnlyBtn.Name = "PaymentOnlyBtn";
            this.PaymentOnlyBtn.Size = new System.Drawing.Size(187, 40);
            this.PaymentOnlyBtn.TabIndex = 14;
            this.PaymentOnlyBtn.Text = "Save Only|(F4)";
            this.PaymentOnlyBtn.UseVisualStyleBackColor = false;
            this.PaymentOnlyBtn.Click += new System.EventHandler(this.PaymentOnlyBtn_Click);
            // 
            // OpenCashBtn
            // 
            this.OpenCashBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(25)))));
            this.OpenCashBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.OpenCash_New;
            this.OpenCashBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenCashBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenCashBtn.FlatAppearance.BorderSize = 0;
            this.OpenCashBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenCashBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenCashBtn.ForeColor = System.Drawing.Color.White;
            this.OpenCashBtn.Location = new System.Drawing.Point(22, 144);
            this.OpenCashBtn.Name = "OpenCashBtn";
            this.OpenCashBtn.Size = new System.Drawing.Size(187, 40);
            this.OpenCashBtn.TabIndex = 16;
            this.OpenCashBtn.Text = "Open Cash|(F6)";
            this.OpenCashBtn.UseVisualStyleBackColor = false;
            this.OpenCashBtn.Click += new System.EventHandler(this.OpenCashBtn_Click);
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(159)))));
            this.CancleBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Cancel_New;
            this.CancleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancleBtn.FlatAppearance.BorderSize = 0;
            this.CancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(22, 99);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(187, 40);
            this.CancleBtn.TabIndex = 16;
            this.CancleBtn.Text = "Cancel|(ESC)";
            this.CancleBtn.UseVisualStyleBackColor = false;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.White;
            this.TotalTxtBox.Location = new System.Drawing.Point(24, 365);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(187, 43);
            this.TotalTxtBox.TabIndex = 52;
            this.TotalTxtBox.TabStop = false;
            this.TotalTxtBox.Text = "0.00";
            this.TotalTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(171, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "JOD";
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CommentsLbl.Location = new System.Drawing.Point(24, 409);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(95, 19);
            this.CommentsLbl.TabIndex = 50;
            this.CommentsLbl.Text = "Comments";
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.BackColor = System.Drawing.Color.White;
            this.CommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(24, 431);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(187, 46);
            this.CommentsTxtBox.TabIndex = 54;
            this.CommentsTxtBox.TabStop = false;
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalBillLbl.Location = new System.Drawing.Point(24, 338);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(80, 25);
            this.TotalBillLbl.TabIndex = 51;
            this.TotalBillLbl.Text = "TOTAL";
            // 
            // TotalDiscountLbl
            // 
            this.TotalDiscountLbl.AutoSize = true;
            this.TotalDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalDiscountLbl.Location = new System.Drawing.Point(27, 207);
            this.TotalDiscountLbl.Name = "TotalDiscountLbl";
            this.TotalDiscountLbl.Size = new System.Drawing.Size(100, 16);
            this.TotalDiscountLbl.TabIndex = 65;
            this.TotalDiscountLbl.Text = "Total Discount";
            // 
            // DiscountOnBillLbl
            // 
            this.DiscountOnBillLbl.AutoSize = true;
            this.DiscountOnBillLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountOnBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountOnBillLbl.Location = new System.Drawing.Point(24, 74);
            this.DiscountOnBillLbl.Name = "DiscountOnBillLbl";
            this.DiscountOnBillLbl.Size = new System.Drawing.Size(99, 16);
            this.DiscountOnBillLbl.TabIndex = 63;
            this.DiscountOnBillLbl.Text = "Dicount On Bill";
            // 
            // TotalTaxlbl
            // 
            this.TotalTaxlbl.AutoSize = true;
            this.TotalTaxlbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalTaxlbl.Location = new System.Drawing.Point(24, 251);
            this.TotalTaxlbl.Name = "TotalTaxlbl";
            this.TotalTaxlbl.Size = new System.Drawing.Size(66, 16);
            this.TotalTaxlbl.TabIndex = 64;
            this.TotalTaxlbl.Text = "Total Tax";
            // 
            // PriceLevelLbl
            // 
            this.PriceLevelLbl.AutoSize = true;
            this.PriceLevelLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLevelLbl.Location = new System.Drawing.Point(25, 116);
            this.PriceLevelLbl.Name = "PriceLevelLbl";
            this.PriceLevelLbl.Size = new System.Drawing.Size(78, 16);
            this.PriceLevelLbl.TabIndex = 69;
            this.PriceLevelLbl.Text = "Price Level";
            // 
            // NetAmountLbl
            // 
            this.NetAmountLbl.AutoSize = true;
            this.NetAmountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetAmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.NetAmountLbl.Location = new System.Drawing.Point(24, 295);
            this.NetAmountLbl.Name = "NetAmountLbl";
            this.NetAmountLbl.Size = new System.Drawing.Size(113, 16);
            this.NetAmountLbl.TabIndex = 68;
            this.NetAmountLbl.Text = "Total Before Tax";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SubtotalLbl.Location = new System.Drawing.Point(23, 4);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(63, 16);
            this.SubtotalLbl.TabIndex = 67;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // TaxTxtBox
            // 
            this.TaxTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TaxTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxtBox.ForeColor = System.Drawing.Color.White;
            this.TaxTxtBox.Location = new System.Drawing.Point(24, 269);
            this.TaxTxtBox.Name = "TaxTxtBox";
            this.TaxTxtBox.ReadOnly = true;
            this.TaxTxtBox.Size = new System.Drawing.Size(184, 23);
            this.TaxTxtBox.TabIndex = 62;
            this.TaxTxtBox.TabStop = false;
            this.TaxTxtBox.Text = "0";
            // 
            // TotalDiscountTxtBox
            // 
            this.TotalDiscountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.TotalDiscountTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDiscountTxtBox.ForeColor = System.Drawing.Color.White;
            this.TotalDiscountTxtBox.Location = new System.Drawing.Point(24, 225);
            this.TotalDiscountTxtBox.Name = "TotalDiscountTxtBox";
            this.TotalDiscountTxtBox.ReadOnly = true;
            this.TotalDiscountTxtBox.Size = new System.Drawing.Size(184, 23);
            this.TotalDiscountTxtBox.TabIndex = 57;
            this.TotalDiscountTxtBox.TabStop = false;
            this.TotalDiscountTxtBox.Text = "0";
            // 
            // PriceLvlDiscountLbl
            // 
            this.PriceLvlDiscountLbl.AutoSize = true;
            this.PriceLvlDiscountLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLvlDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLvlDiscountLbl.Location = new System.Drawing.Point(23, 163);
            this.PriceLvlDiscountLbl.Name = "PriceLvlDiscountLbl";
            this.PriceLvlDiscountLbl.Size = new System.Drawing.Size(102, 16);
            this.PriceLvlDiscountLbl.TabIndex = 66;
            this.PriceLvlDiscountLbl.Text = "Level Discount";
            // 
            // DiscountBillPercLbl
            // 
            this.DiscountBillPercLbl.AutoSize = true;
            this.DiscountBillPercLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBillPercLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountBillPercLbl.Location = new System.Drawing.Point(23, 51);
            this.DiscountBillPercLbl.Name = "DiscountBillPercLbl";
            this.DiscountBillPercLbl.Size = new System.Drawing.Size(103, 19);
            this.DiscountBillPercLbl.TabIndex = 70;
            this.DiscountBillPercLbl.Text = "Discount %";
            // 
            // NetAmountTxtBox
            // 
            this.NetAmountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.NetAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetAmountTxtBox.ForeColor = System.Drawing.Color.White;
            this.NetAmountTxtBox.Location = new System.Drawing.Point(24, 313);
            this.NetAmountTxtBox.Name = "NetAmountTxtBox";
            this.NetAmountTxtBox.ReadOnly = true;
            this.NetAmountTxtBox.Size = new System.Drawing.Size(184, 23);
            this.NetAmountTxtBox.TabIndex = 60;
            this.NetAmountTxtBox.TabStop = false;
            this.NetAmountTxtBox.Text = "0";
            // 
            // DiscountBillTxtBox
            // 
            this.DiscountBillTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountBillTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountBillTxtBox.ForeColor = System.Drawing.Color.White;
            this.DiscountBillTxtBox.Location = new System.Drawing.Point(24, 92);
            this.DiscountBillTxtBox.Name = "DiscountBillTxtBox";
            this.DiscountBillTxtBox.ReadOnly = true;
            this.DiscountBillTxtBox.Size = new System.Drawing.Size(184, 23);
            this.DiscountBillTxtBox.TabIndex = 58;
            this.DiscountBillTxtBox.TabStop = false;
            this.DiscountBillTxtBox.Text = "0";
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.White;
            this.SubtotalTxtBox.Location = new System.Drawing.Point(24, 20);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(184, 23);
            this.SubtotalTxtBox.TabIndex = 61;
            this.SubtotalTxtBox.TabStop = false;
            this.SubtotalTxtBox.Text = "0";
            // 
            // PriceLevelComboBox
            // 
            this.PriceLevelComboBox.DataSource = this.priceLevelsBindingSource;
            this.PriceLevelComboBox.DisplayMember = "Name";
            this.PriceLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriceLevelComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLevelComboBox.FormattingEnabled = true;
            this.PriceLevelComboBox.Location = new System.Drawing.Point(23, 134);
            this.PriceLevelComboBox.Name = "PriceLevelComboBox";
            this.PriceLevelComboBox.Size = new System.Drawing.Size(184, 24);
            this.PriceLevelComboBox.TabIndex = 56;
            this.PriceLevelComboBox.ValueMember = "ID";
            this.PriceLevelComboBox.SelectedValueChanged += new System.EventHandler(this.PriceLevelComboBox_SelectedValueChanged_1);
            // 
            // priceLevelsBindingSource
            // 
            this.priceLevelsBindingSource.DataMember = "PriceLevels";
            this.priceLevelsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriceLevelDiscount
            // 
            this.PriceLevelDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PriceLevelDiscount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLevelDiscount.ForeColor = System.Drawing.Color.White;
            this.PriceLevelDiscount.Location = new System.Drawing.Point(24, 181);
            this.PriceLevelDiscount.Name = "PriceLevelDiscount";
            this.PriceLevelDiscount.ReadOnly = true;
            this.PriceLevelDiscount.Size = new System.Drawing.Size(184, 23);
            this.PriceLevelDiscount.TabIndex = 59;
            this.PriceLevelDiscount.TabStop = false;
            this.PriceLevelDiscount.Text = "0";
            // 
            // DiscountPercTxtBox
            // 
            this.DiscountPercTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPercTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.DiscountPercTxtBox.Location = new System.Drawing.Point(145, 46);
            this.DiscountPercTxtBox.Name = "DiscountPercTxtBox";
            this.DiscountPercTxtBox.Size = new System.Drawing.Size(63, 27);
            this.DiscountPercTxtBox.TabIndex = 55;
            this.DiscountPercTxtBox.Text = "0";
            this.DiscountPercTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscountPercTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiscountPercTxtBox_MouseClick);
            this.DiscountPercTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountPercTxtBox_KeyPress);
            // 
            // InvoiceNumTxtBox
            // 
            this.InvoiceNumTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.InvoiceNumTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumTxtBox.ForeColor = System.Drawing.Color.White;
            this.InvoiceNumTxtBox.Location = new System.Drawing.Point(136, 28);
            this.InvoiceNumTxtBox.Name = "InvoiceNumTxtBox";
            this.InvoiceNumTxtBox.ReadOnly = true;
            this.InvoiceNumTxtBox.Size = new System.Drawing.Size(96, 23);
            this.InvoiceNumTxtBox.TabIndex = 73;
            this.InvoiceNumTxtBox.TabStop = false;
            // 
            // BillNumberLbl
            // 
            this.BillNumberLbl.AutoSize = true;
            this.BillNumberLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BillNumberLbl.Location = new System.Drawing.Point(22, 30);
            this.BillNumberLbl.Name = "BillNumberLbl";
            this.BillNumberLbl.Size = new System.Drawing.Size(108, 16);
            this.BillNumberLbl.TabIndex = 74;
            this.BillNumberLbl.Text = "Invoice Number";
            // 
            // Inner_left_down_panel
            // 
            this.Inner_left_down_panel.BackColor = System.Drawing.Color.Transparent;
            this.Inner_left_down_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Inner_left_down_panel.Controls.Add(this.AccountLbl);
            this.Inner_left_down_panel.Controls.Add(this.CustomerScreenChkBox);
            this.Inner_left_down_panel.Controls.Add(this.InvoiceNumTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.ReturnChkBox);
            this.Inner_left_down_panel.Controls.Add(this.BillNumberLbl);
            this.Inner_left_down_panel.Controls.Add(this.EnableNumpadChkBox);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodCheckBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomerNameLbl);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodDescripTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomersAccountAmountTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.PhoneTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomersAccountAmount);
            this.Inner_left_down_panel.Controls.Add(this.AccountComboBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomerPhoneLbl);
            this.Inner_left_down_panel.Controls.Add(this.PaymentMethodLbl);
            this.Inner_left_down_panel.Controls.Add(this.BarcodeTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CustomerNameTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.AccountDescriptionTxtBox);
            this.Inner_left_down_panel.Controls.Add(this.CashPaymentGB);
            this.Inner_left_down_panel.Controls.Add(this.CheckGB);
            this.Inner_left_down_panel.Controls.Add(this.PayInVisaGB);
            this.Inner_left_down_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Inner_left_down_panel.Location = new System.Drawing.Point(0, 0);
            this.Inner_left_down_panel.Name = "Inner_left_down_panel";
            this.Inner_left_down_panel.Size = new System.Drawing.Size(256, 700);
            this.Inner_left_down_panel.TabIndex = 71;
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.AccountLbl.Location = new System.Drawing.Point(24, 108);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(87, 23);
            this.AccountLbl.TabIndex = 0;
            this.AccountLbl.Text = "Account";
            // 
            // PaymentMethodCheckBox
            // 
            this.PaymentMethodCheckBox.DataSource = this.paymentMethodBindingSource;
            this.PaymentMethodCheckBox.DisplayMember = "Name";
            this.PaymentMethodCheckBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentMethodCheckBox.FormattingEnabled = true;
            this.PaymentMethodCheckBox.Location = new System.Drawing.Point(19, 74);
            this.PaymentMethodCheckBox.Name = "PaymentMethodCheckBox";
            this.PaymentMethodCheckBox.Size = new System.Drawing.Size(213, 27);
            this.PaymentMethodCheckBox.TabIndex = 9;
            this.PaymentMethodCheckBox.ValueMember = "ID";
            this.PaymentMethodCheckBox.SelectedValueChanged += new System.EventHandler(this.PaymentMethodCheckBox_SelectedValueChanged);
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBDataSet;
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerNameLbl.Location = new System.Drawing.Point(19, 219);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(102, 23);
            this.CustomerNameLbl.TabIndex = 0;
            this.CustomerNameLbl.Text = "Customer";
            // 
            // PaymentMethodDescripTxtBox
            // 
            this.PaymentMethodDescripTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentMethodDescripTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodDescripTxtBox.ForeColor = System.Drawing.Color.White;
            this.PaymentMethodDescripTxtBox.Location = new System.Drawing.Point(39, 109);
            this.PaymentMethodDescripTxtBox.Name = "PaymentMethodDescripTxtBox";
            this.PaymentMethodDescripTxtBox.ReadOnly = true;
            this.PaymentMethodDescripTxtBox.Size = new System.Drawing.Size(193, 23);
            this.PaymentMethodDescripTxtBox.TabIndex = 0;
            this.PaymentMethodDescripTxtBox.TabStop = false;
            this.PaymentMethodDescripTxtBox.Visible = false;
            // 
            // CustomersAccountAmountTxtBox
            // 
            this.CustomersAccountAmountTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(225)))), ((int)(((byte)(176)))));
            this.CustomersAccountAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmountTxtBox.ForeColor = System.Drawing.Color.White;
            this.CustomersAccountAmountTxtBox.Location = new System.Drawing.Point(144, 275);
            this.CustomersAccountAmountTxtBox.Name = "CustomersAccountAmountTxtBox";
            this.CustomersAccountAmountTxtBox.ReadOnly = true;
            this.CustomersAccountAmountTxtBox.Size = new System.Drawing.Size(87, 27);
            this.CustomersAccountAmountTxtBox.TabIndex = 0;
            this.CustomersAccountAmountTxtBox.TabStop = false;
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PhoneTxtBox.Location = new System.Drawing.Point(18, 192);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(213, 27);
            this.PhoneTxtBox.TabIndex = 4;
            this.PhoneTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PhoneTxtBox_MouseClick);
            this.PhoneTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTxtBox_KeyPress);
            // 
            // CustomersAccountAmount
            // 
            this.CustomersAccountAmount.AutoSize = true;
            this.CustomersAccountAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomersAccountAmount.Location = new System.Drawing.Point(21, 280);
            this.CustomersAccountAmount.Name = "CustomersAccountAmount";
            this.CustomersAccountAmount.Size = new System.Drawing.Size(117, 16);
            this.CustomersAccountAmount.TabIndex = 0;
            this.CustomersAccountAmount.Text = "Account Amount";
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DataSource = this.accountsBindingSource;
            this.AccountComboBox.DisplayMember = "Name";
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.Enabled = false;
            this.AccountComboBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(19, 137);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(213, 27);
            this.AccountComboBox.TabIndex = 10;
            this.AccountComboBox.ValueMember = "ID";
            this.AccountComboBox.SelectedValueChanged += new System.EventHandler(this.AccountComboBox_SelectedValueChanged);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dBDataSet;
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(19, 167);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(167, 23);
            this.CustomerPhoneLbl.TabIndex = 0;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // PaymentMethodLbl
            // 
            this.PaymentMethodLbl.AutoSize = true;
            this.PaymentMethodLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentMethodLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentMethodLbl.Location = new System.Drawing.Point(21, 48);
            this.PaymentMethodLbl.Name = "PaymentMethodLbl";
            this.PaymentMethodLbl.Size = new System.Drawing.Size(171, 23);
            this.PaymentMethodLbl.TabIndex = 0;
            this.PaymentMethodLbl.Text = "Payment Method";
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(110)))));
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.White;
            this.BarcodeTxtBox.Location = new System.Drawing.Point(19, 0);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(213, 27);
            this.BarcodeTxtBox.TabIndex = 0;
            this.BarcodeTxtBox.TabStop = false;
            this.BarcodeTxtBox.Text = "Barcode Scanner Here";
            this.BarcodeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BarcodeTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BarcodeTxtBox_MouseClick);
            this.BarcodeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTxtBox_KeyPress);
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CustomerNameTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxtBox.ForeColor = System.Drawing.Color.White;
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(18, 246);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.ReadOnly = true;
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(213, 27);
            this.CustomerNameTxtBox.TabIndex = 0;
            this.CustomerNameTxtBox.TabStop = false;
            // 
            // AccountDescriptionTxtBox
            // 
            this.AccountDescriptionTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.AccountDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDescriptionTxtBox.ForeColor = System.Drawing.Color.White;
            this.AccountDescriptionTxtBox.Location = new System.Drawing.Point(27, 167);
            this.AccountDescriptionTxtBox.Name = "AccountDescriptionTxtBox";
            this.AccountDescriptionTxtBox.ReadOnly = true;
            this.AccountDescriptionTxtBox.Size = new System.Drawing.Size(198, 23);
            this.AccountDescriptionTxtBox.TabIndex = 0;
            this.AccountDescriptionTxtBox.TabStop = false;
            this.AccountDescriptionTxtBox.Visible = false;
            // 
            // CashPaymentGB
            // 
            this.CashPaymentGB.BackColor = System.Drawing.Color.Transparent;
            this.CashPaymentGB.Controls.Add(this.label1);
            this.CashPaymentGB.Controls.Add(this.IsCreditLbl);
            this.CashPaymentGB.Controls.Add(this.CashMethodComboBox);
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
            this.CashPaymentGB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashPaymentGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashPaymentGB.Location = new System.Drawing.Point(27, 302);
            this.CashPaymentGB.Name = "CashPaymentGB";
            this.CashPaymentGB.Size = new System.Drawing.Size(193, 307);
            this.CashPaymentGB.TabIndex = 11;
            this.CashPaymentGB.TabStop = false;
            this.CashPaymentGB.Text = "Cash";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(154, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "JOD";
            // 
            // IsCreditLbl
            // 
            this.IsCreditLbl.AutoSize = true;
            this.IsCreditLbl.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsCreditLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.IsCreditLbl.Location = new System.Drawing.Point(3, 131);
            this.IsCreditLbl.Name = "IsCreditLbl";
            this.IsCreditLbl.Size = new System.Drawing.Size(101, 39);
            this.IsCreditLbl.TabIndex = 0;
            this.IsCreditLbl.Text = "Credit";
            this.IsCreditLbl.Visible = false;
            // 
            // CashMethodComboBox
            // 
            this.CashMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CashMethodComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.CashMethodComboBox.FormattingEnabled = true;
            this.CashMethodComboBox.Items.AddRange(new object[] {
            "Cash",
            "Invoice"});
            this.CashMethodComboBox.Location = new System.Drawing.Point(6, 47);
            this.CashMethodComboBox.Name = "CashMethodComboBox";
            this.CashMethodComboBox.Size = new System.Drawing.Size(179, 24);
            this.CashMethodComboBox.TabIndex = 11;
            this.CashMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.CashMethodComboBox_SelectedIndexChanged);
            // 
            // CashMethodLbl
            // 
            this.CashMethodLbl.AutoSize = true;
            this.CashMethodLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashMethodLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashMethodLbl.Location = new System.Drawing.Point(6, 24);
            this.CashMethodLbl.Name = "CashMethodLbl";
            this.CashMethodLbl.Size = new System.Drawing.Size(114, 19);
            this.CashMethodLbl.TabIndex = 0;
            this.CashMethodLbl.Text = "Cash Method";
            // 
            // SellPriceLbl
            // 
            this.SellPriceLbl.AutoSize = true;
            this.SellPriceLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPriceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SellPriceLbl.Location = new System.Drawing.Point(20, 258);
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
            this.BuyRateLbl.Location = new System.Drawing.Point(108, 258);
            this.BuyRateLbl.Name = "BuyRateLbl";
            this.BuyRateLbl.Size = new System.Drawing.Size(56, 14);
            this.BuyRateLbl.TabIndex = 0;
            this.BuyRateLbl.Text = "Buy Rate";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.DataSource = this.currencyBindingSource;
            this.CurrencyComboBox.DisplayMember = "Name";
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(87, 223);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(99, 24);
            this.CurrencyComboBox.TabIndex = 12;
            this.CurrencyComboBox.ValueMember = "ID";
            this.CurrencyComboBox.SelectedValueChanged += new System.EventHandler(this.CurrencyComboBox_SelectedValueChanged);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataMember = "Currency";
            this.currencyBindingSource.DataSource = this.dBDataSet;
            // 
            // CurrencyLbl
            // 
            this.CurrencyLbl.AutoSize = true;
            this.CurrencyLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CurrencyLbl.Location = new System.Drawing.Point(5, 226);
            this.CurrencyLbl.Name = "CurrencyLbl";
            this.CurrencyLbl.Size = new System.Drawing.Size(81, 19);
            this.CurrencyLbl.TabIndex = 0;
            this.CurrencyLbl.Text = "Currency";
            // 
            // SellRateTxtBox
            // 
            this.SellRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SellRateTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellRateTxtBox.ForeColor = System.Drawing.Color.White;
            this.SellRateTxtBox.Location = new System.Drawing.Point(8, 276);
            this.SellRateTxtBox.Name = "SellRateTxtBox";
            this.SellRateTxtBox.Size = new System.Drawing.Size(78, 23);
            this.SellRateTxtBox.TabIndex = 0;
            this.SellRateTxtBox.TabStop = false;
            // 
            // ExchangeTxtBox
            // 
            this.ExchangeTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ExchangeTxtBox.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeTxtBox.ForeColor = System.Drawing.Color.White;
            this.ExchangeTxtBox.Location = new System.Drawing.Point(4, 174);
            this.ExchangeTxtBox.Name = "ExchangeTxtBox";
            this.ExchangeTxtBox.ReadOnly = true;
            this.ExchangeTxtBox.Size = new System.Drawing.Size(182, 43);
            this.ExchangeTxtBox.TabIndex = 0;
            this.ExchangeTxtBox.TabStop = false;
            this.ExchangeTxtBox.Text = "0.00";
            this.ExchangeTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExchangeLbl
            // 
            this.ExchangeLbl.AutoSize = true;
            this.ExchangeLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExchangeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.ExchangeLbl.Location = new System.Drawing.Point(4, 151);
            this.ExchangeLbl.Name = "ExchangeLbl";
            this.ExchangeLbl.Size = new System.Drawing.Size(87, 19);
            this.ExchangeLbl.TabIndex = 0;
            this.ExchangeLbl.Text = "Exhcange";
            // 
            // BuyRateTxtBox
            // 
            this.BuyRateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BuyRateTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyRateTxtBox.ForeColor = System.Drawing.Color.White;
            this.BuyRateTxtBox.Location = new System.Drawing.Point(108, 276);
            this.BuyRateTxtBox.Name = "BuyRateTxtBox";
            this.BuyRateTxtBox.Size = new System.Drawing.Size(78, 23);
            this.BuyRateTxtBox.TabIndex = 0;
            this.BuyRateTxtBox.TabStop = false;
            // 
            // CashInTxtBox
            // 
            this.CashInTxtBox.BackColor = System.Drawing.Color.White;
            this.CashInTxtBox.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashInTxtBox.Location = new System.Drawing.Point(5, 103);
            this.CashInTxtBox.Name = "CashInTxtBox";
            this.CashInTxtBox.Size = new System.Drawing.Size(182, 43);
            this.CashInTxtBox.TabIndex = 13;
            this.CashInTxtBox.Text = "0.00";
            this.CashInTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CashInTxtBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CashInTxtBox_MouseClick);
            this.CashInTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashInTxtBox_KeyPress);
            // 
            // CashInLbl
            // 
            this.CashInLbl.AutoSize = true;
            this.CashInLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashInLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CashInLbl.Location = new System.Drawing.Point(5, 82);
            this.CashInLbl.Name = "CashInLbl";
            this.CashInLbl.Size = new System.Drawing.Size(70, 19);
            this.CashInLbl.TabIndex = 0;
            this.CashInLbl.Text = "Cash In";
            // 
            // CheckGB
            // 
            this.CheckGB.BackColor = System.Drawing.Color.Transparent;
            this.CheckGB.Controls.Add(this.CheckDatePicker);
            this.CheckGB.Controls.Add(this.CheckCommentsTxtBox);
            this.CheckGB.Controls.Add(this.HolderNameTxtBox);
            this.CheckGB.Controls.Add(this.CheckCommentsLbl);
            this.CheckGB.Controls.Add(this.CheckNumberTxtBox);
            this.CheckGB.Controls.Add(this.CheckHolderNameLbl);
            this.CheckGB.Controls.Add(this.PaymentDateLbl);
            this.CheckGB.Controls.Add(this.CheckNumber);
            this.CheckGB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckGB.Location = new System.Drawing.Point(27, 302);
            this.CheckGB.Name = "CheckGB";
            this.CheckGB.Size = new System.Drawing.Size(193, 298);
            this.CheckGB.TabIndex = 11;
            this.CheckGB.TabStop = false;
            this.CheckGB.Text = "Credit Card";
            // 
            // CheckDatePicker
            // 
            this.CheckDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckDatePicker.Location = new System.Drawing.Point(21, 158);
            this.CheckDatePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.Name = "CheckDatePicker";
            this.CheckDatePicker.Size = new System.Drawing.Size(151, 27);
            this.CheckDatePicker.TabIndex = 8;
            this.CheckDatePicker.TabStop = false;
            // 
            // CheckCommentsTxtBox
            // 
            this.CheckCommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.CheckCommentsTxtBox.Location = new System.Drawing.Point(18, 213);
            this.CheckCommentsTxtBox.Multiline = true;
            this.CheckCommentsTxtBox.Name = "CheckCommentsTxtBox";
            this.CheckCommentsTxtBox.Size = new System.Drawing.Size(157, 72);
            this.CheckCommentsTxtBox.TabIndex = 7;
            this.CheckCommentsTxtBox.TabStop = false;
            // 
            // HolderNameTxtBox
            // 
            this.HolderNameTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HolderNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.HolderNameTxtBox.Location = new System.Drawing.Point(21, 104);
            this.HolderNameTxtBox.Name = "HolderNameTxtBox";
            this.HolderNameTxtBox.Size = new System.Drawing.Size(151, 27);
            this.HolderNameTxtBox.TabIndex = 0;
            this.HolderNameTxtBox.TabStop = false;
            // 
            // CheckCommentsLbl
            // 
            this.CheckCommentsLbl.AutoSize = true;
            this.CheckCommentsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckCommentsLbl.Location = new System.Drawing.Point(18, 191);
            this.CheckCommentsLbl.Name = "CheckCommentsLbl";
            this.CheckCommentsLbl.Size = new System.Drawing.Size(95, 19);
            this.CheckCommentsLbl.TabIndex = 6;
            this.CheckCommentsLbl.Text = "Comments";
            // 
            // CheckNumberTxtBox
            // 
            this.CheckNumberTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumberTxtBox.ForeColor = System.Drawing.Color.White;
            this.CheckNumberTxtBox.Location = new System.Drawing.Point(21, 53);
            this.CheckNumberTxtBox.Name = "CheckNumberTxtBox";
            this.CheckNumberTxtBox.ReadOnly = true;
            this.CheckNumberTxtBox.Size = new System.Drawing.Size(151, 27);
            this.CheckNumberTxtBox.TabIndex = 0;
            this.CheckNumberTxtBox.TabStop = false;
            // 
            // CheckHolderNameLbl
            // 
            this.CheckHolderNameLbl.AutoSize = true;
            this.CheckHolderNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHolderNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckHolderNameLbl.Location = new System.Drawing.Point(21, 83);
            this.CheckHolderNameLbl.Name = "CheckHolderNameLbl";
            this.CheckHolderNameLbl.Size = new System.Drawing.Size(115, 19);
            this.CheckHolderNameLbl.TabIndex = 6;
            this.CheckHolderNameLbl.Text = "Holder Name";
            // 
            // PaymentDateLbl
            // 
            this.PaymentDateLbl.AutoSize = true;
            this.PaymentDateLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentDateLbl.Location = new System.Drawing.Point(21, 137);
            this.PaymentDateLbl.Name = "PaymentDateLbl";
            this.PaymentDateLbl.Size = new System.Drawing.Size(125, 19);
            this.PaymentDateLbl.TabIndex = 6;
            this.PaymentDateLbl.Text = "Payment Date";
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSize = true;
            this.CheckNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.CheckNumber.Location = new System.Drawing.Point(21, 30);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(122, 19);
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.Text = "CheckNumber";
            // 
            // PayInVisaGB
            // 
            this.PayInVisaGB.BackColor = System.Drawing.Color.Transparent;
            this.PayInVisaGB.Controls.Add(this.CreditCardInfoTxtBox);
            this.PayInVisaGB.Controls.Add(this.PaymentCommentsLbl);
            this.PayInVisaGB.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayInVisaGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PayInVisaGB.Location = new System.Drawing.Point(27, 302);
            this.PayInVisaGB.Name = "PayInVisaGB";
            this.PayInVisaGB.Size = new System.Drawing.Size(193, 307);
            this.PayInVisaGB.TabIndex = 11;
            this.PayInVisaGB.TabStop = false;
            this.PayInVisaGB.Text = "Visa";
            // 
            // CreditCardInfoTxtBox
            // 
            this.CreditCardInfoTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardInfoTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(25)))));
            this.CreditCardInfoTxtBox.Location = new System.Drawing.Point(14, 53);
            this.CreditCardInfoTxtBox.Multiline = true;
            this.CreditCardInfoTxtBox.Name = "CreditCardInfoTxtBox";
            this.CreditCardInfoTxtBox.Size = new System.Drawing.Size(164, 227);
            this.CreditCardInfoTxtBox.TabIndex = 7;
            this.CreditCardInfoTxtBox.TabStop = false;
            // 
            // PaymentCommentsLbl
            // 
            this.PaymentCommentsLbl.AutoSize = true;
            this.PaymentCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.PaymentCommentsLbl.Location = new System.Drawing.Point(14, 34);
            this.PaymentCommentsLbl.Name = "PaymentCommentsLbl";
            this.PaymentCommentsLbl.Size = new System.Drawing.Size(34, 16);
            this.PaymentCommentsLbl.TabIndex = 6;
            this.PaymentCommentsLbl.Text = "Info";
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // currencyTableAdapter
            // 
            this.currencyTableAdapter.ClearBeforeFill = true;
            // 
            // priceLevelsTableAdapter
            // 
            this.priceLevelsTableAdapter.ClearBeforeFill = true;
            // 
            // Numpad
            // 
            this.Numpad.BackColor = System.Drawing.Color.Transparent;
            this.Numpad.Location = new System.Drawing.Point(321, 20);
            this.Numpad.Name = "Numpad";
            this.Numpad.Size = new System.Drawing.Size(403, 398);
            this.Numpad.TabIndex = 72;
            this.Numpad.Visible = false;
            this.Numpad.ButtonPressed += new System.Windows.Forms.KeyPressEventHandler(this.Numpad_ButtonPressed);
            // 
            // atab
            // 
            this.atab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.atab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atab.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atab.ItemSize = new System.Drawing.Size(1500, 40);
            this.atab.Location = new System.Drawing.Point(256, 0);
            this.atab.myBackColor = System.Drawing.Color.Transparent;
            this.atab.Name = "atab";
            this.atab.SelectedIndex = 2;
            this.atab.Size = new System.Drawing.Size(531, 452);
            this.atab.TabIndex = 73;
            // 
            // TouchScreenFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.Numpad);
            this.Controls.Add(this.atab);
            this.Controls.Add(this.PanelDown);
            this.Controls.Add(this.Inner_left_down_panel);
            this.Controls.Add(this.PanelRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TouchScreenFrm";
            this.Text = "TouchScreenFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.TouchScreenFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            this.PanelDown.ResumeLayout(false);
            this.PanelDown.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceLevelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.Inner_left_down_panel.ResumeLayout(false);
            this.Inner_left_down_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.CashPaymentGB.ResumeLayout(false);
            this.CashPaymentGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.CheckGB.ResumeLayout(false);
            this.CheckGB.PerformLayout();
            this.PayInVisaGB.ResumeLayout(false);
            this.PayInVisaGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.Panel PanelDown;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.Label TotalDiscountLbl;
        private System.Windows.Forms.Label DiscountOnBillLbl;
        private System.Windows.Forms.Label TotalTaxlbl;
        private System.Windows.Forms.Label PriceLevelLbl;
        private System.Windows.Forms.Label NetAmountLbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.TextBox TaxTxtBox;
        private System.Windows.Forms.TextBox TotalDiscountTxtBox;
        private System.Windows.Forms.Label PriceLvlDiscountLbl;
        private System.Windows.Forms.Label DiscountBillPercLbl;
        private System.Windows.Forms.TextBox NetAmountTxtBox;
        private System.Windows.Forms.TextBox DiscountBillTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.ComboBox PriceLevelComboBox;
        private System.Windows.Forms.TextBox PriceLevelDiscount;
        private System.Windows.Forms.TextBox DiscountPercTxtBox;
        private System.Windows.Forms.Panel Inner_left_down_panel;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.ComboBox PaymentMethodCheckBox;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.TextBox PaymentMethodDescripTxtBox;
        private System.Windows.Forms.TextBox CustomersAccountAmountTxtBox;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.TextBox AccountDescriptionTxtBox;
        private System.Windows.Forms.Label CustomersAccountAmount;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.Label PaymentMethodLbl;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.GroupBox PayInVisaGB;
        private System.Windows.Forms.TextBox CreditCardInfoTxtBox;
        private System.Windows.Forms.Label PaymentCommentsLbl;
        private System.Windows.Forms.GroupBox CheckGB;
        private System.Windows.Forms.DateTimePicker CheckDatePicker;
        private System.Windows.Forms.TextBox CheckCommentsTxtBox;
        private System.Windows.Forms.TextBox HolderNameTxtBox;
        private System.Windows.Forms.Label CheckCommentsLbl;
        private System.Windows.Forms.TextBox CheckNumberTxtBox;
        private System.Windows.Forms.Label CheckHolderNameLbl;
        private System.Windows.Forms.Label PaymentDateLbl;
        private System.Windows.Forms.Label CheckNumber;
        private System.Windows.Forms.GroupBox CashPaymentGB;
        private System.Windows.Forms.Label IsCreditLbl;
        private System.Windows.Forms.ComboBox CashMethodComboBox;
        private System.Windows.Forms.Label CashInCurrency;
        private System.Windows.Forms.Label CashMethodLbl;
        private System.Windows.Forms.Label JODstatic;
        private System.Windows.Forms.Label SellPriceLbl;
        private System.Windows.Forms.Label BuyRateLbl;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.Label CurrencyLbl;
        private System.Windows.Forms.TextBox SellRateTxtBox;
        private System.Windows.Forms.TextBox ExchangeTxtBox;
        private System.Windows.Forms.Label ExchangeLbl;
        private System.Windows.Forms.TextBox BuyRateTxtBox;
        private System.Windows.Forms.TextBox CashInTxtBox;
        private System.Windows.Forms.Label CashInLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.TextBox InvoiceNumTxtBox;
        private System.Windows.Forms.Label BillNumberLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button PaymentAndPrintBtn;
        private System.Windows.Forms.Label SavePaymnetandPrint;
        private System.Windows.Forms.Button PaymentOnlyBtn;
        private System.Windows.Forms.Button CancleBtn;
        private System.Windows.Forms.Label SavePaymentNoPrint;
        private System.Windows.Forms.Label CancelPayment;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBDataSetTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DBDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private DBDataSetTableAdapters.CurrencyTableAdapter currencyTableAdapter;
        private System.Windows.Forms.BindingSource priceLevelsBindingSource;
        private DBDataSetTableAdapters.PriceLevelsTableAdapter priceLevelsTableAdapter;
        private System.Windows.Forms.CheckBox EnableNumpadChkBox;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private CalciumsComponents.Numpad Numpad;
        private System.Windows.Forms.Button OpenCashBtn;
        private System.Windows.Forms.CheckBox ReturnChkBox;
        private System.Windows.Forms.CheckBox PrintingThermalA4ChkBox;
        private System.Windows.Forms.CheckBox CustomerScreenChkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private FlatTabControl.FlatTabControl atab;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
    }
}