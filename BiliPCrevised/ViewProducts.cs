namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class ViewProducts : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public ViewProducts()
        {
            this.InitializeComponent();
            this.RefreshInventory();
        }

        private void RefreshInventory()
        {
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            this.dgdViewProducts.DataSource = inventoryRecord;
            this.txtSearchItem.Text = string.Empty;

            foreach (var itemInventory in inventoryRecord)
            {
                if (!this.cboCategory.Items.Contains(itemInventory.Category))
                {
                    this.cboCategory.Items.Add(itemInventory.Category);
                }
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchItem_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsBySpecific<InventoryModel>("Inventory", "Item", this.txtSearchItem.Text);
            this.dgdViewProducts.DataSource = selectedRecord;
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsBySpecific<InventoryModel>("Inventory", "Category", this.cboCategory.Text);
            this.dgdViewProducts.DataSource = selectedRecord;
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            this.RefreshInventory();
        }
    }
}
