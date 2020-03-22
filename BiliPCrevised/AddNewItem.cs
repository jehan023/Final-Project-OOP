using System;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class AddNewItem : Form
    {
        readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public AddNewItem()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            bool itemExists = db.CheckExistence<InventoryModel>("Inventory", "Item", itemBox.Text);

            // Check thy empty boxes
            int emptyField = Functions.CheckFields(GroupTextBox);

            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }

            else if (itemExists == true)
            {
                MessageBox.Show("Item already exists.");
            }

            else if (itemExists == false)
            {
                try
                {
                    db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = itemBox.Text,
                        Qty = int.Parse(s: quantityBox.Text),
                        UnitPrice = double.Parse(s: unitPriceBox.Text),
                        Cost = double.Parse(s: costBox.Text),
                        Category = categoryBox.Text,
                        Supplier = supplierBox.Text,
                        Status = int.Parse(quantityBox.Text) != 0
                    });
                    MessageBox.Show("Item saved!");
                    this.Dispose();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }

            else
            {
                MessageBox.Show("Unknown Error.");
            }
        }

        private void QuantityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
