namespace Calcium_RMS
{
    partial class EditTouchScreenItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BarcodeTxtBox = new System.Windows.Forms.TextBox();
            this.ItemsWithoutBarcodeLbl = new System.Windows.Forms.Label();
            this.ItemsWithoutBarcodeComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet2 = new Calcium_RMS.DBDataSet();
            this.BarcodeLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionLbl = new System.Windows.Forms.Label();
            this.ItemDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.itemsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.ItemsTableAdapter();
            this.TeldgView = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.WithoutAddBtn = new System.Windows.Forms.Button();
            this.DescriptionAddBtn = new System.Windows.Forms.Button();
            this.BarcodeAddBtn = new System.Windows.Forms.Button();
            this.DeleteItemsBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).BeginInit();
            this.UpperPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarcodeTxtBox
            // 
            this.BarcodeTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BarcodeTxtBox.Location = new System.Drawing.Point(700, 50);
            this.BarcodeTxtBox.Name = "BarcodeTxtBox";
            this.BarcodeTxtBox.Size = new System.Drawing.Size(213, 33);
            this.BarcodeTxtBox.TabIndex = 135;
            this.BarcodeTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarcodeTxtBox_KeyPress);
            // 
            // ItemsWithoutBarcodeLbl
            // 
            this.ItemsWithoutBarcodeLbl.AutoSize = true;
            this.ItemsWithoutBarcodeLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsWithoutBarcodeLbl.Location = new System.Drawing.Point(356, 19);
            this.ItemsWithoutBarcodeLbl.Name = "ItemsWithoutBarcodeLbl";
            this.ItemsWithoutBarcodeLbl.Size = new System.Drawing.Size(214, 25);
            this.ItemsWithoutBarcodeLbl.TabIndex = 134;
            this.ItemsWithoutBarcodeLbl.Text = "ItemsWithoutBarcode";
            // 
            // ItemsWithoutBarcodeComboBox
            // 
            this.ItemsWithoutBarcodeComboBox.DataSource = this.itemsBindingSource1;
            this.ItemsWithoutBarcodeComboBox.DisplayMember = "Description";
            this.ItemsWithoutBarcodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsWithoutBarcodeComboBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsWithoutBarcodeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemsWithoutBarcodeComboBox.FormattingEnabled = true;
            this.ItemsWithoutBarcodeComboBox.Location = new System.Drawing.Point(361, 50);
            this.ItemsWithoutBarcodeComboBox.Name = "ItemsWithoutBarcodeComboBox";
            this.ItemsWithoutBarcodeComboBox.Size = new System.Drawing.Size(256, 33);
            this.ItemsWithoutBarcodeComboBox.TabIndex = 131;
            this.ItemsWithoutBarcodeComboBox.ValueMember = "Barcode";
            // 
            // itemsBindingSource1
            // 
            this.itemsBindingSource1.DataMember = "Items";
            this.itemsBindingSource1.DataSource = this.dBDataSet2;
            // 
            // dBDataSet2
            // 
            this.dBDataSet2.DataSetName = "DBDataSet";
            this.dBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BarcodeLbl
            // 
            this.BarcodeLbl.AutoSize = true;
            this.BarcodeLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarcodeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BarcodeLbl.Location = new System.Drawing.Point(695, 19);
            this.BarcodeLbl.Name = "BarcodeLbl";
            this.BarcodeLbl.Size = new System.Drawing.Size(171, 25);
            this.BarcodeLbl.TabIndex = 132;
            this.BarcodeLbl.Text = "Barcode Scanner";
            // 
            // ItemDescriptionLbl
            // 
            this.ItemDescriptionLbl.AutoSize = true;
            this.ItemDescriptionLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemDescriptionLbl.Location = new System.Drawing.Point(3, 19);
            this.ItemDescriptionLbl.Name = "ItemDescriptionLbl";
            this.ItemDescriptionLbl.Size = new System.Drawing.Size(167, 25);
            this.ItemDescriptionLbl.TabIndex = 133;
            this.ItemDescriptionLbl.Text = "Item Description";
            // 
            // ItemDescriptionComboBox
            // 
            this.ItemDescriptionComboBox.DataSource = this.itemsBindingSource;
            this.ItemDescriptionComboBox.DisplayMember = "Description";
            this.ItemDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemDescriptionComboBox.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDescriptionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.ItemDescriptionComboBox.FormattingEnabled = true;
            this.ItemDescriptionComboBox.Location = new System.Drawing.Point(3, 47);
            this.ItemDescriptionComboBox.Name = "ItemDescriptionComboBox";
            this.ItemDescriptionComboBox.Size = new System.Drawing.Size(292, 37);
            this.ItemDescriptionComboBox.TabIndex = 130;
            this.ItemDescriptionComboBox.ValueMember = "Barcode";
            this.ItemDescriptionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemDescriptionComboBox_KeyPress);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // TeldgView
            // 
            this.TeldgView.AllowUserToAddRows = false;
            this.TeldgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeldgView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeldgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TeldgView.BackgroundColor = System.Drawing.Color.White;
            this.TeldgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeldgView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeldgView.ColumnHeadersHeight = 28;
            this.TeldgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TeldgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Description,
            this.PricePerUnit,
            this.AvalQty});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeldgView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeldgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeldgView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeldgView.Location = new System.Drawing.Point(0, 90);
            this.TeldgView.Name = "TeldgView";
            this.TeldgView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeldgView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TeldgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeldgView.Size = new System.Drawing.Size(972, 610);
            this.TeldgView.StandardTab = true;
            this.TeldgView.TabIndex = 136;
            // 
            // Barcode
            // 
            this.Barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 71;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PricePerUnit.HeaderText = "PriceUnit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.Width = 74;
            // 
            // AvalQty
            // 
            this.AvalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.AvalQty.HeaderText = "AvalQty";
            this.AvalQty.Name = "AvalQty";
            this.AvalQty.Width = 71;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Transparent;
            this.UpperPanel.Controls.Add(this.WithoutAddBtn);
            this.UpperPanel.Controls.Add(this.DescriptionAddBtn);
            this.UpperPanel.Controls.Add(this.BarcodeAddBtn);
            this.UpperPanel.Controls.Add(this.BarcodeTxtBox);
            this.UpperPanel.Controls.Add(this.ItemsWithoutBarcodeLbl);
            this.UpperPanel.Controls.Add(this.ItemsWithoutBarcodeComboBox);
            this.UpperPanel.Controls.Add(this.BarcodeLbl);
            this.UpperPanel.Controls.Add(this.ItemDescriptionLbl);
            this.UpperPanel.Controls.Add(this.ItemDescriptionComboBox);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1020, 90);
            this.UpperPanel.TabIndex = 137;
            // 
            // WithoutAddBtn
            // 
            this.WithoutAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.WithoutAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green1;
            this.WithoutAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WithoutAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WithoutAddBtn.FlatAppearance.BorderSize = 0;
            this.WithoutAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WithoutAddBtn.ForeColor = System.Drawing.Color.Coral;
            this.WithoutAddBtn.Location = new System.Drawing.Point(621, 41);
            this.WithoutAddBtn.Name = "WithoutAddBtn";
            this.WithoutAddBtn.Size = new System.Drawing.Size(45, 45);
            this.WithoutAddBtn.TabIndex = 137;
            this.WithoutAddBtn.UseVisualStyleBackColor = false;
            this.WithoutAddBtn.Click += new System.EventHandler(this.WithoutAddBtn_Click);
            // 
            // DescriptionAddBtn
            // 
            this.DescriptionAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Icon;
            this.DescriptionAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DescriptionAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DescriptionAddBtn.FlatAppearance.BorderSize = 0;
            this.DescriptionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionAddBtn.Location = new System.Drawing.Point(298, 42);
            this.DescriptionAddBtn.Name = "DescriptionAddBtn";
            this.DescriptionAddBtn.Size = new System.Drawing.Size(45, 45);
            this.DescriptionAddBtn.TabIndex = 137;
            this.DescriptionAddBtn.UseVisualStyleBackColor = false;
            this.DescriptionAddBtn.Click += new System.EventHandler(this.DescriptionAddBtn_Click);
            // 
            // BarcodeAddBtn
            // 
            this.BarcodeAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.BarcodeAddBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.Plus_Green1;
            this.BarcodeAddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarcodeAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarcodeAddBtn.FlatAppearance.BorderSize = 0;
            this.BarcodeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BarcodeAddBtn.ForeColor = System.Drawing.Color.Coral;
            this.BarcodeAddBtn.Location = new System.Drawing.Point(927, 41);
            this.BarcodeAddBtn.Name = "BarcodeAddBtn";
            this.BarcodeAddBtn.Size = new System.Drawing.Size(45, 45);
            this.BarcodeAddBtn.TabIndex = 137;
            this.BarcodeAddBtn.UseVisualStyleBackColor = false;
            this.BarcodeAddBtn.Click += new System.EventHandler(this.BarcodeAddBtn_Click);
            // 
            // DeleteItemsBtn
            // 
            this.DeleteItemsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteItemsBtn.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon_Big;
            this.DeleteItemsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteItemsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItemsBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DeleteItemsBtn.FlatAppearance.BorderSize = 0;
            this.DeleteItemsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemsBtn.Location = new System.Drawing.Point(2, 3);
            this.DeleteItemsBtn.Name = "DeleteItemsBtn";
            this.DeleteItemsBtn.Size = new System.Drawing.Size(45, 45);
            this.DeleteItemsBtn.TabIndex = 136;
            this.DeleteItemsBtn.UseVisualStyleBackColor = false;
            this.DeleteItemsBtn.Click += new System.EventHandler(this.DeleteItemsBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.DeleteItemsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(972, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 610);
            this.panel1.TabIndex = 138;
            // 
            // EditTouchScreenItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.TeldgView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EditTouchScreenItems";
            this.Text = "Edit Touch Screen Items";
            this.Load += new System.EventHandler(this.EditTouchScreenItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeldgView)).EndInit();
            this.UpperPanel.ResumeLayout(false);
            this.UpperPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeTxtBox;
        private System.Windows.Forms.Label ItemsWithoutBarcodeLbl;
        private System.Windows.Forms.ComboBox ItemsWithoutBarcodeComboBox;
        private System.Windows.Forms.Label BarcodeLbl;
        private System.Windows.Forms.Label ItemDescriptionLbl;
        private System.Windows.Forms.ComboBox ItemDescriptionComboBox;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private DBDataSet dBDataSet;
        private DBDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private DBDataSet dBDataSet2;
        private System.Windows.Forms.BindingSource itemsBindingSource1;
        private System.Windows.Forms.DataGridView TeldgView;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvalQty;
        private System.Windows.Forms.Button BarcodeAddBtn;
        private System.Windows.Forms.Button DeleteItemsBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button WithoutAddBtn;
        private System.Windows.Forms.Button DescriptionAddBtn;

    }
}