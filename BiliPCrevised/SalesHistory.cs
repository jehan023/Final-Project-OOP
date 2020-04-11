namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class SalesHistory : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public SalesHistory()
        {
            this.InitializeComponent();
            this.AutoCompleteSearch();
        }

        private void AutoCompleteSearch()
        {
            AutoCompleteStringCollection search = new AutoCompleteStringCollection();

            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");

            foreach (var id in salesRecord)
            {
                if (!search.Contains(id.TransactionId))
                {
                    search.Add(id.TransactionId);
                }
            }

            this.TxtTransID.AutoCompleteCustomSource = search;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            foreach (var transaction in salesRecord)
            {
                if (!this.CboMonth.Items.Contains(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.CboMonth.Items.Add(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            this.dgdSalesHistory.DataSource = salesRecord;
        }

        private void CboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var userRecord = this.db.LoadRecords<UsersModel>("Users");
            double employeeSalary = 0;
            foreach (var user in userRecord)
            {
                employeeSalary += user.Salary;
            }

            DateTime monYear = DateTime.Parse(this.CboMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthList<SalesHistoryModel>(
                "SalesHistory", "DateOfPurchase", monYear.Year, monYear.Month);
            this.dgdSalesHistory.DataSource = selectedRecord;
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.CboMonth.Text = this.TxtTransID.Text = string.Empty;
            this.dgdSalesHistory.DataSource = salesRecord;
        }

        private void TxtTransID_TextChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByCaseInsensitive<SalesHistoryModel>("SalesHistory", "TransactionId", this.TxtTransID.Text);
            this.dgdSalesHistory.DataSource = selectedRecord;
        }

        private void TxtTransID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }

        private void CboMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
