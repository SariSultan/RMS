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
    public static class DisposalReasonMgmt
    {

        public static Nullable<int> AddDisposalReason(DisposalReason aDisposalReason)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO DisposalReason (Name,Comment) VALUES (@Name,@Comment)", Helper.Instance.con);
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = aDisposalReason.Disposal_Detailed_Name;
                    cmd.Parameters.Add("@Comment", SqlDbType.NVarChar).Value = aDisposalReason.Disposal_Detailed_Comment;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return 1;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN DisposalReason MGMT (AddDisposalReason FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }

            }
            else
            {
                return null;
            }
        }

        public static string SelectDescriptionByID(int aDisposalReasonID)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Comment from DisposalReason where ID=@ID", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = aDisposalReasonID;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count == 1)
                    {
                        return dt.Rows[0]["Comment"].ToString();
                    }
                    else
                    {
                        return "-1";
                    }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN DisposalReason MGMT (AddDisposalReason FUNCTION) EX=" + ex.Message.ToString());
                    return "0";
                }
            }
            else
            {
                return null;
            }
        }
    }
}
