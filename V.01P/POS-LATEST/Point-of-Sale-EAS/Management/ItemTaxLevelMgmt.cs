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
    public static class ItemTaxLevelMgmt
    {
        public static bool AddTaxLevel(ItemTaxLevel aItemTaxLevel)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TaxLevel (Percentage,Description) VALUES (@Percentage,@Description)", Helper.Instance.con);
                    cmd.Parameters.Add("@Percentage", SqlDbType.NVarChar).Value = aItemTaxLevel.Item_Tax_Percentage;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemTaxLevel.Item_Tax_Description;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                   
                    MessageBox.Show("ERROR IN *ItemTaxLevel* MGMT (AddTaxLevel FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void UpdateTaxLevel(ItemTaxLevel aItemTaxLevel)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TaxLevel SET Percentage=@Percentage,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                    cmd.Parameters.Add("@Percentage", SqlDbType.NVarChar).Value = aItemTaxLevel.Item_Tax_Percentage;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemTaxLevel.Item_Tax_Description;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aItemTaxLevel.Item_Tax_ID;

                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ItemTaxLevel* MGMT (UpdateTaxLevel FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static string SelectItemTaxByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Percentage from TaxLevel Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count>0)
                    {
                        if (dt.Rows[0]["Percentage"].ToString() == "TAX-FREE" || dt.Rows[0]["Percentage"].ToString() == "NON-TAXABLE")
                        {
                            return "0";
                        }
                        else
                        {
                            return dt.Rows[0]["Percentage"].ToString();
                        }  
                    }
                    else
                    {
                        return "0"; 
                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ItemTaxLevel* MGMT (SelectItemTaxByID FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from TaxLevel", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Tax* MGMT (SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }


        public static Nullable<int> IsTaxLevelUsed(string aPercentage)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from TaxLevel Where Percentage=@Percentage", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Percentage", SqlDbType.NVarChar).Value = aPercentage;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 10;
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *TaxLevel* MGMT (IsTaxLevelUsed FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
