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
    public static class ItemCategoryMgmt
    {
        public static bool AddItemCategory(ItemCategory aItemCategory)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ItemCategory (Name,Description) VALUES (@Name,@Description)", Helper.Instance.con);
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aItemCategory.Item_Category_Name;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemCategory.Item_Category_Description;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ItemCategory* MGMT (AddItemCategory FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void UpdateCategory(ItemCategory aItemCategory)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ItemCategory SET Name=@Name,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aItemCategory.Item_Category_Name;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItemCategory.Item_Category_Description;
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = aItemCategory.Item_Category_ID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ItemCategory* MGMT (UpdateCategory FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }
        public static string SelectItemCategoryByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Name from ItemCategory Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0]["Name"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ItemCategory* MGMT (SelectItemCategoryByID FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ItemCategory", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Category* MGMT (SelectAll FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static Nullable<int> IsCategoryUsedByName(string aCategoryName)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Name from ItemCategory Where Name=@Name", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aCategoryName;
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
                    MessageBox.Show("ERROR IN *ItemCategory* MGMT (aCategoryName FUNCTION) EX=" + ex.Message.ToString());
                    return null;

                }
            }
            return null;
        }


        public static DataTable SelectTouchScreenCategories()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ItemCategory WHERE ID IN (Select Category From Items WHERE TouchScreen=1);", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Category* MGMT (SelectTouchScreenCategories FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
