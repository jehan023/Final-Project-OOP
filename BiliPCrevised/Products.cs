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
            this.RefreshInventory();
        }

        private void RefreshInventory()
        {
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            this.dgdProduct.DataSource = inventoryRecord;
            this.txtSearchItem.Text = string.Empty;

            foreach (var itemInventory in inventoryRecord)
            {
                if (!this.CategoryBox.Items.Contains(itemInventory.Category))
                {
                    this.CategoryBox.Items.Add(itemInventory.Category);
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
                this.radInStockTrue.Checked = this.dgdProduct.Rows[0].Cells[7].Value.Equals(true);
                this.radInStockFalse.Checked = this.dgdProduct.Rows[0].Cells[7].Value.Equals(false);
            }
            else
            {
                // Clear textboxes if the data is null
                this.idBox.Text
                    = this.txtItemName.Text
                    = this.txtQuantity.Text
                    = this.txtUnitPrice.Text
                    = this.txtCost.Text
                    = this.txtCategory.Text
                    = this.txtSupplier.Text
                    = string.Empty;
                this.radInStockTrue.Checked
                    = this.radInStockFalse.Checked
                    = false;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Item", this.txtSearchItem.Text);
            this.dgdProduct.DataSource = selectedRecord;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefreshItem_Click(object sender, EventArgs e)
        {
            this.CategoryBox.Text = string.Empty;
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
            else
            {
                try
                {
                    var selectedRecord = this.db.LoadRecordById<InventoryModel>("Inventory", new ObjectId(this.idBox.Text));
                    selectedRecord.Item = this.txtItemName.Text;
                    selectedRecord.Qty = int.Parse(s: this.txtQuantity.Text, CultureInfo.InvariantCulture);
                    selectedRecord.UnitPrice = double.Parse(s: this.txtUnitPrice.Text, CultureInfo.InvariantCulture);
                    selectedRecord.UnitPrice = double.Parse(s: this.txtCost.Text, CultureInfo.InvariantCulture);
                    selectedRecord.Category = this.txtCategory.Text;
                    selectedRecord.Supplier = this.txtSupplier.Text;
                    selectedRecord.Status = int.Parse(this.txtQuantity.Text, CultureInfo.InvariantCulture) != 0;

                    this.db.UpsertRecord<InventoryModel>("Inventory", selectedRecord.Id, selectedRecord);
                    MessageBox.Show("Item updated.");
                    this.RefreshInventory();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.db.DeleleRecord<InventoryModel>("Inventory", ObjectId.Parse(this.idBox.Text));
                MessageBox.Show("Item deleted.");
                this.RefreshInventory();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void DgdProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.idBox.Text = this.dgdProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtItemName.Text = this.dgdProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtQuantity.Text = this.dgdProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtUnitPrice.Text = this.dgdProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtCost.Text = this.dgdProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtCategory.Text = this.dgdProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txtSupplier.Text = this.dgdProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.radInStockTrue.Checked = this.dgdProduct.Rows[e.RowIndex].Cells[7].Value.Equals(true);
                this.radInStockFalse.Checked = this.dgdProduct.Rows[e.RowIndex].Cells[7].Value.Equals(false);
            }
            catch (ArgumentOutOfRangeException)
            {
                // Occurs when upper-leftmost datagridview is clicked.
                MessageBox.Show("Invalid selection.");
            }
        }

        private void CostBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Category", this.CategoryBox.Text);
            this.dgdProduct.DataSource = selectedRecord;
        }
    }
}
