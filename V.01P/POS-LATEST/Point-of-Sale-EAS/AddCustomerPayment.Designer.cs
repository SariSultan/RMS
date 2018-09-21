namespace Calcium_RMS
{
    partial class AddCustomerPayment
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
            this.CustomerPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.AccountBalnaceLbl = new System.Windows.Forms.Label();
            this.CustomerBalanceTxtBox = new System.Windows.Forms.TextBox();
            this.PaymentAmountLbl = new System.Windows.Forms.Label();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.PaymentAmountTxtBox = new System.Windows.Forms.TextBox();
            this.CommentsTxtBox = new System.Windows.Forms.TextBox();
            this.AddPaymentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaymentMethodCheckBox = new System.Windows.Forms.ComboBox();
            this.paymentMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.PaymentMethodDescripTxtBox = new System.Windows.Forms.TextBox();
            this.AccountDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentMethodLbl = new System.Windows.Forms.Label();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.AccountBalanceLbl = new System.Windows.Forms.Label();
            this.AccountBalanceTxtBox = new System.Windows.Forms.TextBox();
            this.CheckGB = new System.Windows.Forms.GroupBox();
            this.CheckDatePicker = new System.Windows.Forms.DateTimePicker();
            this.HolderNameTxtBox = new System.Windows.Forms.TextBox();
            this.CheckCommentsLbl = new System.Windows.Forms.Label();
            this.CheckNumberTxtBox = new System.Windows.Forms.TextBox();
            this.CheckHolderNameLbl = new System.Windows.Forms.Label();
            this.PaymentDateLbl = new System.Windows.Forms.Label();
            this.CheckNumber = new System.Windows.Forms.Label();
            this.CheckCommentsTxtBox = new System.Windows.Forms.TextBox();
            this.PayInVisaGB = new System.Windows.Forms.GroupBox();
            this.CreditCardInfoTxtBox = new System.Windows.Forms.TextBox();
            this.PaymentCommentsLbl = new System.Windows.Forms.Label();
            this.accountsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.AccountsTableAdapter();
            this.paymentMethodTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.PaymentMethodTableAdapter();
            this.PaymentNumberLbl = new System.Windows.Forms.Label();
            this.PaymentNumberTxtBox = new System.Windows.Forms.TextBox();
            this.AddCustomerLbl = new System.Windows.Forms.Label();
            this.CustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CustomerTableAdapter();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.AddPaymentandPrintBtn = new System.Windows.Forms.Button();
            this.PayDateStaticPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintingThermalA4ChkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.CheckGB.SuspendLayout();
            this.PayInVisaGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerPhoneTxtBox
            // 
            this.CustomerPhoneTxtBox.BackColor = System.Drawing.Color.White;
            this.CustomerPhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerPhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerPhoneTxtBox.Location = new System.Drawing.Point(285, 55);
            this.CustomerPhoneTxtBox.Name = "CustomerPhoneTxtBox";
            this.CustomerPhoneTxtBox.Size = new System.Drawing.Size(130, 20);
            this.CustomerPhoneTxtBox.TabIndex = 0;
            this.CustomerPhoneTxtBox.TextChanged += new System.EventHandler(this.CustomerPhoneTxtBox_TextChanged);
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(306, 38);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(98, 14);
            this.CustomerPhoneLbl.TabIndex = 1;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomerNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerNameLbl.Location = new System.Drawing.Point(66, 38);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(94, 14);
            this.CustomerNameLbl.TabIndex = 1;
            this.CustomerNameLbl.Text = "Customer Name";
            // 
            // AccountBalnaceLbl
            // 
            this.AccountBalnaceLbl.AutoSize = true;
            this.AccountBalnaceLbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountBalnaceLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalnaceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountBalnaceLbl.Location = new System.Drawing.Point(93, 79);
            this.AccountBalnaceLbl.Name = "AccountBalnaceLbl";
            this.AccountBalnaceLbl.Size = new System.Drawing.Size(48, 14);
            this.AccountBalnaceLbl.TabIndex = 1;
            this.AccountBalnaceLbl.Text = "Balance";
            // 
            // CustomerBalanceTxtBox
            // 
            this.CustomerBalanceTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.CustomerBalanceTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerBalanceTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerBalanceTxtBox.Location = new System.Drawing.Point(6, 96);
            this.CustomerBalanceTxtBox.Name = "CustomerBalanceTxtBox";
            this.CustomerBalanceTxtBox.ReadOnly = true;
            this.CustomerBalanceTxtBox.Size = new System.Drawing.Size(274, 20);
            this.CustomerBalanceTxtBox.TabIndex = 0;
            // 
            // PaymentAmountLbl
            // 
            this.PaymentAmountLbl.AutoSize = true;
            this.PaymentAmountLbl.BackColor = System.Drawing.Color.Transparent;
            this.PaymentAmountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentAmountLbl.Location = new System.Drawing.Point(290, 79);
            this.PaymentAmountLbl.Name = "PaymentAmountLbl";
            this.PaymentAmountLbl.Size = new System.Drawing.Size(122, 14);
            this.PaymentAmountLbl.TabIndex = 1;
            this.PaymentAmountLbl.Text = "Payment Amount Lbl";
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.BackColor = System.Drawing.Color.Transparent;
            this.CommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CommentsLbl.Location = new System.Drawing.Point(113, 456);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(80, 14);
            this.CommentsLbl.TabIndex = 1;
            this.CommentsLbl.Text = "CommentsLbl";
            // 
            // PaymentAmountTxtBox
            // 
            this.PaymentAmountTxtBox.BackColor = System.Drawing.Color.White;
            this.PaymentAmountTxtBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentAmountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentAmountTxtBox.Location = new System.Drawing.Point(286, 94);
            this.PaymentAmountTxtBox.Name = "PaymentAmountTxtBox";
            this.PaymentAmountTxtBox.Size = new System.Drawing.Size(129, 22);
            this.PaymentAmountTxtBox.TabIndex = 0;
            this.PaymentAmountTxtBox.Text = "0.00";
            // 
            // CommentsTxtBox
            // 
            this.CommentsTxtBox.BackColor = System.Drawing.Color.White;
            this.CommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CommentsTxtBox.Location = new System.Drawing.Point(6, 473);
            this.CommentsTxtBox.Multiline = true;
            this.CommentsTxtBox.Name = "CommentsTxtBox";
            this.CommentsTxtBox.Size = new System.Drawing.Size(300, 51);
            this.CommentsTxtBox.TabIndex = 0;
            // 
            // AddPaymentBtn
            // 
            this.AddPaymentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddPaymentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPaymentBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPaymentBtn.FlatAppearance.BorderSize = 0;
            this.AddPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPaymentBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPaymentBtn.ForeColor = System.Drawing.Color.White;
            this.AddPaymentBtn.Location = new System.Drawing.Point(312, 473);
            this.AddPaymentBtn.Name = "AddPaymentBtn";
            this.AddPaymentBtn.Size = new System.Drawing.Size(135, 51);
            this.AddPaymentBtn.TabIndex = 2;
            this.AddPaymentBtn.Text = "Add Payment";
            this.AddPaymentBtn.UseVisualStyleBackColor = false;
            this.AddPaymentBtn.Click += new System.EventHandler(this.AddPaymentBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PaymentMethodCheckBox);
            this.groupBox1.Controls.Add(this.PaymentMethodDescripTxtBox);
            this.groupBox1.Controls.Add(this.AccountDescriptionTxtBox);
            this.groupBox1.Controls.Add(this.AccountComboBox);
            this.groupBox1.Controls.Add(this.PaymentMethodLbl);
            this.groupBox1.Controls.Add(this.AccountLbl);
            this.groupBox1.Controls.Add(this.AccountBalanceLbl);
            this.groupBox1.Controls.Add(this.AccountBalanceTxtBox);
            this.groupBox1.Controls.Add(this.CheckGB);
            this.groupBox1.Controls.Add(this.PayInVisaGB);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.groupBox1.Location = new System.Drawing.Point(14, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 323);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // PaymentMethodCheckBox
            // 
            this.PaymentMethodCheckBox.DataSource = this.paymentMethodBindingSource;
            this.PaymentMethodCheckBox.DisplayMember = "Name";
            this.PaymentMethodCheckBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodCheckBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.PaymentMethodCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentMethodCheckBox.FormattingEnabled = true;
            this.PaymentMethodCheckBox.Location = new System.Drawing.Point(25, 97);
            this.PaymentMethodCheckBox.Name = "PaymentMethodCheckBox";
            this.PaymentMethodCheckBox.Size = new System.Drawing.Size(145, 21);
            this.PaymentMethodCheckBox.TabIndex = 20;
            this.PaymentMethodCheckBox.ValueMember = "ID";
            this.PaymentMethodCheckBox.SelectedValueChanged += new System.EventHandler(this.PaymentMethodCheckBox_SelectedValueChanged);
            // 
            // paymentMethodBindingSource
            // 
            this.paymentMethodBindingSource.DataMember = "PaymentMethod";
            this.paymentMethodBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentMethodDescripTxtBox
            // 
            this.PaymentMethodDescripTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PaymentMethodDescripTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.PaymentMethodDescripTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentMethodDescripTxtBox.Location = new System.Drawing.Point(175, 97);
            this.PaymentMethodDescripTxtBox.Name = "PaymentMethodDescripTxtBox";
            this.PaymentMethodDescripTxtBox.ReadOnly = true;
            this.PaymentMethodDescripTxtBox.Size = new System.Drawing.Size(181, 20);
            this.PaymentMethodDescripTxtBox.TabIndex = 19;
            // 
            // AccountDescriptionTxtBox
            // 
            this.AccountDescriptionTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.AccountDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AccountDescriptionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountDescriptionTxtBox.Location = new System.Drawing.Point(175, 40);
            this.AccountDescriptionTxtBox.Name = "AccountDescriptionTxtBox";
            this.AccountDescriptionTxtBox.ReadOnly = true;
            this.AccountDescriptionTxtBox.Size = new System.Drawing.Size(181, 20);
            this.AccountDescriptionTxtBox.TabIndex = 19;
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DataSource = this.accountsBindingSource;
            this.AccountComboBox.DisplayMember = "Name";
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AccountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(25, 40);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(145, 21);
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
            this.PaymentMethodLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentMethodLbl.Location = new System.Drawing.Point(47, 76);
            this.PaymentMethodLbl.Name = "PaymentMethodLbl";
            this.PaymentMethodLbl.Size = new System.Drawing.Size(101, 14);
            this.PaymentMethodLbl.TabIndex = 12;
            this.PaymentMethodLbl.Text = "Payment Method";
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountLbl.Location = new System.Drawing.Point(71, 19);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(53, 14);
            this.AccountLbl.TabIndex = 12;
            this.AccountLbl.Text = "Account";
            // 
            // AccountBalanceLbl
            // 
            this.AccountBalanceLbl.AutoSize = true;
            this.AccountBalanceLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalanceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountBalanceLbl.Location = new System.Drawing.Point(394, 76);
            this.AccountBalanceLbl.Name = "AccountBalanceLbl";
            this.AccountBalanceLbl.Size = new System.Drawing.Size(143, 14);
            this.AccountBalanceLbl.TabIndex = 1;
            this.AccountBalanceLbl.Text = "Current Account Balance";
            // 
            // AccountBalanceTxtBox
            // 
            this.AccountBalanceTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.AccountBalanceTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.AccountBalanceTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AccountBalanceTxtBox.Location = new System.Drawing.Point(362, 97);
            this.AccountBalanceTxtBox.Name = "AccountBalanceTxtBox";
            this.AccountBalanceTxtBox.Size = new System.Drawing.Size(206, 20);
            this.AccountBalanceTxtBox.TabIndex = 0;
            this.AccountBalanceTxtBox.TextChanged += new System.EventHandler(this.CustomerPhoneTxtBox_TextChanged);
            // 
            // CheckGB
            // 
            this.CheckGB.Controls.Add(this.CheckDatePicker);
            this.CheckGB.Controls.Add(this.HolderNameTxtBox);
            this.CheckGB.Controls.Add(this.CheckCommentsLbl);
            this.CheckGB.Controls.Add(this.CheckNumberTxtBox);
            this.CheckGB.Controls.Add(this.CheckHolderNameLbl);
            this.CheckGB.Controls.Add(this.PaymentDateLbl);
            this.CheckGB.Controls.Add(this.CheckNumber);
            this.CheckGB.Controls.Add(this.CheckCommentsTxtBox);
            this.CheckGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckGB.Location = new System.Drawing.Point(24, 129);
            this.CheckGB.Name = "CheckGB";
            this.CheckGB.Size = new System.Drawing.Size(544, 178);
            this.CheckGB.TabIndex = 11;
            this.CheckGB.TabStop = false;
            this.CheckGB.Text = "Pay Using Credit Card";
            this.CheckGB.Visible = false;
            // 
            // CheckDatePicker
            // 
            this.CheckDatePicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckDatePicker.Location = new System.Drawing.Point(21, 140);
            this.CheckDatePicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.CheckDatePicker.Name = "CheckDatePicker";
            this.CheckDatePicker.Size = new System.Drawing.Size(154, 20);
            this.CheckDatePicker.TabIndex = 8;
            // 
            // HolderNameTxtBox
            // 
            this.HolderNameTxtBox.BackColor = System.Drawing.Color.White;
            this.HolderNameTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.HolderNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.HolderNameTxtBox.Location = new System.Drawing.Point(193, 41);
            this.HolderNameTxtBox.Name = "HolderNameTxtBox";
            this.HolderNameTxtBox.Size = new System.Drawing.Size(326, 20);
            this.HolderNameTxtBox.TabIndex = 7;
            // 
            // CheckCommentsLbl
            // 
            this.CheckCommentsLbl.AutoSize = true;
            this.CheckCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckCommentsLbl.Location = new System.Drawing.Point(318, 66);
            this.CheckCommentsLbl.Name = "CheckCommentsLbl";
            this.CheckCommentsLbl.Size = new System.Drawing.Size(65, 14);
            this.CheckCommentsLbl.TabIndex = 6;
            this.CheckCommentsLbl.Text = "Comments";
            // 
            // CheckNumberTxtBox
            // 
            this.CheckNumberTxtBox.BackColor = System.Drawing.Color.White;
            this.CheckNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckNumberTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckNumberTxtBox.Location = new System.Drawing.Point(21, 41);
            this.CheckNumberTxtBox.Name = "CheckNumberTxtBox";
            this.CheckNumberTxtBox.ReadOnly = true;
            this.CheckNumberTxtBox.Size = new System.Drawing.Size(154, 20);
            this.CheckNumberTxtBox.TabIndex = 7;
            // 
            // CheckHolderNameLbl
            // 
            this.CheckHolderNameLbl.AutoSize = true;
            this.CheckHolderNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckHolderNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckHolderNameLbl.Location = new System.Drawing.Point(309, 23);
            this.CheckHolderNameLbl.Name = "CheckHolderNameLbl";
            this.CheckHolderNameLbl.Size = new System.Drawing.Size(77, 14);
            this.CheckHolderNameLbl.TabIndex = 6;
            this.CheckHolderNameLbl.Text = "Holder Name";
            // 
            // PaymentDateLbl
            // 
            this.PaymentDateLbl.AutoSize = true;
            this.PaymentDateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentDateLbl.Location = new System.Drawing.Point(45, 118);
            this.PaymentDateLbl.Name = "PaymentDateLbl";
            this.PaymentDateLbl.Size = new System.Drawing.Size(85, 14);
            this.PaymentDateLbl.TabIndex = 6;
            this.PaymentDateLbl.Text = "Payment Date";
            // 
            // CheckNumber
            // 
            this.CheckNumber.AutoSize = true;
            this.CheckNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckNumber.Location = new System.Drawing.Point(57, 23);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(87, 14);
            this.CheckNumber.TabIndex = 6;
            this.CheckNumber.Text = "Check Number";
            // 
            // CheckCommentsTxtBox
            // 
            this.CheckCommentsTxtBox.BackColor = System.Drawing.Color.White;
            this.CheckCommentsTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CheckCommentsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CheckCommentsTxtBox.Location = new System.Drawing.Point(193, 85);
            this.CheckCommentsTxtBox.Multiline = true;
            this.CheckCommentsTxtBox.Name = "CheckCommentsTxtBox";
            this.CheckCommentsTxtBox.Size = new System.Drawing.Size(326, 78);
            this.CheckCommentsTxtBox.TabIndex = 7;
            // 
            // PayInVisaGB
            // 
            this.PayInVisaGB.Controls.Add(this.CreditCardInfoTxtBox);
            this.PayInVisaGB.Controls.Add(this.PaymentCommentsLbl);
            this.PayInVisaGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayInVisaGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PayInVisaGB.Location = new System.Drawing.Point(24, 129);
            this.PayInVisaGB.Name = "PayInVisaGB";
            this.PayInVisaGB.Size = new System.Drawing.Size(544, 178);
            this.PayInVisaGB.TabIndex = 11;
            this.PayInVisaGB.TabStop = false;
            this.PayInVisaGB.Text = "Pay Using Credit Card";
            this.PayInVisaGB.Visible = false;
            // 
            // CreditCardInfoTxtBox
            // 
            this.CreditCardInfoTxtBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardInfoTxtBox.Location = new System.Drawing.Point(79, 24);
            this.CreditCardInfoTxtBox.Multiline = true;
            this.CreditCardInfoTxtBox.Name = "CreditCardInfoTxtBox";
            this.CreditCardInfoTxtBox.Size = new System.Drawing.Size(447, 144);
            this.CreditCardInfoTxtBox.TabIndex = 7;
            // 
            // PaymentCommentsLbl
            // 
            this.PaymentCommentsLbl.AutoSize = true;
            this.PaymentCommentsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentCommentsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentCommentsLbl.Location = new System.Drawing.Point(24, 87);
            this.PaymentCommentsLbl.Name = "PaymentCommentsLbl";
            this.PaymentCommentsLbl.Size = new System.Drawing.Size(29, 14);
            this.PaymentCommentsLbl.TabIndex = 6;
            this.PaymentCommentsLbl.Text = "Info";
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // paymentMethodTableAdapter
            // 
            this.paymentMethodTableAdapter.ClearBeforeFill = true;
            // 
            // PaymentNumberLbl
            // 
            this.PaymentNumberLbl.AutoSize = true;
            this.PaymentNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.PaymentNumberLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentNumberLbl.Location = new System.Drawing.Point(484, 38);
            this.PaymentNumberLbl.Name = "PaymentNumberLbl";
            this.PaymentNumberLbl.Size = new System.Drawing.Size(113, 14);
            this.PaymentNumberLbl.TabIndex = 110;
            this.PaymentNumberLbl.Text = "PaymentNumberLbl";
            // 
            // PaymentNumberTxtBox
            // 
            this.PaymentNumberTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PaymentNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.PaymentNumberTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PaymentNumberTxtBox.Location = new System.Drawing.Point(453, 55);
            this.PaymentNumberTxtBox.Name = "PaymentNumberTxtBox";
            this.PaymentNumberTxtBox.ReadOnly = true;
            this.PaymentNumberTxtBox.Size = new System.Drawing.Size(154, 20);
            this.PaymentNumberTxtBox.TabIndex = 109;
            // 
            // AddCustomerLbl
            // 
            this.AddCustomerLbl.AutoSize = true;
            this.AddCustomerLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddCustomerLbl.Location = new System.Drawing.Point(192, 4);
            this.AddCustomerLbl.Name = "AddCustomerLbl";
            this.AddCustomerLbl.Size = new System.Drawing.Size(255, 25);
            this.AddCustomerLbl.TabIndex = 111;
            this.AddCustomerLbl.Text = "Add Customer Payment";
            // 
            // CustomerNameComboBox
            // 
            this.CustomerNameComboBox.BackColor = System.Drawing.Color.White;
            this.CustomerNameComboBox.DataSource = this.customerBindingSource;
            this.CustomerNameComboBox.DisplayMember = "Name";
            this.CustomerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerNameComboBox.FormattingEnabled = true;
            this.CustomerNameComboBox.Location = new System.Drawing.Point(6, 55);
            this.CustomerNameComboBox.Name = "CustomerNameComboBox";
            this.CustomerNameComboBox.Size = new System.Drawing.Size(275, 21);
            this.CustomerNameComboBox.TabIndex = 114;
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
            // AddPaymentandPrintBtn
            // 
            this.AddPaymentandPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddPaymentandPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPaymentandPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPaymentandPrintBtn.FlatAppearance.BorderSize = 0;
            this.AddPaymentandPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPaymentandPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPaymentandPrintBtn.ForeColor = System.Drawing.Color.White;
            this.AddPaymentandPrintBtn.Location = new System.Drawing.Point(453, 473);
            this.AddPaymentandPrintBtn.Name = "AddPaymentandPrintBtn";
            this.AddPaymentandPrintBtn.Size = new System.Drawing.Size(154, 51);
            this.AddPaymentandPrintBtn.TabIndex = 2;
            this.AddPaymentandPrintBtn.Text = "Add Payment and Print";
            this.AddPaymentandPrintBtn.UseVisualStyleBackColor = false;
            this.AddPaymentandPrintBtn.Click += new System.EventHandler(this.AddPaymentandPrintBtn_Click);
            // 
            // PayDateStaticPicker
            // 
            this.PayDateStaticPicker.Enabled = false;
            this.PayDateStaticPicker.Font = new System.Drawing.Font("Tahoma", 8F);
            this.PayDateStaticPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PayDateStaticPicker.Location = new System.Drawing.Point(453, 92);
            this.PayDateStaticPicker.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.PayDateStaticPicker.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.PayDateStaticPicker.Name = "PayDateStaticPicker";
            this.PayDateStaticPicker.Size = new System.Drawing.Size(154, 20);
            this.PayDateStaticPicker.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.label2.Location = new System.Drawing.Point(418, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 110;
            this.label2.Text = "JOD";
            // 
            // PrintingThermalA4ChkBox
            // 
            this.PrintingThermalA4ChkBox.AutoSize = true;
            this.PrintingThermalA4ChkBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintingThermalA4ChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PrintingThermalA4ChkBox.Location = new System.Drawing.Point(453, 451);
            this.PrintingThermalA4ChkBox.Name = "PrintingThermalA4ChkBox";
            this.PrintingThermalA4ChkBox.Size = new System.Drawing.Size(141, 20);
            this.PrintingThermalA4ChkBox.TabIndex = 159;
            this.PrintingThermalA4ChkBox.Text = "Export As PDF File";
            this.PrintingThermalA4ChkBox.UseVisualStyleBackColor = true;
            // 
            // AddCustomerPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 533);
            this.Controls.Add(this.PrintingThermalA4ChkBox);
            this.Controls.Add(this.PayDateStaticPicker);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.CustomerNameComboBox);
            this.Controls.Add(this.AddCustomerLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PaymentNumberLbl);
            this.Controls.Add(this.PaymentNumberTxtBox);
            this.Controls.Add(this.AddPaymentandPrintBtn);
            this.Controls.Add(this.AddPaymentBtn);
            this.Controls.Add(this.CommentsLbl);
            this.Controls.Add(this.PaymentAmountLbl);
            this.Controls.Add(this.AccountBalnaceLbl);
            this.Controls.Add(this.CustomerNameLbl);
            this.Controls.Add(this.CustomerPhoneLbl);
            this.Controls.Add(this.CustomerBalanceTxtBox);
            this.Controls.Add(this.CommentsTxtBox);
            this.Controls.Add(this.PaymentAmountTxtBox);
            this.Controls.Add(this.CustomerPhoneTxtBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddCustomerPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomerPayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCustomerPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.CheckGB.ResumeLayout(false);
            this.CheckGB.PerformLayout();
            this.PayInVisaGB.ResumeLayout(false);
            this.PayInVisaGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerPhoneTxtBox;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.Label AccountBalnaceLbl;
        private System.Windows.Forms.TextBox CustomerBalanceTxtBox;
        private System.Windows.Forms.Label PaymentAmountLbl;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.TextBox PaymentAmountTxtBox;
        private System.Windows.Forms.TextBox CommentsTxtBox;
        private System.Windows.Forms.Button AddPaymentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PaymentMethodCheckBox;
        private System.Windows.Forms.TextBox PaymentMethodDescripTxtBox;
        private System.Windows.Forms.TextBox AccountDescriptionTxtBox;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label PaymentMethodLbl;
        private System.Windows.Forms.Label AccountLbl;
        private System.Windows.Forms.GroupBox CheckGB;
        private System.Windows.Forms.DateTimePicker CheckDatePicker;
        private System.Windows.Forms.TextBox CheckCommentsTxtBox;
        private System.Windows.Forms.TextBox HolderNameTxtBox;
        private System.Windows.Forms.Label CheckCommentsLbl;
        private System.Windows.Forms.TextBox CheckNumberTxtBox;
        private System.Windows.Forms.Label CheckHolderNameLbl;
        private System.Windows.Forms.Label CheckNumber;
        private System.Windows.Forms.GroupBox PayInVisaGB;
        private System.Windows.Forms.TextBox CreditCardInfoTxtBox;
        private System.Windows.Forms.Label PaymentCommentsLbl;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DBDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.BindingSource paymentMethodBindingSource;
        private DBDataSetTableAdapters.PaymentMethodTableAdapter paymentMethodTableAdapter;

        private System.Windows.Forms.Label PaymentNumberLbl;
        private System.Windows.Forms.TextBox PaymentNumberTxtBox;
        private System.Windows.Forms.Label AccountBalanceLbl;
        private System.Windows.Forms.TextBox AccountBalanceTxtBox;
        private System.Windows.Forms.Label AddCustomerLbl;
        private System.Windows.Forms.ComboBox CustomerNameComboBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Button AddPaymentandPrintBtn;
        private System.Windows.Forms.Label PaymentDateLbl;
        private System.Windows.Forms.DateTimePicker PayDateStaticPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PrintingThermalA4ChkBox;
    }
}