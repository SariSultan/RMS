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
    public partial class EditDisposeItems : Form
    {
        public EditDisposeItems()
        {
            InitializeComponent();
        }
private void TranslateUI()
        {
          //  this.RightToLeft = FlowDirectionManager.GetFlowDirection();
           //// this.RightToLeftLayout = true;
            BillNumberLbl.Text = UiText.EdtDspItmBillNumberLbl;
            CheckInfoGB.Text = UiText.EdtDspItmCheckInfoGB;
            CheckTime.Text = UiText.EdtDspItmCheckTime;
            CheckTimeLbl.Text = UiText.EdtDspItmCheckTimeLbl;
            ChkBillBtn.Text = UiText.EdtDspItmChkBillBtn;
            ChkDate.Text = UiText.EdtDspItmChkDate;
            ChkDateLbl.Text = UiText.EdtDspItmChkDateLbl;
            ChkedBy.Text = UiText.EdtDspItmChkedBy;
            ChkedByUserNameLbl.Text = UiText.EdtDspItmChkedByUserNameLbl;
            Date.Text = UiText.EdtDspItmDate;
            DisposalReasonLbl.Text = UiText.EdtDspItmDisposalReasonLbl;
            EditDisposeItemsLbl.Text = UiText.EdtDspItmEditDisposeItemsLbl;
            IsRevisedLbl.Text = UiText.EdtDspItmIsRevisedLbl;
            label2.Text = UiText.EdtDspItmlabel2;
            label3.Text = UiText.EdtDspItmlabel3;
            label4.Text = UiText.EdtDspItmlabel4;
            label5.Text = UiText.EdtDspItmlabel5;
            ReprintBtn.Text = UiText.EdtDspItmPaymentAndPrintBtn;
            PaymentGB.Text = UiText.EdtDspItmPaymentGB;
            ReviseBillBtn.Text = UiText.EdtDspItmReviseBillBtn;
            ReviseDate.Text = UiText.EdtDspItmReviseDate;
            ReviseDatelbl.Text = UiText.EdtDspItmReviseDatelbl;
            RevisedBy.Text = UiText.EdtDspItmRevisedBy;
            RevisedBylbl.Text = UiText.EdtDspItmRevisedBylbl;
            ReviseInfoGB.Text = UiText.EdtDspItmReviseInfoGB;
            ReviseLossProfit.Text = UiText.EdtDspItmReviseLossProfit;
            ReviseLossProfitLbl.Text = UiText.EdtDspItmReviseLossProfitLbl;
            ReviseTime.Text = UiText.EdtDspItmReviseTime;
            ReviseTimeLbl.Text = UiText.EdtDspItmReviseTimeLbl;
            SubtotalLbl.Text = UiText.EdtDspItmSubtotalLbl;
            TellerLbl.Text = UiText.EdtDspItmTellerLbl;
            Time.Text = UiText.EdtDspItmTime;
            TotalBillLbl.Text = UiText.EdtDspItmTotalBillLbl;
            TotalTaxlbl.Text = UiText.EdtDspItmTotalTaxlbl;
            UserName.Text = UiText.EdtDspItmUserName;


        }
    }
}
