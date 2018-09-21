namespace Calcium_RMS
{
    partial class Testing
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
            this.Add1000ItemsBtn = new System.Windows.Forms.Button();
            this.Add1000Sale = new System.Windows.Forms.Button();
            this.Add1000PurchaseVoucherBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add1000ItemsBtn
            // 
            this.Add1000ItemsBtn.Location = new System.Drawing.Point(79, 22);
            this.Add1000ItemsBtn.Name = "Add1000ItemsBtn";
            this.Add1000ItemsBtn.Size = new System.Drawing.Size(366, 23);
            this.Add1000ItemsBtn.TabIndex = 0;
            this.Add1000ItemsBtn.Text = "Add 1000 Items";
            this.Add1000ItemsBtn.UseVisualStyleBackColor = true;
            this.Add1000ItemsBtn.Click += new System.EventHandler(this.Add1000ItemsBtn_Click);
            // 
            // Add1000Sale
            // 
            this.Add1000Sale.Location = new System.Drawing.Point(79, 71);
            this.Add1000Sale.Name = "Add1000Sale";
            this.Add1000Sale.Size = new System.Drawing.Size(366, 23);
            this.Add1000Sale.TabIndex = 0;
            this.Add1000Sale.Text = "Add 1000 Sale Receipt";
            this.Add1000Sale.UseVisualStyleBackColor = true;
            this.Add1000Sale.Click += new System.EventHandler(this.Add1000Sale_Click);
            // 
            // Add1000PurchaseVoucherBtn
            // 
            this.Add1000PurchaseVoucherBtn.Location = new System.Drawing.Point(79, 139);
            this.Add1000PurchaseVoucherBtn.Name = "Add1000PurchaseVoucherBtn";
            this.Add1000PurchaseVoucherBtn.Size = new System.Drawing.Size(366, 23);
            this.Add1000PurchaseVoucherBtn.TabIndex = 0;
            this.Add1000PurchaseVoucherBtn.Text = "Add 1000 Purchase Voucher";
            this.Add1000PurchaseVoucherBtn.UseVisualStyleBackColor = true;
            this.Add1000PurchaseVoucherBtn.Click += new System.EventHandler(this.Add1000PurchaseVoucherBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add1000PurchaseVoucherBtn);
            this.Controls.Add(this.Add1000Sale);
            this.Controls.Add(this.Add1000ItemsBtn);
            this.Name = "Testing";
            this.Text = "Testing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add1000ItemsBtn;
        private System.Windows.Forms.Button Add1000Sale;
        private System.Windows.Forms.Button Add1000PurchaseVoucherBtn;
        private System.Windows.Forms.Label label1;
    }
}