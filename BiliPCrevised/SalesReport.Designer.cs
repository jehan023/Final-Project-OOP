namespace BiliPC
{
    partial class SalesReport
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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.cboViewMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dgdInventoryReport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossMarginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesHistoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtGrossMargin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProfitPerce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTCIS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryModelBindingSource)).BeginInit();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.SaddleBrown;
            this.pnlTop.Controls.Add(this.btnGenerateReport);
            this.pnlTop.Controls.Add(this.cboViewMonth);
            this.pnlTop.Controls.Add(this.lblMonth);
            this.pnlTop.Controls.Add(this.btnShowAll);
            this.pnlTop.Controls.Add(this.lblSalesReport);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 117);
            this.pnlTop.TabIndex = 4;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Location = new System.Drawing.Point(818, 51);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(102, 44);
            this.btnGenerateReport.TabIndex = 23;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // cboViewMonth
            // 
            this.cboViewMonth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboViewMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboViewMonth.FormattingEnabled = true;
            this.cboViewMonth.Location = new System.Drawing.Point(156, 69);
            this.cboViewMonth.Name = "cboViewMonth";
            this.cboViewMonth.Size = new System.Drawing.Size(312, 26);
            this.cboViewMonth.TabIndex = 22;
            this.cboViewMonth.SelectedIndexChanged += new System.EventHandler(this.CboViewMonth_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(26, 73);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(121, 22);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "View Month:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(698, 51);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(102, 44);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.AutoSize = true;
            this.lblSalesReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.ForeColor = System.Drawing.Color.White;
            this.lblSalesReport.Location = new System.Drawing.Point(26, 20);
            this.lblSalesReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(216, 37);
            this.lblSalesReport.TabIndex = 16;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.LightCoral;
            this.btnX.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Black;
            this.btnX.Location = new System.Drawing.Point(921, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 27);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBackground.Controls.Add(this.sfDataGrid1);
            this.pnlBackground.Controls.Add(this.dgdInventoryReport);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 5;
            // 
            // dgdInventoryReport
            // 
            this.dgdInventoryReport.AllowUserToAddRows = false;
            this.dgdInventoryReport.AllowUserToDeleteRows = false;
            this.dgdInventoryReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdInventoryReport.AutoGenerateColumns = false;
            this.dgdInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.dateOfPurchaseDataGridViewTextBoxColumn,
            this.tCISDataGridViewTextBoxColumn,
            this.tRADataGridViewTextBoxColumn,
            this.netSalesDataGridViewTextBoxColumn,
            this.grossMarginDataGridViewTextBoxColumn});
            this.dgdInventoryReport.DataSource = this.salesHistoryModelBindingSource;
            this.dgdInventoryReport.Location = new System.Drawing.Point(26, 22);
            this.dgdInventoryReport.Name = "dgdInventoryReport";
            this.dgdInventoryReport.ReadOnly = true;
            this.dgdInventoryReport.RowHeadersWidth = 51;
            this.dgdInventoryReport.Size = new System.Drawing.Size(894, 311);
            this.dgdInventoryReport.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfPurchaseDataGridViewTextBoxColumn
            // 
            this.dateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "DateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "DateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.Name = "dateOfPurchaseDataGridViewTextBoxColumn";
            this.dateOfPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCISDataGridViewTextBoxColumn
            // 
            this.tCISDataGridViewTextBoxColumn.DataPropertyName = "TCIS";
            this.tCISDataGridViewTextBoxColumn.HeaderText = "TCIS";
            this.tCISDataGridViewTextBoxColumn.Name = "tCISDataGridViewTextBoxColumn";
            this.tCISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRADataGridViewTextBoxColumn
            // 
            this.tRADataGridViewTextBoxColumn.DataPropertyName = "TRA";
            this.tRADataGridViewTextBoxColumn.HeaderText = "TRA";
            this.tRADataGridViewTextBoxColumn.Name = "tRADataGridViewTextBoxColumn";
            this.tRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netSalesDataGridViewTextBoxColumn
            // 
            this.netSalesDataGridViewTextBoxColumn.DataPropertyName = "NetSales";
            this.netSalesDataGridViewTextBoxColumn.HeaderText = "NetSales";
            this.netSalesDataGridViewTextBoxColumn.Name = "netSalesDataGridViewTextBoxColumn";
            this.netSalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossMarginDataGridViewTextBoxColumn
            // 
            this.grossMarginDataGridViewTextBoxColumn.DataPropertyName = "GrossMargin";
            this.grossMarginDataGridViewTextBoxColumn.HeaderText = "GrossMargin";
            this.grossMarginDataGridViewTextBoxColumn.Name = "grossMarginDataGridViewTextBoxColumn";
            this.grossMarginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesHistoryModelBindingSource
            // 
            this.salesHistoryModelBindingSource.DataSource = typeof(BiliPC.SalesHistoryModel);
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.GroupTextBox.Controls.Add(this.txtGrossMargin);
            this.GroupTextBox.Controls.Add(this.label5);
            this.GroupTextBox.Controls.Add(this.txtProfitPerce);
            this.GroupTextBox.Controls.Add(this.label4);
            this.GroupTextBox.Controls.Add(this.txtNetProfit);
            this.GroupTextBox.Controls.Add(this.label3);
            this.GroupTextBox.Controls.Add(this.txtTRA);
            this.GroupTextBox.Controls.Add(this.label2);
            this.GroupTextBox.Controls.Add(this.txtTCIS);
            this.GroupTextBox.Controls.Add(this.label1);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 456);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 183);
            this.GroupTextBox.TabIndex = 46;
            this.GroupTextBox.TabStop = false;
            // 
            // txtGrossMargin
            // 
            this.txtGrossMargin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrossMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossMargin.Location = new System.Drawing.Point(592, 127);
            this.txtGrossMargin.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrossMargin.Name = "txtGrossMargin";
            this.txtGrossMargin.ReadOnly = true;
            this.txtGrossMargin.Size = new System.Drawing.Size(328, 29);
            this.txtGrossMargin.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(469, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 71;
            this.label5.Text = "Net Profit :";
            // 
            // txtProfitPerce
            // 
            this.txtProfitPerce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProfitPerce.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitPerce.Location = new System.Drawing.Point(592, 33);
            this.txtProfitPerce.Margin = new System.Windows.Forms.Padding(2);
            this.txtProfitPerce.Name = "txtProfitPerce";
            this.txtProfitPerce.ReadOnly = true;
            this.txtProfitPerce.Size = new System.Drawing.Size(328, 29);
            this.txtProfitPerce.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(374, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 22);
            this.label4.TabIndex = 69;
            this.label4.Text = "Profit Percentage % :";
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetProfit.Location = new System.Drawing.Point(592, 80);
            this.txtNetProfit.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.ReadOnly = true;
            this.txtNetProfit.Size = new System.Drawing.Size(328, 29);
            this.txtNetProfit.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(434, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 67;
            this.label3.Text = "Gross Margin :";
            // 
            // txtTRA
            // 
            this.txtTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRA.Location = new System.Drawing.Point(26, 129);
            this.txtTRA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTRA.Name = "txtTRA";
            this.txtTRA.ReadOnly = true;
            this.txtTRA.Size = new System.Drawing.Size(336, 29);
            this.txtTRA.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 22);
            this.label2.TabIndex = 65;
            this.label2.Text = "Total Retail Amount :";
            // 
            // txtTCIS
            // 
            this.txtTCIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTCIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCIS.Location = new System.Drawing.Point(26, 57);
            this.txtTCIS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCIS.Name = "txtTCIS";
            this.txtTCIS.ReadOnly = true;
            this.txtTCIS.Size = new System.Drawing.Size(336, 29);
            this.txtTCIS.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "Total Cost of Items Sold :";
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.DataSource = this.salesHistoryModelBindingSource;
            this.sfDataGrid1.Location = new System.Drawing.Point(30, 59);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(865, 250);
            this.sfDataGrid1.TabIndex = 24;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.GroupTextBox);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "SalesReport";
            this.Text = "``````````````````````````````````````````````````";
            this.Load += new System.EventHandler(this.SalesReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryModelBindingSource)).EndInit();
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cboViewMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgdInventoryReport;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.TextBox txtProfitPerce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetProfit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTCIS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrossMargin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfPurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesHistoryModelBindingSource;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
    }
}