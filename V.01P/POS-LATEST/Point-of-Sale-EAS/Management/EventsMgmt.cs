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
    public static class EventsMgmt
    {
        public static int SelectEventIDbyName(string aName)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select ID from Events Where Name=@Name", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = aName;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt.Rows.Count > 0)
                        return int.Parse(dt.Rows[0]["ID"].ToString());
                    else
                        return 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *Events* MGMT ( SelectEventIDbyName FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }
    }
}
