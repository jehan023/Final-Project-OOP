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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.CboViewMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblInventoryReport = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnClearDelRec = new System.Windows.Forms.Button();
            this.lblDeletedRecords = new System.Windows.Forms.Label();
            this.dgdDeletedRecords = new System.Windows.Forms.DataGridView();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtTCAI = new System.Windows.Forms.TextBox();
            this.lblTRA = new System.Windows.Forms.Label();
            this.txtTRA = new System.Windows.Forms.TextBox();
            this.lblTCAI = new System.Windows.Forms.Label();
            this.dgdInventoryReport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifiedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inStockDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDeletedRecords)).BeginInit();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlTop.Controls.Add(this.btnGenerateReport);
            this.pnlTop.Controls.Add(this.CboViewMonth);
            this.pnlTop.Controls.Add(this.lblMonth);
            this.pnlTop.Controls.Add(this.btnShowAll);
            this.pnlTop.Controls.Add(this.lblInventoryReport);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 117);
            this.pnlTop.TabIndex = 1;
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
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // CboViewMonth
            // 
            this.CboViewMonth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CboViewMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboViewMonth.FormattingEnabled = true;
            this.CboViewMonth.Location = new System.Drawing.Point(156, 65);
            this.CboViewMonth.Name = "CboViewMonth";
            this.CboViewMonth.Size = new System.Drawing.Size(312, 32);
            this.CboViewMonth.TabIndex = 224;
            this.CboViewMonth.SelectedIndexChanged += new System.EventHandler(this.CboViewMonth_SelectedIndexChanged);
            this.CboViewMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboViewMonth_KeyPress);
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
            this.lblMonth.TabIndex = 3;
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
            this.btnShowAll.TabIndex = 5;
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
            this.lblInventoryReport.TabIndex = 2;
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
            this.btnX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.pnlBackground.Controls.Add(this.btnClearDelRec);
            this.pnlBackground.Controls.Add(this.lblDeletedRecords);
            this.pnlBackground.Controls.Add(this.dgdDeletedRecords);
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdInventoryReport);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 7;
            // 
            // btnClearDelRec
            // 
            this.btnClearDelRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearDelRec.Location = new System.Drawing.Point(194, 270);
            this.btnClearDelRec.Name = "btnClearDelRec";
            this.btnClearDelRec.Size = new System.Drawing.Size(75, 23);
            this.btnClearDelRec.TabIndex = 10;
            this.btnClearDelRec.Text = "Clear";
            this.btnClearDelRec.UseVisualStyleBackColor = true;
            this.btnClearDelRec.Click += new System.EventHandler(this.BtnClearDelRec_Click);
            // 
            // lblDeletedRecords
            // 
            this.lblDeletedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDeletedRecords.AutoSize = true;
            this.lblDeletedRecords.BackColor = System.Drawing.Color.Transparent;
            this.lblDeletedRecords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletedRecords.ForeColor = System.Drawing.Color.Black;
            this.lblDeletedRecords.Location = new System.Drawing.Point(26, 270);
            this.lblDeletedRecords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeletedRecords.Name = "lblDeletedRecords";
            this.lblDeletedRecords.Size = new System.Drawing.Size(163, 22);
            this.lblDeletedRecords.TabIndex = 9;
            this.lblDeletedRecords.Text = "Deleted Records";
            // 
            // dgdDeletedRecords
            // 
            this.dgdDeletedRecords.AllowUserToAddRows = false;
            this.dgdDeletedRecords.AllowUserToDeleteRows = false;
            this.dgdDeletedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdDeletedRecords.AutoGenerateColumns = false;
            this.dgdDeletedRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdDeletedRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdDeletedRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDeletedRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dateModifiedDataGridViewTextBoxColumn1,
            this.itemDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn1,
            this.costDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn1,
            this.supplierDataGridViewTextBoxColumn1,
            this.inStockDataGridViewCheckBoxColumn1,
            this.statusDataGridViewTextBoxColumn1});
            this.dgdDeletedRecords.DataSource = this.inventoryModelBindingSource;
            this.dgdDeletedRecords.Location = new System.Drawing.Point(23, 296);
            this.dgdDeletedRecords.Name = "dgdDeletedRecords";
            this.dgdDeletedRecords.ReadOnly = true;
            this.dgdDeletedRecords.RowHeadersWidth = 51;
            this.dgdDeletedRecords.Size = new System.Drawing.Size(897, 123);
            this.dgdDeletedRecords.StandardTab = true;
            this.dgdDeletedRecords.TabIndex = 11;
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
            this.GroupTextBox.Location = new System.Drawing.Point(0, 415);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 107);
            this.GroupTextBox.TabIndex = 12;
            this.GroupTextBox.TabStop = false;
            // 
            // txtTCAI
            // 
            this.txtTCAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTCAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTCAI.Location = new System.Drawing.Point(335, 62);
            this.txtTCAI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTCAI.Name = "txtTCAI";
            this.txtTCAI.ReadOnly = true;
            this.txtTCAI.Size = new System.Drawing.Size(268, 29);
            this.txtTCAI.TabIndex = 16;
            // 
            // lblTRA
            // 
            this.lblTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTRA.AutoSize = true;
            this.lblTRA.BackColor = System.Drawing.Color.Transparent;
            this.lblTRA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRA.ForeColor = System.Drawing.Color.Black;
            this.lblTRA.Location = new System.Drawing.Point(51, 26);
            this.lblTRA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTRA.Name = "lblTRA";
            this.lblTRA.Size = new System.Drawing.Size(254, 18);
            this.lblTRA.TabIndex = 13;
            this.lblTRA.Text = "Total retail amount of all items :";
            // 
            // txtTRA
            // 
            this.txtTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRA.Location = new System.Drawing.Point(335, 21);
            this.txtTRA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTRA.Name = "txtTRA";
            this.txtTRA.ReadOnly = true;
            this.txtTRA.Size = new System.Drawing.Size(268, 29);
            this.txtTRA.TabIndex = 14;
            // 
            // lblTCAI
            // 
            this.lblTCAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTCAI.AutoSize = true;
            this.lblTCAI.BackColor = System.Drawing.Color.Transparent;
            this.lblTCAI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCAI.ForeColor = System.Drawing.Color.Black;
            this.lblTCAI.Location = new System.Drawing.Point(121, 67);
            this.lblTCAI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTCAI.Name = "lblTCAI";
            this.lblTCAI.Size = new System.Drawing.Size(184, 18);
            this.lblTCAI.TabIndex = 15;
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
            this.dgdInventoryReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdInventoryReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgdInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateModifiedDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.inStockDataGridViewCheckBoxColumn});
            this.dgdInventoryReport.DataSource = this.inventoryModelBindingSource;
            this.dgdInventoryReport.Location = new System.Drawing.Point(23, 22);
            this.dgdInventoryReport.Name = "dgdInventoryReport";
            this.dgdInventoryReport.ReadOnly = true;
            this.dgdInventoryReport.RowHeadersWidth = 51;
            this.dgdInventoryReport.Size = new System.Drawing.Size(897, 245);
            this.dgdInventoryReport.TabIndex = 8;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateModifiedDataGridViewTextBoxColumn1
            // 
            this.dateModifiedDataGridViewTextBoxColumn1.DataPropertyName = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn1.FillWeight = 106.0934F;
            this.dateModifiedDataGridViewTextBoxColumn1.HeaderText = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateModifiedDataGridViewTextBoxColumn1.Name = "dateModifiedDataGridViewTextBoxColumn1";
            this.dateModifiedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn1
            // 
            this.itemDataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn1.FillWeight = 149.7326F;
            this.itemDataGridViewTextBoxColumn1.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn1.Name = "itemDataGridViewTextBoxColumn1";
            this.itemDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.FillWeight = 63.44374F;
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn1
            // 
            this.unitPriceDataGridViewTextBoxColumn1.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn1.Name = "unitPriceDataGridViewTextBoxColumn1";
            this.unitPriceDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn1.Visible = false;
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            this.costDataGridViewTextBoxColumn1.ReadOnly = true;
            this.costDataGridViewTextBoxColumn1.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn1.FillWeight = 90.36512F;
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            this.categoryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn1
            // 
            this.supplierDataGridViewTextBoxColumn1.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn1.FillWeight = 90.36512F;
            this.supplierDataGridViewTextBoxColumn1.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn1.Name = "supplierDataGridViewTextBoxColumn1";
            this.supplierDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inStockDataGridViewCheckBoxColumn1
            // 
            this.inStockDataGridViewCheckBoxColumn1.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn1.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.inStockDataGridViewCheckBoxColumn1.Name = "inStockDataGridViewCheckBoxColumn1";
            this.inStockDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.inStockDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            this.statusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn1.Visible = false;
            // 
            // inventoryModelBindingSource
            // 
            this.inventoryModelBindingSource.DataSource = typeof(BiliPC.InventoryModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateModifiedDataGridViewTextBoxColumn
            // 
            this.dateModifiedDataGridViewTextBoxColumn.DataPropertyName = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn.FillWeight = 102.6373F;
            this.dateModifiedDataGridViewTextBoxColumn.HeaderText = "DateModified";
            this.dateModifiedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateModifiedDataGridViewTextBoxColumn.Name = "dateModifiedDataGridViewTextBoxColumn";
            this.dateModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.FillWeight = 209.6256F;
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.FillWeight = 80.89497F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.FillWeight = 76.71047F;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.FillWeight = 76.71047F;
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.FillWeight = 76.71047F;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.FillWeight = 76.71047F;
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Visible = false;
            // 
            // inStockDataGridViewCheckBoxColumn
            // 
            this.inStockDataGridViewCheckBoxColumn.DataPropertyName = "InStock";
            this.inStockDataGridViewCheckBoxColumn.HeaderText = "InStock";
            this.inStockDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.inStockDataGridViewCheckBoxColumn.Name = "inStockDataGridViewCheckBoxColumn";
            this.inStockDataGridViewCheckBoxColumn.ReadOnly = true;
            this.inStockDataGridViewCheckBoxColumn.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.inventoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblInventoryReport;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox CboViewMonth;
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
        private System.Windows.Forms.BindingSource inventoryModelBindingSource;
        private System.Windows.Forms.Button btnClearDelRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModifiedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inStockDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
    }
}