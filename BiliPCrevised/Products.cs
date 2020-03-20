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
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = client.GetDatabase("POS_Database");
        static IMongoCollection<InventoryModel> collection = db.GetCollection<InventoryModel>("Inventory");


        public Products()
        {
            InitializeComponent();
            ReadProductData();
        }

        //close the form
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add product
        private void button2_Click(object sender, EventArgs e)
        {
            AddNewItem addItem = new AddNewItem();
            addItem.ShowDialog();
        }

        //Refresh button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<InventoryModel> list = collection.AsQueryable().ToList<InventoryModel>();
            ProductDataGrid.DataSource = list;
        }

        //show in boxes the data
        public void ReadProductData()
        {
            List<InventoryModel> list = collection.AsQueryable().ToList<InventoryModel>();
            ProductDataGrid.DataSource = list;
            itemIdBox.Text = ProductDataGrid.Rows[0].Cells[0].Value.ToString();
            itemBox.Text = ProductDataGrid.Rows[0].Cells[1].Value.ToString();
            quantityBox.Text = ProductDataGrid.Rows[0].Cells[2].Value.ToString();
            priceBox.Text = ProductDataGrid.Rows[0].Cells[3].Value.ToString();
            costBox.Text = ProductDataGrid.Rows[0].Cells[4].Value.ToString();
            categoryBox.Text = ProductDataGrid.Rows[0].Cells[5].Value.ToString();
            supplierBox.Text = ProductDataGrid.Rows[0].Cells[6].Value.ToString();
            radioStatusTrue.Checked = ProductDataGrid.Rows[0].Cells[7].Value.Equals(true);
            radioStatusFalse.Checked = ProductDataGrid.Rows[0].Cells[7].Value.Equals(false);
        }

        //data selection in datagrid
        private void ProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                itemIdBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                itemBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                quantityBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                priceBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                costBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                categoryBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                supplierBox.Text = ProductDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
                radioStatusTrue.Checked = ProductDataGrid.Rows[e.RowIndex].Cells[7].Value.Equals(true);
                radioStatusFalse.Checked = ProductDataGrid.Rows[e.RowIndex].Cells[7].Value.Equals(false);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid selection.");
            }
        }

        public bool StatusChecker()
        {
            if (Int32.Parse(quantityBox.Text) > 0)
            {
                radioStatusTrue.Checked = true;
                return true;
            }
            else
            {
                radioStatusFalse.Checked = true;
                return false;
            }
        }
        
        //Update product
        private void button3_Click(object sender, EventArgs e)
        {
            MongoCRUD db = new MongoCRUD("POS_Database");

            // Check the empty boxes
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
                MessageBox.Show("Please fill all of the " + BoxesCount + " field/s.");
            }

            else
            {
                var updateDef = Builders<InventoryModel>.Update
                   .Set("Item", itemBox.Text)
                   .Set("Qty", Int32.Parse(quantityBox.Text))
                   .Set("UnitPrice", Double.Parse(priceBox.Text))
                   .Set("Cost", Double.Parse(costBox.Text))
                   .Set("Category", categoryBox.Text)
                   .Set("Status", StatusChecker())
                   .Set("Supplier", supplierBox.Text);
                collection.UpdateOne(p => p.Id == ObjectId.Parse(itemIdBox.Text), updateDef);
                ReadProductData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(p => p.Id == ObjectId.Parse(itemIdBox.Text));
            ReadProductData();
        }

    }
}
