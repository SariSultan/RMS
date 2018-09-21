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
using Calcium_RMS.Reports;
using System.Diagnostics;

namespace Calcium_RMS
{
    public partial class AddCustomerPayment : Form
    {
        bool CustomerDoNotHaveAccount = true;
        double Balance = 0;
        int CustomerID = 1;

        bool semaphore = false;

        DataRow aCustomerRow = null;
        DataRow aCusomerAccountRow = null;
        CustomersPayments aCustomerPayment;
        DataRow aMethodRow = null;

        Color CreditCardInfoTxtBoxCOLOR = Color.White;

        Color PaymentAmountTxtBoxCOLOR = Color.White;

        Color HolderNameTxtBoxCOLOR = Color.White;
        public AddCustomerPayment()
        {
            InitializeComponent();
            
            PaymentAmountTxtBox.TextChanged += new EventHandler(Validators.TextBoxDoubleInputChange);

            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            //Add this Line To Each Constructor To Disable Maximize

            this.StartPosition = FormStartPosition.CenterScreen;

            CreditCardInfoTxtBoxCOLOR = CreditCardInfoTxtBox.BackColor;
            PaymentAmountTxtBoxCOLOR = PaymentAmountTxtBox.BackColor;
            HolderNameTxtBoxCOLOR = HolderNameTxtBox.BackColor;

            TranslateUI();
        }

        private void AddCustomerPayment_Load(object sender, EventArgs e)
        {
            try
            {

                semaphore = true;
                PayDateStaticPicker.Text = DateTime.Now.ToString();
                // TODO: This line of code loads data into the 'dBDataSet.Customer' table. You can move, or remove it, as needed.
                this.customerTableAdapter.Fill(this.dBDataSet.Customer);
                aCustomerPayment = new CustomersPayments();
                int PaymentNumber = CustomersPaymentsMgmt.NextPaymentNumber();
                PaymentNumberTxtBox.Text = PaymentNumber.ToString();
                // TODO: This line of code loads data into the 'dBDataSet.PaymentMethod' table. You can move, or remove it, as needed.
                this.paymentMethodTableAdapter.Fill(this.dBDataSet.PaymentMethod);
                // TODO: This line of code loads data into the 'dBDataSet.Accounts' table. You can move, or remove it, as needed.
                this.accountsTableAdapter.Fill(this.dBDataSet.Accounts);
                semaphore = false;
            }
            catch (Exception ex) //Launching Error Please Report It To Sari King [Database error 99%]
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddCustomerPayment_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

        }

