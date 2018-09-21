using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calcium_RMS.Entities;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;


namespace Calcium_RMS.Reports
{
    public static class ReportsMgmt
    {
        public static DataTable EndOfDayByUserIDandDate(int filterUserID, string FilterDateFrom, string FilterDateTo)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {

                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(TotalItems) AS TOTitems, SUM(TotalTax) AS TOTtax, SUM(TotalPrice) AS TOTprice, SUM(TotalCost) AS TOTcost, SUM(TotalDiscount) AS TOTdiscount, PaymentMethodID, IsCashCredit, IsRevised FROM   BillGeneral WHERE   (1 = 1)", Helper.Instance.con);
                    if (filterUserID != -1)
                    {
                        da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = filterUserID;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " GROUP BY PaymentMethodID, IsCashCredit, IsRevised ORDER BY IsRevised ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (EndOfDayByUserIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable PurchaseEndOfDayByUserIDandDate(int filterUserID, string FilterDateFrom, string FilterDateTo)
        {

            if (Helper.Instance.con.State == ConnectionState.Closed)
            {

                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(ID) AS TOTitems, SUM(TotalTax) AS TOTtax, SUM(TotalCost) AS TOTcost,SUM(Subtotal) AS TOTsub, SUM(TotalDiscount) AS TOTdiscount, PaymentMethodID, IsCashCredit, IsRevised FROM   PurchaseVoucherGeneral WHERE   (1 = 1)", Helper.Instance.con);
                    if (filterUserID != -1)
                    {
                        da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = filterUserID;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " GROUP BY PaymentMethodID, IsCashCredit, IsRevised ORDER BY IsRevised ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (PurchaseEndOfDayByUserIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable CustomerPaymentEndOfDayByUserIDandDate(int filterUserID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {

                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(ID) AS TOTitems, SUM(Amount) AS TOTAmount, PaymentMethodID, IsRevised FROM   CustomersPayments WHERE   (1 = 1)", Helper.Instance.con);
                    if (filterUserID != -1)
                    {
                        da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = filterUserID;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " GROUP BY PaymentMethodID, IsRevised ORDER BY IsRevised ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (CustomersPaymentsEndOfDayByUserIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable VendorsPaymentEndOfDayByUserIDandDate(int filterUserID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {

                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(ID) AS TOTitems, SUM(Amount) AS TOTAmount, PaymentMethodID, IsRevised FROM   VendorsPayments WHERE   (1 = 1)", Helper.Instance.con);
                    if (filterUserID != -1)
                    {
                        da.SelectCommand.CommandText += " and TellerID=@TellerID ";
                        da.SelectCommand.Parameters.Add("@TellerID", SqlDbType.Int).Value = filterUserID;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " GROUP BY PaymentMethodID, IsRevised ORDER BY IsRevised ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (VendorsPaymentEndOfDayByUserIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        //customer balance statement report
        public static DataTable SelectCustomerPaymentsByIDandDate(int CustomerID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Date,PaymentNumber,Amount,OldUsrAccountAmount,IsRevised,Time,ReviseDate,ReviseTime FROM   CustomersPayments WHERE   (1 = 1)", Helper.Instance.con);
                    if (CustomerID != -1)
                    {
                        da.SelectCommand.CommandText += " and CustomerID=@CustomerID ";
                        da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                    }
                    else
                    {
                        Helper.Instance.con.Close();
                        return null;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }

                    da.SelectCommand.CommandText += "  ORDER BY Date ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectCustomerPaymentsByIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataTable SelectCustomerBillINVOICEsByIDandDate(int CustomerID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Date,Number,TotalPrice,CustomerAccountAmountOld,IsRevised,BillTime,ReviseDate FROM   BillGeneral WHERE   IsCashCredit=1 ", Helper.Instance.con);
                    if (CustomerID != -1)
                    {
                        da.SelectCommand.CommandText += " and CustomerID=@CustomerID ";
                        da.SelectCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = CustomerID;
                    }
                    else
                    {
                        Helper.Instance.con.Close();
                        return null;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }

                    da.SelectCommand.CommandText += "  ORDER BY Date ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectCustomerBillINVOICEsByIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        //vendor balance statement report
        public static DataTable SelectVendorPaymentsByIDandDate(int VendorID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Date,PaymentNumber,Amount,OldVendorAccountAmount,IsRevised,Time,ReviseDate,ReviseTime FROM   VendorsPayments WHERE   (1 = 1)", Helper.Instance.con);
                    if (VendorID != -1)
                    {
                        da.SelectCommand.CommandText += " and VendorID=@VendorID ";
                        da.SelectCommand.Parameters.Add("@VendorID", SqlDbType.Int).Value = VendorID;
                    }
                    else
                    {
                        Helper.Instance.con.Close();
                        return null;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }

                    da.SelectCommand.CommandText += "  ORDER BY Date ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectVendorPaymentsByIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataTable SelectVendorPurchaseINVOICEsByIDandDate(int VendorID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  Date,VoucherNumber,TotalCost,VendorAccountAmountOld,IsRevised,Time,ReviseDate,ReviseTime FROM   PurchaseVoucherGeneral WHERE   IsCashCredit=1 ", Helper.Instance.con);
                    if (VendorID != -1)
                    {
                        da.SelectCommand.CommandText += " and VendorID=@VendorID ";
                        da.SelectCommand.Parameters.Add("@VendorID", SqlDbType.Int).Value = VendorID;
                    }
                    else
                    {
                        Helper.Instance.con.Close();
                        return null;
                    }

                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }

                    da.SelectCommand.CommandText += "  ORDER BY Date ASC";
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectVendorPurchaseINVOICEsByIDandDate FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        //statistics reports
        public static DataTable FastMovItemBasedOnQty(int NumberOfItems, string FilterDateFrom, string FilterDateTo, bool FastMoveItem = true)//set fastmoveitem to false to get slow move item report
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(@NumberOfItems) " +
                        " ItemDescription, SUM(Qty) AS Summation FROM   BillDetailed WHERE(" +
                        " Number IN(SELECT Number FROM  BillGeneral WHERE (1=1) ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@NumberOfItems", SqlDbType.Int).Value = NumberOfItems;
                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " and IsRevised=0 )) GROUP BY ItemDescription ORDER BY Summation " + (FastMoveItem ? "DESC" : "ASC");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (FastMovItemBasedOnQty FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataTable HighestRevenuesItems(int NumberOfItems, string FilterDateFrom, string FilterDateTo, bool FastMoveItem = true)//set fastmoveitem to false to get slow move item report
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(@NumberOfItems) " +
                        " ItemDescription,  SUM(TotalPerUnit - Qty * OldAvgUnitCost) AS Summation FROM   BillDetailed WHERE(" +
                        " Number IN(SELECT Number FROM  BillGeneral WHERE (1=1) ", Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@NumberOfItems", SqlDbType.Int).Value = NumberOfItems;
                    if (FilterDateFrom != "")
                    {
                        da.SelectCommand.CommandText += " and Date>=@FilterDateFrom and Date<=@FilterDateTo";
                        da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                        da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    }
                    da.SelectCommand.CommandText += " and IsRevised=0 )) GROUP BY ItemDescription ORDER BY Summation " + (FastMoveItem ? "DESC" : "ASC");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (HighestRevenuesItems FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        //Revenues comparison 
        public static DataTable RevenuesComparions(int ByDDMMYYYY, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("TRUNCATE TABLE DateTemp" +
                        " declare @StartDate datetime" +
                        " declare @EndDate datetime " +
                        " select @StartDate = @FilterDateFrom," +
                        " @EndDate = @FilterDateTo" +
                        // " select @StartDate= @StartDate-(DATEPART(DD,@StartDate)-1) "+
                        " while (@StartDate<=@EndDate)" +
                        " begin" +
                        " insert into dbo.DateTemp values (@StartDate,0,0,0 ) " +
                        " select @StartDate=DATEADD(DD,1,@StartDate) end" +
                        " MERGE DateTemp bi" +
                        " USING (Select Date,Sum(TotalPrice) AS TotalPrice ,SUM(TotalCost) As TotalCost, Sum(TotalPrice) - SUM(TotalCost) As TotalRevenue from BillGeneral" +
                        " WHERE Date>=@FilterDateFrom2 and Date<=@FilterDateTo2 and IsRevised=0 GROUP BY Date) bo" +
                        " ON bi.Date = bo.Date " +
                        " WHEN MATCHED THEN" +
                        " UPDATE SET bi.TP =bo.TotalPrice, bi.TC=bo.TotalCost, bi.TR=bo.TotalRevenue;", Helper.Instance.con);
                    if (ByDDMMYYYY == 0)//DayByDay
                    {
                        da.SelectCommand.CommandText += " SELECT DATEPART(YEAR,Date) As YEAR, DATEPART(MONTH,Date) AS MONTH,DATEPART(Day,Date) AS Day,SUM(TP) AS TotalPrice,SUM(TC) AS TotalCost,SUM(TR) AS TotalProfit FROM DateTemp WHERE 1=1 GROUP BY DATEPART(Year, Date), DATEPART(Month, Date),DATEPART(Day, Date) ORDER BY YEAR,MONTH";
                    }
                    else if (ByDDMMYYYY == 1)//MonthByMonth
                    {
                        da.SelectCommand.CommandText += " SELECT DATEPART(YEAR,Date) As YEAR, DATEPART(MONTH,Date) AS MONTH,SUM(TP) AS TotalPrice,SUM(TC) AS TotalCost,SUM(TR) AS TotalProfit FROM DateTemp WHERE 1=1 GROUP BY DATEPART(Year, Date), DATEPART(Month, Date) ORDER BY YEAR,MONTH";
                    }
                    else
                    {
                        da.SelectCommand.CommandText += " SELECT DATEPART(YEAR,Date) As YEAR,SUM(TP) AS TotalPrice,SUM(TC) AS TotalCost,SUM(TR) AS TotalProfit FROM DateTemp WHERE 1=1 GROUP BY DATEPART(Year, Date) ORDER BY YEAR";
                    }

                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom2", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo2", SqlDbType.Date).Value = FilterDateTo;
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (RevenuesComparions FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        //TAX
        public static DataRow SelectSalesTax(int TaxLevelID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(TotalPerUnit) AS TotalSold, SUM(OldAvgUnitCost * Qty) AS TotalCost" +
                        " FROM BillDetailed WHERE (ItemID IN (SELECT ID FROM Items " +
                        " WHERE (TaxLevel = @TaxLevelID))) AND (Number IN (SELECT Number " +
                        " FROM BillGeneral " +
                        " WHERE        (Date>=@FilterDateFrom AND Date<=@FilterDateTo AND IsRevised = 0)))"
                        , Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@TaxLevelID", SqlDbType.Int).Value = TaxLevelID;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectSalesTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectCustomersReturnsTax(int TaxLevelID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(TotalPerUnit) AS TotalSold, SUM(OldAvgUnitCost * Qty) AS TotalCost" +
                        " FROM ReturnItemsCustDetailed WHERE (ItemID IN (SELECT ID FROM Items " +
                        " WHERE (TaxLevel = @TaxLevelID))) AND (Number IN (SELECT Number " +
                        " FROM ReturnItemsCustGeneral " +
                        " WHERE        (Date>=@FilterDateFrom AND Date<=@FilterDateTo AND IsRevised = 0)))"
                        , Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@TaxLevelID", SqlDbType.Int).Value = TaxLevelID;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectCustomersReturnsTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectPurchaseTax(int TaxLevelID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(ItemCost * Qty) AS TotalCost" +
                        " FROM PurchaseVoucherDetailed WHERE (ItemID IN (SELECT ID FROM Items " +
                        " WHERE (TaxLevel = @TaxLevelID))) AND (VoucherNumber IN (SELECT VoucherNumber " +
                        " FROM PurchaseVoucherGeneral " +
                        " WHERE        (Date>=@FilterDateFrom AND Date<=@FilterDateTo AND IsRevised = 0)))"
                        , Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@TaxLevelID", SqlDbType.Int).Value = TaxLevelID;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectPurchaseTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

        public static DataRow SelectVendorsReturnsTax(int TaxLevelID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT  SUM(ItemCost * Qty) AS TotalCost" +
                        " FROM ReturnItemsVendorDetailed WHERE (ItemID IN (SELECT ID FROM Items " +
                        " WHERE (TaxLevel = @TaxLevelID))) AND (Number IN (SELECT Number " +
                        " FROM ReturnItemsVendorGeneral " +
                        " WHERE        (Date>=@FilterDateFrom AND Date<=@FilterDateTo AND IsRevised = 0)))"
                        , Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@TaxLevelID", SqlDbType.Int).Value = TaxLevelID;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectVendorsReturnsTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }
        public static DataRow SelectDisposalTax(int TaxLevelID, string FilterDateFrom, string FilterDateTo)
        {
            if (Helper.Instance.con.State == ConnectionState.Closed)
            {
                try
                {
                    Helper.Instance.con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT SUM(UnitCost * Qty) AS TotalCost" +
                        " FROM DisposalDetailed WHERE (ItemID IN (SELECT ID FROM Items " +
                        " WHERE (TaxLevel = @TaxLevelID))) AND (GeneralNumber IN (SELECT Number " +
                        " FROM DisposalGeneral " +
                        " WHERE        (Date>=@FilterDateFrom AND Date<=@FilterDateTo AND IsRevised = 0)))"
                        , Helper.Instance.con);
                    da.SelectCommand.Parameters.Add("@TaxLevelID", SqlDbType.Int).Value = TaxLevelID;
                    da.SelectCommand.Parameters.Add("@FilterDateFrom", SqlDbType.Date).Value = FilterDateFrom;
                    da.SelectCommand.Parameters.Add("@FilterDateTo", SqlDbType.Date).Value = FilterDateTo;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Helper.Instance.con.Close();
                    return dt.Rows[0];
                }
                catch (Exception ex)
                {
                    Helper.Instance.con.Close();
                    MessageBox.Show("ERROR IN *ReportsMgmt* MGMT (SelectDisposalTax FUNCTION) EX=" + ex.Message.ToString());
                    return null;
                }
            }
            return null;
        }

    }
}
