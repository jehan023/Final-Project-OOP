namespace BiliPC
{
    using System;
    using System.Globalization;
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
            this.Close();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            bool itemExists = this.db.CheckExistence<InventoryModel>("Inventory", "Item", this.txtItem.Text);
            int emptyField = Functions.CheckFields(this.GroupTextBox);

            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (itemExists)
            {
                MessageBox.Show("Item already exists.");
            }
            else if (!itemExists)
            {
                try
                {
                    this.db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = this.txtItem.Text,
                        Qty = int.Parse(s: this.txtQuantity.Text, CultureInfo.InvariantCulture),
                        UnitPrice = double.Parse(s: this.txtUnitPrice.Text, CultureInfo.InvariantCulture),
                        Cost = double.Parse(s: this.txtCost.Text, CultureInfo.InvariantCulture),
                        Category = this.txtCategory.Text,
                        Supplier = this.txtSupplier.Text,
                        Status = int.Parse(this.txtQuantity.Text, CultureInfo.InvariantCulture) != 0,
                    });
                    MessageBox.Show("Item saved!");
                    this.Close();
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

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void TxtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToDouble(e);
        }
    }
}
