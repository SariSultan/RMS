namespace Calcium_RMS
{
    partial class SplashFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashFrm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SqlServerStatusLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(84, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(162, 20);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // SqlServerStatusLbl
            // 
            this.SqlServerStatusLbl.AutoSize = true;
            this.SqlServerStatusLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlServerStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.SqlServerStatusLbl.Location = new System.Drawing.Point(12, 9);
            this.SqlServerStatusLbl.Name = "SqlServerStatusLbl";
            this.SqlServerStatusLbl.Size = new System.Drawing.Size(155, 19);
            this.SqlServerStatusLbl.TabIndex = 0;
            this.SqlServerStatusLbl.Text = "SQL Server Status";
            this.SqlServerStatusLbl.Visible = false;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.StatusLbl.Location = new System.Drawing.Point(258, 9);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(59, 19);
            this.StatusLbl.TabIndex = 0;
            this.StatusLbl.Text = "status";
            this.StatusLbl.Visible = false;
            // 
            // SplashFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Calcium_RMS.Properties.Resources.Logo3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SqlServerStatusLbl);
            this.Controls.Add(this.StatusLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCIUM RMS LOADING...";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label SqlServerStatusLbl;
        public System.Windows.Forms.Label StatusLbl;
    }
}