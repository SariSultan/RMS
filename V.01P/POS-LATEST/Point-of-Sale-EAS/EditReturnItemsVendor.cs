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
    public partial class EditReturnItemsVendor : Form
    {
        public EditReturnItemsVendor()
        {
            InitializeComponent();
        }

        private void TranslateUI()
        {
            //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
            //// this.RightToLeftLayout = true;
            BillNumberLbl.Text = UiText.EdtRtnItmVBillNumberLbl;
            CheckInfoGB.Text = UiText.EdtRtnItmVCheckInfoGB;
            CheckTime.Text = UiText.EdtRtnItmVCheckTime;
            CheckTimeLbl.Text = UiText.EdtRtnItmVCheckTimeLbl;
            ChkBillBtn.Text = UiText.EdtRtnItmVChkBillBtn;
            ChkDate.Text = UiText.EdtRtnItmVChkDate;
            ChkDateLbl.Text = UiText.EdtRtnItmVChkDateLbl;
            ChkedBy.Text = UiText.EdtRtnItmVChkedBy;
            ChkedByUserNameLbl.Text = UiText.EdtRtnItmVChkedByUserNameLbl;
            CompanyLbl.Text = UiText.EdtRtnItmVCompanyLbl;
            Date.Text = UiText.EdtRtnItmVDate;
            EditReturnItemsCustomerLbl.Text = UiText.EdtRtnItmVEditReturnItemsCustomerLbl;
            IsRevisedLbl.Text = UiText.EdtRtnItmVIsRevisedLbl;
            label2.Text = UiText.EdtRtnItmVlabel2;
            label3.Text = UiText.EdtRtnItmVlabel3;
            label4.Text = UiText.EdtRtnItmVlabel4;
            label5.Text = UiText.EdtRtnItmVlabel5;
            PaymentAndPrintBtn.Text = UiText.EdtRtnItmVPaymentAndPrintBtn;
            PaymentGB.Text = UiText.EdtRtnItmVPaymentGB;
            ReviseBillBtn.Text = UiText.EdtRtnItmVReviseBillBtn;
            ReviseDate.Text = UiText.EdtRtnItmVReviseDate;
            ReviseDatelbl.Text = UiText.EdtRtnItmVReviseDatelbl;
            RevisedBy.Text = UiText.EdtRtnItmVRevisedBy;
            RevisedBylbl.Text = UiText.EdtRtnItmVRevisedBylbl;
            ReviseInfoGB.Text = UiText.EdtRtnItmVReviseInfoGB;
            ReviseLossProfit.Text = UiText.EdtRtnItmVReviseLossProfit;
            ReviseLossProfitLbl.Text = UiText.EdtRtnItmVReviseLossProfitLbl;
            ReviseTime.Text = UiText.EdtRtnItmVReviseTime;
            ReviseTimeLbl.Text = UiText.EdtRtnItmVReviseTimeLbl;
            SubtotalLbl.Text = UiText.EdtRtnItmVSubtotalLbl;
            TellerLbl.Text = UiText.EdtRtnItmVTellerLbl;
            Time.Text = UiText.EdtRtnItmVTime;
            TotalBillLbl.Text = UiText.EdtRtnItmVTotalBillLbl;
            TotalTaxlbl.Text = UiText.EdtRtnItmVTotalTaxlbl;
            UserName.Text = UiText.EdtRtnItmVUserName;
            VendorAccountAmountLbl.Text = UiText.EdtRtnItmVVendorAccountAmountLbl;
            VendorLbl.Text = UiText.EdtRtnItmVVendorLbl;


        }
    }
}
