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
    public partial class EditItems : Form
    {
        bool IsUpdating = false;
        bool OnExit = false;
        bool semaphore = false;
        bool IsLoading = true;
        DataTable aPriceLevelsTable;
        DataTable aItemData = null;

        Color BarcodeTxtBoxBGColor = Color.White;
        Color QtyTxtBoxBGColor = Color.White;
        Color RenderTxtBoxBGColor = Color.White;
        Color DescriptionBGColor = Color.White;
        Color SellPriceBGColor = Color.White;
        Color AvgUnitCostBGColor = Color.White;

        public EditItems()
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
            TranslateUI();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {
            try
            {
                IsLoading = true;
                // TODO: This line of code loads data into the 'dBDataSet2.TaxLevel' table. You can move, or remove it, as needed.
                this.taxLevelTableAdapter.Fill(this.dBDataSet2.TaxLevel);
                // TODO: This line of code loads data into the 'dBDataSet2.Vendors' table. You can move, or remove it, as needed.
                this.vendorsTableAdapter.Fill(this.dBDataSet2.Vendors);
                // TODO: This line of code loads data into the 'dBDataSet2.ItemCategory' table. You can move, or remove it, as needed.
                this.itemCategoryTableAdapter.Fill(this.dBDataSet2.ItemCategory);
                // TODO: This line of code loads data into the 'dBDataSet2.ItemType' table. You can move, or remove it, as needed.
                this.itemTypeTableAdapter.Fill(this.dBDataSet2.ItemType);

                this.itemsTableAdapter.WithBarcode(this.dBDataSet.Items);
                this.itemsTableAdapter1.WithoutBarcode(this.dBDataSet2.Items);

                ByBarcDescChkBox.Enabled = true;
                ByBarcDescChkBox.Checked = true;
                BarcodeToEditTxtBox.Enabled = true;
                ItemDescriptionComboBox.Enabled = false;
                WithoutBarcodeComboBox.Enabled = false;
                IsLoading = false;
            }
            catch (Exception ex) //Launching Error Please Report It To Sari King [Database error 99%]
            {
                IsLoading = false;
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\nException: IN[AddNewItem_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Items aaItem = new Items();
            aaItem.Item_Type = (int)TypeComboBox.SelectedValue;
            aaItem.Item_Category = (int)CategoryComboBox.SelectedValue;
            aaItem.Vendor = (int)VendorComboBox.SelectedValue;
            aaItem.Item_Tax_Level = (int)TaxLevelComboBox.SelectedValue;
            aaItem.Item_Barcode = BarcodeTxtBox.Text;
            aaItem.Item_Description = DescriptionTxtBox.Text;
            aaItem.Avalable_Qty = double.Parse(QtyTxtBox.Text);
            aaItem.Render_Point = double.Parse(RenderPointTxtBox.Text);
            // aaItem.Entry_Date = DateTxtBox.Text;
            aaItem.Sell_Price = double.Parse(SellPriceTxtBox.Text);
            aaItem.Avg_Unit_Cost = double.Parse(AvgCostTxtBox.Text);
            // aaItem.PriceLevelID = int.Parse(SaleTxtBox.Text);
            // aaItem.Item_ID = int.Parse(IDTxtBox.Text);
            try
            {
                if (!ItemsMgmt.IsItemExist(BarcodeTxtBox.Text) || BarcodeTxtBox.Text == BarcodeToEditTxtBox.Text)
                {
                    ItemsMgmt.UpdateItemByID(aaItem);
                    MessageBox.Show("DONE");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Barcode " + BarcodeTxtBox.Text + " Already Exist in the system");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateVariables(DataRow aItemRow)
        {
            try
            {
                
                if (aItemRow["IsWithoutBarcode"].ToString()=="1")
                {
                    WithoutBarcodeChkBox.Checked = true;
                    WithoutBarcodeComboBox.SelectedText = aItemRow["Description"].ToString();
                    WithoutBarcodeComboBox.Text = aItemRow["Description"].ToString();
                    
                }
                else
                {
                    BarcodeToEditTxtBox.Text = aItemRow["Barcode"].ToString();
                    KeyPressEventArgs e = new KeyPressEventArgs((char)Keys.Return);
                    BarcodeToEditTxtBox_KeyPress(BarcodeTxtBox, e);
                }
                
            }
            catch (Exception ex)
            {
                IsUpdating = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[UpdateVariables] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void UpdateMargin()
        {
            double TestParser;
            if (!double.TryParse(SellPriceTxtBox.Text,out TestParser) || !double.TryParse(AvgCostTxtBox.Text,out TestParser))
            {
                return;
            }

            try
            {
                MarginTxtBox.Text =Math.Round( ((double.Parse(SellPriceTxtBox.Text) - double.Parse(AvgCostTxtBox.Text)) * 100 / double.Parse(AvgCostTxtBox.Text)),3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[UpdateMargin] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void WithoutBarcodeChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WithoutBarcodeChkBox.Checked)
            {
                BarcodeToEditTxtBox.Clear();
                BarcodeToEditTxtBox.Enabled = false;
                ItemDescriptionComboBox.Enabled = false;
                WithoutBarcodeComboBox.Enabled = true;
                ByBarcDescChkBox.Enabled = false;
                
                BarcodeTxtBox.Enabled = false;
                BarcodeTxtBox.Clear();
                if (IsUpdating)
                {
                    return;
                }
                UpdateItemBtn.Hide();
            }
            else
            {
                BarcodeToEditTxtBox.Enabled = true;
                ItemDescriptionComboBox.Enabled = false;
                WithoutBarcodeComboBox.Enabled = false;
                ByBarcDescChkBox.Enabled = true;
                ByBarcDescChkBox.Checked = true;
                BarcodeTxtBox.Enabled = Enabled;
                if (IsUpdating)
                {
                    return; 
                }
                BarcodeTxtBox.Clear();
                UpdateItemBtn.Hide();
            }
           
        }

        private void ByBarcDescChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ByBarcDescChkBox.Checked)
            {
                BarcodeToEditTxtBox.Enabled = true;
                ItemDescriptionComboBox.Enabled = false;
                if (IsUpdating)
                {
                    return;
                }
                UpdateItemBtn.Hide();
            }
            else
            {
                BarcodeToEditTxtBox.Enabled = false;
                ItemDescriptionComboBox.Enabled = true;
                if (IsUpdating)
                {
                    return;
                }
                UpdateItemBtn.Hide();
                // ItemDescriptionComboBox.SelectedIndex = 0;
            }

        }

        private void BarcodeToEditTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (int)Keys.Return)
                {
                    IsUpdating = true;
                    if (Validators.TxtBoxNotEmpty(BarcodeToEditTxtBox.Text))
                    {
                        aItemData = ItemsMgmt.SelectItemByBarCode(BarcodeToEditTxtBox.Text);
                        if (aItemData != null)
                        {
                            if (aItemData.Rows.Count > 0)
                            {
                                UpdateItemBtn.Show();
                                TypeComboBox.Text = ItemTypeMgmt.SelectItemTypeByID(int.Parse(aItemData.Rows[0]["Type"].ToString()));
                                CategoryComboBox.Text = ItemCategoryMgmt.SelectItemCategoryByID(int.Parse(aItemData.Rows[0]["Category"].ToString()));
                                VendorComboBox.Text = VendorsMgmt.SelectVendorByID(int.Parse(aItemData.Rows[0]["Vendor"].ToString()));
                                TaxLevelComboBox.Text = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemData.Rows[0]["TaxLevel"].ToString()));

                                BarcodeTxtBox.Text = BarcodeToEditTxtBox.Text;
                                DescriptionTxtBox.Text = aItemData.Rows[0]["Description"].ToString();
                                ItemDescriptionComboBox.Text = aItemData.Rows[0]["Description"].ToString();
                                QtyTxtBox.Text = aItemData.Rows[0]["Qty"].ToString();
                                RenderPointTxtBox.Text = aItemData.Rows[0]["RenderPoint"].ToString();
                                DateAddedTxtBox.Text = aItemData.Rows[0]["EntryDate"].ToString();
                                SellPriceTxtBox.Text = aItemData.Rows[0]["SellPrice"].ToString();
                                AvgCostTxtBox.Text = aItemData.Rows[0]["AvgUnitCost"].ToString();
                                AvailableQtyTxtBox.Text = aItemData.Rows[0]["OnHandQty"].ToString(); /*@SMS V01O changed*/
                                Pricing.Controls.Clear();
                                //ADDING PRICE LEVELS
                                int ItemID = int.Parse(aItemData.Rows[0]["ID"].ToString());
                                aPriceLevelsTable = PriceLevelsMgmt.SelectAll();
                                if (aPriceLevelsTable.Rows.Count > 0)
                                {
                                    foreach (DataRow r in aPriceLevelsTable.Rows)
                                    {
                                        if (r["Name"].ToString() != "Standard")
                                        {
                                            Label aLabel = new Label();
                                            aLabel.Text = r["Name"].ToString();
                                            TextBox aTextBox = new TextBox();
                                            DataTable aSpecialPriceTable = SpecialPricesMgmt.SelectSpecialPricebyItemIDandPriceLevelID(ItemID, int.Parse(r["ID"].ToString()));
                                            if (aSpecialPriceTable.Rows.Count > 0)
                                            {
                                                aTextBox.Text = aSpecialPriceTable.Rows[0]["Price"].ToString();
                                            }
                                            else
                                            {
                                                aTextBox.Text = SellPriceTxtBox.Text;
                                            }

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
                                MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.BarcodeTxt + "\n2)" + MsgTxt.IfNotBarChkWithoutBarcodeTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show(MsgTxt.NotUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    UpdateItemBtn.Hide();
                }
                TaxEnclodedChkBox.Checked = false;
                UpdateMargin();
                IsUpdating = false;
            }
            catch (Exception ex)
            {
                IsUpdating = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[BarcodeToEditTxtBox_KeyPress] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private void AddNewTypeBtn_Click(object sender, EventArgs e)
        {
            AddNewItemType aAddNewItemType = new AddNewItemType();
            aAddNewItemType.ShowDialog();
            this.itemTypeTableAdapter.Fill(this.dBDataSet.ItemType);
        }

        private void AddNewCategoryBtn_Click(object sender, EventArgs e)
        {
            AddNewCategory aAddNewCategory = new AddNewCategory();
            aAddNewCategory.ShowDialog();
            this.itemCategoryTableAdapter.Fill(this.dBDataSet.ItemCategory);
        }

        private void AddNewVendorBtn_Click(object sender, EventArgs e)
        {

            AddVendor aAddVendor = new AddVendor();
            aAddVendor.ShowDialog();
            this.vendorsTableAdapter.Fill(this.dBDataSet.Vendors);
        }

        private void AddNewTaxLevelBtn_Click(object sender, EventArgs e)
        {
            AddTaxLevel aAddTaxLevel = new AddTaxLevel();
            aAddTaxLevel.ShowDialog();
            this.taxLevelTableAdapter.Fill(this.dBDataSet.TaxLevel);
        }

        private void AddNewPriceLevelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (aItemData != null)
                {
                    AddNewPriceLevel aAddNewPriceLevel = new AddNewPriceLevel();
                    aAddNewPriceLevel.ShowDialog();

                    aPriceLevelsTable = PriceLevelsMgmt.SelectAll();
                    Pricing.Controls.Clear();
                    if (aPriceLevelsTable.Rows.Count > 0)
                    {
                        int ItemID = int.Parse(aItemData.Rows[0]["ID"].ToString());
                        foreach (DataRow r in aPriceLevelsTable.Rows)
                        {
                            if (r["Name"].ToString() != "Standard")
                            {
                                Label aLabel = new Label();
                                aLabel.Text = r["Name"].ToString();
                                TextBox aTextBox = new TextBox();
                                DataTable aSpecialPriceTable = SpecialPricesMgmt.SelectSpecialPricebyItemIDandPriceLevelID(ItemID, int.Parse(r["ID"].ToString()));
                                if (aSpecialPriceTable == null)
                                {
                                    MessageBox.Show("UNEXPECTED ERROR");
                                    this.Close();
                                }
                                if (aSpecialPriceTable.Rows.Count > 0)
                                {
                                    aTextBox.Text = aSpecialPriceTable.Rows[0]["Price"].ToString();
                                }
                                else
                                {
                                    aTextBox.Text = SellPriceTxtBox.Text;
                                }
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
                    MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.ItemTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[AddNewPriceLevelBtn_Click] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemDescriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!OnExit && !IsUpdating && !IsLoading && ItemDescriptionComboBox.SelectedValue != null)
                {
                    IsUpdating = true;
                    aItemData = ItemsMgmt.SelectItemByBarCode(ItemDescriptionComboBox.SelectedValue.ToString());
                    if (aItemData.Rows.Count > 0)
                    {
                        UpdateItemBtn.Show();
                        TypeComboBox.Text = ItemTypeMgmt.SelectItemTypeByID(int.Parse(aItemData.Rows[0]["Type"].ToString()));
                        CategoryComboBox.Text = ItemCategoryMgmt.SelectItemCategoryByID(int.Parse(aItemData.Rows[0]["Category"].ToString()));
                        VendorComboBox.Text = VendorsMgmt.SelectVendorByID(int.Parse(aItemData.Rows[0]["Vendor"].ToString()));
                        TaxLevelComboBox.Text = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemData.Rows[0]["TaxLevel"].ToString()));
                        BarcodeTxtBox.Text = aItemData.Rows[0]["Barcode"].ToString();
                        BarcodeToEditTxtBox.Text = aItemData.Rows[0]["Barcode"].ToString();

                        DescriptionTxtBox.Text = aItemData.Rows[0]["Description"].ToString();
                        QtyTxtBox.Text = aItemData.Rows[0]["Qty"].ToString();
                        RenderPointTxtBox.Text = aItemData.Rows[0]["RenderPoint"].ToString();
                        DateAddedTxtBox.Text = aItemData.Rows[0]["EntryDate"].ToString();
                        SellPriceTxtBox.Text = aItemData.Rows[0]["SellPrice"].ToString();
                        AvgCostTxtBox.Text = aItemData.Rows[0]["AvgUnitCost"].ToString();
                        AvailableQtyTxtBox.Text = aItemData.Rows[0]["OnHandQty"].ToString(); /*@SMS V01O changed*/
                        if (aItemData.Rows[0]["IsWeight"].ToString() == "1")
                        {
                            WeightChkBox.Checked = true;
                        }
                        else
                        {
                            WeightChkBox.Checked = false;
                        }
                        Pricing.Controls.Clear();
                        //ADDING PRICE LEVELS
                        int ItemID = int.Parse(aItemData.Rows[0]["ID"].ToString());
                        aPriceLevelsTable = PriceLevelsMgmt.SelectAll();
                        if (aPriceLevelsTable.Rows.Count > 0)
                        {
                            foreach (DataRow r in aPriceLevelsTable.Rows)
                            {
                                if (r["Name"].ToString() != "Standard")
                                {
                                    Label aLabel = new Label();
                                    aLabel.Text = r["Name"].ToString();
                                    TextBox aTextBox = new TextBox();
                                    DataTable aSpecialPriceTable = SpecialPricesMgmt.SelectSpecialPricebyItemIDandPriceLevelID(ItemID, int.Parse(r["ID"].ToString()));
                                    if (aSpecialPriceTable.Rows.Count > 0)
                                    {
                                        aTextBox.Text = aSpecialPriceTable.Rows[0]["Price"].ToString();
                                    }
                                    else
                                    {
                                        aTextBox.Text = SellPriceTxtBox.Text;
                                    }

                                    aTextBox.Name = r["Name"].ToString();
                                    aTextBox.TextChanged += new EventHandler(Calcium_RMS.Validators.TextBoxDoubleInputChange);
                                    Pricing.Controls.Add(aLabel);
                                    Pricing.Controls.Add(aTextBox);
                                }
                            }
                        }
                        TaxEnclodedChkBox.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.NotUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    UpdateMargin();
                    IsUpdating = false;
                }
            }
            catch (Exception ex)
            {
                IsUpdating = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[ItemDescriptionComboBox_SelectedIndexChanged] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void WithoutBarcodeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsUpdating)
                {
                    return;  
                }
                if (WithoutBarcodeComboBox.SelectedValue != null)
                {
                    aItemData = ItemsMgmt.SelectItemByBarCode(WithoutBarcodeComboBox.SelectedValue.ToString());
                }
                else
                {
                    return;
                }
                if (aItemData.Rows.Count > 0)
                {
                    IsUpdating = true;
                    UpdateItemBtn.Show();
                    TypeComboBox.Text = ItemTypeMgmt.SelectItemTypeByID(int.Parse(aItemData.Rows[0]["Type"].ToString()));
                    CategoryComboBox.Text = ItemCategoryMgmt.SelectItemCategoryByID(int.Parse(aItemData.Rows[0]["Category"].ToString()));
                    VendorComboBox.Text = VendorsMgmt.SelectVendorByID(int.Parse(aItemData.Rows[0]["Vendor"].ToString()));
                    TaxLevelComboBox.Text = ItemTaxLevelMgmt.SelectItemTaxByID(int.Parse(aItemData.Rows[0]["TaxLevel"].ToString()));

                    BarcodeTxtBox.Text = aItemData.Rows[0]["Barcode"].ToString();
                    DescriptionTxtBox.Text = aItemData.Rows[0]["Description"].ToString();
                    QtyTxtBox.Text = aItemData.Rows[0]["Qty"].ToString();
                    RenderPointTxtBox.Text = aItemData.Rows[0]["RenderPoint"].ToString();
                    DateAddedTxtBox.Text = aItemData.Rows[0]["EntryDate"].ToString();
                    SellPriceTxtBox.Text = aItemData.Rows[0]["SellPrice"].ToString();
                    AvgCostTxtBox.Text = aItemData.Rows[0]["AvgUnitCost"].ToString();
                    AvailableQtyTxtBox.Text = aItemData.Rows[0]["OnHandQty"].ToString(); /*@SMS V01O changed*/
                    Pricing.Controls.Clear();
                    //ADDING PRICE LEVELS
                    int ItemID = int.Parse(aItemData.Rows[0]["ID"].ToString());
                    aPriceLevelsTable = PriceLevelsMgmt.SelectAll();

                    if (aPriceLevelsTable.Rows.Count > 0)
                    {
                        foreach (DataRow r in aPriceLevelsTable.Rows)
                        {
                            if (r["Name"].ToString() != "Standard")
                            {
                                Label aLabel = new Label();
                                aLabel.Text = r["Name"].ToString();
                                aLabel.ForeColor = Color.Black;
                                TextBox aTextBox = new TextBox();
                                DataTable aSpecialPriceTable = SpecialPricesMgmt.SelectSpecialPricebyItemIDandPriceLevelID(ItemID, int.Parse(r["ID"].ToString()));
                                if (aSpecialPriceTable.Rows.Count > 0)
                                {
                                    aTextBox.Text = aSpecialPriceTable.Rows[0]["Price"].ToString();
                                }
                                else
                                {
                                    aTextBox.Text = SellPriceTxtBox.Text;
                                }

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
                    MessageBox.Show(MsgTxt.NotUsedTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TaxEnclodedChkBox.Checked = false;
                UpdateMargin();
                IsUpdating = false;
            }
            catch (Exception ex)
            {
                IsUpdating = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[WithoutBarcodeComboBox_SelectedIndexChanged] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
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
                                               // tb.BackColor = Color.Black;
                                            }
                                        }
                                        if (IsPriceLevelsEmpty)
                                        {
                                            MessageBox.Show(MsgTxt.PleaseSelectTxt + "\n1)" + MsgTxt.PriceLevelsTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            return;
                                        }
                                        else
                                        {
                                            bool IsBarcodeUsed = false;
                                            //CHECK IF NEW BARCODE IS  NOT CHECKED
                                            string OldBarcode;
                                            if (!WithoutBarcodeChkBox.Checked)
                                            {
                                                IsBarcodeUsed = ItemsMgmt.IsItemExist(BarcodeTxtBox.Text);
                                                if (ByBarcDescChkBox.Checked)
                                                {
                                                    OldBarcode = BarcodeToEditTxtBox.Text;
                                                }
                                                else
                                                {
                                                    OldBarcode = ItemDescriptionComboBox.SelectedValue.ToString();
                                                }
                                            }
                                            else
                                            {
                                                OldBarcode = WithoutBarcodeComboBox.SelectedValue.ToString();
                                            }
                                            Items aItem = new Items();
                                            aItem.Item_Type = (int)TypeComboBox.SelectedValue;
                                            aItem.Item_Category = (int)CategoryComboBox.SelectedValue;
                                            aItem.Vendor = (int)VendorComboBox.SelectedValue;
                                            aItem.Item_Tax_Level = (int)TaxLevelComboBox.SelectedValue;
                                            if (WithoutBarcodeChkBox.Checked)
                                            {
                                                aItem.Item_Barcode = WithoutBarcodeComboBox.SelectedValue.ToString();
                                            }
                                            else
                                            {
                                                //aItem.IsWithoutBarcode = 0;
                                                aItem.Item_Barcode = BarcodeTxtBox.Text;
                                            }
                                            aItem.Item_ID = ItemsMgmt.SelectItemIDByBarcode(OldBarcode);
                                            if (!IsBarcodeUsed || WithoutBarcodeChkBox.Checked || OldBarcode == aItem.Item_Barcode)
                                            {
                                                aItem.Item_Description = DescriptionTxtBox.Text;
                                                aItem.Avalable_Qty = double.Parse(QtyTxtBox.Text);
                                                aItem.Render_Point = double.Parse(RenderPointTxtBox.Text);
                                                // aItem.Entry_Date = DateTime.Now.ToShortDateString();

                                                double aSellPrice = double.Parse(SellPriceTxtBox.Text);
                                                double aUnitCost = double.Parse(AvgCostTxtBox.Text);
                                                double aTax = double.Parse(ItemTaxLevelMgmt.SelectItemTaxByID(aItem.Item_Tax_Level));

                                                if (TaxEnclodedChkBox.Checked)
                                                {
                                                    aItem.Sell_Price = Math.Round(aSellPrice / ((aTax / 100) + 1), 4);
                                                    aItem.Avg_Unit_Cost = Math.Round(aUnitCost / ((aTax / 100) + 1), 4);
                                                }
                                                else
                                                {
                                                    aItem.Sell_Price = aSellPrice;
                                                    aItem.Avg_Unit_Cost = aUnitCost;
                                                }
                                                ItemsMgmt.UpdateItemByID(aItem);
                                                int ItemID = aItem.Item_ID;
                                                foreach (var tb in Pricing.Controls.OfType<TextBox>())
                                                {
                                                    Nullable<int> PriceLevelID = PriceLevelsMgmt.SelectPriceLevelIDByName(tb.Name);
                                                    if (PriceLevelID != null)
                                                    {
                                                        double atbSellPrice = double.Parse(tb.Text);

                                                        if (TaxEnclodedChkBox.Checked)
                                                        {
                                                            atbSellPrice = Math.Round(atbSellPrice / ((aTax / 100) + 1), 4);
                                                        }

                                                        Nullable<int> IsAddSpecialPriceOK;
                                                        if (SpecialPricesMgmt.IsSpecialPriceExist(ItemID, (int)PriceLevelID) == true)//exist update
                                                        {
                                                            IsAddSpecialPriceOK = SpecialPricesMgmt.UpdatePriceLevel(ItemID, (int)PriceLevelID, atbSellPrice);
                                                        }
                                                        else if (SpecialPricesMgmt.IsSpecialPriceExist(ItemID, (int)PriceLevelID) == false)//not exist create new
                                                        {
                                                            IsAddSpecialPriceOK = SpecialPricesMgmt.AddSpecialPrice(ItemID, (int)PriceLevelID, atbSellPrice);
                                                        } //null database error
                                                        else
                                                        {
                                                            MessageBox.Show(MsgTxt.UnexpectedError + "DataBase: SpecialPricesMgmt.AddSpecialPrice" , MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            return;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("UNEXPECTED ERROR !!ITEM ADDED SUCCESSFULY, NOT PRICE LEVELS ADDED " + "\n" + "PLEASE ADD PRICE LEVELS MANUALLY FROM EDIT ITEM PAGE", "PRICE LEVEL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        throw new System.ArgumentException("Parameter cannot be null", "original");
                                                    }
                                                }
                                                MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.AddedSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                IsUpdating = false;
                MessageBox.Show(MsgTxt.UnexpectedError + "\nException: IN[UpdateItemBtn_Click] \n" + ex.ToString(), MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        double TestParsingOut;
        private void MarginTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsLoading||IsUpdating)
                {
                    return;
                }
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
                if (IsLoading || IsUpdating)
                {
                    return;
                }
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
                if (IsLoading || IsUpdating)
                {
                    return;
                }
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

        ////To Make Size Always Normal For Non-Grid Forms
        //protected override void OnResize(EventArgs e)
        //{
        //    if (this.WindowState == FormWindowState.Maximized)
        //    {
        //        this.WindowState = FormWindowState.Normal;
        //    }

        //}

        private void TranslateUI()
        {
            try
            {
                this.Text = FormsNames.EditItemsFormName;
                //this.RightToLeft = FlowDirectionManager.GetFlowDirection();
            //// this.RightToLeftLayout = true;
            AddNewCategoryBtn.Text = UiText.EdtItmAddNewCategoryBtn;
            AddNewPriceLevelBtn.Text = UiText.EdtItmAddNewPriceLevelBtn;
            AddNewTaxLevelBtn.Text = UiText.EdtItmAddNewTaxLevelBtn;
            AddNewTypeBtn.Text = UiText.EdtItmAddNewTypeBtn;
            AddNewVendorBtn.Text = UiText.EdtItmAddNewVendorBtn;
            AvgCostLbl.Text = UiText.EdtItmAvgCostLbl;
            BarcodeLbl.Text = UiText.EdtItmBarcodeLbl;
            BarcodeToEditLbl.Text = UiText.EdtItmBarcodeToEditLbl;
            ByBarcDescChkBox.Text = UiText.EdtItmByBarcDescChkBox;
            CategoryLbl.Text = UiText.EdtItmCategoryLbl;
            DateAddedLbl.Text = UiText.EdtItmDateAddedLbl;
            DescriptionLbl.Text = UiText.EdtItmDescriptionLbl;
            EditItemsLbl.Text = UiText.EdtItmEditItemsLbl;
            ItemDescriptionToEditLbl.Text = UiText.EdtItmItemDescriptionToEditLbl;
            ItemInfoGB.Text = UiText.EdtItmItemInfoGB;
            ItemTypeLbl.Text = UiText.EdtItmItemTypeLbl;
            MarginLbl.Text = UiText.EdtItmMarginLbl;
            PricingGB.Text = UiText.EdtItmPricingGB;
            PricingLbl.Text = UiText.EdtItmPricingLbl;
            QtyLbl.Text = UiText.EdtItmQtyLbl;
            RenderPointLbl.Text = UiText.EdtItmRenderPointLbl;
            RequiredFieldLbl.Text = UiText.EdtItmRequiredFieldLbl;
            SellPriceLbl.Text = UiText.EdtItmSellPriceLbl;
            TaxEnclodedChkBox.Text = UiText.EdtItmTaxEnclodedChkBox;
            TaxLevelLbl.Text = UiText.EdtItmTaxLevelLbl;
            UpdateItemBtn.Text = UiText.EdtItmUpdateItemBtn;
            VendorLbl.Text = UiText.EdtItmVendorLbl;
            WithoutBarcodeChkBox.Text = UiText.EdtItmWithoutBarcodeChkBox;
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
