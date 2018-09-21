using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Text;
namespace Calcium_RMS
{
    public partial class ReturnItemsCustomer : Form
    {
        public ReturnItemsCustomer()
        {
            InitializeComponent();
 TranslateUI();

            //Add this Line To Each Constructor To Disable Maximize
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ReturnItemsCustomer_Load(object sender, EventArgs e)
        {
            this.itemsTableAdapter.WithoutBarcode(this.dbDataSet1.Items);
            this.itemsTableAdapter.Fill(this.dBDataSet.Items);
        }


        private void TranslateUI()
        {
            ReturnItemsCustomerLbl.Text = UiText.RetItmCstReturnItemsCustomerLbl;
            BillNumberLbl.Text = UiText.RetItmCstBillNumberLbl;
            UserName.Text = UiText.RetItmCstUserName;
            TellerLbl.Text = UiText.RetItmCstTellerLbl;
            ItemDescriptionLbl.Text = UiText.RetItmCstItemDescriptionLbl;
            BarcodeLbl.Text = UiText.RetItmCstBarcodeLbl;
            ItemsWithoutBarcodeLbl.Text = UiText.RetItmCstItemsWithoutBarcodeLbl;
            CustomerPhoneLbl.Text = UiText.RetItmCstCustomerPhoneLbl;
            CustomersAccountAmount.Text = UiText.RetItmCstCustomersAccountAmount;
            CustomerNameLbl.Text = UiText.RetItmCstCustomerNameLbl;
            SubtotalLbl.Text = UiText.RetItmCstSubtotalLbl;
            TotalTaxlbl.Text = UiText.RetItmCstTotalTaxlbl;
            TotalBillLbl.Text = UiText.RetItmCstTotalBillLbl;
            CancleBtn.Text = UiText.RetItmCstCancleBtn;
            PaymentOnlyBtn.Text = UiText.RetItmCstPaymentOnlyBtn;
            PaymentAndPrintBtn.Text = UiText.RetItmCstPaymentAndPrintBtn;

        }
    }
}
