namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Linq;
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
            bool itemExists = this.db.CheckExistenceByGeneric<InventoryModel, string>("Inventory", "Item", this.txtItem.Text);
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
                if (int.TryParse(this.txtQuantity.Text, out int quantity)
                    && double.TryParse(this.txtUnitPrice.Text, out double unitPrice)
                    && double.TryParse(this.txtCost.Text, out double cost))
                {
                    // Insert to Inventory
                    this.db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = this.txtItem.Text,
                        Qty = quantity,
                        UnitPrice = unitPrice,
                        Cost = cost,
                        Category = this.txtCategory.Text,
                        Supplier = this.txtSupplier.Text,
                        Status = quantity != 0,
                    });

                    // Insert to Inventory Report
                    string status = "Out";
                    if (quantity > 0)
                    {
                        status = "In(" + quantity.ToString(CultureInfo.CurrentCulture) + ")";
                    }

                    this.db.InsertRecord("InventoryReport", new InventoryReportModel
                    {
                        Item = this.txtItem.Text,
                        DateModified = DateTime.Now,
                        Status = status,
                        RetailAmount = unitPrice,
                        Cost = cost,
                        Category = this.txtCategory.Text,
                        Supplier = this.txtSupplier.Text,
                    });

                    MessageBox.Show("Item saved!");
                    this.Close();
                }
                else
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
            if ((e.KeyChar == 46) && !this.txtUnitPrice.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }
    }
}
