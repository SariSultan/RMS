namespace Calcium_RMS
{
    partial class EditReturnItemsCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PaymentGB = new System.Windows.Forms.GroupBox();
            this.Time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PaymentAndPrintBtn = new System.Windows.Forms.Button();
            this.ReviseBillBtn = new System.Windows.Forms.Button();
            this.ChkBillBtn = new System.Windows.Forms.Button();
            this.CustomerNameTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.CustomersAccountAmountTxtBox = new System.Windows.Forms.TextBox();
            this.PhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CustomersAccountAmount = new System.Windows.Forms.Label();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.TotalTaxlbl = new System.Windows.Forms.Label();
            this.SubtotalLbl = new System.Windows.Forms.Label();
            this.TaxTxtBox = new System.Windows.Forms.TextBox();
            this.SubtotalTxtBox = new System.Windows.Forms.TextBox();
            this.BillNumberLbl = new System.Windows.Forms.Label();
            this.InvoiceNumTxtBox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.TellerLbl = new System.Windows.Forms.Label();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.TotalTxtBox = new System.Windows.Forms.TextBox();
            this.EditReturnItemsCustomerLbl = new System.Windows.Forms.Label();
            this.TotalBillLbl = new System.Windows.Forms.Label();
            this.PrintBtn = new System.Windows.Forms.Label();
            this.ReviseBill = new System.Windows.Forms.Label();
            this.CheckBill = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IsRevisedLbl = new System.Windows.Forms.Label();
            this.ReviseInfoGB = new System.Windows.Forms.GroupBox();
            this.ReviseDate = new System.Windows.Forms.Label();
            this.ReviseLossProfit = new System.Windows.Forms.Label();
            this.ReviseTimeLbl = new System.Windows.Forms.Label();
            this.RevisedBy = new System.Windows.Forms.Label();
            this.ReviseDatelbl = new System.Windows.Forms.Label();
            this.ReviseLossProfitLbl = new System.Windows.Forms.Label();
            this.ReviseTime = new System.Windows.Forms.Label();
            this.RevisedBylbl = new System.Windows.Forms.Label();
            this.CheckInfoGB = new System.Windows.Forms.GroupBox();
            this.ChkDate = new System.Windows.Forms.Label();
            this.ChkedBy = new System.Windows.Forms.Label();
            this.CheckTimeLbl = new System.Windows.Forms.Label();
            this.ChkDateLbl = new System.Windows.Forms.Label();
            this.ChkedByUserNameLbl = new System.Windows.Forms.Label();
            this.CheckTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PaymentGB.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ReviseInfoGB.SuspendLayout();
            this.CheckInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
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
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.Location = new System.Drawing.Point(0, 0);
            this.TeldgView.Name = "TeldgView";
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(614, 515);
            this.TeldgView.TabIndex = 151;
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
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.PaymentGB);
            this.panel1.Controls.Add(this.PaymentAndPrintBtn);
            this.panel1.Controls.Add(this.ReviseBillBtn);
            this.panel1.Controls.Add(this.ChkBillBtn);
            this.panel1.Controls.Add(this.CustomerNameTxtBox);
            this.panel1.Controls.Add(this.CustomerNameLbl);
            this.panel1.Controls.Add(this.CustomersAccountAmountTxtBox);
            this.panel1.Controls.Add(this.PhoneTxtBox);
            this.panel1.Controls.Add(this.CustomersAccountAmount);
            this.panel1.Controls.Add(this.CustomerPhoneLbl);
            this.panel1.Controls.Add(this.TotalTaxlbl);
            this.panel1.Controls.Add(this.SubtotalLbl);
            this.panel1.Controls.Add(this.TaxTxtBox);
            this.panel1.Controls.Add(this.SubtotalTxtBox);
            this.panel1.Controls.Add(this.BillNumberLbl);
            this.panel1.Controls.Add(this.InvoiceNumTxtBox);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.TellerLbl);
            this.panel1.Controls.Add(this.CommentsTxtBox);
            this.panel1.Controls.Add(this.TotalTxtBox);
            this.panel1.Controls.Add(this.EditReturnItemsCustomerLbl);
            this.panel1.Controls.Add(this.TotalBillLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 662);
            this.panel1.TabIndex = 152;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.pictureBox2.Location = new System.Drawing.Point(342, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 170;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(363, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 169;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentGB
            // 
            this.PaymentGB.Controls.Add(this.Time);
            this.PaymentGB.Controls.Add(this.Date);
            this.PaymentGB.Controls.Add(this.label2);
            this.PaymentGB.Controls.Add(this.label3);
            this.PaymentGB.Controls.Add(this.label4);
            this.PaymentGB.Controls.Add(this.label5);
            this.PaymentGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.PaymentGB.Location = new System.Drawing.Point(16, 116);
            this.PaymentGB.Name = "PaymentGB";
            this.PaymentGB.Size = new System.Drawing.Size(246, 117);
            this.PaymentGB.TabIndex = 168;
            this.PaymentGB.TabStop = false;
            this.PaymentGB.Text = "PaymentInfo";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.Time.Location = new System.Drawing.Point(95, 47);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(38, 14);
            this.Time.TabIndex = 66;
            this.Time.Text = "Time:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.Date.Location = new System.Drawing.Point(21, 47);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(37, 14);
            this.Date.TabIndex = 65;
            this.Date.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(160, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 63;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(92, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 14);
            this.label3.TabIndex = 67;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(18, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 64;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(172, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 14);
            this.label5.TabIndex = 62;
            this.label5.Text = "label5";
            // 
            // PaymentAndPrintBtn
            // 
            this.PaymentAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.PaymentAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.PaymentAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.PaymentAndPrintBtn.Location = new System.Drawing.Point(262, 628);
            this.PaymentAndPrintBtn.Name = "PaymentAndPrintBtn";
            this.PaymentAndPrintBtn.Size = new System.Drawing.Size(120, 24);
            this.PaymentAndPrintBtn.TabIndex = 166;
            this.PaymentAndPrintBtn.Text = "Pay and Print";
            this.PaymentAndPrintBtn.UseVisualStyleBackColor = false;
            // 
            // ReviseBillBtn
            // 
            this.ReviseBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseBillBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReviseBillBtn.FlatAppearance.BorderSize = 0;
            this.ReviseBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviseBillBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseBillBtn.ForeColor = System.Drawing.Color.White;
            this.ReviseBillBtn.Location = new System.Drawing.Point(138, 628);
            this.ReviseBillBtn.Name = "ReviseBillBtn";
            this.ReviseBillBtn.Size = new System.Drawing.Size(120, 24);
            this.ReviseBillBtn.TabIndex = 164;
            this.ReviseBillBtn.Text = "Revise";
            this.ReviseBillBtn.UseVisualStyleBackColor = false;
            // 
            // ChkBillBtn
            // 
            this.ChkBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ChkBillBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChkBillBtn.FlatAppearance.BorderSize = 0;
            this.ChkBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkBillBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBillBtn.ForeColor = System.Drawing.Color.White;
            this.ChkBillBtn.Location = new System.Drawing.Point(13, 628);
            this.ChkBillBtn.Name = "ChkBillBtn";
            this.ChkBillBtn.Size = new System.Drawing.Size(120, 24);
            this.ChkBillBtn.TabIndex = 165;
            this.ChkBillBtn.Text = "Check";
            this.ChkBillBtn.UseVisualStyleBackColor = false;
            // 
            // CustomerNameTxtBox
            // 
            this.CustomerNameTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomerNameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CustomerNameTxtBox.Location = new System.Drawing.Point(227, 338);
            this.CustomerNameTxtBox.Name = "CustomerNameTxtBox";
            this.CustomerNameTxtBox.ReadOnly = true;
            this.CustomerNameTxtBox.Size = new System.Drawing.Size(151, 21);
            this.CustomerNameTxtBox.TabIndex = 159;
            this.CustomerNameTxtBox.TabStop = false;
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CustomerNameLbl.Location = new System.Drawing.Point(273, 319);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(59, 14);
            this.CustomerNameLbl.TabIndex = 160;
            this.CustomerNameLbl.Text = "Customer";
            // 
            // CustomersAccountAmountTxtBox
            // 
            this.CustomersAccountAmountTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomersAccountAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CustomersAccountAmountTxtBox.Location = new System.Drawing.Point(16, 338);
            this.CustomersAccountAmountTxtBox.Name = "CustomersAccountAmountTxtBox";
            this.CustomersAccountAmountTxtBox.ReadOnly = true;
            this.CustomersAccountAmountTxtBox.Size = new System.Drawing.Size(151, 21);
            this.CustomersAccountAmountTxtBox.TabIndex = 158;
            this.CustomersAccountAmountTxtBox.TabStop = false;
            // 
            // PhoneTxtBox
            // 
            this.PhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.PhoneTxtBox.Location = new System.Drawing.Point(122, 282);
            this.PhoneTxtBox.Name = "PhoneTxtBox";
            this.PhoneTxtBox.Size = new System.Drawing.Size(151, 21);
            this.PhoneTxtBox.TabIndex = 161;
            // 
            // CustomersAccountAmount
            // 
            this.CustomersAccountAmount.AutoSize = true;
            this.CustomersAccountAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAccountAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CustomersAccountAmount.Location = new System.Drawing.Point(37, 319);
            this.CustomersAccountAmount.Name = "CustomersAccountAmount";
            this.CustomersAccountAmount.Size = new System.Drawing.Size(109, 14);
            this.CustomersAccountAmount.TabIndex = 156;
            this.CustomersAccountAmount.Text = "Customer Account";
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(147, 266);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(98, 14);
            this.CustomerPhoneLbl.TabIndex = 157;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // TotalTaxlbl
            // 
            this.TotalTaxlbl.AutoSize = true;
            this.TotalTaxlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TotalTaxlbl.Location = new System.Drawing.Point(275, 374);
            this.TotalTaxlbl.Name = "TotalTaxlbl";
            this.TotalTaxlbl.Size = new System.Drawing.Size(55, 14);
            this.TotalTaxlbl.TabIndex = 148;
            this.TotalTaxlbl.Text = "TotalTax";
            // 
            // SubtotalLbl
            // 
            this.SubtotalLbl.AutoSize = true;
            this.SubtotalLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.SubtotalLbl.Location = new System.Drawing.Point(65, 374);
            this.SubtotalLbl.Name = "SubtotalLbl";
            this.SubtotalLbl.Size = new System.Drawing.Size(53, 14);
            this.SubtotalLbl.TabIndex = 149;
            this.SubtotalLbl.Text = "Subtotal";
            // 
            // TaxTxtBox
            // 
            this.TaxTxtBox.BackColor = System.Drawing.Color.White;
            this.TaxTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TaxTxtBox.Location = new System.Drawing.Point(227, 393);
            this.TaxTxtBox.Name = "TaxTxtBox";
            this.TaxTxtBox.ReadOnly = true;
            this.TaxTxtBox.Size = new System.Drawing.Size(151, 21);
            this.TaxTxtBox.TabIndex = 147;
            this.TaxTxtBox.TabStop = false;
            this.TaxTxtBox.Text = "0";
            // 
            // SubtotalTxtBox
            // 
            this.SubtotalTxtBox.BackColor = System.Drawing.Color.White;
            this.SubtotalTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.SubtotalTxtBox.Location = new System.Drawing.Point(16, 393);
            this.SubtotalTxtBox.Name = "SubtotalTxtBox";
            this.SubtotalTxtBox.ReadOnly = true;
            this.SubtotalTxtBox.Size = new System.Drawing.Size(151, 21);
            this.SubtotalTxtBox.TabIndex = 146;
            this.SubtotalTxtBox.TabStop = false;
            this.SubtotalTxtBox.Text = "0";
            // 
            // BillNumberLbl
            // 
            this.BillNumberLbl.AutoSize = true;
            this.BillNumberLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.BillNumberLbl.Location = new System.Drawing.Point(289, 128);
            this.BillNumberLbl.Name = "BillNumberLbl";
            this.BillNumberLbl.Size = new System.Drawing.Size(67, 14);
            this.BillNumberLbl.TabIndex = 130;
            this.BillNumberLbl.Text = "Bill Number";
            // 
            // InvoiceNumTxtBox
            // 
            this.InvoiceNumTxtBox.BackColor = System.Drawing.Color.White;
            this.InvoiceNumTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.InvoiceNumTxtBox.Location = new System.Drawing.Point(269, 148);
            this.InvoiceNumTxtBox.Name = "InvoiceNumTxtBox";
            this.InvoiceNumTxtBox.ReadOnly = true;
            this.InvoiceNumTxtBox.Size = new System.Drawing.Size(106, 21);
            this.InvoiceNumTxtBox.TabIndex = 133;
            this.InvoiceNumTxtBox.TabStop = false;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.UserName.Location = new System.Drawing.Point(292, 178);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(61, 14);
            this.UserName.TabIndex = 132;
            this.UserName.Text = "Username";
            // 
            // TellerLbl
            // 
            this.TellerLbl.AutoSize = true;
            this.TellerLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TellerLbl.Location = new System.Drawing.Point(296, 200);
            this.TellerLbl.Name = "TellerLbl";
            this.TellerLbl.Size = new System.Drawing.Size(52, 14);
            this.TellerLbl.TabIndex = 131;
            this.TellerLbl.Text = "TellerLbl";
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(13, 537);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(369, 85);
            this.CommentsTxtBox.TabIndex = 70;
            // 
            // TotalTxtBox
            // 
            this.TotalTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TotalTxtBox.Location = new System.Drawing.Point(122, 475);
            this.TotalTxtBox.Name = "TotalTxtBox";
            this.TotalTxtBox.ReadOnly = true;
            this.TotalTxtBox.Size = new System.Drawing.Size(151, 33);
            this.TotalTxtBox.TabIndex = 65;
            this.TotalTxtBox.Text = "0";
            // 
            // EditReturnItemsCustomerLbl
            // 
            this.EditReturnItemsCustomerLbl.AutoSize = true;
            this.EditReturnItemsCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditReturnItemsCustomerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.EditReturnItemsCustomerLbl.Location = new System.Drawing.Point(58, 51);
            this.EditReturnItemsCustomerLbl.Name = "EditReturnItemsCustomerLbl";
            this.EditReturnItemsCustomerLbl.Size = new System.Drawing.Size(281, 25);
            this.EditReturnItemsCustomerLbl.TabIndex = 66;
            this.EditReturnItemsCustomerLbl.Text = "Edit Customer Return Items";
            // 
            // TotalBillLbl
            // 
            this.TotalBillLbl.AutoSize = true;
            this.TotalBillLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TotalBillLbl.Location = new System.Drawing.Point(172, 456);
            this.TotalBillLbl.Name = "TotalBillLbl";
            this.TotalBillLbl.Size = new System.Drawing.Size(50, 14);
            this.TotalBillLbl.TabIndex = 66;
            this.TotalBillLbl.Text = "TOTAL ";
            // 
            // PrintBtn
            // 
            this.PrintBtn.AutoSize = true;
            this.PrintBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintBtn.ForeColor = System.Drawing.Color.Indigo;
            this.PrintBtn.Location = new System.Drawing.Point(425, 251);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(49, 16);
            this.PrintBtn.TabIndex = 167;
            this.PrintBtn.Text = "Reprint";
            // 
            // ReviseBill
            // 
            this.ReviseBill.AutoSize = true;
            this.ReviseBill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseBill.ForeColor = System.Drawing.Color.Indigo;
            this.ReviseBill.Location = new System.Drawing.Point(323, 264);
            this.ReviseBill.Name = "ReviseBill";
            this.ReviseBill.Size = new System.Drawing.Size(80, 19);
            this.ReviseBill.TabIndex = 163;
            this.ReviseBill.Text = "Revise Bill";
            // 
            // CheckBill
            // 
            this.CheckBill.AutoSize = true;
            this.CheckBill.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBill.ForeColor = System.Drawing.Color.Indigo;
            this.CheckBill.Location = new System.Drawing.Point(197, 264);
            this.CheckBill.Name = "CheckBill";
            this.CheckBill.Size = new System.Drawing.Size(77, 19);
            this.CheckBill.TabIndex = 162;
            this.CheckBill.Text = "Check Bill";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.IsRevisedLbl);
            this.panel3.Controls.Add(this.ReviseInfoGB);
            this.panel3.Controls.Add(this.CheckInfoGB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 147);
            this.panel3.TabIndex = 168;
            // 
            // IsRevisedLbl
            // 
            this.IsRevisedLbl.AutoSize = true;
            this.IsRevisedLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsRevisedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.IsRevisedLbl.Location = new System.Drawing.Point(496, 65);
            this.IsRevisedLbl.Name = "IsRevisedLbl";
            this.IsRevisedLbl.Size = new System.Drawing.Size(54, 14);
            this.IsRevisedLbl.TabIndex = 153;
            this.IsRevisedLbl.Text = "Revised";
            this.IsRevisedLbl.Visible = false;
            // 
            // ReviseInfoGB
            // 
            this.ReviseInfoGB.Controls.Add(this.ReviseDate);
            this.ReviseInfoGB.Controls.Add(this.ReviseLossProfit);
            this.ReviseInfoGB.Controls.Add(this.ReviseTimeLbl);
            this.ReviseInfoGB.Controls.Add(this.RevisedBy);
            this.ReviseInfoGB.Controls.Add(this.ReviseDatelbl);
            this.ReviseInfoGB.Controls.Add(this.ReviseLossProfitLbl);
            this.ReviseInfoGB.Controls.Add(this.ReviseTime);
            this.ReviseInfoGB.Controls.Add(this.RevisedBylbl);
            this.ReviseInfoGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseInfoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseInfoGB.Location = new System.Drawing.Point(13, 15);
            this.ReviseInfoGB.Name = "ReviseInfoGB";
            this.ReviseInfoGB.Size = new System.Drawing.Size(215, 117);
            this.ReviseInfoGB.TabIndex = 151;
            this.ReviseInfoGB.TabStop = false;
            this.ReviseInfoGB.Text = "ReviseInfo";
            // 
            // ReviseDate
            // 
            this.ReviseDate.AutoSize = true;
            this.ReviseDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseDate.Location = new System.Drawing.Point(13, 26);
            this.ReviseDate.Name = "ReviseDate";
            this.ReviseDate.Size = new System.Drawing.Size(71, 14);
            this.ReviseDate.TabIndex = 65;
            this.ReviseDate.Text = "ReviseDate:";
            // 
            // ReviseLossProfit
            // 
            this.ReviseLossProfit.AutoSize = true;
            this.ReviseLossProfit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseLossProfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseLossProfit.Location = new System.Drawing.Point(125, 26);
            this.ReviseLossProfit.Name = "ReviseLossProfit";
            this.ReviseLossProfit.Size = new System.Drawing.Size(64, 14);
            this.ReviseLossProfit.TabIndex = 63;
            this.ReviseLossProfit.Text = "Loss/Profit";
            // 
            // ReviseTimeLbl
            // 
            this.ReviseTimeLbl.AutoSize = true;
            this.ReviseTimeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseTimeLbl.Location = new System.Drawing.Point(120, 68);
            this.ReviseTimeLbl.Name = "ReviseTimeLbl";
            this.ReviseTimeLbl.Size = new System.Drawing.Size(72, 14);
            this.ReviseTimeLbl.TabIndex = 63;
            this.ReviseTimeLbl.Text = "ReviseTime:";
            // 
            // RevisedBy
            // 
            this.RevisedBy.AutoSize = true;
            this.RevisedBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.RevisedBy.Location = new System.Drawing.Point(15, 68);
            this.RevisedBy.Name = "RevisedBy";
            this.RevisedBy.Size = new System.Drawing.Size(65, 14);
            this.RevisedBy.TabIndex = 63;
            this.RevisedBy.Text = "RevisedBy:";
            // 
            // ReviseDatelbl
            // 
            this.ReviseDatelbl.AutoSize = true;
            this.ReviseDatelbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseDatelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseDatelbl.Location = new System.Drawing.Point(26, 47);
            this.ReviseDatelbl.Name = "ReviseDatelbl";
            this.ReviseDatelbl.Size = new System.Drawing.Size(48, 14);
            this.ReviseDatelbl.TabIndex = 64;
            this.ReviseDatelbl.Text = "DateLbl";
            // 
            // ReviseLossProfitLbl
            // 
            this.ReviseLossProfitLbl.AutoSize = true;
            this.ReviseLossProfitLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseLossProfitLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseLossProfitLbl.Location = new System.Drawing.Point(148, 47);
            this.ReviseLossProfitLbl.Name = "ReviseLossProfitLbl";
            this.ReviseLossProfitLbl.Size = new System.Drawing.Size(24, 14);
            this.ReviseLossProfitLbl.TabIndex = 62;
            this.ReviseLossProfitLbl.Text = "-/+";
            // 
            // ReviseTime
            // 
            this.ReviseTime.AutoSize = true;
            this.ReviseTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviseTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ReviseTime.Location = new System.Drawing.Point(130, 89);
            this.ReviseTime.Name = "ReviseTime";
            this.ReviseTime.Size = new System.Drawing.Size(52, 14);
            this.ReviseTime.TabIndex = 62;
            this.ReviseTime.Text = "TellerLbl";
            // 
            // RevisedBylbl
            // 
            this.RevisedBylbl.AutoSize = true;
            this.RevisedBylbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisedBylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.RevisedBylbl.Location = new System.Drawing.Point(23, 89);
            this.RevisedBylbl.Name = "RevisedBylbl";
            this.RevisedBylbl.Size = new System.Drawing.Size(52, 14);
            this.RevisedBylbl.TabIndex = 62;
            this.RevisedBylbl.Text = "TellerLbl";
            // 
            // CheckInfoGB
            // 
            this.CheckInfoGB.Controls.Add(this.ChkDate);
            this.CheckInfoGB.Controls.Add(this.ChkedBy);
            this.CheckInfoGB.Controls.Add(this.CheckTimeLbl);
            this.CheckInfoGB.Controls.Add(this.ChkDateLbl);
            this.CheckInfoGB.Controls.Add(this.ChkedByUserNameLbl);
            this.CheckInfoGB.Controls.Add(this.CheckTime);
            this.CheckInfoGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInfoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CheckInfoGB.Location = new System.Drawing.Point(242, 15);
            this.CheckInfoGB.Name = "CheckInfoGB";
            this.CheckInfoGB.Size = new System.Drawing.Size(215, 117);
            this.CheckInfoGB.TabIndex = 150;
            this.CheckInfoGB.TabStop = false;
            this.CheckInfoGB.Text = "CheckInfo";
            // 
            // ChkDate
            // 
            this.ChkDate.AutoSize = true;
            this.ChkDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ChkDate.Location = new System.Drawing.Point(24, 26);
            this.ChkDate.Name = "ChkDate";
            this.ChkDate.Size = new System.Drawing.Size(70, 14);
            this.ChkDate.TabIndex = 65;
            this.ChkDate.Text = "CheckDate:";
            // 
            // ChkedBy
            // 
            this.ChkedBy.AutoSize = true;
            this.ChkedBy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ChkedBy.Location = new System.Drawing.Point(25, 68);
            this.ChkedBy.Name = "ChkedBy";
            this.ChkedBy.Size = new System.Drawing.Size(67, 14);
            this.ChkedBy.TabIndex = 63;
            this.ChkedBy.Text = "CheckedBy";
            // 
            // CheckTimeLbl
            // 
            this.CheckTimeLbl.AutoSize = true;
            this.CheckTimeLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CheckTimeLbl.Location = new System.Drawing.Point(117, 47);
            this.CheckTimeLbl.Name = "CheckTimeLbl";
            this.CheckTimeLbl.Size = new System.Drawing.Size(71, 14);
            this.CheckTimeLbl.TabIndex = 63;
            this.CheckTimeLbl.Text = "CheckTime:";
            // 
            // ChkDateLbl
            // 
            this.ChkDateLbl.AutoSize = true;
            this.ChkDateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ChkDateLbl.Location = new System.Drawing.Point(38, 47);
            this.ChkDateLbl.Name = "ChkDateLbl";
            this.ChkDateLbl.Size = new System.Drawing.Size(48, 14);
            this.ChkDateLbl.TabIndex = 64;
            this.ChkDateLbl.Text = "DateLbl";
            // 
            // ChkedByUserNameLbl
            // 
            this.ChkedByUserNameLbl.AutoSize = true;
            this.ChkedByUserNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkedByUserNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ChkedByUserNameLbl.Location = new System.Drawing.Point(35, 89);
            this.ChkedByUserNameLbl.Name = "ChkedByUserNameLbl";
            this.ChkedByUserNameLbl.Size = new System.Drawing.Size(52, 14);
            this.ChkedByUserNameLbl.TabIndex = 62;
            this.ChkedByUserNameLbl.Text = "TellerLbl";
            // 
            // CheckTime
            // 
            this.CheckTime.AutoSize = true;
            this.CheckTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.CheckTime.Location = new System.Drawing.Point(130, 68);
            this.CheckTime.Name = "CheckTime";
            this.CheckTime.Size = new System.Drawing.Size(52, 14);
            this.CheckTime.TabIndex = 62;
            this.CheckTime.Text = "TellerLbl";
            // 
            // EditReturnItemsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 662);
            this.Controls.Add(this.TeldgView);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReviseBill);
            this.Controls.Add(this.CheckBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditReturnItemsCustomer";
            this.Text = "EditReturnItemsCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PaymentGB.ResumeLayout(false);
            this.PaymentGB.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ReviseInfoGB.ResumeLayout(false);
            this.ReviseInfoGB.PerformLayout();
            this.CheckInfoGB.ResumeLayout(false);
            this.CheckInfoGB.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox CustomerNameTxtBox;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.TextBox CustomersAccountAmountTxtBox;
        private System.Windows.Forms.TextBox PhoneTxtBox;
        private System.Windows.Forms.Label CustomersAccountAmount;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.Label TotalTaxlbl;
        private System.Windows.Forms.Label SubtotalLbl;
        private System.Windows.Forms.TextBox TaxTxtBox;
        private System.Windows.Forms.TextBox SubtotalTxtBox;
        private System.Windows.Forms.Label BillNumberLbl;
        private System.Windows.Forms.TextBox InvoiceNumTxtBox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label TellerLbl;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.TextBox TotalTxtBox;
        private System.Windows.Forms.Label EditReturnItemsCustomerLbl;
        private System.Windows.Forms.Label TotalBillLbl;
        private System.Windows.Forms.Label PrintBtn;
        private System.Windows.Forms.Button PaymentAndPrintBtn;
        private System.Windows.Forms.Label ReviseBill;
        private System.Windows.Forms.Label CheckBill;
        private System.Windows.Forms.Button ReviseBillBtn;
        private System.Windows.Forms.Button ChkBillBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label IsRevisedLbl;
        private System.Windows.Forms.GroupBox ReviseInfoGB;
        private System.Windows.Forms.Label ReviseDate;
        private System.Windows.Forms.Label ReviseLossProfit;
        private System.Windows.Forms.Label ReviseTimeLbl;
        private System.Windows.Forms.Label RevisedBy;
        private System.Windows.Forms.Label ReviseDatelbl;
        private System.Windows.Forms.Label ReviseLossProfitLbl;
        private System.Windows.Forms.Label ReviseTime;
        private System.Windows.Forms.Label RevisedBylbl;
        private System.Windows.Forms.GroupBox CheckInfoGB;
        private System.Windows.Forms.Label ChkDate;
        private System.Windows.Forms.Label ChkedBy;
        private System.Windows.Forms.Label CheckTimeLbl;
        private System.Windows.Forms.Label ChkDateLbl;
        private System.Windows.Forms.Label ChkedByUserNameLbl;
        private System.Windows.Forms.Label CheckTime;
        private System.Windows.Forms.GroupBox PaymentGB;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}