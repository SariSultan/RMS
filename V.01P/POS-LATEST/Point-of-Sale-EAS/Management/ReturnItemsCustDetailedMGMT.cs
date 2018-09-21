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
    public static class ReturnItemsCustDetailedMGMT
    {
        public static void InsertItem(ReturnItemsCustDetailed aReturnItemsCustDetailed)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ReturnItemsCustDetailed (ItemID,ItemDescription,Qty,SellPrice,TotalPerUnit,Number,OldAvaQty,OldAvgUnitCost,IsRevised) VALUES (@ItemID,@ItemDescription,@Qty,@SellPrice,@TotalPerUnit,@Number,@OldAvaQty,@OldAvgUnitCost,0)", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aReturnItemsCustDetailed.ItemID;
                    cmd.Parameters.Add("@ItemDescription", SqlDbType.NVarChar).Value = aReturnItemsCustDetailed.ItemDescription;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aReturnItemsCustDetailed.Qty;
                    cmd.Parameters.Add("@SellPrice", SqlDbType.Float).Value = aReturnItemsCustDetailed.SellPrice;
                    cmd.Parameters.Add("@TotalPerUnit", SqlDbType.Float).Value = aReturnItemsCustDetailed.TotalPerUnit;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aReturnItemsCustDetailed.Number;
                    cmd.Parameters.Add("@OldAvaQty", SqlDbType.Float).Value = aReturnItemsCustDetailed.OldAvaQty;
                    cmd.Parameters.Add("@OldAvgUnitCost", SqlDbType.Float).Value = aReturnItemsCustDetailed.OldAvgUnitCost;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN Return Items Cust Detailed MGMG (InsertItem FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectBillByBillNumber(int aBillNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsCustDetailed where Number=@Number ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Return Items Cust Detailed* MGMT (SelectBillByBillNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static void DeleteByGeneralBillNumber(int aGeneralBillNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ReturnItemsCustDetailed Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Return Items Cust Detailed* MGMT (DeleteByGeneralBillNumber Function) EX=" + ex.Message.ToString());
                }
            }
        }

        public static void MakeItemsAsRevised(int aGeneralBillNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsCustDetailed set IsRevised=1 Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR IN *Return Items Cust Detailed* MGMT (MakeItemAsRevised Function) EX=" + ex.Message.ToString());
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
        }


        #region MULTITABLE
        public static double SelectAllReturnedQty(int aItemID, string DateFrom, string DateTo, int IsReversed,bool BegginingBalance =false)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from ReturnItemsCustDetailed Where ItemID=@ItemID AND Number IN (SELECT Number FROM ReturnItemsCustGeneral WHERE 1=1  ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    if (DateFrom != string.Empty && DateTo != string.Empty)
                    {
                        if (BegginingBalance)
                        {
                            da.SelectCommand.CommandText += "AND Date < @DateFrom ";
                            da.SelectCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom;
                        }
                        else
                        {
                            da.SelectCommand.CommandText += "AND Date BETWEEN @DateFrom AND @DateTo";
                            da.SelectCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom;
                            da.SelectCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = DateTo;
                        }
                    }
                    if (IsReversed != -1)
                    {
                        da.SelectCommand.CommandText += " AND IsRevised=@IsRevised ";
                        da.SelectCommand.Parameters.Add("@IsRevised", SqlDbType.Int).Value = IsReversed;
                    }
                    da.SelectCommand.CommandText += ")";

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows[0]["SUM"].ToString() != null && dt.Rows[0]["SUM"].ToString() != "")
                        return double.Parse(dt.Rows[0]["SUM"].ToString());
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *SelectAllReturnedQty* MGMT (SelectAllReturnedQty FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE
    }
}
