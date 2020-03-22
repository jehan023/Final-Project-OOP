using MongoDB.Bson;
using System;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class Products : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public Products()
        {
            InitializeComponent();
            RefreshInventory();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            using (AddNewItem addItem = new AddNewItem())
            {
                addItem.ShowDialog();
            }
        }

        public void RefreshInventory()
        {
            var InventoryRecord = db.LoadRecords<InventoryModel>("Inventory");
            ProductDataGrid.DataSource = InventoryRecord;
            searchItemBox.Text = "";
        }

        private void RefreshItemBtn_Click(object sender, EventArgs e)
        {
            RefreshInventory();
        }

        private void ProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            itemNameBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantityBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            unitPriceBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            costBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            categoryBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            supplierBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            inStockTrueRadioBtn.Checked = ProductDataGrid.Rows[e.RowIndex].Cells[7].Value.Equals(true);
            inStockFalseRadioBtn.Checked = ProductDataGrid.Rows[e.RowIndex].Cells[7].Value.Equals(false);
        }

        private void UpdateItemBtn_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int EmptyField = Functions.CheckFields(GroupTextBox);
            if (EmptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + EmptyField + " field/s.");
            }

            else
            {
                try
                {
                    var SelectedRecord = db.LoadRecordById<InventoryModel>("Inventory", new ObjectId(idBox.Text));
                    SelectedRecord.Item = itemNameBox.Text;
                    SelectedRecord.Qty = int.Parse(s: quantityBox.Text);
                    SelectedRecord.UnitPrice = double.Parse(s: unitPriceBox.Text);
                    SelectedRecord.Cost = double.Parse(s: costBox.Text);
                    SelectedRecord.Category = categoryBox.Text;
                    SelectedRecord.Supplier = supplierBox.Text;
                    SelectedRecord.Status = int.Parse(quantityBox.Text) != 0;

                    db.UpsertRecord<InventoryModel>("Inventory", SelectedRecord.Id, SelectedRecord);
                    RefreshInventory();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
        }

        private void DeleteItemBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleleRecord<InventoryModel>("Inventory", ObjectId.Parse(idBox.Text));
                RefreshInventory();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var SelectedRecord = db.LoadRecordsBySpecific<InventoryModel>("Inventory", "Item", searchItemBox.Text);
            ProductDataGrid.DataSource = SelectedRecord;
        }

        private void CostBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
