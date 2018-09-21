using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Calcium_RMS.CustomerScreen
{
    
    public class ThreadData
    {
       public DataTable aTable{get;set;}
    }

    public partial class CustomerScreenFrm : Form
    {

        System.Windows.Forms.Timer ThankYouTimer;
        public CustomerScreenFrm()
        {
            InitializeComponent();

            ThankYouTimer = new System.Windows.Forms.Timer();
            ThankYouTimer.Interval=10000;
            ThankYouTimer.Tick+=new EventHandler(SetWelcomeAgain);
            ThankYouTimer.Stop();
            SetWelcome();
        }

       
        private void SetWelcomeAgain(object sender, EventArgs e)
        {
            SetWelcome();
        }
        private void SetWelcome()
        {
            try
            {
                ThankYouTimer.Stop();
                Bitmap bitmap = new Bitmap(Application.StartupPath + @"\CustomerScreen\IMG1.png");
                Color clr = bitmap.GetPixel(0, 0);
                pictureBox1.BackgroundImage = bitmap;
            }
            catch(Exception ex)
            { 
               // MessageBox.Show(ex.Message + ex.ToString()); 
            }
        }
        private void SetThankYou()
        {
            try
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + @"\CustomerScreen\IMG2.png");
                Color clr = bitmap.GetPixel(0, 0);
                pictureBox1.BackgroundImage = bitmap;
                ThankYouTimer.Start();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message + ex.ToString()); 
            }
        }

        public void SetThankYouImage()
        {
            SetThankYou();
        }
        private void ShowIdleScreen()
        {
           // pictureBox1.BackgroundImage = aSlideShow[0];
            pictureBox1.Show();
            RightPanel.Hide();
            CustDGView.Hide();
        }
        private void HideIdleScreen()
        {
            pictureBox1.Hide();
            RightPanel.Show();
            CustDGView.Show();
        }
        #region Customer Options
        public class CustomerInfo
        {
            public string CustomerName { set; get; }
            public string CustomerPhone { get; set; }
            public string CustomerAccountAmoutn { get; set; }
            public bool Enabled { set; get; }
        }
        private void DisableCustomeroptions()
        {
            CustomerNameLbl.Hide();
            CustomerNameTxtBox.Hide();
            CustomerPhoneLbl.Hide();
            CustomersAccountAmount.Hide();
            CustomersAccountAmountTxtBox.Hide();
            PhoneTxtBox.Hide();
        }

        private void EnableCustomeroptions()
        {
            CustomerNameLbl.Show();
            CustomerNameTxtBox.Show();
            CustomerPhoneLbl.Show();
            CustomersAccountAmount.Show();
            CustomersAccountAmountTxtBox.Show();
            PhoneTxtBox.Show();
        }

        private void UpdateCustomerInfo(CustomerInfo __CustomerInfo)
        {
            if (__CustomerInfo.Enabled)
            {
                EnableCustomeroptions();
                CustomerNameTxtBox.Text = __CustomerInfo.CustomerName;
                CustomersAccountAmountTxtBox.Text = __CustomerInfo.CustomerAccountAmoutn.ToString();
                PhoneTxtBox.Text = __CustomerInfo.CustomerPhone;
            }
            else
            {
                DisableCustomeroptions();
            }
        }
        #endregion Customer Options

        public class CustomerScreenData
        {
            public CustomerInfo __CustomerInfo { set; get; }
            public DataTable __DGViewItems { set; get; }

            public string __PriceLevel { set; get; }
            public string __PriceLevelDiscount { set; get; }
            public string __DiscountPerc { set; get; }
            public string __DiscountBillAmt { set; get; }
            public string __TotalDiscount { set; get; }
            public string __Subtotal { set; get; }
            public string __Tax { set; get; }
            public string __TotBefTax { set; get; }
            public string __TotAmt { set; get; }

            public bool SetIdle { set; get; }
        }

        public void UpdateScreen(CustomerScreenData __SomeData)
        {
            if (__SomeData.SetIdle)
            {
                ResetScreen();
                ShowIdleScreen();
                //set the screen to idle
            }
            else
            {
                HideIdleScreen();
                UpdateCustomerInfo(__SomeData.__CustomerInfo);
                PriceLevelComboBox.Text = __SomeData.__PriceLevel;
                PriceLevelDiscount.Text = __SomeData.__PriceLevelDiscount.ToString();
                DiscountPercTxtBox.Text = __SomeData.__DiscountPerc.ToString();
                DiscountBillTxtBox.Text = __SomeData.__DiscountBillAmt.ToString();
                TotalDiscountTxtBox.Text = __SomeData.__TotalDiscount.ToString();
                SubtotalTxtBox.Text = __SomeData.__Subtotal.ToString();
                TaxTxtBox.Text = __SomeData.__Tax.ToString();
                NetAmountTxtBox.Text = __SomeData.__TotBefTax.ToString();
                TotalTxtBox.Text = __SomeData.__TotAmt.ToString();
                AddItemsToDGView(__SomeData.__DGViewItems);
            }
        }

        public void SetRowSelection(int Index)
        {
            CustDGView.FirstDisplayedScrollingRowIndex = Index;
        }
        private void ResetScreen()
        {
            try
            {
                if (CustDGView.Rows.Count>0)
                {
                    CustDGView.DataSource = null;
                }
                PriceLevelComboBox.Text = "Standard";
                PriceLevelDiscount.Text = "0.00";
                DiscountPercTxtBox.Text = "0.00%";
                DiscountBillTxtBox.Text = "0.00";
                TotalDiscountTxtBox.Text = "0.00";
                SubtotalTxtBox.Text = "0.00";
                TaxTxtBox.Text = "0.00";
                NetAmountTxtBox.Text = "0.00";
                TotalTxtBox.Text = "0.00";
                DisableCustomeroptions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.ToString());
            }
        }

        private void AddItemsToDGView(DataTable __DGViewTableItems)
        {
            ThreadData aData = new ThreadData();
            aData.aTable=__DGViewTableItems;
            Thread aThread=new Thread(ThreadExecute);
            aThread.Start(aData);
           // aThread.Join();
        }

        delegate void SetMessageCallback(object aThreadData);
        private void ThreadExecute(object aThreadData)
        {
            if (InvokeRequired)
            {
                SetMessageCallback d = new SetMessageCallback(ThreadExecute);
                this.BeginInvoke(d, new object[] { aThreadData });
                //Thread.CurrentThread.Abort();
            }
            else{
            ThreadData aData = aThreadData as ThreadData;
            DataTable __DGViewTableItems = aData.aTable;
            
            CustDGView.DataSource = __DGViewTableItems;
            CustDGView.Columns["Description"].HeaderText = "Description";
            CustDGView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustDGView.Columns["UnitPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustDGView.Columns["TaxLevel"].HeaderText = "Tax Level %";
            CustDGView.Columns["TaxLevel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustDGView.Columns["Quantity"].HeaderText = "Quantity";
            CustDGView.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustDGView.Columns["Total"].HeaderText = "Total Price";
            CustDGView.Columns["Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CustDGView.ClearSelection();
            CustDGView.FirstDisplayedScrollingRowIndex = __DGViewTableItems.Rows.Count - 1;
            
            //Thread.CurrentThread.Abort();
            }
            
        }




        
    }
}
