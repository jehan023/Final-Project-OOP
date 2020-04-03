namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class SalesReport : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public SalesReport()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalesReport_Load(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.dgdInventoryReport.DataSource = salesRecord;

            foreach (var transaction in salesRecord)
            {
                if (!this.cboViewMonth.Items.Contains(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.cboViewMonth.Items.Add(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.dgdInventoryReport.DataSource = salesRecord;
        }

        private void CboViewMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime monYear = DateTime.Parse(this.cboViewMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthListT<SalesHistoryModel>(
                "SalesHistory", "DateOfPurchase", monYear.Year, monYear.Month, DateTime.DaysInMonth(monYear.Year, monYear.Month));
            this.dgdInventoryReport.DataSource = selectedRecord;

            double totalCostItemSold, totalRetailPrice, grossMargin, employeeSalary, netProfit, profitPercentage;
            totalCostItemSold = totalRetailPrice = grossMargin = employeeSalary = 0;

            foreach (var transaction in selectedRecord)
            {
                totalCostItemSold += transaction.TCIS;
                totalRetailPrice += transaction.TRA;
                grossMargin += transaction.GrossMargin;
            }

            netProfit = grossMargin - employeeSalary;
            profitPercentage = (netProfit / totalCostItemSold) * 100;
            this.txtTCIS.Text = totalCostItemSold.ToString(CultureInfo.CurrentCulture);
            this.txtTRA.Text = totalRetailPrice.ToString(CultureInfo.CurrentCulture);
            this.txtGrossMargin.Text = grossMargin.ToString(CultureInfo.CurrentCulture);
            this.txtNetProfit.Text = netProfit.ToString(CultureInfo.CurrentCulture);
            this.txtProfitPerce.Text = profitPercentage.ToString(CultureInfo.CurrentCulture);
        }
    }
}
