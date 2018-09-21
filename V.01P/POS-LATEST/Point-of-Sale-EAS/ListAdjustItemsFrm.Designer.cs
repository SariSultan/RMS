namespace Calcium_RMS
{
    partial class ListAdjustItemsFrm
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
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.RefNumberTxtBox = new System.Windows.Forms.TextBox();
            this.RefNumberLbl = new System.Windows.Forms.Label();
            this.ListAdjustsBtn = new System.Windows.Forms.Button();
            this.ExportAsBtn = new System.Windows.Forms.Button();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.ListAdjustDgView = new System.Windows.Forms.DataGridView();
            this.RefNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedByCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDiffValCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperPanel.SuspendLayout();
            this.LowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAdjustDgView)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.RefNumberTxtBox);
            this.UpperPanel.Controls.Add(this.RefNumberLbl);
            this.UpperPanel.Controls.Add(this.ListAdjustsBtn);
            this.UpperPanel.Controls.Add(this.ExportAsBtn);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(844, 70);
            this.UpperPanel.TabIndex = 1;
            // 
            // RefNumberTxtBox
            // 
            this.RefNumberTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefNumberTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.RefNumberTxtBox.Enabled = false;
            this.RefNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefNumberTxtBox.Location = new System.Drawing.Point(416, 39);
            this.RefNumberTxtBox.Name = "RefNumberTxtBox";
            this.RefNumberTxtBox.Size = new System.Drawing.Size(125, 27);
            this.RefNumberTxtBox.TabIndex = 36;
            // 
            // RefNumberLbl
            // 
            this.RefNumberLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefNumberLbl.AutoSize = true;
            this.RefNumberLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.RefNumberLbl.Location = new System.Drawing.Point(413, 18);
            this.RefNumberLbl.Name = "RefNumberLbl";
            this.RefNumberLbl.Size = new System.Drawing.Size(129, 16);
            this.RefNumberLbl.TabIndex = 35;
            this.RefNumberLbl.Text = "Reference Number";
            // 
            // ListAdjustsBtn
            // 
            this.ListAdjustsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.ListAdjustsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ListAdjustsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListAdjustsBtn.FlatAppearance.BorderSize = 0;
            this.ListAdjustsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAdjustsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListAdjustsBtn.ForeColor = System.Drawing.Color.White;
            this.ListAdjustsBtn.Location = new System.Drawing.Point(12, 12);
            this.ListAdjustsBtn.Name = "ListAdjustsBtn";
            this.ListAdjustsBtn.Size = new System.Drawing.Size(150, 30);
            this.ListAdjustsBtn.TabIndex = 16;
            this.ListAdjustsBtn.Text = "List Adjusts";
            this.ListAdjustsBtn.UseVisualStyleBackColor = false;
            this.ListAdjustsBtn.Click += new System.EventHandler(this.ListAdjustsBtn_Click);
            // 
            // ExportAsBtn
            // 
            this.ExportAsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAsBtn.BackColor = System.Drawing.Color.Silver;
            this.ExportAsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExportAsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportAsBtn.FlatAppearance.BorderSize = 0;
            this.ExportAsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportAsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportAsBtn.ForeColor = System.Drawing.Color.Black;
            this.ExportAsBtn.Location = new System.Drawing.Point(547, 37);
            this.ExportAsBtn.Name = "ExportAsBtn";
            this.ExportAsBtn.Size = new System.Drawing.Size(150, 30);
            this.ExportAsBtn.TabIndex = 16;
            this.ExportAsBtn.Text = "Export";
            this.ExportAsBtn.UseVisualStyleBackColor = false;
            this.ExportAsBtn.Click += new System.EventHandler(this.ExportAsBtn_Click);
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.NextPage);
            this.LowerPanel.Controls.Add(this.PageOfTotalTxtBox);
            this.LowerPanel.Controls.Add(this.GotoPageTxtBox);
            this.LowerPanel.Controls.Add(this.ItemsPerPageBtn);
            this.LowerPanel.Controls.Add(this.PreviousPage);
            this.LowerPanel.Controls.Add(this.GoToPageBtn);
            this.LowerPanel.Controls.Add(this.ItemsPerPageTxtBox);
            this.LowerPanel.Controls.Add(this.ItemsPerPageLbl);
            this.LowerPanel.Controls.Add(this.TotalPagesLbl);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerPanel.Location = new System.Drawing.Point(0, 475);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(844, 60);
            this.LowerPanel.TabIndex = 3;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(310, 30);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 37;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(206, 30);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PageOfTotalTxtBox.TabIndex = 36;
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.Location = new System.Drawing.Point(336, 28);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(57, 20);
            this.GotoPageTxtBox.TabIndex = 35;
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsPerPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(96, 29);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(75, 23);
            this.ItemsPerPageBtn.TabIndex = 40;
            this.ItemsPerPageBtn.Text = "Change";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(182, 30);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 38;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.GoToPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(399, 24);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(60, 24);
            this.GoToPageBtn.TabIndex = 33;
            this.GoToPageBtn.Text = "Go";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(17, 31);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(77, 20);
            this.ItemsPerPageTxtBox.TabIndex = 39;
            this.ItemsPerPageTxtBox.Text = "10";
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(14, 10);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(115, 16);
            this.ItemsPerPageLbl.TabIndex = 32;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TotalPagesLbl.Location = new System.Drawing.Point(233, 11);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(41, 16);
            this.TotalPagesLbl.TabIndex = 34;
            this.TotalPagesLbl.Text = "Page";
            // 
            // ListAdjustDgView
            // 
            this.ListAdjustDgView.AllowUserToAddRows = false;
            this.ListAdjustDgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.ListAdjustDgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListAdjustDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAdjustDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefNumCol,
            this.AddedByCol,
            this.DateCol,
            this.TotalDiffValCol});
            this.ListAdjustDgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListAdjustDgView.Location = new System.Drawing.Point(0, 70);
            this.ListAdjustDgView.Name = "ListAdjustDgView";
            this.ListAdjustDgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListAdjustDgView.Size = new System.Drawing.Size(844, 405);
            this.ListAdjustDgView.TabIndex = 4;
            this.ListAdjustDgView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ListAdjustDgView_CellMouseDoubleClick);
            this.ListAdjustDgView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListAdjustDgView_RowEnter);
            // 
            // RefNumCol
            // 
            this.RefNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.RefNumCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.RefNumCol.HeaderText = "Reference Number";
            this.RefNumCol.Name = "RefNumCol";
            this.RefNumCol.ReadOnly = true;
            this.RefNumCol.Width = 112;
            // 
            // AddedByCol
            // 
            this.AddedByCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddedByCol.HeaderText = "Added By";
            this.AddedByCol.Name = "AddedByCol";
            this.AddedByCol.ReadOnly = true;
            this.AddedByCol.Width = 72;
            // 
            // DateCol
            // 
            this.DateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Width = 55;
            // 
            // TotalDiffValCol
            // 
            this.TotalDiffValCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalDiffValCol.HeaderText = "Total Difference Value (JOD)";
            this.TotalDiffValCol.Name = "TotalDiffValCol";
            this.TotalDiffValCol.ReadOnly = true;
            // 
            // ListAdjustItemsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 535);
            this.Controls.Add(this.ListAdjustDgView);
            this.Controls.Add(this.LowerPanel);
            this.Controls.Add(this.UpperPanel);
            this.Name = "ListAdjustItemsFrm";
            this.Text = "List Adjust Items";
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.LowerPanel.ResumeLayout(false);
            this.LowerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAdjustDgView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button ListAdjustsBtn;
        private System.Windows.Forms.TextBox RefNumberTxtBox;
        private System.Windows.Forms.Label RefNumberLbl;
        private System.Windows.Forms.Button ExportAsBtn;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.DataGridView ListAdjustDgView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedByCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDiffValCol;
    }
}