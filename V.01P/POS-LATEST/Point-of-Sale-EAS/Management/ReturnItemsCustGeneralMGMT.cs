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
   public static class ReturnItemsCustGeneralMGMT
    {
       public static bool InsertBill(ReturnItemsCustGeneral aReturnItemsCustGeneral)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ReturnItemsCustGeneral (Number,Date,Time,TotalTax,TotalPrice,TotalCost,TellerID,CustomerID,PriceLevelID,Comments,DiscountPerc,TotalDiscount,AccountID,NetAmount,IsChecked,IsRevised,SubTotal,IsCashCredit,CustomerAccountAmountOld) VALUES "+
                                                                                        "(@Number,@Date,@Time,@TotalTax,@TotalPrice,@TotalCost,@TellerID,@CustomerID,@PriceLevelID,@Comments,@DiscountPerc,@TotalDiscount,@AccountID,@NetAmount,0,0,@SubTotal,@IsCashCredit,@CustomerAccountAmountOld)", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aReturnItemsCustGeneral.Number;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aReturnItemsCustGeneral.Date;
                    cmd.Parameters.Add("@Time", SqlDbType.NVarChar).Value = aReturnItemsCustGeneral.Time;

                    cmd.Parameters.Add("@TotalTax", SqlDbType.Float).Value = aReturnItemsCustGeneral.TotalTax ;

                    cmd.Parameters.Add("@TotalPrice", SqlDbType.Float).Value = aReturnItemsCustGeneral.TotalPrice;
                    cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = aReturnItemsCustGeneral.TotalCost;

                    cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aReturnItemsCustGeneral.TellerID;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aReturnItemsCustGeneral.CustomerID;
                    cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aReturnItemsCustGeneral.PriceLevel;


                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aReturnItemsCustGeneral.Comments;
                    cmd.Parameters.Add("@DiscountPerc", SqlDbType.Float).Value = aReturnItemsCustGeneral.DiscountPerc;

                    cmd.Parameters.Add("@TotalDiscount", SqlDbType.Float).Value = aReturnItemsCustGeneral.TotalDiscount;
                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aReturnItemsCustGeneral.AccountID;
                    cmd.Parameters.Add("@NetAmount", SqlDbType.Float).Value = aReturnItemsCustGeneral.NetAmount;                    
                    //ischecked isrevised is added in the sql query to 0,0
                    cmd.Parameters.Add("@SubTotal", SqlDbType.Float).Value = aReturnItemsCustGeneral.SubTotal;
                    cmd.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = aReturnItemsCustGeneral.IsCashCredit;

                    cmd.Parameters.Add("@CustomerAccountAmountOld", SqlDbType.Float).Value = aReturnItemsCustGeneral.CustomerAccountAmountOld;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN Return Items Cust General MGMT (InsertBill FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void DeleteBill(int aBillGeneralNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ReturnItemsCustGeneral Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }

        public static DataTable SelectAllBills(int FilterTellerID, string FilterDateFrom, string FilterDateTo, bool FilterCheckedBills, bool FilterIsRevised, bool FilterUnchecked, bool FilterUnRevised, int FilterCustomerID, bool FilterCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsCustGeneral where 1=1 ", Helper.Instance.con);
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
                    if (FilterCustomerID != -1)
                    {
                        da.SelectCommand.CommandText += " and CustomerID=@CustomerID";
                        da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = FilterCustomerID;
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
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (SelectAllBills FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static int NextBillNumber()
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Number) AS MAXNUM FROM ReturnItemsCustGeneral", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (NextBillNumber FUNCTION) EX=" + ex.Message.ToString());
                    return 0;
                }
            }
            return 0;
        }

        public static DataRow SelectBillByNumber(int aBillNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from ReturnItemsCustGeneral where Number=@Number", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
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
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (SelectBillByNumber FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static bool UpdateBillToChecked(string CheckedBy, string ChkDate, int aBillNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsCustGeneral SET IsChecked=1,CheckedDate=@CheckedDate,CheckedBy=@CheckedBy Where Number=@Number", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@CheckedDate", SqlDbType.Date).Value = ChkDate;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = CheckedBy;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN ReturnItemsCustGeneral MGMT (UpdateBillToChecked FUNCTION) EX=" + ex.Message.ToString());

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool UpdateBillToRevised(string RevisedBy, string ReviseDate, int aBillNumber, double aCostLoss)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ReturnItemsCustGeneral SET IsRevised=1,ReviseDate=@ReviseDate,RevisedBy=@RevisedBy Where Number=@Number", Helper.Instance.con);

                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;                    
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN ReturnItemsCustGeneral MGMT (UpdateBillToRevised FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static bool IsBillExist(int aBillNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Number from ReturnItemsCustGeneral where Number=@Number", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@Number", SqlDbType.VarChar).Value = aBillNumber;
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
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (IsBillExist FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static DataRow SelectTotalTax(string FilterDateFrom, string FilterDateTo)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(TotalPrice) AS TotalSelled" +
                        " , SUM(TotalTax) AS TaxTotal, SUM(TotalCost) AS ItemsCost from ReturnItemsCustGeneral where  (IsRevised = 0)", Helper.Instance.con);
                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
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
                    MessageBox.Show("ERROR IN *ReturnItemsCustGeneral* MGMT (SelectTotalTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectTotalCustReturns(int FilterTellerID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  COUNT(ID) AS TotalInvoices,SUM(TotalTax) AS TOTTAX, SUM(TotalCost) AS TOTCOST,SUM(TotalPrice) AS TOTPRICE FROM ReturnItemsCustGeneral WHERE IsRevised = 0 ", Helper.Instance.con);
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

                    MessageBox.Show("ERROR IN *Return items Cust General* MGMT (SelectTotalCustReturns FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
                finally
                {
                    Helper.Instance.con.Close();
                }
            }
            return null;
        }


        public static double SelectCustomersReturns(string FilterDateFrom, string FilterDateTo, int TellerID, int IsReversed, int IsCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  SUM(TotalPrice) AS TOTPRICE FROM ReturnItemsCustGeneral WHERE 1=1 ", Helper.Instance.con);
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
                        if (double.TryParse(dt.Rows[0]["TOTPRICE"].ToString(), out TestParser))
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
                    MessageBox.Show("ERROR IN *Return items Cust General* MGMT (SelectCustomersReturns FUNCTION) EX=" + ex.Message.ToString());
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
