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
    public static class WeightMgmt
    {       
        public static bool UpdateWeight(Weight aWeight)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Weight SET DivisionScale=@DivisionScale,BarcodeLength=@BarcodeLength WHERE ID=1", Helper.Instance.con);
                    cmd.Parameters.Add("@DivisionScale", SqlDbType.Int).Value = aWeight.DivisionScale;
                    cmd.Parameters.Add("@BarcodeLength", SqlDbType.Int).Value = aWeight.BarcodeLength;                    
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN WeightMgmt MGMt (UpdateWeight FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static DataRow SelectWeightRow()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from Weight", Helper.Instance.con);
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
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *SelectWeightRow* MGMT ( SelectWeightRow FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
    }
}
