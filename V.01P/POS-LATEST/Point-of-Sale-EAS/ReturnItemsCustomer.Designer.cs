namespace Calcium_RMS
{
    partial class ReturnItemsCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnItemsCustomer));
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IncreaseBtn = new System.Windows.Forms.Button();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.DecreaseBtn = new System.Windows.Forms.Button();
            this.DecreaseLbl = new System.Windows.Forms.Label();
            this.IncreaseLbl = new System.Windows.Forms.Label();
            this.RemoveLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CustomersAccountAmount = new System.Windows.Forms.Label();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.CancleBtn = new System.Windows.Forms.Button();
            this.PaymentOnlyBtn = new System.Windows.Forms.Button();
            this.PaymentAndPrintBtn = new System.Windows.Forms.Button();
            this.TotalTaxlbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.TaxTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.WithoutAddBtn = new System.Windows.Forms.Button();
            this.DescriptionAddBtn = new System.Windows.Forms.Button();
            this.BillNumberLbl = new System.Windows.Forms.Label();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsWithoutBarcodeLbl = new System.Windows.Forms.Label();
            this.InvoiceNumTxtBox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet1 = new Calcium_RMS.DBDataSet();
            this.TellerLbl = new System.Windows.Forms.Label();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.ItemDescriptionLbl = new System.Windows.Forms.Label();
            this.ReturnItemsCustomerLbl = new System.Windows.Forms.Label();
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.CustomersAccountAmountTxtBox = new System.Windows.Forms.TextBox();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.SavePaymnetandPrint = new System.Windows.Forms.Label();
            this.SavePaymentNoPrint = new System.Windows.Forms.Label();
            this.CancelPayment = new System.Windows.Forms.Label();
            this.itemsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
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
            this.Tax,
            this.PriceTotal,
            this.AvalQty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.Location = new System.Drawing.Point(0, 0);
            this.TeldgView.Name = "TeldgView";
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(575, 700);
            this.TeldgView.TabIndex = 148;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.IncreaseBtn);
            this.panel2.Controls.Add(this.DeleteItemsBtn);
            this.panel2.Controls.Add(this.DecreaseBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(575, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 700);
            this.panel2.TabIndex = 150;
            // 
            // IncreaseBtn
            // 
            this.IncreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.IncreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Icon;
            this.IncreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IncreaseBtn.FlatAppearance.BorderSize = 0;
            this.IncreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseBtn.Location = new System.Drawing.Point(9, 14);
            this.IncreaseBtn.Name = "IncreaseBtn";
            this.IncreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.IncreaseBtn.TabIndex = 140;
            this.IncreaseBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon_Big;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(9, 90);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(35, 35);
            this.DeleteItemsBtn.TabIndex = 138;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            // 
            // DecreaseBtn
            // 
            this.DecreaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DecreaseBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon_Big;
            this.DecreaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DecreaseBtn.FlatAppearance.BorderSize = 0;
            this.DecreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseBtn.Location = new System.Drawing.Point(9, 52);
            this.DecreaseBtn.Name = "DecreaseBtn";
            this.DecreaseBtn.Size = new System.Drawing.Size(35, 35);
            this.DecreaseBtn.TabIndex = 143;
            this.DecreaseBtn.UseVisualStyleBackColor = false;
            // 
            // DecreaseLbl
            // 
            this.DecreaseLbl.AutoSize = true;
            this.DecreaseLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DecreaseLbl.Location = new System.Drawing.Point(333, 195);
            this.DecreaseLbl.Name = "DecreaseLbl";
            this.DecreaseLbl.Size = new System.Drawing.Size(61, 16);
            this.DecreaseLbl.TabIndex = 144;
            this.DecreaseLbl.Text = "Decrease";
            // 
            // IncreaseLbl
            // 
            this.IncreaseLbl.AutoSize = true;
            this.IncreaseLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncreaseLbl.ForeColor = System.Drawing.Color.Indigo;
            this.IncreaseLbl.Location = new System.Drawing.Point(290, 88);
            this.IncreaseLbl.Name = "IncreaseLbl";
            this.IncreaseLbl.Size = new System.Drawing.Size(57, 16);
            this.IncreaseLbl.TabIndex = 141;
            this.IncreaseLbl.Text = "Increase";
            // 
            // RemoveLbl
            // 
            this.RemoveLbl.AutoSize = true;
            this.RemoveLbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLbl.ForeColor = System.Drawing.Color.Indigo;
            this.RemoveLbl.Location = new System.Drawing.Point(270, 270);
            this.RemoveLbl.Name = "RemoveLbl";
            this.RemoveLbl.Size = new System.Drawing.Size(54, 16);
            this.RemoveLbl.TabIndex = 139;
            this.RemoveLbl.Text = "Remove";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MinimizePB);
            this.panel1.Controls.Add(this.CustomerNameTxtBox);
            this.panel1.Controls.Add(this.ExitPB);
            this.panel1.Controls.Add(this.CustomerNameLbl);
            this.panel1.Controls.Add(this.PhoneTxtBox);
            this.panel1.Controls.Add(this.CustomersAccountAmount);
            this.panel1.Controls.Add(this.CustomerPhoneLbl);
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
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.ItemsWithoutBarcodeComboBox);
            this.panel1.Controls.Add(this.TellerLbl);
            this.panel1.Controls.Add(this.CommentsTxtBox);
            this.panel1.Controls.Add(this.BarcodeLbl);
            this.panel1.Controls.Add(this.TotalTxtBox);
            this.panel1.Controls.Add(this.ItemDescriptionLbl);
            this.panel1.Controls.Add(this.ReturnItemsCustomerLbl);
            this.panel1.Controls.Add(this.TotalBillLbl);
            this.panel1.Controls.Add(this.CustomersAccountAmountTxtBox);
            this.panel1.Controls.Add(this.ItemDescriptionComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(630, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 700);
            this.panel1.TabIndex = 149;
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
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(137, 43);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameTxtBox.TabIndex = 117;
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
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CustomerNameLbl.Location = new System.Drawing.Point(256, 348);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(59, 14);
            this.CustomerNameLbl.TabIndex = 160;
            this.CustomerNameLbl.Text = "Customer";
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.BackColor = System.Drawing.Color.White;
            this.PhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.PhoneTxtBox.Location = new System.Drawing.Point(213, 317);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(155, 21);
            this.PhoneTxtBox.TabIndex = 161;
            // 
            // CustomersAccountAmount
            // 
            this.CustomersAccountAmount.AutoSize = true;
            this.CustomersAccountAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CustomersAccountAmount.Location = new System.Drawing.Point(22, 348);
            this.CustomersAccountAmount.Name = "CustomersAccountAmount";
            this.CustomersAccountAmount.Size = new System.Drawing.Size(109, 14);
            this.CustomersAccountAmount.TabIndex = 156;
            this.CustomersAccountAmount.Text = "Customer Account";
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(234, 298);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(98, 14);
            this.CustomerPhoneLbl.TabIndex = 157;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // CancleBtn
            // 
            this.CancleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CancleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancleBtn.FlatAppearance.BorderSize = 0;
            this.CancleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancleBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancleBtn.ForeColor = System.Drawing.Color.White;
            this.CancleBtn.Location = new System.Drawing.Point(11, 664);
            this.CancleBtn.Name = "CancleBtn";
            this.CancleBtn.Size = new System.Drawing.Size(120, 24);
            this.CancleBtn.TabIndex = 155;
            this.CancleBtn.Text = "Cancel";
            this.CancleBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentOnlyBtn
            // 
            this.PaymentOnlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.PaymentOnlyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentOnlyBtn.FlatAppearance.BorderSize = 0;
            this.PaymentOnlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentOnlyBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentOnlyBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentOnlyBtn.Location = new System.Drawing.Point(137, 664);
            this.PaymentOnlyBtn.Name = "PaymentOnlyBtn";
            this.PaymentOnlyBtn.Size = new System.Drawing.Size(120, 24);
            this.PaymentOnlyBtn.TabIndex = 153;
            this.PaymentOnlyBtn.Text = "Pay Only";
            this.PaymentOnlyBtn.UseVisualStyleBackColor = false;
            // 
            // PaymentAndPrintBtn
            // 
            this.PaymentAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.PaymentAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.PaymentAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentAndPrintBtn.Location = new System.Drawing.Point(262, 664);
            this.PaymentAndPrintBtn.Name = "PaymentAndPrintBtn";
            this.PaymentAndPrintBtn.Size = new System.Drawing.Size(120, 24);
            this.PaymentAndPrintBtn.TabIndex = 154;
            this.PaymentAndPrintBtn.Text = "Pay and Print";
            this.PaymentAndPrintBtn.UseVisualStyleBackColor = false;
            // 
            // TotalTaxlbl
            // 
            this.TotalTaxlbl.AutoSize = true;
            this.TotalTaxlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.TotalTaxlbl.Location = new System.Drawing.Point(257, 408);
            this.TotalTaxlbl.Name = "TotalTaxlbl";
            this.TotalTaxlbl.Size = new System.Drawing.Size(55, 14);
            this.TotalTaxlbl.TabIndex = 148;
            this.TotalTaxlbl.Text = "TotalTax";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.SubtotalLbl.Location = new System.Drawing.Point(55, 408);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(53, 14);
            this.SubtotalLbl.TabIndex = 149;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // TaxTxtBox
            // 
            this.TaxTxtBox.BackColor = System.Drawing.Color.White;
            this.TaxTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.TaxTxtBox.Location = new System.Drawing.Point(213, 427);
            this.TaxTxtBox.Name = "TaxTxtBox";
            this.TaxTxtBox.ReadOnly = true;
            this.TaxTxtBox.Size = new System.Drawing.Size(155, 21);
            this.TaxTxtBox.TabIndex = 147;
            this.TaxTxtBox.TabStop = false;
            this.TaxTxtBox.Text = "0";
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.White;
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.SubtotalTxtBox.Location = new System.Drawing.Point(8, 427);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(155, 21);
            this.SubtotalTxtBox.TabIndex = 146;
            this.SubtotalTxtBox.TabStop = false;
            this.SubtotalTxtBox.Text = "0";
            // 
            // WithoutAddBtn
            // 
            this.WithoutAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.WithoutAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WithoutAddBtn.BackgroundImage")));
            this.WithoutAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithoutAddBtn.FlatAppearance.BorderSize = 0;
            this.WithoutAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithoutAddBtn.Location = new System.Drawing.Point(167, 315);
            this.WithoutAddBtn.Name = "WithoutAddBtn";
            this.WithoutAddBtn.Size = new System.Drawing.Size(25, 25);
            this.WithoutAddBtn.TabIndex = 140;
            this.WithoutAddBtn.UseVisualStyleBackColor = false;
            // 
            // DescriptionAddBtn
            // 
            this.DescriptionAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DescriptionAddBtn.BackgroundImage")));
            this.DescriptionAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescriptionAddBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionAddBtn.Location = new System.Drawing.Point(167, 265);
            this.DescriptionAddBtn.Name = "DescriptionAddBtn";
            this.DescriptionAddBtn.Size = new System.Drawing.Size(25, 25);
            this.DescriptionAddBtn.TabIndex = 140;
            this.DescriptionAddBtn.UseVisualStyleBackColor = false;
            // 
            // BillNumberLbl
            // 
            this.BillNumberLbl.AutoSize = true;
            this.BillNumberLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.BillNumberLbl.Location = new System.Drawing.Point(43, 160);
            this.BillNumberLbl.Name = "BillNumberLbl";
            this.BillNumberLbl.Size = new System.Drawing.Size(67, 14);
            this.BillNumberLbl.TabIndex = 130;
            this.BillNumberLbl.Text = "Bill Number";
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.BackColor = System.Drawing.Color.White;
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(213, 267);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(155, 21);
            this.BarcodeTxtBox.TabIndex = 145;
            // 
            // ItemsWithoutBarcodeLbl
            // 
            this.ItemsWithoutBarcodeLbl.AutoSize = true;
            this.ItemsWithoutBarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.ItemsWithoutBarcodeLbl.Location = new System.Drawing.Point(13, 298);
            this.ItemsWithoutBarcodeLbl.Name = "ItemsWithoutBarcodeLbl";
            this.ItemsWithoutBarcodeLbl.Size = new System.Drawing.Size(127, 14);
            this.ItemsWithoutBarcodeLbl.TabIndex = 142;
            this.ItemsWithoutBarcodeLbl.Text = "ItemsWithoutBarcode";
            // 
            // InvoiceNumTxtBox
            // 
            this.InvoiceNumTxtBox.BackColor = System.Drawing.Color.White;
            this.InvoiceNumTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.InvoiceNumTxtBox.Location = new System.Drawing.Point(8, 180);
            this.InvoiceNumTxtBox.Name = "InvoiceNumTxtBox";
            this.InvoiceNumTxtBox.ReadOnly = true;
            this.InvoiceNumTxtBox.Size = new System.Drawing.Size(155, 21);
            this.InvoiceNumTxtBox.TabIndex = 133;
            this.InvoiceNumTxtBox.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.UserName.Location = new System.Drawing.Point(264, 160);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(61, 14);
            this.UserName.TabIndex = 132;
            this.UserName.Text = "Username";
            // 
            // ItemsWithoutBarcodeComboBox
            // 
            this.ItemsWithoutBarcodeComboBox.BackColor = System.Drawing.Color.White;
            this.ItemsWithoutBarcodeComboBox.DataSource = this.itemsBindingSource1;
            this.ItemsWithoutBarcodeComboBox.DisplayMember = "Description";
            this.ItemsWithoutBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsWithoutBarcodeComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.ItemsWithoutBarcodeComboBox.FormattingEnabled = true;
            this.ItemsWithoutBarcodeComboBox.Location = new System.Drawing.Point(8, 317);
            this.ItemsWithoutBarcodeComboBox.Name = "ItemsWithoutBarcodeComboBox";
            this.ItemsWithoutBarcodeComboBox.Size = new System.Drawing.Size(155, 21);
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
            // TellerLbl
            // 
            this.TellerLbl.AutoSize = true;
            this.TellerLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.TellerLbl.Location = new System.Drawing.Point(269, 183);
            this.TellerLbl.Name = "TellerLbl";
            this.TellerLbl.Size = new System.Drawing.Size(52, 14);
            this.TellerLbl.TabIndex = 131;
            this.TellerLbl.Text = "TellerLbl";
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(11, 578);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(371, 77);
            this.CommentsTxtBox.TabIndex = 70;
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.BarcodeLbl.Location = new System.Drawing.Point(230, 248);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(99, 14);
            this.BarcodeLbl.TabIndex = 136;
            this.BarcodeLbl.Text = "Barcode Scanner";
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.TotalTxtBox.Location = new System.Drawing.Point(117, 512);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(155, 21);
            this.TotalTxtBox.TabIndex = 65;
            this.TotalTxtBox.Text = "0";
            // 
            // ItemDescriptionLbl
            // 
            this.ItemDescriptionLbl.AutoSize = true;
            this.ItemDescriptionLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.ItemDescriptionLbl.Location = new System.Drawing.Point(29, 248);
            this.ItemDescriptionLbl.Name = "ItemDescriptionLbl";
            this.ItemDescriptionLbl.Size = new System.Drawing.Size(97, 14);
            this.ItemDescriptionLbl.TabIndex = 137;
            this.ItemDescriptionLbl.Text = "Item Description";
            // 
            // ReturnItemsCustomerLbl
            // 
            this.ReturnItemsCustomerLbl.AutoSize = true;
            this.ReturnItemsCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnItemsCustomerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.ReturnItemsCustomerLbl.Location = new System.Drawing.Point(79, 81);
            this.ReturnItemsCustomerLbl.Name = "ReturnItemsCustomerLbl";
            this.ReturnItemsCustomerLbl.Size = new System.Drawing.Size(239, 25);
            this.ReturnItemsCustomerLbl.TabIndex = 66;
            this.ReturnItemsCustomerLbl.Text = "Customer Return Items";
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.TotalBillLbl.Location = new System.Drawing.Point(169, 493);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(50, 14);
            this.TotalBillLbl.TabIndex = 66;
            this.TotalBillLbl.Text = "TOTAL ";
            // 
            // CustomersAccountAmountTxtBox
            // 
            this.CustomersAccountAmountTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomersAccountAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.CustomersAccountAmountTxtBox.Location = new System.Drawing.Point(8, 367);
            this.CustomersAccountAmountTxtBox.Name = "CustomersAccountAmountTxtBox";
            this.CustomersAccountAmountTxtBox.ReadOnly = true;
            this.CustomersAccountAmountTxtBox.Size = new System.Drawing.Size(155, 21);
            this.CustomersAccountAmountTxtBox.TabIndex = 158;
            this.CustomersAccountAmountTxtBox.TabStop = false;
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.BackColor = System.Drawing.Color.White;
            this.ItemDescriptionComboBox.DataSource = this.itemsBindingSource;
            this.ItemDescriptionComboBox.DisplayMember = "Description";
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(102)))), ((int)(((byte)(65)))));
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(8, 267);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(155, 21);
            this.ItemDescriptionComboBox.TabIndex = 134;
            this.ItemDescriptionComboBox.ValueMember = "Barcode";
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
            // SavePaymnetandPrint
            // 
            this.SavePaymnetandPrint.AutoSize = true;
            this.SavePaymnetandPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymnetandPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymnetandPrint.Location = new System.Drawing.Point(290, 376);
            this.SavePaymnetandPrint.Name = "SavePaymnetandPrint";
            this.SavePaymnetandPrint.Size = new System.Drawing.Size(91, 16);
            this.SavePaymnetandPrint.TabIndex = 152;
            this.SavePaymnetandPrint.Text = "Save and Print";
            // 
            // SavePaymentNoPrint
            // 
            this.SavePaymentNoPrint.AutoSize = true;
            this.SavePaymentNoPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePaymentNoPrint.ForeColor = System.Drawing.Color.Indigo;
            this.SavePaymentNoPrint.Location = new System.Drawing.Point(221, 376);
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
            this.CancelPayment.Location = new System.Drawing.Point(150, 375);
            this.CancelPayment.Name = "CancelPayment";
            this.CancelPayment.Size = new System.Drawing.Size(46, 16);
            this.CancelPayment.TabIndex = 150;
            this.CancelPayment.Text = "Cancle";
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnItemsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.TeldgView);
            this.Controls.Add(this.RemoveLbl);
            this.Controls.Add(this.DecreaseLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.IncreaseLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SavePaymentNoPrint);
            this.Controls.Add(this.CancelPayment);
            this.Controls.Add(this.SavePaymnetandPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReturnItemsCustomer";
            this.Text = "ReturnItemsCustomer";
            this.Load += new System.EventHandler(this.ReturnItemsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button IncreaseBtn;
        private System.Windows.Forms.Label DecreaseLbl;
        private System.Windows.Forms.Label IncreaseLbl;
        private System.Windows.Forms.Label RemoveLbl;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.Button DecreaseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SavePaymnetandPrint;
        private System.Windows.Forms.Button CancleBtn;
        private System.Windows.Forms.Button PaymentOnlyBtn;
        private System.Windows.Forms.Button PaymentAndPrintBtn;
        private System.Windows.Forms.Label SavePaymentNoPrint;
        private System.Windows.Forms.Label CancelPayment;
        private System.Windows.Forms.Label TotalTaxlbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.TextBox TaxTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.Button WithoutAddBtn;
        private System.Windows.Forms.Button DescriptionAddBtn;
        private System.Windows.Forms.Label BillNumberLbl;
        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.Label ItemsWithoutBarcodeLbl;
        private System.Windows.Forms.TextBox InvoiceNumTxtBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.ComboBox ItemsWithoutBarcodeComboBox;
        private System.Windows.Forms.Label TellerLbl;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Label ItemDescriptionLbl;
        private System.Windows.Forms.Label ReturnItemsCustomerLbl;
        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private DBDataSet dbDataSet1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DBDataSet dBDataSet;
        private DBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.TextBox CustomersAccountAmountTxtBox;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label CustomersAccountAmount;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
    }
}