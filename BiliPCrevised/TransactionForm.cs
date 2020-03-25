namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using MongoDB.Bson;

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

        private void RefreshDataGrid()
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");
            this.dgdCart.DataSource = cartRecord;
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

            this.RefreshDataGrid();
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pass the value before resetting the box
            string returnItem = this.cboItem.Text;

            // Reset the cboItem value
            this.cboItem.Items.Clear();
            this.cboItem.Text = string.Empty;
            var selectedCatRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Category", this.cboCategory.Text);

            // Change cboItem.Items value depending on selected cboCategory
            foreach (var cboInventory in selectedCatRecord)
            {
                if (!this.cboItem.Items.Contains(cboInventory.Item))
                {
                    this.cboItem.Items.Add(cboInventory.Item);

                    // Show the cleared value at the textbox if same category
                    if (returnItem == cboInventory.Item)
                    {
                        this.cboItem.Text = returnItem;
                    }
                }
            }
        }

        private void CboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtQuantity.Text))
            {
                this.txtQuantity.Text = "0";
            }

            var selectedRecord = this.db.LoadRecordsBySpecificT<InventoryModel>("Inventory", "Item", this.cboItem.Text);
            this.cboItem.Text = selectedRecord.Item;
            this.cboCategory.Text = selectedRecord.Category;
            this.txtUnitPrice.Text = selectedRecord.UnitPrice.ToString(CultureInfo.InvariantCulture);
            this.txtTotalUnitPrice.Text = (selectedRecord.UnitPrice *
                int.Parse(this.txtQuantity.Text, CultureInfo.InvariantCulture))
                .ToString(CultureInfo.InvariantCulture);
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            var selectedInvRecord = this.db.LoadRecordsBySpecificT<InventoryModel>("Inventory", "Item", this.cboItem.Text);
            var selectedCartRecord = this.db.LoadRecordById<TransactionTempModel>("TransactionTempModel", selectedInvRecord.Id);

            if (selectedCartRecord == null)
            {
                selectedCartRecord = new TransactionTempModel
                {
                    Id = selectedInvRecord.Id,
                };
            }

            selectedCartRecord.Id = selectedInvRecord.Id;
            selectedCartRecord.Item = selectedInvRecord.Item;
            selectedCartRecord.Quantity = int.Parse(s: this.txtQuantity.Text, CultureInfo.InvariantCulture);
            selectedCartRecord.UnitPrice = selectedInvRecord.UnitPrice;
            selectedCartRecord.TotalUnitPrice = selectedCartRecord.UnitPrice * selectedCartRecord.Quantity;

            this.db.UpsertRecord<TransactionTempModel>("TransactionTemp", selectedCartRecord.Id, selectedCartRecord);
            this.RefreshDataGrid();
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cboItem.Text))
            {
                if (string.IsNullOrEmpty(this.txtQuantity.Text))
                {
                    this.txtQuantity.Text = "0";
                }

                var selectedRecord = this.db.LoadRecordsBySpecificT<InventoryModel>("Inventory", "Item", this.cboItem.Text);
                this.txtUnitPrice.Text = selectedRecord.UnitPrice.ToString(CultureInfo.InvariantCulture);
                try
                {
                    this.txtTotalUnitPrice.Text = (selectedRecord.UnitPrice
                        * int.Parse(this.txtQuantity.Text, CultureInfo.InvariantCulture))
                        .ToString(CultureInfo.InvariantCulture);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid character.");
                }
            }
        }

        private void TxtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            this.txtChange.Text = (double.Parse(this.txtAmountReceived.Text, CultureInfo.InvariantCulture)
                - double.Parse(this.txtTotalPrice.Text, CultureInfo.InvariantCulture))
                .ToString(CultureInfo.InvariantCulture);
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            using (AddDiscount addDiscount = new AddDiscount())
            {
                addDiscount.ShowDialog();
            }
        }
    }
}
