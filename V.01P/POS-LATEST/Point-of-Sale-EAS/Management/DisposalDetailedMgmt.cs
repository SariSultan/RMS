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
    public static class DisposalDetailedMgmt
    {
        public static void InsertDisposalItem(DisposalDetailed aDesposalDetailed)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO DisposalDetailed (ItemID,ItemDescription,Qty,UnitCost,Date,TotalPerUnit,GeneralNumber,IsRevised) VALUES"+
                                                                                "(@ItemID,@ItemDescription,@Qty,@UnitCost,@Date,@TotalPerUnit,@GeneralNumber,@IsRevised)", Helper.Instance.con);
                    cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = aDesposalDetailed.Disposal_Detailed_ItemID;
                    cmd.Parameters.Add("@ItemDescription", SqlDbType.NVarChar).Value = aDesposalDetailed.Disposal_Detailed_ItemDescription;
                    cmd.Parameters.Add("@Qty", SqlDbType.Float).Value = aDesposalDetailed.Disposal_Detailed_Qty;
                    cmd.Parameters.Add("@UnitCost", SqlDbType.Float).Value = aDesposalDetailed.Disposal_Detailed_UnitCost;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aDesposalDetailed.Disposal_Detailed_Date;
                    cmd.Parameters.Add("@TotalPerUnit", SqlDbType.Float).Value = aDesposalDetailed.Disposal_Detailed_TotalPerUnit;
                    cmd.Parameters.Add("@GeneralNumber", SqlDbType.Int).Value = aDesposalDetailed.Disposal_Detailed_GeneralNumber;
                    cmd.Parameters.Add("@IsRevised", SqlDbType.Int).Value = 0;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN DisposalDetailed MGMT (InsertItem FUNCTION) EX=" + ex.Message);
                }
                finally 
                { Helper.Instance.con.Close(); }

            }
        }

        public static void DeleteDisposalItemsByGeneralNum(int aDisposalGeneralNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM DisposalDetailed WHERE GeneralNumber=@GeneralNumber)", Helper.Instance.con);
                    cmd.Parameters.Add("@GeneralNumber", SqlDbType.Int).Value = aDisposalGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN DisposalDetailed MGMT (DeleteDisposalItemsByGeneralNum FUNCTION) EX=" + ex.Message.ToString());
                }
                finally
                { Helper.Instance.con.Close(); }
            }
        }

        public static DataTable SelectDisposalByGeneralNumber(int aGeneralDisposalNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from BillDetailed where GeneralNumber=@GeneralNumber ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@GeneralNumber", SqlDbType.Int).Value = aGeneralDisposalNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("ERROR IN *Disposal Detaield* MGMT (SelectDisposalByGeneralNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
            return null;
        }
    

        public static void MakeItemsReveresed(int aGeneralDisposalNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE DisposalDetailed set IsRevised=1 Where GeneralNumberNumber =@GeneralNumber", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralDisposalNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Disposal Detailed* MGMT (MakeItemsReveresed Function) EX=" + ex.Message.ToString());
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
                  
            }
        }


        #region MULTITABLE
        public static double SelectAllDisposedQty(int aItemID, string DateFrom, string DateTo, int IsReversed, bool BegginingBalance=false)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(Qty) AS SUM from DisposalDetailed Where ItemID=@ItemID AND GeneralNumber IN (SELECT Number AS GeneralNumber FROM DisposalGeneral WHERE 1=1  ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *DisposalDetailedMgmt* MGMT (SelectAllDisposedQty FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
        #endregion MULTITABLE
    }
}
