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
    public partial class Keybrd : GenericKeyboard
    {
        public Keybrd()
        {
            InitializeComponent();
            foreach (NoFocusButtonKbrd btn in this.Controls)
            {
                btn.Click += new EventHandler(RaiseEventBtn);
            }
        }

        private void RaiseEventBtn(object sender, EventArgs e)
        {
            if (sender is NoFocusButtonKbrd)
            {
                NoFocusButtonKbrd aBtn = sender as NoFocusButtonKbrd;
                if (aBtn.Text == "Tab")
                {
                    RaiseButtonPressed((char)Keys.Tab);
                }
                else if (aBtn.Text == "Enter")
                {
                    RaiseButtonPressed((char)Keys.Return);
                }
                else if (aBtn.Text == "<<")
                {
                    RaiseButtonPressed((char)Keys.Back); 
                }
                else if (aBtn.Text == "Hide")
                {
                    this.Visible = false;
                }
                else
                {
                    RaiseButtonPressed((char)aBtn.Text.Substring(0, 1)[0]);
                }

            }
        }

        
    }
    public partial class NoFocusButtonKbrd : Button
    {
        public NoFocusButtonKbrd()
        {
            SetStyle(ControlStyles.Selectable, false);
            FlatAppearance.BorderSize = 3;
            BackColor = Color.FromArgb(0, 160, 176);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 193, 212);
            FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 130, 145);
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            Size = new System.Drawing.Size(100, 100);
            UseVisualStyleBackColor = false;




        }
    }
    
}
