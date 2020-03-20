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
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNewItem addItem = new AddNewItem();
            addItem.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<InventoryModel> list = collection.AsQueryable().ToList<InventoryModel>();
            ProductDataGrid.DataSource = list;
        }

        private void ProductDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
