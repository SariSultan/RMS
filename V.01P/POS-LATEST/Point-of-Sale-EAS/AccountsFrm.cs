using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Text;
using System.Runtime.InteropServices;
namespace Calcium_RMS
{
    public partial class AccountsFrm : Form
    {
        Color AmountBGColor = Color.White;

        public AccountsFrm()
        {
            InitializeComponent();

            AmountBGColor = AmountTxtBox.BackColor;
            AmountTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);

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
            TranslateUI();

        }

        private void AccountsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'dBDataSet.Accounts' table. You can move, or remove it, as needed.
                this.accountsTableAdapter.Fill(this.dBDataSet.Accounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[AccountsFrm_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                
            }


        }

        private void AccountComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AccountComboBox.SelectedValue != null)
            {
                try
                {
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(AccountComboBox.SelectedValue.ToString()));
                    AccountDescriptionTxtBox.Text = aAccountRow["Description"].ToString();
                    AmountTxtBox.Text = aAccountRow["Amount"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AccountComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double NewAmount = 0;
                if (double.TryParse(AmountTxtBox.Text, out NewAmount) && AccountComboBox.SelectedValue != null)
                {
                    int AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                    AccountsMgmt.UpdateAccountAmountByAccountID(AccountID, NewAmount);
                    MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AmountTxtBox.BackColor = AmountBGColor;
                }
                else
                {
                    MessageBox.Show(MsgTxt.ErrorPleaseEnterCorrectAmount, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AmountTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    AmountTxtBox.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AccountsFormName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        ////To Make Size Always Normal For Non-Grid Forms
        //protected override void OnResize(EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //      //  ControlHelper.SuspendDrawing(this);
        //        this.SuspendLayout();                
        //        this.WindowState = FormWindowState.Normal;                
        //        this.ResumeLayout();
        //       // ControlHelper.ResumeDrawing(this, false);
        //    }
        //}

        protected override void OnMouseDown(MouseEventArgs e)
        {
            ControlHelper.MoveBorderless(this, e);
        }



       
    }
}
