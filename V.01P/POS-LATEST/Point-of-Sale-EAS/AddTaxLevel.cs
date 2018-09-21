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



    public partial class AddTaxLevel : Form
    {
        Color PercentageBGColor = Color.White;
        Color DescriptionBGColor = Color.White;
        public AddTaxLevel()
        {
            InitializeComponent();

            PercentageTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);

            PercentageBGColor = PercentageTxtBox.BackColor;
            DescriptionBGColor = DescriptionTxtBox.BackColor;

            TranslateUI();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            //Add this Line To Each Constructor To Disable Maximize
         
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddTaxBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double TestParser;
                if (Validators.TxtBoxNotEmpty(PercentageTxtBox.Text) && Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                {
                    if (!double.TryParse(PercentageTxtBox.Text, out TestParser))
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PercentageTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return;

                    }
                    else
                    {
                        PercentageTxtBox.BackColor = PercentageBGColor;
                    }

                    Nullable<int> Check = ItemTaxLevelMgmt.IsTaxLevelUsed(PercentageTxtBox.Text);
                    if (Check == 10)
                    {
                        ItemTaxLevel aItemTaxLevel = new ItemTaxLevel();
                        aItemTaxLevel.Item_Tax_Percentage = PercentageTxtBox.Text;
                        aItemTaxLevel.Item_Tax_Description = DescriptionTxtBox.Text;

                        if (ItemTaxLevelMgmt.AddTaxLevel(aItemTaxLevel))
                        {
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + " \n[DataBase Error]:IN [AddTaxBtn_Click]" + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }

                    }
                    else if (Check == 5)
                    {
                        MessageBox.Show(MsgTxt.PercentageTxt +" [ "+ PercentageTxtBox.Text + " ] " + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Check == null)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + " \n[DataBase Error2]:IN [AddTaxBtn_Click]" + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    if (!Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                    {
                        DescriptionTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        DescriptionTxtBox.Focus();
                    }
                    else
                    {
                        DescriptionTxtBox.BackColor = DescriptionBGColor;
                    }

                    if (!Validators.TxtBoxNotEmpty(PercentageTxtBox.Text))
                    {
                        PercentageTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        PercentageTxtBox.Focus();
                    }
                    else
                    {
                        PercentageTxtBox.BackColor = PercentageBGColor;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " \n[Exception]:IN [AddUserBtn_Click]" + "\n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }



        }

        private void AddTaxLevel_Load(object sender, EventArgs e)
        {
          
        }


        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddNewTaxLevelFormName;
                // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //// this.RightToLeftLayout = true;
                AddCustomerLbl.Text = UiText.AddTxLvlAddCustomerLbl;
                AddTaxBtn.Text = UiText.AddTxLvlAddTaxBtn;
                DescriptionLbl.Text = UiText.AddTxLvlDescriptionLbl;
                PercentageLbl.Text = UiText.AddTxLvlPercentageLbl;
                RequiredFieldsLbl.Text = UiText.AddTxLvlRequiredFieldsLbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //MAKE THE BORDERLESS MOVABLE
        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case 0x84:
                        base.WndProc(ref m);
                        if ((int)m.Result == 0x1)
                            m.Result = (IntPtr)0x2;
                        return;
                }
                base.WndProc(ref m);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WndProc] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

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

       


    }
}
