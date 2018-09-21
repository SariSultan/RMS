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
    public static class PurchaseVoucherGeneralMgmt
    {
        public static bool  AddVoucher(PurchaseVoucherGeneral aPurchaseVoucherGeneral)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PurchaseVoucherGeneral " +
                        "(VoucherNumber,Date,Time,VendorID" +
                    ",TotalFreeItemsQty,TotalTax,Subtotal,DiscountPerc,TotalDiscount" +
                    ",TotalCost,PaymentMethodID,TellerID,Comments,CreditCardInfo" +
                    ",CurrencyID,AccountID,CheckNumber,IsCashCredit,VendorAccountAmountOld" +
                    ",IsChecked,CheckedBy,CheckTime,IsRevised" +
                    ",RevisedBy,ReviseTime,ReviseLoss,Fees,TotalItemsDiscount)" +
                    " VALUES " +
                    "(@VoucherNumber,@Date,@Time,@VendorID" +
                    ",@TotalFreeItemsQty,@TotalTax,@Subtotal,@DiscountPerc,@TotalDiscount" +
                    ",@TotalCost,@PaymentMethodID,@TellerID,@Comments,@CreditCardInfo" +
                    ",@CurrencyID,@AccountID,@CheckNumber,@IsCashCredit,@VendorAccountAmountOld" +
                    ",@IsChecked,@CheckedBy,@CheckTime,@IsRevised" +
                    ",@RevisedBy,@ReviseTime,@ReviseLoss,@Fees,@TotalItemsDiscount)", Helper.Instance.con);

                    cmd.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aPurchaseVoucherGeneral.VoucherNumber;
                    cmd.Parameters.Add("@Date", SqlDbType.Date).Value = aPurchaseVoucherGeneral.Date;
                    cmd.Parameters.Add("@Time", SqlDbType.VarChar).Value = aPurchaseVoucherGeneral.Time;
                    cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = aPurchaseVoucherGeneral.VendorID;
                    //cmd.Parameters.Add("@TotalItems", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalItems;

                    cmd.Parameters.Add("@TotalFreeItemsQty", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalFreeItemsQty;
                    cmd.Parameters.Add("@TotalTax", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalTax;
                    cmd.Parameters.Add("@Subtotal", SqlDbType.Float).Value = aPurchaseVoucherGeneral.Subtotal;
                    cmd.Parameters.Add("@DiscountPerc", SqlDbType.Float).Value = aPurchaseVoucherGeneral.DiscountPerc;
                    cmd.Parameters.Add("@TotalDiscount", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalDiscount;

                    cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalCost;
                    cmd.Parameters.Add("@PaymentMethodID", SqlDbType.Int).Value = aPurchaseVoucherGeneral.PaymentMethodID;
                    cmd.Parameters.Add("@TellerID", SqlDbType.Int).Value = aPurchaseVoucherGeneral.TellerID;
                    cmd.Parameters.Add("@Comments", SqlDbType.NVarChar).Value = aPurchaseVoucherGeneral.Comments;
                    cmd.Parameters.Add("@CreditCardInfo", SqlDbType.NVarChar).Value = aPurchaseVoucherGeneral.CreditCardInfo;

                    cmd.Parameters.Add("@CurrencyID", SqlDbType.Int).Value = aPurchaseVoucherGeneral.CurrencyID;
                    cmd.Parameters.Add("@AccountID", SqlDbType.Int).Value = aPurchaseVoucherGeneral.AccountID;
                    cmd.Parameters.Add("@CheckNumber", SqlDbType.Int).Value = aPurchaseVoucherGeneral.CheckNumber;
                    cmd.Parameters.Add("@IsCashCredit", SqlDbType.Int).Value = aPurchaseVoucherGeneral.IsCashCredit;
                    cmd.Parameters.Add("@VendorAccountAmountOld", SqlDbType.Float).Value = aPurchaseVoucherGeneral.VendorAccountAmountOld;

                    cmd.Parameters.Add("@IsChecked", SqlDbType.Int).Value = aPurchaseVoucherGeneral.IsChecked;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = "";// aPurchaseVoucherGeneral.CheckedBy;
                    //cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = "";//aPurchaseVoucherGeneral.CheckDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.VarChar).Value = "";//aPurchaseVoucherGeneral.CheckTime;
                    cmd.Parameters.Add("@IsRevised", SqlDbType.Int).Value = aPurchaseVoucherGeneral.IsRevised;


                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = "";//aPurchaseVoucherGeneral.RevisedBy;
                    //cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = "";//aPurchaseVoucherGeneral.ReviseDate;
                    cmd.Parameters.Add("@ReviseTime", SqlDbType.VarChar).Value = "";//aPurchaseVoucherGeneral.ReviseTime;
                    cmd.Parameters.Add("@ReviseLoss", SqlDbType.Float).Value = 0;//aPurchaseVoucherGeneral.ReviseLoss;
                    cmd.Parameters.Add("@Fees", SqlDbType.Float).Value = aPurchaseVoucherGeneral.Fees;

                    cmd.Parameters.Add("@TotalItemsDiscount", SqlDbType.Float).Value = aPurchaseVoucherGeneral.TotalItemsDiscount;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneral* MGMT (AddVoucher1 FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static int NextVoucherNumber()
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT MAX(VoucherNumber) AS MAXNUM FROM PurchaseVoucherGeneral ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneral* MGMT (NextVoucherNumber FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from PurchaseVoucherGeneral ", Helper.Instance.con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneralMgmt* MGMT (SelectAllVouchers FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectGeneralVoucherByNumber(int aVoucherNumber)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from PurchaseVoucherGeneral where VoucherNumber=@VoucherNumber  ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aVoucherNumber;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneralMgmt* MGMT (SelectGeneralVoucherByNumber FUNCTION) EX=" + ex.Message.ToString());
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
                    SqlDataAdapter da = new SqlDataAdapter("Select * from PurchaseVoucherGeneral WHERE 1=1 ", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneralMgmt* MGMT (SelectAllVouchers(Vars) FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static bool UpdateVoucherChecked(string CheckedBy, string ChkDate,string ChkTime, int aBillNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PurchaseVoucherGeneral SET IsChecked=1,CheckDate=@CheckDate,CheckedBy=@CheckedBy,CheckTime=@CheckTime Where VoucherNumber=@VoucherNumber", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@CheckDate", SqlDbType.Date).Value = ChkDate;
                    cmd.Parameters.Add("@CheckTime", SqlDbType.NVarChar).Value = ChkDate;
                    cmd.Parameters.Add("@CheckedBy", SqlDbType.NVarChar).Value = CheckedBy;
                    cmd.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aBillNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneral* MGMT (UpdateVoucherChecked FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }
        public static bool UpdateVoucherToRevised(string RevisedBy, string ReviseDate,string ReviseTime, int aBillNumber, double aCostLoss)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE PurchaseVoucherGeneral SET IsRevised=1,ReviseDate=@ReviseDate,ReviseTime=@ReviseTime,RevisedBy=@RevisedBy,ReviseLoss=@ReviseLoss Where VoucherNumber=@VoucherNumber", Helper.Instance.con);

                    //,PaymentMethodID,Comments,SalesDiscount,DiscountPerc,CashIn,
                    //TotalDiscount,CreditCardInfo,CurrencyID,AccountID,NetAmount,
                    //CheckNumber,Currency

                    cmd.Parameters.Add("@ReviseDate", SqlDbType.Date).Value = ReviseDate;
                    cmd.Parameters.Add("@ReviseTime", SqlDbType.NVarChar).Value = ReviseTime;
                    cmd.Parameters.Add("@RevisedBy", SqlDbType.NVarChar).Value = RevisedBy;
                    cmd.Parameters.Add("@VoucherNumber", SqlDbType.Int).Value = aBillNumber;
                    cmd.Parameters.Add("@ReviseLoss", SqlDbType.Float).Value = aCostLoss;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Purchase Voucher General* MGMT (UpdateVoucherToRevised FUNCTION) EX=" + ex.Message.ToString());
                    return false;
                }
            }
            return false;
        }

        public static void DeleteVoucher(int aPurchaseVoucherNumber)
        {
            if (Helper.Instance.con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PurchaseVoucherGeneral Where VoucherNumber =@Number", Helper.Instance.con);
                    cmd.Parameters.Add("@Number", SqlDbType.Float).Value = aPurchaseVoucherNumber;
                    cmd.ExecuteNonQuery();
                    Helper.Instance.con.Close();
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *Purchase Voucher General* MGMT (Delete FUNCTION) EX=" + ex.Message.ToString());
                }
            }
        }


        public static double SelectPurchaseAmount(string FilterDateFrom, string FilterDateTo, int TellerID, int IsReversed, int PaymentMethodID, int IsCashCredit)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select SUM(TotalCost) AS TotalCost" +
                        "  FROM PurchaseVoucherGeneral where  1=1", Helper.Instance.con);
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
                        if (double.TryParse(dt.Rows[0]["TotalCost"].ToString(), out TestParser))
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
                    MessageBox.Show("ERROR IN *Purchase Voucher general* MGMT (SelectSalesAmount FUNCTION) EX=" + ex.Message.ToString());
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
                        "  FROM PurchaseVoucherGeneral where  1=1", Helper.Instance.con);
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
                    MessageBox.Show("ERROR IN *PurchaseVoucherGeneral* MGMT (SelectTotalDiscount FUNCTION) EX=" + ex.Message.ToString());
                    return 0.00;
                }
            }
            return 0.00;
        }

    }
}
