namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Microsoft.Reporting.WinForms;

    public partial class PrintReceipt : Form
    {
        public PrintReceipt(string dateTime, string employeeName, string transId, string customerName, string contactNo, List<TransactionTempModel> dataSource, string subtotal, string discount, string cash, string change, string totalPrice)
        {
            this.InitializeComponent();
            this.DateTime = dateTime;
            this.EmployeeName = employeeName;
            this.DataSource = dataSource;
            this.TransId = transId;
            this.CustomerName = customerName;
            this.CustomerNo = contactNo;
            this.Subtotal = subtotal;
            this.Discount = discount;
            this.Cash = cash;
            this.Change = change;
            this.TotalPrice = totalPrice;
        }

        private List<TransactionTempModel> DataSource { get; set; }

        private string DateTime { get; set; }

        private string EmployeeName { get; set; }

        private string TransId { get; set; }

        private string CustomerName { get; set; }

        private string CustomerNo { get; set; }

        private string Subtotal { get; set; }

        private string Discount { get; set; }

        private string TotalPrice { get; set; }

        private string Cash { get; set; }

        private string Change { get; set; }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            ReportDataSource source = new ReportDataSource("dsReceipt", this.DataSource);
            this.ReceiptViewer.LocalReport.DataSources.Clear();
            this.ReceiptViewer.LocalReport.DataSources.Add(source);

            ReportParameter[] para = new ReportParameter[]
            {
                new ReportParameter("pDate", this.DateTime),
                new ReportParameter("pSalesRepresentative", this.EmployeeName),
                new ReportParameter("pTransID", this.TransId),
                new ReportParameter("pCustomerName", this.CustomerName),
                new ReportParameter("pCustomerNo", this.CustomerNo),
                new ReportParameter("pSubtotalAmount", this.Subtotal),
                new ReportParameter("pDiscount", this.Discount),
                new ReportParameter("pTotalAmountDue", this.TotalPrice),
                new ReportParameter("pCash", this.Cash),
                new ReportParameter("pChange", this.Change),
            };
            this.ReceiptViewer.LocalReport.SetParameters(para);
            this.ReceiptViewer.RefreshReport();
        }
    }
}
