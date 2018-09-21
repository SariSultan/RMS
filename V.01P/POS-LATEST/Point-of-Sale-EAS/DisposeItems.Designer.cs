namespace Calcium_RMS
{
    partial class DisposeItems
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
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisposalReasonComboBox = new System.Windows.Forms.ComboBox();
            this.disposalReasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.DisposalReasonDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.DisposalReasonLbl = new System.Windows.Forms.Label();
            this.AddNewDisposalReasonBtn = new System.Windows.Forms.Button();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.InvoiceNumTxtBox = new System.Windows.Forms.TextBox();
            this.DecreaseLbl = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeLbl = new System.Windows.Forms.Label();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.ItemsWithoutBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new Calcium_RMS.DBDataSet();
            this.IncreaseLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionLbl = new System.Windows.Forms.Label();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.BillNumberLbl = new System.Windows.Forms.Label();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveLbl = new System.Windows.Forms.Label();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrintingThermalA4ChkBox = new System.Windows.Forms.CheckBox();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.PaymentOnlyBtn = new System.Windows.Forms.Button();
            this.PaymentAndPrintBtn = new System.Windows.Forms.Button();
            this.TotalTaxlbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.TaxTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.WithoutAddBtn = new System.Windows.Forms.Button();
            this.DescriptionAddBtn = new System.Windows.Forms.Button();
            this.DisposeItemsLbl = new System.Windows.Forms.Label();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.SavePaymentNoPrint = new System.Windows.Forms.Label();
            this.CancelPayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            this.disposalReasonTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.DisposalReasonTableAdapter();
            this.SavePaymnetandPrint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalReasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TotalBillLbl.Location = new System.Drawing.Point(95, 377);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(74, 14);
            this.TotalBillLbl.TabIndex = 66;
            this.TotalBillLbl.Text = "TOTAL Cost";
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.Black;
            this.TotalTxtBox.Location = new System.Drawing.Point(92, 395);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(202, 33);
            this.TotalTxtBox.TabIndex = 65;
            this.TotalTxtBox.Text = "0.00";
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.TeldgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
            this.TeldgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeldgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.Qty,
            this.PricePerUnit,
            this.Tax,
            this.PriceTotal,
            this.AvalQty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.Location = new System.Drawing.Point(0, 0);
            this.TeldgView.Name = "TeldgView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.TeldgView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(581, 615);
            this.TeldgView.TabIndex = 58;
            this.TeldgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeldgView_CellValueChanged);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 85;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
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
            // DisposalReasonComboBox
            // 
            this.DisposalReasonComboBox.BackColor = System.Drawing.Color.White;
            this.DisposalReasonComboBox.DataSource = this.disposalReasonBindingSource;
            this.DisposalReasonComboBox.DisplayMember = "Name";
            this.DisposalReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DisposalReasonComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisposalReasonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.DisposalReasonComboBox.FormattingEnabled = true;
            this.DisposalReasonComboBox.Location = new System.Drawing.Point(174, 73);
            this.DisposalReasonComboBox.Name = "DisposalReasonComboBox";
            this.DisposalReasonComboBox.Size = new System.Drawing.Size(195, 21);
            this.DisposalReasonComboBox.TabIndex = 71;
            this.DisposalReasonComboBox.ValueMember = "ID";
            this.DisposalReasonComboBox.SelectedIndexChanged += new System.EventHandler(this.DisposalReasonComboBox_SelectedIndexChanged);
            // 
            // disposalReasonBindingSource
            // 
            this.disposalReasonBindingSource.DataMember = "DisposalReason";
            this.disposalReasonBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.BackColor = System.Drawing.Color.White;
            this.CommentsTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(92, 456);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(202, 34);
            this.CommentsTxtBox.TabIndex = 70;
            // 
            // DisposalReasonDescriptionTxtBox
            // 
            this.DisposalReasonDescriptionTxtBox.BackColor = System.Drawing.Color.White;
            this.DisposalReasonDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisposalReasonDescriptionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.DisposalReasonDescriptionTxtBox.Location = new System.Drawing.Point(173, 100);
            this.DisposalReasonDescriptionTxtBox.Name = "DisposalReasonDescriptionTxtBox";
            this.DisposalReasonDescriptionTxtBox.ReadOnly = true;
            this.DisposalReasonDescriptionTxtBox.Size = new System.Drawing.Size(196, 21);
            this.DisposalReasonDescriptionTxtBox.TabIndex = 73;
            // 
            // DisposalReasonLbl
            // 
            this.DisposalReasonLbl.AutoSize = true;
            this.DisposalReasonLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisposalReasonLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.DisposalReasonLbl.Location = new System.Drawing.Point(20, 75);
            this.DisposalReasonLbl.Name = "DisposalReasonLbl";
            this.DisposalReasonLbl.Size = new System.Drawing.Size(103, 14);
            this.DisposalReasonLbl.TabIndex = 72;
            this.DisposalReasonLbl.Text = "DisposalReasonLbl";
            // 
            // AddNewDisposalReasonBtn
            // 
            this.AddNewDisposalReasonBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddNewDisposalReasonBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Icon3;
            this.AddNewDisposalReasonBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewDisposalReasonBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewDisposalReasonBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.AddNewDisposalReasonBtn.Location = new System.Drawing.Point(16, 100);
            this.AddNewDisposalReasonBtn.Name = "AddNewDisposalReasonBtn";
            this.AddNewDisposalReasonBtn.Size = new System.Drawing.Size(145, 24);
            this.AddNewDisposalReasonBtn.TabIndex = 76;
            this.AddNewDisposalReasonBtn.Text = "New Disposal Reason";
            this.AddNewDisposalReasonBtn.UseVisualStyleBackColor = false;
            this.AddNewDisposalReasonBtn.Click += new System.EventHandler(this.AddNewDisposalReasonBtn_Click);
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.BackColor = System.Drawing.Color.White;
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(94, 174);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(198, 21);
            this.BarcodeTxtBox.TabIndex = 145;
            this.BarcodeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTxtBox_KeyPress);
            // 
            // InvoiceNumTxtBox
            // 
            this.InvoiceNumTxtBox.BackColor = System.Drawing.Color.White;
            this.InvoiceNumTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.InvoiceNumTxtBox.Location = new System.Drawing.Point(174, 49);
            this.InvoiceNumTxtBox.Name = "InvoiceNumTxtBox";
            this.InvoiceNumTxtBox.ReadOnly = true;
            this.InvoiceNumTxtBox.Size = new System.Drawing.Size(195, 21);
            this.InvoiceNumTxtBox.TabIndex = 133;
            this.InvoiceNumTxtBox.TabStop = false;
            // 
            // DecreaseLbl
            // 
            this.DecreaseLbl.AutoSize = true;
            this.DecreaseLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DecreaseLbl.Location = new System.Drawing.Point(251, 154);
            this.DecreaseLbl.Name = "DecreaseLbl";
            this.DecreaseLbl.Size = new System.Drawing.Size(59, 15);
            this.DecreaseLbl.TabIndex = 144;
            this.DecreaseLbl.Text = "Decrease";
            // 
            // ItemsWithoutBarcodeLbl
            // 
            this.ItemsWithoutBarcodeLbl.AutoSize = true;
            this.ItemsWithoutBarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsWithoutBarcodeLbl.Location = new System.Drawing.Point(97, 244);
            this.ItemsWithoutBarcodeLbl.Name = "ItemsWithoutBarcodeLbl";
            this.ItemsWithoutBarcodeLbl.Size = new System.Drawing.Size(127, 14);
            this.ItemsWithoutBarcodeLbl.TabIndex = 142;
            this.ItemsWithoutBarcodeLbl.Text = "ItemsWithoutBarcode";
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Icon;
            this.IncreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Location = new System.Drawing.Point(6, 12);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.IncreaseBtn.TabIndex = 140;
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            this.IncreaseBtn.Click += new System.EventHandler(this.IncreaseBtn_Click);
            // 
            // ItemsWithoutBarcodeComboBox
            // 
            this.ItemsWithoutBarcodeComboBox.BackColor = System.Drawing.Color.White;
            this.ItemsWithoutBarcodeComboBox.DataSource = this.itemsBindingSource1;
            this.ItemsWithoutBarcodeComboBox.DisplayMember = "Description";
            this.ItemsWithoutBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsWithoutBarcodeComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsWithoutBarcodeComboBox.FormattingEnabled = true;
            this.ItemsWithoutBarcodeComboBox.Location = new System.Drawing.Point(94, 261);
            this.ItemsWithoutBarcodeComboBox.Name = "ItemsWithoutBarcodeComboBox";
            this.ItemsWithoutBarcodeComboBox.Size = new System.Drawing.Size(198, 21);
            this.ItemsWithoutBarcodeComboBox.TabIndex = 135;
            this.ItemsWithoutBarcodeComboBox.ValueMember = "Barcode";
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dbDataSet1;
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "DBDataSet";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IncreaseLbl
            // 
            this.IncreaseLbl.AutoSize = true;
            this.IncreaseLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.IncreaseLbl.Location = new System.Drawing.Point(229, 129);
            this.IncreaseLbl.Name = "IncreaseLbl";
            this.IncreaseLbl.Size = new System.Drawing.Size(53, 15);
            this.IncreaseLbl.TabIndex = 141;
            this.IncreaseLbl.Text = "Increase";
            // 
            // ItemDescriptionLbl
            // 
            this.ItemDescriptionLbl.AutoSize = true;
            this.ItemDescriptionLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemDescriptionLbl.Location = new System.Drawing.Point(97, 198);
            this.ItemDescriptionLbl.Name = "ItemDescriptionLbl";
            this.ItemDescriptionLbl.Size = new System.Drawing.Size(97, 14);
            this.ItemDescriptionLbl.TabIndex = 137;
            this.ItemDescriptionLbl.Text = "Item Description";
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.BarcodeLbl.Location = new System.Drawing.Point(97, 157);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(99, 14);
            this.BarcodeLbl.TabIndex = 136;
            this.BarcodeLbl.Text = "Barcode Scanner";
            // 
            // BillNumberLbl
            // 
            this.BillNumberLbl.AutoSize = true;
            this.BillNumberLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.BillNumberLbl.Location = new System.Drawing.Point(22, 51);
            this.BillNumberLbl.Name = "BillNumberLbl";
            this.BillNumberLbl.Size = new System.Drawing.Size(100, 14);
            this.BillNumberLbl.TabIndex = 130;
            this.BillNumberLbl.Text = "Voucher Number";
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon_Big;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(6, 92);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(35, 35);
            this.DeleteItemsBtn.TabIndex = 138;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            this.DeleteItemsBtn.Click += new System.EventHandler(this.DeleteItemsBtn_Click);
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.BackColor = System.Drawing.Color.White;
            this.ItemDescriptionComboBox.DataSource = this.itemsBindingSource;
            this.ItemDescriptionComboBox.DisplayMember = "Description";
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(94, 215);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(198, 21);
            this.ItemDescriptionComboBox.TabIndex = 134;
            this.ItemDescriptionComboBox.ValueMember = "Barcode";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dBDataSet;
            // 
            // RemoveLbl
            // 
            this.RemoveLbl.AutoSize = true;
            this.RemoveLbl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLbl.ForeColor = System.Drawing.Color.Indigo;
            this.RemoveLbl.Location = new System.Drawing.Point(232, 176);
            this.RemoveLbl.Name = "RemoveLbl";
            this.RemoveLbl.Size = new System.Drawing.Size(50, 15);
            this.RemoveLbl.TabIndex = 139;
            this.RemoveLbl.Text = "Remove";
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon_Big;
            this.DecreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Location = new System.Drawing.Point(6, 52);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.DecreaseBtn.TabIndex = 143;
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            this.DecreaseBtn.Click += new System.EventHandler(this.DecreaseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.PrintingThermalA4ChkBox);
            this.panel1.Controls.Add(this.CancleBtn);
            this.panel1.Controls.Add(this.PaymentOnlyBtn);
            this.panel1.Controls.Add(this.PaymentAndPrintBtn);
            this.panel1.Controls.Add(this.TotalTaxlbl);
            this.panel1.Controls.Add(this.SubtotalLbl);
            this.panel1.Controls.Add(this.TaxTxtBox);
            this.panel1.Controls.Add(this.SubtotalTxtBox);
            this.panel1.Controls.Add(this.WithoutAddBtn);
            this.panel1.Controls.Add(this.DescriptionAddBtn);
            this.panel1.Controls.Add(this.BillNumberLbl);
            this.panel1.Controls.Add(this.BarcodeTxtBox);
            this.panel1.Controls.Add(this.ItemsWithoutBarcodeLbl);
            this.panel1.Controls.Add(this.InvoiceNumTxtBox);
            this.panel1.Controls.Add(this.ItemsWithoutBarcodeComboBox);
            this.panel1.Controls.Add(this.AddNewDisposalReasonBtn);
            this.panel1.Controls.Add(this.ItemDescriptionComboBox);
            this.panel1.Controls.Add(this.CommentsTxtBox);
            this.panel1.Controls.Add(this.DisposalReasonComboBox);
            this.panel1.Controls.Add(this.DisposalReasonDescriptionTxtBox);
            this.panel1.Controls.Add(this.BarcodeLbl);
            this.panel1.Controls.Add(this.DisposalReasonLbl);
            this.panel1.Controls.Add(this.TotalTxtBox);
            this.panel1.Controls.Add(this.ItemDescriptionLbl);
            this.panel1.Controls.Add(this.DisposeItemsLbl);
            this.panel1.Controls.Add(this.CommentsLbl);
            this.panel1.Controls.Add(this.TotalBillLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 615);
            this.panel1.TabIndex = 146;
            // 
            // PrintingThermalA4ChkBox
            // 
            this.PrintingThermalA4ChkBox.AutoSize = true;
            this.PrintingThermalA4ChkBox.ForeColor = System.Drawing.Color.Black;
            this.PrintingThermalA4ChkBox.Location = new System.Drawing.Point(95, 591);
            this.PrintingThermalA4ChkBox.Name = "PrintingThermalA4ChkBox";
            this.PrintingThermalA4ChkBox.Size = new System.Drawing.Size(117, 17);
            this.PrintingThermalA4ChkBox.TabIndex = 156;
            this.PrintingThermalA4ChkBox.Text = "Export As PDF File ";
            this.PrintingThermalA4ChkBox.UseVisualStyleBackColor = true;
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.CancleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancleBtn.FlatAppearance.BorderSize = 0;
            this.CancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(92, 561);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(202, 24);
            this.CancleBtn.TabIndex = 155;
            this.CancleBtn.Text = "Cancel";
            this.CancleBtn.UseVisualStyleBackColor = false;
            this.CancleBtn.Click += new System.EventHandler(this.CancleBtn_Click);
            // 
            // PaymentOnlyBtn
            // 
            this.PaymentOnlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.PaymentOnlyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentOnlyBtn.FlatAppearance.BorderSize = 0;
            this.PaymentOnlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentOnlyBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOnlyBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentOnlyBtn.Location = new System.Drawing.Point(92, 531);
            this.PaymentOnlyBtn.Name = "PaymentOnlyBtn";
            this.PaymentOnlyBtn.Size = new System.Drawing.Size(202, 24);
            this.PaymentOnlyBtn.TabIndex = 154;
            this.PaymentOnlyBtn.Text = "Save (F4)";
            this.PaymentOnlyBtn.UseVisualStyleBackColor = false;
            this.PaymentOnlyBtn.Click += new System.EventHandler(this.PaymentOnlyBtn_Click);
            // 
            // PaymentAndPrintBtn
            // 
            this.PaymentAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.PaymentAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.PaymentAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentAndPrintBtn.Location = new System.Drawing.Point(91, 501);
            this.PaymentAndPrintBtn.Name = "PaymentAndPrintBtn";
            this.PaymentAndPrintBtn.Size = new System.Drawing.Size(203, 24);
            this.PaymentAndPrintBtn.TabIndex = 154;
            this.PaymentAndPrintBtn.Text = "Pay and Print (F2)";
            this.PaymentAndPrintBtn.UseVisualStyleBackColor = false;
            this.PaymentAndPrintBtn.Click += new System.EventHandler(this.PaymentAndPrintBtn_Click);
            // 
            // TotalTaxlbl
            // 
            this.TotalTaxlbl.AutoSize = true;
            this.TotalTaxlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TotalTaxlbl.Location = new System.Drawing.Point(99, 336);
            this.TotalTaxlbl.Name = "TotalTaxlbl";
            this.TotalTaxlbl.Size = new System.Drawing.Size(55, 14);
            this.TotalTaxlbl.TabIndex = 148;
            this.TotalTaxlbl.Text = "TotalTax";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.SubtotalLbl.Location = new System.Drawing.Point(99, 294);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(53, 14);
            this.SubtotalLbl.TabIndex = 149;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // TaxTxtBox
            // 
            this.TaxTxtBox.BackColor = System.Drawing.Color.White;
            this.TaxTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TaxTxtBox.Location = new System.Drawing.Point(95, 352);
            this.TaxTxtBox.Name = "TaxTxtBox";
            this.TaxTxtBox.ReadOnly = true;
            this.TaxTxtBox.Size = new System.Drawing.Size(199, 21);
            this.TaxTxtBox.TabIndex = 147;
            this.TaxTxtBox.TabStop = false;
            this.TaxTxtBox.Text = "0";
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.White;
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.SubtotalTxtBox.Location = new System.Drawing.Point(95, 311);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(199, 21);
            this.SubtotalTxtBox.TabIndex = 146;
            this.SubtotalTxtBox.TabStop = false;
            this.SubtotalTxtBox.Text = "0";
            // 
            // WithoutAddBtn
            // 
            this.WithoutAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.WithoutAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Icon;
            this.WithoutAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithoutAddBtn.FlatAppearance.BorderSize = 0;
            this.WithoutAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithoutAddBtn.Location = new System.Drawing.Point(298, 260);
            this.WithoutAddBtn.Name = "WithoutAddBtn";
            this.WithoutAddBtn.Size = new System.Drawing.Size(25, 20);
            this.WithoutAddBtn.TabIndex = 140;
            this.WithoutAddBtn.UseVisualStyleBackColor = false;
            this.WithoutAddBtn.Click += new System.EventHandler(this.WithoutAddBtn_Click);
            // 
            // DescriptionAddBtn
            // 
            this.DescriptionAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Icon;
            this.DescriptionAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescriptionAddBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionAddBtn.Location = new System.Drawing.Point(298, 214);
            this.DescriptionAddBtn.Name = "DescriptionAddBtn";
            this.DescriptionAddBtn.Size = new System.Drawing.Size(25, 20);
            this.DescriptionAddBtn.TabIndex = 140;
            this.DescriptionAddBtn.UseVisualStyleBackColor = false;
            this.DescriptionAddBtn.Click += new System.EventHandler(this.DescriptionAddBtn_Click);
            // 
            // DisposeItemsLbl
            // 
            this.DisposeItemsLbl.AutoSize = true;
            this.DisposeItemsLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisposeItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.DisposeItemsLbl.Location = new System.Drawing.Point(86, 0);
            this.DisposeItemsLbl.Name = "DisposeItemsLbl";
            this.DisposeItemsLbl.Size = new System.Drawing.Size(195, 25);
            this.DisposeItemsLbl.TabIndex = 66;
            this.DisposeItemsLbl.Text = "Damage Voucher";
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.CommentsLbl.Location = new System.Drawing.Point(96, 439);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CommentsLbl.TabIndex = 66;
            this.CommentsLbl.Text = "Comments";
            // 
            // SavePaymentNoPrint
            // 
            this.SavePaymentNoPrint.AutoSize = true;
            this.SavePaymentNoPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymentNoPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymentNoPrint.Location = new System.Drawing.Point(275, 326);
            this.SavePaymentNoPrint.Name = "SavePaymentNoPrint";
            this.SavePaymentNoPrint.Size = new System.Drawing.Size(65, 16);
            this.SavePaymentNoPrint.TabIndex = 151;
            this.SavePaymentNoPrint.Text = "Save Only";
            // 
            // CancelPayment
            // 
            this.CancelPayment.AutoSize = true;
            this.CancelPayment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelPayment.ForeColor = System.Drawing.Color.Indigo;
            this.CancelPayment.Location = new System.Drawing.Point(204, 325);
            this.CancelPayment.Name = "CancelPayment";
            this.CancelPayment.Size = new System.Drawing.Size(46, 16);
            this.CancelPayment.TabIndex = 150;
            this.CancelPayment.Text = "Cancle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.IncreaseBtn);
            this.panel2.Controls.Add(this.DeleteItemsBtn);
            this.panel2.Controls.Add(this.DecreaseBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(49, 615);
            this.panel2.TabIndex = 147;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // disposalReasonTableAdapter
            // 
            this.disposalReasonTableAdapter.ClearBeforeFill = true;
            // 
            // SavePaymnetandPrint
            // 
            this.SavePaymnetandPrint.AutoSize = true;
            this.SavePaymnetandPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymnetandPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymnetandPrint.Location = new System.Drawing.Point(344, 326);
            this.SavePaymnetandPrint.Name = "SavePaymnetandPrint";
            this.SavePaymnetandPrint.Size = new System.Drawing.Size(91, 16);
            this.SavePaymnetandPrint.TabIndex = 152;
            this.SavePaymnetandPrint.Text = "Save and Print";
            // 
            // DisposeItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 615);
            this.Controls.Add(this.TeldgView);
            this.Controls.Add(this.RemoveLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DecreaseLbl);
            this.Controls.Add(this.SavePaymentNoPrint);
            this.Controls.Add(this.CancelPayment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IncreaseLbl);
            this.Controls.Add(this.SavePaymnetandPrint);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DisposeItems";
            this.Text = "DisposeItems";
            this.Load += new System.EventHandler(this.DisposeItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalReasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private System.Windows.Forms.ComboBox DisposalReasonComboBox;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.TextBox DisposalReasonDescriptionTxtBox;
        private System.Windows.Forms.Label DisposalReasonLbl;
        private System.Windows.Forms.Button AddNewDisposalReasonBtn;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.TextBox InvoiceNumTxtBox;
        private System.Windows.Forms.Label DecreaseLbl;
        private System.Windows.Forms.Label ItemsWithoutBarcodeLbl;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.ComboBox ItemsWithoutBarcodeComboBox;
        private System.Windows.Forms.Label IncreaseLbl;
        private System.Windows.Forms.Label ItemDescriptionLbl;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label BillNumberLbl;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.Label RemoveLbl;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource disposalReasonBindingSource;
        private DBDataSetTableAdapters.DisposalReasonTableAdapter disposalReasonTableAdapter;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private DBDataSet dbDataSet1;
        private System.Windows.Forms.Label TotalTaxlbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.TextBox TaxTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.Button PaymentAndPrintBtn;
        private System.Windows.Forms.Label SavePaymentNoPrint;
        private System.Windows.Forms.Label CancelPayment;
        private System.Windows.Forms.Label DisposeItemsLbl;
        private System.Windows.Forms.Label SavePaymnetandPrint;
        private System.Windows.Forms.Button CancleBtn;
        private System.Windows.Forms.Button WithoutAddBtn;
        private System.Windows.Forms.Button DescriptionAddBtn;
        private System.Windows.Forms.CheckBox PrintingThermalA4ChkBox;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.Button PaymentOnlyBtn;
    }
}