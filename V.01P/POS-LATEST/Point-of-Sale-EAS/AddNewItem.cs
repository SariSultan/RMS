using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Entities;
using Calcium_RMS.Management;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class AddNewItem : Form
    {
        Color BarcodeTxtBoxBGColor = Color.White;
        Color QtyTxtBoxBGColor = Color.White;
        Color RenderTxtBoxBGColor = Color.White;
        Color DescriptionBGColor = Color.White;
        Color SellPriceBGColor = Color.White;
        Color AvgUnitCostBGColor = Color.White;

        bool semaphore = false;

        DataTable aPriceLevelsTable = null;

        int DivisionScale = 1;
        int BarcodeLength = 1;
        bool aThereIsWeigth = false;

        public AddNewItem()
        {
            InitializeComponent();

            BarcodeTxtBoxBGColor = BarcodeTxtBox.BackColor;
            QtyTxtBoxBGColor = QtyTxtBox.BackColor;
            RenderTxtBoxBGColor = RenderPointTxtBox.BackColor;
            DescriptionBGColor = DescriptionTxtBox.BackColor;
            SellPriceBGColor = SellPriceTxtBox.BackColor;
            AvgUnitCostBGColor = AvgCostTxtBox.BackColor;

            SellPriceTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
            AvgCostTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
            MarginTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
            QtyTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
            RenderPointTxtBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);

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

        private void AddNewItem_Load(object sender, EventArgs e)
        {
            try
            {
                // AvgCostTxtBox.BackColor = Color.Transparent;
                this.WindowState = FormWindowState.Maximized;
                // TODO: This line of code loads data into the 'dBDataSet.Items' table. You can move, or remove it, as needed.
                this.itemsTableAdapter.Fill(this.dBDataSet.Items);
                // TODO: This line of code loads data into the 'dBDataSet.TaxLevel' table. You can move, or remove it, as needed.
                this.taxLevelTableAdapter.Fill(this.dBDataSet.TaxLevel);
                // TODO: This line of code loads data into the 'dBDataSet.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
                // TODO: This line of code loads data into the 'dBDataSet.ItemCategory' table. You can move, or remove it, as needed.
                this.itemCategoryTableAdapter.Fill(this.dBDataSet.ItemCategory);
                // TODO: This line of code loads data into the 'dBDataSet.ItemType' table. You can move, or remove it, as needed.
                this.itemTypeTableAdapter.Fill(this.dBDataSet.ItemType);

                aPriceLevelsTable = PriceLevelsMgmt.SelectAll();
                if (aPriceLevelsTable != null)
                {
                    if (aPriceLevelsTable.Rows.Count > 0)
                    {
                        foreach (DataRow r in aPriceLevelsTable.Rows)
                        {
                            if (r["Name"].ToString() != "Standard")
                            {
                                Label aLabel = new Label();
                                aLabel.Text = r["Name"].ToString();
                                TextBox aTextBox = new TextBox();
                                aTextBox.Text = SellPriceTxtBox.Text;
                                aTextBox.Name = r["Name"].ToString();
                                aTextBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
                                Pricing.Controls.Add(aLabel);
                                Pricing.Controls.Add(aTextBox);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n" + MsgTxt.CannotFindTxt + " " + MsgTxt.PriceLevelsTxt + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }

                DataRow aWeightRow = WeightMgmt.SelectWeightRow();
                if (aWeightRow != null)
                {
                    if (int.TryParse(aWeightRow["DivisionScale"].ToString(), out DivisionScale) && int.TryParse(aWeightRow["BarcodeLength"].ToString(), out BarcodeLength))
                    {
                        if (DivisionScale > 0 && BarcodeLength > 0)
                        {
                            aThereIsWeigth = true;
                        }
                    }
                }
                else
                {
                    //show error or no ?
                }
            }
            catch (Exception ex) //Launching Error Please Report It To Sari King [Database error 99%]
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddNewItem_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validators.TxtBoxNotEmpty(BarcodeTxtBox.Text) || WithoutBarcodeChkBox.Checked)
                {
                    BarcodeTxtBox.BackColor = BarcodeTxtBoxBGColor;
                    double ParsingOutTester = 0;
                    if (Validators.TxtBoxNotEmpty(QtyTxtBox.Text) && double.TryParse(QtyTxtBox.Text, out ParsingOutTester))
                    {
                        QtyTxtBox.BackColor = QtyTxtBoxBGColor;
                        if (Validators.TxtBoxNotEmpty(RenderPointTxtBox.Text) && double.TryParse(RenderPointTxtBox.Text, out ParsingOutTester))
                        {
                            RenderPointTxtBox.BackColor = RenderTxtBoxBGColor;
                            if (Validators.TxtBoxNotEmpty(DescriptionTxtBox.Text))
                            {
                                DescriptionTxtBox.BackColor = DescriptionBGColor;
                                if (Validators.TxtBoxNotEmpty(SellPriceTxtBox.Text) && double.TryParse(SellPriceTxtBox.Text, out ParsingOutTester))
                                {
                                    SellPriceTxtBox.BackColor = SellPriceBGColor;
                                    if (Validators.TxtBoxNotEmpty(AvgCostTxtBox.Text) && double.TryParse(AvgCostTxtBox.Text, out ParsingOutTester))
                                    {
                                        AvgCostTxtBox.BackColor = AvgUnitCostBGColor;

                                        bool IsPriceLevelsEmpty = false;

                                        foreach (var tb in Pricing.Controls.OfType<TextBox>())
                                        {
                                            if (!Validators.TxtBoxNotEmpty(tb.Text) || !double.TryParse(tb.Text, out ParsingOutTester))
                                            {
                                                IsPriceLevelsEmpty = true;
                                                tb.BackColor = SharedVariables.TxtBoxRequiredColor;
                                            }
                                            else
                                            {
                                                tb.BackColor = Color.White;
                                            }
                                        }
                                        if (IsPriceLevelsEmpty)
                                        {
                                            MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.PriceLevelsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                        else
                                        {
                                            Items aItem = new Items();
                                            if (TypeComboBox.SelectedValue ==null || CategoryComboBox.SelectedValue==null || VendorComboBox.SelectedValue==null ||TaxLevelComboBox.SelectedValue==null)
                                            {
                                                MessageBox.Show(MsgTxt.PleaseAddAllRequiredFields, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                return;
                                            }
                                            aItem.Item_Type = (int)TypeComboBox.SelectedValue;
                                            aItem.Item_Category = (int)CategoryComboBox.SelectedValue;
                                            aItem.Vendor = (int)VendorComboBox.SelectedValue;
                                            aItem.Item_Tax_Level = (int)TaxLevelComboBox.SelectedValue;

                                            if (WithoutBarcodeChkBox.Checked)
                                            {
                                                aItem.IsWithoutBarcode = 1;
                                                int aWithoutBarcode_Barcode = ItemsMgmt.SelectWithoutBarcode_Barcode(); ;
                                                if (aWithoutBarcode_Barcode == 0)
                                                {
                                                    MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddItemBtn_Click:Cannot Select Without Barcode _ Barcode] \n" + MsgTxt.PleaseTryAgainLaterTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    return;
                                                }
                                                while (ItemsMgmt.IsItemExist(aWithoutBarcode_Barcode.ToString()))
                                                {
                                                    aWithoutBarcode_Barcode++;
                                                }
                                                aItem.Item_Barcode = "NOBC" + aWithoutBarcode_Barcode.ToString();
                                            }
                                            else
                                            {
                                                if (aThereIsWeigth && WeightChkBox.Checked && BarcodeTxtBox.Text.Length >= BarcodeLength)
                                                {
                                                    aItem.IsWeight = 1;
                                                    aItem.IsWithoutBarcode = 0;
                                                    aItem.Item_Barcode = BarcodeTxtBox.Text.Substring(0, BarcodeLength);
                                                }
                                                else
                                                {
                                                    aItem.IsWeight = 0;
                                                    aItem.IsWithoutBarcode = 0;
                                                    aItem.Item_Barcode = BarcodeTxtBox.Text;
                                                }
                                            }
                                            if (!ItemsMgmt.IsItemExist(aItem.Item_Barcode))
                                            {
                                                aItem.Item_Description = DescriptionTxtBox.Text;
                                                aItem.Avalable_Qty = double.Parse(QtyTxtBox.Text);
                                                aItem.Render_Point = double.Parse(RenderPointTxtBox.Text);
                                                aItem.Entry_Date = DateTime.Now.ToShortDateString();

                                                double aSellPrice = double.Parse(SellPriceTxtBox.Text);
                                                double aUnitCost = double.Parse(AvgCostTxtBox.Text);
                                                double aTax = double.Parse(ItemTaxLevelMgmt.SelectItemTaxByID(aItem.Item_Tax_Level));

                                                if (TaxEnclodedChkBox.Checked)
                                                {

                                                    aItem.Sell_Price = Math.Round(aSellPrice / ((aTax / 100) + 1), 5);
                                                    aItem.Avg_Unit_Cost = Math.Round(aUnitCost / ((aTax / 100) + 1), 5);
                                                }
                                                else
                                                {
                                                    aItem.Sell_Price = aSellPrice;
                                                    aItem.Avg_Unit_Cost = aUnitCost;
                                                }
                                                if (!ItemsMgmt.AddItem(aItem))
                                                {
                                                    MessageBox.Show(MsgTxt.UnexpectedError + "DataBase: ItemsMgmt.AddItem" + MsgTxt.DidnotAdded + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    this.Close();
                                                }
                                                int ItemID = ItemsMgmt.SelectItemIDByBarcode(aItem.Item_Barcode);
                                                foreach (var tb in Pricing.Controls.OfType<TextBox>())
                                                {
                                                    double atbSellPrice = double.Parse(tb.Text);
                                                    if (TaxEnclodedChkBox.Checked)
                                                    {
                                                        atbSellPrice = Math.Round(atbSellPrice / ((aTax / 100) + 1), 5);
                                                    }
                                                    Nullable<int> PriceLevelID = PriceLevelsMgmt.SelectPriceLevelIDByName(tb.Name);
                                                    if (PriceLevelID != null)
                                                    {
                                                        Nullable<int> IsAddSpecialPriceOK = SpecialPricesMgmt.AddSpecialPrice(ItemID, (int)PriceLevelID, atbSellPrice);
                                                        if (IsAddSpecialPriceOK == null)
                                                        {
                                                            MessageBox.Show(MsgTxt.PriceLevelsTxt + " " + tb.Name + " " + MsgTxt.DidnotAdded + "\n", MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show(MsgTxt.UnexpectedError + "DataBase: " + MsgTxt.PriceLevelsTxt + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        this.Close();
                                                    }
                                                }

                                                MessageBox.Show(MsgTxt.AddedSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                DialogResult ret;
                                                ret = MessageBox.Show(MsgTxt.AddAnotherItemTxt, MsgTxt.InformationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                                if (ret == DialogResult.Yes)
                                                {
                                                    ReloadForm();
                                                }
                                                else
                                                {
                                                    this.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show(MsgTxt.BarcodeTxt + " " + MsgTxt.AlreadyUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                BarcodeTxtBox.Text = "";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.UnitCostTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        AvgCostTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                                        AvgCostTxtBox.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.SellingPriceTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    SellPriceTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                                    SellPriceTxtBox.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.DescriptionTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                DescriptionTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                                DescriptionTxtBox.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.RenderPointTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            RenderPointTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                            RenderPointTxtBox.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.ValidQtyTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        QtyTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                        QtyTxtBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.BarcodeTxt + "\n2)" + MsgTxt.IfNotBarChkWithoutBarcodeTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BarcodeTxtBox.BackColor = SharedVariables.TxtBoxRequiredColor;
                    BarcodeTxtBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddItemBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }

        }

        private void ReloadForm()
        {
            BarcodeTxtBox.Clear();
            DescriptionTxtBox.Clear();
        }

        private void AddNewTypeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewItemType aAddNewItemType = new AddNewItemType();
                aAddNewItemType.ShowDialog();
                this.itemTypeTableAdapter.Fill(this.dBDataSet.ItemType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewTypeBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddNewCategoryBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewCategory aAddNewCategory = new AddNewCategory();
                aAddNewCategory.ShowDialog();
                this.itemCategoryTableAdapter.Fill(this.dBDataSet.ItemCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewCategoryBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddNewVendorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddVendor aAddVendor = new AddVendor();
                aAddVendor.ShowDialog();
                this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewVendorBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddNewTaxLevelBtn_Click(object sender, EventArgs e)
        {

            try
            {
                AddTaxLevel aAddTaxLevel = new AddTaxLevel();
                aAddTaxLevel.ShowDialog();
                this.taxLevelTableAdapter.Fill(this.dBDataSet.TaxLevel);
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewTaxLevelBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AddNewPriceLevelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewPriceLevel aAddNewPriceLevel = new AddNewPriceLevel();
                aAddNewPriceLevel.ShowDialog();
                aPriceLevelsTable = PriceLevelsMgmt.SelectAll();
                Pricing.Controls.Clear();
                if (aPriceLevelsTable.Rows.Count > 0)
                {
                    foreach (DataRow r in aPriceLevelsTable.Rows)
                    {
                        if (r["Name"].ToString() != "Standard")
                        {
                            Label aLabel = new Label();
                            aLabel.Text = r["Name"].ToString();
                            TextBox aTextBox = new TextBox();
                            aTextBox.Text = SellPriceTxtBox.Text;
                            aTextBox.Name = r["Name"].ToString();
                            aTextBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
                            Pricing.Controls.Add(aLabel);
                            Pricing.Controls.Add(aTextBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewPriceLevelBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void WithoutBarcodeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (WithoutBarcodeChkBox.Checked)
                {
                    BarcodeTxtBox.Text = "";
                    BarcodeTxtBox.Enabled = false;
                    WeightChkBox.Checked = false;
                    WeightChkBox.Enabled = false;
                }
                else
                {
                    BarcodeTxtBox.Text = "";
                    BarcodeTxtBox.Enabled = true;
                    WeightChkBox.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[WithoutBarcodeChkBox_CheckedChanged] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.AddNewItemFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                //// this.RightToLeftLayout = true;
                AddItemBtn.Text = UiText.AddItmAddItemBtn;
                AddNewCategoryBtn.Text = UiText.AddItmAddNewCategoryBtn;
                AddNewItemLbl.Text = UiText.AddItmAddNewItemLbl;
                AddNewPriceLevelBtn.Text = UiText.AddItmAddNewPriceLevelBtn;
                AddNewTaxLevelBtn.Text = UiText.AddItmAddNewTaxLevelBtn;
                AddNewTypeBtn.Text = UiText.AddItmAddNewTypeBtn;
                AddNewVendorBtn.Text = UiText.AddItmAddNewVendorBtn;
                AvgCostLbl.Text = UiText.AddItmAvgCostLbl;
                BarcodeLbl.Text = UiText.AddItmBarcodeLbl;
                CategoryLbl.Text = UiText.AddItmCategoryLbl;
                DescriptionLbl.Text = UiText.AddItmDescriptionLbl;
                ItemInfoGB.Text = UiText.AddItmItemInfoGB;
                ItemTypeLbl.Text = UiText.AddItmItemTypeLbl;
                MarginLbl.Text = UiText.AddItmMarginLbl;
                PricingGB.Text = UiText.AddItmPricingGB;
                PricingLbl.Text = UiText.AddItmPricingLbl;
                QtyLbl.Text = UiText.AddItmQtyLbl;
                RequiredFieldLbl.Text = UiText.AddItmRequiredFieldLbl;
                RenderPointLbl.Text = UiText.AddItmRenderPointLbl;
                SellPriceLbl.Text = UiText.AddItmSellPriceLbl;
                TaxEnclodedChkBox.Text = UiText.AddItmTaxEnclodedChkBox;
                TaxLevelLbl.Text = UiText.AddItmTaxLevelLbl;
                VendorLbl.Text = UiText.AddItmVendorLbl;
                WeightChkBox.Text = UiText.AddItmWeightChkBox;
                WithoutBarcodeChkBox.Text = UiText.AddItmWithoutBarcodeChkBox;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        double TestParsingOut;
        private void MarginTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(MarginTxtBox.Text, out TestParsingOut) && !semaphore)
                {
                    if (double.TryParse(AvgCostTxtBox.Text, out TestParsingOut))
                    {
                        semaphore = true;
                        SellPriceTxtBox.Text = ((double.Parse(MarginTxtBox.Text) / 100) * double.Parse(AvgCostTxtBox.Text) + double.Parse(AvgCostTxtBox.Text)).ToString();
                        semaphore = false;
                    }
                    else if (double.TryParse(SellPriceTxtBox.Text, out TestParsingOut))
                    {
                        semaphore = true;
                        AvgCostTxtBox.Text = (TestParsingOut - (double.Parse(MarginTxtBox.Text) / 100 * TestParsingOut)).ToString();
                        semaphore = false;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[MarginTxtBox_TextChanged] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void AvgCostTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(MarginTxtBox.Text, out TestParsingOut) && double.TryParse(AvgCostTxtBox.Text, out TestParsingOut) && !semaphore)
                {
                    semaphore = true;
                    SellPriceTxtBox.Text = ((double.Parse(MarginTxtBox.Text) / 100) * double.Parse(AvgCostTxtBox.Text) + double.Parse(AvgCostTxtBox.Text)).ToString();
                    semaphore = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AvgCostTxtBox_TextChanged] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void SellPriceTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (var TB in Pricing.Controls.OfType<TextBox>())
                {
                    TB.Text = SellPriceTxtBox.Text;
                }
                if (double.TryParse(SellPriceTxtBox.Text, out TestParsingOut) && double.TryParse(AvgCostTxtBox.Text, out TestParsingOut))
                {
                    if (!semaphore)
                    {
                        semaphore = true;
                        MarginTxtBox.Text = ((double.Parse(SellPriceTxtBox.Text) - double.Parse(AvgCostTxtBox.Text)) * 100 / double.Parse(AvgCostTxtBox.Text)).ToString();
                        semaphore = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[SellPriceTxtBox_TextChanged] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        //MAKE THE BORDERLESS MOVABLE
        //protected override void WndProc(ref Message m)
        //{
        //    try
        //    {
        //        switch (m.Msg)
        //        {
        //            case 0x84:
        //                base.WndProc(ref m);
        //                if ((int)m.Result == 0x1)
        //                    m.Result = (IntPtr)0x2;
        //                return;
        //        }
        //        base.WndProc(ref m);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WndProc] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        throw;
        //    }

        //}

        //Garbage Collector
        protected override void OnClosed(EventArgs e)
        {
            try
            {
                foreach (object obj in this.Controls)
                {
                    if (obj is IDisposable)
                    {
                        (obj as IDisposable).Dispose();
                    }
                }
                base.OnClosed(e);
                base.Dispose();
                this.Dispose();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [OnClosed] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

       
    }
}
