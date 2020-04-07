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

            this.RefreshDataGrid(salesRecord);
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
            this.RefreshDataGrid(selectedRecord);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.cboMonth.Text = string.Empty;
            this.RefreshDataGrid(salesRecord);
        }

        private void RefreshDataGrid(List<SalesHistoryModel> salesRecord)
        {
            this.dgdSalesHistory.DataSource = salesRecord;
        }
    }
}
