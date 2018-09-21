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
   public static class DisposalGeneralMgmt
    {
       public static bool InsertDisposal(DisposalGeneral aDesposalGeneral)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO DisposalGeneral (Number,Date,Time,Reason,TotalTax,TotalCost,IsRevised,IsChecked,Comments,TellerID) VALUES (@Number,@Date,@Time,@Reason,@TotalTax,@TotalCost,@IsRevised,@IsChecked,@Comments,@TellerID)", Helper.Instance.con);
                   cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aDesposalGeneral.Disposal_General_Number;

                   cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aDesposalGeneral.Disposal_General_Date;
                   cmd.Parameters.Add("@Time", SqlDbType.NVarChar).Value = aDesposalGeneral.Disposal_General_Time;
                   cmd.Parameters.Add("@Reason", SqlDbType.Int).Value = aDesposalGeneral.Disposal_General_Reason;
                   cmd.Parameters.Add("@TotalTax", SqlDbType.Float).Value = aDesposalGeneral.Disposal_General_TotalTax;
                   cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = aDesposalGeneral.Disposal_General_TotalCost;
                   cmd.Parameters.Add("@IsRevised", SqlDbType.Int).Value = 0;
                   cmd.Parameters.Add("@IsChecked", SqlDbType.Int).Value = 0;
                   cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aDesposalGeneral.Disposal_General_Comments;
                   cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aDesposalGeneral.Disposal_General_TellerID;
                   cmd.ExecuteNonQuery();
                   return true;
                   //Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN DisposalGeneral MGMT (Insert FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }

           }
           return false;
       }

       public static void DeleteDisposal(int DisposalGeneralID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("DELETE FROM DisposalGeneral Where ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@ID", SqlDbType.Int).Value = DisposalGeneralID;
                   cmd.ExecuteNonQuery();
                   //Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN DisposalGeneral MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
               }
               finally
               {
                   Helper.Instance.con.Close();
               }

           }
       }

       public static DataTable SelectAllDisposals(int FilterTellerID, string FilterDateFrom, string FilterDateTo, bool FilterCheckedBills, bool FilterIsRevised, bool FilterUnchecked, bool FilterUnRevised)
       {

           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from DisposalGeneral where 1=1 ", Helper.Instance.con);
                   if (FilterTellerID != 0)
                   {
                       da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                       da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = FilterTellerID;
                   }

                   if (FilterDateFrom != "")
                   {
                       da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                       da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                       da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                   }
                   if (FilterCheckedBills == true)
                   {
                       da.SelectCommand.CommandText += " and IsChecked=1";
                   }
                   if (FilterIsRevised == true)
                   {
                       da.SelectCommand.CommandText += " and IsRevised=1";
                   }
                   if (FilterUnchecked)
                   {
                       da.SelectCommand.CommandText += " and IsChecked=0";

                   }
                   if (FilterUnRevised)
                   {
                       da.SelectCommand.CommandText += " and IsRevised=0";

                   }
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt;
               }
               catch (Exception ex)
               {

                   MessageBox.Show("ERROR IN *DisposalGeneral* MGMT (SelectAllDisposals FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }
           }
           return null;
       }


       public static int NextDisposalNumber()
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Number) AS MAXNUM FROM DisposalGeneral", Helper.Instance.con);
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
                   MessageBox.Show("ERROR IN *DisposalGeneral* MGMT (NextDisposalNumber FUNCTION) EX=" + ex.Message.ToString());
                   return 0;
               }
               finally
               {
                   Helper.Instance.con.Close();

               }
           }
           return 0;
       }

       public static DataRow SelectDisposalByNumber(int aDisposalNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from DisposalGeneral where Number=@Number", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aDisposalNumber;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return dt.Rows[0];
                   else
                       return null;
               }
               catch (Exception ex)
               {

                   MessageBox.Show("ERROR IN *DisposalGeneral* MGMT (SelectDisposalByNumber FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }
           }
           return null;
       }

       public static bool UpdateDisposalToChecked(string CheckedBy, string ChkDate, int aDisposalNumber)
       {
           if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE DisposalGeneral SET IsChecked=1,CheckedDate=@CheckedDate,CheckedBy=@CheckedBy Where Number=@Number", Helper.Instance.con);


                   cmd.Parameters.Add("@CheckedDate", SqlDbType.Date).Value = ChkDate;
                   cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = CheckedBy;
                   cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aDisposalNumber;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN Disposal General MGMT (UpdateDisposalToChecked FUNCTION) EX=" + ex.Message.ToString());

                   return false;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }
           }
           else
           {
               return false;
           }
       }

       public static bool UpdateDisposalToRevised(string RevisedBy, string ReviseDate, int aDisposalNumber)
       {
           if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE DisposalGeneral SET IsRevised=1,ReviseDate=@ReviseDate,RevisedBy=@RevisedBy Where Number=@Number", Helper.Instance.con);

                   cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                   cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                   cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aDisposalNumber;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN DisposalGeneral MGMT (UpdateDisposalToRevised FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }
           }
           return false;
       }

       public static DataRow SelectTotalDisposals(int FilterTellerID, string FilterDateFrom, string FilterDateTo)
       {

           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("SELECT  COUNT(ID) AS TotalInvoices,SUM(TotalTax) AS TOTTAX, SUM(TotalCost) AS TOTCOST FROM DisposalGeneral WHERE IsRevised = 0 ", Helper.Instance.con);
                   if (FilterTellerID > 0)
                   {
                       da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                       da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = FilterTellerID;
                   }

                   if (FilterDateFrom != "")
                   {
                       da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                       da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                       da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                   }
                   
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt.Rows[0];
               }
               catch (Exception ex)
               {

                   MessageBox.Show("ERROR IN *DisposalGeneral* MGMT (SelectAllDisposals FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
               finally
               {
                   Helper.Instance.con.Close();
               }
           }
           return null;
       }

      
    }
}
