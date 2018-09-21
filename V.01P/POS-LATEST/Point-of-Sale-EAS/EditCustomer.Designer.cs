namespace Calcium_RMS
{
    partial class EditCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCustomer));
            this.CustomerInfoGB = new System.Windows.Forms.GroupBox();
            this.Err1 = new System.Windows.Forms.Label();
            this.MakeUserAccountChkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.Phone1TxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.Phone1Lbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.UpdateCustomerBtn = new System.Windows.Forms.Button();
            this.Phone1ComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.Phone1ComboBoxlbl = new System.Windows.Forms.Label();
            this.customerTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CustomerTableAdapter();
            this.EditCustomersLbl = new System.Windows.Forms.Label();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.CustomerInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerInfoGB
            // 
            this.CustomerInfoGB.BackColor = System.Drawing.Color.Transparent;
            this.CustomerInfoGB.Controls.Add(this.Err1);
            this.CustomerInfoGB.Controls.Add(this.MakeUserAccountChkBox);
            this.CustomerInfoGB.Controls.Add(this.label3);
            this.CustomerInfoGB.Controls.Add(this.label1);
            this.CustomerInfoGB.Controls.Add(this.AddressTxtBox);
            this.CustomerInfoGB.Controls.Add(this.Phone1TxtBox);
            this.CustomerInfoGB.Controls.Add(this.NameTxtBox);
            this.CustomerInfoGB.Controls.Add(this.Phone1Lbl);
            this.CustomerInfoGB.Controls.Add(this.NameLbl);
            this.CustomerInfoGB.Controls.Add(this.EmailTxtBox);
            this.CustomerInfoGB.Controls.Add(this.EmailLbl);
            this.CustomerInfoGB.Controls.Add(this.AddressLbl);
            this.CustomerInfoGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerInfoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.CustomerInfoGB.Location = new System.Drawing.Point(14, 108);
            this.CustomerInfoGB.Name = "CustomerInfoGB";
            this.CustomerInfoGB.Size = new System.Drawing.Size(280, 344);
            this.CustomerInfoGB.TabIndex = 17;
            this.CustomerInfoGB.TabStop = false;
            this.CustomerInfoGB.Text = "Customer Information";
            // 
            // Err1
            // 
            this.Err1.AutoSize = true;
            this.Err1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Err1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Err1.Location = new System.Drawing.Point(25, 304);
            this.Err1.Name = "Err1";
            this.Err1.Size = new System.Drawing.Size(228, 15);
            this.Err1.TabIndex = 25;
            this.Err1.Text = "You Cannot Remove a Customer Account";
            // 
            // MakeUserAccountChkBox
            // 
            this.MakeUserAccountChkBox.AutoSize = true;
            this.MakeUserAccountChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.MakeUserAccountChkBox.Location = new System.Drawing.Point(64, 267);
            this.MakeUserAccountChkBox.Name = "MakeUserAccountChkBox";
            this.MakeUserAccountChkBox.Size = new System.Drawing.Size(145, 18);
            this.MakeUserAccountChkBox.TabIndex = 10;
            this.MakeUserAccountChkBox.Text = "Make User Acoount";
            this.MakeUserAccountChkBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(46, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(46, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddressTxtBox.Location = new System.Drawing.Point(64, 188);
            this.AddressTxtBox.Multiline = true;
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(153, 62);
            this.AddressTxtBox.TabIndex = 4;
            // 
            // Phone1TxtBox
            // 
            this.Phone1TxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1TxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.Phone1TxtBox.Location = new System.Drawing.Point(64, 91);
            this.Phone1TxtBox.Name = "Phone1TxtBox";
            this.Phone1TxtBox.Size = new System.Drawing.Size(153, 21);
            this.Phone1TxtBox.TabIndex = 5;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.NameTxtBox.Location = new System.Drawing.Point(64, 43);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(153, 21);
            this.NameTxtBox.TabIndex = 1;
            // 
            // Phone1Lbl
            // 
            this.Phone1Lbl.AutoSize = true;
            this.Phone1Lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.Phone1Lbl.Location = new System.Drawing.Point(117, 72);
            this.Phone1Lbl.Name = "Phone1Lbl";
            this.Phone1Lbl.Size = new System.Drawing.Size(49, 14);
            this.Phone1Lbl.TabIndex = 6;
            this.Phone1Lbl.Text = "Phone1";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.NameLbl.Location = new System.Drawing.Point(122, 24);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 14);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.EmailTxtBox.Location = new System.Drawing.Point(64, 139);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(153, 21);
            this.EmailTxtBox.TabIndex = 3;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.EmailLbl.Location = new System.Drawing.Point(124, 120);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(34, 14);
            this.EmailLbl.TabIndex = 4;
            this.EmailLbl.Text = "Email";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.AddressLbl.Location = new System.Drawing.Point(116, 168);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(50, 14);
            this.AddressLbl.TabIndex = 5;
            this.AddressLbl.Text = "Address";
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.UpdateCustomerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateCustomerBtn.FlatAppearance.BorderSize = 0;
            this.UpdateCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(14, 458);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(280, 34);
            this.UpdateCustomerBtn.TabIndex = 22;
            this.UpdateCustomerBtn.Text = "Update Information";
            this.UpdateCustomerBtn.UseVisualStyleBackColor = false;
            this.UpdateCustomerBtn.Visible = false;
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.UpdateCustomerBtn_Click);
            // 
            // Phone1ComboBox
            // 
            this.Phone1ComboBox.DataSource = this.customerBindingSource;
            this.Phone1ComboBox.DisplayMember = "Phone1";
            this.Phone1ComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.Phone1ComboBox.FormattingEnabled = true;
            this.Phone1ComboBox.Location = new System.Drawing.Point(14, 77);
            this.Phone1ComboBox.Name = "Phone1ComboBox";
            this.Phone1ComboBox.Size = new System.Drawing.Size(280, 21);
            this.Phone1ComboBox.TabIndex = 18;
            this.Phone1ComboBox.ValueMember = "ID";
            this.Phone1ComboBox.TextChanged += new System.EventHandler(this.Phone1ComboBox_TextChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Phone1ComboBoxlbl
            // 
            this.Phone1ComboBoxlbl.AutoSize = true;
            this.Phone1ComboBoxlbl.BackColor = System.Drawing.Color.Transparent;
            this.Phone1ComboBoxlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1ComboBoxlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.Phone1ComboBoxlbl.Location = new System.Drawing.Point(107, 60);
            this.Phone1ComboBoxlbl.Name = "Phone1ComboBoxlbl";
            this.Phone1ComboBoxlbl.Size = new System.Drawing.Size(95, 14);
            this.Phone1ComboBoxlbl.TabIndex = 20;
            this.Phone1ComboBoxlbl.Text = "SeachByPhone1";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // EditCustomersLbl
            // 
            this.EditCustomersLbl.AutoSize = true;
            this.EditCustomersLbl.BackColor = System.Drawing.Color.Transparent;
            this.EditCustomersLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.EditCustomersLbl.Location = new System.Drawing.Point(73, 9);
            this.EditCustomersLbl.Name = "EditCustomersLbl";
            this.EditCustomersLbl.Size = new System.Drawing.Size(180, 25);
            this.EditCustomersLbl.TabIndex = 23;
            this.EditCustomersLbl.Text = "EDIT CUSTOMERS";
            // 
            // MinimizePB
            // 
            this.MinimizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePB.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePB.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.MinimizePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Location = new System.Drawing.Point(-410, 9);
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
            this.ExitPB.Location = new System.Drawing.Point(-389, 9);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(15, 15);
            this.ExitPB.TabIndex = 115;
            this.ExitPB.TabStop = false;
            this.ExitPB.Visible = false;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(310, 512);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.EditCustomersLbl);
            this.Controls.Add(this.Phone1ComboBoxlbl);
            this.Controls.Add(this.Phone1ComboBox);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.CustomerInfoGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditCustomer";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.CustomerInfoGB.ResumeLayout(false);
            this.CustomerInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerInfoGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TextBox Phone1TxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Label Phone1Lbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.ComboBox Phone1ComboBox;
        private System.Windows.Forms.Label Phone1ComboBoxlbl;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Button UpdateCustomerBtn;
        private System.Windows.Forms.Label EditCustomersLbl;
        private System.Windows.Forms.CheckBox MakeUserAccountChkBox;
        private System.Windows.Forms.Label Err1;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
    }
}