namespace Calcium_RMS
{
    partial class AccountsFrm
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
            this.AccountDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.AccountComboBox = new System.Windows.Forms.ComboBox();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Calcium_RMS.DBDataSet();
            this.AccountLbl = new System.Windows.Forms.Label();
            this.accountsTableAdapter = new Calcium_RMS.DBDataSetTableAdapters.AccountsTableAdapter();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.AccntsMgmLbl = new System.Windows.Forms.Label();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDescriptionTxtBox
            // 
            this.AccountDescriptionTxtBox.BackColor = System.Drawing.Color.White;
            this.AccountDescriptionTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountDescriptionTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AccountDescriptionTxtBox.Location = new System.Drawing.Point(12, 101);
            this.AccountDescriptionTxtBox.Name = "AccountDescriptionTxtBox";
            this.AccountDescriptionTxtBox.ReadOnly = true;
            this.AccountDescriptionTxtBox.Size = new System.Drawing.Size(306, 21);
            this.AccountDescriptionTxtBox.TabIndex = 12;
            this.AccountDescriptionTxtBox.TabStop = false;
            // 
            // AccountComboBox
            // 
            this.AccountComboBox.DataSource = this.accountsBindingSource;
            this.AccountComboBox.DisplayMember = "Name";
            this.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountComboBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AccountComboBox.FormattingEnabled = true;
            this.AccountComboBox.Location = new System.Drawing.Point(12, 74);
            this.AccountComboBox.Name = "AccountComboBox";
            this.AccountComboBox.Size = new System.Drawing.Size(150, 21);
            this.AccountComboBox.TabIndex = 13;
            this.AccountComboBox.ValueMember = "ID";
            this.AccountComboBox.SelectedValueChanged += new System.EventHandler(this.AccountComboBox_SelectedValueChanged);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccountLbl
            // 
            this.AccountLbl.AutoSize = true;
            this.AccountLbl.BackColor = System.Drawing.Color.Transparent;
            this.AccountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AccountLbl.Location = new System.Drawing.Point(61, 57);
            this.AccountLbl.Name = "AccountLbl";
            this.AccountLbl.Size = new System.Drawing.Size(53, 14);
            this.AccountLbl.TabIndex = 11;
            this.AccountLbl.Text = "Account";
            // 
            // accountsTableAdapter
            // 
            this.accountsTableAdapter.ClearBeforeFill = true;
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.BackColor = System.Drawing.Color.White;
            this.AmountTxtBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AmountTxtBox.Location = new System.Drawing.Point(168, 74);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(150, 21);
            this.AmountTxtBox.TabIndex = 14;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(105, 133);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(120, 24);
            this.UpdateBtn.TabIndex = 15;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.BackColor = System.Drawing.Color.Transparent;
            this.AmountLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AmountLbl.Location = new System.Drawing.Point(218, 57);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(51, 14);
            this.AmountLbl.TabIndex = 16;
            this.AmountLbl.Text = "Amount";
            // 
            // AccntsMgmLbl
            // 
            this.AccntsMgmLbl.AutoSize = true;
            this.AccntsMgmLbl.BackColor = System.Drawing.Color.Transparent;
            this.AccntsMgmLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccntsMgmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(65)))), ((int)(((byte)(52)))));
            this.AccntsMgmLbl.Location = new System.Drawing.Point(58, 10);
            this.AccntsMgmLbl.Name = "AccntsMgmLbl";
            this.AccntsMgmLbl.Size = new System.Drawing.Size(215, 23);
            this.AccntsMgmLbl.TabIndex = 11;
            this.AccntsMgmLbl.Text = "Accounts Managment";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "-----------------------------------------------------------------------------";
            // 
            // AccountsFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 168);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.AccountDescriptionTxtBox);
            this.Controls.Add(this.AccountComboBox);
            this.Controls.Add(this.AccntsMgmLbl);
            this.Controls.Add(this.AccountLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AccountsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AccountsFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccountsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountDescriptionTxtBox;
        private System.Windows.Forms.ComboBox AccountComboBox;
        private System.Windows.Forms.Label AccountLbl;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DBDataSetTableAdapters.AccountsTableAdapter accountsTableAdapter;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.Label AccntsMgmLbl;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.Label label1;
    }
}