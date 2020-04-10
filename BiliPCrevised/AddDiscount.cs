namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class AddDiscount : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public AddDiscount()
        {
            this.InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddDiscount_Load(object sender, EventArgs e)
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");
            this.txtDiscount.Text = "0";

            // Refresh Total Price text
            double totalPrice = 0;

            foreach (var item in cartRecord)
            {
                totalPrice += item.TotalUnitPrice - (item.TotalUnitPrice * item.Discount / 100);
            }

            this.txtTotalPrice.Text = totalPrice.ToString("F", CultureInfo.CurrentCulture);
            this.RefreshDiscountedPrice();
        }

        private void RefreshDiscountedPrice()
        {
            if (string.IsNullOrEmpty(this.txtDiscount.Text))
            {
                this.txtDiscount.Text = "0";
            }

            if (double.TryParse(this.txtDiscount.Text, out double discount))
            {
                if (double.TryParse(this.txtTotalPrice.Text, out double totalPrice))
                {
                    this.txtDiscountedPrice.Text = (totalPrice - (discount / 100 * totalPrice))
                        .ToString("F", CultureInfo.CurrentCulture);
                }
            }
        }

        private void AddDiscountToAll(double discount)
        {
            var cartRecord = this.db.LoadRecords<TransactionTempModel>("TransactionTemp");

            foreach (var item in cartRecord)
            {
                var selectedCartRecord = this.db.LoadRecordsByGenericT<TransactionTempModel, ObjectId>("TransactionTemp", "Id", item.Id);
                selectedCartRecord.Discount = discount;
                this.db.UpsertRecord("TransactionTemp", selectedCartRecord.Id, selectedCartRecord);
            }
        }

        private void TxtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {
            this.RefreshDiscountedPrice();
        }

        private void BtnAddDiscount_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.txtDiscount.Text, out double discount))
            {
                if (discount == 100)
                {
                    DialogResult dialogResult = MessageBox.Show("This will make everything free. Are you sure with this?",  "Verify", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.AddDiscountToAll(discount);
                        this.Close();
                    }
                }
                else if (discount >= 0 && discount < 100)
                {
                    this.AddDiscountToAll(discount);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid value.");
                }
            }
        }
    }
}
