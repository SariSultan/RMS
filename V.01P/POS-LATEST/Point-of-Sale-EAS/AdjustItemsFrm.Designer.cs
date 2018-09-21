namespace Calcium_RMS
{
    partial class AdjustItemsFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.MatchLbl = new System.Windows.Forms.Label();
            this.OptionsGB = new System.Windows.Forms.GroupBox();
            this.ReferenceNumberTxtBox = new System.Windows.Forms.TextBox();
            this.ReferenceNumberLbl = new System.Windows.Forms.Label();
            this.AdjustmentDateLbl = new System.Windows.Forms.Label();
            this.AdjDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ListItemsBtn = new System.Windows.Forms.Button();
            this.AdjustDgView = new System.Windows.Forms.DataGridView();
            this.BarcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvaQtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldAvgQtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhysicalCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifferencesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiffValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerPanel = new System.Windows.Forms.Panel();
            this.XlsChkBox = new System.Windows.Forms.CheckBox();
            this.NextPage = new System.Windows.Forms.Button();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.ExportAsPdfBtn = new System.Windows.Forms.Button();
            this.SaveAndPrintBtn = new System.Windows.Forms.Button();
            this.UpperPanel.SuspendLayout();
            this.OptionsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustDgView)).BeginInit();
            this.LowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.Controls.Add(this.MatchLbl);
            this.UpperPanel.Controls.Add(this.OptionsGB);
            this.UpperPanel.Controls.Add(this.ListItemsBtn);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(825, 90);
            this.UpperPanel.TabIndex = 0;
            // 
            // MatchLbl
            // 
            this.MatchLbl.AutoSize = true;
            this.MatchLbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatchLbl.Location = new System.Drawing.Point(322, 0);
            this.MatchLbl.Name = "MatchLbl";
            this.MatchLbl.Size = new System.Drawing.Size(394, 18);
            this.MatchLbl.TabIndex = 18;
            this.MatchLbl.Text = "The Physical Count 100% Matches The Available Quantitys";
            this.MatchLbl.Visible = false;
            // 
            // OptionsGB
            // 
            this.OptionsGB.Controls.Add(this.ReferenceNumberTxtBox);
            this.OptionsGB.Controls.Add(this.ReferenceNumberLbl);
            this.OptionsGB.Controls.Add(this.AdjustmentDateLbl);
            this.OptionsGB.Controls.Add(this.AdjDatePicker);
            this.OptionsGB.Location = new System.Drawing.Point(168, 12);
            this.OptionsGB.Name = "OptionsGB";
            this.OptionsGB.Size = new System.Drawing.Size(628, 72);
            this.OptionsGB.TabIndex = 17;
            this.OptionsGB.TabStop = false;
            this.OptionsGB.Text = "Adjustment Information";
            // 
            // ReferenceNumberTxtBox
            // 
            this.ReferenceNumberTxtBox.Enabled = false;
            this.ReferenceNumberTxtBox.Location = new System.Drawing.Point(157, 41);
            this.ReferenceNumberTxtBox.Name = "ReferenceNumberTxtBox";
            this.ReferenceNumberTxtBox.Size = new System.Drawing.Size(96, 20);
            this.ReferenceNumberTxtBox.TabIndex = 2;
            // 
            // ReferenceNumberLbl
            // 
            this.ReferenceNumberLbl.AutoSize = true;
            this.ReferenceNumberLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.ReferenceNumberLbl.Location = new System.Drawing.Point(10, 40);
            this.ReferenceNumberLbl.Name = "ReferenceNumberLbl";
            this.ReferenceNumberLbl.Size = new System.Drawing.Size(140, 19);
            this.ReferenceNumberLbl.TabIndex = 1;
            this.ReferenceNumberLbl.Text = "Reference Number";
            // 
            // AdjustmentDateLbl
            // 
            this.AdjustmentDateLbl.AutoSize = true;
            this.AdjustmentDateLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdjustmentDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AdjustmentDateLbl.Location = new System.Drawing.Point(10, 16);
            this.AdjustmentDateLbl.Name = "AdjustmentDateLbl";
            this.AdjustmentDateLbl.Size = new System.Drawing.Size(128, 19);
            this.AdjustmentDateLbl.TabIndex = 1;
            this.AdjustmentDateLbl.Text = "Adjustment Date";
            // 
            // AdjDatePicker
            // 
            this.AdjDatePicker.Enabled = false;
            this.AdjDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AdjDatePicker.Location = new System.Drawing.Point(157, 15);
            this.AdjDatePicker.Name = "AdjDatePicker";
            this.AdjDatePicker.Size = new System.Drawing.Size(96, 20);
            this.AdjDatePicker.TabIndex = 0;
            // 
            // ListItemsBtn
            // 
            this.ListItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.ListItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ListItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListItemsBtn.FlatAppearance.BorderSize = 0;
            this.ListItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListItemsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemsBtn.ForeColor = System.Drawing.Color.White;
            this.ListItemsBtn.Location = new System.Drawing.Point(12, 12);
            this.ListItemsBtn.Name = "ListItemsBtn";
            this.ListItemsBtn.Size = new System.Drawing.Size(150, 30);
            this.ListItemsBtn.TabIndex = 16;
            this.ListItemsBtn.Text = "List Items";
            this.ListItemsBtn.UseVisualStyleBackColor = false;
            this.ListItemsBtn.Click += new System.EventHandler(this.ListItemsBtn_Click);
            // 
            // AdjustDgView
            // 
            this.AdjustDgView.AllowUserToAddRows = false;
            this.AdjustDgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AdjustDgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AdjustDgView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AdjustDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdjustDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarcodeColumn,
            this.DescriptionColumn,
            this.AvgCostColumn,
            this.AvaQtyColumn,
            this.OldAvgQtyCol,
            this.PhysicalCountColumn,
            this.DifferencesColumn,
            this.DiffValueColumn});
            this.AdjustDgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdjustDgView.Location = new System.Drawing.Point(0, 90);
            this.AdjustDgView.Name = "AdjustDgView";
            this.AdjustDgView.Size = new System.Drawing.Size(825, 368);
            this.AdjustDgView.TabIndex = 1;
            this.AdjustDgView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdjustDgView_CellValueChanged);
            // 
            // BarcodeColumn
            // 
            this.BarcodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BarcodeColumn.HeaderText = "Barcode";
            this.BarcodeColumn.Name = "BarcodeColumn";
            this.BarcodeColumn.ReadOnly = true;
            this.BarcodeColumn.Width = 71;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // AvgCostColumn
            // 
            this.AvgCostColumn.HeaderText = "Avg Cost";
            this.AvgCostColumn.Name = "AvgCostColumn";
            this.AvgCostColumn.ReadOnly = true;
            // 
            // AvaQtyColumn
            // 
            this.AvaQtyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AvaQtyColumn.HeaderText = "Available Qty";
            this.AvaQtyColumn.Name = "AvaQtyColumn";
            this.AvaQtyColumn.ReadOnly = true;
            this.AvaQtyColumn.Width = 88;
            // 
            // OldAvgQtyCol
            // 
            this.OldAvgQtyCol.HeaderText = "Old Ava Qty";
            this.OldAvgQtyCol.Name = "OldAvgQtyCol";
            this.OldAvgQtyCol.ReadOnly = true;
            this.OldAvgQtyCol.Visible = false;
            // 
            // PhysicalCountColumn
            // 
            this.PhysicalCountColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.PhysicalCountColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PhysicalCountColumn.HeaderText = "Physical Count";
            this.PhysicalCountColumn.Name = "PhysicalCountColumn";
            this.PhysicalCountColumn.Width = 94;
            // 
            // DifferencesColumn
            // 
            this.DifferencesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.DifferencesColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DifferencesColumn.HeaderText = "Differences";
            this.DifferencesColumn.Name = "DifferencesColumn";
            this.DifferencesColumn.ReadOnly = true;
            this.DifferencesColumn.Width = 87;
            // 
            // DiffValueColumn
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.DiffValueColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiffValueColumn.HeaderText = "Difference Value JOD";
            this.DiffValueColumn.Name = "DiffValueColumn";
            this.DiffValueColumn.ReadOnly = true;
            // 
            // LowerPanel
            // 
            this.LowerPanel.Controls.Add(this.XlsChkBox);
            this.LowerPanel.Controls.Add(this.NextPage);
            this.LowerPanel.Controls.Add(this.PageOfTotalTxtBox);
            this.LowerPanel.Controls.Add(this.GotoPageTxtBox);
            this.LowerPanel.Controls.Add(this.ItemsPerPageBtn);
            this.LowerPanel.Controls.Add(this.PreviousPage);
            this.LowerPanel.Controls.Add(this.GoToPageBtn);
            this.LowerPanel.Controls.Add(this.ItemsPerPageTxtBox);
            this.LowerPanel.Controls.Add(this.ItemsPerPageLbl);
            this.LowerPanel.Controls.Add(this.TotalPagesLbl);
            this.LowerPanel.Controls.Add(this.ExportAsPdfBtn);
            this.LowerPanel.Controls.Add(this.SaveAndPrintBtn);
            this.LowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerPanel.Location = new System.Drawing.Point(0, 458);
            this.LowerPanel.Name = "LowerPanel";
            this.LowerPanel.Size = new System.Drawing.Size(825, 64);
            this.LowerPanel.TabIndex = 2;
            // 
            // XlsChkBox
            // 
            this.XlsChkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XlsChkBox.AutoSize = true;
            this.XlsChkBox.Location = new System.Drawing.Point(663, 6);
            this.XlsChkBox.Name = "XlsChkBox";
            this.XlsChkBox.Size = new System.Drawing.Size(100, 17);
            this.XlsChkBox.TabIndex = 41;
            this.XlsChkBox.Text = "Export as Excel";
            this.XlsChkBox.UseVisualStyleBackColor = true;
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
            // ExportAsPdfBtn
            // 
            this.ExportAsPdfBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportAsPdfBtn.BackColor = System.Drawing.Color.Silver;
            this.ExportAsPdfBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ExportAsPdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportAsPdfBtn.FlatAppearance.BorderSize = 0;
            this.ExportAsPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportAsPdfBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportAsPdfBtn.ForeColor = System.Drawing.Color.Black;
            this.ExportAsPdfBtn.Location = new System.Drawing.Point(507, 25);
            this.ExportAsPdfBtn.Name = "ExportAsPdfBtn";
            this.ExportAsPdfBtn.Size = new System.Drawing.Size(150, 30);
            this.ExportAsPdfBtn.TabIndex = 16;
            this.ExportAsPdfBtn.Text = "Export as PDF";
            this.ExportAsPdfBtn.UseVisualStyleBackColor = false;
            // 
            // SaveAndPrintBtn
            // 
            this.SaveAndPrintBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAndPrintBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.SaveAndPrintBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveAndPrintBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAndPrintBtn.FlatAppearance.BorderSize = 0;
            this.SaveAndPrintBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndPrintBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndPrintBtn.ForeColor = System.Drawing.Color.White;
            this.SaveAndPrintBtn.Location = new System.Drawing.Point(663, 25);
            this.SaveAndPrintBtn.Name = "SaveAndPrintBtn";
            this.SaveAndPrintBtn.Size = new System.Drawing.Size(150, 30);
            this.SaveAndPrintBtn.TabIndex = 16;
            this.SaveAndPrintBtn.Text = "Save";
            this.SaveAndPrintBtn.UseVisualStyleBackColor = false;
            this.SaveAndPrintBtn.Click += new System.EventHandler(this.SaveAndPrintBtn_Click);
            // 
            // AdjustItemsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 522);
            this.Controls.Add(this.AdjustDgView);
            this.Controls.Add(this.UpperPanel);
            this.Controls.Add(this.LowerPanel);
            this.Name = "AdjustItemsFrm";
            this.Text = "Adjust Items Qty";
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.OptionsGB.ResumeLayout(false);
            this.OptionsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdjustDgView)).EndInit();
            this.LowerPanel.ResumeLayout(false);
            this.LowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.DataGridView AdjustDgView;
        private System.Windows.Forms.Panel LowerPanel;
        private System.Windows.Forms.Button ListItemsBtn;
        private System.Windows.Forms.Button SaveAndPrintBtn;
        private System.Windows.Forms.GroupBox OptionsGB;
        private System.Windows.Forms.Label AdjustmentDateLbl;
        private System.Windows.Forms.DateTimePicker AdjDatePicker;
        private System.Windows.Forms.Label ReferenceNumberLbl;
        private System.Windows.Forms.TextBox ReferenceNumberTxtBox;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.Button ExportAsPdfBtn;
        private System.Windows.Forms.CheckBox XlsChkBox;
        private System.Windows.Forms.Label MatchLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvaQtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldAvgQtyCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferencesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiffValueColumn;
    }
}