namespace Calcium_RMS.Security
{
    partial class ActivationFrm
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
            this.GenerateKeyBtn = new System.Windows.Forms.Button();
            this.AddResponseKey = new System.Windows.Forms.Button();
            this.ActvStepsLbl = new System.Windows.Forms.Label();
            this.Step1Lbl = new System.Windows.Forms.Label();
            this.Step2Lbl = new System.Windows.Forms.Label();
            this.ClientNameTxtBox = new System.Windows.Forms.TextBox();
            this.CompanyNameTxtBox = new System.Windows.Forms.TextBox();
            this.ClientPhoneTxtBox = new System.Windows.Forms.TextBox();
            this.ClientEmailTxtBox = new System.Windows.Forms.TextBox();
            this.ClientNameLbl = new System.Windows.Forms.Label();
            this.CompanyNameLbl = new System.Windows.Forms.Label();
            this.ClientPhoneLbl = new System.Windows.Forms.Label();
            this.ClientEmailLbl = new System.Windows.Forms.Label();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            this.Step3Lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateKeyBtn
            // 
            this.GenerateKeyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(160)))));
            this.GenerateKeyBtn.FlatAppearance.BorderSize = 0;
            this.GenerateKeyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateKeyBtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateKeyBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateKeyBtn.Location = new System.Drawing.Point(85, 593);
            this.GenerateKeyBtn.Name = "GenerateKeyBtn";
            this.GenerateKeyBtn.Size = new System.Drawing.Size(241, 38);
            this.GenerateKeyBtn.TabIndex = 0;
            this.GenerateKeyBtn.Text = "Generate Request Key File";
            this.GenerateKeyBtn.UseVisualStyleBackColor = false;
            this.GenerateKeyBtn.Click += new System.EventHandler(this.GenerateKeyBtn_Click);
            // 
            // AddResponseKey
            // 
            this.AddResponseKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(57)))), ((int)(((byte)(160)))));
            this.AddResponseKey.FlatAppearance.BorderSize = 0;
            this.AddResponseKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddResponseKey.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResponseKey.ForeColor = System.Drawing.Color.White;
            this.AddResponseKey.Location = new System.Drawing.Point(381, 480);
            this.AddResponseKey.Name = "AddResponseKey";
            this.AddResponseKey.Size = new System.Drawing.Size(241, 38);
            this.AddResponseKey.TabIndex = 0;
            this.AddResponseKey.Text = "Add Reponse Key";
            this.AddResponseKey.UseVisualStyleBackColor = false;
            this.AddResponseKey.Click += new System.EventHandler(this.AddResponseKey_Click);
            // 
            // ActvStepsLbl
            // 
            this.ActvStepsLbl.AutoSize = true;
            this.ActvStepsLbl.BackColor = System.Drawing.Color.Transparent;
            this.ActvStepsLbl.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActvStepsLbl.ForeColor = System.Drawing.Color.White;
            this.ActvStepsLbl.Location = new System.Drawing.Point(183, 175);
            this.ActvStepsLbl.Name = "ActvStepsLbl";
            this.ActvStepsLbl.Size = new System.Drawing.Size(363, 42);
            this.ActvStepsLbl.TabIndex = 1;
            this.ActvStepsLbl.Text = "REGISTRATION FORM";
            // 
            // Step1Lbl
            // 
            this.Step1Lbl.AutoSize = true;
            this.Step1Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Step1Lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.Step1Lbl.Location = new System.Drawing.Point(79, 257);
            this.Step1Lbl.Name = "Step1Lbl";
            this.Step1Lbl.Size = new System.Drawing.Size(196, 42);
            this.Step1Lbl.TabIndex = 1;
            this.Step1Lbl.Text = "Step1:\r\nGenerate The Request Key File \r\nand Send It To You Reseller";
            this.Step1Lbl.Click += new System.EventHandler(this.Step1Lbl_Click);
            // 
            // Step2Lbl
            // 
            this.Step2Lbl.AutoSize = true;
            this.Step2Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Step2Lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.Step2Lbl.Location = new System.Drawing.Point(379, 429);
            this.Step2Lbl.Name = "Step2Lbl";
            this.Step2Lbl.Size = new System.Drawing.Size(178, 42);
            this.Step2Lbl.TabIndex = 1;
            this.Step2Lbl.Text = "Step2:\r\nAdd The Key To The System\r\nand Enjoy!";
            this.Step2Lbl.Click += new System.EventHandler(this.Step2Lbl_Click);
            // 
            // ClientNameTxtBox
            // 
            this.ClientNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientNameTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientNameTxtBox.Location = new System.Drawing.Point(88, 342);
            this.ClientNameTxtBox.Name = "ClientNameTxtBox";
            this.ClientNameTxtBox.Size = new System.Drawing.Size(221, 26);
            this.ClientNameTxtBox.TabIndex = 2;
            // 
            // CompanyNameTxtBox
            // 
            this.CompanyNameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyNameTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.CompanyNameTxtBox.Location = new System.Drawing.Point(88, 412);
            this.CompanyNameTxtBox.Name = "CompanyNameTxtBox";
            this.CompanyNameTxtBox.Size = new System.Drawing.Size(205, 26);
            this.CompanyNameTxtBox.TabIndex = 3;
            // 
            // ClientPhoneTxtBox
            // 
            this.ClientPhoneTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientPhoneTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPhoneTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientPhoneTxtBox.Location = new System.Drawing.Point(88, 482);
            this.ClientPhoneTxtBox.Name = "ClientPhoneTxtBox";
            this.ClientPhoneTxtBox.Size = new System.Drawing.Size(205, 26);
            this.ClientPhoneTxtBox.TabIndex = 4;
            // 
            // ClientEmailTxtBox
            // 
            this.ClientEmailTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientEmailTxtBox.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientEmailTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientEmailTxtBox.Location = new System.Drawing.Point(88, 552);
            this.ClientEmailTxtBox.Name = "ClientEmailTxtBox";
            this.ClientEmailTxtBox.Size = new System.Drawing.Size(205, 26);
            this.ClientEmailTxtBox.TabIndex = 5;
            // 
            // ClientNameLbl
            // 
            this.ClientNameLbl.AutoSize = true;
            this.ClientNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClientNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientNameLbl.Location = new System.Drawing.Point(79, 320);
            this.ClientNameLbl.Name = "ClientNameLbl";
            this.ClientNameLbl.Size = new System.Drawing.Size(79, 14);
            this.ClientNameLbl.TabIndex = 7;
            this.ClientNameLbl.Text = "Client Name";
            // 
            // CompanyNameLbl
            // 
            this.CompanyNameLbl.AutoSize = true;
            this.CompanyNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.CompanyNameLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.CompanyNameLbl.Location = new System.Drawing.Point(79, 390);
            this.CompanyNameLbl.Name = "CompanyNameLbl";
            this.CompanyNameLbl.Size = new System.Drawing.Size(101, 14);
            this.CompanyNameLbl.TabIndex = 7;
            this.CompanyNameLbl.Text = "Company Name";
            // 
            // ClientPhoneLbl
            // 
            this.ClientPhoneLbl.AutoSize = true;
            this.ClientPhoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClientPhoneLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientPhoneLbl.Location = new System.Drawing.Point(79, 460);
            this.ClientPhoneLbl.Name = "ClientPhoneLbl";
            this.ClientPhoneLbl.Size = new System.Drawing.Size(85, 14);
            this.ClientPhoneLbl.TabIndex = 7;
            this.ClientPhoneLbl.Text = "Client Phone";
            // 
            // ClientEmailLbl
            // 
            this.ClientEmailLbl.AutoSize = true;
            this.ClientEmailLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClientEmailLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientEmailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.ClientEmailLbl.Location = new System.Drawing.Point(79, 529);
            this.ClientEmailLbl.Name = "ClientEmailLbl";
            this.ClientEmailLbl.Size = new System.Drawing.Size(77, 14);
            this.ClientEmailLbl.TabIndex = 7;
            this.ClientEmailLbl.Text = "Client Email";
            // 
            // MinimizePB
            // 
            this.MinimizePB.BackColor = System.Drawing.Color.Transparent;
            this.MinimizePB.BackgroundImage = global::Calcium_RMS.Properties.Resources.Minus_Icon1;
            this.MinimizePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePB.Location = new System.Drawing.Point(662, 12);
            this.MinimizePB.Name = "MinimizePB";
            this.MinimizePB.Size = new System.Drawing.Size(15, 15);
            this.MinimizePB.TabIndex = 35;
            this.MinimizePB.TabStop = false;
            // 
            // ExitPB
            // 
            this.ExitPB.BackColor = System.Drawing.Color.Transparent;
            this.ExitPB.BackgroundImage = global::Calcium_RMS.Properties.Resources.x_Icon;
            this.ExitPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPB.Location = new System.Drawing.Point(683, 12);
            this.ExitPB.Name = "ExitPB";
            this.ExitPB.Size = new System.Drawing.Size(15, 15);
            this.ExitPB.TabIndex = 34;
            this.ExitPB.TabStop = false;
            // 
            // Step3Lbl
            // 
            this.Step3Lbl.AutoSize = true;
            this.Step3Lbl.BackColor = System.Drawing.Color.Transparent;
            this.Step3Lbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step3Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(29)))), ((int)(((byte)(124)))));
            this.Step3Lbl.Location = new System.Drawing.Point(79, 647);
            this.Step3Lbl.Name = "Step3Lbl";
            this.Step3Lbl.Size = new System.Drawing.Size(199, 28);
            this.Step3Lbl.TabIndex = 1;
            this.Step3Lbl.Text = "Step3: Send the request file to\r\nRMSActivation@calcium.com.jo";
            this.Step3Lbl.Click += new System.EventHandler(this.Step1Lbl_Click);
            // 
            // ActivationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calcium_RMS.Properties.Resources.Regiester_new_logo;
            this.ClientSize = new System.Drawing.Size(710, 750);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.ClientEmailLbl);
            this.Controls.Add(this.ClientPhoneLbl);
            this.Controls.Add(this.CompanyNameLbl);
            this.Controls.Add(this.ClientNameLbl);
            this.Controls.Add(this.ClientEmailTxtBox);
            this.Controls.Add(this.ClientPhoneTxtBox);
            this.Controls.Add(this.CompanyNameTxtBox);
            this.Controls.Add(this.ClientNameTxtBox);
            this.Controls.Add(this.Step2Lbl);
            this.Controls.Add(this.Step3Lbl);
            this.Controls.Add(this.Step1Lbl);
            this.Controls.Add(this.ActvStepsLbl);
            this.Controls.Add(this.AddResponseKey);
            this.Controls.Add(this.GenerateKeyBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivationFrm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateKeyBtn;
        private System.Windows.Forms.Button AddResponseKey;
        private System.Windows.Forms.Label ActvStepsLbl;
        private System.Windows.Forms.Label Step1Lbl;
        private System.Windows.Forms.Label Step2Lbl;
        private System.Windows.Forms.TextBox ClientNameTxtBox;
        private System.Windows.Forms.TextBox CompanyNameTxtBox;
        private System.Windows.Forms.TextBox ClientPhoneTxtBox;
        private System.Windows.Forms.TextBox ClientEmailTxtBox;
        private System.Windows.Forms.Label ClientNameLbl;
        private System.Windows.Forms.Label CompanyNameLbl;
        private System.Windows.Forms.Label ClientPhoneLbl;
        private System.Windows.Forms.Label ClientEmailLbl;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
        private System.Windows.Forms.Label Step3Lbl;
    }
}