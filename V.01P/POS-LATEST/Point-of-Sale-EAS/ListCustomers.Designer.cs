namespace Calcium_RMS
{
    partial class ListCustomers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCustomers));
            this.ListCustomersLbl = new System.Windows.Forms.Label();
            this.ListCustomersDGView = new System.Windows.Forms.DataGridView();
            this.Namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListCustomersBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.TotalITemsTxtBox = new System.Windows.Forms.TextBox();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalItemsLbl = new System.Windows.Forms.Label();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportToPdfBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomersDGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListCustomersLbl
            // 
            this.ListCustomersLbl.AutoSize = true;
            this.ListCustomersLbl.BackColor = System.Drawing.Color.Transparent;
            this.ListCustomersLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ListCustomersLbl.Location = new System.Drawing.Point(682, 0);
            this.ListCustomersLbl.Name = "ListCustomersLbl";
            this.ListCustomersLbl.Size = new System.Drawing.Size(153, 25);
            this.ListCustomersLbl.TabIndex = 21;
            this.ListCustomersLbl.Text = "List Customers";
            this.ListCustomersLbl.Visible = false;
            // 
            // ListCustomersDGView
            // 
            this.ListCustomersDGView.AllowUserToAddRows = false;
            this.ListCustomersDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListCustomersDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListCustomersDGView.BackgroundColor = System.Drawing.Color.White;
            this.ListCustomersDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCustomersDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namecol,
            this.AccountAmount,
            this.Phone1,
            this.Email,
            this.Address});
            this.ListCustomersDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListCustomersDGView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ListCustomersDGView.Location = new System.Drawing.Point(0, 116);
            this.ListCustomersDGView.Name = "ListCustomersDGView";
            this.ListCustomersDGView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListCustomersDGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListCustomersDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListCustomersDGView.ShowEditingIcon = false;
            this.ListCustomersDGView.Size = new System.Drawing.Size(595, 523);
            this.ListCustomersDGView.TabIndex = 22;
            this.ListCustomersDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCustomersDGView_CellDoubleClick);
            // 
            // Namecol
            // 
            this.Namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Namecol.HeaderText = "Name";
            this.Namecol.Name = "Namecol";
            this.Namecol.ReadOnly = true;
            this.Namecol.Width = 59;
            // 
            // AccountAmount
            // 
            this.AccountAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AccountAmount.HeaderText = "AccountAmount";
            this.AccountAmount.Name = "AccountAmount";
            this.AccountAmount.ReadOnly = true;
            this.AccountAmount.Width = 108;
            // 
            // Phone1
            // 
            this.Phone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone1.HeaderText = "Phone";
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            this.Phone1.Width = 62;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 56;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // ListCustomersBtn
            // 
            this.ListCustomersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ListCustomersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListCustomersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListCustomersBtn.FlatAppearance.BorderSize = 0;
            this.ListCustomersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListCustomersBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListCustomersBtn.ForeColor = System.Drawing.Color.White;
            this.ListCustomersBtn.Location = new System.Drawing.Point(12, 7);
            this.ListCustomersBtn.Name = "ListCustomersBtn";
            this.ListCustomersBtn.Size = new System.Drawing.Size(100, 100);
            this.ListCustomersBtn.TabIndex = 1;
            this.ListCustomersBtn.Text = "Customers List";
            this.ListCustomersBtn.UseVisualStyleBackColor = false;
            this.ListCustomersBtn.Click += new System.EventHandler(this.ListCustomersBtn_Click);
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ItemsPerPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ItemsPerPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(404, 34);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(65, 24);
            this.ItemsPerPageBtn.TabIndex = 8;
            this.ItemsPerPageBtn.Text = "Change";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(326, 36);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(72, 20);
            this.ItemsPerPageTxtBox.TabIndex = 7;
            this.ItemsPerPageTxtBox.Text = "10";
            this.ItemsPerPageTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemsPerPageTxtBox_KeyPress);
            // 
            // TotalITemsTxtBox
            // 
            this.TotalITemsTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.TotalITemsTxtBox.Enabled = false;
            this.TotalITemsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.TotalITemsTxtBox.Location = new System.Drawing.Point(521, 87);
            this.TotalITemsTxtBox.Name = "TotalITemsTxtBox";
            this.TotalITemsTxtBox.ReadOnly = true;
            this.TotalITemsTxtBox.Size = new System.Drawing.Size(62, 20);
            this.TotalITemsTxtBox.TabIndex = 9;
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(194, 36);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 4;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(300, 36);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 6;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PageOfTotalTxtBox.Enabled = false;
            this.PageOfTotalTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(220, 36);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(74, 20);
            this.PageOfTotalTxtBox.TabIndex = 5;
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.BackColor = System.Drawing.Color.White;
            this.GotoPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.GotoPageTxtBox.Location = new System.Drawing.Point(91, 36);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(97, 20);
            this.GotoPageTxtBox.TabIndex = 2;
            this.GotoPageTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GotoPageTxtBox_KeyPress);
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.GoToPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(91, 6);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(97, 24);
            this.GoToPageBtn.TabIndex = 3;
            this.GoToPageBtn.Text = "GoToPage";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(323, 16);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(104, 14);
            this.ItemsPerPageLbl.TabIndex = 43;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.TotalItemsLbl.Location = new System.Drawing.Point(518, 67);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(66, 14);
            this.TotalItemsLbl.TabIndex = 44;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.TotalPagesLbl.Location = new System.Drawing.Point(237, 17);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(34, 14);
            this.TotalPagesLbl.TabIndex = 64;
            this.TotalPagesLbl.Text = "Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ListCustomersBtn);
            this.panel1.Controls.Add(this.ListCustomersLbl);
            this.panel1.Controls.Add(this.ExportToPdfBtn);
            this.panel1.Controls.Add(this.TotalITemsTxtBox);
            this.panel1.Controls.Add(this.TotalItemsLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 116);
            this.panel1.TabIndex = 65;
            // 
            // ExportToPdfBtn
            // 
            this.ExportToPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.ExportToPdfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportToPdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportToPdfBtn.FlatAppearance.BorderSize = 0;
            this.ExportToPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToPdfBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToPdfBtn.ForeColor = System.Drawing.Color.White;
            this.ExportToPdfBtn.Location = new System.Drawing.Point(118, 7);
            this.ExportToPdfBtn.Name = "ExportToPdfBtn";
            this.ExportToPdfBtn.Size = new System.Drawing.Size(100, 100);
            this.ExportToPdfBtn.TabIndex = 10;
            this.ExportToPdfBtn.Text = "Export As PDF File";
            this.ExportToPdfBtn.UseVisualStyleBackColor = false;
            this.ExportToPdfBtn.Click += new System.EventHandler(this.ExportToPdfBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TotalPagesLbl);
            this.panel2.Controls.Add(this.ItemsPerPageBtn);
            this.panel2.Controls.Add(this.PageOfTotalTxtBox);
            this.panel2.Controls.Add(this.GotoPageTxtBox);
            this.panel2.Controls.Add(this.NextPage);
            this.panel2.Controls.Add(this.GoToPageBtn);
            this.panel2.Controls.Add(this.ItemsPerPageTxtBox);
            this.panel2.Controls.Add(this.PreviousPage);
            this.panel2.Controls.Add(this.ItemsPerPageLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 639);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 61);
            this.panel2.TabIndex = 66;
            // 
            // ListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(595, 700);
            this.Controls.Add(this.ListCustomersDGView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers List";
            ((System.ComponentModel.ISupportInitialize)(this.ListCustomersDGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ListCustomersLbl;
        private System.Windows.Forms.DataGridView ListCustomersDGView;
        private System.Windows.Forms.Button ListCustomersBtn;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.TextBox TotalITemsTxtBox;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalItemsLbl;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button ExportToPdfBtn;
        private System.Windows.Forms.Panel panel2;
    }
}