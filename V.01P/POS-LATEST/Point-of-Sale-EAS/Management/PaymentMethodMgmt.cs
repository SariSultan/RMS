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
   public static class PaymentMethodMgmt
    {
        /*THESE ARE STATIC SHOULD BE THE SAME IN THE DATABASE*/
        public static  readonly int CASH_PAYMENT_METHOD = 1;
        public static readonly int CREDITCARD_PAYMENT_METHOD = 2;
        public static readonly int CHECK_PAYMENT_METHOD = 3;
       public static void AddPaymentMethod(PaymentMethod aPaymentMethod)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO PaymentMethod (Name,Description) VALUES (@Name,@Description)", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPaymentMethod.Payment_Method_Name;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPaymentMethod.Payment_Method_Description;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT (AddPaymentMethod FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }


       public static void UpdatePaymentMethod(PaymentMethod aPaymentMethod)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE PaymentMethod SET Name=@Name,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPaymentMethod.Payment_Method_Name;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPaymentMethod.Payment_Method_Description;
                   cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aPaymentMethod.Payment_Method_ID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT (UpdatePaymentMethod FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static int SelectDefaultAccountIDByMethodID(int aMethodID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select DefaultAccountID from PaymentMethod Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aMethodID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return int.Parse(dt.Rows[0]["DefaultAccountID"].ToString());
                   else
                       return 1;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT ( SelectDefaultAccountIDByMethodID FUNCTION) EX=" + ex.Message.ToString());
                   return 1;
               }
           }
           return 1;
       }

       public static DataRow SelectDefaultPaymentMethod()
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from PaymentMethod Where IsDefault=1", Helper.Instance.con);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return dt.Rows[0];
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT ( SelectDefaultPaymentMethod FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static string SelectDescriptionByID(int aMethodID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select Description from PaymentMethod Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aMethodID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return dt.Rows[0]["Description"].ToString();
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT ( SelectDescriptionByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static DataRow SelectMethodRowByID(int aMethodID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from PaymentMethod Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aMethodID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return dt.Rows[0];
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT ( SelectMethodRowByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static DataTable SelectAll()
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from PaymentMethod ", Helper.Instance.con);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt;

               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *PaymentMethod* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }
    }
}
