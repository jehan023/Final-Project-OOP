using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class AddNewItem : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public AddNewItem()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            bool itemExists= db.CheckExistence<InventoryModel>("Inventory", "Item", ItemBox.Text);

            // Check thy empty boxes
            int BoxesCount = 0;
            foreach (Control control in GroupTextBox.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        BoxesCount += 1;
                    }
                }
            }

            if (BoxesCount > 0)
            {
                MessageBox.Show("Please fill all of the "+ BoxesCount + " field/s.");
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
                        Item = ItemBox.Text,
                        Quantity = int.Parse(QuantityBox.Text),
                        UnitPrice = double.Parse(UnitPriceBox.Text),
                        Cost = double.Parse(CostBox.Text),
                        Category = CategoryBox.Text,
                        Supplier = SupplierBox.Text
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
    }
}
