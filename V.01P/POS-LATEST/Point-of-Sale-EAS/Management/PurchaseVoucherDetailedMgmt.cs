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
    public static class PurchaseVoucherDetailedMgmt
    {
        public static void AddItem(PurchaseVoucherDetailed aPurchaseVoucherDetailed)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PurchaseVoucherDetailed (ItemID,Qty,ItemCost,Discount,FreeItemsQty,VoucherNumber,OldAvgUnitCost,OldAvaQty,IsRevised) VALUES (@ItemID,@Qty,@ItemCost,@Discount,@FreeItemsQty,@VoucherNumber,@OldAvgUnitCost,@OldAvaQty,0)", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_ItemID;
                    //cmd.Parameters.Add("@Barcode", SqlDbType.NVarChar).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_Barcode;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_Qty;
                    cmd.Parameters.Add("@ItemCost", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_ItemCost;
                    cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_Discount;
                    cmd.Parameters.Add("@FreeItemsQty", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_FreeItemsQty;
                    cmd.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_VoucherNumber;
                    cmd.Parameters.Add("@OldAvgUnitCost", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_OldAvgUnitCost;
                    cmd.Parameters.Add("@OldAvaQty", SqlDbType.Float).Value = aPurchaseVoucherDetailed.Purchase_Voucher_Detailed_OldAvaQty;
                    //ISERVISED SET TO ZERO IN THE QUERY
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PurchaseVoucherDetailed* MGMT (AddItem FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectVoucherByVoucherNumber(int aVoucherNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from PurchaseVoucherDetailed where VoucherNumber=@VoucherNumber ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aVoucherNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Voucher Detailed* MGMT (SelectVoucherByBillNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static double SelectItemCostByNumber(int aItemID, int aVoucherNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ItemCost from PurchaseVoucherDetailed where VoucherNumber=@VoucherNumber and ItemID=@ItemID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aVoucherNumber;
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["ItemCost"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Voucher Detailed* MGMT (SelectItemCostByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static void MakeItemAsRevised(int aPurchaseGeneralNumber, int aItemID)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PurchaseVoucherDetailed set IsRevised=1 Where VoucherNumber=@VoucherNumber and ItemID=@ItemID", Helper.Instance.con);
                    cmd.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aPurchaseGeneralNumber;
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PurchaseVoucherDetailed* MGMT (MakeItemAsRevised Function) EX=" + ex.Message.ToString());
                }
            }
        }

        //NOT EDITED FROM HERE

        public static void DeleteVoucherByNumber(int aVoucherNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("DELETE * FROM PurchaseVoucherDetailed where VoucherNumber=@VoucherNumber ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aVoucherNumber;
                    Helper.Instance.con.Close();

                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Voucher Detailed* MGMT (DeleteVoucherByNumber FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }


        #region MULTITABLE
        public static double SelectAllPurchaseQty(int aItemID, string DateFrom, string DateTo, int IsReversed, bool BegginingBalance=false)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from PurchaseVoucherDetailed Where ItemID=@ItemID AND VoucherNumber IN (SELECT VoucherNumber FROM PurchaseVoucherGeneral WHERE 1=1  ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *PurchaseVoucherDetailedMgmt* MGMT (PurchaseVoucherDetailedMgmt FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE

    }
}