        private void CustomerPhoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!semaphore)
                {
                    semaphore = true;
                    aCusomerAccountRow = null;
                    aCustomerRow = CustomerMgmt.SelectCustomerRowByPhone1(CustomerPhoneTxtBox.Text);
                    if (aCustomerRow == null) //there is no customer
                    {
                        CustomerNameComboBox.Text = string.Empty;
                        CustomerBalanceTxtBox.Text = string.Empty;
                        PaymentAmountTxtBox.Enabled = false;
                        CommentsTxtBox.Enabled = false;
                        CustomerDoNotHaveAccount = true;
                    }
                    else
                    {
                        string CustomerName = aCustomerRow["Name"].ToString();
                        CustomerID = int.Parse(aCustomerRow["ID"].ToString());
                        aCusomerAccountRow = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                        if (aCusomerAccountRow == null)
                        {
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = UiText.CustomerDoNotHaveAccountTxt;
                            //
                            PaymentAmountTxtBox.Enabled = false;
                            CommentsTxtBox.Enabled = false;
                            CustomerDoNotHaveAccount = true;
                        }
                        else //He Have Account
                        {
                            Balance = Double.Parse(aCusomerAccountRow["Amount"].ToString());

                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = Balance.ToString();

                            PaymentAmountTxtBox.Enabled = true;
                            CommentsTxtBox.Enabled = true;

                            CustomerDoNotHaveAccount = false;

                            PaymentAmountTxtBox.Enabled = true;
                        }
                    }
                    semaphore = false;
                }
            }
            catch (Exception ex)//UnExpected Error IN [CustomerPhoneTxtBox_TextChanged]
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerPhoneTxtBox_TextChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AccountComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (AccountComboBox.SelectedValue != null)
                {
                    DataRow aAccountRow = AccountsMgmt.SelectAccountRowByID(int.Parse(AccountComboBox.SelectedValue.ToString()));
                    if (AccountsMgmt.SelectAccountPaymentMethodByID(int.Parse(AccountComboBox.SelectedValue.ToString())) == int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()))
                    {
                        AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aAccountRow["ID"].ToString()));
                        AccountBalanceTxtBox.Text = aAccountRow["Amount"].ToString();
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.AccountTxt + "\n[" + AccountComboBox.Text + "]\n" + MsgTxt.DoNotAcceptTxt + "\n" + PaymentMethodCheckBox.Text, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //Same As Function on value change for the payment method combo box
                        // DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        AccountComboBox.SelectedValue = int.Parse(aMethodRow["DefaultAccountID"].ToString());
                        PaymentMethodDescripTxtBox.Text = aMethodRow["Description"].ToString();
                        if (aMethodRow["IsCash"].ToString() == "1")
                        {
                            PayInVisaGB.Hide();
                            CheckGB.Hide();
                        }
                        else if (aMethodRow["IsCredit"].ToString() == "1")
                        {
                            PayInVisaGB.Show();
                            PayInVisaGB.BringToFront();
                            CheckGB.Hide();
                        }
                        else
                        {
                            CheckGB.Show();
                            CheckGB.BringToFront();
                            PayInVisaGB.Hide();
                        }
                    }
                }
                else
                {

                }
            }
            catch (Exception ex) //Unexpected Error
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AccountComboBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void PaymentMethodCheckBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                //no need to lock because this changes the account table which needed to be updated 
                if (PaymentMethodCheckBox.SelectedValue != null)
                {
                    aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                    AccountComboBox.SelectedValue = int.Parse(aMethodRow["DefaultAccountID"].ToString());
                    AccountDescriptionTxtBox.Text = AccountsMgmt.SelectAccountDescriptionByID(int.Parse(aMethodRow["DefaultAccountID"].ToString()));
                    PaymentMethodDescripTxtBox.Text = aMethodRow["Description"].ToString();
                    if (aMethodRow["IsCash"].ToString() == "1")
                    {
                        PayInVisaGB.Hide();
                        CheckGB.Hide();
                    }
                    else if (aMethodRow["IsCredit"].ToString() == "1")
                    {
                        PayInVisaGB.Show();
                        PayInVisaGB.BringToFront();
                        CheckGB.Hide();
                    }
                    else
                    {
                        CheckGB.Show();
                        CheckGB.BringToFront();
                        PayInVisaGB.Hide();
                        CheckNumberTxtBox.Text = ChecksMgmt.NextCheckNumber().ToString();
                    }
                }
                else
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [PaymentMethodCheckBox_SelectedValueChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void CustomerNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CustomerNameComboBox.SelectedValue != null)
                {
                    semaphore = true;

                    CustomerPhoneTxtBox.Text = CustomerNameComboBox.SelectedValue.ToString();
                    aCusomerAccountRow = null;
                    aCustomerRow = CustomerMgmt.SelectCustomerRowByPhone1(CustomerPhoneTxtBox.Text);

                    if (aCustomerRow == null) // No Customer
                    {
                        CustomerNameComboBox.Text = string.Empty;
                        CustomerBalanceTxtBox.Text = string.Empty;
                        //
                        CommentsTxtBox.ReadOnly = true;
                        CustomerDoNotHaveAccount = true;
                        PaymentAmountTxtBox.Enabled = false;
                    }
                    else
                    {
                        string CustomerName = aCustomerRow["Name"].ToString();
                        CustomerID = int.Parse(aCustomerRow["ID"].ToString());
                        aCusomerAccountRow = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                        if (aCusomerAccountRow == null)
                        {
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = UiText.CustomerDoNotHaveAccountTxt;
                            CustomerDoNotHaveAccount = true;
                            //
                            CommentsTxtBox.ReadOnly = true;
                            PaymentAmountTxtBox.Enabled = false;
                        }
                        else
                        {
                            Balance = Double.Parse(aCusomerAccountRow["Amount"].ToString());
                            CustomerNameComboBox.Text = CustomerName;
                            CustomerBalanceTxtBox.Text = Balance.ToString();
                            CommentsTxtBox.ReadOnly = false;
                            CustomerDoNotHaveAccount = false;
                            PaymentAmountTxtBox.Enabled = true;
                        }
                    }
                    semaphore = false;
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [CustomerNameComboBox_SelectedIndexChanged] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AddPaymentBtn_Click(object sender, EventArgs e)
        {
            if (AddPayment())
            {
                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddNewTxt + "?", MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                if (ret == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool AddPayment()
        {
            semaphore = true;
            int NextCheckNumber = -1;
            double Amount = 0;
            try
            {
                if (CustomerDoNotHaveAccount)
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n 1)" + MsgTxt.CustomerTxt + "\n2)" + MsgTxt.ValidAccountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    semaphore = false; return false;
                }
                else
                {
                    if (!double.TryParse(PaymentAmountTxtBox.Text, out Amount) || PaymentAmountTxtBox.Text == string.Empty)
                    {

                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PaymentAmountTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return false;
                    }
                    else if (Amount == 0)
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectCorrectAmountTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        PaymentAmountTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        return false;
                    }
                    else
                    {
                        PaymentAmountTxtBox.BackColor = PaymentAmountTxtBoxCOLOR;
                        //This is Added To Take The New Value
                        //انه لو صارت حركة بيع في اثناء التعديل
                        DataRow aMethodRow = PaymentMethodMgmt.SelectMethodRowByID(int.Parse(PaymentMethodCheckBox.SelectedValue.ToString()));
                        aCusomerAccountRow = CustomersAccountsMgmt.SelectCustomerAccountRowByCusID(CustomerID);
                        Balance = Double.Parse(aCusomerAccountRow["Amount"].ToString());

                        aCustomerPayment = new CustomersPayments();
                        int PaymentNumber = CustomersPaymentsMgmt.NextPaymentNumber();
                        if (PaymentNumber == 0)//ERROR PAYMENT NUMBER ZERO
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [Payment Number = 0] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            semaphore = false;
                            this.Close();
                            return false;
                        }
                        aCustomerPayment.Customer_Payment_PaymentNumber = PaymentNumber;
                        aCustomerPayment.Customer_Payment_CustomerID = CustomerID;
                        aCustomerPayment.Customer_Payment_Date = DateTime.Now.ToShortDateString();
                        aCustomerPayment.Customer_Payment_Time = DateTime.Now.ToShortTimeString();

                        int TellerID = UsersMgmt.SelectUserIDByUserName(SharedFunctions.ReturnLoggedUserName());
                        if (TellerID == 0)
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TellerID = 0] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            semaphore = false;
                            this.Close();
                            return false;
                        }
                        aCustomerPayment.Customer_Payment_TellerID = TellerID;
                        aCustomerPayment.Customer_Payment_OldAmount = Balance;
                        aCustomerPayment.Customer_Payment_Amount = Amount;
                        aCustomerPayment.Customer_Payment_Comments = CommentsTxtBox.Text;
                        aCustomerPayment.PaymentMethodID = int.Parse(PaymentMethodCheckBox.SelectedValue.ToString());
                        aCustomerPayment.AccountID = int.Parse(AccountComboBox.SelectedValue.ToString());
                        Checks aCheck = new Checks();
                        if (aMethodRow["IsCash"].ToString() == "1")
                        {
                            aCustomerPayment.IsCreditCard = 0;
                            aCustomerPayment.CreditCardInfo = "NOT-CREDIT";
                            if (!CustomersPaymentsMgmt.AddCustomerPayment(aCustomerPayment))
                            {
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error:CANNOT ADD PAYMENT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                this.Close();
                                return false;
                            }

                            int CusAccountID = int.Parse(aCusomerAccountRow["ID"].ToString());
                            double NewAmount = aCustomerPayment.Customer_Payment_OldAmount - aCustomerPayment.Customer_Payment_Amount;
                            if (!CustomersAccountsMgmt.UpdateAccountAmountByAccountID(CusAccountID, NewAmount))
                            {
                                CustomersPaymentsMgmt.DeleteCustomerPayment(aCustomerPayment);
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error:CANNOT UPDATE ACCOUNT AMOUNT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                this.Close();
                                return false;
                            }
                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            semaphore = false;

                            return true;
                        }
                        else if (aMethodRow["IsCredit"].ToString() == "1")//-----------------------------------------------------------------------------
                        {
                            if (CreditCardInfoTxtBox.Text.Trim() != "")
                            {
                                aCustomerPayment.IsCreditCard = 1;
                                aCustomerPayment.CreditCardInfo = CreditCardInfoTxtBox.Text;
                                if (!CustomersPaymentsMgmt.AddCustomerPayment(aCustomerPayment))
                                {
                                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error:CANNOT ADD PAYMENT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                    return false;
                                }
                                int CusAccountID = int.Parse(aCusomerAccountRow["ID"].ToString());
                                double NewAmount = aCustomerPayment.Customer_Payment_OldAmount - aCustomerPayment.Customer_Payment_Amount;
                                if (!CustomersAccountsMgmt.UpdateAccountAmountByAccountID(CusAccountID, NewAmount))
                                {
                                    CustomersPaymentsMgmt.DeleteCustomerPayment(aCustomerPayment);
                                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error:CANNOT UPDATE ACCOUNT AMOUNT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Close();
                                    return false;
                                }

                                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                semaphore = false;
                                return true;
                            }
                            else
                            {

                                MessageBox.Show(MsgTxt.PleaseAddCreditCardInfoTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                CreditCardInfoTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                                semaphore = false;
                                return true;
                            }
                        }
                        else //its cheque----------------------------------------------------------------------------------
                        {
                            if (HolderNameTxtBox.Text.Trim() != "")
                            {
                                aCheck.Chekcs_HolderName = HolderNameTxtBox.Text;
                            }
                            else
                            {
                                MessageBox.Show(MsgTxt.CheckHolderNameTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                semaphore = false;
                                HolderNameTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                                return false;
                            }

                            aCustomerPayment.IsCreditCard = 0;
                            aCustomerPayment.CreditCardInfo = "NOT-CREDIT";
                            //its check
                            NextCheckNumber = ChecksMgmt.NextCheckNumber();
                            if (NextCheckNumber == 0) //ERRO IN CHEQUES
                            {
                                MessageBox.Show("ERROR IN CHEQUE");
                                semaphore = false;
                                return false;
                            }
                            aCustomerPayment.CheckNumber = NextCheckNumber;

                            if (!CustomersPaymentsMgmt.AddCustomerPayment(aCustomerPayment))
                            {
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error: CANNOT ADD PAYMENT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                this.Close();
                                return false;
                            }
                            aCheck.Chekcs_PaymentDate = CheckDatePicker.Value.ToShortDateString();
                            aCheck.Chekcs_IsBill = 0;
                            aCheck.Chekcs_IsPurchaseVoucher = 0;
                            aCheck.Chekcs_AccountID = 0;
                            aCheck.Chekcs_Comments = CheckCommentsTxtBox.Text;
                            aCheck.Chekcs_Amount = aCustomerPayment.Customer_Payment_Amount;
                            aCheck.Chekcs_IsPaid = 0;
                            aCheck.CheckNumber = NextCheckNumber;
                            aCheck.AddingDate = DateTime.Now.ToShortDateString();
                            aCheck.Chekcs_PaymentDate = CheckDatePicker.Text;
                            aCheck.Chekcs_IsVendorPayment = 0;
                            aCheck.Chekcs_IsCustomerPayment = 1;
                            aCheck.Chekcs_CustomerPaymentNumber = aCustomerPayment.Customer_Payment_PaymentNumber;

                            if (!ChecksMgmt.InsertCheck(aCheck))
                            {
                                CustomersPaymentsMgmt.DeleteCustomerPayment(aCustomerPayment);
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error: CANNOT ADD CHECK] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                return true;
                            }

                            int CusAccountID = int.Parse(aCusomerAccountRow["ID"].ToString());
                            double NewAmount = aCustomerPayment.Customer_Payment_OldAmount - aCustomerPayment.Customer_Payment_Amount;

                            if (!CustomersAccountsMgmt.UpdateAccountAmountByAccountID(CusAccountID, NewAmount))
                            {
                                ChecksMgmt.DeleteCheckByCheckNumber(aCheck.CheckNumber);
                                CustomersPaymentsMgmt.DeleteCustomerPayment(aCustomerPayment);
                                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DataBase Error:CANNOT UPDATE ACCOUNT AMOUNT] \n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                semaphore = false;
                                this.Close();
                                return false;
                            }

                            MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            semaphore = false;

                            return true;
                        } //end of cheque
                    }
                }
            }

            catch (Exception ex)
            {
                semaphore = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddPaymentBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            return false;
        }
        private void ReloadForm()
        {
            try
            {
                CustomerPhoneTxtBox.Text = string.Empty;

                CustomerNameComboBox.Text = string.Empty;

                CustomerBalanceTxtBox.Text = string.Empty;

                CommentsTxtBox.Text = string.Empty;

                PaymentMethodCheckBox.SelectedValue = 1;

                CreditCardInfoTxtBox.Text = string.Empty;

                HolderNameTxtBox.Text = string.Empty;

                CheckCommentsTxtBox.Text = string.Empty;

                PaymentAmountTxtBox.Text = "0.00";

                CreditCardInfoTxtBox.BackColor = CreditCardInfoTxtBoxCOLOR;

                PaymentAmountTxtBox.BackColor = PaymentAmountTxtBoxCOLOR;

                HolderNameTxtBox.BackColor = HolderNameTxtBoxCOLOR;

                PaymentNumberTxtBox.Text = CustomersPaymentsMgmt.NextPaymentNumber().ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ReloadForm] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddCustomerPaymentFormName;

                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //this.RightToLeftLayout = true;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //this.RightToLeftLayout = true;
                AccountBalanceLbl.Text = UiText.AddCstPytAccountBalanceLbl;
                AccountBalnaceLbl.Text = UiText.AddCstPytAccountBalnaceLbl;
                AccountLbl.Text = UiText.AddCstPytAccountLbl;
                AddCustomerLbl.Text = UiText.AddCstPytAddCustomerLbl;
               // AddCustomerPaymentLbl.Text = UiText.AddCstPytAddCustomerPaymentLbl;
                CheckCommentsLbl.Text = UiText.AddCstPytCheckCommentsLbl;
                CheckGB.Text = UiText.AddCstPytCheckGB;
                CheckHolderNameLbl.Text = UiText.AddCstPytCheckHolderNameLbl;
                CheckNumber.Text = UiText.AddCstPytCheckNumber;
                CommentsLbl.Text = UiText.AddCstPytCommentsLbl;
                CustomerNameLbl.Text = UiText.AddCstPytCustomerNameLbl;
                CustomerPhoneLbl.Text = UiText.AddCstPytCustomerPhoneLbl;
                groupBox1.Text = UiText.AddCstPytgroupBox1;
                PayInVisaGB.Text = UiText.AddCstPytPayInVisaGB;
                PaymentAmountLbl.Text = UiText.AddCstPytPaymentAmountLbl;
                PaymentCommentsLbl.Text = UiText.AddCstPytPaymentCommentsLbl;
                PaymentDateLbl.Text = UiText.AddCstPytPaymentDateLbl;
                PaymentMethodLbl.Text = UiText.AddCstPytPaymentMethodLbl;
                PaymentNumberLbl.Text = UiText.AddCstPytPaymentNumberLbl;
                AddPaymentBtn.Text = UiText.AddPaymentBtnLbl;
                AddPaymentandPrintBtn.Text = UiText.AddPaymentandPrintBtnLbl;

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
            semaphore = true;

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

        private void AddPaymentandPrintBtn_Click(object sender, EventArgs e)
        {
            if (AddPayment())
            {
                print_receipt();
                DialogResult ret;
                ret = MessageBox.Show(MsgTxt.AddNewTxt + "?", MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                if (ret == DialogResult.Yes)
                {
                    ReloadForm();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool print_receipt()
        {
            try
            {
                List<DataTable> aDataTableList = new List<DataTable>();
                DataTable aDataTable1 = new DataTable();
                aDataTable1.Columns.Add("[border=true1]" + ReceiptText.RctTxtToPayAmount);
                aDataTable1.Columns.Add(PaymentAmountTxtBox.Text);

                aDataTable1.Rows.Add();
                aDataTable1.Rows[0][0] = ReceiptText.RctTxtPayMethod;
                aDataTable1.Rows[0][1] = PaymentMethodCheckBox.Text;
                aDataTable1.Rows.Add();
                double OldCustomerAccountAmountParser = 0;
                if (double.TryParse(CustomerBalanceTxtBox.Text, out OldCustomerAccountAmountParser))
                {
                    aDataTable1.Rows[1][0] = ReceiptText.RctTxtOldBalance;
                    aDataTable1.Rows[1][1] = OldCustomerAccountAmountParser;
                    aDataTable1.Rows.Add();
                    aDataTable1.Rows[2][0] = ReceiptText.RctTxtNewBalance;
                    aDataTable1.Rows[2][1] = OldCustomerAccountAmountParser - double.Parse(PaymentAmountTxtBox.Text);
                }

                aDataTableList.Add(aDataTable1);
                List<string> aStringList = ReportsHelper.ImportReportHeader(0, 0);
                List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 0);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
                aStringList.Add(ReceiptName.RctNmsCustomerPay);
                aStringList.Add("<h2>" + ReceiptText.RctTxtDate + "/" + ReceiptText.RctTxtTime + " " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
                aStringList.Add("<h2> " + ReceiptText.RctTxtTeller + ":&nbsp;&nbsp;" + SharedFunctions.ReturnLoggedUserName() + "</h2>");
                aStringList.Add(ReceiptText.RctTxtCustomer + ":&nbsp;&nbsp;" + CustomerNameComboBox.Text);
                aStringList.Add(ReceiptText.RctTxtPaymentNum + ":&nbsp; " + PaymentNumberTxtBox.Text);
                aStringList.Add(SharedVariables.Line_Solid_10px_Black);
               // PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, true, true);
                PrintingManager.Instance.PrintTables(aDataTableList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, !PrintingThermalA4ChkBox.Checked, !PrintingThermalA4ChkBox.Checked, PrintingThermalA4ChkBox.Checked, ReportsHelper.TempOutputPath + ".pdf", false, "", false, PrintingThermalA4ChkBox.Checked);
                if (PrintingThermalA4ChkBox.Checked)
                {
                    Process.Start(ReportsHelper.TempPDFOutputPath);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n Exception: IN[AddCustomerPayment:Print Receipt [EXCEPTION IS]] \n" + ex.Message, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
