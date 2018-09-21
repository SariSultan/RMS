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
    public static class CurrencyMgmt
    {
        public static double  SelectBuyRateByID(int aID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SellRate from Currency Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return double.Parse(dt.Rows[0]["SellRate"].ToString());
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectSellRateByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static double SelectSellRateByID(int aID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select BuyRate from Currency Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return double.Parse(dt.Rows[0]["BuyRate"].ToString());
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectBuyRateByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static string SelectCurrencyNameByID(int aID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Name from Currency Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0]["Name"].ToString();
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectBuyRateByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static int SelectDefaultCurrencyID()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Currency Where IsDefault=1", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectDefaultCurrencyID FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Currency ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                        return dt;
                    
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectCurrencyRowByID(int aID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {

                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Currency Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
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
                    MessageBox.Show("ERROR IN *Currency* MGMT ( SelectCurrencyRowByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
