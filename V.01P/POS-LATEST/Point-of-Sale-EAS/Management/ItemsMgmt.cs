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
    public class ItemsMgmt
    {

        public static bool AddItem(Items aItems)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Items (Type,Category,Vendor,Barcode,Description,Qty,RenderPoint,SellPrice,AvgUnitCost,EntryDate,TaxLevel,OnHandQty,IsWithoutBarcode,TouchScreen,IsWeight) VALUES (@Type,@Category,@Vendor,@Barcode,@Description,@Qty,@RenderPoint,@SellPrice,@AvgUnitCost,@Date,@TaxLevel,@OnHandQty,@IsWithoutBarcode,0,@IsWeight)", Helper.Instance.con);
                try
                {
                    Helper.Instance.con.Open();
                    cmd.Parameters.Add("@Type", SqlDbType.Int).Value = aItems.Item_Type;
                    cmd.Parameters.Add("@Category", SqlDbType.Int).Value = aItems.Item_Category;
                    cmd.Parameters.Add("@Vendor", SqlDbType.Int).Value = aItems.Vendor;
                    cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aItems.Item_Barcode;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItems.Item_Description;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aItems.Avalable_Qty;
                    cmd.Parameters.Add("@RenderPoint", SqlDbType.Float).Value = aItems.Render_Point;
                    cmd.Parameters.Add("@SellPrice", SqlDbType.Float).Value = aItems.Sell_Price;
                    cmd.Parameters.Add("@AvgUnitCost", SqlDbType.Float).Value = aItems.Avg_Unit_Cost;
                    cmd.Parameters.Add("@Date", SqlDbType.NVarChar).Value = aItems.Entry_Date;
                    cmd.Parameters.Add("@TaxLevel", SqlDbType.Int).Value = aItems.Item_Tax_Level;
                    //  cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aItems.PriceLevelID;
                    cmd.Parameters.Add("@OnHandQty", SqlDbType.Float).Value = aItems.Avalable_Qty;

                    cmd.Parameters.Add("@IsWithoutBarcode", SqlDbType.Int).Value = aItems.IsWithoutBarcode;

                    cmd.Parameters.Add("@IsWeight", SqlDbType.Int).Value = aItems.IsWeight;

                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN Items MGMT (AddItemFunction FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void UpdateItemByID(Items aItems)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET Type=@Type,Category=@Category,Vendor=@Vendor,Barcode=@Barcode,Description=@Description,Qty=@Qty,RenderPoint=@RenderPoint,SellPrice=@SellPrice,AvgUnitCost=@AvgUnitCost,TaxLevel=@TaxLevel,IsWeight=@IsWeight WHERE ID=@ID", Helper.Instance.con);
                    cmd.Parameters.Add("@Type", SqlDbType.Int).Value = aItems.Item_Type;
                    cmd.Parameters.Add("@Category", SqlDbType.Int).Value = aItems.Item_Category;
                    cmd.Parameters.Add("@Vendor", SqlDbType.Int).Value = aItems.Vendor;
                    cmd.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aItems.Item_Barcode;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aItems.Item_Description;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aItems.Avalable_Qty;
                    cmd.Parameters.Add("@RenderPoint", SqlDbType.Float).Value = aItems.Render_Point;
                    cmd.Parameters.Add("@SellPrice", SqlDbType.Float).Value = aItems.Sell_Price;
                    cmd.Parameters.Add("@AvgUnitCost", SqlDbType.Float).Value = aItems.Avg_Unit_Cost;
                    // cmd.Parameters.Add("@Date", SqlDbType.NVarChar).Value = aItems.Entry_Date;
                    cmd.Parameters.Add("@TaxLevel", SqlDbType.Int).Value = aItems.Item_Tax_Level;
                    // cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aItems.PriceLevelID;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aItems.Item_ID;

                    cmd.Parameters.Add("@IsWeight", SqlDbType.Int).Value = aItems.IsWeight;

                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateItem FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }
        public static int SelectWithoutBarcode_Barcode()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select MAX(ID) AS MAXNUM from Items", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    int MaxNum = 0;
                    if (dt.Rows.Count > 0)
                    {
                        int TestParser = 0;
                        if (int.TryParse(dt.Rows[0]["MAXNUM"].ToString(), out TestParser))
                        {
                            return TestParser + 1;
                        }
                        else
                        {
                            return MaxNum + 1;
                        }
                    }
                    else
                    {
                        return MaxNum + 1;
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectWithoutBarcode_Barcode FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        //TO HERE NOT EDITED

        public static DataTable SelectItemByBarCode(string aBarcode)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateItem FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataTable SelectAllItems()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectAllItems FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataTable RenderPoint()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items WHERE Qty<=RenderPoint ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (RenderPoint FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static Double SelectItemCostByBarcode(string aBarcode)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select AvgUnitCost from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["AvgUnitCost"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemCostByBarcode FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static int SelectItemIDByBarcode(string aBarcode)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["ID"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemIDByBarcode FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static string SelectItemBarcodeByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Barcode from Items Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0]["Barcode"].ToString();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemBarcodeByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static string SelectTaxLevelIDByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select TaxLevel from Items Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return dt.Rows[0]["TaxLevel"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemBarcodeByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static void UpdateItemQtyByBarcode(string aBarcode, double aOrginalQty, double aQtyAdded)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET Qty=@Qty WHERE Barcode=@Barcode", Helper.Instance.con);
                    cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aBarcode;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aOrginalQty + aQtyAdded;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateItemQtyByBarcode FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static bool UpdateItemQtyByID(int ItemID, double NewQty)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET Qty=@Qty WHERE ID=@ItemID", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = NewQty;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateItemQtyByID FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void UpdateAvgUnitCostByBarcode(string aBarcode, double aAvgUnitCost)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET AvgUnitCost=@AvgUnitCost WHERE Barcode=@Barcode", Helper.Instance.con);
                    cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aBarcode;
                    cmd.Parameters.Add("@AvgUnitCost", SqlDbType.Float).Value = aAvgUnitCost;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateAvgUnitCostByBarcode FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static Double SelectItemQtyByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Qty from Items Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["Qty"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemQtyByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        public static Double SelectItemQtyByBarcode(string aBarcode)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Qty from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["Qty"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemQtyByBarcode FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static DataRow SelectItemRowByBarcode(string aBarcode)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemRowByBarcode FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectItemRowByID(int aItemID)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aItemID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0];
                    }
                    else
                        return null;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectItemRowByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static bool IsItemExist(string aBarcode)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Items Where Barcode=@Barcode", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (IsItemExist FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
        public static bool IsItemExistByID(int ItemID)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Items Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ItemID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (IsItemExist FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static bool IsItemWgtExist(string aBarcode)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Items Where Barcode=@Barcode and IsWeight=1", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (IsItemWgtExist FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
        public static bool IsItemTouchScreen(string aBarcode)
        {


            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Items Where Barcode=@Barcode and TouchScreen=1 ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Barcode", SqlDbType.VarChar).Value = aBarcode;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (IsItemTouchScreen FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void FillDataSet(DataSet aDBDataSet)
        {
            try
            {
                Helper.Instance.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Items ", Helper.Instance.con);
                da.Fill(aDBDataSet, "Items");
                Helper.Instance.con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR IN *Items* MGMT (FillDataSet FUNCTION) EX=" + ex.Message.ToString());

            }
        }

        public static void UpdateItemQtyandAvgUnitCostByID(int aItemID, double aNewQty, double aNewAvgUnitCost)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET Qty=@Qty,AvgUnitCost=@AvgUnitCost WHERE ID=@ID", Helper.Instance.con);
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aNewQty;
                    cmd.Parameters.Add("@AvgUnitCost", SqlDbType.Float).Value = aNewAvgUnitCost;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aItemID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (UpdateItemQtyandAvgUnitCostByID FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static void MakeItemTouchScreen(string aBarcode, bool IsTouchScreen)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Items SET TouchScreen=@TouchScreen WHERE Barcode=@Barcode", Helper.Instance.con);
                    cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aBarcode;
                    if (IsTouchScreen)
                    {
                        cmd.Parameters.Add("@TouchScreen", SqlDbType.Int).Value = 1;
                    }
                    else
                    {
                        cmd.Parameters.Add("@TouchScreen", SqlDbType.Int).Value = 0;
                    }
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (MakeItemTouchScreen FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectAllTouchScreenItems()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Items Where TouchScreen=1", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectAllTouchScreenItems FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static Nullable<int> SelectNumberOfItems()
        {            
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select COUNT(ID) AS TotalItems from Items ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        int TestParser = 0;
                        if (int.TryParse(dt.Rows[0]["TotalItems"].ToString(), out TestParser))
                        {
                            return TestParser;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectNumberOfItems FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static double SelectOnHandQtyByItemID(int ItemID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select OnHandQty from Items Where ID=@ItemID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return double.Parse(dt.Rows[0]["OnHandQty"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Items* MGMT (SelectOnHandQtyByItemID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
    }

}

