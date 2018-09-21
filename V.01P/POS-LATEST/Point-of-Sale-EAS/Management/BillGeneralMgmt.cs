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
    public static class BillGeneralMgmt
    {
        public static bool InsertBill(BillGeneral aBillGeneral)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO BillGeneral (Number,Date,BillTime,TotalItems,TotalTax,TotalPrice,TotalCost,TellerID,CustomerID,PriceLevelID,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,CheckNumber,Currency,IsChecked,IsRevised,SubTotal,IsCashCredit,CustomerAccountAmountOld) VALUES (@Number,@Date,@BillTime,@TotalItems,@TotalTax,@TotalPrice,@TotalCost,@TellerID,@CustomerID,@PriceLevelID,@PaymentMethodID,@Comments,@SalesDiscount,@DiscountPerc,@CashIn,@TotalDiscount,@CreditCardInfo,@CurrencyID,@AccountID,@NetAmount,@CheckNumber,@Currency,0,0,@SubTotal,@IsCashCredit,@CustomerAccountAmountOld)", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillGeneral.Bill_General_Number;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aBillGeneral.Bill_General_Date;
                    cmd.Parameters.Add("@BillTime", SqlDbType.NVarChar).Value = aBillGeneral.Bill_General_Time;
                    cmd.Parameters.Add("@TotalItems", SqlDbType.Float).Value = aBillGeneral.Bill_General_TotalItems;
                    cmd.Parameters.Add("@TotalTax", SqlDbType.Float).Value = aBillGeneral.Bill_General_TotalTax;

                    cmd.Parameters.Add("@TotalPrice", SqlDbType.Float).Value = aBillGeneral.Bill_General_TotalPrice;
                    cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = aBillGeneral.Bill_General_TotalCost;
                    cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aBillGeneral.Bill_General_TellerID;
                    cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = aBillGeneral.Bill_General_CustomerID;
                    cmd.Parameters.Add("@PriceLevelID", SqlDbType.Int).Value = aBillGeneral.Bill_General_PriceLevel;

                    cmd.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = aBillGeneral.Bill_General_PaymentMethodID;
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aBillGeneral.Bill_General_Comments;
                    cmd.Parameters.Add("@SalesDiscount", SqlDbType.Float).Value = aBillGeneral.Bill_General_SalesDiscount;
                    cmd.Parameters.Add("@DiscountPerc", SqlDbType.Float).Value = aBillGeneral.Bill_General_DiscountPerc;
                    cmd.Parameters.Add("@CashIn", SqlDbType.Float).Value = aBillGeneral.Bill_General_CashIn;

                    cmd.Parameters.Add("@TotalDiscount", SqlDbType.Float).Value = aBillGeneral.Bill_General_TotalDiscount;
                    cmd.Parameters.Add("@CreditCardInfo", SqlDbType.NVarChar).Value = aBillGeneral.Bill_General_CreditCardInfo;
                    cmd.Parameters.Add("@CurrencyID", SqlDbType.Int).Value = aBillGeneral.Bill_General_CurrencyID;
                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aBillGeneral.Bill_General_AccountID;
                    cmd.Parameters.Add("@NetAmount", SqlDbType.Float).Value = aBillGeneral.Bill_General_NetAmount;

                    cmd.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aBillGeneral.Bill_General_CheckNumber;
                    cmd.Parameters.Add("@Currency", SqlDbType.NVarChar).Value = aBillGeneral.Bill_General_Currency;
                    //ischecked isrevised is added in the sql query to 0,0
                    cmd.Parameters.Add("@SubTotal", SqlDbType.Float).Value = aBillGeneral.Bill_General_SubTotal;
                    cmd.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = aBillGeneral.Bill_General_IsCashCredit;

                    cmd.Parameters.Add("@CustomerAccountAmountOld", SqlDbType.Float).Value = aBillGeneral.CustomerAccountAmountOld;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN BILL GENERAL MGMT (INSERT FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM BillGeneral Where Number =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillGeneralNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Bill General* MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from BillGeneral where 1=1 ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (SelectAllBills FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(Number) AS MAXNUM FROM BillGeneral", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (NextBillNumber FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from BillGeneral where Number=@Number", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (SelectBillByNumber FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlCommand cmd = new SqlCommand("UPDATE BillGeneral SET IsChecked=1,CheckedDate=@CheckedDate,CheckedBy=@CheckedBy Where Number=@Number", Helper.Instance.con);

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
                    MessageBox.Show("ERROR IN BILL GENERAL MGMT (UpdateBillToChecked FUNCTION) EX=" + ex.Message.ToString());

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
                    SqlCommand cmd = new SqlCommand("UPDATE BillGeneral SET IsRevised=1,ReviseDate=@ReviseDate,RevisedBy=@RevisedBy,ReviseLoss=@ReviseLoss Where Number=@Number", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                    cmd.Parameters.Add("@Number", SqlDbType.Int).Value = aBillNumber;
                    cmd.Parameters.Add("@ReviseLoss", SqlDbType.Float).Value = aCostLoss;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN BILL GENERAL MGMT (UpdateBillToRevised FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select Number from BillGeneral where Number=@Number", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (IsBillExist FUNCTION) EX=" + ex.Message.ToString());
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
                        " , SUM(TotalTax) AS TaxTotal, SUM(TotalCost) AS ItemsCost from BillGeneral where  (IsRevised = 0)", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (SelectTotalTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="FilterDateFrom"></param>
        /// <param name="FilterDateTo"></param>
        /// <param name="TellerID">if teller id=(-1) select all tellers</param>
        /// <param name="IsReversed"> if IsReversed=(-1) then select all.
        ///                                          (0) Select Unreversed
        ///                                          (1) Select Only Reversed</param>
        /// <param name="PaymentMethodID">if (-1) all</param>
        /// <param name="IsCashCredit"> if (-1) all</param>
        /// <returns></returns>
        public static double SelectSalesAmount(string FilterDateFrom,string FilterDateTo,int TellerID, int IsReversed,int PaymentMethodID,int IsCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(TotalPrice) AS TotalPrice" +
                        "  FROM BillGeneral where  1=1", Helper.Instance.con);
                    if (FilterDateFrom != "" && FilterDateTo!="")
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
                    if (PaymentMethodID != -1)
                    {
                        da.SelectCommand.CommandText += " AND PaymentMethodID=@PaymentMethodID";
                        da.SelectCommand.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = PaymentMethodID;
                    }
                    if (IsCashCredit != -1)
                    {
                        da.SelectCommand.CommandText += " AND IsCashCredit=@IsCashCredit";
                        da.SelectCommand.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = IsCashCredit;
                    }

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    if (dt==null)
                    {
                        return 0.00;
                    }
                    else if (dt.Rows.Count > 0)
                    {
                        double TestParser = 0.00;
                        if (double.TryParse(dt.Rows[0]["TotalPrice"].ToString(),out TestParser))
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (SelectSalesAmount FUNCTION) EX=" + ex.Message.ToString());
                    return 0.00;
                }
            }
            return 0.00;
        }

        public static double SelectTotalDiscount(string FilterDateFrom, string FilterDateTo, int TellerID, int IsReversed, int PaymentMethodID, int IsCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(TotalDiscount) AS TotalDiscount" +
                        "  FROM BillGeneral where  1=1", Helper.Instance.con);
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
                    if (PaymentMethodID != -1)
                    {
                        da.SelectCommand.CommandText += " AND PaymentMethodID=@PaymentMethodID";
                        da.SelectCommand.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = PaymentMethodID;
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
                        if (double.TryParse(dt.Rows[0]["TotalDiscount"].ToString(), out TestParser))
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
                    MessageBox.Show("ERROR IN *BillGeneral* MGMT (SelectTotalDiscount FUNCTION) EX=" + ex.Message.ToString());
                    return 0.00;
                }
            }
            return 0.00;
        }

    }
}
