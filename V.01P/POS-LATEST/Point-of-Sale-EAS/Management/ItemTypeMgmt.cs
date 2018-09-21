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
  public static  class ItemTypeMgmt
    {
      public static bool AddItemType(ItemType aItemType)
      {
          if (Helper.Instance.con.State == ConnectionState.Closed)
          {
              try
              {
                  Helper.Instance.con.Open();
                  SqlCommand cmd = new SqlCommand("INSERT INTO ItemType (Name,Description) VALUES (@Name,@Description)", Helper.Instance.con);
                  cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aItemType.Item_Type_Name;
                  cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemType.Item_Type_Description;
                  cmd.ExecuteNonQuery();
                  Helper.Instance.con.Close();
                  return true;
              }
              catch (Exception ex)
              {
                  Helper.Instance.con.Close();
                  MessageBox.Show("ERROR IN *ItemType* MGMT (AddItemType FUNCTION) EX=" + ex.Message.ToString());
                  return false;
              }
          }
          return false;
      }

      public static void UpdateItemType(ItemType aItemType)
      {
          if (Helper.Instance.con.State == ConnectionState.Closed)
          {
              try
              {
                  Helper.Instance.con.Open();
                  SqlCommand cmd = new SqlCommand("UPDATE ItemType SET Name=@Name,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                  cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aItemType.Item_Type_Name;
                  cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemType.Item_Type_Description;
                  cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aItemType.Item_Type_ID;

                  cmd.ExecuteNonQuery();
                  Helper.Instance.con.Close();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("ERROR IN *ItemType* MGMT (UpdateItemType FUNCTION) EX=" + ex.Message.ToString());
              }
          }
      }

      public static string SelectItemTypeByID(int aID)
      {

          if (Helper.Instance.con.State == ConnectionState.Closed)
          {
              try
              {
                  Helper.Instance.con.Open();
                  SqlDataAdapter da = new SqlDataAdapter("Select Name from ItemType Where ID=@ID", Helper.Instance.con);
                  da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                  DataTable dt = new DataTable();
                  da.Fill(dt);
                  Helper.Instance.con.Close();
                  return dt.Rows[0]["Name"].ToString() ;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("ERROR IN *ItemType* MGMT (SelectItemTypeByID FUNCTION) EX=" + ex.Message.ToString());
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
                  SqlDataAdapter da = new SqlDataAdapter("Select * from ItemType", Helper.Instance.con);
                  DataTable dt = new DataTable();
                  da.Fill(dt);
                  Helper.Instance.con.Close();
                  return dt;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("ERROR IN *ItemType* MGMT (SelectAll FUNCTION) EX=" + ex.Message.ToString());
                  return null;
              }
          }
          return null;
      }

      public static Nullable<int> IsTypeUsedByName(string aTypeName)
      {
          if (Helper.Instance.con.State == ConnectionState.Closed)
          {
              try
              {
                  Helper.Instance.con.Open();
                  SqlDataAdapter da = new SqlDataAdapter("Select Name from ItemType Where Name=@Name", Helper.Instance.con);
                  da.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aTypeName;
                  DataTable dt = new DataTable();
                  da.Fill(dt);
                  Helper.Instance.con.Close();
                  if (dt.Rows.Count>0)
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
                  MessageBox.Show("ERROR IN *ItemType* MGMT (IsTypeUsedByName FUNCTION) EX=" + ex.Message.ToString());
                  return null;

              }
          }
          return null;
      }

    
    }
}
