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
   public static class CustomerMgmt
    {
       public static bool InsertCustomer(Customer aCustomer)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO Customer (Name,Email,Address,Phone1) VALUES (@Name,@Email,@Address,@Phone1)", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aCustomer.Customer_Name;
                   cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = aCustomer.Customer_Email;
                   cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = aCustomer.Customer_Address;
                   cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aCustomer.Customer_Phone1;
                 //  cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aCustomer.Customer_Phone2;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close(); 
                   MessageBox.Show("ERROR IN CUSTOMER MGMT (Insert FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }               
           }
           return false;
       }

       public static void DeleteCustomer(Customer aCustomer)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("DELETE FROM Customer Where CustomerID=@CustomerID)", Helper.Instance.con);
                   cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomer.Customer_ID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN CUSTOMER MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
               }
           }
       }

       public static bool UpdateInfomationByID(Customer aCustomer)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name=@Name,Email=@Email,Address=@Address,Phone1=@Phone1 WHERE ID=@CustomerID", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aCustomer.Customer_Name;
                   cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = aCustomer.Customer_Email;
                   cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = aCustomer.Customer_Address;
                   cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aCustomer.Customer_Phone1;
                   cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aCustomer.Customer_ID;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
                   return true;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN CUSTOMER MGMT (Update FUNCTION) EX=" + ex.Message.ToString());
                   return false;
               }
           }
           return false;

       }

       public static bool IsPhoneUsed(string aNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer Where Phone1=@Phone1", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Phone1", SqlDbType.VarChar).Value = aNumber ;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return (dt.Rows.Count > 0);
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Customers* MGMT (IsPhoneUsed FUNCTION) EX=" + ex.Message.ToString());
                   return false ;
               }
           }
           return true;
       }

       public static DataRow SelectCustomerByPhone1(string aNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer Where Phone1=@Phone1", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Phone1", SqlDbType.VarChar).Value = aNumber;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count>0)
                   {
                       return dt.Rows[0];
                   }
                   else
                   {
                       return null;
                   }
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerByPhone1 FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static DataRow SelectCustomerRowByPhone1(string aNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer Where Phone1=@Phone1", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Phone1", SqlDbType.VarChar).Value = aNumber;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count>0)
                   {
                       return dt.Rows[0]; 
                   }
                   else
                   {
                       return null;
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerByPhone1 FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static int SelectCustomerIDByPhone1(string aNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select ID from Customer Where Phone1=@Phone1", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Phone1", SqlDbType.VarChar).Value = aNumber;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return int.Parse(dt.Rows[0]["ID"].ToString());
                   else
                       return -1;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerIDByPhone1 FUNCTION) EX=" + ex.Message.ToString());
                   return -1;
               }
           }
           return -1;
       }

       public static string SelectCustomerPhone1ByID(int aID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select Phone1 from Customer Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count > 0)
                       return dt.Rows[0]["Phone1"].ToString();
                   else
                       return null;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerPhone1ByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }



       public static DataTable SelectCustomerByPhone2(string aNumber)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer Where Phone2=@Phone2", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@Phone2", SqlDbType.VarChar).Value = aNumber;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt;
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerByPhone2 FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static DataTable SelectAllCustomers()
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer ", Helper.Instance.con);                                     
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   return dt;
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Customers* MGMT (Select All Customers FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }

       public static void FillDataSet(DBDataSet aDBDataSet)
       {
           try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer ", Helper.Instance.con);                                     
                   da.Fill(aDBDataSet,"Customer");
                   Helper.Instance.con.Close();
                   
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN *Customers* MGMT (FillDataSet FUNCTION) EX=" + ex.Message.ToString());
                   
               }
           }

       public static DataRow SelectCustomerRowByID(int aID)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlDataAdapter da = new SqlDataAdapter("Select * from Customer Where ID=@ID", Helper.Instance.con);
                   da.SelectCommand.Parameters.Add("@ID", SqlDbType.VarChar).Value = aID;
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   Helper.Instance.con.Close();
                   if (dt.Rows.Count>0)
                   {
                       return dt.Rows[0]; 
                   }
                   else
                   {
                       return null;
                   }
               }
               catch (Exception ex)
               {
                   Helper.Instance.con.Close();
                   MessageBox.Show("ERROR IN *Customers* MGMT (SelectCustomerRowByID FUNCTION) EX=" + ex.Message.ToString());
                   return null;
               }
           }
           return null;
       }



       //ayman
       public static void InsertCustomerTest(Customer aCustomer)
       {
           if (Helper.Instance.con.State == ConnectionState.Closed)
           {
               try
               {
                   Helper.Instance.con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO Customer (Name,Phone1) VALUES (@Name,@Phone1)", Helper.Instance.con);
                   cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aCustomer.Customer_Name;
                   //cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = aCustomer.Customer_Email;
                   //cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = aCustomer.Customer_Address;
                   cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aCustomer.Customer_Phone1;
                   //  cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aCustomer.Customer_Phone2;
                   cmd.ExecuteNonQuery();
                   Helper.Instance.con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show("ERROR IN CUSTOMER MGMT (InsertCustomerTest FUNCTION) EX=" + ex.Message.ToString());
               }

           }
       }

       }
    }

