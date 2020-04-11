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
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            this.dgdInventoryReport.DataSource = inventoryRecord;
            foreach (var item in inventoryRecord)
            {
                if (!this.CboViewMonth.Items.Contains(item.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.CboViewMonth.Items.Add(item.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            var deletedItemRecord = this.db.LoadRecords<InventoryModel>("InventoryDeletedRecords");
            foreach (var record in deletedItemRecord)
            {
                if (!this.CboViewMonth.Items.Contains(record.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture)))
                {
                    this.CboViewMonth.Items.Add(record.DateModified.ToString("MMMM yyyy", CultureInfo.CurrentCulture));
                }
            }

            this.RefreshDataGrids(inventoryRecord, deletedItemRecord);
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            this.CboViewMonth.Text = string.Empty;
            var deletedItemRecord = this.db.LoadRecords<InventoryModel>("InventoryDeletedRecords");

            this.RefreshDataGrids(inventoryRecord, deletedItemRecord);
        }

        private void CboViewMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime monYear = DateTime.Parse(this.CboViewMonth.Text, CultureInfo.InvariantCulture);
            var selectedRecord = this.db.LoadRecordsByMonthList<InventoryModel>(
                "Inventory", "DateModified", monYear.Year, monYear.Month);
            var deletedItemRecord = this.db.LoadRecordsByMonthList<InventoryModel>(
                "InventoryDeletedRecords", "DateModified", monYear.Year, monYear.Month);
            this.RefreshDataGrids(selectedRecord, deletedItemRecord);
        }

        private void RefreshDataGrids(List<InventoryModel> inventoryReport, List<InventoryModel> deletedItemRecord)
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
                    totalRetailPrice += item.UnitPrice * qty.Qty;
                }
            }

            this.txtTCAI.Text = totalCostAllItems.ToString(CultureInfo.CurrentCulture);
            this.txtTRA.Text = totalRetailPrice.ToString(CultureInfo.CurrentCulture);
        }

        private void BtnClearDelRec_Click(object sender, EventArgs e)
        {
            var deletedRecords = this.db.LoadRecords<InventoryModel>("InventoryDeletedRecords");
            if (!string.IsNullOrEmpty(this.CboViewMonth.Text))
            {
                DateTime monYear = DateTime.Parse(this.CboViewMonth.Text, CultureInfo.InvariantCulture);
                deletedRecords = this.db.LoadRecordsByMonthList<InventoryModel>("InventoryDeletedRecords", "DateModified", monYear.Year, monYear.Month);
            }

            foreach (var record in deletedRecords)
            {
                this.db.DeleleRecord<InventoryModel>("InventoryDeletedRecords", record.Id);
            }

            var inventoryRecord = this.db.LoadRecords<InventoryModel>("Inventory");
            deletedRecords = this.db.LoadRecords<InventoryModel>("InventoryDeletedRecords");
            this.RefreshDataGrids(inventoryRecord, deletedRecords);
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
            if (!string.IsNullOrEmpty(this.CboViewMonth.Text))
            {
                xlWorkSheet.Name = this.CboViewMonth.Text;
            }
            else
            {
                xlWorkSheet.Name = "Inventory Report";
            }

            // Storing header part in Excel
            for (int x = 1; x < this.dgdInventoryReport.ColumnCount; x++)
            {
                if (this.dgdInventoryReport.Columns[x].Visible)
                {
                    xlWorkSheet.Cells[1, x] = this.dgdInventoryReport.Columns[x].HeaderText;
                }
            }

            // Default distance between datagrid and the summary
            int lastRow = 2;

            // Storing Each row and column value to excel sheet
            for (int y = 0; y < this.dgdInventoryReport.Rows.Count; y++)
            {
                for (int x = 1; x < this.dgdInventoryReport.ColumnCount; x++)
                {
                    if (this.dgdInventoryReport.Columns[x].Visible)
                    {
                        xlWorkSheet.Cells[y + 2, x] = this.dgdInventoryReport.Rows[y].Cells[x].Value.ToString();
                    }
                }

                lastRow += 1;
            }

            // Summary of the data
            xlWorkSheet.Cells[lastRow + 1, 1] = "Total Cost of All Items: ";
            xlWorkSheet.Cells[lastRow + 1, 2] = this.txtTCAI.Text;
            xlWorkSheet.Cells[lastRow + 2, 1] = "Total Retail Amount of All Items: ";
            xlWorkSheet.Cells[lastRow + 2, 2] = this.txtTRA.Text;

            // Save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = $"BiliPC Inventory Report {this.CboViewMonth.Text}",
                DefaultExt = ".xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 2,
            };

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

        private void CboViewMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
