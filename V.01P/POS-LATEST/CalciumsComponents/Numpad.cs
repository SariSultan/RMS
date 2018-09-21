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
    public partial class Numpad : GenericKeyboard
    {
        public Numpad()
        {
            InitializeComponent();            
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('0');
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('.');
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed((char)Keys.Enter);
            this.Visible = false;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed((char)Keys.Back);
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('1');
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('2');
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('3');
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('4');
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('5');
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('6');
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('7');
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('8');
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            RaiseButtonPressed('9');
        }
    }

    public partial class NoFocusButton : Button
    {
        public NoFocusButton()
        {
            SetStyle(ControlStyles.Selectable, false);
            FlatAppearance.BorderSize = 3;
            //BackColor = Color.FromArgb(0, 160, 176);
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
