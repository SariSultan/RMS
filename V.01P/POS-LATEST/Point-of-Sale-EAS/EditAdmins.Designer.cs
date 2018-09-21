namespace Calcium_RMS
{
    partial class EditAdmins
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
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.UserInfoGB = new System.Windows.Forms.GroupBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.Descriptionlbl = new System.Windows.Forms.Label();
            this.Phone2lbl = new System.Windows.Forms.Label();
            this.Phone1lbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Phone1TxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Phone2TxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.AddressTxtBox = new System.Windows.Forms.TextBox();
            this.DescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.usersTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.UsersTableAdapter();
            this.MakeAdminGB = new System.Windows.Forms.GroupBox();
            this.EditAdminsCheckBox = new System.Windows.Forms.CheckBox();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdatePrivBtn = new System.Windows.Forms.Button();
            this.AddCustomerLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UserInfoGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.MakeAdminGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.UpdateInfoBtn.FlatAppearance.BorderSize = 0;
            this.UpdateInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateInfoBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateInfoBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateInfoBtn.Location = new System.Drawing.Point(78, 496);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(153, 24);
            this.UpdateInfoBtn.TabIndex = 22;
            this.UpdateInfoBtn.Text = "Update Information";
            this.UpdateInfoBtn.UseVisualStyleBackColor = false;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click);
            // 
            // UserInfoGB
            // 
            this.UserInfoGB.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoGB.Controls.Add(this.PasswordLbl);
            this.UserInfoGB.Controls.Add(this.Descriptionlbl);
            this.UserInfoGB.Controls.Add(this.Phone2lbl);
            this.UserInfoGB.Controls.Add(this.Phone1lbl);
            this.UserInfoGB.Controls.Add(this.AddressLbl);
            this.UserInfoGB.Controls.Add(this.NameLbl);
            this.UserInfoGB.Controls.Add(this.Phone1TxtBox);
            this.UserInfoGB.Controls.Add(this.PasswordTxtBox);
            this.UserInfoGB.Controls.Add(this.Phone2TxtBox);
            this.UserInfoGB.Controls.Add(this.NameTxtBox);
            this.UserInfoGB.Controls.Add(this.AddressTxtBox);
            this.UserInfoGB.Controls.Add(this.DescriptionTxtBox);
            this.UserInfoGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.UserInfoGB.Location = new System.Drawing.Point(14, 108);
            this.UserInfoGB.Name = "UserInfoGB";
            this.UserInfoGB.Size = new System.Drawing.Size(280, 373);
            this.UserInfoGB.TabIndex = 21;
            this.UserInfoGB.TabStop = false;
            this.UserInfoGB.Text = "Information";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.Location = new System.Drawing.Point(111, 219);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(58, 14);
            this.PasswordLbl.TabIndex = 12;
            this.PasswordLbl.Text = "Password";
            // 
            // Descriptionlbl
            // 
            this.Descriptionlbl.AutoSize = true;
            this.Descriptionlbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descriptionlbl.Location = new System.Drawing.Point(107, 271);
            this.Descriptionlbl.Name = "Descriptionlbl";
            this.Descriptionlbl.Size = new System.Drawing.Size(67, 14);
            this.Descriptionlbl.TabIndex = 11;
            this.Descriptionlbl.Text = "Description";
            // 
            // Phone2lbl
            // 
            this.Phone2lbl.AutoSize = true;
            this.Phone2lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone2lbl.Location = new System.Drawing.Point(116, 168);
            this.Phone2lbl.Name = "Phone2lbl";
            this.Phone2lbl.Size = new System.Drawing.Size(49, 14);
            this.Phone2lbl.TabIndex = 10;
            this.Phone2lbl.Text = "Phone2";
            // 
            // Phone1lbl
            // 
            this.Phone1lbl.AutoSize = true;
            this.Phone1lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1lbl.Location = new System.Drawing.Point(116, 120);
            this.Phone1lbl.Name = "Phone1lbl";
            this.Phone1lbl.Size = new System.Drawing.Size(49, 14);
            this.Phone1lbl.TabIndex = 9;
            this.Phone1lbl.Text = "Phone1";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.Location = new System.Drawing.Point(115, 72);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(50, 14);
            this.AddressLbl.TabIndex = 8;
            this.AddressLbl.Text = "Address";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(121, 24);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 14);
            this.NameLbl.TabIndex = 7;
            this.NameLbl.Text = "Name";
            // 
            // Phone1TxtBox
            // 
            this.Phone1TxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1TxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.Phone1TxtBox.Location = new System.Drawing.Point(64, 139);
            this.Phone1TxtBox.Name = "Phone1TxtBox";
            this.Phone1TxtBox.Size = new System.Drawing.Size(153, 21);
            this.Phone1TxtBox.TabIndex = 6;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.PasswordTxtBox.Location = new System.Drawing.Point(64, 242);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(153, 21);
            this.PasswordTxtBox.TabIndex = 5;
            // 
            // Phone2TxtBox
            // 
            this.Phone2TxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone2TxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.Phone2TxtBox.Location = new System.Drawing.Point(64, 188);
            this.Phone2TxtBox.Name = "Phone2TxtBox";
            this.Phone2TxtBox.Size = new System.Drawing.Size(153, 21);
            this.Phone2TxtBox.TabIndex = 3;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.NameTxtBox.Location = new System.Drawing.Point(64, 43);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(153, 21);
            this.NameTxtBox.TabIndex = 2;
            // 
            // AddressTxtBox
            // 
            this.AddressTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.AddressTxtBox.Location = new System.Drawing.Point(64, 91);
            this.AddressTxtBox.Name = "AddressTxtBox";
            this.AddressTxtBox.Size = new System.Drawing.Size(153, 21);
            this.AddressTxtBox.TabIndex = 1;
            // 
            // DescriptionTxtBox
            // 
            this.DescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.DescriptionTxtBox.Location = new System.Drawing.Point(64, 293);
            this.DescriptionTxtBox.Multiline = true;
            this.DescriptionTxtBox.Name = "DescriptionTxtBox";
            this.DescriptionTxtBox.Size = new System.Drawing.Size(153, 62);
            this.DescriptionTxtBox.TabIndex = 0;
            // 
            // UserNameComboBox
            // 
            this.UserNameComboBox.DataSource = this.usersBindingSource;
            this.UserNameComboBox.DisplayMember = "UserName";
            this.UserNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.UserNameComboBox.FormattingEnabled = true;
            this.UserNameComboBox.Location = new System.Drawing.Point(14, 80);
            this.UserNameComboBox.Name = "UserNameComboBox";
            this.UserNameComboBox.Size = new System.Drawing.Size(280, 21);
            this.UserNameComboBox.TabIndex = 20;
            this.UserNameComboBox.ValueMember = "ID";
            this.UserNameComboBox.SelectedValueChanged += new System.EventHandler(this.UserNameComboBox_SelectedValueChanged);
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
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // MakeAdminGB
            // 
            this.MakeAdminGB.BackColor = System.Drawing.Color.Transparent;
            this.MakeAdminGB.Controls.Add(this.EditAdminsCheckBox);
            this.MakeAdminGB.Controls.Add(this.AdminCheckBox);
            this.MakeAdminGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeAdminGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.MakeAdminGB.Location = new System.Drawing.Point(14, 546);
            this.MakeAdminGB.Name = "MakeAdminGB";
            this.MakeAdminGB.Size = new System.Drawing.Size(280, 55);
            this.MakeAdminGB.TabIndex = 21;
            this.MakeAdminGB.TabStop = false;
            this.MakeAdminGB.Text = "Admin";
            // 
            // EditAdminsCheckBox
            // 
            this.EditAdminsCheckBox.AutoSize = true;
            this.EditAdminsCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAdminsCheckBox.Location = new System.Drawing.Point(145, 23);
            this.EditAdminsCheckBox.Name = "EditAdminsCheckBox";
            this.EditAdminsCheckBox.Size = new System.Drawing.Size(123, 18);
            this.EditAdminsCheckBox.TabIndex = 0;
            this.EditAdminsCheckBox.Text = "Allow Edit Admins";
            this.EditAdminsCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckBox.Location = new System.Drawing.Point(17, 23);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(60, 18);
            this.AdminCheckBox.TabIndex = 0;
            this.AdminCheckBox.Text = "Admin";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
            // 
            // UpdatePrivBtn
            // 
            this.UpdatePrivBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.UpdatePrivBtn.FlatAppearance.BorderSize = 0;
            this.UpdatePrivBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdatePrivBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePrivBtn.ForeColor = System.Drawing.Color.White;
            this.UpdatePrivBtn.Location = new System.Drawing.Point(78, 610);
            this.UpdatePrivBtn.Name = "UpdatePrivBtn";
            this.UpdatePrivBtn.Size = new System.Drawing.Size(153, 24);
            this.UpdatePrivBtn.TabIndex = 22;
            this.UpdatePrivBtn.Text = "Update Priviliges";
            this.UpdatePrivBtn.UseVisualStyleBackColor = false;
            this.UpdatePrivBtn.Click += new System.EventHandler(this.UpdatePrivBtn_Click);
            // 
            // AddCustomerLbl
            // 
            this.AddCustomerLbl.AutoSize = true;
            this.AddCustomerLbl.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomerLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.AddCustomerLbl.Location = new System.Drawing.Point(83, 9);
            this.AddCustomerLbl.Name = "AddCustomerLbl";
            this.AddCustomerLbl.Size = new System.Drawing.Size(142, 25);
            this.AddCustomerLbl.TabIndex = 63;
            this.AddCustomerLbl.Text = "EDIT ADMINS";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UserNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.UserNameLbl.Location = new System.Drawing.Point(119, 63);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(70, 14);
            this.UserNameLbl.TabIndex = 19;
            this.UserNameLbl.Text = "User Name";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "----------------------------------------------------------------------";
            // 
            // EditAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(312, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.UpdateInfoBtn);
            this.Controls.Add(this.AddCustomerLbl);
            this.Controls.Add(this.UpdatePrivBtn);
            this.Controls.Add(this.MakeAdminGB);
            this.Controls.Add(this.UserInfoGB);
            this.Controls.Add(this.UserNameComboBox);
            this.Controls.Add(this.UserNameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "EditAdmins";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditAdmins";
            this.Load += new System.EventHandler(this.EditAdmins_Load);
            this.UserInfoGB.ResumeLayout(false);
            this.UserInfoGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.MakeAdminGB.ResumeLayout(false);
            this.MakeAdminGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.GroupBox UserInfoGB;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label Descriptionlbl;
        private System.Windows.Forms.Label Phone2lbl;
        private System.Windows.Forms.Label Phone1lbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox Phone1TxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox Phone2TxtBox;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox AddressTxtBox;
        private System.Windows.Forms.TextBox DescriptionTxtBox;
        private System.Windows.Forms.ComboBox UserNameComboBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.GroupBox MakeAdminGB;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.CheckBox EditAdminsCheckBox;
        private System.Windows.Forms.Button UpdatePrivBtn;
        private System.Windows.Forms.Label AddCustomerLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Label label4;
    }
}