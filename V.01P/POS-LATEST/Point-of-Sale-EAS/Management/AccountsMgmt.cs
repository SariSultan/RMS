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
    public static class AccountsMgmt
    {
        public static string SelectAccountDescriptionByID(int aID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Description from Accounts Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0]["Description"].ToString();
                    else
                        return "";
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SlectAccountDescriptionByID FUNCTION) EX=" + ex.Message.ToString());
                    return "";
                }
            }
            return "";
        }

        public static int SelectDefaultAccountID()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Accounts Where IsDefault=1", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["ID"].ToString());
                    else
                        return 1;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectDefaultAccountID FUNCTION) EX=" + ex.Message.ToString());
                    return 1;
                }
            }
            return 1;
        }
        public static int SelectDefaultCreditAccountID()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Accounts Where IsDefaultCreditCardAccount=1", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["ID"].ToString());
                    else
                        return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectDefaultCreditAccountID FUNCTION) EX=" + ex.Message.ToString());
                    return 1;
                }
            }
            return 1;
        }

        public static DataRow SelectDefaultCreditAccount()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Accounts Where IsDefaultCreditCardAccount=1", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectDefaultCreditAccountID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectAccountRowByID(int aAccountID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Accounts Where ID=@ID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
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
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectAccountByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static int SelectAccountCurrencyByID(int aAccountID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select CurrencyID from Accounts Where ID=@ID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["CurrencyID"].ToString());
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectAccountCurrencyByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static int SelectAccountPaymentMethodByID(int aAccountID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select PaymentMethodID from Accounts Where ID=@ID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aAccountID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["PaymentMethodID"].ToString());
                    else
                        return 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectAccountPaymentMethodByID FUNCTION) EX=" + ex.Message.ToString());
                    return 1;
                }
            }
            return 1;
        }

        public static DataTable SelectAll()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Accounts", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                 
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Amount=@Amount Where ID=@ID", Helper.Instance.con);

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
                    cmd.Parameters.Add("@Amount", SqlDbType.Float).Value = aAmount;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( UpdateAccountAmountByAccountID FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;

        }
        public static double SelectAccountAmountByID(int aAccountID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Amount from Accounts Where ID=@ID", Helper.Instance.con);

                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aAccountID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return double.Parse(dt.Rows[0]["Amount"].ToString());
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Accounts* MGMT ( SelectAccountAmountByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

    }
}
