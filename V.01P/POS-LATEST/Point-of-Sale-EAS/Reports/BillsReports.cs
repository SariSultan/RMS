using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Calcium_RMS.Management;
using Calcium_RMS.Entities;
namespace Calcium_RMS.Reports
{
    public class BillsReports
    {
        static BillsReports instance;

        public static BillsReports Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillsReports();
                }
                return instance;
            }
        }

        public string EndOfPeriodReport(string TellerName, int FilterTellerNameID, string FilterDateFrom, string FilterDateTo, bool TableBorder = false, bool Preview = true, bool PrintToThermal = false, bool ExportToPdf = false, bool ExportToExcel = false, string ExportPath = "", bool colored = false)
        {
            /**************************************** END OF PERIOD *********************************/
            /* For Teller : Teller Name (s) Date From ----------> To 
             * Printed On : Date::Time
             * Printed By : Current User Name
             * *************************************************************************************
             *                                        [CASH]
             * ---------------------------------------- |--------------------------------------------
             * |                TYPE                    |                   AMOUNT (JOD)            |
             * --------------------------------------------------------------------------------------
             * |                CASH SALES              |               XXXXXX.XXX                  |
             * --------------------------------------------------------------------------------------
             * |_______________TOTAL____________________|_______________XXXXXX.XXX__________________|
             * */
            List<DataTable> aDTList = new List<DataTable>();
            DataTable aTempTable = null;
            DataRow aTempRow = null; /*Row Used For filling the datatables*/
            #region REPORT HEADER
            string RCV = "<b>" + Text.ReportsText.ReceivedRepTxt + "</b>";
            string REV = "<b>" + Text.ReportsText.ReversedRepTxt + "</b>";
            List<string> aStringList = ReportsHelper.ImportReportHeader(0, 1);
            List<string> aFooterList = ReportsHelper.ImportReportHeader(1, 1);
            aStringList.Add(SharedVariables.Line_Solid_10px_Black);
            aStringList.Add(Text.ReportsNames.EndOfPeriodRepNm);
            aStringList.Add("<h2>" + Text.ReportsText.TellerRepTxt + ": <b>" + TellerName + "</b></h2>");
            aStringList.Add("<h2>" + Text.ReportsText.DateRepTxt + " " + Text.ReportsText.FromRepTxt +
                                    " : " + FilterDateFrom + " " + Text.ReportsText.ToRepTxt + " :" + FilterDateTo + "</h2>");
            aStringList.Add("<h2>" + Text.ReportsText.PrintedOnrepTxt + " : " + DateTime.Now.ToShortDateString() + "&nbsp;&nbsp;" + DateTime.Now.ToShortTimeString() + "</h2>");
            aStringList.Add("<h2>" + Text.ReportsText.PrintedByrepTxt + ": <b>" + SharedFunctions.ReturnLoggedUserName() + "</b></h2>");
            aStringList.Add(SharedVariables.Line_Solid_10px_Black);
            #endregion REPORT HEADER

            #region CASH_HANDLING
            { /*cash scope*/
                double CashSalesDiscount = BillGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD,0);
                double CashSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID,-1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, 0);/*Cash Sales Amount*/
                double ReversedCashSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CASH_PAYMENT_METHOD,0);
                double CashSalesReturns = ReturnItemsCustGeneralMGMT.SelectCustomersReturns(FilterDateFrom, FilterDateTo, FilterTellerNameID, 0, -1);
                double NetTotalCashSales = CashSales - ReversedCashSales - CashSalesReturns;/*discount removed since it is in the added to the sales*/
                #region CASH_HANDLING_SALES
                DataTable aCashTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashTableHeader.Columns.Add(Text.ReportsText.CashSalesRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashTableHeader);
                /*Receieved Cash Sales Handling*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CshSalesRepTxt;/*Cash Sales*/

                aTempRow[1] = CashSales + CashSalesDiscount;
                /*Reversed  Cash Sales Handling*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevCashSalesRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedCashSales;
                /*Cash Sales Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashSalesDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = CashSalesDiscount;
                /*Cash Sales Returns*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashSalesReturnsRepTxt; /*Cash Sales Returns;*/
                aTempRow[1] = CashSalesReturns;
                /*NET Cash Sales*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalCashSales + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CASH_HANDLING_SALES
                double CashCustPayment = CustomersPaymentsMgmt.SelectCustomerPayments(FilterDateFrom, FilterDateTo, FilterTellerNameID, 0, PaymentMethodMgmt.CASH_PAYMENT_METHOD);
                double CashVendorPayment = VendorsPaymentsMgmt.SelectCustomerPayments(FilterDateFrom, FilterDateTo, FilterTellerNameID, 0, PaymentMethodMgmt.CASH_PAYMENT_METHOD);
                double NetCashPayments = CashCustPayment - CashVendorPayment;
                #region CASH_HANDLING_PAYMENTS
                DataTable aPaymentsTableHeader = new DataTable();             /*Only Header For Cash section*/
                aPaymentsTableHeader.Columns.Add(Text.ReportsText.CashPaymentsRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aPaymentsTableHeader);
                /*Cash Customer Payments*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashCustPaymentsRepTxt;/*Cash Sales*/
                aTempRow[1] = CashCustPayment;
                /*Cash Vendors Payments*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashVendPaymentsRepTxt;/*Cash Sales*/
                aTempRow[1] = CashVendorPayment;
                /*Net Cash Payments*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetCashPayments + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CASH_HANDLING_PAYMENTS
                double CashPurchaseDiscount = PurchaseVoucherGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, -1);
                double CashPurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, 0);/*Cash Sales Amount*/
                double ReversedCashPurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, -1);
                double CashPurchaseReturns = ReturnItemsVendorGeneralMgmt.SelectVendorReturns(FilterDateFrom, FilterDateTo, FilterTellerNameID, 0, -1);
                double NetTotalCashPurchase = -CashPurchase + ReversedCashPurchase + CashPurchaseReturns;/*discount removed since it is in the added to the sales*/
                #region CASH_HANDLING_PURCHASE
                DataTable aCashPurchaseTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashPurchaseTableHeader.Columns.Add(Text.ReportsText.CashPurchaseRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashPurchaseTableHeader);
                /*CASH PURCHASES*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashPurchaseRepTxt;
                aTempRow[1] = CashPurchase + CashPurchaseDiscount;
                /*REVERSED CASH PURCHASES*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevCashPurchaseRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedCashPurchase;
                /*Cash Purchase Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashPurchaseDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = CashPurchaseDiscount;
                /*Cash Purchase Returns*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CashPurchaseReturnRepTxt; /*Cash Sales Returns;*/
                aTempRow[1] = CashPurchaseReturns;
                /*NET Cash Purchase*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalCashPurchase + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CASH_HANDLING_PURCHASE

                double TotalCash = NetTotalCashSales + NetCashPayments - NetTotalCashPurchase;
                DataTable aFinalCashTable = new DataTable();
                aFinalCashTable.Columns.Add(Text.ReportsText.TotalCashAmountTxt + " " + TotalCash.ToString() + " JOD <hr/>");
                aDTList.Add(aFinalCashTable);
            }/*end cash scope*/
            #endregion CASH_HANDLING

            #region INVOICE_CARD_HANDLING
            {/*Invoice Scope*/
                double InvoiceSalesDiscount = BillGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD,1);
                double InvoiceSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, 1);/*Cash Sales Amount*/
                double ReversedInvoiceSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, 1);
                double NetTotalInvoiceSales = InvoiceSales  - ReversedInvoiceSales;/*discount removed since it is in the added to the sales*/
                #region INVOICE_HANDLING_SALES
                DataTable aCashTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashTableHeader.Columns.Add(Text.ReportsText.InvoiceSalesRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashTableHeader);
                /*Receieved Cash Sales Handling*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.InvoiceSalesRepTxt;/*Cash Sales*/
                aTempRow[1] = InvoiceSalesDiscount + InvoiceSales;
                /*Reversed  Cash Sales Handling*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevInvoiceSalesRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedInvoiceSales;
                /*Cash Sales Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.InvoiceDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = InvoiceSalesDiscount;
                /*NET Cash Sales*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalInvoiceSales + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion INVOICE_HANDLING_SALES

                double InvoicePurchaseDiscount = PurchaseVoucherGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD,1);
                double InvoicePurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CASH_PAYMENT_METHOD,1);/*Cash Sales Amount*/
                double ReversedInvoicePurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CASH_PAYMENT_METHOD, 1);
                double NetTotalInvoicePurchase = -InvoicePurchase + ReversedInvoicePurchase ;/*discount removed since it is in the added to the sales*/
                #region Invoice_HANDLING_PURCHASE
                DataTable aCashPurchaseTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashPurchaseTableHeader.Columns.Add(Text.ReportsText.InvoicePurchaseRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashPurchaseTableHeader);
                /*CASH PURCHASES*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.InvoicePurchaseRepTxt;
                aTempRow[1] = InvoicePurchase + InvoicePurchaseDiscount;
                /*REVERSED CASH PURCHASES*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevInvoicePurchaseRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedInvoicePurchase;
                /*Cash Purchase Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.InvoicePurchaseDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = InvoicePurchaseDiscount;
                /*NET Cash Purchase*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalInvoicePurchase + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion Invoice_HANDLING_PURCHASE

                double TotalInvoice = NetTotalInvoiceSales - NetTotalInvoicePurchase;
                DataTable aFinalInvoiceTable = new DataTable();
                aFinalInvoiceTable.Columns.Add(Text.ReportsText.TotalInvoiceAmountTxt + " " + TotalInvoice.ToString() + " JOD <hr/>");
                aDTList.Add(aFinalInvoiceTable);
            }/*End Invoice Scope*/
            #endregion INVOICE_CARD_HANDLING

            #region CREDIT_CARD_HANDLING
            {/*Credit Scope*/
                double CreditSalesDiscount = BillGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);
                double CreditSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);/*Cash Sales Amount*/
                double ReversedCreditSales = BillGeneralMgmt.SelectSalesAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);
                double NetTotalCreditSales = CreditSales - ReversedCreditSales;/*discount removed since it is in the added to the sales*/
                #region CREDIT_HANDLING_SALES
                DataTable aCashTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashTableHeader.Columns.Add(Text.ReportsText.CreditSalesRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashTableHeader);
                /*Receieved Cash Sales Handling*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditSalesRepTxt;/*Cash Sales*/

                aTempRow[1] = CreditSales + CreditSalesDiscount;
                /*Reversed  Cash Sales Handling*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevCreditSalesRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedCreditSales;
                /*Cash Sales Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditSalesDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = CreditSalesDiscount;
                /*NET Cash Sales*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalCreditSales + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CREDIT_HANDLING_SALES

                double CreditCustPayment = CustomersPaymentsMgmt.SelectCustomerPayments(FilterDateFrom, FilterDateTo, FilterTellerNameID,0, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD);
                double CreditVendorPayment = VendorsPaymentsMgmt.SelectCustomerPayments(FilterDateFrom, FilterDateTo, FilterTellerNameID, 0, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD);
                double NetCreditPayments = CreditCustPayment - CreditVendorPayment;
                #region CREDIT_HANDLING_PAYMENTS
                DataTable aPaymentsTableHeader = new DataTable();             /*Only Header For Cash section*/
                aPaymentsTableHeader.Columns.Add(Text.ReportsText.CreditPaymentsRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aPaymentsTableHeader);
                /*Cash Customer Payments*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditCustPaymentsRepTxt;/*Cash Sales*/
                aTempRow[1] = CreditCustPayment;
                /*Cash Vendors Payments*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditVendPaymentsRepTxt;/*Cash Sales*/
                aTempRow[1] = CreditVendorPayment;
                /*Net Cash Payments*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetCreditPayments + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CREDIT_HANDLING_PAYMENTS

                double CreditPurchaseDiscount = PurchaseVoucherGeneralMgmt.SelectTotalDiscount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);
                double CreditPurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, -1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);/*Cash Sales Amount*/
                double ReversedCreditPurchase = PurchaseVoucherGeneralMgmt.SelectPurchaseAmount(FilterDateFrom, FilterDateTo, FilterTellerNameID, 1, PaymentMethodMgmt.CREDITCARD_PAYMENT_METHOD, -1);
                double NetTotalCreditPurchase = -CreditPurchase + ReversedCreditPurchase ;/*discount removed since it is in the added to the sales*/
                #region CREDIT_HANDLING_PURCHASE
                DataTable aCashPurchaseTableHeader = new DataTable();             /*Only Header For Cash section*/
                aCashPurchaseTableHeader.Columns.Add(Text.ReportsText.CreditPurchaseRepTxt);   /*Title Only row, this is empty datatable*/
                aDTList.Add(aCashPurchaseTableHeader);
                /*CASH PURCHASES*/
                aTempTable = GetEndOfPeriodInnerTable(TableBorder);
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditPurchaseRepTxt;
                aTempRow[1] = CreditPurchase + CreditPurchaseDiscount;
                /*REVERSED CASH PURCHASES*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.RevCreditPurchaseRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = ReversedCreditPurchase;
                /*Cash Purchase Discounts*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = Text.ReportsText.CreditPurchaseDiscountRepTxt;/*ReversedCash Sales*/
                aTempRow[1] = CreditPurchaseDiscount;
                /*NET Cash Purchase*/
                aTempRow = aTempTable.Rows.Add();
                aTempRow[0] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.MANUAL_TD_OPTION_END + ReportsHelper.MANUAL_TD_END;
                aTempRow[1] = ReportsHelper.MANUAL_TD_OPTION_START + ReportsHelper.NOBORDER + ReportsHelper.UNDERLINE + ReportsHelper.BOLD + ReportsHelper.MANUAL_TD_OPTION_END + Text.ReportsText.TotalTxt + " " + NetTotalCreditPurchase + ReportsHelper.MANUAL_TD_END;
                aDTList.Add(aTempTable);
                #endregion CREDIT_HANDLING_PURCHASE

                double TotalCredit = NetTotalCreditSales + NetCreditPayments - NetTotalCreditPurchase;
                DataTable aFinalCreditTable = new DataTable();
                aFinalCreditTable.Columns.Add(Text.ReportsText.TotalCreditAmountTxt + " " + TotalCredit.ToString() + " JOD <hr/>");
                aDTList.Add(aFinalCreditTable);

            }/*End Credit Scope*/
            #endregion CREDIT_HANDLING_PURCHASE

            #region SENDING_FOR_PRINTING_MANAGER
            if (Preview)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, false, false, "", false, "", colored);
                return "True";
            }
            else if (ExportToPdf)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, false, false, true, ExportPath, false, "", colored);
                return "True";
            }
            else if (ExportToExcel)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, false, false, false, "", ExportToExcel, ExportPath, colored);

                return "True";
            }
            else if (PrintToThermal)
            {
                PrintingManager.Instance.PrintTables(aDTList, aStringList, aFooterList, ReportsHelper.TempOutputPath, ReportsHelper.TempOutputPath, PrintToThermal, true);
                return "True";
            }
            else
            {
                return "ERROR";
            }
            #endregion SENDING_FOR_PRINTING_MANAGER

        }

        private DataTable GetEndOfPeriodInnerTable(bool TableBorder)
        {
            DataTable aGeneralTemplateTable = new DataTable();

            aGeneralTemplateTable.Columns.Add(Text.ReportsText.TypeRepTxt);
            aGeneralTemplateTable.Columns.Add(Text.ReportsText.AmountRepTxt);
            if (TableBorder)
            {
                aGeneralTemplateTable.Columns[0].ColumnName = "[Border=true1]" + aGeneralTemplateTable.Columns[0].ColumnName;
            }
            return aGeneralTemplateTable;
        }
    }
}

