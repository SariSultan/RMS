using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Calcium_RMS.Management
{
    public static class AdjustInventoryDetailedMgmt
    {
        public static bool AddAdjustDetailedItem(AdjustInventoryDetailed aAdjustDetailed)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO AdjustInventoryDetailed (Number, ItemID  ,OldQty, NewQty,DifferenceQty,DifferenceValue) VALUES (@Number,@ItemID,@OldQty,@NewQty,@DifferenceQty,@DifferenceValue)", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aAdjustDetailed.Number;
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aAdjustDetailed.ItemID;
                    cmd.Parameters.Add("@OldQty", SqlDbType.Float).Value = aAdjustDetailed.OldQty;
                    cmd.Parameters.Add("@NewQty", SqlDbType.Float).Value = aAdjustDetailed.NewQty;
                    cmd.Parameters.Add("@DifferenceQty", SqlDbType.Float).Value = aAdjustDetailed.DifferenceQty;
                    cmd.Parameters.Add("@DifferenceValue", SqlDbType.Float).Value = aAdjustDetailed.DifferenceValue;
                    
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (AddAdjust FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (Connection Already Open)");
            }

        }

        public static bool UpdateDetailedSingleEntry(AdjustInventoryDetailed aAdjustDetailed)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AdjustInventoryDetailed SET OldQty=@OldQty,NewQty=@NewQty,DifferenceQty=@DifferenceQty,DifferenceValue=@DifferenceValue WHERE ItemID=@ItemID AND Number=@Number ", Helper.Instance.con);
                    cmd.Parameters.Add("@OldQty", SqlDbType.Float).Value = aAdjustDetailed.OldQty;
                    cmd.Parameters.Add("@NewQty", SqlDbType.Float).Value = aAdjustDetailed.NewQty;
                    cmd.Parameters.Add("@DifferenceQty", SqlDbType.Float).Value = aAdjustDetailed.DifferenceQty;
                    cmd.Parameters.Add("@DifferenceValue", SqlDbType.Float).Value = aAdjustDetailed.DifferenceValue;
                    
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aAdjustDetailed.ItemID;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aAdjustDetailed.Number;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (UpdateDetailedSingleEntry FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (UpdateDetailedSingleEntry FUNCTION Connection already open) ");
            }
        }

        public static DataTable SelectAllAdjustsDetailed(int GeneralNumber, int ItemID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from AdjustInventoryDetailed WHERE 1=1 ", Helper.Instance.con);
                    if (GeneralNumber != -1)
                    {
                        da.SelectCommand.CommandText += " AND ( Number = @Number) ";
                        da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = GeneralNumber;
                    }
                    if (ItemID != -1)
                    {
                        da.SelectCommand.CommandText += " AND (ItemID=@ItemID)";
                        da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    }
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (SelectAllAdjustsDetailed FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (SelectAllAdjustsDetailed FUNCTION Connection already open) ");
            }

        }

        public static void DeleteDetailedEntries(int aGeneralNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AdjustInventoryDetailed Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (DeleteDetailedEntries FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }
        public static void DeleteDetailedEntries(int aGeneralNumber,int ItemID)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AdjustInventoryDetailed Where Number =@Number AND ItemID=@ItemID", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralNumber;
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (DeleteDetailedEntries FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectAllAdjustsDetailedSUMValue(int GeneralNumber, int ItemID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(DifferenceValue) AS DifferenceValue,Number from AdjustInventoryDetailed WHERE 1=1 ", Helper.Instance.con);
                    if (GeneralNumber != -1)
                    {
                        da.SelectCommand.CommandText += " AND ( Number = @Number) ";
                        da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = GeneralNumber;
                    }
                    if (ItemID != -1)
                    {
                        da.SelectCommand.CommandText += " AND (ItemID=@ItemID)";
                        da.SelectCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = ItemID;
                    }
                    da.SelectCommand.CommandText += " GROUP BY Number";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (SelectAllAdjustsDetailed FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (SelectAllAdjustsDetailed FUNCTION Connection already open) ");
            }

        }

        #region MULTITABLE
        public static double SelectAllAdjustQty(int aItemID, string DateFrom, string DateTo, int IsReversed, bool BegginingBalance=false)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(DifferenceQty) AS SUM from AdjustInventoryDetailed Where ItemID=@ItemID AND Number IN (SELECT Number FROM AdjustInventoryGeneral WHERE 1=1  ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *AdjustInventoryDetailedMgmt* MGMT (SelectAllAdjustQty FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE

    }
}
