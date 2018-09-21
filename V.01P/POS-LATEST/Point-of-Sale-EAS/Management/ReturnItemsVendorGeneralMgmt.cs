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
    public static class ReturnItemsVendorGeneralMgmt
    {
        public static bool AddVoucher(ReturnItemsVendorGeneral aReturnItemsVendorGeneral)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ReturnItemsVendorGeneral " +
                        "(Number,Date,Time,VendorID" +
                    ",TotalTax,Subtotal,DiscountPerc,TotalItemsDiscount,TotalDiscount" +
                    ",TotalCost,TellerID,Comments" +
                    ",AccountID,IsCashCredit,VendorAccountAmountOld" +
                    ",IsChecked,CheckedBy,CheckTime,IsRevised" +
                    ",RevisedBy,ReviseTime,Fees)" +
                    " VALUES " +
                    "(@Number,@Date,@Time,@VendorID" +
                    ",@TotalTax,@Subtotal,@DiscountPerc,@TotalItemsDiscount,@TotalDiscount" +
                    ",@TotalCost,@TellerID,@Comments" +
                    ",@AccountID,@IsCashCredit,@VendorAccountAmountOld" +
                    ",@IsChecked,@CheckedBy,@CheckTime,@IsRevised" +
                    ",@RevisedBy,@ReviseTime,@Fees)", Helper.Instance.con);

                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aReturnItemsVendorGeneral.Number;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aReturnItemsVendorGeneral.Date;
                    cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = aReturnItemsVendorGeneral.Time;
                    cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = aReturnItemsVendorGeneral.VendorID;

                    cmd.Parameters.Add("@TotalTax", SqlDbType.Float).Value = aReturnItemsVendorGeneral.TotalTax;
                    cmd.Parameters.Add("@Subtotal", SqlDbType.Float).Value = aReturnItemsVendorGeneral.Subtotal;
                    cmd.Parameters.Add("@DiscountPerc", SqlDbType.Float).Value = aReturnItemsVendorGeneral.DiscountPerc;
                    cmd.Parameters.Add("@TotalItemsDiscount", SqlDbType.Float).Value = aReturnItemsVendorGeneral.TotalItemsDiscount;
                    cmd.Parameters.Add("@TotalDiscount", SqlDbType.Float).Value = aReturnItemsVendorGeneral.TotalDiscount;

                    cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = aReturnItemsVendorGeneral.TotalCost;
                    cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aReturnItemsVendorGeneral.TellerID;
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aReturnItemsVendorGeneral.Comments;

                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aReturnItemsVendorGeneral.AccountID;
                    cmd.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = aReturnItemsVendorGeneral.IsCashCredit;
                    cmd.Parameters.Add("@VendorAccountAmountOld", SqlDbType.Float).Value = aReturnItemsVendorGeneral.VendorAccountAmountOld;

                    cmd.Parameters.Add("@IsChecked", SqlDbType.Int).Value = 0;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = "";// aPurchaseVoucherGeneral.CheckedBy;
                    //cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = "";//aPurchaseVoucherGeneral.CheckDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.VarChar).Value = "";//aPurchaseVoucherGeneral.CheckTime;
                    cmd.Parameters.Add("@IsRevised", SqlDbType.Int).Value = 0;

                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = "";//aPurchaseVoucherGeneral.RevisedBy;
                    //cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = "";//aPurchaseVoucherGeneral.ReviseDate;
                    cmd.Parameters.Add("@ReviseTime", SqlDbType.VarChar).Value = "";//aPurchaseVoucherGeneral.ReviseTime;
                    cmd.Parameters.Add("@Fees", SqlDbType.Float).Value = aReturnItemsVendorGeneral.Fees;
                    
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (AddVoucher FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static int NextReturnVendorNumber()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Number) AS MAXNUM FROM ReturnItemsVendorGeneral ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (NextReturnVendorNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;

                }
            }
            return 0;
        }

        public static DataTable SelectAllVouchers()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsVendorGeneral ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (SelectAllVouchers FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectGeneralVoucherByNumber(int aNumber)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsVendorGeneral where Number=@Number  ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (SelectGeneralVoucherByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable SelectAllVouchers(int FilterTellerID, string FilterDateFrom, string FilterDateTo, bool FilterChecked, bool FilterRevised, bool FilterUnChecked, bool FilterUnRevised, int FilterVendorID, bool FilterCashCredit)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsVendorGeneral WHERE 1=1 ", Helper.Instance.con);
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
                    if (FilterChecked == true)
                    {
                        da.SelectCommand.CommandText += " and IsChecked=1";
                    }
                    if (FilterRevised == true)
                    {
                        da.SelectCommand.CommandText += " and IsRevised=1";
                    }
                    if (FilterUnChecked)
                    {
                        da.SelectCommand.CommandText += " and IsChecked=0";

                    }
                    if (FilterUnRevised)
                    {
                        da.SelectCommand.CommandText += " and IsRevised=0";

                    }
                    if (FilterVendorID != -1)
                    {
                        da.SelectCommand.CommandText += " and VendorID=@VendorID";
                        da.SelectCommand.Parameters.Add("@VendorID", SqlDbType.Int).Value = FilterVendorID;
                    }
                    if (FilterCashCredit)
                    {
                        da.SelectCommand.CommandText += " and IsCashCredit=1";
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (SelectAllVouchers(Vars) FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static bool UpdateVoucherChecked(string CheckedBy, string ChkDate, string ChkTime, int aBillNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsVendorGeneral SET IsChecked=1,CheckDate=@CheckDate,CheckedBy=@CheckedBy,CheckTime=@CheckTime Where Number=@Number", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = ChkDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.NVarChar).Value = ChkDate;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = CheckedBy;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (UpdateVoucherChecked FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
        public static bool UpdateVoucherToRevised(string RevisedBy, string ReviseDate, string ReviseTime, int aBillNumber, double aCostLoss)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsVendorGeneral SET IsRevised=1,ReviseDate=@ReviseDate,ReviseTime=@ReviseTime,RevisedBy=@RevisedBy Where Number=@Number", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                    cmd.Parameters.Add("@ReviseTime", SqlDbType.NVarChar).Value = ReviseTime;
                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (UpdateVoucherToRevised FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void DeleteVoucher(int aNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ReturnItemsVendorGeneral Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Float).Value = aNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsVendorGeneral* MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataRow SelectTotalVendorReturns(int FilterTellerID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  COUNT(ID) AS TotalInvoices,SUM(TotalTax) AS TOTTAX, SUM(TotalCost) AS TOTCOST FROM ReturnItemsVendorGeneral WHERE IsRevised = 0 ", Helper.Instance.con);
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

                    MessageBox.Show("ERROR IN *ReturnItemsVendortGeneral* MGMT (SelectTotalVendorReturns FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
            return null;
        }


        public static double SelectVendorReturns(string FilterDateFrom, string FilterDateTo, int TellerID, int IsReversed, int IsCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT   SUM(TotalCost) AS TOTCOST FROM ReturnItemsVendorGeneral WHERE 1 = 1 ", Helper.Instance.con);
                    if (FilterDateFrom != "" && FilterDateTo != "")
                    {
                        da.SelectCommand.CommandText += " AND Date>=@FilterDateFrom AND Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    if (TellerID != -1)
                    {
                        da.SelectCommand.CommandText += " AND TellerID=@TellerID";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = TellerID;
                    }
                    if (IsReversed != -1)
                    {
                        da.SelectCommand.CommandText += " AND IsRevised=@IsRevised";
                        da.SelectCommand.Parameters.Add("@IsRevised", SqlDbType.Int).Value = IsReversed;
                    }

                    if (IsCashCredit != -1)
                    {
                        da.SelectCommand.CommandText += " AND IsCashCredit=@IsCashCredit";
                        da.SelectCommand.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = IsCashCredit;
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt == null)
                    {
                        return 0.00;
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        double TestParser = 0.00;
                        if (double.TryParse(dt.Rows[0]["TOTCOST"].ToString(), out TestParser))
                        {
                            return TestParser;
                        }
                        else
                        {
                            return 0.00;
                        }
                    }
                    else
                    { return 0.00; }
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Return items Vendor General* MGMT (SelectVendorReturns FUNCTION) EX=" + ex.Message.ToString());
                    return 0.00;
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
            return 0.00;
        }
    }
}
