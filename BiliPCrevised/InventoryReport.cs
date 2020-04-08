namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class InventoryReport : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public InventoryReport()
        {
            this.InitializeComponent();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            var inventoryRecord = this.db.LoadRecords<InventoryReportModel>("InventoryReport");
            this.dgdInventoryReport.DataSource = inventoryRecord;
            foreach (var item in inventoryRecord)
            {
                if (!this.cboViewMonth.Items.Contains(item.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.cboViewMonth.Items.Add(item.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            var deletedItemRecord = this.db.LoadRecords<InventoryReportModel>("InventoryDeletedRecords");
            foreach (var record in deletedItemRecord)
            {
                if (!this.cboViewMonth.Items.Contains(record.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.cboViewMonth.Items.Add(record.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            this.RefreshDataGrids(inventoryRecord, deletedItemRecord);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var inventoryRecord = this.db.LoadRecords<InventoryReportModel>("InventoryReport");
            this.cboViewMonth.Text = string.Empty;
            var deletedItemRecord = this.db.LoadRecords<InventoryReportModel>("InventoryDeletedRecords");

            this.RefreshDataGrids(inventoryRecord, deletedItemRecord);
        }

        private void CboViewMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime monYear = DateTime.Parse(this.cboViewMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthList<InventoryReportModel>(
                "InventoryReport", "DateModified", monYear.Year, monYear.Month);
            var deletedItemRecord = this.db.LoadRecordsByMonthList<InventoryReportModel>(
                "InventoryDeletedRecords", "DateModified", monYear.Year, monYear.Month);
            this.RefreshDataGrids(selectedRecord, deletedItemRecord);
        }

        private void RefreshDataGrids(List<InventoryReportModel> inventoryReport, List<InventoryReportModel> deletedItemRecord)
        {
            this.dgdInventoryReport.DataSource = inventoryReport;
            this.dgdDeletedRecords.DataSource = deletedItemRecord;

            double totalCostAllItems, totalRetailPrice;
            totalCostAllItems = totalRetailPrice = 0;

            // Gets the quantity of each items in Inventory Model for summation
            var invRecord = this.db.LoadRecords<InventoryModel>("Inventory");

            // Summation of data in sales record
            foreach (var item in inventoryReport)
            {
                foreach (var qty in invRecord)
                {
                    totalCostAllItems += item.Cost * qty.Qty;
                    totalRetailPrice += item.RetailAmount * qty.Qty;
                }
            }

            this.txtTCAI.Text = totalCostAllItems.ToString(CultureInfo.CurrentCulture);
            this.txtTRA.Text = totalRetailPrice.ToString(CultureInfo.CurrentCulture);
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
                xlWorkSheet.Name = "Inventory Report";
            }

            // Storing header part in Excel
            for (int i = 2; i < this.dgdInventoryReport.Columns.Count + 1; i++)
            {
                xlWorkSheet.Cells[1, i - 1] = this.dgdInventoryReport.Columns[i - 1].HeaderText;
            }

            // Default distance between datagrid and the summary
            int lastRow = 2;

            // Storing Each row and column value to excel sheet
            for (int i = 0; i < this.dgdInventoryReport.Rows.Count; i++)
            {
                for (int j = 1; j < this.dgdInventoryReport.Columns.Count; j++)
                {
                    xlWorkSheet.Cells[i + 2, j] = this.dgdInventoryReport.Rows[i].Cells[j].Value.ToString();
                }

                lastRow += 1;
            }

            // Summary of the data
            xlWorkSheet.Cells[lastRow + 1, 1] = "Total Cost of All Items: ";
            xlWorkSheet.Cells[lastRow + 1, 2] = this.txtTCAI.Text;
            xlWorkSheet.Cells[lastRow + 2, 1] = "Total Retail Amount of All Items: ";
            xlWorkSheet.Cells[lastRow + 2, 2] = this.txtTRA.Text;

            // -------------------------------Add new worksheet for deleted items------------------------------

            // Save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "BiliPC Inventory Report";
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
