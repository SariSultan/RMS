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
   public static class VendorsAccountsMgmt
    {
        public static bool InserVendorAccount(int aVendorID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO VendorsAccounts (VendorID,Amount) VALUES (@VendorID,0)", Helper.Instance.con);
                    cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = aVendorID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *VendorsAccounts* MGMT (InserVendorAccount FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }

            }
            return false;
        }
        public static DataRow SelectVendorAccountRowByVendorID(int aVendorID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from VendorsAccounts Where VendorID=@VendorID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@VendorID", SqlDbType.Int).Value = aVendorID;
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
                    MessageBox.Show("ERROR IN *VendorsAccounts* MGMT ( SelectVendorAccountRowByVendorID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static void UpdateAccountAmountByAccountID(int aAccountID, double aAmount)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE VendorsAccounts SET Amount=@Amount Where ID=@ID", Helper.Instance.con);


                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
                    cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = aAmount;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *VendorsAccounts* MGMT ( UpdateAccountAmountByAccountID FUNCTION) EX=" + ex.Message.ToString());

                }
            }

        }

        public static DataTable SelectAll()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from VendorsAccounts", Helper.Instance.con);

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
                    MessageBox.Show("ERROR IN *VendorsAccounts* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
