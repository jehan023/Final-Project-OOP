namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class AddNewItem : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public AddNewItem()
        {
            this.InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            bool itemExists = this.db.CheckExistence<InventoryModel>("Inventory", "Item", this.txtItem.Text);

            // Check thy empty boxes
            int emptyField = Functions.CheckFields(this.GroupTextBox);

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
                    this.db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = this.txtItem.Text,
                        Qty = int.Parse(s: this.txtQuantity.Text),
                        UnitPrice = double.Parse(s: this.txtUnitPrice.Text),
                        Cost = double.Parse(s: this.txtCost.Text),
                        Category = this.txtCategory.Text,
                        Supplier = this.txtSupplier.Text,
                        Status = int.Parse(this.txtQuantity.Text) != 0,
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
