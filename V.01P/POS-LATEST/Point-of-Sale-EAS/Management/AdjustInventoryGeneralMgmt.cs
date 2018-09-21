using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Calcium_RMS.Entities;
using System.Windows.Forms;
namespace Calcium_RMS.Management
{
   public static  class AdjustInventoryGeneralMgmt
    {
       public static bool AddAdjustGeneralItem(AdjustInventoryGeneral aAdjustGeneral)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO AdjustInventoryGeneral (Number,TellerID,Date,IsChecked) VALUES (@Number,@TellerID,@Date,@IsChecked)", Helper.Instance.con);
                   cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aAdjustGeneral.Number;
                   cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aAdjustGeneral.TellerID;
                   cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aAdjustGeneral.Date;
                   cmd.Parameters.Add("@IsChecked", SqlDbType.Int).Value = 0;
             //      cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = aAdjustGeneral.IsChecked;
               //    cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = aAdjustGeneral.CheckDate;
                //   cmd.Parameters.Add("@CheckTime", SqlDbType.NVarChar).Value = aAdjustGeneral.CheckTime;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (AddAdjustGeneralItem FUNCTION) EX=" + ex.Message.ToString());
               }
           }
           else
           {
               throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (FUNCTION:AddAdjustGeneralItem Connection Already Open)");
           }
       }

        public static DataTable SelectAllAdjustsGeneral(int GeneralNumber, string DateFrom,string DateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from AdjustInventoryGeneral WHERE 1=1 ", Helper.Instance.con);
                    if (DateFrom!=string.Empty && DateTo !=string.Empty)
                    {
                        da.SelectCommand.CommandText += " AND (Date BETWEEN @DateFrom AND @DateTo)";
                        da.SelectCommand.Parameters.Add("@DateFrom", SqlDbType.Date).Value = DateFrom;
                        da.SelectCommand.Parameters.Add("@DateTo", SqlDbType.Date).Value = DateTo;
                    }
                    if (GeneralNumber != -1)
                    {
                        da.SelectCommand.CommandText += " AND (Number=@Number)";
                        da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = GeneralNumber;
                    }
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (SelectAllAdjustsGeneral FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (SelectAllAdjustsGeneral FUNCTION Connection already open) ");
            }
        }

        public static bool CheckAdjustGeneralEntry(AdjustInventoryGeneral aAdjustGeneral)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE AdjustInventoryGeneral SET IsChecked=@IsChecked,CheckedBy=@CheckedBy,CheckDate=@CheckDate,CheckTime=@CheckTime WHERE Number=@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aAdjustGeneral.Number;
                    cmd.Parameters.Add("@IsChecked", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = aAdjustGeneral.CheckedBy;
                    cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = aAdjustGeneral.CheckDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.NVarChar).Value = aAdjustGeneral.CheckTime;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (CheckAdjustGeneralEntry FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (FUNCTION:CheckAdjustGeneralEntry Connection Already Open)");
            }
        }

        public static int NextBillNumber()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Number) AS MAXNUM FROM AdjustInventoryGeneral", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    int currentnumber;
                    if (dt.Rows[0]["MAXNUM"].ToString() != string.Empty)
                        currentnumber = Convert.ToInt32(dt.Rows[0]["MAXNUM"].ToString());
                    else
                        currentnumber = 0;
                    return currentnumber + 1;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (NextBillNumber FUNCTION) EX=" + ex.Message.ToString());
                }
            }
            else
            {
                throw new Exception("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (FUNCTION:CheckAdjustGeneralEntry Connection Already Open)");
            }
        }

        public static void DeleteAdjustEntry(int aGeneralNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM AdjustInventoryGeneral Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *AdjustInventoryGeneralMgmt* MGMT (DeleteAdjustEntry FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }
    }
}
