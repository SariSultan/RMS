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
   public static class PriceLevelsMgmt
    {
       public static void AddPriceLevel(PriceLevels aPriceLevels)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO PriceLevels (Name,Description) VALUES (@Name,@Description)", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPriceLevels.Price_Level_Name;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPriceLevels.Price_Level_Description;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PriceLevels* MGMT (AddPriceLevel FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static void UpdatePriceLevel(PriceLevels aPriceLevels)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE PriceLevels SET Name=@Name,Description=@Description,Discount=@Discount WHERE ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPriceLevels.Price_Level_Name;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPriceLevels.Price_Level_Description;
                   cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = aPriceLevels.Price_Level_Discount;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PriceLevels* MGMT (UpdatePriceLevel FUNCTION) EX=" + ex.Message.ToString());
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
                   SqlDataAdapter da = new SqlDataAdapter("Select * from PriceLevels ", Helper.Instance.con);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt;

               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *PriceLevels* MGMT ( SelectAll FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static string SelectPriceLevelNameByID(int aID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select Name from PriceLevels Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                   {
                       return dt.Rows[0]["Name"].ToString();
                   }
                   else
                   {
                       return null;
                   }
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *PriceLevels* MGMT (SelectPriceLevelNameByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static Nullable<int> IsPriceLevelUsed(string aPriceLevelName)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select ID from PriceLevels Where Name=@Name", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPriceLevelName;
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
                   MessageBox.Show("ERROR IN *PriceLevelMgmt* MGMT (IsPriceLevelUsed FUNCTION) EX=" + ex.Message.ToString());
                   return null;

               }
           }
           return null;
       }

       public static Nullable<int> SelectPriceLevelIDByName(string aName)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select ID from PriceLevels Where Name=@Name", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aName;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                   {
                       return int.Parse(dt.Rows[0]["ID"].ToString());
                   }
                   else
                   {
                       return 0;
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *PriceLevels* MGMT (SelectPriceLevelIDByName FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }
    }
}
