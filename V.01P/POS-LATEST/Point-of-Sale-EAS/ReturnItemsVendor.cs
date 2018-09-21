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
    public partial class ReturnItemsVendor : Form
    {
        public ReturnItemsVendor()
        {
            InitializeComponent();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);
            //Add this Line To Each Constructor To Disable Maximize
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
			 TranslateUI();
        }

        private void ReturnItemsVendor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet1.Vendors' table. You can move, or remove it, as needed.
          //  this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);

        }

        private void TranslateUI()
        {
            ReturnItemsVendorLbl.Text = UiText.RetItmVndReturnItemsVendorLbl;
            BillNumberLbl.Text = UiText.RetItmVndBillNumberLbl;
            UserName.Text = UiText.RetItmVndUserName;
            TellerLbl.Text = UiText.RetItmVndTellerLbl;
            ItemDescriptionLbl.Text = UiText.RetItmVndItemDescriptionLbl;
            BarcodeLbl.Text = UiText.RetItmVndBarcodeLbl;
            ItemsWithoutBarcodeLbl.Text = UiText.RetItmVndItemsWithoutBarcodeLbl;
            CompanyLbl.Text = UiText.RetItmVndCompanyLbl;
            VendorAccountAmountLbl.Text = UiText.RetItmVndVendorAccountAmountLbl;
            VendorLbl.Text = UiText.RetItmVndVendorLbl;
            SubtotalLbl.Text = UiText.RetItmVndSubtotalLbl;
            TotalTaxlbl.Text = UiText.RetItmVndTotalTaxlbl;
            TotalBillLbl.Text = UiText.RetItmVndTotalBillLbl;
            CancleBtn.Text = UiText.RetItmVndCancleBtn;
            PaymentOnlyBtn.Text = UiText.RetItmVndPaymentOnlyBtn;
            PaymentAndPrintBtn.Text = UiText.RetItmVndPaymentAndPrintBtn;

        }
    }
}
