using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalciumsComponents
{
    public partial class ChkBoxButton : UserControl
    {
        public ChkBoxButton()
        {
            InitializeComponent();
        }
    }
    public partial class ChkBoxBtn : Button
    {
     

        public bool Checked { get; set; }
        public ChkBoxBtn()
        {
            SetStyle(ControlStyles.Selectable, false);
            FlatAppearance.BorderSize = 3;
            BackColor = Color.FromArgb(0, 160, 176);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 193, 212);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 130, 145);
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            Size = new System.Drawing.Size(50, 50);
            UseVisualStyleBackColor = false;


            
        }
    }
}
