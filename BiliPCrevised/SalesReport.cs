namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;
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
            this.dgdSalesReport.DataSource = salesRecord;
            foreach (var transaction in salesRecord)
            {
                if (!this.cboViewMonth.Items.Contains(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.cboViewMonth.Items.Add(transaction.DateOfPurchase.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            this.RefreshData(salesRecord);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var salesRecord = this.db.LoadRecords<SalesHistoryModel>("SalesHistory");
            this.cboViewMonth.Text = string.Empty;
            this.RefreshData(salesRecord);
        }

        private void RefreshData(List<SalesHistoryModel> salesRecord)
        {
            this.dgdSalesReport.DataSource = salesRecord;
            double totalCostItemSold, totalRetailPrice, grossMargin, employeeSalary, netSales, netProfit, profitPercentage;
            totalCostItemSold = totalRetailPrice = grossMargin = employeeSalary = netSales = 0;

            // -------- NOTICE: For improvement, employee salary must be recorded into the sales report                ------
            // -------- For example, the salary can be per transaction then deduct it when the transaction is finished ------
            // Retrieve summation of employees salary
            var userRecord = this.db.LoadRecords<UsersModel>("Users");
            foreach (var user in userRecord)
            {
                employeeSalary += user.Salary;
            }

            // Summation of data in sales record
            foreach (var transaction in salesRecord)
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

        private void CboViewMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime monYear = DateTime.Parse(this.cboViewMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthList<SalesHistoryModel>(
                "SalesHistory", "DateOfPurchase", monYear.Year, monYear.Month);
            this.RefreshData(selectedRecord);
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            // Creating Excel Application
            Microsoft.Office.Interop.Excel._Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            // Creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook xlWorkBook = xlApp.Workbooks.Add(Type.Missing);

            // Creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet xlWorkSheet = null;

            // See the excel sheet behind the program
            xlApp.Visible = false;

            // Get the reference of first sheet. By default its name is Sheet1.
            // Store its reference to worksheet
            xlWorkSheet = xlWorkBook.Sheets["Sheet1"];
            xlWorkSheet = xlWorkBook.ActiveSheet;

            // Changing the name of active sheet
            if (!string.IsNullOrEmpty(this.cboViewMonth.Text))
            {
                xlWorkSheet.Name = this.cboViewMonth.Text;
            }
            else
            {
                xlWorkSheet.Name = "Sales Report";
            }

            // Storing header part in Excel
            for (int i = 2; i < this.dgdSalesReport.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i - 1] = this.dgdSalesReport.Columns[i - 1].HeaderText;
            }

            // Default distance between datagrid and the summary
            int lastRow = 2;

            // Storing Each row and column value to excel sheet
            for (int i = 0; i < this.dgdSalesReport.Rows.Count; i++)
            {
                for (int j = 1; j < this.dgdSalesReport.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j] = this.dgdSalesReport.Rows[i].Cells[j].Value.ToString();
                }

                lastRow += 1;
            }

            // Summary of the data
            xlWorkSheet.Cells[lastRow + 1, 1] = "Total Cost of Items Sold: ";
            xlWorkSheet.Cells[lastRow + 1, 2] = this.txtTCIS.Text;
            xlWorkSheet.Cells[lastRow + 2, 1] = "Total Retail Amount: ";
            xlWorkSheet.Cells[lastRow + 2, 2] = this.txtTRA.Text;
            xlWorkSheet.Cells[lastRow + 3, 1] = "Gross Margin: ";
            xlWorkSheet.Cells[lastRow + 3, 2] = this.txtGrossMargin.Text;
            xlWorkSheet.Cells[lastRow + 4, 1] = "Net Profit: ";
            xlWorkSheet.Cells[lastRow + 4, 2] = this.txtNetProfit.Text;
            xlWorkSheet.Cells[lastRow + 5, 1] = "Profit Percentage: ";
            xlWorkSheet.Cells[lastRow + 5, 2] = this.txtProfitPerce.Text;

            // Save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "BiliPC Sales Report";
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Display alerts set to false so that another replace dialog won't appear
                    xlApp.DisplayAlerts = false;
                    xlWorkBook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    // Display alerts set to true so that alert will appear if something happens
                    xlApp.DisplayAlerts = true;
                    MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (COMException)
                {
                    // Occurs when trying to save same filename while opened in Microsoft Excel
                    MessageBox.Show("Error saving document. The filename might already exist and is used by another application.");
                }
            }

            // Exit from the application
            // Set to false because Excel opens another save option when save is cancelled
            xlWorkBook.Close(false);
            xlApp.Quit();

            this.ReleaseObject(xlWorkSheet);
            this.ReleaseObject(xlWorkBook);
            this.ReleaseObject(xlApp);
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception ex)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
