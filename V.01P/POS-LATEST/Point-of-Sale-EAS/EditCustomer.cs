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
    public partial class EditCustomer : Form
    {
        int CustomerID = 0;
        bool IsLoading = false;
        bool OnExit = false;
        Color NameColor = Color.White;
        Color PhoneColor = Color.White;


        public EditCustomer()
        {
            this.SuspendLayout();
            InitializeComponent();
            NameColor = NameTxtBox.BackColor;
            PhoneColor = Phone1TxtBox.BackColor;

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            TranslateUI();
            this.ResumeLayout();
        }
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            IsLoading = true;
            try
            {
                this.customerTableAdapter.Fill(this.dBDataSet.Customer);
                Err1.Hide();
                IsLoading = false;
            }
            catch (Exception ex)
            {
                IsLoading = false;
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditCustomer_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            this.ResumeLayout();
            Application.DoEvents();

        }

        private void Phone1ComboBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsLoading && !OnExit)
            {
                if (Validators.TxtBoxNotEmpty(Phone1ComboBox.Text))
                {
                    Phone1ComboBox.BackColor = Color.White;
                    DataRow DR = CustomerMgmt.SelectCustomerByPhone1(Phone1ComboBox.Text);
                    if (DR != null)
                    {
                        UpdateCustomerBtn.Show();
                        CustomerID = int.Parse(DR["ID"].ToString());
                        NameTxtBox.Text = DR["Name"].ToString();
                        AddressTxtBox.Text = DR["Address"].ToString();
                        EmailTxtBox.Text = DR["Email"].ToString();
                        Phone1TxtBox.Text = DR["Phone1"].ToString();

                        DataRow CusAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                        if (CusAccount != null)
                        {
                            MakeUserAccountChkBox.Checked = true;
                        }
                        else
                        {
                            MakeUserAccountChkBox.Checked = false;
                        }
                    }
                    else
                    {
                        UpdateCustomerBtn.Hide();
                        // MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [Phone1ComboBox_TextChanged:SelectCustomerByPhone1 ==null] \n Exception: " + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    UpdateCustomerBtn.Hide();

                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Phone1ComboBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    Phone1ComboBox.Focus();
                }
            }

        }

        private void UpdateCustomerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTxtBox.Text.ToUpper() == "CASH")
                {
                    return;
                }
                if (Validators.TxtBoxNotEmpty(NameTxtBox.Text) && Validators.TxtBoxNotEmpty(Phone1TxtBox.Text))
                {
                    Phone1TxtBox.BackColor = PhoneColor;
                    NameTxtBox.BackColor = NameColor;

                    if (!CustomerMgmt.IsPhoneUsed(Phone1TxtBox.Text) || Phone1TxtBox.Text == Phone1ComboBox.Text)
                    {
                        Customer aCustomer = new Customer();
                        aCustomer.Customer_Name = NameTxtBox.Text;
                        aCustomer.Customer_Address = AddressTxtBox.Text;
                        aCustomer.Customer_Email = EmailTxtBox.Text;
                        aCustomer.Customer_Phone1 = Phone1TxtBox.Text;
                        aCustomer.Customer_ID = CustomerID;
                        DataRow CusAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);

                        if (MakeUserAccountChkBox.Checked == false)
                        {
                            if (CusAccount != null)
                            {
                                Err1.Show();
                            }
                            else
                            {
                                CustomerMgmt.UpdateInfomationByID(aCustomer);
                                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            if (CusAccount == null)
                            {
                                if (!CustomersAccountsMgmt.InsertCustomerAccount(CustomerID))
                                {
                                    MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            if (!CustomerMgmt.UpdateInfomationByID(aCustomer))
                            {
                                MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                throw new Exception("Database Error in [Update Information By ID]");
                            }
                            else
                            {
                                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.PhoneInUse, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (!Validators.TxtBoxNotEmpty(Phone1TxtBox.Text))
                    {
                        Phone1TxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        Phone1TxtBox.Focus();
                    }
                    else
                    {
                        Phone1TxtBox.BackColor = PhoneColor;
                    }

                    if (!Validators.TxtBoxNotEmpty(NameTxtBox.Text))
                    {
                        NameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        NameTxtBox.Focus();
                    }
                    else
                    {
                        NameTxtBox.BackColor = NameColor;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateCustomerBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }
        public void UpdateVariables(DataRow aCustomerDataRow)
        {
            try
            {
                IsLoading = true;
                Phone1ComboBox.Text = aCustomerDataRow["Phone1"].ToString();
                Phone1ComboBox.SelectedValue = aCustomerDataRow["ID"].ToString();
                CustomerID = int.Parse(aCustomerDataRow["ID"].ToString());
                NameTxtBox.Text = aCustomerDataRow["Name"].ToString();
                EmailTxtBox.Text = aCustomerDataRow["Email"].ToString();
                AddressTxtBox.Text = aCustomerDataRow["Address"].ToString();
                Phone1TxtBox.Text = aCustomerDataRow["Phone1"].ToString();
                DataRow CusAccount = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                if (CusAccount != null)
                {
                    MakeUserAccountChkBox.Checked = true;
                }
                else
                {
                    MakeUserAccountChkBox.Checked = false;
                }

                UpdateCustomerBtn.Show();
                IsLoading = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateVariables] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditCustomerFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                // this.RightToLeftLayout = true;
                AddressLbl.Text = UiText.EdtCstAddressLbl;
                CustomerInfoGB.Text = UiText.EdtCstCustomerInfoGB;
                EditCustomersLbl.Text = UiText.EdtCstEditCustomersLbl;
                EmailLbl.Text = UiText.EdtCstEmailLbl;
                Err1.Text = UiText.EdtCstErr1;
                MakeUserAccountChkBox.Text = UiText.EdtCstMakeUserAccountChkBox;
                NameLbl.Text = UiText.EdtCstNameLbl;
                Phone1ComboBoxlbl.Text = UiText.EdtCstPhone1ComboBoxlbl;
                Phone1Lbl.Text = UiText.EdtCstPhone1Lbl;
                UpdateCustomerBtn.Text = UiText.EdtCstUpdateCustomerBtn;

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
            OnExit = true;
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
