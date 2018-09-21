namespace Calcium_RMS
{
    partial class ReportsFrm
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
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("List Customers Report");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("List Customers Balances");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Customer Balance Statement");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Customers Reports", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("List Vendors");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("List Vendors Balances");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Vendor Balance Statement");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Vendors Reports", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("End of Period Report");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("End Of Period", new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Fast Move Item");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Slow Move Items");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Highest Revenues Items");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Lowest Revenues Items");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Revenues Comparison");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Statistics", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Sales and Purchase");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Tax Reports", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Physical Inventory Worksheet");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Inventory Valuation Summary");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Item Status Report");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Adjust Inventory Summary");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Inventory", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.DateLbl = new System.Windows.Forms.Label();
            this.DateToLbl = new System.Windows.Forms.Label();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.LayoutOptions = new System.Windows.Forms.GroupBox();
            this.RTLChkBox = new System.Windows.Forms.CheckBox();
            this.ColorsChkBox = new System.Windows.Forms.CheckBox();
            this.TableBorderChkBox = new System.Windows.Forms.CheckBox();
            this.ThermalPrinterChkBox = new System.Windows.Forms.CheckBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.DateFrompicker = new System.Windows.Forms.DateTimePicker();
            this.PrintToThermalBtn = new System.Windows.Forms.Button();
            this.SaveAsBtn = new System.Windows.Forms.Button();
            this.DateToPicker = new System.Windows.Forms.DateTimePicker();
            this.InventoryOptionsGB = new System.Windows.Forms.GroupBox();
            this.RefNumTxtBox = new System.Windows.Forms.TextBox();
            this.ReferenceNumLbl = new System.Windows.Forms.Label();
            this.ItemNameLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerOptionsGB = new System.Windows.Forms.GroupBox();
            this.Phone1ComboBox = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.CustomerNameComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerNamechkBox = new System.Windows.Forms.CheckBox();
            this.CustomerPhoneLbl = new System.Windows.Forms.Label();
            this.CustomerNameLbl = new System.Windows.Forms.Label();
            this.TellerGB = new System.Windows.Forms.GroupBox();
            this.AllTellersChkBox = new System.Windows.Forms.CheckBox();
            this.TellerNameComboBox = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatisticsGB = new System.Windows.Forms.GroupBox();
            this.ComparisonLbl = new System.Windows.Forms.Label();
            this.RevenuesComparisonComboBox = new System.Windows.Forms.ComboBox();
            this.NumberOfItemsTxtBox = new System.Windows.Forms.TextBox();
            this.NumberOfItemsLbl = new System.Windows.Forms.Label();
            this.VendorsOptionsGB = new System.Windows.Forms.GroupBox();
            this.VendorNameComboBox = new System.Windows.Forms.ComboBox();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendorNameLbl = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.usersTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.UsersTableAdapter();
            this.customerTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.CustomerTableAdapter();
            this.vendorsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.VendorsTableAdapter();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            this.LayoutOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.InventoryOptionsGB.SuspendLayout();
            this.CustomerOptionsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.TellerGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.StatisticsGB.SuspendLayout();
            this.VendorsOptionsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.treeView1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(57)))), ((int)(((byte)(140)))));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode24.Name = "ListCustomersRepBtn";
            treeNode24.Text = "List Customers Report";
            treeNode25.Name = "ListCustBalanceBtn";
            treeNode25.Text = "List Customers Balances";
            treeNode26.Name = "CustomerBalanceStatementBtn";
            treeNode26.Text = "Customer Balance Statement";
            treeNode27.Name = "CustomersRoot";
            treeNode27.Text = "Customers Reports";
            treeNode28.Name = "ListVendorsBtn";
            treeNode28.Text = "List Vendors";
            treeNode29.Name = "ListVendorsBalancesBtn";
            treeNode29.Text = "List Vendors Balances";
            treeNode30.Name = "VendorBalanceStatementBtn";
            treeNode30.Text = "Vendor Balance Statement";
            treeNode31.Name = "VendorsRoot";
            treeNode31.Text = "Vendors Reports";
            treeNode32.Name = "EndofPeriodReportsBtn";
            treeNode32.Text = "End of Period Report";
            treeNode33.Name = "EndofPeriodReportsRoot";
            treeNode33.Text = "End Of Period";
            treeNode34.Name = "FastMoveItemBtn";
            treeNode34.Text = "Fast Move Item";
            treeNode35.Name = "SlowMoveItemsBtn";
            treeNode35.Text = "Slow Move Items";
            treeNode36.Name = "HighestRevenuesBtn";
            treeNode36.Text = "Highest Revenues Items";
            treeNode37.Name = "LowestRevenuesBtn";
            treeNode37.Text = "Lowest Revenues Items";
            treeNode38.Name = "RevenuesComparisonBtn";
            treeNode38.Text = "Revenues Comparison";
            treeNode39.Name = "StatisticsRoot";
            treeNode39.Text = "Statistics";
            treeNode40.Name = "SalesPurchaseTaxBtn";
            treeNode40.Text = "Sales and Purchase";
            treeNode41.Name = "TaxationRoot";
            treeNode41.Text = "Tax Reports";
            treeNode42.Name = "PhysicalInvWorksheetBtn";
            treeNode42.Text = "Physical Inventory Worksheet";
            treeNode43.Name = "InvValSummaryBtn";
            treeNode43.Text = "Inventory Valuation Summary";
            treeNode44.Name = "ItemStatusRepBtn";
            treeNode44.Text = "Item Status Report";
            treeNode45.Name = "AdjustInvBtn";
            treeNode45.Text = "Adjust Inventory Summary";
            treeNode46.Name = "InventoryRoot";
            treeNode46.Text = "Inventory";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode31,
            treeNode33,
            treeNode39,
            treeNode41,
            treeNode46});
            this.treeView1.Size = new System.Drawing.Size(246, 642);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.Controls.Add(this.DateLbl);
            this.HeaderPanel.Controls.Add(this.DateToLbl);
            this.HeaderPanel.Controls.Add(this.MinimizePB);
            this.HeaderPanel.Controls.Add(this.LayoutOptions);
            this.HeaderPanel.Controls.Add(this.ExitPB);
            this.HeaderPanel.Controls.Add(this.ViewBtn);
            this.HeaderPanel.Controls.Add(this.DateFrompicker);
            this.HeaderPanel.Controls.Add(this.PrintToThermalBtn);
            this.HeaderPanel.Controls.Add(this.SaveAsBtn);
            this.HeaderPanel.Controls.Add(this.DateToPicker);
            this.HeaderPanel.Controls.Add(this.CustomerOptionsGB);
            this.HeaderPanel.Controls.Add(this.TellerGB);
            this.HeaderPanel.Controls.Add(this.StatisticsGB);
            this.HeaderPanel.Controls.Add(this.VendorsOptionsGB);
            this.HeaderPanel.Controls.Add(this.InventoryOptionsGB);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(246, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(738, 167);
            this.HeaderPanel.TabIndex = 1;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.DateLbl.Location = new System.Drawing.Point(504, 7);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(37, 14);
            this.DateLbl.TabIndex = 58;
            this.DateLbl.Text = "From";
            // 
            // DateToLbl
            // 
            this.DateToLbl.AutoSize = true;
            this.DateToLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.DateToLbl.Location = new System.Drawing.Point(630, 7);
            this.DateToLbl.Name = "DateToLbl";
            this.DateToLbl.Size = new System.Drawing.Size(22, 14);
            this.DateToLbl.TabIndex = 60;
            this.DateToLbl.Text = "To";
            // 
            // MinimizePB
            // 
            this.MinimizePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizePB.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePB.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.MinimizePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Location = new System.Drawing.Point(690, 4);
            this.MinimizePB.Name = "MinimizePB";
            this.MinimizePB.Size = new System.Drawing.Size(15, 15);
            this.MinimizePB.TabIndex = 116;
            this.MinimizePB.TabStop = false;
            this.MinimizePB.Visible = false;
            // 
            // LayoutOptions
            // 
            this.LayoutOptions.Controls.Add(this.RTLChkBox);
            this.LayoutOptions.Controls.Add(this.ColorsChkBox);
            this.LayoutOptions.Controls.Add(this.TableBorderChkBox);
            this.LayoutOptions.Controls.Add(this.ThermalPrinterChkBox);
            this.LayoutOptions.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.LayoutOptions.Location = new System.Drawing.Point(262, 7);
            this.LayoutOptions.Name = "LayoutOptions";
            this.LayoutOptions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LayoutOptions.Size = new System.Drawing.Size(198, 152);
            this.LayoutOptions.TabIndex = 77;
            this.LayoutOptions.TabStop = false;
            this.LayoutOptions.Text = "Layout Options";
            // 
            // RTLChkBox
            // 
            this.RTLChkBox.AutoSize = true;
            this.RTLChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTLChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.RTLChkBox.Location = new System.Drawing.Point(19, 117);
            this.RTLChkBox.Name = "RTLChkBox";
            this.RTLChkBox.Size = new System.Drawing.Size(99, 18);
            this.RTLChkBox.TabIndex = 78;
            this.RTLChkBox.Text = "Right To Left";
            this.RTLChkBox.UseVisualStyleBackColor = true;
            this.RTLChkBox.CheckedChanged += new System.EventHandler(this.RTLChkBox_CheckedChanged);
            // 
            // ColorsChkBox
            // 
            this.ColorsChkBox.AutoSize = true;
            this.ColorsChkBox.Checked = true;
            this.ColorsChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ColorsChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorsChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.ColorsChkBox.Location = new System.Drawing.Point(19, 86);
            this.ColorsChkBox.Name = "ColorsChkBox";
            this.ColorsChkBox.Size = new System.Drawing.Size(67, 18);
            this.ColorsChkBox.TabIndex = 67;
            this.ColorsChkBox.Text = "Colored";
            this.ColorsChkBox.UseVisualStyleBackColor = true;
            // 
            // TableBorderChkBox
            // 
            this.TableBorderChkBox.AutoSize = true;
            this.TableBorderChkBox.Checked = true;
            this.TableBorderChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TableBorderChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableBorderChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.TableBorderChkBox.Location = new System.Drawing.Point(19, 55);
            this.TableBorderChkBox.Name = "TableBorderChkBox";
            this.TableBorderChkBox.Size = new System.Drawing.Size(96, 18);
            this.TableBorderChkBox.TabIndex = 67;
            this.TableBorderChkBox.Text = "Table Border";
            this.TableBorderChkBox.UseVisualStyleBackColor = true;
            // 
            // ThermalPrinterChkBox
            // 
            this.ThermalPrinterChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThermalPrinterChkBox.Location = new System.Drawing.Point(19, 20);
            this.ThermalPrinterChkBox.Name = "ThermalPrinterChkBox";
            this.ThermalPrinterChkBox.Size = new System.Drawing.Size(115, 22);
            this.ThermalPrinterChkBox.TabIndex = 79;
            this.ThermalPrinterChkBox.Text = "Thermal Printer";
            // 
            // ExitPB
            // 
            this.ExitPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitPB.BackColor = System.Drawing.Color.Transparent;
            this.ExitPB.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon;
            this.ExitPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPB.Location = new System.Drawing.Point(711, 4);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(15, 15);
            this.ExitPB.TabIndex = 115;
            this.ExitPB.TabStop = false;
            this.ExitPB.Visible = false;
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.ViewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewBtn.FlatAppearance.BorderSize = 0;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewBtn.ForeColor = System.Drawing.Color.White;
            this.ViewBtn.Location = new System.Drawing.Point(466, 123);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(232, 24);
            this.ViewBtn.TabIndex = 69;
            this.ViewBtn.Text = "View Report";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DateFrompicker
            // 
            this.DateFrompicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateFrompicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrompicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFrompicker.Location = new System.Drawing.Point(466, 27);
            this.DateFrompicker.Name = "DateFrompicker";
            this.DateFrompicker.Size = new System.Drawing.Size(113, 21);
            this.DateFrompicker.TabIndex = 59;
            // 
            // PrintToThermalBtn
            // 
            this.PrintToThermalBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.PrintToThermalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintToThermalBtn.FlatAppearance.BorderSize = 0;
            this.PrintToThermalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintToThermalBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintToThermalBtn.ForeColor = System.Drawing.Color.White;
            this.PrintToThermalBtn.Location = new System.Drawing.Point(466, 93);
            this.PrintToThermalBtn.Name = "PrintToThermalBtn";
            this.PrintToThermalBtn.Size = new System.Drawing.Size(232, 24);
            this.PrintToThermalBtn.TabIndex = 69;
            this.PrintToThermalBtn.Text = "Print To Thermal";
            this.PrintToThermalBtn.UseVisualStyleBackColor = false;
            this.PrintToThermalBtn.Click += new System.EventHandler(this.PrintToThermalBtn_Click);
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.SaveAsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAsBtn.FlatAppearance.BorderSize = 0;
            this.SaveAsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsBtn.ForeColor = System.Drawing.Color.White;
            this.SaveAsBtn.Location = new System.Drawing.Point(466, 63);
            this.SaveAsBtn.Name = "SaveAsBtn";
            this.SaveAsBtn.Size = new System.Drawing.Size(232, 24);
            this.SaveAsBtn.TabIndex = 69;
            this.SaveAsBtn.Text = "Save As";
            this.SaveAsBtn.UseVisualStyleBackColor = false;
            this.SaveAsBtn.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // DateToPicker
            // 
            this.DateToPicker.CalendarMonthBackground = System.Drawing.Color.Lavender;
            this.DateToPicker.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateToPicker.Location = new System.Drawing.Point(585, 27);
            this.DateToPicker.Name = "DateToPicker";
            this.DateToPicker.Size = new System.Drawing.Size(113, 21);
            this.DateToPicker.TabIndex = 61;
            // 
            // InventoryOptionsGB
            // 
            this.InventoryOptionsGB.Controls.Add(this.RefNumTxtBox);
            this.InventoryOptionsGB.Controls.Add(this.ReferenceNumLbl);
            this.InventoryOptionsGB.Controls.Add(this.ItemNameLbl);
            this.InventoryOptionsGB.Controls.Add(this.ItemDescriptionComboBox);
            this.InventoryOptionsGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryOptionsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.InventoryOptionsGB.Location = new System.Drawing.Point(26, 5);
            this.InventoryOptionsGB.Name = "InventoryOptionsGB";
            this.InventoryOptionsGB.Size = new System.Drawing.Size(215, 152);
            this.InventoryOptionsGB.TabIndex = 76;
            this.InventoryOptionsGB.TabStop = false;
            this.InventoryOptionsGB.Text = "Inventory Options";
            // 
            // RefNumTxtBox
            // 
            this.RefNumTxtBox.Location = new System.Drawing.Point(14, 107);
            this.RefNumTxtBox.Name = "RefNumTxtBox";
            this.RefNumTxtBox.Size = new System.Drawing.Size(191, 22);
            this.RefNumTxtBox.TabIndex = 2;
            // 
            // ReferenceNumLbl
            // 
            this.ReferenceNumLbl.AutoSize = true;
            this.ReferenceNumLbl.Location = new System.Drawing.Point(14, 83);
            this.ReferenceNumLbl.Name = "ReferenceNumLbl";
            this.ReferenceNumLbl.Size = new System.Drawing.Size(119, 14);
            this.ReferenceNumLbl.TabIndex = 1;
            this.ReferenceNumLbl.Text = "Reference Number";
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.AutoSize = true;
            this.ItemNameLbl.Location = new System.Drawing.Point(14, 27);
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(73, 14);
            this.ItemNameLbl.TabIndex = 1;
            this.ItemNameLbl.Text = "Item Name";
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(14, 51);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(194, 22);
            this.ItemDescriptionComboBox.TabIndex = 0;
            // 
            // CustomerOptionsGB
            // 
            this.CustomerOptionsGB.Controls.Add(this.Phone1ComboBox);
            this.CustomerOptionsGB.Controls.Add(this.CustomerNameComboBox);
            this.CustomerOptionsGB.Controls.Add(this.CustomerNamechkBox);
            this.CustomerOptionsGB.Controls.Add(this.CustomerPhoneLbl);
            this.CustomerOptionsGB.Controls.Add(this.CustomerNameLbl);
            this.CustomerOptionsGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerOptionsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.CustomerOptionsGB.Location = new System.Drawing.Point(26, 7);
            this.CustomerOptionsGB.Name = "CustomerOptionsGB";
            this.CustomerOptionsGB.Size = new System.Drawing.Size(215, 152);
            this.CustomerOptionsGB.TabIndex = 75;
            this.CustomerOptionsGB.TabStop = false;
            this.CustomerOptionsGB.Text = "Customer Options";
            // 
            // Phone1ComboBox
            // 
            this.Phone1ComboBox.DataSource = this.customerBindingSource;
            this.Phone1ComboBox.DisplayMember = "Phone1";
            this.Phone1ComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone1ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.Phone1ComboBox.FormattingEnabled = true;
            this.Phone1ComboBox.Location = new System.Drawing.Point(9, 40);
            this.Phone1ComboBox.Name = "Phone1ComboBox";
            this.Phone1ComboBox.Size = new System.Drawing.Size(200, 21);
            this.Phone1ComboBox.TabIndex = 71;
            this.Phone1ComboBox.ValueMember = "ID";
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
            // CustomerNameComboBox
            // 
            this.CustomerNameComboBox.DataSource = this.customerBindingSource;
            this.CustomerNameComboBox.DisplayMember = "Name";
            this.CustomerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.CustomerNameComboBox.FormattingEnabled = true;
            this.CustomerNameComboBox.Location = new System.Drawing.Point(10, 111);
            this.CustomerNameComboBox.Name = "CustomerNameComboBox";
            this.CustomerNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.CustomerNameComboBox.TabIndex = 71;
            this.CustomerNameComboBox.ValueMember = "ID";
            // 
            // CustomerNamechkBox
            // 
            this.CustomerNamechkBox.AutoSize = true;
            this.CustomerNamechkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNamechkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.CustomerNamechkBox.Location = new System.Drawing.Point(45, 67);
            this.CustomerNamechkBox.Name = "CustomerNamechkBox";
            this.CustomerNamechkBox.Size = new System.Drawing.Size(130, 18);
            this.CustomerNamechkBox.TabIndex = 73;
            this.CustomerNamechkBox.Text = "By Customer Name";
            this.CustomerNamechkBox.UseVisualStyleBackColor = true;
            this.CustomerNamechkBox.CheckedChanged += new System.EventHandler(this.CustomerNamechkBox_CheckedChanged);
            // 
            // CustomerPhoneLbl
            // 
            this.CustomerPhoneLbl.AutoSize = true;
            this.CustomerPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.CustomerPhoneLbl.Location = new System.Drawing.Point(61, 20);
            this.CustomerPhoneLbl.Name = "CustomerPhoneLbl";
            this.CustomerPhoneLbl.Size = new System.Drawing.Size(98, 14);
            this.CustomerPhoneLbl.TabIndex = 72;
            this.CustomerPhoneLbl.Text = "Customer Phone";
            // 
            // CustomerNameLbl
            // 
            this.CustomerNameLbl.AutoSize = true;
            this.CustomerNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.CustomerNameLbl.Location = new System.Drawing.Point(63, 91);
            this.CustomerNameLbl.Name = "CustomerNameLbl";
            this.CustomerNameLbl.Size = new System.Drawing.Size(94, 14);
            this.CustomerNameLbl.TabIndex = 72;
            this.CustomerNameLbl.Text = "Customer Name";
            // 
            // TellerGB
            // 
            this.TellerGB.Controls.Add(this.AllTellersChkBox);
            this.TellerGB.Controls.Add(this.TellerNameComboBox);
            this.TellerGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TellerGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.TellerGB.Location = new System.Drawing.Point(26, 7);
            this.TellerGB.Name = "TellerGB";
            this.TellerGB.Size = new System.Drawing.Size(215, 152);
            this.TellerGB.TabIndex = 74;
            this.TellerGB.TabStop = false;
            this.TellerGB.Text = "TellerOptions";
            // 
            // AllTellersChkBox
            // 
            this.AllTellersChkBox.AutoSize = true;
            this.AllTellersChkBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllTellersChkBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.AllTellersChkBox.Location = new System.Drawing.Point(59, 90);
            this.AllTellersChkBox.Name = "AllTellersChkBox";
            this.AllTellersChkBox.Size = new System.Drawing.Size(77, 18);
            this.AllTellersChkBox.TabIndex = 56;
            this.AllTellersChkBox.Text = "All Tellers";
            this.AllTellersChkBox.UseVisualStyleBackColor = true;
            this.AllTellersChkBox.CheckedChanged += new System.EventHandler(this.AllTellersChkBox_CheckedChanged);
            // 
            // TellerNameComboBox
            // 
            this.TellerNameComboBox.BackColor = System.Drawing.Color.Lavender;
            this.TellerNameComboBox.DataSource = this.usersBindingSource;
            this.TellerNameComboBox.DisplayMember = "Name";
            this.TellerNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TellerNameComboBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TellerNameComboBox.FormattingEnabled = true;
            this.TellerNameComboBox.Location = new System.Drawing.Point(17, 62);
            this.TellerNameComboBox.Name = "TellerNameComboBox";
            this.TellerNameComboBox.Size = new System.Drawing.Size(183, 21);
            this.TellerNameComboBox.TabIndex = 57;
            this.TellerNameComboBox.ValueMember = "ID";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.dBDataSet;
            // 
            // StatisticsGB
            // 
            this.StatisticsGB.Controls.Add(this.ComparisonLbl);
            this.StatisticsGB.Controls.Add(this.RevenuesComparisonComboBox);
            this.StatisticsGB.Controls.Add(this.NumberOfItemsTxtBox);
            this.StatisticsGB.Controls.Add(this.NumberOfItemsLbl);
            this.StatisticsGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.StatisticsGB.Location = new System.Drawing.Point(26, 7);
            this.StatisticsGB.Name = "StatisticsGB";
            this.StatisticsGB.Size = new System.Drawing.Size(215, 152);
            this.StatisticsGB.TabIndex = 76;
            this.StatisticsGB.TabStop = false;
            this.StatisticsGB.Text = "Statistics Options";
            // 
            // ComparisonLbl
            // 
            this.ComparisonLbl.AutoSize = true;
            this.ComparisonLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComparisonLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.ComparisonLbl.Location = new System.Drawing.Point(69, 93);
            this.ComparisonLbl.Name = "ComparisonLbl";
            this.ComparisonLbl.Size = new System.Drawing.Size(78, 14);
            this.ComparisonLbl.TabIndex = 81;
            this.ComparisonLbl.Text = "Way to View";
            // 
            // RevenuesComparisonComboBox
            // 
            this.RevenuesComparisonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RevenuesComparisonComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevenuesComparisonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(56)))), ((int)(((byte)(139)))));
            this.RevenuesComparisonComboBox.FormattingEnabled = true;
            this.RevenuesComparisonComboBox.Items.AddRange(new object[] {
            "Day By Day",
            "Month By Month",
            "Year By Year"});
            this.RevenuesComparisonComboBox.Location = new System.Drawing.Point(14, 121);
            this.RevenuesComparisonComboBox.Name = "RevenuesComparisonComboBox";
            this.RevenuesComparisonComboBox.Size = new System.Drawing.Size(198, 21);
            this.RevenuesComparisonComboBox.TabIndex = 80;
            // 
            // NumberOfItemsTxtBox
            // 
            this.NumberOfItemsTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfItemsTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.NumberOfItemsTxtBox.Location = new System.Drawing.Point(14, 53);
            this.NumberOfItemsTxtBox.Name = "NumberOfItemsTxtBox";
            this.NumberOfItemsTxtBox.Size = new System.Drawing.Size(198, 21);
            this.NumberOfItemsTxtBox.TabIndex = 79;
            this.NumberOfItemsTxtBox.Text = "10";
            // 
            // NumberOfItemsLbl
            // 
            this.NumberOfItemsLbl.AutoSize = true;
            this.NumberOfItemsLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfItemsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.NumberOfItemsLbl.Location = new System.Drawing.Point(55, 23);
            this.NumberOfItemsLbl.Name = "NumberOfItemsLbl";
            this.NumberOfItemsLbl.Size = new System.Drawing.Size(102, 14);
            this.NumberOfItemsLbl.TabIndex = 78;
            this.NumberOfItemsLbl.Text = "Number Of Items";
            // 
            // VendorsOptionsGB
            // 
            this.VendorsOptionsGB.Controls.Add(this.VendorNameComboBox);
            this.VendorsOptionsGB.Controls.Add(this.VendorNameLbl);
            this.VendorsOptionsGB.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsOptionsGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.VendorsOptionsGB.Location = new System.Drawing.Point(26, 7);
            this.VendorsOptionsGB.Name = "VendorsOptionsGB";
            this.VendorsOptionsGB.Size = new System.Drawing.Size(215, 152);
            this.VendorsOptionsGB.TabIndex = 76;
            this.VendorsOptionsGB.TabStop = false;
            this.VendorsOptionsGB.Text = "Vendors Options";
            // 
            // VendorNameComboBox
            // 
            this.VendorNameComboBox.DataSource = this.vendorsBindingSource;
            this.VendorNameComboBox.DisplayMember = "Name";
            this.VendorNameComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.VendorNameComboBox.FormattingEnabled = true;
            this.VendorNameComboBox.Location = new System.Drawing.Point(9, 77);
            this.VendorNameComboBox.Name = "VendorNameComboBox";
            this.VendorNameComboBox.Size = new System.Drawing.Size(198, 21);
            this.VendorNameComboBox.TabIndex = 71;
            this.VendorNameComboBox.ValueMember = "ID";
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.dBDataSet;
            // 
            // VendorNameLbl
            // 
            this.VendorNameLbl.AutoSize = true;
            this.VendorNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(106)))), ((int)(((byte)(140)))));
            this.VendorNameLbl.Location = new System.Drawing.Point(59, 56);
            this.VendorNameLbl.Name = "VendorNameLbl";
            this.VendorNameLbl.Size = new System.Drawing.Size(82, 14);
            this.VendorNameLbl.TabIndex = 72;
            this.VendorNameLbl.Text = "Vendor Name";
            // 
            // webBrowser1
            // 
            this.webBrowser1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(246, 167);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(738, 475);
            this.webBrowser1.TabIndex = 2;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 642);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ReportsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsFrm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            this.LayoutOptions.ResumeLayout(false);
            this.LayoutOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.InventoryOptionsGB.ResumeLayout(false);
            this.InventoryOptionsGB.PerformLayout();
            this.CustomerOptionsGB.ResumeLayout(false);
            this.CustomerOptionsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.TellerGB.ResumeLayout(false);
            this.TellerGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.StatisticsGB.ResumeLayout(false);
            this.StatisticsGB.PerformLayout();
            this.VendorsOptionsGB.ResumeLayout(false);
            this.VendorsOptionsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.DateTimePicker DateToPicker;
        private System.Windows.Forms.Label DateToLbl;
        private System.Windows.Forms.DateTimePicker DateFrompicker;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.ComboBox TellerNameComboBox;
        private System.Windows.Forms.CheckBox AllTellersChkBox;
        private System.Windows.Forms.CheckBox TableBorderChkBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.CheckBox ThermalPrinterChkBox;
        private System.Windows.Forms.Button PrintToThermalBtn;
        private System.Windows.Forms.Button SaveAsBtn;
        private System.Windows.Forms.Label CustomerNameLbl;
        private System.Windows.Forms.Label VendorNameLbl;
        private System.Windows.Forms.Label CustomerPhoneLbl;
        private System.Windows.Forms.ComboBox CustomerNameComboBox;
        private System.Windows.Forms.ComboBox VendorNameComboBox;
        private System.Windows.Forms.ComboBox Phone1ComboBox;
        private System.Windows.Forms.CheckBox CustomerNamechkBox;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private DBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private DBDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private System.Windows.Forms.GroupBox LayoutOptions;
        private System.Windows.Forms.GroupBox VendorsOptionsGB;
        private System.Windows.Forms.GroupBox CustomerOptionsGB;
        private System.Windows.Forms.GroupBox TellerGB;
        private System.Windows.Forms.GroupBox StatisticsGB;
        private System.Windows.Forms.TextBox NumberOfItemsTxtBox;
        private System.Windows.Forms.Label NumberOfItemsLbl;
        private System.Windows.Forms.ComboBox RevenuesComparisonComboBox;
        private System.Windows.Forms.Label ComparisonLbl;
        private System.Windows.Forms.CheckBox ColorsChkBox;
        private System.Windows.Forms.CheckBox RTLChkBox;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.GroupBox InventoryOptionsGB;
        private System.Windows.Forms.Label ItemNameLbl;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.TextBox RefNumTxtBox;
        private System.Windows.Forms.Label ReferenceNumLbl;
    }
}