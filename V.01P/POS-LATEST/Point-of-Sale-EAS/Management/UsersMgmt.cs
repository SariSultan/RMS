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
   public static class UsersMgmt
    {
       public static bool AddUser(Users aUsers)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO Users (Name,Address,Phone1,Phone2,UserName,Password,Description,IsAdmin) VALUES (@Name,@Address,@Phone1,@Phone2,@UserName,@Password,@Description,@IsAdmin)", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aUsers.User_Name;
                   cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = aUsers.User_Address;
                   cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aUsers.User_Phone1;
                   cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aUsers.User_Phone2;
                   cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = aUsers.User_UserName;
                   cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = aUsers.User_Password;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aUsers.User_Description;
                   cmd.Parameters.Add("@IsAdmin", SqlDbType.NVarChar).Value = 0;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (AddUser FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;
       }

       public static DataRow SelectUserByUserNameandPassword(string aUserName, string aPassword)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where UserName=@UserName and Password=@Password", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = aUserName;
                   da.SelectCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = aPassword;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count ==1)
                       return dt.Rows[0];
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (Select User By Name FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static DataRow SelectUserInfoByID(int aID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count == 1)
                       return dt.Rows[0];
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (SelectUserInfoByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static string SelectUserNameByID(int aID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select UserName from Users Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count == 1)
                       return dt.Rows[0]["UserName"].ToString();
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (SelectUserNameByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static int  SelectUserIDByUserName(string aUserName)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select ID from Users Where UserName=@UserName", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = aUserName;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count == 1)
                       return int.Parse(dt.Rows[0]["ID"].ToString());
                   else
                       return 0;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Users* MGMT (SelectUserIDByUserName FUNCTION) EX=" + ex.Message.ToString());
                   return 0;
               }
           }
           return 0;
       }

       public static DataTable SelectAllUsers()
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Users ", Helper.Instance.con);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                       return dt;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (SelectAllUsers FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static bool UpdateUser(Users aUsers)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE Users SET Name=@Name,Address=@Address,Phone1=@Phone1,Phone2=@Phone2,Password=@Password,Description=@Description WHERE ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aUsers.User_Name;
                   cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = aUsers.User_Address;
                   cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aUsers.User_Phone1;
                   cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aUsers.User_Phone2;
                   cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = aUsers.User_Password;
                   cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = aUsers.User_Description;
                   cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aUsers.User_ID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (UpdateUser FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;
       }

       public static void MakeUserAdmin(int aUsersID,int aIsAdmin)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE Users SET IsAdmin=@IsAdmin WHERE ID=@ID", Helper.Instance.con);
                   cmd.Parameters.Add("@IsAdmin", SqlDbType.Int).Value = aIsAdmin;
                   cmd.Parameters.Add("@ID", SqlDbType.Int).Value = aUsersID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Users* MGMT (MakeUserAdmin FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static bool IsUserExist(string aUserName)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Users Where UserName=@UserName", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = aUserName;
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
                   MessageBox.Show("ERROR IN *Users* MGMT ( IsUserExist FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;
       }


       public static bool IsUserAdmin(int aUserID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select IsAdmin from Users Where ID=@aUserID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@aUserID", SqlDbType.Int).Value = aUserID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       if (dt.Rows[0]["IsAdmin"].ToString()=="1")
                       {
                           return true;
                       }
                   else
                       return false;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Users* MGMT ( IsUserAdmin FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;
       }
    }
}
