namespace Calcium_RMS
{
    partial class ConnStringFrm
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
            this.ConnStringTxtBox = new System.Windows.Forms.TextBox();
            this.TestBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnStringTxtBox
            // 
            this.ConnStringTxtBox.Location = new System.Drawing.Point(12, 12);
            this.ConnStringTxtBox.Multiline = true;
            this.ConnStringTxtBox.Name = "ConnStringTxtBox";
            this.ConnStringTxtBox.Size = new System.Drawing.Size(490, 125);
            this.ConnStringTxtBox.TabIndex = 0;
            this.ConnStringTxtBox.TextChanged += new System.EventHandler(this.ConnStringTxtBox_TextChanged);
            // 
            // TestBtn
            // 
            this.TestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(193)))), ((int)(((byte)(48)))));
            this.TestBtn.FlatAppearance.BorderSize = 0;
            this.TestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestBtn.ForeColor = System.Drawing.Color.White;
            this.TestBtn.Location = new System.Drawing.Point(12, 146);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(246, 49);
            this.TestBtn.TabIndex = 1;
            this.TestBtn.Text = "Test Connection String";
            this.TestBtn.UseVisualStyleBackColor = false;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(193)))), ((int)(((byte)(48)))));
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(264, 146);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(238, 49);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Update Connection String";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ConnStringFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 209);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.ConnStringTxtBox);
            this.Name = "ConnStringFrm";
            this.Text = "Connection String Settings";
            this.Load += new System.EventHandler(this.ConnStringFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnStringTxtBox;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button UpdateBtn;
    }
}