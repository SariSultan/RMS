using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Entities;
namespace Calcium_RMS
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }
        int NumberOfConfigs = 10;
        private double NumberOfItems = 1000;
        private double NumberOfBills = 1000;
        private double NumberOfPurchases = 1000;
        private void Add1000ItemsBtn_Click(object sender, EventArgs e)
        {
            var types = ItemTypeMgmt.SelectAll();
            var categories = ItemCategoryMgmt.SelectAll();
            var vendors = VendorsMgmt.SelectAllVendors();
            if (types.Rows.Count == 0 || categories.Rows.Count == 0 | vendors.Rows.Count == 0)
            {
                GenerateItemsConfigs();

                types = ItemTypeMgmt.SelectAll();
                categories = ItemCategoryMgmt.SelectAll();
                vendors = VendorsMgmt.SelectAllVendors();
            }

            var cnt = 2;
            var aRandom = new Random();
            while (cnt < NumberOfItems)
            {
                var aItem = new Items();
                aItem.Item_Barcode = $"Test Item {cnt}";
                aItem.Item_Type = int.Parse(types.Rows[cnt % NumberOfConfigs]["ID"].ToString());
                aItem.Item_Category = int.Parse(categories.Rows[cnt % NumberOfConfigs]["ID"].ToString());
                aItem.Vendor = int.Parse(vendors.Rows[cnt % NumberOfConfigs]["ID"].ToString());
                aItem.Item_Description = $"Test Item {cnt}";
                aItem.Item_Tax_Level = (cnt % 6 != 0) ? cnt % 6 : 1;
                aItem.OnHandQty = cnt;
                aItem.Render_Point = 10;
                aItem.Sell_Price = aRandom.Next(50, 300);
                aItem.PriceLevelID = 1;
                aItem.Entry_Date = "1/1/2009";
                aItem.Avg_Unit_Cost = aItem.Sell_Price - 10;
                aItem.Avalable_Qty = cnt;
                cnt++;

                if (!ItemsMgmt.AddItem(aItem)) return;
                if (cnt % 100 == 0)
                {
                    label1.Text = $"Adding Item {cnt}/{NumberOfItems} ... ({(cnt / NumberOfItems) * 100 })%";
                    Application.DoEvents();
                }
            }
        }

        private void GenerateItemsConfigs()
        {
            for (var i = 0; i < NumberOfConfigs; i++)
            {
                var atype = new ItemType
                {
                    Item_Type_Description = $"test {i}",
                    Item_Type_Name = $"test {i}"
                };
                ItemTypeMgmt.AddItemType(atype);

                var aCategory = new ItemCategory
                {
                    Item_Category_Description = $"test {i}",
                    Item_Category_Name = $"test {i}"
                };
                ItemCategoryMgmt.AddItemCategory(aCategory);

                var aVendors = new Vendors
                {
                    Vendor_Company = $"test {i}",
                    Vendor_Email = $"test {i}",
                    Vendor_Location = $"test {i}",
                    Vendor_Name = $"test {i}",
                    Vendor_Phone1 = "000",
                    Vendor_Phone2 = "222",
                    Vendor_Start_Date = "1/1/2009"
                };
                VendorsMgmt.AddVendor(aVendors);
            }
        }

        private void Add1000Sale_Click(object sender, EventArgs e)
        {
            int cnt = 1;
            DateTime date = DateTime.Now;
            var randAmount = new Random();

            int userId = int.Parse(UsersMgmt.SelectAllUsers().Rows[0]["ID"].ToString());
            while (cnt++ < NumberOfBills)
            {
                try
                {
                    int numofDetailed = randAmount.Next(1, 20);
                    var aBillGeneral = new BillGeneral();
                    aBillGeneral.Bill_General_AccountID = 1;
                    aBillGeneral.Bill_General_CashIn = 100;
                    aBillGeneral.Bill_General_Currency = "JOD";
                    aBillGeneral.Bill_General_CurrencyID = 1;
                    aBillGeneral.Bill_General_CustomerID = 1;
                    aBillGeneral.Bill_General_Date = date.Subtract(TimeSpan.FromDays(randAmount.Next(1, 2000))).ToShortDateString();
                    aBillGeneral.Bill_General_DiscountPerc = 0;
                    aBillGeneral.Bill_General_IsCashCredit = 0;
                    aBillGeneral.Bill_General_NetAmount = 100;
                    aBillGeneral.Bill_General_Number = BillGeneralMgmt.NextBillNumber();
                    aBillGeneral.Bill_General_PaymentMethodID = 1;
                    aBillGeneral.Bill_General_PriceLevel = 1;
                    aBillGeneral.Bill_General_SalesDiscount = 0;
                    aBillGeneral.Bill_General_SubTotal = 100;
                    aBillGeneral.Bill_General_TellerID = userId;
                    aBillGeneral.Bill_General_Time =
                        DateTime.Now.ToShortTimeString();
                    aBillGeneral.Bill_General_TotalCost = randAmount.Next(50, 99);
                    aBillGeneral.Bill_General_TotalDiscount = 0;
                    aBillGeneral.Bill_General_TotalItems = numofDetailed;
                    aBillGeneral.Bill_General_TotalPrice = 100;
                    aBillGeneral.Bill_General_TotalTax = 16;
                    aBillGeneral.CustomerAccountAmountOld = 0;
                    aBillGeneral.Bill_General_Comments = "Test Sale";
                    aBillGeneral.Bill_General_CreditCardInfo = "NotCredit";

                    Random aRandom = new Random();

                    if (BillGeneralMgmt.InsertBill(aBillGeneral))
                    {
                        while (numofDetailed > 0)
                        {
                            BillDetailed aBillDetailed = new BillDetailed();
                            string aBarcode = "Test Item " + aRandom.Next(1, (int)NumberOfItems);
                            DataTable aItemRow = ItemsMgmt.SelectItemByBarCode(aBarcode);
                            if (aItemRow.Rows.Count != 0)
                            {
                                aBillDetailed.Bill_Detailed_ItemDescription = aItemRow.Rows[0]["Description"].ToString();
                                aBillDetailed.Bill_Detailed_ItemID = int.Parse(aItemRow.Rows[0]["ID"].ToString());
                                aBillDetailed.Bill_Detailed_Number = aBillGeneral.Bill_General_Number;
                                aBillDetailed.Bill_Detailed_OldAvaQty = double.Parse(aItemRow.Rows[0]["Qty"].ToString());
                                aBillDetailed.Bill_Detailed_OldAvgUnitCost =
                                    double.Parse(aItemRow.Rows[0]["AvgUnitCost"].ToString());
                                aBillDetailed.Bill_Detailed_Qty = numofDetailed;
                                aBillDetailed.Bill_Detailed_SellPrice = double.Parse(aItemRow.Rows[0]["SellPrice"].ToString());

                                aBillDetailed.Bill_Detailed_TotalPerUnit = aBillDetailed.Bill_Detailed_Qty *
                                                                           aBillDetailed.Bill_Detailed_SellPrice;

                                BillDetailedMgmt.InsertItem(aBillDetailed);
                            }
                            numofDetailed--;
                        }
                    }
                    if (cnt % 100 == 0)
                    {
                        label1.Text = $"Adding Bill {cnt}/{NumberOfBills} ... ({(cnt / NumberOfBills) * 100 })%";
                        Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error in {cnt} \n {ex}");
                }
            }
        }

        private void Add1000PurchaseVoucherBtn_Click(object sender, EventArgs e)
        {
            Random randAmount = new Random();
            int cnt = 1;
            var Vendors = VendorsMgmt.SelectAllVendors();
            int userId = int.Parse(UsersMgmt.SelectAllUsers().Rows[0]["ID"].ToString());
            while (cnt++ < NumberOfPurchases)
            {
                try
                {
                    PurchaseVoucherGeneral aPurchaseGeneral = new PurchaseVoucherGeneral();
                    aPurchaseGeneral.AccountID = 1;
                    aPurchaseGeneral.Comments = "";
                    aPurchaseGeneral.CurrencyID = 1;
                    aPurchaseGeneral.Date = DateTime.Now.Subtract(TimeSpan.FromDays(randAmount.Next(1, 2000))).ToShortDateString();
                    aPurchaseGeneral.DiscountPerc = 0;
                    aPurchaseGeneral.Fees = 10;
                    aPurchaseGeneral.IsCashCredit = 0;
                    aPurchaseGeneral.IsChecked = 0;
                    aPurchaseGeneral.IsRevised = 0;
                    aPurchaseGeneral.PaymentMethodID = 1;
                    aPurchaseGeneral.Subtotal = 100;
                    aPurchaseGeneral.TellerID = userId;
                    aPurchaseGeneral.Time = DateTime.Now.ToShortTimeString();
                    aPurchaseGeneral.TotalCost = 90;
                    aPurchaseGeneral.TotalDiscount = 0;
                    aPurchaseGeneral.TotalFreeItemsQty = 0;
                    aPurchaseGeneral.TotalItemsDiscount = 0;
                    aPurchaseGeneral.TotalTax = 10;
                    aPurchaseGeneral.VendorAccountAmountOld = 0;
                    aPurchaseGeneral.VendorID =
                        int.Parse(Vendors.Rows[(int)NumberOfPurchases % Vendors.Rows.Count]["ID"].ToString());
                    aPurchaseGeneral.VoucherNumber = PurchaseVoucherGeneralMgmt.NextVoucherNumber();
                    aPurchaseGeneral.CreditCardInfo = "";


                    int NumofDetailed = randAmount.Next(1, 20);
                    if (PurchaseVoucherGeneralMgmt.AddVoucher(aPurchaseGeneral))
                        while (NumofDetailed > 0)
                        {
                            PurchaseVoucherDetailed aPurchaseDetailed = new PurchaseVoucherDetailed();
                            string aBarcode = "Test Item " + randAmount.Next(1,(int) NumberOfItems).ToString();
                            DataTable aItemRow = ItemsMgmt.SelectItemByBarCode(aBarcode);
                            if (aItemRow.Rows.Count != 0)
                            {
                                aPurchaseDetailed.Purchase_Voucher_Detailed_ItemID =
                                    int.Parse(aItemRow.Rows[0]["ID"].ToString());
                                aPurchaseDetailed.Purchase_Voucher_Detailed_VoucherNumber =
                                    aPurchaseGeneral.VoucherNumber;
                                aPurchaseDetailed.Purchase_Voucher_Detailed_IsRevised = 0;
                                aPurchaseDetailed.Purchase_Voucher_Detailed_ItemCost =
                                    double.Parse(aItemRow.Rows[0]["AvgUnitCost"].ToString());
                                aPurchaseDetailed.Purchase_Voucher_Detailed_OldAvaQty =
                                    double.Parse(aItemRow.Rows[0]["Qty"].ToString());
                                aPurchaseDetailed.Purchase_Voucher_Detailed_Qty = NumofDetailed;
                                aPurchaseDetailed.Purchase_Voucher_Detailed_Discount = 0;
                                    // = double.Parse(aItemRow.Rows[0]["SellPrice"].ToString());
                                aPurchaseDetailed.Purchase_Voucher_Detailed_FreeItemsQty = 0;
                                    // aBillDetailed.Bill_Detailed_TotalPerUnit = aBillDetailed.Bill_Detailed_Qty * aBillDetailed.Bill_Detailed_SellPrice;
                                PurchaseVoucherDetailedMgmt.AddItem(aPurchaseDetailed);
                            }
                            NumofDetailed--;
                        }
                    if (cnt % 100 == 0)
                    {
                        label1.Text = $"Adding Purchase Order {cnt}/{NumberOfPurchases} ... ({(cnt / NumberOfPurchases) * 100 })%";
                        Application.DoEvents();
                    }
                }
                catch (Exception ex){ MessageBox.Show($"Error in {cnt} \n {ex}"); }
            }

        }

    }
}
