namespace Calcium_RMS
{
    partial class ListUsers
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
            this.ListUsersBtn = new System.Windows.Forms.Button();
            this.ListUsersDgView = new System.Windows.Forms.DataGridView();
            this.Namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListUsersLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDgView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListUsersBtn
            // 
            this.ListUsersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(193)))), ((int)(((byte)(48)))));
            this.ListUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListUsersBtn.FlatAppearance.BorderSize = 0;
            this.ListUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListUsersBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsersBtn.ForeColor = System.Drawing.Color.White;
            this.ListUsersBtn.Location = new System.Drawing.Point(450, 60);
            this.ListUsersBtn.Name = "ListUsersBtn";
            this.ListUsersBtn.Size = new System.Drawing.Size(120, 50);
            this.ListUsersBtn.TabIndex = 26;
            this.ListUsersBtn.Text = "List Users";
            this.ListUsersBtn.UseVisualStyleBackColor = false;
            this.ListUsersBtn.Click += new System.EventHandler(this.ListUsersBtn_Click);
            // 
            // ListUsersDgView
            // 
            this.ListUsersDgView.AllowUserToAddRows = false;
            this.ListUsersDgView.AllowUserToDeleteRows = false;
            this.ListUsersDgView.BackgroundColor = System.Drawing.Color.White;
            this.ListUsersDgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListUsersDgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Namecol,
            this.Address,
            this.Phone1,
            this.Phone2,
            this.UserName,
            this.Password,
            this.Description});
            this.ListUsersDgView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListUsersDgView.Location = new System.Drawing.Point(0, 123);
            this.ListUsersDgView.Name = "ListUsersDgView";
            this.ListUsersDgView.ReadOnly = true;
            this.ListUsersDgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListUsersDgView.Size = new System.Drawing.Size(1020, 577);
            this.ListUsersDgView.TabIndex = 25;
            this.ListUsersDgView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsersDgView_CellDoubleClick);
            // 
            // Namecol
            // 
            this.Namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Namecol.HeaderText = "Name";
            this.Namecol.Name = "Namecol";
            this.Namecol.ReadOnly = true;
            this.Namecol.Width = 59;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 71;
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
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 81;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 78;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ListUsersLbl
            // 
            this.ListUsersLbl.AutoSize = true;
            this.ListUsersLbl.BackColor = System.Drawing.Color.Transparent;
            this.ListUsersLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListUsersLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(193)))), ((int)(((byte)(48)))));
            this.ListUsersLbl.Location = new System.Drawing.Point(461, 22);
            this.ListUsersLbl.Name = "ListUsersLbl";
            this.ListUsersLbl.Size = new System.Drawing.Size(99, 25);
            this.ListUsersLbl.TabIndex = 24;
            this.ListUsersLbl.Text = "List Users";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ListUsersBtn);
            this.panel1.Controls.Add(this.ListUsersLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 123);
            this.panel1.TabIndex = 27;
            // 
            // ListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 700);
            this.Controls.Add(this.ListUsersDgView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListUsers";
            this.Text = "ListUsers";
            ((System.ComponentModel.ISupportInitialize)(this.ListUsersDgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListUsersBtn;
        private System.Windows.Forms.DataGridView ListUsersDgView;
        private System.Windows.Forms.Label ListUsersLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Panel panel1;
    }
}