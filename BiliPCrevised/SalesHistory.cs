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
                if (!this.cboMonth.Items.Contains(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.cboMonth.Items.Add(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
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

            DateTime monYear = DateTime.Parse(this.cboMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthList<SalesHistoryModel>(
                "SalesHistory", "DateOfPurchase", monYear.Year, monYear.Month);
            this.dgdSalesHistory.DataSource = selectedRecord;
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.cboMonth.Text = string.Empty;
            this.dgdSalesHistory.DataSource = salesRecord;
        }


        private void TxtTransID_TextChanged(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByCaseInsensitive<SalesHistoryModel>("SalesHistory", "TransactionId", this.txtTransID.Text);
            this.dgdSalesHistory.DataSource = selectedRecord;
        }
    }
}
