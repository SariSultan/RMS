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
    public static class BillDetailedMgmt
    {
        public static void InsertItem(BillDetailed aBillDetailed)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BillDetailed (ItemID,ItemDescription,Qty,SellPrice,TotalPerUnit,Number,OldAvaQty,OldAvgUnitCost,IsRevised) VALUES (@ItemID,@ItemDescription,@Qty,@SellPrice,@TotalPerUnit,@BillNumber,@OldAvaQty,@OldAvgUnitCost,0)", Helper.Instance.con);     
                    cmd.Parameters.Add("@ItemID",SqlDbType.Int).Value=aBillDetailed.Bill_Detailed_ItemID;
                    cmd.Parameters.Add("@ItemDescription", SqlDbType.NVarChar).Value = aBillDetailed.Bill_Detailed_ItemDescription;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aBillDetailed.Bill_Detailed_Qty;
                    cmd.Parameters.Add("@SellPrice", SqlDbType.Float).Value = aBillDetailed.Bill_Detailed_SellPrice;
                    cmd.Parameters.Add("@TotalPerUnit", SqlDbType.Float).Value = aBillDetailed.Bill_Detailed_TotalPerUnit;
                    cmd.Parameters.Add("@BillNumber", SqlDbType.Int).Value = aBillDetailed.Bill_Detailed_Number;
                    cmd.Parameters.Add("@OldAvaQty", SqlDbType.Float).Value = aBillDetailed.Bill_Detailed_OldAvaQty;
                    cmd.Parameters.Add("@OldAvgUnitCost", SqlDbType.Float).Value = aBillDetailed.Bill_Detailed_OldAvgUnitCost;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();                    
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();   
                    MessageBox.Show("ERROR IN BILL DETAILED MGMG (INSERT FUNCTION) EX="+ex.Message.ToString()); 
                }
            }
        }

        public static DataTable SelectBillByBillNumber( int aBillNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from BillDetailed where Number=@Number ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *BillDetailedMgmt* MGMT (SelectBillByBillNumber FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM BillDetailed Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *BillDetailed* MGMT (DeleteByGeneralBillNumber Function) EX=" + ex.Message.ToString());
                }
            }
        }

        public static void MakeItemAsRevised(int aGeneralBillNumber, int aItemID)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE BillDetailed set IsRevised=1 Where Number =@Number and ItemID=@ItemID", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralBillNumber;
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("ERROR IN *BillDetailed* MGMT (MakeItemAsRevised Function) EX=" + ex.Message.ToString());
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
        }

        public static Double SelectOldAvgUnitCostByID(int aItemID,int aBillGeneralNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select OldAvgUnitCost from BillDetailed Where ItemID=@ItemID and Number=@Number", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aBillGeneralNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return double.Parse(dt.Rows[0]["OldAvgUnitCost"].ToString());
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *BillDetailed* MGMT (SelectOldAvgUnitCostByID FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static Double SelectAllItemsSoldAfterBillNumber(int aItemID, int aBillGeneralNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from BillDetailed Where ItemID=@ItemID and Number>@Number", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aBillGeneralNumber;
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
                    MessageBox.Show("ERROR IN *BillDetailed* MGMT (SelectAllItemsSoldAfterBillNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        #region MULTITABLE
        public static double SelectAllSoldQty(int aItemID, string DateFrom, string DateTo, int IsReversed,bool BegginingBalance=false)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from BillDetailed Where ItemID=@ItemID AND Number IN (SELECT Number FROM BillGeneral WHERE 1=1  ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = aItemID;
                    if (DateFrom!=string.Empty && DateTo!=string.Empty)
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
                    if (IsReversed!=-1)
                    {
                        da.SelectCommand.CommandText += " AND IsRevised=@IsRevised";
                        da.SelectCommand.Parameters.Add("@IsRevised", SqlDbType.Int).Value = IsReversed;
                    }
                    da.SelectCommand.CommandText +=")";
                    
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
                    MessageBox.Show("ERROR IN *BillDetailed* MGMT (SelectAllSoldQty FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE
    }
}
