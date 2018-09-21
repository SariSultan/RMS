using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Entities;
using Calcium_RMS.Text;
using System.IO;

namespace Calcium_RMS
{
    public partial class PrintingSettingsFrm : Form
    {
        bool IsLoading = false;
        public PrintingSettingsFrm()
        {
            InitializeComponent();
            ExitPB.Click += new EventHandler(Validators.ExitPBOnClick);
            ExitPB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            ExitPB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            MinimizePB.Click += new EventHandler(Validators.MinimizePBOnClick);
            MinimizePB.MouseHover += new EventHandler(Validators.ExitAndMinimizeMouseHover);
            MinimizePB.MouseLeave += new EventHandler(Validators.ExitAndMinimizeMouseLeave);

            UpdateForm();

        }

        private void UpdateForm()
        {
            try
            {
                IsLoading = true;
                DataTable aBillHeader = PrintingSettingsMgmt.SelectBillsHeaders(0, 0);
                DataTable aBillFooter = PrintingSettingsMgmt.SelectBillsHeaders(1, 0);
                DataTable aReportHeader = PrintingSettingsMgmt.SelectBillsHeaders(0, 1);
                DataTable aReportFooter = PrintingSettingsMgmt.SelectBillsHeaders(1, 1);
                if (aBillHeader != null)
                {
                    foreach (DataRow aRow in aBillHeader.Rows)
                    {
                        if (aRow["Number"].ToString() == "1")
                        {
                            bh1TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "2")
                        {
                            bh2TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "3")
                        {
                            bh3TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "4")
                        {
                            bh4TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "5")
                        {
                            bh5TxtBox.Text = aRow["Data"].ToString();
                        }
                    }
                }

                if (aBillFooter != null)
                {
                    foreach (DataRow aRow in aBillFooter.Rows)
                    {
                        if (aRow["Number"].ToString() == "1")
                        {
                            bf1TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "2")
                        {
                            bf2TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "3")
                        {
                            bf3TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "4")
                        {
                            bf4TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "5")
                        {
                            bf5TxtBox.Text = aRow["Data"].ToString();
                        }
                    }
                }

                //-------------- Starting Report Data
                if (aReportHeader != null)
                {
                    foreach (DataRow aRow in aReportHeader.Rows)
                    {
                        if (aRow["Number"].ToString() == "1")
                        {
                            rh1TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "2")
                        {
                            rh2TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "3")
                        {
                            rh3TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "4")
                        {
                            rh4TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "5")
                        {
                            rh5TxtBox.Text = aRow["Data"].ToString();
                        }
                    }
                }

                if (aReportFooter != null)
                {
                    foreach (DataRow aRow in aReportFooter.Rows)
                    {
                        if (aRow["Number"].ToString() == "1")
                        {
                            rf1TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "2")
                        {
                            rf2TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "3")
                        {
                            rf3TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "4")
                        {
                            rf4TxtBox.Text = aRow["Data"].ToString();
                        }
                        else if (aRow["Number"].ToString() == "5")
                        {
                            rf5TxtBox.Text = aRow["Data"].ToString();
                        }
                    }
                }

                //---------------------
                PrintLogoChkBox.Checked = ConfigurationHelper.IsPrintLogoEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [PrintingSettingsForm] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { IsLoading = false; }

        }

        private void UpdateBillsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintingSettings aPrintingSettings = new PrintingSettings();
                aPrintingSettings.BillOrReport = 0;
                int aCnt = 0;
                //Headers
                aPrintingSettings.HeaderOrFooter = 0;
                //
                aPrintingSettings.Data = bh1TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bh2TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bh3TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bh4TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bh5TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aCnt = 0;

                //Footers
                aPrintingSettings.HeaderOrFooter = 1;
                //
                aPrintingSettings.Data = bf1TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bf2TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bf3TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bf4TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = bf5TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [PritingSettingFrm: UpdateBillsBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateForm();
        }

        private void UpdateReportsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintingSettings aPrintingSettings = new PrintingSettings();
                aPrintingSettings.BillOrReport = 1;
                int aCnt = 0;
                //Headers
                aPrintingSettings.HeaderOrFooter = 0;
                //
                aPrintingSettings.Data = rh1TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rh2TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rh3TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rh4TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rh5TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aCnt = 0;
                //Footers
                aPrintingSettings.HeaderOrFooter = 1;
                //
                aPrintingSettings.Data = rf1TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rf2TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rf3TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rf4TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                aPrintingSettings.Data = rf5TxtBox.Text;
                aPrintingSettings.Number = ++aCnt;
                PrintingSettingsMgmt.InsertLine(aPrintingSettings);
                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [PritingSettingFrm: UpdateReportsBtn_Click] \n Exception: \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateForm();
        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.PrintingSettingFormName;
                BillsGB.Text = UiText.PrntStgBillsGB;
                label1.Text = UiText.PrntStglabel1;
                label2.Text = UiText.PrntStglabel2;
                label3.Text = UiText.PrntStglabel3;
                label4.Text = UiText.PrntStglabel4;
                label5.Text = UiText.PrntStglabel5;
                label6.Text = UiText.PrntStglabel6;
                label7.Text = UiText.PrntStglabel7;
                label8.Text = UiText.PrntStglabel8;
                label9.Text = UiText.PrntStglabel9;
                label10.Text = UiText.PrntStglabel10;
                UpdateBillsBtn.Text = UiText.PrntStgUpdateBillsBtn;
                ReportsGB.Text = UiText.PrntStgReportsGB;
                label11.Text = UiText.PrntStglabel11;
                label12.Text = UiText.PrntStglabel12;
                label13.Text = UiText.PrntStglabel13;
                label14.Text = UiText.PrntStglabel14;
                label15.Text = UiText.PrntStglabel15;
                label16.Text = UiText.PrntStglabel16;
                label17.Text = UiText.PrntStglabel17;
                label18.Text = UiText.PrntStglabel18;
                label19.Text = UiText.PrntStglabel19;
                label20.Text = UiText.PrntStglabel20;
                UpdateReportsBtn.Text = UiText.PrntStgUpdateReportsBtn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ReceiptLangComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!IsLoading)
                {
                    if (ReceiptLangComboBox.SelectedText != null)
                    {
                        if (ConfigurationHelper.UpdateReceiptLanguage(ReceiptLangComboBox.Text))
                        {
                            MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string LangCheck;
                            LangCheck = ConfigurationHelper.GetReceiptLanguage();
                            if (!LangCheck.Contains("ERROR"))
                            {
                                if (LangCheck.ToUpper() == "ARABIC")
                                {
                                    string CurrentCulture = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();
                                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-JO");
                                    Reports.ReportsHelper.ReceiptRTL = true;
                                    ReceiptName.TranslateReceiptText();
                                    ReceiptText.TranslateReceiptText();
                                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CurrentCulture);
                                    //TRANSLATE RECIEPT
                                }
                                else
                                {
                                    string CurrentCulture = System.Threading.Thread.CurrentThread.CurrentUICulture.ToString();
                                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                                    Reports.ReportsHelper.ReceiptRTL = false;
                                    ReceiptName.TranslateReceiptText();
                                    ReceiptText.TranslateReceiptText();
                                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(CurrentCulture);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.UnexpectedError, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogoSelectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog aDial = new OpenFileDialog();
            aDial.Filter = "Image Files (*.JPG)|*.jpg";
            if (aDial.ShowDialog() == DialogResult.OK)
            {
                File.Copy(aDial.FileName, Application.StartupPath + @"\Logo.jpg", true);
                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrintLogoChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsLoading)
            {
                ConfigurationHelper.UpdateReceiptLogo(PrintLogoChkBox.Checked);
                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void PrintingSettingsFrm_Load(object sender, EventArgs e)
        {
            IsLoading = true;
            string LangCheck;
            LangCheck = ConfigurationHelper.GetReceiptLanguage();
            if (!LangCheck.Contains("ERROR"))
            {
                if (LangCheck.ToUpper() == "ARABIC")
                {
                    ReceiptLangComboBox.SelectedIndex = 1;
                }
                else
                {
                    ReceiptLangComboBox.SelectedIndex = 0;
                }
            }
            IsLoading = false;
        }

    }
}
