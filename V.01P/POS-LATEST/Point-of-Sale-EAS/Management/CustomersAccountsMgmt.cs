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
    public static class CustomersAccountsMgmt
    {
        public static bool InsertCustomerAccount(int aCustomerID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CustomersAccounts (CustomerID,Amount) VALUES (@CustomerID,0)", Helper.Instance.con);
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomerID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CUSTOMERsAccounts* MGMT (InsertCustomerAccount FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }

            }
            return false;
        }
        public static DataRow SelectCustomerAccountRowByCusID(int aCustomerID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from CustomersAccounts Where CustomerID=@CustomerID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomerID;
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
                    MessageBox.Show("ERROR IN *CustomersAccounts* MGMT ( SelectCustomerAccountRowByCusID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static bool UpdateAccountAmountByAccountID(int aAccountID, double aAmount)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE CustomersAccounts SET Amount=@Amount Where ID=@ID", Helper.Instance.con);


                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
                    cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = aAmount;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersAccounts* MGMT ( UpdateAccountAmountByAccountID FUNCTION) EX=" + ex.Message.ToString());
                    return false;

                }
            }
            return false;

        }

        public static DataTable SelectAll()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from CustomersAccounts", Helper.Instance.con);

                    //da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomerID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return dt;
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *CustomersAccounts* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
