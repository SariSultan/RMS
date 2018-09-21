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
    public partial class ChooseBillToEdit : Form
    {
        Color BillNumberBGColor = Color.White;

        protected override bool ProcessCmdKey(ref Message message, Keys keys)
        {
            switch (keys)
            {
                case Keys.Return:
                    //Process action here.
                    EditBillBtn.PerformClick();
                    break;
            }
            return false;
        }

        public ChooseBillToEdit()
        {
            InitializeComponent();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            //Add this Line To Each Constructor To Disable Maximize
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            BillNumberBGColor = BillNumberTxtBox.BackColor;
            BillNumberTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxIntInputChange);          

            TranslateUI();
        }

        private void EditBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int TestParse = 0;

                if (int.TryParse(BillNumberTxtBox.Text, out TestParse))
                {
                    BillNumberTxtBox.BackColor = BillNumberBGColor;
                    if (BillGeneralMgmt.IsBillExist(int.Parse(BillNumberTxtBox.Text)))
                    {
                        DataTable aDataTableToPass = BillDetailedMgmt.SelectBillByBillNumber(int.Parse(BillNumberTxtBox.Text));
                        if (aDataTableToPass==null)
                        {
                            throw new Exception("aDataTableToPass==null");
                        }

                        EditBill aEditBill = new EditBill();
                        aEditBill.TopMost = true;                       
                        aEditBill.AddDgView(aDataTableToPass);

                        DataRow aGeneralBillDataRow = BillGeneralMgmt.SelectBillByNumber(int.Parse(BillNumberTxtBox.Text));

                        if (aGeneralBillDataRow==null)
                        {
                            aEditBill.Close();
                            throw new Exception("aGeneralBillDataRow==null");
                        }

                        aEditBill.UpdateVariables(aGeneralBillDataRow);
                        aEditBill.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.BillNumberNotExistTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BillNumberTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.ErrorPleaseEnterCorrectAmount, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BillNumberTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [EditBillBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ChooseBillToEdit_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[ChooseBillToEdit_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void TranslateUI()
        {
            try
            {
               this.Text = FormsNames.ChooseBillToEditFormName;
                BillNumber.Text = UiText.ChsBlBillNumber;
                EditBillBtn.Text = UiText.ChsBlEditBillBtn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        ////MAKE THE BORDERLESS MOVABLE
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
