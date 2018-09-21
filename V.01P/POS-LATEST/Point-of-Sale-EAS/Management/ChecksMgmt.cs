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
    public static class ChecksMgmt
    {
        public static bool InsertCheck(Checks aCheck)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Checks (HolderName,PaymentDate,IsBill,GeneralBillNumber,IsPurchaseVoucher,PurchaseVoucherNumber,AccountID,Comments,Amount,IsPaid,CheckNumber,AddingDate,IsRevised,IsCustomerPayment,CustomerPaymentNumber,IsVendorPayment,VendorPaymentNumber)" +
                                                                "VALUES (@HolderName,@PaymentDate,@IsBill,@GeneralBillNumber,@IsPurchaseVoucher,@PurchaseVoucherNumber,@AccountID,@Comments,@Amount,@IsPaid,@CheckNumber,@AddingDate,0,@IsCustomerPayment,@CustomerPaymentNumber,@IsVendorPayment,@VendorPaymentNumber)", Helper.Instance.con);
                    cmd.Parameters.Add("@HolderName", SqlDbType.NVarChar).Value = aCheck.Chekcs_HolderName;
                    cmd.Parameters.Add("@PaymentDate", SqlDbType.Date).Value = aCheck.Chekcs_PaymentDate;
                    cmd.Parameters.Add("@IsBill", SqlDbType.Int).Value = aCheck.Chekcs_IsBill;
                    cmd.Parameters.Add("@GeneralBillNumber", SqlDbType.Int).Value = aCheck.Chekcs_GeneralBillNumber;
                    cmd.Parameters.Add("@IsPurchaseVoucher", SqlDbType.Int).Value = aCheck.Chekcs_IsPurchaseVoucher;
                    cmd.Parameters.Add("@PurchaseVoucherNumber", SqlDbType.Int).Value = aCheck.Chekcs_PurchaseVoucherNumber;
                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aCheck.Chekcs_AccountID;
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aCheck.Chekcs_Comments;
                    cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = aCheck.Chekcs_Amount;
                    cmd.Parameters.Add("@IsPaid", SqlDbType.Int).Value = aCheck.Chekcs_IsPaid;

                    cmd.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aCheck.CheckNumber;
                    cmd.Parameters.Add("@AddingDate", SqlDbType.Date).Value = aCheck.AddingDate;


                    cmd.Parameters.Add("@IsCustomerPayment", SqlDbType.Int).Value = aCheck.Chekcs_IsCustomerPayment;
                    cmd.Parameters.Add("@CustomerPaymentNumber", SqlDbType.Int).Value = aCheck.Chekcs_CustomerPaymentNumber;
                    cmd.Parameters.Add("@IsVendorPayment", SqlDbType.Int).Value = aCheck.Chekcs_IsVendorPayment;
                    cmd.Parameters.Add("@VendorPaymentNumber", SqlDbType.Int).Value = aCheck.Chekcs_VendorPaymentNumber;


                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Checks* MGMT (INSERT CHECK FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static int NextCheckNumber()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(CheckNumber) AS MAXNUM FROM Checks", Helper.Instance.con);
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
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Checks* MGMT (NextCheckNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }


        public static void DeleteCheckByCheckNumber(int aCheckNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Checks Where CheckNumber =@CheckNumber", Helper.Instance.con);
                    cmd.Parameters.Add("@CheckNumber", SqlDbType.NVarChar).Value = aCheckNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR IN *Checks* MGMT (DeleteCheckByCheckNumber Function) EX=" + ex.Message.ToString());
                }
            }
        }


        public static DataRow SelectCheckRowByNumber(int aNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Checks Where CheckNumber=@CheckNumber", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Checks* MGMT (SelectCheckRowByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }


        public static bool MakeCheckRevised(int aCheckNumber, string aReviseDate)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Checks SET IsRevised=1,ReviseDate=@ReviseDate Where CheckNumber =@CheckNumber", Helper.Instance.con);
                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = aReviseDate;
                    cmd.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aCheckNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR IN *Checks* MGMT (MakeCheckRevised Function) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
        
    }
}
