using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

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

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            AddNewItem addItem = new AddNewItem();
            addItem.ShowDialog();
        }

        public void RefreshInventory()
        {
            var InventoryRecord = db.LoadRecords<InventoryModel>("Inventory");
            ProductDataGrid.DataSource = InventoryRecord;
        }

        private void refreshItemBtn_Click(object sender, EventArgs e)
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

        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int EmptyField = 0;
            foreach (Control control in GroupTextBox.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        EmptyField += 1;
                    }
                }
            }
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
                    SelectedRecord.Qty = int.Parse(quantityBox.Text);
                    SelectedRecord.UnitPrice = Double.Parse(unitPriceBox.Text);
                    SelectedRecord.Cost = double.Parse(costBox.Text);
                    SelectedRecord.Category = categoryBox.Text;
                    SelectedRecord.Supplier = supplierBox.Text;

                    bool inStock = SelectedRecord.Status;
                    if (Int32.Parse(quantityBox.Text) == 0)
                    {
                        inStock = false;
                    }
                    else
                    {
                        inStock = true;
                    }
                    SelectedRecord.Status = inStock;
                    db.UpsertRecord<InventoryModel>("Inventory", SelectedRecord.Id, SelectedRecord);
                    RefreshInventory();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
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
    }
}
