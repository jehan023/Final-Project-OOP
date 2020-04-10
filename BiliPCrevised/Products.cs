namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class Products : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public Products()
        {
            this.InitializeComponent();
            this.AutoCompleteSearch();
            this.RefreshInventory();
        }

        private void AutoCompleteSearch()
        {
            AutoCompleteStringCollection search = new AutoCompleteStringCollection();

            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");

            foreach (var itemInventory in inventoryRecord)
            {
                if (!search.Contains(itemInventory.Item))
                {
                    search.Add(itemInventory.Item);
                }
            }

            this.txtSearchItem.AutoCompleteCustomSource = search;
        }

        private void RefreshInventory()
        {
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            this.dgdProduct.DataSource = inventoryRecord;
            this.txtSearchItem.Text = string.Empty;

            foreach (var itemInventory in inventoryRecord)
            {
                if (!this.cboCategory.Items.Contains(itemInventory.Category))
                {
                    this.cboCategory.Items.Add(itemInventory.Category);
                }
            }

            if (inventoryRecord.Any())
            {
                // Show first item in the textboxes if there is data
                this.idBox.Text = this.dgdProduct.Rows[0].Cells[0].Value.ToString();
                this.txtItemName.Text = this.dgdProduct.Rows[0].Cells[1].Value.ToString();
                this.txtQuantity.Text = this.dgdProduct.Rows[0].Cells[2].Value.ToString();
                this.txtUnitPrice.Text = this.dgdProduct.Rows[0].Cells[3].Value.ToString();
                this.txtCost.Text = this.dgdProduct.Rows[0].Cells[4].Value.ToString();
                this.txtCategory.Text = this.dgdProduct.Rows[0].Cells[5].Value.ToString();
                this.txtSupplier.Text = this.dgdProduct.Rows[0].Cells[6].Value.ToString();
                this.txtDate.Text = this.dgdProduct.Rows[0].Cells[7].Value.ToString();
                this.radInStockTrue.Checked = this.dgdProduct.Rows[0].Cells[8].Value.Equals(true);
                this.radInStockFalse.Checked = this.dgdProduct.Rows[0].Cells[8].Value.Equals(false);
            }
            else
            {
                // Clear textboxes if the data is null
                this.idBox.Text
                    = this.txtItemName.Text
                    = this.txtQuantity.Text
                    = this.txtUnitPrice.Text
                    = this.txtCost.Text
                    = this.txtDate.Text
                    = this.txtCategory.Text
                    = this.txtSupplier.Text
                        = string.Empty;
                this.radInStockTrue.Checked
                    = this.radInStockFalse.Checked
                        = false;
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByCaseInsensitive<InventoryModel>("Inventory", "Item", this.txtSearchItem.Text);
            this.dgdProduct.DataSource = selectedRecord;
        }

        private void TxtSearchItem_TextChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByCaseInsensitive<InventoryModel>("Inventory", "Item", this.txtSearchItem.Text);
            this.dgdProduct.DataSource = selectedRecord;
        }

        private void BtnRefreshItem_Click(object sender, EventArgs e)
        {
            this.cboCategory.Text = string.Empty;
            this.RefreshInventory();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            using (AddNewItem addItem = new AddNewItem())
            {
                addItem.ShowDialog();
            }

            this.RefreshInventory();
        }

        private void BtnUpdateItem_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int emptyField = Functions.CheckFields(this.GroupTextBox);
            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (ObjectId.TryParse(this.idBox.Text, out ObjectId id) && int.TryParse(this.txtQuantity.Text, out int quantity) && double.TryParse(this.txtUnitPrice.Text, out double unitPrice) && double.TryParse(this.txtCost.Text, out double cost))
            {
                var selectedInvRecord = this.db.LoadRecordsByGenericT<InventoryModel, ObjectId>("Inventory", "Id", id);

                // Default stock status unless specified
                string status = "OUT";
                if (quantity > 0)
                {
                    status = "IN (" + quantity.ToString(CultureInfo.CurrentCulture) + ")";
                }

                // Updating Inventory
                selectedInvRecord.Item = this.txtItemName.Text;
                selectedInvRecord.Qty = quantity;
                selectedInvRecord.UnitPrice = unitPrice;
                selectedInvRecord.Cost = cost;
                selectedInvRecord.DateModified = DateTime.Now;
                selectedInvRecord.Category = this.txtCategory.Text;
                selectedInvRecord.Supplier = this.txtSupplier.Text;
                selectedInvRecord.InStock = quantity != 0;
                selectedInvRecord.Status = status;

                this.db.UpsertRecord("Inventory", selectedInvRecord.Id, selectedInvRecord);
                MessageBox.Show("Item updated.");

                // Updating of Transaction Form
                bool itemExists = this.db.CheckExistenceByGeneric<TransactionTempModel, ObjectId>("TransactionTemp", "Id", id);
                if (itemExists)
                {
                    var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", id);
                    if (selectedInvRecord.Qty >= selectedCartRecord.Quantity)
                    {
                        selectedCartRecord.Item = selectedInvRecord.Item;
                        selectedCartRecord.UnitPrice = selectedInvRecord.UnitPrice;
                        selectedCartRecord.TotalUnitPrice = selectedCartRecord.UnitPrice * selectedCartRecord.Quantity;
                        this.db.UpsertRecord("TransactionTemp", selectedInvRecord.Id, selectedCartRecord);

                        MessageBox.Show("Transaction form updated.");
                    }
                }
                else if (itemExists)
                {
                    var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", id);
                    if (selectedInvRecord.Qty < selectedCartRecord.Quantity)
                    {
                        this.db.DeleleRecord<TransactionTempModel>("TransactionTemp", id);
                        MessageBox.Show("An item was deleted in transaction form due to insufficient stock.");
                    }
                }

                this.RefreshInventory();
            }
            else
            {
                MessageBox.Show("Please enter a valid character.");
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.idBox.Text) && ObjectId.TryParse(this.idBox.Text, out ObjectId id))
            {
                var selectedRecord = this.db.LoadRecordsByGenericT<InventoryModel, ObjectId>("Inventory", "Id", id);

                // Record deleted Item then delete from Inventory Report
                this.db.InsertRecord("InventoryDeletedRecords", new InventoryModel
                {
                    Item = selectedRecord.Item,
                    DateModified = DateTime.Now,
                    Qty = selectedRecord.Qty,
                    Category = selectedRecord.Category,
                    Supplier = selectedRecord.Supplier,
                });

                // Delete item in Inventory
                this.db.DeleleRecord<InventoryModel>("Inventory", id);
                MessageBox.Show("Item deleted.");

                // Delete item in Transaction Form
                bool itemExists = this.db.CheckExistenceByGeneric<TransactionTempModel, ObjectId>("TransactionTemp", "Id", id);
                if (itemExists)
                {
                    this.db.DeleleRecord<TransactionTempModel>("TransactionTemp", id);
                    MessageBox.Show("Transaction form updated.");
                }

                this.RefreshInventory();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void DgdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.idBox.Text = this.dgdProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtItemName.Text = this.dgdProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtQuantity.Text = this.dgdProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtUnitPrice.Text = this.dgdProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtCost.Text = this.dgdProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtCategory.Text = this.dgdProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txtSupplier.Text = this.dgdProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.txtDate.Text = this.dgdProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.radInStockTrue.Checked = this.dgdProduct.Rows[e.RowIndex].Cells[8].Value.Equals(true);
                this.radInStockFalse.Checked = this.dgdProduct.Rows[e.RowIndex].Cells[8].Value.Equals(false);
            }
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByGenericList<InventoryModel, string>("Inventory", "Category", this.cboCategory.Text);
            this.dgdProduct.DataSource = selectedRecord;
        }

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtCost.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }

        private void TxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtUnitPrice.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
