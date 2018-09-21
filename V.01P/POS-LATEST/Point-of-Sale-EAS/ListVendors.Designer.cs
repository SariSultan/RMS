namespace Calcium_RMS
{
    partial class ListVendors
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
            this.ListVendorsBtn = new System.Windows.Forms.Button();
            this.ListVendorsDGView = new System.Windows.Forms.DataGridView();
            this.Namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locationcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.ListVendorsDGView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListVendorsBtn
            // 
            this.ListVendorsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.ListVendorsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ListVendorsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListVendorsBtn.FlatAppearance.BorderSize = 0;
            this.ListVendorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListVendorsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListVendorsBtn.ForeColor = System.Drawing.Color.White;
            this.ListVendorsBtn.Location = new System.Drawing.Point(8, 3);
            this.ListVendorsBtn.Name = "ListVendorsBtn";
            this.ListVendorsBtn.Size = new System.Drawing.Size(100, 100);
            this.ListVendorsBtn.TabIndex = 1;
            this.ListVendorsBtn.Text = "List Vendors";
            this.ListVendorsBtn.UseVisualStyleBackColor = false;
            this.ListVendorsBtn.Click += new System.EventHandler(this.ListVendorsBtn_Click);
            // 
            // ListVendorsDGView
            // 
            this.ListVendorsDGView.AllowUserToAddRows = false;
            this.ListVendorsDGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.ListVendorsDGView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListVendorsDGView.BackgroundColor = System.Drawing.Color.White;
            this.ListVendorsDGView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListVendorsDGView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListVendorsDGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListVendorsDGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namecol,
            this.Locationcol,
            this.Phone1,
            this.Phone2,
            this.Email,
            this.Company,
            this.StartDate,
            this.AccountAmount});
            this.ListVendorsDGView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListVendorsDGView.Location = new System.Drawing.Point(0, 112);
            this.ListVendorsDGView.Name = "ListVendorsDGView";
            this.ListVendorsDGView.ReadOnly = true;
            this.ListVendorsDGView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListVendorsDGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ListVendorsDGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListVendorsDGView.Size = new System.Drawing.Size(574, 528);
            this.ListVendorsDGView.TabIndex = 25;
            this.ListVendorsDGView.TabStop = false;
            this.ListVendorsDGView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListVendorsDGView_CellDoubleClick);
            // 
            // Namecol
            // 
            this.Namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Namecol.HeaderText = "Name";
            this.Namecol.Name = "Namecol";
            this.Namecol.ReadOnly = true;
            this.Namecol.Width = 59;
            // 
            // Locationcol
            // 
            this.Locationcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Locationcol.HeaderText = "Location";
            this.Locationcol.Name = "Locationcol";
            this.Locationcol.ReadOnly = true;
            this.Locationcol.Width = 72;
            // 
            // Phone1
            // 
            this.Phone1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone1.HeaderText = "Phone1";
            this.Phone1.Name = "Phone1";
            this.Phone1.ReadOnly = true;
            this.Phone1.Width = 68;
            // 
            // Phone2
            // 
            this.Phone2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone2.HeaderText = "Phone2";
            this.Phone2.Name = "Phone2";
            this.Phone2.ReadOnly = true;
            this.Phone2.Width = 68;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 56;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 77;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // AccountAmount
            // 
            this.AccountAmount.HeaderText = "AccountAmount";
            this.AccountAmount.Name = "AccountAmount";
            this.AccountAmount.ReadOnly = true;
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.ItemsPerPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(365, 25);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(79, 23);
            this.ItemsPerPageBtn.TabIndex = 6;
            this.ItemsPerPageBtn.Text = "Change Items Per PAge";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.BackColor = System.Drawing.Color.White;
            this.ItemsPerPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(300, 27);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(62, 20);
            this.ItemsPerPageTxtBox.TabIndex = 5;
            this.ItemsPerPageTxtBox.Text = "10";
            // 
            // TotalITemsTxtBox
            // 
            this.TotalITemsTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.TotalITemsTxtBox.Location = new System.Drawing.Point(472, 85);
            this.TotalITemsTxtBox.Name = "TotalITemsTxtBox";
            this.TotalITemsTxtBox.ReadOnly = true;
            this.TotalITemsTxtBox.Size = new System.Drawing.Size(95, 20);
            this.TotalITemsTxtBox.TabIndex = 61;
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(133, 31);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 58;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(235, 31);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 59;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(157, 31);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(72, 20);
            this.PageOfTotalTxtBox.TabIndex = 57;
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.BackColor = System.Drawing.Color.White;
            this.GotoPageTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(104)))), ((int)(((byte)(65)))));
            this.GotoPageTxtBox.Location = new System.Drawing.Point(8, 31);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(85, 20);
            this.GotoPageTxtBox.TabIndex = 2;
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.GoToPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(8, 5);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(85, 24);
            this.GoToPageBtn.TabIndex = 3;
            this.GoToPageBtn.Text = "GoToPage";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(297, 8);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(115, 16);
            this.ItemsPerPageLbl.TabIndex = 53;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.TotalItemsLbl.Location = new System.Drawing.Point(474, 66);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(73, 16);
            this.TotalItemsLbl.TabIndex = 54;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.TotalPagesLbl.Location = new System.Drawing.Point(170, 7);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(41, 16);
            this.TotalPagesLbl.TabIndex = 63;
            this.TotalPagesLbl.Text = "Page";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ExportToPdfBtn);
            this.panel1.Controls.Add(this.ListVendorsBtn);
            this.panel1.Controls.Add(this.TotalItemsLbl);
            this.panel1.Controls.Add(this.TotalITemsTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 112);
            this.panel1.TabIndex = 64;
            // 
            // ExportToPdfBtn
            // 
            this.ExportToPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(103)))), ((int)(((byte)(64)))));
            this.ExportToPdfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExportToPdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportToPdfBtn.FlatAppearance.BorderSize = 0;
            this.ExportToPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportToPdfBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportToPdfBtn.ForeColor = System.Drawing.Color.White;
            this.ExportToPdfBtn.Location = new System.Drawing.Point(111, 3);
            this.ExportToPdfBtn.Name = "ExportToPdfBtn";
            this.ExportToPdfBtn.Size = new System.Drawing.Size(100, 100);
            this.ExportToPdfBtn.TabIndex = 65;
            this.ExportToPdfBtn.Text = "Export As PDF File";
            this.ExportToPdfBtn.UseVisualStyleBackColor = false;
            this.ExportToPdfBtn.Click += new System.EventHandler(this.ExportToPdfBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ItemsPerPageTxtBox);
            this.panel2.Controls.Add(this.ItemsPerPageBtn);
            this.panel2.Controls.Add(this.NextPage);
            this.panel2.Controls.Add(this.ItemsPerPageLbl);
            this.panel2.Controls.Add(this.GotoPageTxtBox);
            this.panel2.Controls.Add(this.PreviousPage);
            this.panel2.Controls.Add(this.TotalPagesLbl);
            this.panel2.Controls.Add(this.GoToPageBtn);
            this.panel2.Controls.Add(this.PageOfTotalTxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 60);
            this.panel2.TabIndex = 64;
            // 
            // ListVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(574, 700);
            this.Controls.Add(this.ListVendorsDGView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ListVendors";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListVendors";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ListVendorsDGView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListVendorsBtn;
        private System.Windows.Forms.DataGridView ListVendorsDGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locationcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountAmount;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExportToPdfBtn;
    }
}