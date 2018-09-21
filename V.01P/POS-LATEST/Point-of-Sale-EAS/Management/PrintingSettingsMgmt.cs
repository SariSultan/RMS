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
    public static class PrintingSettingsMgmt
    {
        public static DataTable SelectBillsHeaders(int HeaderOrFooter, int BillOrReport)//01 01
        {
            List<string> aStringList = new List<string>();
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select *  from PrintingSettings WHERE BillOrReport=@BillOrReport and HeaderOrFooter=@HeaderOrFooter ORDER BY Number", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@BillOrReport", SqlDbType.Int).Value = BillOrReport;
                    da.SelectCommand.Parameters.Add("@HeaderOrFooter", SqlDbType.Int).Value = HeaderOrFooter;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count>0)
                    {
                        return dt;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PrintingSettings* MGMT (SelectBillsHeaders FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static void InsertLine(PrintingSettings aPrintingSetting)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PrintingSettings SET Data=@Data WHERE HeaderOrFooter=@HeaderOrFooter AND BillOrReport=@BillOrReport AND Number=@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@HeaderOrFooter", SqlDbType.Int).Value = aPrintingSetting.HeaderOrFooter;
                    cmd.Parameters.Add("@Data", SqlDbType.NVarChar).Value = aPrintingSetting.Data;
                    cmd.Parameters.Add("@BillOrReport", SqlDbType.Int).Value = aPrintingSetting.BillOrReport;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aPrintingSetting.Number;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN PrintingSettingsMgmt MGMt (InsertLine FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }     
    }
}
