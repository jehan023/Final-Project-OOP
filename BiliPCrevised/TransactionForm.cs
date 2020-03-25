namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class TransactionForm : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public TransactionForm()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            foreach (var cboInventory in inventoryRecord)
            {
                if (!this.cboCategory.Items.Contains(cboInventory.Category))
                {
                    this.cboCategory.Items.Add(cboInventory.Category);
                }

                if (!this.cboItem.Items.Contains(cboInventory.Item))
                {
                    this.cboItem.Items.Add(cboInventory.Item);
                }
            }
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Category", this.cboCategory.Text);
            this.cboItem.Items.Clear();
            this.cboItem.Text = string.Empty;

            // Change cboItem.Items value depending on selected cboCategory
            foreach (var cboInventory in selectedRecord)
            {
                if (!this.cboItem.Items.Contains(cboInventory.Item))
                {
                    this.cboItem.Items.Add(cboInventory.Item);
                }
            }
        }

        private void CboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Item", this.cboItem.Text);

            // Change cboCategory.Items value depending on selected cboItem
            foreach (var cboInventory in selectedRecord)
            {
                if (!this.cboCategory.Items.Contains(cboInventory.Category))
                {
                    this.cboCategory.Items.Add(cboInventory.Category);
                    this.cboCategory.Text = cboInventory.Category;
                }
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            bool itemExists = this.db.CheckExistence<InventoryModel>("Transaction_TEMP", "Item", this.cboItem.Text);
            var selectedRecord = this.db.LoadRecordsBySpecificT<InventoryModel>("Transaction_TEMP", "Item", this.cboItem.Text);

            // CODEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
        }
    }
}
