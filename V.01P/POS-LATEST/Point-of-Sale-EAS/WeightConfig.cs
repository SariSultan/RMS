using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Entities;
using Calcium_RMS.Management;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class WeightConfig : Form
    {
        DataRow aWeightrow = null;
        bool ThereIsWeight = false;
        public WeightConfig()
        {
            InitializeComponent();

            aWeightrow = WeightMgmt.SelectWeightRow();
            BarcodeLengthTxtBox.Text = aWeightrow["BarcodeLength"].ToString();
            DivisionScaleTxtBox.Text = aWeightrow["DivisionScale"].ToString();

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            //Add this Line To Each Constructor To Disable Maximize

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void UpdateBtnLbl_Click(object sender, EventArgs e)
        {
            int aBarcodeLength = 0;
            int aDivisionscale = 0;
            if (int.TryParse(BarcodeLengthTxtBox.Text, out aBarcodeLength) && int.TryParse(DivisionScaleTxtBox.Text, out aDivisionscale))
            {
                Weight aWeight = new Weight();
                aWeight.DivisionScale = aDivisionscale;
                aWeight.BarcodeLength = aBarcodeLength;

                if (WeightMgmt.UpdateWeight(aWeight))
                {
                    MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + " " + "DB-ERROR: Cannot UpdateWeight", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!int.TryParse(BarcodeLengthTxtBox.Text, out aBarcodeLength))
                {
                    BarcodeLengthTxtBox.Focus();
                }
                else
                {
                    DivisionScaleTxtBox.Focus();
                }
            }
        }

        private void WeightConfig_Load(object sender, EventArgs e)
        {

        }

        //Garbage Collector
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                foreach (object obj in this.Controls)
                {
                    if (obj is IDisposable)
                    {
                        (obj as IDisposable).Dispose();
                    }
                }
                base.OnClosed(e);
                base.Dispose();
                this.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [OnClosed] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.WeightConfigFormName;
                BarcodeLengthLbl.Text = UiText.W8CnfBarcodeLengthLbl;
                DivisionScaleLbl.Text = UiText.W8CnfDivisionScaleLbl;
                UpdateBtnLbl.Text = UiText.W8CnfUpdateBtnLbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
