namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.WinForms.DataGridConverter;
    using Syncfusion.XlsIO;

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
            this.sfDataGrid1.DataSource = selectedRecord;

            double totalCostItemSold, totalRetailPrice, grossMargin, netSales, employeeSalary, netProfit, profitPercentage;
            totalCostItemSold = totalRetailPrice = grossMargin = netSales = employeeSalary = 0;

            foreach (var transaction in selectedRecord)
            {
                totalCostItemSold += transaction.TCIS;
                totalRetailPrice += transaction.TRA;
                netSales += transaction.NetSales;
                grossMargin += transaction.GrossMargin;
            }

            netProfit = grossMargin - employeeSalary;
            profitPercentage = (netProfit / netSales) * 100;
            this.txtTCIS.Text = totalCostItemSold.ToString(CultureInfo.CurrentCulture);
            this.txtTRA.Text = totalRetailPrice.ToString(CultureInfo.CurrentCulture);
            this.txtGrossMargin.Text = grossMargin.ToString(CultureInfo.CurrentCulture);
            this.txtNetProfit.Text = netProfit.ToString(CultureInfo.CurrentCulture);
            this.txtProfitPerce.Text = profitPercentage.ToString(CultureInfo.CurrentCulture);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            options.ExcludeColumns.Add("id");
            options.ExcludeColumns.Add("TCIS");
            var excelEngine = this.sfDataGrid1.ExportToExcel(this.sfDataGrid1.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            using (SaveFileDialog saveFilterDialog = new SaveFileDialog())
            {
                {
                    saveFilterDialog.FilterIndex = 2;
                    saveFilterDialog.Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx";
                }

                if (saveFilterDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFilterDialog.OpenFile())
                    {
                        if (saveFilterDialog.FilterIndex == 1)
                        {
                            workBook.Version = ExcelVersion.Excel97to2003;
                        }
                        else if (saveFilterDialog.FilterIndex == 2)
                        {
                            workBook.Version = ExcelVersion.Excel2010;
                        }
                        else
                        {
                            workBook.Version = ExcelVersion.Excel2013;
                        }

                        workBook.SaveAs(stream);
                    }

                    // Message box confirmation to view the created workbook.
                    if (MessageBox.Show(this.sfDataGrid1, "Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        // Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                        System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                    }
                }
            }
        }
    }
}
