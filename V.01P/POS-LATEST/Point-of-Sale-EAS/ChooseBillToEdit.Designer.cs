namespace Calcium_RMS
{
    partial class ChooseBillToEdit
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
            this.BillNumberTxtBox = new System.Windows.Forms.TextBox();
            this.BillNumber = new System.Windows.Forms.Label();
            this.EditBillBtn = new System.Windows.Forms.Button();
            this.MinimizePB = new System.Windows.Forms.PictureBox();
            this.ExitPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).BeginInit();
            this.SuspendLayout();
            // 
            // BillNumberTxtBox
            // 
            this.BillNumberTxtBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumberTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BillNumberTxtBox.Location = new System.Drawing.Point(18, 51);
            this.BillNumberTxtBox.Name = "BillNumberTxtBox";
            this.BillNumberTxtBox.Size = new System.Drawing.Size(153, 23);
            this.BillNumberTxtBox.TabIndex = 0;
            // 
            // BillNumber
            // 
            this.BillNumber.AutoSize = true;
            this.BillNumber.BackColor = System.Drawing.Color.Transparent;
            this.BillNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.BillNumber.Location = new System.Drawing.Point(13, 9);
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.Size = new System.Drawing.Size(128, 25);
            this.BillNumber.TabIndex = 1;
            this.BillNumber.Text = "Bill Number";
            // 
            // EditBillBtn
            // 
            this.EditBillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.EditBillBtn.FlatAppearance.BorderSize = 0;
            this.EditBillBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBillBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBillBtn.ForeColor = System.Drawing.Color.White;
            this.EditBillBtn.Location = new System.Drawing.Point(17, 80);
            this.EditBillBtn.Name = "EditBillBtn";
            this.EditBillBtn.Size = new System.Drawing.Size(154, 24);
            this.EditBillBtn.TabIndex = 2;
            this.EditBillBtn.Text = "Go To Edit Page";
            this.EditBillBtn.UseVisualStyleBackColor = false;
            this.EditBillBtn.Click += new System.EventHandler(this.EditBillBtn_Click);
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
            // ChooseBillToEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(255, 130);
            this.Controls.Add(this.MinimizePB);
            this.Controls.Add(this.ExitPB);
            this.Controls.Add(this.EditBillBtn);
            this.Controls.Add(this.BillNumber);
            this.Controls.Add(this.BillNumberTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "ChooseBillToEdit";
            this.Text = "ChooseBillToEdit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ChooseBillToEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BillNumberTxtBox;
        private System.Windows.Forms.Label BillNumber;
        private System.Windows.Forms.Button EditBillBtn;
        private System.Windows.Forms.PictureBox MinimizePB;
        private System.Windows.Forms.PictureBox ExitPB;
    }
}