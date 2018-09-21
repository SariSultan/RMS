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
    public partial class GenericKeyboard : UserControl
    {
        public GenericKeyboard()
        {
            InitializeComponent();
        }

      

        #region Events
        public event KeyPressEventHandler ButtonPressed;
        #endregion Events

        #region Methods
        public void RaiseButtonPressed(char WhatToSend)
        {
            KeyPressEventHandler handler = ButtonPressed;
            if (handler!=null)
            {
                handler(this,new KeyPressEventArgs(WhatToSend));
            }
            
        }

        
        #endregion Methods
    }

  
}
