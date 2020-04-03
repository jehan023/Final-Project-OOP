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
            var selectedRecord = this.db.LoadRecordsByStringList<InventoryModel>("Inventory", "Category", this.cboViewMonth.Text);
            this.dgdInventoryReport.DataSource = selectedRecord;
        }
    }
}
