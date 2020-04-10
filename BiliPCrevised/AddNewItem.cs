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
            this.AutoComplete();
        }

        private void AutoComplete()
        {
            AutoCompleteStringCollection category = new AutoCompleteStringCollection();
            AutoCompleteStringCollection supplier = new AutoCompleteStringCollection();

            var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");

            foreach (var fill in invRecord)
            {
                if (!category.Contains(fill.Category))
                {
                    category.Add(fill.Category);
                }

                if (!supplier.Contains(fill.Supplier))
                {
                    supplier.Add(fill.Supplier);
                }
            }

            this.txtCategory.AutoCompleteCustomSource = category;
            this.txtSupplier.AutoCompleteCustomSource = supplier;
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
                    && double.TryParse(this.TxtCost.Text, out double cost))
                {
                    // Default stock status unless specified
                    string status = "OUT";
                    if (quantity > 0)
                    {
                        status = "IN (" + quantity.ToString(CultureInfo.CurrentCulture) + ")";
                    }

                    // Insert to Inventory
                    this.db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = this.txtItem.Text,
                        Qty = quantity,
                        UnitPrice = unitPrice,
                        Cost = cost,
                        DateModified = DateTime.Now,
                        Category = this.txtCategory.Text,
                        Supplier = this.txtSupplier.Text,
                        InStock = quantity != 0,
                        Status = status,
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

        private void TxtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.TxtCost.Text.Contains('.'))
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
