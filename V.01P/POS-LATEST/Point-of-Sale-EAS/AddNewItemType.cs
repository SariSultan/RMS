using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Entities;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class AddNewItemType : Form
    {
        Color NameBGColor = Color.White;
        Color DescBGColor = Color.White;

        public AddNewItemType()
        {
            InitializeComponent();

            NameBGColor = NameTxtBox.BackColor;
            DescBGColor = DescriptionTxtBox.BackColor;

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            //Add this Line To Each Constructor To Disable Maximize
           
            this.StartPosition = FormStartPosition.CenterScreen;

            TranslateUI();
        }

        private void AddTypeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validators.TxtBoxNotEmpty(NameTxtBox.Text) && Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                {
                    Nullable<int> Check = ItemTypeMgmt.IsTypeUsedByName(NameTxtBox.Text);
                    if (Check == 10)
                    {
                        ItemType aItemType = new ItemType();
                        aItemType.Item_Type_Name = NameTxtBox.Text;
                        aItemType.Item_Type_Description = DescriptionTxtBox.Text;
                        if (!ItemTypeMgmt.AddItemType(aItemType))
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + "\nCannot Add Item Type\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else if (Check == 5)
                    {
                        MessageBox.Show(MsgTxt.ItemTypeTxt + "\n" + NameTxtBox.Text + "\n" + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (Check == null)
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error :Connection Problem In[AddTypeBtn_Click]  \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        DescriptionTxtBox.BackColor = DescBGColor;
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
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddCategoryBtn_Click] -  \nException:\n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddNewTypeFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //// this.RightToLeftLayout = true;
                AddTypeBtn.Text = UiText.AddItmTypAddTypeBtn;
                DescriptionLbl.Text = UiText.AddItmTypDescriptionLbl;
                label3.Text = UiText.AddItmTyplabel3;
                NameLbl.Text = UiText.AddItmTypNameLbl;
                RequiredFieldsLbl.Text = UiText.AddItmTypRequiredFieldsLbl;
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
