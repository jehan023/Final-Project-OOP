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
            bool itemExists = db.CheckExistence<InventoryModel>("Inventory", "Item", ItemBox.Text);

            // Check thy empty boxes
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
                MessageBox.Show("Please fill all of the "+ EmptyField + " field/s.");
            }
            else if (itemExists == true)
            {
                MessageBox.Show("Item already exists.");
            }
            else if (itemExists == false)
            {
                try
                {
                    bool InStock = false;
                    if (Int32.Parse(QuantityBox.Text) > 0)
                    {
                        InStock = true;
                    }
                    else
                    {
                        InStock = false;
                    }
                    db.InsertRecord("Inventory", new InventoryModel
                    {
                        Item = ItemBox.Text,
                        Qty = Int32.Parse(QuantityBox.Text),
                        UnitPrice = Double.Parse(UnitPriceBox.Text),
                        Cost = Double.Parse(CostBox.Text),
                        Category = CategoryBox.Text,
                        Supplier = SupplierBox.Text,
                        Status = InStock
                    }); 
                    MessageBox.Show("Item saved!");
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unhandled exception " + ex + ". Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Unknown Error.");
            }


        }
    }
}
