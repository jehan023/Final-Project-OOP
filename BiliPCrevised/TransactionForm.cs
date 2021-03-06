﻿    namespace BiliPC
{
    using System;
    using System.Collections.Generic;
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
            this.AutoCompleteSearch();
        }

        public string Id { get; set; }

        // Suggestion typing for search Item
        private void AutoCompleteSearch()
        {
            AutoCompleteStringCollection search = new AutoCompleteStringCollection();

            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");

            foreach (var itemInventory in inventoryRecord)
            {
                if (!search.Contains(itemInventory.Item))
                {
                    search.Add(itemInventory.Item);
                }
            }

            this.CboItem.AutoCompleteCustomSource = search;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();

            // When Transaction UI close automatically cart will be refreshed/dropped
            this.db.DropCollection<TransactionTempModel>("TransactionTemp");
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
            bool itemExists = this.db.CheckExistenceByGeneric<TransactionTempModel, string>("TransactionTemp", "Item", this.CboItem.Text);
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
            var salesRecByDate = this.db.LoadRecordsByMonthList<SalesHistoryModel>("SalesHistory", "DateOfPurchase", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Day);
            this.txtTransactionID.Text = string.Format(CultureInfo.CurrentCulture, "{0}{1:D5}", DateTime.Now.ToString("yyyyMMdd", CultureInfo.CurrentCulture), salesRecByDate.Count + 1);

            // Refresh Total Unit Price
            if (!string.IsNullOrEmpty(this.CboItem.Text) && int.TryParse(this.txtQuantity.Text, out int result))
            {
                InventoryModel selectedRecord = this.db.LoadRecordsByGenericT<InventoryModel, string>("Inventory", "Item", this.CboItem.Text);
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
            this.cboCategory.Text = this.CboItem.Text = string.Empty;
            this.txtQuantity.Text = this.txtUnitPrice.Text = this.txtTotalUnitPrice.Text = "0";

            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            foreach (var cboInventory in inventoryRecord)
            {
                if (!this.cboCategory.Items.Contains(cboInventory.Category))
                {
                    this.cboCategory.Items.Add(cboInventory.Category);
                }

                if (!this.CboItem.Items.Contains(cboInventory.Item))
                {
                    this.CboItem.Items.Add(cboInventory.Item);
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

            this.txtTotalPrice.Text = totalPrice.ToString(CultureInfo.CurrentCulture);

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

            this.txtChange.Text = (amountReceived - totalPrice).ToString(CultureInfo.CurrentCulture);
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
                var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", item.Id);
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
                this.CboItem.Text = this.dgdCart.Rows[e.RowIndex].Cells[1].Value.ToString();
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
            if (!string.IsNullOrEmpty(this.CboItem.Text))
            {
                this.CheckItem();
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
            var selectedCatRecord = this.db.LoadRecordsByGenericList<InventoryModel, string>("Inventory", "Category", this.cboCategory.Text);

            // Pass the value before resetting the box
            string returnItem = this.CboItem.Text;

            // Reset the cboItem value
            this.CboItem.Text = string.Empty;
            this.CboItem.Items.Clear();

            // Change cboItem.Items value depending on selected cboCategory
            foreach (var cboInventory in selectedCatRecord)
            {
                if (!this.CboItem.Items.Contains(cboInventory.Item))
                {
                    this.CboItem.Items.Add(cboInventory.Item);

                    // Show the cleared value at the textbox if same category
                    if (returnItem == cboInventory.Item)
                    {
                        this.CboItem.Text = returnItem;
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

        // Checks item input in CboItem
        private void CheckItem()
        {
            var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            bool exist = false;
            foreach (var item in invRecord)
            {
                if (this.CboItem.Text == item.Item)
                {
                    exist = true;
                }
            }

            if (exist == false)
            {
                // Message box showing Item is not exists.
                string message = "Item not exists.";
                string title = "Add Item";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                this.RefreshCboItems();
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            bool exist = false;
            foreach (var item in invRecord)
            {
                if (this.CboItem.Text == item.Item)
                {
                    exist = true;
                }
            }

            if (!string.IsNullOrEmpty(this.CboItem.Text))
            {
                if (exist == true)
                {
                    if (int.TryParse(this.txtQuantity.Text, out int quantity) && quantity > 0)
                    {
                        var selectedInvRecord = this.db.LoadRecordsByGenericT<InventoryModel, string>("Inventory", "Item", this.CboItem.Text);
                        if (selectedInvRecord.Qty >= quantity)
                        {
                            var cartExists = this.db.CheckExistenceByGeneric<TransactionTempModel, ObjectId>("TransactionTemp", "Id", selectedInvRecord.Id);
                            if (!cartExists)
                            {
                                this.db.InsertRecord("TransactionTemp", new TransactionTempModel { Id = selectedInvRecord.Id, });
                            }

                            var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", selectedInvRecord.Id);
                            selectedCartRecord.Item = selectedInvRecord.Item;
                            selectedCartRecord.UnitPrice = selectedInvRecord.UnitPrice;
                            selectedCartRecord.Quantity = quantity;
                            selectedCartRecord.TotalUnitPrice = selectedCartRecord.UnitPrice * selectedCartRecord.Quantity;

                            this.db.UpsertRecord("TransactionTemp", selectedCartRecord.Id, selectedCartRecord);
                            this.RefreshCboItems();
                            this.RefreshDiscountsToAll();
                            this.RefreshDataGrid();
                            this.RefreshDataLower();
                            this.RefreshAddButton();
                        }
                        else
                        {
                            // Shows how many stocks left for that item in cboItem
                            var stock = selectedInvRecord.Qty;
                            string msg = $"This item has {stock} available.";
                            string title = "Stocks Left";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(msg, title, buttons, MessageBoxIcon.Warning);
                            this.txtQuantity.Text = "0";
                        }
                    }
                    else
                    {
                        // Message box showing to add qty.
                        string message = "Please add quantity.";
                        string title = " ";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Message box showing Item is not exists.
                    string message = "Item not exists.";
                    string title = "Add Item";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    this.RefreshCboItems();
                }
            }
            else
            {
                // Message box showing to select an item.
                string message = "Please select an item.";
                string title = " ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            if (ObjectId.TryParse(this.Id, out ObjectId id))
            {
                this.db.DeleleRecord<TransactionTempModel>("TransactionTemp", id);
                MessageBox.Show("Item removed.");
                this.RefreshCboItems();
                this.RefreshDataGrid();
                this.RefreshDataLower();
                this.RefreshAddButton();
            }
            else
            {
                // Message box showing to select an item on cart.
                string message = "Please select an item.";
                string title = " ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
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
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");
            if (cartRecord.Any())
            {
                if (ObjectId.TryParse(this.Id, out ObjectId id)
                && double.TryParse(this.txtAmountReceived.Text, out double cash)
                && double.TryParse(this.txtChange.Text, out double change)
                && double.TryParse(this.txtTotalPrice.Text, out double totalPrice)
                && change >= 0)
                {
                    // Message box confirmation of transaction
                    string message = "Do you want to continue?";
                    string title = "Transaction Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (CustomerInfo info = new CustomerInfo())
                        {
                            info.ShowDialog();
                        }

                        var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", id);
                        using (PrintReceipt receipt = new PrintReceipt(
                            DateTime.Now.ToString("MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture),
                            LoginUI.AcctName,
                            this.txtTransactionID.Text,
                            CustomerInfo.CustomerName,
                            CustomerInfo.ContactNo,
                            cartRecord,
                            string.Format(CultureInfo.CurrentCulture, "₱{0:0.00}", cartRecord.Sum(x => x.TotalUnitPrice)),
                            string.Format(CultureInfo.CurrentCulture, "{0}%", selectedCartRecord.Discount),
                            string.Format(CultureInfo.CurrentCulture, "₱{0:0.00}", cash),
                            string.Format(CultureInfo.CurrentCulture, "₱{0:0.00}", change),
                            string.Format(CultureInfo.CurrentCulture, "₱{0:0.00}", totalPrice)))
                        {
                            receipt.ShowDialog();
                        }

                        this.Transact(cartRecord);
                    }
                }
                else
                {
                    // Message box showing to check your cash input.
                    string message = "Please check your cash.";
                    string title = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Message box showing to add item on cart.
                string message = "Please add an item.";
                string title = " ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void BtnTransact_Click(object sender, EventArgs e)
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");
            if (cartRecord.Any())
            {
                if (double.TryParse(this.txtChange.Text, out double change) && change >= 0)
                {
                    // Message box confirmation of transaction
                    string message = "Do you want to continue?";
                    string title = "Transaction Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        using (CustomerInfo info = new CustomerInfo())
                        {
                            info.ShowDialog();
                        }

                        this.Transact(cartRecord);
                    }
                }
                else
                {
                    // Message box showing to check your cash input.
                    string message = "Please check your cash.";
                    string title = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Message box showing to add item on cart.
                string message = "Please add an item.";
                string title = " ";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void Transact(List<TransactionTempModel> cartRecord)
        {
            if (double.TryParse(this.txtTotalPrice.Text, out double totalPrice)
                && double.TryParse(this.txtChange.Text, out double change))
            {
                var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");
                double totalCostItemSold = 0;
                foreach (var cart in cartRecord)
                {
                    foreach (var item in invRecord)
                    {
                        if (cart.Id == item.Id)
                        {
                            if (item.Qty == cart.Quantity)
                            {
                                item.InStock = false;
                            }

                            item.Qty -= cart.Quantity;
                            item.DateModified = DateTime.Now;

                            string status = "OUT";
                            if (item.Qty > 0)
                            {
                                status = "IN (" + item.Qty.ToString(CultureInfo.CurrentCulture) + ")";
                            }

                            item.Status = status;
                            this.db.UpsertRecord("Inventory", item.Id, item);
                            totalCostItemSold += item.Cost * cart.Quantity;
                            break;
                        }
                    }
                }

                // Insert the sales history to the database
                this.db.InsertRecord("SalesHistory", new SalesHistoryModel
                {
                    TransactionId = this.txtTransactionID.Text,
                    Items = string.Join(", ", (from item in cartRecord select item.Item).ToArray()),
                    DateOfPurchase = DateTime.Now,
                    Employee = LoginUI.AcctName,
                    CustomerName = CustomerInfo.CustomerName,
                    CustomerNo = CustomerInfo.ContactNo,
                    TCIS = totalCostItemSold,
                    TRA = cartRecord.Sum(x => x.TotalUnitPrice),
                    NetSales = totalPrice,
                    GrossMargin = totalPrice - totalCostItemSold,
                }); ;

                MessageBox.Show("Transaction Success!");
                this.db.DropCollection<TransactionTempModel>("TransactionTemp");

                this.txtChange.Text = this.txtAmountReceived.Text = string.Empty;
                this.RefreshDataUpper();
                this.RefreshDataGrid();
                this.RefreshDataLower();
            }
        }

        private void CboItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // true - disable typing
            e.Handled = false;
        }

        private void CboItem_TextChanged(object sender, EventArgs e)
        {
            // Refresh the CboItem and CboCategory
            if (string.IsNullOrEmpty(this.CboItem.Text))
            {
                this.RefreshCboItems();
            }

            // Automatic fill the Category box match with item
            var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            foreach (var item in invRecord)
            {
                if (this.CboItem.Text == item.Item)
                {
                    this.cboCategory.Text = item.Category;
                }
            }
        }
    }
}
