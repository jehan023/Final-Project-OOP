namespace BiliPC
{
    partial class InventoryReport
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
            this.lblInventoryReport = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblDeletedRecords = new System.Windows.Forms.Label();
            this.dgdDeletedRecords = new System.Windows.Forms.DataGridView();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtTCAI = new System.Windows.Forms.TextBox();
            this.lblTRA = new System.Windows.Forms.Label();
            this.txtTRA = new System.Windows.Forms.TextBox();
            this.lblTCAI = new System.Windows.Forms.Label();
            this.dgdInventoryReport = new System.Windows.Forms.DataGridView();
            this.inventoryReportModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifiedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeletedRecords)).BeginInit();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReportModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlTop.Controls.Add(this.btnGenerateReport);
            this.pnlTop.Controls.Add(this.cboViewMonth);
            this.pnlTop.Controls.Add(this.lblMonth);
            this.pnlTop.Controls.Add(this.btnShowAll);
            this.pnlTop.Controls.Add(this.lblInventoryReport);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 117);
            this.pnlTop.TabIndex = 3;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateReport.BackColor = System.Drawing.Color.SpringGreen;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateReport.Location = new System.Drawing.Point(793, 51);
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
            this.lblMonth.Location = new System.Drawing.Point(30, 69);
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
            this.btnShowAll.Location = new System.Drawing.Point(673, 51);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(102, 44);
            this.btnShowAll.TabIndex = 20;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // lblInventoryReport
            // 
            this.lblInventoryReport.AutoSize = true;
            this.lblInventoryReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventoryReport.ForeColor = System.Drawing.Color.White;
            this.lblInventoryReport.Location = new System.Drawing.Point(23, 20);
            this.lblInventoryReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInventoryReport.Name = "lblInventoryReport";
            this.lblInventoryReport.Size = new System.Drawing.Size(276, 37);
            this.lblInventoryReport.TabIndex = 16;
            this.lblInventoryReport.Text = "Inventory Report";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Firebrick;
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
            this.pnlBackground.Controls.Add(this.lblDeletedRecords);
            this.pnlBackground.Controls.Add(this.dgdDeletedRecords);
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdInventoryReport);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 4;
            // 
            // lblDeletedRecords
            // 
            this.lblDeletedRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDeletedRecords.AutoSize = true;
            this.lblDeletedRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblDeletedRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletedRecords.ForeColor = System.Drawing.Color.Black;
            this.lblDeletedRecords.Location = new System.Drawing.Point(585, 22);
            this.lblDeletedRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeletedRecords.Name = "lblDeletedRecords";
            this.lblDeletedRecords.Size = new System.Drawing.Size(163, 22);
            this.lblDeletedRecords.TabIndex = 67;
            this.lblDeletedRecords.Text = "Deleted Records";
            // 
            // dgdDeletedRecords
            // 
            this.dgdDeletedRecords.AllowUserToAddRows = false;
            this.dgdDeletedRecords.AllowUserToDeleteRows = false;
            this.dgdDeletedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdDeletedRecords.AutoGenerateColumns = false;
            this.dgdDeletedRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeletedRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.itemDataGridViewTextBoxColumn1,
            this.dateModifiedDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn1,
            this.supplierDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.costDataGridViewTextBoxColumn1,
            this.retailAmountDataGridViewTextBoxColumn1});
            this.dgdDeletedRecords.DataSource = this.inventoryReportModelBindingSource;
            this.dgdDeletedRecords.Location = new System.Drawing.Point(589, 47);
            this.dgdDeletedRecords.Name = "dgdDeletedRecords";
            this.dgdDeletedRecords.ReadOnly = true;
            this.dgdDeletedRecords.RowHeadersWidth = 51;
            this.dgdDeletedRecords.Size = new System.Drawing.Size(327, 340);
            this.dgdDeletedRecords.TabIndex = 48;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.GroupTextBox.Controls.Add(this.txtTCAI);
            this.GroupTextBox.Controls.Add(this.lblTRA);
            this.GroupTextBox.Controls.Add(this.txtTRA);
            this.GroupTextBox.Controls.Add(this.lblTCAI);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 393);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 129);
            this.GroupTextBox.TabIndex = 47;
            this.GroupTextBox.TabStop = false;
            // 
            // txtTCAI
            // 
            this.txtTCAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTCAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCAI.Location = new System.Drawing.Point(315, 62);
            this.txtTCAI.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCAI.Name = "txtTCAI";
            this.txtTCAI.ReadOnly = true;
            this.txtTCAI.Size = new System.Drawing.Size(268, 29);
            this.txtTCAI.TabIndex = 66;
            // 
            // lblTRA
            // 
            this.lblTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTRA.AutoSize = true;
            this.lblTRA.BackColor = System.Drawing.Color.Transparent;
            this.lblTRA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRA.ForeColor = System.Drawing.Color.Black;
            this.lblTRA.Location = new System.Drawing.Point(31, 23);
            this.lblTRA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTRA.Name = "lblTRA";
            this.lblTRA.Size = new System.Drawing.Size(254, 18);
            this.lblTRA.TabIndex = 65;
            this.lblTRA.Text = "Total retail amount of all items :";
            // 
            // txtTRA
            // 
            this.txtTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRA.Location = new System.Drawing.Point(315, 18);
            this.txtTRA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTRA.Name = "txtTRA";
            this.txtTRA.ReadOnly = true;
            this.txtTRA.Size = new System.Drawing.Size(268, 29);
            this.txtTRA.TabIndex = 64;
            // 
            // lblTCAI
            // 
            this.lblTCAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTCAI.AutoSize = true;
            this.lblTCAI.BackColor = System.Drawing.Color.Transparent;
            this.lblTCAI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCAI.ForeColor = System.Drawing.Color.Black;
            this.lblTCAI.Location = new System.Drawing.Point(101, 67);
            this.lblTCAI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTCAI.Name = "lblTCAI";
            this.lblTCAI.Size = new System.Drawing.Size(184, 18);
            this.lblTCAI.TabIndex = 63;
            this.lblTCAI.Text = "Total cost of all items :";
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
            this.itemDataGridViewTextBoxColumn,
            this.dateModifiedDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.retailAmountDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn});
            this.dgdInventoryReport.DataSource = this.inventoryReportModelBindingSource;
            this.dgdInventoryReport.Location = new System.Drawing.Point(26, 22);
            this.dgdInventoryReport.Name = "dgdInventoryReport";
            this.dgdInventoryReport.ReadOnly = true;
            this.dgdInventoryReport.RowHeadersWidth = 51;
            this.dgdInventoryReport.Size = new System.Drawing.Size(557, 365);
            this.dgdInventoryReport.TabIndex = 0;
            // 
            // inventoryReportModelBindingSource
            // 
            this.inventoryReportModelBindingSource.DataSource = typeof(BiliPC.InventoryReportModel);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn1
            // 
            this.itemDataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn1.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn1.Name = "itemDataGridViewTextBoxColumn1";
            this.itemDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateModifiedDataGridViewTextBoxColumn1
            // 
            this.dateModifiedDataGridViewTextBoxColumn1.DataPropertyName = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn1.HeaderText = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn1.Name = "dateModifiedDataGridViewTextBoxColumn1";
            this.dateModifiedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            this.categoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn1
            // 
            this.supplierDataGridViewTextBoxColumn1.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn1.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn1.Name = "supplierDataGridViewTextBoxColumn1";
            this.supplierDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            this.costDataGridViewTextBoxColumn1.ReadOnly = true;
            this.costDataGridViewTextBoxColumn1.Visible = false;
            // 
            // retailAmountDataGridViewTextBoxColumn1
            // 
            this.retailAmountDataGridViewTextBoxColumn1.DataPropertyName = "RetailAmount";
            this.retailAmountDataGridViewTextBoxColumn1.HeaderText = "RetailAmount";
            this.retailAmountDataGridViewTextBoxColumn1.Name = "retailAmountDataGridViewTextBoxColumn1";
            this.retailAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.retailAmountDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateModifiedDataGridViewTextBoxColumn
            // 
            this.dateModifiedDataGridViewTextBoxColumn.DataPropertyName = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn.HeaderText = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn.Name = "dateModifiedDataGridViewTextBoxColumn";
            this.dateModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // retailAmountDataGridViewTextBoxColumn
            // 
            this.retailAmountDataGridViewTextBoxColumn.DataPropertyName = "RetailAmount";
            this.retailAmountDataGridViewTextBoxColumn.HeaderText = "RetailAmount";
            this.retailAmountDataGridViewTextBoxColumn.Name = "retailAmountDataGridViewTextBoxColumn";
            this.retailAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "InventoryReport";
            this.Text = "Inventory_Report";
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeletedRecords)).EndInit();
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryReportModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblInventoryReport;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox cboViewMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgdInventoryReport;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.TextBox txtTCAI;
        private System.Windows.Forms.Label lblTRA;
        private System.Windows.Forms.TextBox txtTRA;
        private System.Windows.Forms.Label lblTCAI;
        private System.Windows.Forms.Label lblDeletedRecords;
        private System.Windows.Forms.DataGridView dgdDeletedRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifiedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource inventoryReportModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
    }
}