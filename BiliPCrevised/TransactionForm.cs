    namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class TransactionForm : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public TransactionForm()
        {
            this.InitializeComponent();
        }

        public string Id { get; set; }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            this.RefreshCboItems();
            this.RefreshDiscountsToAll();
            this.RefreshDataGrid();
            this.RefreshDataUpper();
            this.RefreshDataLower();
        }

        private void RefreshAddButton()
        {
            bool itemExists = this.db.CheckExistenceByString<TransactionTempModel>("TransactionTemp", "Item", this.cboItem.Text);
            if (itemExists)
            {
                this.btnAddItem.Text = "MODIFY";
            }
            else
            {
                this.btnAddItem.Text = "ADD";
            }
        }

        private void RefreshDataUpper()
        {
            // Refresh Total Unit Price
            if (!string.IsNullOrEmpty(this.cboItem.Text) && int.TryParse(this.txtQuantity.Text, out int result))
            {
                InventoryModel selectedRecord = this.db.LoadRecordsByStringT<InventoryModel>("Inventory", "Item", this.cboItem.Text);
                this.txtUnitPrice.Text = selectedRecord.UnitPrice.ToString(CultureInfo.InvariantCulture);
                this.txtTotalUnitPrice.Text = (selectedRecord.UnitPrice * result)
                        .ToString(CultureInfo.InvariantCulture);

                // Comment this part if you do not want to change the category according to selected cboItem
                this.cboCategory.Text = selectedRecord.Category.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                // Comment by line if you want to disable refresh of textbox when category changes
                this.txtQuantity.Text =
                    this.txtUnitPrice.Text =
                    this.txtTotalUnitPrice.Text = "0";
            }
        }

        private void RefreshCboItems()
        {
            this.cboCategory.Text = this.cboItem.Text = string.Empty;
            this.txtQuantity.Text = this.txtUnitPrice.Text = this.txtTotalUnitPrice.Text = "0";

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

        private void RefreshDataLower()
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");

            // Refresh Total Price text
            double totalPrice = 0;

            foreach (var item in cartRecord)
            {
                totalPrice += item.TotalUnitPrice - (item.TotalUnitPrice * item.Discount / 100);
            }

            this.txtTotalPrice.Text = totalPrice.ToString(CultureInfo.InvariantCulture);

            // Refresh Change text
            double amountReceived = 0;
            if (!string.IsNullOrEmpty(this.txtAmountReceived.Text)
                && double.TryParse(this.txtAmountReceived.Text, out double result))
            {
                amountReceived = result;
            }
            else
            {
                this.txtAmountReceived.Text = "0";
            }

            this.txtChange.Text = (amountReceived - totalPrice).ToString(CultureInfo.InvariantCulture);
        }

        private void RefreshDiscountsToAll()
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");

            // Refresh discount and change to all
            double discount = 0;
            foreach (var item in cartRecord)
            {
                if (item.Discount > 0)
                {
                    discount = item.Discount;
                }
            }

            foreach (var item in cartRecord)
            {
                var selectedCartRecord = this.db.LoadRecordById<TransactionTempModel>("TransactionTemp", item.Id);
                selectedCartRecord.Discount = discount;
                this.db.UpsertRecord("TransactionTemp", selectedCartRecord.Id, selectedCartRecord);
            }
        }

        private void RefreshDataGrid()
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");

            // Default selected Item in the data grid
            this.dgdCart.DataSource = cartRecord;
            if (cartRecord.Any())
            {
                this.Id = this.dgdCart.Rows[0].Cells[0].Value.ToString();
            }
            else
            {
                this.Id = string.Empty;
            }
        }

        private void DgdCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.Id = this.dgdCart.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.cboItem.Text = this.dgdCart.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtQuantity.Text = this.dgdCart.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtUnitPrice.Text = this.dgdCart.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtTotalUnitPrice.Text = this.dgdCart.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void TxtAmountReceived_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtAmountReceived.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cboItem.Text))
            {
                this.RefreshAddButton();
                this.RefreshDataUpper();
            }
        }

        private void TxtAmountReceived_TextChanged(object sender, EventArgs e)
        {
            this.RefreshDataLower();
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

            this.RefreshAddButton();
            this.RefreshDataUpper();
        }

        private void CboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshDataUpper();
            this.RefreshAddButton();
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.cboItem.Text))
            {
                if (this.txtQuantity.Text != "0" && int.TryParse(this.txtQuantity.Text, out int result))
                {
                    var selectedInvRecord = this.db.LoadRecordsByStringT<InventoryModel>("Inventory", "Item", this.cboItem.Text);
                    var selectedCartRecord = this.db.LoadRecordById<TransactionTempModel>("TransactionTemp", selectedInvRecord.Id);

                    if (selectedCartRecord == null)
                    {
                        selectedCartRecord = new TransactionTempModel
                        {
                            Id = selectedInvRecord.Id,
                        };
                    }

                    selectedCartRecord.Id = selectedInvRecord.Id;
                    selectedCartRecord.Item = selectedInvRecord.Item;
                    selectedCartRecord.UnitPrice = selectedInvRecord.UnitPrice;
                    selectedCartRecord.Quantity = result;
                    selectedCartRecord.TotalUnitPrice = selectedCartRecord.UnitPrice * selectedCartRecord.Quantity;

                    if (selectedInvRecord.Qty >= selectedCartRecord.Quantity)
                    {
                        this.db.UpsertRecord("TransactionTemp", selectedCartRecord.Id, selectedCartRecord);
                        this.RefreshCboItems();
                        this.RefreshDiscountsToAll();
                        this.RefreshDataGrid();
                        this.RefreshDataLower();
                        this.RefreshAddButton();
                    }
                    else
                    {
                        MessageBox.Show("Please check the stocks of your item.");
                    }
                }
                else
                {
                    MessageBox.Show("Please add quantity.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (ObjectId.TryParse(this.Id, out ObjectId result))
            {
                this.db.DeleleRecord<TransactionTempModel>("TransactionTemp", result);
                MessageBox.Show("Item removed.");
                this.RefreshCboItems();
                this.RefreshDataGrid();
                this.RefreshDataLower();
                this.RefreshAddButton();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void BtnAddDiscount_Click(object sender, EventArgs e)
        {
            using (AddDiscount addDiscount = new AddDiscount())
            {
                addDiscount.ShowDialog();
            }

            this.RefreshDataGrid();
            this.RefreshDataLower();
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (ObjectId.TryParse(this.Id, out ObjectId id))
            {
                var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");
                var selectedCartRecord = this.db.LoadRecordById<TransactionTempModel>("TransactionTemp", id);
                double rawTotalPrice = 0;
                foreach (var item in cartRecord)
                {
                    rawTotalPrice += item.TotalUnitPrice;
                }

                using (PrintReceipt receipt = new PrintReceipt(
                    DateTime.Now.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture),
                    LoginUI.AcctName,
                    default,
                    cartRecord,
                    string.Format(CultureInfo.InvariantCulture, "₱{0:0.00}", rawTotalPrice),
                    string.Format(CultureInfo.InvariantCulture, "{0}%", selectedCartRecord.Discount),
                    string.Format(CultureInfo.InvariantCulture, "₱{0:0.00}", this.txtAmountReceived.Text),
                    string.Format(CultureInfo.InvariantCulture, "₱{0:0.00}", this.txtChange.Text),
                    string.Format(CultureInfo.InvariantCulture, "₱{0:0.00}", this.txtTotalPrice.Text)))
                {
                    receipt.ShowDialog();
                }
            }
        }
    }
}
