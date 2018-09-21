using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace Calcium_RMS.Management
{
    public static class CustomersPaymentsMgmt
    {
        public static int NextPaymentNumber()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(PaymentNumber) AS MAXNUM FROM CustomersPayments", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    int currentnumber;
                    if (dt.Rows[0]["MAXNUM"].ToString() != string.Empty)
                        currentnumber = Convert.ToInt32(dt.Rows[0]["MAXNUM"].ToString());
                    else
                        currentnumber = 0;
                    return currentnumber + 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (NextPaymentNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static bool AddCustomerPayment(CustomersPayments aCustomerPayment)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CustomersPayments (CustomerID,PaymentNumber,Date,Time,TellerID,Amount,OldUsrAccountAmount,IsChecked,IsRevised,Comments,IsCreditCard,CreditCardInfo,PaymentMethodID,CheckNumber,AccountID) VALUES (@CustomerID,@PaymentNumber,@Date,@Time,@TellerID,@Amount,@OldAccountAmount,0,0,@Comments,@IsCreditCard,@CreditCardInfo,@PaymentMethodID,@CheckNumber,@AccountID)", Helper.Instance.con);
                    // CustomerID,Date,Time,TellerID,Amount,OldAccountAmount,IsChecked,IsRevised,Comments
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomerPayment.Customer_Payment_CustomerID;
                    cmd.Parameters.Add("@PaymentNumber", SqlDbType.Int).Value = aCustomerPayment.Customer_Payment_PaymentNumber;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aCustomerPayment.Customer_Payment_Date;
                    cmd.Parameters.Add("@Time", SqlDbType.NVarChar).Value = aCustomerPayment.Customer_Payment_Time;
                    cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aCustomerPayment.Customer_Payment_TellerID;
                    cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = aCustomerPayment.Customer_Payment_Amount;
                    cmd.Parameters.Add("@OldAccountAmount", SqlDbType.Float).Value = aCustomerPayment.Customer_Payment_OldAmount;
                    //IS CHECKED AND IS REVISED ADDED TO ZEROS IN THE QUERY
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aCustomerPayment.Customer_Payment_Comments;

                    cmd.Parameters.Add("@IsCreditCard", SqlDbType.Int).Value = aCustomerPayment.IsCreditCard;
                    cmd.Parameters.Add("@CreditCardInfo", SqlDbType.NVarChar).Value = aCustomerPayment.CreditCardInfo;

                    cmd.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = aCustomerPayment.PaymentMethodID;
                    cmd.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aCustomerPayment.CheckNumber;
                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aCustomerPayment.AccountID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (AddCustomerPayment FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }

            }
            return false;
        }

        public static bool DeleteCustomerPayment(CustomersPayments aCustomerPayment)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CustomersPayments WHERE PaymentNumber=@PaymentNumber", Helper.Instance.con);
                    cmd.Parameters.Add("@PaymentNumber", SqlDbType.Int).Value = aCustomerPayment.Customer_Payment_PaymentNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (DeleteCustomerPayment FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }

            }
            return false;
        }

        public static bool UpdatePaymentToChecked(string CheckedBy, string ChkDate, string ChkTime, int aPaymentNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomersPayments SET IsChecked=1,CheckDate=@CheckDate,CheckedBy=@CheckedBy,CheckTime=@CheckTime Where PaymentNumber=@PaymentNumber", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = ChkDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.NVarChar).Value = ChkDate;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = CheckedBy;
                    cmd.Parameters.Add("@PaymentNumber", SqlDbType.Int).Value = aPaymentNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (UpdatePaymentToChecked FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static bool UpdatePaymentToRevised(string RevisedBy, string ReviseDate, string ReviseTime, int aPaymentNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomersPayments SET IsRevised=1,ReviseDate=@ReviseDate,ReviseTime=@ReviseTime,RevisedBy=@RevisedBy Where PaymentNumber=@PaymentNumber", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                    cmd.Parameters.Add("@ReviseTime", SqlDbType.NVarChar).Value = ReviseTime;
                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                    cmd.Parameters.Add("@PaymentNumber", SqlDbType.Int).Value = aPaymentNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (UpdatePaymentToRevised FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        //Selects
        public static DataTable SelectAll()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from CustomersPayments ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable SelectAll(int FilterTellerID, string FilterDateFrom, string FilterDateTo, bool FilterCheckedBills, bool FilterIsRevised, bool FilterUnchecked, bool FilterUnRevised, int FilterCustomerID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from CustomersPayments where 1=1 ", Helper.Instance.con);
                    if (FilterTellerID != 0)
                    {
                        da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = FilterTellerID;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    if (FilterCheckedBills == true)
                    {
                        da.SelectCommand.CommandText += " and IsChecked=1";
                    }
                    if (FilterIsRevised == true)
                    {
                        da.SelectCommand.CommandText += " and IsRevised=1";
                    }
                    if (FilterUnchecked)
                    {
                        da.SelectCommand.CommandText += " and IsChecked=0";

                    }
                    if (FilterUnRevised)
                    {
                        da.SelectCommand.CommandText += " and IsRevised=0";

                    }
                    if (FilterCustomerID != -1)
                    {
                        da.SelectCommand.CommandText += " and CustomerID=@CustomerID";
                        da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = FilterCustomerID;
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (SelectAllBills(param) FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataRow SelectPaymentRow(int aPaymentNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from CustomersPayments where PaymentNumber=@PaymentNumber  ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@PaymentNumber", SqlDbType.Int).Value = aPaymentNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *CustomersPayments* MGMT (SelectPaymentRow FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }


        public static double SelectCustomerPayments(string FilterDateFrom, string FilterDateTo, int TellerID, int IsReversed, int PaymentMethodID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Amount) AS TotalPrice" +
                        "  FROM CustomersPayments where  1=1", Helper.Instance.con);
                    if (FilterDateFrom != "" && FilterDateTo != "")
                    {
                        da.SelectCommand.CommandText += " AND Date>=@FilterDateFrom AND Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    if (TellerID != -1)
                    {
                        da.SelectCommand.CommandText += " AND TellerID=@TellerID";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = TellerID;
                    }
                    if (IsReversed != -1)
                    {
                        da.SelectCommand.CommandText += " AND IsRevised=@IsRevised";
                        da.SelectCommand.Parameters.Add("@IsRevised", SqlDbType.Int).Value = IsReversed;
                    }
                    if (PaymentMethodID != -1)
                    {
                        da.SelectCommand.CommandText += " AND PaymentMethodID=@PaymentMethodID";
                        da.SelectCommand.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = PaymentMethodID;
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt == null)
                    {
                        return 0.00;
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        double TestParser = 0.00;
                        if (double.TryParse(dt.Rows[0]["TotalPrice"].ToString(), out TestParser))
                        {
                            return TestParser;
                        }
                        else
                        {
                            return 0.00;
                        }

                    }
                    else
                    { return 0.00; }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Customer Payments General* MGMT (SelectCustomerPayments FUNCTION) EX=" + ex.Message.ToString());
                    return 0.00;
                }
            }
            return 0.00;
        }
    }
}
