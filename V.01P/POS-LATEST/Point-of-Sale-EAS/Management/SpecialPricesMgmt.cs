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
    public static class SpecialPricesMgmt
    {
        public static DataTable SelectAllPriceLevels()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * FROM SpecialPrices WHERE 1=1", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *SpecialPrices* MGMT ( SelectAllPriceLevels FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable SelectSpecialPricebyItemIDandPriceLevelID(int aItemID,int aPriceLevelID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Price FROM SpecialPrices WHERE ItemID=@ItemID and PriceLevelID=@PriceLevelID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    da.SelectCommand.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aPriceLevelID ;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                        return dt;
                   
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *SpecialPrices* MGMT ( SelectSpecialPricebyItemIDandPriceLevelID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static Nullable<int> AddSpecialPrice(int ItemID, int PriceLevelID,double Price)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO SpecialPrices (ItemID,PriceLevelID,Price) VALUES (@ItemID,@PriceLevelID,@Price)", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = PriceLevelID;
                    cmd.Parameters.Add("@Price", SqlDbType.Float).Value = Price;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return 0;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("ERROR IN *Priviliges* MGMT (AddPrivilige FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }


        public static Nullable<int> UpdatePriceLevel(int ItemID, int PriceLevelID, double Price)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE  SpecialPrices SET Price=@Price WHERE ItemID=@ItemID AND PriceLevelID=@PriceLevelID", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = PriceLevelID;
                    cmd.Parameters.Add("@Price", SqlDbType.Float).Value = Price;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Priviliges* MGMT (AddPrivilige FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }


        public static Nullable<bool> IsSpecialPriceExist(int aItemID, int aPriceLevelID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Price FROM SpecialPrices WHERE ItemID=@ItemID and PriceLevelID=@PriceLevelID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    da.SelectCommand.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aPriceLevelID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count>0)
                    {
                        return true; 
                    }
                    else
                    {
                        return false;   
                    }

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *SpecialPrices* MGMT ( SelectSpecialPricebyItemIDandPriceLevelID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

    }
}
