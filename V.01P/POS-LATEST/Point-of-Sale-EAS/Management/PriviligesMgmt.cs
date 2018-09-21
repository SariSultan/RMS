using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
//----------------------------------DONT KNOW HOW TO CONTROL DIFFERENT PRIVILIGES YET ?!!!!
namespace Calcium_RMS.Management
{
   public static class PriviligesMgmt
    {
       //public static void AddNewPrivilige(Priviliges aPriviliges) 
       //{
       //    if (Helper.Instance.con.State == ConnectionState.Closed)
       //    {
       //        try
       //        {
       //            Helper.Instance.con.Open();
       //            SqlCommand cmd = new SqlCommand("INSERT INTO Priviliges (Name,Description) VALUES (@Name,@Description)", Helper.Instance.con);
       //            cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPriviliges.Priviliges_Name;
       //            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPriviliges.Priviliges_Description;                   
       //            cmd.ExecuteNonQuery();
       //            Helper.Instance.con.Close();
       //        }
       //        catch (Exception ex)
       //        {
       //            MessageBox.Show("ERROR IN *Priviliges* MGMT (AddNewPrivilige FUNCTION) EX=" + ex.Message.ToString());
       //        }
       //    }
       //}

       public static void UpdatePrivilige(Priviliges aPriviliges)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("Update Priviliges SET Name=@Name,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aPriviliges.Priviliges_Name;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aPriviliges.Priviliges_Description;
                   cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aPriviliges.Priviliges_ID;

                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Priviliges* MGMT (UpdatePriviliges FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static DataTable SelectEventIDbyUserID(int aUserID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select EventID from Priviliges Where UserID=@UserID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@UserID", SqlDbType.VarChar).Value = aUserID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                       return dt;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Priviliges* MGMT ( SelectEventIDbyUserID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static void AddPrivilige(int aUserID, int aEventID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO Priviliges (UserID,EventID) VALUES (@UserID,@EventID)", Helper.Instance.con);
                   cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = aUserID;
                   cmd.Parameters.Add("@EventID", SqlDbType.Int).Value = aEventID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Priviliges* MGMT (AddPrivilige FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static void RemovePrivilige(int aUserID, int aEventID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("Delete From Priviliges WHERE UserID=@UserID and EventID=@EventID", Helper.Instance.con);
                   cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = aUserID;
                   cmd.Parameters.Add("@EventID", SqlDbType.Int).Value = aEventID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Priviliges* MGMT (RemovePrivilige FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static bool IsPriviligeExist(int aUserID, int aEventID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Priviliges Where UserID=@UserID and EventID=@EventID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = aUserID;
                   da.SelectCommand.Parameters.Add("@EventID", SqlDbType.Int).Value = aEventID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return true;
                   else
                       return false;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Priviliges* MGMT ( IsPriviligeExist FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;
       }
    }


}
