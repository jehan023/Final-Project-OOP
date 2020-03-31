namespace BiliPC
{
    partial class PrintReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReceiptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReceiptViewer
            // 
            this.ReceiptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReceiptViewer.LocalReport.ReportEmbeddedResource = "BiliPC.PrintReceiptViewer.rdlc";
            this.ReceiptViewer.Location = new System.Drawing.Point(0, 0);
            this.ReceiptViewer.Name = "ReceiptViewer";
            this.ReceiptViewer.ServerReport.BearerToken = null;
            this.ReceiptViewer.Size = new System.Drawing.Size(973, 576);
            this.ReceiptViewer.TabIndex = 0;
            // 
            // PrintReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 576);
            this.Controls.Add(this.ReceiptViewer);
            this.Name = "PrintReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintReceipt";
            this.Load += new System.EventHandler(this.PrintReceipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReceiptViewer;
    }
}