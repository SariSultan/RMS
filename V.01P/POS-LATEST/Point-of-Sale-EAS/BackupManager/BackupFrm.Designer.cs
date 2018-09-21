namespace Calcium_RMS.BackupManager
{
    partial class BackupFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupFrm));
            this.BackupDBBtn = new System.Windows.Forms.Button();
            this.VerifyBackedUpDBBTn = new System.Windows.Forms.Button();
            this.RestoreDBBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // BackupDBBtn
            // 
            this.BackupDBBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackupDBBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackupDBBtn.BackgroundImage")));
            this.BackupDBBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackupDBBtn.FlatAppearance.BorderSize = 0;
            this.BackupDBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackupDBBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupDBBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.BackupDBBtn.Location = new System.Drawing.Point(12, 12);
            this.BackupDBBtn.Name = "BackupDBBtn";
            this.BackupDBBtn.Size = new System.Drawing.Size(237, 76);
            this.BackupDBBtn.TabIndex = 0;
            this.BackupDBBtn.Text = "Backup Database";
            this.BackupDBBtn.UseVisualStyleBackColor = false;
            this.BackupDBBtn.Click += new System.EventHandler(this.BackupDBBtn_Click);
            // 
            // VerifyBackedUpDBBTn
            // 
            this.VerifyBackedUpDBBTn.BackColor = System.Drawing.Color.Transparent;
            this.VerifyBackedUpDBBTn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerifyBackedUpDBBTn.BackgroundImage")));
            this.VerifyBackedUpDBBTn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VerifyBackedUpDBBTn.FlatAppearance.BorderSize = 0;
            this.VerifyBackedUpDBBTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyBackedUpDBBTn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyBackedUpDBBTn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.VerifyBackedUpDBBTn.Location = new System.Drawing.Point(12, 94);
            this.VerifyBackedUpDBBTn.Name = "VerifyBackedUpDBBTn";
            this.VerifyBackedUpDBBTn.Size = new System.Drawing.Size(237, 69);
            this.VerifyBackedUpDBBTn.TabIndex = 0;
            this.VerifyBackedUpDBBTn.Text = "Verify";
            this.VerifyBackedUpDBBTn.UseVisualStyleBackColor = false;
            this.VerifyBackedUpDBBTn.Click += new System.EventHandler(this.VerifyBackedUpDBBTn_Click);
            // 
            // RestoreDBBtn
            // 
            this.RestoreDBBtn.BackColor = System.Drawing.Color.Transparent;
            this.RestoreDBBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RestoreDBBtn.BackgroundImage")));
            this.RestoreDBBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestoreDBBtn.FlatAppearance.BorderSize = 0;
            this.RestoreDBBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreDBBtn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestoreDBBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(115)))), ((int)(((byte)(4)))));
            this.RestoreDBBtn.Location = new System.Drawing.Point(12, 169);
            this.RestoreDBBtn.Name = "RestoreDBBtn";
            this.RestoreDBBtn.Size = new System.Drawing.Size(237, 67);
            this.RestoreDBBtn.TabIndex = 0;
            this.RestoreDBBtn.Text = "Restore";
            this.RestoreDBBtn.UseVisualStyleBackColor = false;
            this.RestoreDBBtn.Click += new System.EventHandler(this.RestoreDBBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(267, 46);
            this.progressBar1.TabIndex = 1;
            // 
            // BackupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 292);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RestoreDBBtn);
            this.Controls.Add(this.VerifyBackedUpDBBTn);
            this.Controls.Add(this.BackupDBBtn);
            this.Name = "BackupFrm";
            this.Text = "Backup/ Restore Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackupDBBtn;
        private System.Windows.Forms.Button VerifyBackedUpDBBTn;
        private System.Windows.Forms.Button RestoreDBBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}