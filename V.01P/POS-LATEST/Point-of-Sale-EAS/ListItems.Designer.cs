namespace Calcium_RMS
{
    partial class ListItems
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
            this.ListItemsDgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margincol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RenderPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListItemsBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GoToPageBtn = new System.Windows.Forms.Button();
            this.TotalPagesLbl = new System.Windows.Forms.Label();
            this.GotoPageTxtBox = new System.Windows.Forms.TextBox();
            this.PageOfTotalTxtBox = new System.Windows.Forms.TextBox();
            this.NextPage = new System.Windows.Forms.Button();
            this.PreviousPage = new System.Windows.Forms.Button();
            this.TotalItemsLbl = new System.Windows.Forms.Label();
            this.TotalITemsTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageLbl = new System.Windows.Forms.Label();
            this.ItemsPerPageTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsPerPageBtn = new System.Windows.Forms.Button();
            this.RndrPointChkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColoredChkBox = new System.Windows.Forms.CheckBox();
            this.TableBorderChkBox = new System.Windows.Forms.CheckBox();
            this.ExportPdfBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsDgView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListItemsDgView
            // 
            this.ListItemsDgView.AllowUserToAddRows = false;
            this.ListItemsDgView.AllowUserToDeleteRows = false;
            this.ListItemsDgView.AllowUserToOrderColumns = true;
            this.ListItemsDgView.BackgroundColor = System.Drawing.Color.White;
            this.ListItemsDgView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListItemsDgView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ListItemsDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.Qty,
            this.AvgUnitCost,
            this.SellPrice,
            this.Margincol,
            this.TaxLevel,
            this.Type,
            this.Category,
            this.RenderPoint,
            this.Vendor,
            this.DateAdded,
            this.SalesPrice});
            this.ListItemsDgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListItemsDgView.Location = new System.Drawing.Point(0, 112);
            this.ListItemsDgView.Name = "ListItemsDgView";
            this.ListItemsDgView.ReadOnly = true;
            this.ListItemsDgView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListItemsDgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListItemsDgView.Size = new System.Drawing.Size(696, 588);
            this.ListItemsDgView.TabIndex = 22;
            this.ListItemsDgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListItemsDgView_CellDoubleClick);
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle1;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // AvgUnitCost
            // 
            this.AvgUnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AvgUnitCost.HeaderText = "AvgUnitCost";
            this.AvgUnitCost.Name = "AvgUnitCost";
            this.AvgUnitCost.ReadOnly = true;
            this.AvgUnitCost.Width = 92;
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SellPrice.HeaderText = "SellPrice";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            this.SellPrice.Width = 71;
            // 
            // Margincol
            // 
            this.Margincol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Margincol.HeaderText = "Margin%";
            this.Margincol.Name = "Margincol";
            this.Margincol.ReadOnly = true;
            this.Margincol.Width = 75;
            // 
            // TaxLevel
            // 
            this.TaxLevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TaxLevel.HeaderText = "TaxLevel";
            this.TaxLevel.Name = "TaxLevel";
            this.TaxLevel.ReadOnly = true;
            this.TaxLevel.Width = 75;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 56;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 77;
            // 
            // RenderPoint
            // 
            this.RenderPoint.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.RenderPoint.HeaderText = "RenderPoint";
            this.RenderPoint.Name = "RenderPoint";
            this.RenderPoint.ReadOnly = true;
            this.RenderPoint.Width = 91;
            // 
            // Vendor
            // 
            this.Vendor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Vendor.HeaderText = "Vendor";
            this.Vendor.Name = "Vendor";
            this.Vendor.ReadOnly = true;
            this.Vendor.Width = 66;
            // 
            // DateAdded
            // 
            this.DateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DateAdded.HeaderText = "DateAdded";
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            this.DateAdded.Width = 86;
            // 
            // SalesPrice
            // 
            this.SalesPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPrice.HeaderText = "SalesPrice";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            this.SalesPrice.Visible = false;
            // 
            // ListItemsBtn
            // 
            this.ListItemsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ListItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListItemsBtn.FlatAppearance.BorderSize = 0;
            this.ListItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListItemsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListItemsBtn.ForeColor = System.Drawing.Color.White;
            this.ListItemsBtn.Location = new System.Drawing.Point(12, 4);
            this.ListItemsBtn.Name = "ListItemsBtn";
            this.ListItemsBtn.Size = new System.Drawing.Size(100, 100);
            this.ListItemsBtn.TabIndex = 23;
            this.ListItemsBtn.Text = "Items List";
            this.ListItemsBtn.UseVisualStyleBackColor = false;
            this.ListItemsBtn.Click += new System.EventHandler(this.ListItemsBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // GoToPageBtn
            // 
            this.GoToPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.GoToPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToPageBtn.FlatAppearance.BorderSize = 0;
            this.GoToPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoToPageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToPageBtn.ForeColor = System.Drawing.Color.White;
            this.GoToPageBtn.Location = new System.Drawing.Point(471, 25);
            this.GoToPageBtn.Name = "GoToPageBtn";
            this.GoToPageBtn.Size = new System.Drawing.Size(60, 24);
            this.GoToPageBtn.TabIndex = 25;
            this.GoToPageBtn.Text = "Go";
            this.GoToPageBtn.UseVisualStyleBackColor = false;
            this.GoToPageBtn.Click += new System.EventHandler(this.GoToPageBtn_Click);
            // 
            // TotalPagesLbl
            // 
            this.TotalPagesLbl.AutoSize = true;
            this.TotalPagesLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPagesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TotalPagesLbl.Location = new System.Drawing.Point(275, 11);
            this.TotalPagesLbl.Name = "TotalPagesLbl";
            this.TotalPagesLbl.Size = new System.Drawing.Size(41, 16);
            this.TotalPagesLbl.TabIndex = 26;
            this.TotalPagesLbl.Text = "Page";
            // 
            // GotoPageTxtBox
            // 
            this.GotoPageTxtBox.Location = new System.Drawing.Point(408, 29);
            this.GotoPageTxtBox.Name = "GotoPageTxtBox";
            this.GotoPageTxtBox.Size = new System.Drawing.Size(57, 20);
            this.GotoPageTxtBox.TabIndex = 27;
            // 
            // PageOfTotalTxtBox
            // 
            this.PageOfTotalTxtBox.BackColor = System.Drawing.Color.White;
            this.PageOfTotalTxtBox.Location = new System.Drawing.Point(278, 31);
            this.PageOfTotalTxtBox.Name = "PageOfTotalTxtBox";
            this.PageOfTotalTxtBox.ReadOnly = true;
            this.PageOfTotalTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PageOfTotalTxtBox.TabIndex = 28;
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.FlatAppearance.BorderSize = 0;
            this.NextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.ForeColor = System.Drawing.Color.White;
            this.NextPage.Location = new System.Drawing.Point(382, 31);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(20, 20);
            this.NextPage.TabIndex = 29;
            this.NextPage.Text = ">";
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // PreviousPage
            // 
            this.PreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.PreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PreviousPage.FlatAppearance.BorderSize = 0;
            this.PreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPage.ForeColor = System.Drawing.Color.White;
            this.PreviousPage.Location = new System.Drawing.Point(254, 31);
            this.PreviousPage.Name = "PreviousPage";
            this.PreviousPage.Size = new System.Drawing.Size(20, 20);
            this.PreviousPage.TabIndex = 29;
            this.PreviousPage.Text = "<";
            this.PreviousPage.UseVisualStyleBackColor = false;
            this.PreviousPage.Click += new System.EventHandler(this.PreviousPage_Click);
            // 
            // TotalItemsLbl
            // 
            this.TotalItemsLbl.AutoSize = true;
            this.TotalItemsLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.TotalItemsLbl.Location = new System.Drawing.Point(121, 65);
            this.TotalItemsLbl.Name = "TotalItemsLbl";
            this.TotalItemsLbl.Size = new System.Drawing.Size(73, 16);
            this.TotalItemsLbl.TabIndex = 24;
            this.TotalItemsLbl.Text = "TotalItems";
            // 
            // TotalITemsTxtBox
            // 
            this.TotalITemsTxtBox.BackColor = System.Drawing.Color.White;
            this.TotalITemsTxtBox.Location = new System.Drawing.Point(118, 84);
            this.TotalITemsTxtBox.Name = "TotalITemsTxtBox";
            this.TotalITemsTxtBox.ReadOnly = true;
            this.TotalITemsTxtBox.Size = new System.Drawing.Size(76, 20);
            this.TotalITemsTxtBox.TabIndex = 30;
            // 
            // ItemsPerPageLbl
            // 
            this.ItemsPerPageLbl.AutoSize = true;
            this.ItemsPerPageLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsPerPageLbl.Location = new System.Drawing.Point(86, 11);
            this.ItemsPerPageLbl.Name = "ItemsPerPageLbl";
            this.ItemsPerPageLbl.Size = new System.Drawing.Size(115, 16);
            this.ItemsPerPageLbl.TabIndex = 24;
            this.ItemsPerPageLbl.Text = "# Items Per Page";
            // 
            // ItemsPerPageTxtBox
            // 
            this.ItemsPerPageTxtBox.Location = new System.Drawing.Point(89, 32);
            this.ItemsPerPageTxtBox.Name = "ItemsPerPageTxtBox";
            this.ItemsPerPageTxtBox.Size = new System.Drawing.Size(77, 20);
            this.ItemsPerPageTxtBox.TabIndex = 30;
            this.ItemsPerPageTxtBox.Text = "10";
            // 
            // ItemsPerPageBtn
            // 
            this.ItemsPerPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ItemsPerPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsPerPageBtn.FlatAppearance.BorderSize = 0;
            this.ItemsPerPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemsPerPageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsPerPageBtn.ForeColor = System.Drawing.Color.White;
            this.ItemsPerPageBtn.Location = new System.Drawing.Point(168, 30);
            this.ItemsPerPageBtn.Name = "ItemsPerPageBtn";
            this.ItemsPerPageBtn.Size = new System.Drawing.Size(75, 23);
            this.ItemsPerPageBtn.TabIndex = 31;
            this.ItemsPerPageBtn.Text = "Change";
            this.ItemsPerPageBtn.UseVisualStyleBackColor = false;
            this.ItemsPerPageBtn.Click += new System.EventHandler(this.ItemsPerPageBtn_Click);
            // 
            // RndrPointChkBox
            // 
            this.RndrPointChkBox.AutoSize = true;
            this.RndrPointChkBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RndrPointChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.RndrPointChkBox.Location = new System.Drawing.Point(118, 5);
            this.RndrPointChkBox.Name = "RndrPointChkBox";
            this.RndrPointChkBox.Size = new System.Drawing.Size(245, 20);
            this.RndrPointChkBox.TabIndex = 32;
            this.RndrPointChkBox.Text = "Show Items Reached Render Point";
            this.RndrPointChkBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ColoredChkBox);
            this.panel1.Controls.Add(this.TableBorderChkBox);
            this.panel1.Controls.Add(this.RndrPointChkBox);
            this.panel1.Controls.Add(this.ExportPdfBtn);
            this.panel1.Controls.Add(this.ListItemsBtn);
            this.panel1.Controls.Add(this.TotalItemsLbl);
            this.panel1.Controls.Add(this.TotalITemsTxtBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 112);
            this.panel1.TabIndex = 33;
            // 
            // ColoredChkBox
            // 
            this.ColoredChkBox.AutoSize = true;
            this.ColoredChkBox.Location = new System.Drawing.Point(594, 30);
            this.ColoredChkBox.Name = "ColoredChkBox";
            this.ColoredChkBox.Size = new System.Drawing.Size(63, 17);
            this.ColoredChkBox.TabIndex = 33;
            this.ColoredChkBox.Text = "Colored";
            this.ColoredChkBox.UseVisualStyleBackColor = true;
            // 
            // TableBorderChkBox
            // 
            this.TableBorderChkBox.AutoSize = true;
            this.TableBorderChkBox.Location = new System.Drawing.Point(594, 7);
            this.TableBorderChkBox.Name = "TableBorderChkBox";
            this.TableBorderChkBox.Size = new System.Drawing.Size(87, 17);
            this.TableBorderChkBox.TabIndex = 33;
            this.TableBorderChkBox.Text = "Table Border";
            this.TableBorderChkBox.UseVisualStyleBackColor = true;
            // 
            // ExportPdfBtn
            // 
            this.ExportPdfBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(74)))), ((int)(((byte)(60)))));
            this.ExportPdfBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportPdfBtn.FlatAppearance.BorderSize = 0;
            this.ExportPdfBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportPdfBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportPdfBtn.ForeColor = System.Drawing.Color.White;
            this.ExportPdfBtn.Location = new System.Drawing.Point(488, 4);
            this.ExportPdfBtn.Name = "ExportPdfBtn";
            this.ExportPdfBtn.Size = new System.Drawing.Size(100, 100);
            this.ExportPdfBtn.TabIndex = 23;
            this.ExportPdfBtn.Text = "Export As PDF File";
            this.ExportPdfBtn.UseVisualStyleBackColor = false;
            this.ExportPdfBtn.Click += new System.EventHandler(this.ExportPdfBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NextPage);
            this.panel2.Controls.Add(this.PageOfTotalTxtBox);
            this.panel2.Controls.Add(this.GotoPageTxtBox);
            this.panel2.Controls.Add(this.ItemsPerPageBtn);
            this.panel2.Controls.Add(this.PreviousPage);
            this.panel2.Controls.Add(this.GoToPageBtn);
            this.panel2.Controls.Add(this.ItemsPerPageTxtBox);
            this.panel2.Controls.Add(this.ItemsPerPageLbl);
            this.panel2.Controls.Add(this.TotalPagesLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 641);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 59);
            this.panel2.TabIndex = 34;
            // 
            // ListItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(696, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ListItemsDgView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "ListItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items List";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ListItemsDgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListItemsDgView;
        private System.Windows.Forms.Button ListItemsBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GoToPageBtn;
        private System.Windows.Forms.Label TotalPagesLbl;
        private System.Windows.Forms.TextBox GotoPageTxtBox;
        private System.Windows.Forms.TextBox PageOfTotalTxtBox;
        private System.Windows.Forms.Button NextPage;
        private System.Windows.Forms.Button PreviousPage;
        private System.Windows.Forms.Label TotalItemsLbl;
        private System.Windows.Forms.TextBox TotalITemsTxtBox;
        private System.Windows.Forms.Label ItemsPerPageLbl;
        private System.Windows.Forms.TextBox ItemsPerPageTxtBox;
        private System.Windows.Forms.Button ItemsPerPageBtn;
        private System.Windows.Forms.CheckBox RndrPointChkBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margincol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn RenderPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.Button ExportPdfBtn;
        private System.Windows.Forms.CheckBox ColoredChkBox;
        private System.Windows.Forms.CheckBox TableBorderChkBox;
        private System.Windows.Forms.Panel panel2;
    }
}