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
    public partial class EditReturnItemsCustomer : Form
    {
        public EditReturnItemsCustomer()
        {
            InitializeComponent();
        }
        private void TranslateUI()
        {
            //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
           // this.RightToLeftLayout = true;
            BillNumberLbl.Text = UiText.EdtRtnItmBillNumberLbl;
            CheckInfoGB.Text = UiText.EdtRtnItmCheckInfoGB;
            CheckTime.Text = UiText.EdtRtnItmCheckTime;
            CheckTimeLbl.Text = UiText.EdtRtnItmCheckTimeLbl;
            ChkBillBtn.Text = UiText.EdtRtnItmChkBillBtn;
            ChkDate.Text = UiText.EdtRtnItmChkDate;
            ChkDateLbl.Text = UiText.EdtRtnItmChkDateLbl;
            ChkedBy.Text = UiText.EdtRtnItmChkedBy;
            ChkedByUserNameLbl.Text = UiText.EdtRtnItmChkedByUserNameLbl;
            CustomersAccountAmount.Text = UiText.EdtRtnItmCustomersAccountAmount;
            CustomerNameLbl.Text = UiText.EdtRtnItmCustomerNameLbl;
            Date.Text = UiText.EdtRtnItmDate;
            EditReturnItemsCustomerLbl.Text = UiText.EdtRtnItmEditReturnItemsCustomerLbl;
            IsRevisedLbl.Text = UiText.EdtRtnItmIsRevisedLbl;
            label2.Text = UiText.EdtRtnItmlabel2;
            label3.Text = UiText.EdtRtnItmlabel3;
            label4.Text = UiText.EdtRtnItmlabel4;
            label5.Text = UiText.EdtRtnItmlabel5;
            PaymentAndPrintBtn.Text = UiText.EdtRtnItmPaymentAndPrintBtn;
            PaymentGB.Text = UiText.EdtRtnItmPaymentGB;
            ReviseBillBtn.Text = UiText.EdtRtnItmReviseBillBtn;
            ReviseDate.Text = UiText.EdtRtnItmReviseDate;
            ReviseDatelbl.Text = UiText.EdtRtnItmReviseDatelbl;
            RevisedBy.Text = UiText.EdtRtnItmRevisedBy;
            RevisedBylbl.Text = UiText.EdtRtnItmRevisedBylbl;
            ReviseInfoGB.Text = UiText.EdtRtnItmReviseInfoGB;
            ReviseLossProfit.Text = UiText.EdtRtnItmReviseLossProfit;
            ReviseLossProfitLbl.Text = UiText.EdtRtnItmReviseLossProfitLbl;
            ReviseTime.Text = UiText.EdtRtnItmReviseTime;
            ReviseTimeLbl.Text = UiText.EdtRtnItmReviseTimeLbl;
            SubtotalLbl.Text = UiText.EdtRtnItmSubtotalLbl;
            TellerLbl.Text = UiText.EdtRtnItmTellerLbl;
            Time.Text = UiText.EdtRtnItmTime;
            TotalBillLbl.Text = UiText.EdtRtnItmTotalBillLbl;
            TotalTaxlbl.Text = UiText.EdtRtnItmTotalTaxlbl;
            UserName.Text = UiText.EdtRtnItmUserName;

        }
    }
}
