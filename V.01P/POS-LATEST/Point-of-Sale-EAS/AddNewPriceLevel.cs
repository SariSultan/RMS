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
    public partial class AddNewPriceLevel : Form
    {
        Color NameBGColor = Color.White;
        Color DescriptionBGColor = Color.White;

        public AddNewPriceLevel()
        {
            InitializeComponent();
            NameBGColor = NameTxtBox.BackColor;
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

        private void AddNewPriceLevelBtn_Click(object sender, EventArgs e)
        {
            try
            {


                if (Validators.TxtBoxNotEmpty(NameTxtBox.Text) && Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                {
                    Nullable<int> Check = PriceLevelsMgmt.IsPriceLevelUsed(NameTxtBox.Text);
                    if (Check == 10)
                    {
                        PriceLevels aPriceLevel = new PriceLevels();
                        aPriceLevel.Price_Level_Name = NameTxtBox.Text;
                        aPriceLevel.Price_Level_Description = DescriptionTxtBox.Text;

                        try
                        {
                            PriceLevelsMgmt.AddPriceLevel(aPriceLevel);
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else if (Check == 5)
                    {
                        MessageBox.Show(MsgTxt.PriceLevelsTxt + "[" + NameTxtBox.Text + "]" + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (Check == null)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + " \n[DataBase Error]:IN [AddNewPriceLevelBtn_Click]" + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                    {
                        DescriptionTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        DescriptionTxtBox.Focus();
                    }
                    else
                    {
                        DescriptionTxtBox.BackColor = DescriptionBGColor;
                    }

                    if (!Validators.TxtBoxNotEmpty(NameTxtBox.Text))
                    {
                        NameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        NameTxtBox.Focus();
                    }
                    else
                    {
                        NameTxtBox.BackColor = NameBGColor;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + " \n[Exception]:IN [AddNewPriceLevelBtn_Click]" + "\n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TranslateUI()
        {


            try
            {
                this.Text = FormsNames.AddNewPriceLevelFormName;
                AddNewPriceLevelBtn.Text = UiText.AddPrcLvlAddNewPriceLevelBtn;
                DescriptionLbl.Text = UiText.AddPrcLvlDescriptionLbl;
                label3.Text = UiText.AddPrcLvllabel3;
                NameLbl.Text = UiText.AddPrcLvlNameLbl;
                RequiredFieldsLbl.Text = UiText.AddPrcLvlRequiredFieldsLbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddNewPriceLevel_Load(object sender, EventArgs e)
        {
            
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
