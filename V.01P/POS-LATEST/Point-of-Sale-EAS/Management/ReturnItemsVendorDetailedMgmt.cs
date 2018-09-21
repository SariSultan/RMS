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
    public static class ReturnItemsVendorDetailedMgmt
    {
        public static void AddItem(ReturnItemsVendorDetailed aReturnItemsVendorDetailed)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ReturnItemsVendorDetailed (ItemID,Qty,ItemCost,Discount,FreeItemsQty,Number,OldAvgUnitCost,OldAvaQty,IsRevised) VALUES "+
                                                                                            "(@ItemID,@Qty,@ItemCost,@Discount,@FreeItemsQty,@Number,@OldAvgUnitCost,@OldAvaQty,0)", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aReturnItemsVendorDetailed.ItemID;

                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aReturnItemsVendorDetailed.Qty;
                    cmd.Parameters.Add("@ItemCost", SqlDbType.Float).Value = aReturnItemsVendorDetailed.ItemCost;
                    cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = aReturnItemsVendorDetailed.Discount;
                    cmd.Parameters.Add("@FreeItemsQty", SqlDbType.Float).Value = aReturnItemsVendorDetailed.FreeItemsQty;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aReturnItemsVendorDetailed.Number;
                    cmd.Parameters.Add("@OldAvgUnitCost", SqlDbType.Float).Value = aReturnItemsVendorDetailed.OldAvgUnitCost;
                    cmd.Parameters.Add("@OldAvaQty", SqlDbType.Float).Value = aReturnItemsVendorDetailed.OldAvaQty;
                    //ISERVISED SET TO ZERO IN THE QUERY
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailed* MGMT (AddItem FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectItemsByNumber(int aVoucherNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsVendorDetailed where Number=@Number ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aVoucherNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailed* MGMT (SelectItemsByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static double SelectItemCostByNumber(int aItemID, int aNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ItemCost from ReturnItemsVendorDetailed where Number=@Number and ItemID=@ItemID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aNumber;
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["ItemCost"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailed* MGMT (SelectItemCostByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static void MakeItemAsRevised(int aGeneralNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsVendorDetailed set IsRevised=1 Where Number=@Number ", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailed* MGMT (MakeItemAsRevised Function) EX=" + ex.Message.ToString());
                }
            }
        }

        //NOT EDITED FROM HERE

        public static void DeleteItemsByNumber(int aNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("DELETE * FROM ReturnItemsVendorDetailed where Number=@Number ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aNumber;
                    Helper.Instance.con.Close();

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailed* MGMT (DeleteItemsByNumber FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        #region MULTITABLE
        public static double SelectAllReturnedQty(int aItemID, string DateFrom, string DateTo, int IsReversed, bool BegginingBalance=false)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from ReturnItemsVendorDetailed Where ItemID=@ItemID AND Number IN (SELECT Number FROM ReturnItemsVendorGeneral WHERE 1=1  ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *ReturnItemsVendorDetailedMgmt* MGMT (SelectAllReturnedQty FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE
    }
}
