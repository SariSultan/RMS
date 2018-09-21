using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calcium_RMS.Management;
using Calcium_RMS.Text;

namespace Calcium_RMS
{
    public partial class EditTouchScreenItems : Form
    {
        public EditTouchScreenItems()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            UpdateList();
            TranslateUI();
        }

        private void EditTouchScreenItems_Load(object sender, EventArgs e)
        {
            try
            {
                this.itemsTableAdapter.WithBarcode(this.dBDataSet.Items);
                this.itemsTableAdapter.WithoutBarcode(this.dBDataSet2.Items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.ErrorLoadingFrom + "\n Exception: IN[EditTouchScreenItems_Load] \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void BarcodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (int)Keys.Return)
                {
                    if (Validators.TxtBoxNotEmpty(BarcodeTxtBox.Text))
                    {
                        AddItemUsingBarcode(BarcodeTxtBox.Text);
                    }
                    //DataTable aItemTable = ItemsMgmt.SelectItemByBarCode(BarcodeTxtBox.Text);
                    //if (aItemTable.Rows.Count == 1)
                    //{
                    //    TeldgView.ClearSelection();
                    //     int RowNum = TeldgView.Rows.Add();
                    //    TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
                    //    TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
                    //    TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["SellPrice"].ToString();
                    //    TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aItemTable.Rows[0]["Qty"].ToString();
                    //    TeldgView.Rows[RowNum].Selected = true;
                    //    BarcodeTxtBox.Text = string.Empty;
                    //    ItemDescriptionComboBox.Text = string.Empty;
                    //}
                    //else
                    //{
                    //    MessageBox.Show(MsgTxt.ItemNotFoundTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    BarcodeTxtBox.Text = string.Empty;
                    //    ItemDescriptionComboBox.Text = string.Empty;
                    //}
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [BarcodeTxtBox_KeyPress] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }
        }

        private bool AddItemUsingBarcode(string aBarcode)
        {
            try
            {
                if (!ItemsMgmt.IsItemTouchScreen(aBarcode))
                {
                    DataTable aItemTable = ItemsMgmt.SelectItemByBarCode(aBarcode);
                    if (aItemTable.Rows.Count == 1)
                    {
                        TeldgView.ClearSelection();
                        int RowNum = TeldgView.Rows.Add();
                        TeldgView.Rows[RowNum].Cells["Barcode"].Value = aItemTable.Rows[0]["Barcode"].ToString();
                        TeldgView.Rows[RowNum].Cells["Description"].Value = aItemTable.Rows[0]["Description"].ToString();
                        TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aItemTable.Rows[0]["SellPrice"].ToString();
                        TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aItemTable.Rows[0]["Qty"].ToString();
                        TeldgView.Rows[RowNum].Selected = true;
                        BarcodeTxtBox.Text = string.Empty;
                        ItemsMgmt.MakeItemTouchScreen(aBarcode, true);
                        // MessageBox.Show(MsgTxt.UpdateSuccessfully, MsgTxt.UpdateSuccessfully, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show(MsgTxt.ItemNotFoundTxt, MsgTxt.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BarcodeTxtBox.Text = string.Empty;
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(MsgTxt.AlreadyUsedTxt, MsgTxt.InformationCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [AddItemUsingBarcode] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return false;
                throw;
            }

        }

        private void DeleteItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in TeldgView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        ItemsMgmt.MakeItemTouchScreen(row.Cells["Barcode"].Value.ToString(), false);
                        TeldgView.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DeleteItemsBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void DescriptionAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemDescriptionComboBox.SelectedValue != null)
                {
                    AddItemUsingBarcode(ItemDescriptionComboBox.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [DescriptionAddBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void WithoutAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemsWithoutBarcodeComboBox.SelectedValue != null)
                {
                    AddItemUsingBarcode(ItemsWithoutBarcodeComboBox.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [WithoutAddBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }


        }

        private void BarcodeAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validators.TxtBoxNotEmpty(BarcodeTxtBox.Text))
                {
                    AddItemUsingBarcode(BarcodeTxtBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [BarcodeAddBtn_Click] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void UpdateList()
        {
            try
            {
                DataTable aDT = ItemsMgmt.SelectAllTouchScreenItems();
                if (aDT != null)
                {
                    if (aDT.Rows.Count > 0)
                    {
                        foreach (DataRow aRow in aDT.Rows)
                        {
                            TeldgView.ClearSelection();
                            int RowNum = TeldgView.Rows.Add();
                            TeldgView.Rows[RowNum].Cells["Barcode"].Value = aRow["Barcode"].ToString();
                            TeldgView.Rows[RowNum].Cells["Description"].Value = aRow["Description"].ToString();
                            TeldgView.Rows[RowNum].Cells["PricePerUnit"].Value = aRow["SellPrice"].ToString();
                            TeldgView.Rows[RowNum].Cells["AvalQty"].Value = aRow["Qty"].ToString();
                            TeldgView.Rows[RowNum].Selected = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [UpdateList] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        void TranslateUI()
        {
            try
            {
                // this.RightToLeft = FlowDirectionManager.GetFlowDirection();
                // this.RightToLeftLayout = true;
                BarcodeLbl.Text = UiText.EdtTchItmBarcodeLbl;
                ItemDescriptionLbl.Text = UiText.EdtTchItmItemDescriptionLbl;
                ItemsWithoutBarcodeLbl.Text = UiText.EdtTchItmItemsWithoutBarcodeLbl;
            }
            catch (Exception ex)
            {

                MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [TranslateUI] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
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

        private void ItemDescriptionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Return)
            {
                try
                {
                    if (ItemDescriptionComboBox.SelectedValue != null)
                    {
                        AddItemUsingBarcode(ItemDescriptionComboBox.SelectedValue.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(MsgTxt.UnexpectedError + "\n IN [ItemDescriptionComboBox_KeyPress] \n Exception: \n" + ex.ToString() + "\n" + MsgTxt.FormWillCloseNowTxt, MsgTxt.ErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }



    }
}
