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
    public static class VendorsMgmt
    {
        public static bool AddVendor(Vendors aVendors)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Vendors (Name,Location,Phone1,Phone2,Email,Company,StartDate) VALUES (@Name,@Location,@Phone1,@Phone2,@Email,@Company,@StartDate)", Helper.Instance.con);
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = aVendors.Vendor_Name;
                    cmd.Parameters.Add("@Location", SqlDbType.NVarChar).Value = aVendors.Vendor_Location;
                    cmd.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aVendors.Vendor_Phone1;
                    cmd.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aVendors.Vendor_Phone2;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = aVendors.Vendor_Email;
                    cmd.Parameters.Add("@Company", SqlDbType.NVarChar).Value = aVendors.Vendor_Company;
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = aVendors.Vendor_Start_Date;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Vendors* MGMT (AddVendor FUNCTION) EX=" + ex.Message.ToString());
                    Helper.Instance.con.Close();
                    return false;
                }
            }
            return false;
        }

        public static string SelectVendorByID(int aID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Name from Vendors Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0]["Name"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Vendors* MGMT (SelectVendorByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static int SelectVendorIDByName(string aVendorName)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Vendors Where Name=@Name", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = aVendorName;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return int.Parse(dt.Rows[0]["ID"].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Vendors* MGMT (SelectVendorIDByName FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static DataRow SelectVendorRowByName(string aVendorName)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Vendors Where Name=@Name", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = aVendorName;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if(dt.Rows.Count==1)
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Vendors* MGMT (SelectVendorRowByName FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataRow SelectVendorRowByID(int aVendorID)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Vendors Where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aVendorID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count == 1)
                        return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Vendors* MGMT (SelectVendorRowByID FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static bool IsVendorExist(string aVendorName)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Vendors Where Name=@Name", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = aVendorName;
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
                    MessageBox.Show("ERROR IN *Vendors* MGMT (IsVendorExist FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static DataTable SelectAllVendors()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Vendors", Helper.Instance.con);
                    //da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Vendors* MGMT (SelectAllVendors FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static bool UpdateVendorByName(string aOldName,Vendors aVendors)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("UPDATE Vendors SET Name=@Name,Location=@Location,Phone1=@Phone1,Phone2=@Phone2,Email=@Email,Company=@Company Where Name=@aOldName", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@aOldName", SqlDbType.VarChar).Value = aOldName;
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = aVendors.Vendor_Name;
                    da.SelectCommand.Parameters.Add("@Location", SqlDbType.NVarChar).Value = aVendors.Vendor_Location;
                    da.SelectCommand.Parameters.Add("@Phone1", SqlDbType.NVarChar).Value = aVendors.Vendor_Phone1;
                    da.SelectCommand.Parameters.Add("@Phone2", SqlDbType.NVarChar).Value = aVendors.Vendor_Phone2;
                    da.SelectCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = aVendors.Vendor_Email;
                    da.SelectCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = aVendors.Vendor_Company;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Vendors* MGMT (UpdateVendorByName FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
    }
}
