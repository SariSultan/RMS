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
    public partial class AddDisposalReason : Form
    {
        Color NameBGColor = Color.White;
        Color DescBGColor = Color.White;
        public AddDisposalReason()
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

        private void AddDisposalReasonBtn_Click(object sender, EventArgs e)
        {
            if (Validators.TxtBoxNotEmpty(NameTxtBox.Text))
            {
                if (Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                {
                    DisposalReason aDisposalReason = new DisposalReason();
                    aDisposalReason.Disposal_Detailed_Name = NameTxtBox.Text;
                    aDisposalReason.Disposal_Detailed_Comment = DescriptionTxtBox.Text;

                    Nullable<int> IsAddDisposalReasonOK = DisposalReasonMgmt.AddDisposalReason(aDisposalReason);
                    if (IsAddDisposalReasonOK == 1)
                    {
                        MessageBox.Show(MsgTxt.DisposalReasonTxt + NameTxtBox.Text + "\n" + MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error: AddDisposalReasonBtn_Click] \n Exception: \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields + "\n" + "1)" + MsgTxt.DescriptionTxt, MsgTxt.PleaseAddAllRequiredFields, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    DescriptionTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    DescriptionTxtBox.Focus();

                    NameTxtBox.BackColor = NameBGColor;
                }
            }
            else
            {
                MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields + "\n" + "1)" + MsgTxt.NameTxt + "\n 2)" + MsgTxt.DescriptionTxt, MsgTxt.PleaseAddAllRequiredFields, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void AddDisposalReason_Load(object sender, EventArgs e)
        {
           
        }

        void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddDisposalReasonFormName;
                AddDisposalReasonBtn.Text = UiText.AddDsReAddDisposalReasonBtn;
                DescriptionLbl.Text = UiText.AddDsReDescriptionLbl;
                label3.Text = UiText.AddDsRelabel3;
                NameLbl.Text = UiText.AddDsReNameLbl;
                RequiredFieldsLbl.Text = UiText.AddDsReRequiredFieldsLbl;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        //MAKE THE BORDERLESS MOVABLE
        //protected override void WndProc(ref Message m)
        //{
        //    try
        //    {
        //        switch (m.Msg)
        //        {
        //            case 0x84:
        //                base.WndProc(ref m);
        //                if ((int)m.Result == 0x1)
        //                    m.Result = (IntPtr)0x2;
        //                return;
        //        }
        //        base.WndProc(ref m);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WndProc] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        this.Close();
        //    }

        //}

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
