namespace BiliPC
{
    partial class SalesHistory
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.lblTransID = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblSalesHistory = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.dgdSalesHistory = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfPurchaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossMarginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesHistoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdSalesHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.txtTransID);
            this.pnlTop.Controls.Add(this.lblTransID);
            this.pnlTop.Controls.Add(this.btnShowAll);
            this.pnlTop.Controls.Add(this.cboMonth);
            this.pnlTop.Controls.Add(this.lblMonth);
            this.pnlTop.Controls.Add(this.lblSalesHistory);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 117);
            this.pnlTop.TabIndex = 0;
            // 
            // txtTransID
            // 
            this.txtTransID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransID.Location = new System.Drawing.Point(172, 67);
            this.txtTransID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(312, 29);
            this.txtTransID.TabIndex = 9;
            this.txtTransID.TextChanged += new System.EventHandler(this.TxtTransID_TextChanged);
            // 
            // lblTransID
            // 
            this.lblTransID.AutoSize = true;
            this.lblTransID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransID.ForeColor = System.Drawing.Color.White;
            this.lblTransID.Location = new System.Drawing.Point(26, 70);
            this.lblTransID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransID.Name = "lblTransID";
            this.lblTransID.Size = new System.Drawing.Size(149, 22);
            this.lblTransID.TabIndex = 8;
            this.lblTransID.Text = "Transaction ID:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(811, 59);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(102, 44);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // cboMonth
            // 
            this.cboMonth.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboMonth.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(571, 67);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(207, 29);
            this.cboMonth.TabIndex = 2;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.CboMonth_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(498, 70);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(72, 22);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month:";
            // 
            // lblSalesHistory
            // 
            this.lblSalesHistory.AutoSize = true;
            this.lblSalesHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesHistory.ForeColor = System.Drawing.Color.White;
            this.lblSalesHistory.Location = new System.Drawing.Point(23, 20);
            this.lblSalesHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesHistory.Name = "lblSalesHistory";
            this.lblSalesHistory.Size = new System.Drawing.Size(221, 37);
            this.lblSalesHistory.TabIndex = 1;
            this.lblSalesHistory.Text = "Sales History";
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
            this.btnX.TabIndex = 6;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.SystemColors.Info;
            this.pnlBackground.Controls.Add(this.dgdSalesHistory);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 4;
            // 
            // dgdSalesHistory
            // 
            this.dgdSalesHistory.AllowUserToAddRows = false;
            this.dgdSalesHistory.AllowUserToDeleteRows = false;
            this.dgdSalesHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdSalesHistory.AutoGenerateColumns = false;
            this.dgdSalesHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdSalesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdSalesHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdSalesHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateOfPurchaseDataGridViewTextBoxColumn,
            this.transactionIdDataGridViewTextBoxColumn,
            this.itemsDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.tCISDataGridViewTextBoxColumn,
            this.tRADataGridViewTextBoxColumn,
            this.netSalesDataGridViewTextBoxColumn,
            this.grossMarginDataGridViewTextBoxColumn});
            this.dgdSalesHistory.DataSource = this.salesHistoryModelBindingSource;
            this.dgdSalesHistory.Location = new System.Drawing.Point(26, 22);
            this.dgdSalesHistory.Name = "dgdSalesHistory";
            this.dgdSalesHistory.ReadOnly = true;
            this.dgdSalesHistory.RowHeadersWidth = 51;
            this.dgdSalesHistory.Size = new System.Drawing.Size(894, 472);
            this.dgdSalesHistory.TabIndex = 5;
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
            // dateOfPurchaseDataGridViewTextBoxColumn
            // 
            this.dateOfPurchaseDataGridViewTextBoxColumn.DataPropertyName = "DateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.HeaderText = "DateOfPurchase";
            this.dateOfPurchaseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfPurchaseDataGridViewTextBoxColumn.Name = "dateOfPurchaseDataGridViewTextBoxColumn";
            this.dateOfPurchaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemsDataGridViewTextBoxColumn
            // 
            this.itemsDataGridViewTextBoxColumn.DataPropertyName = "Items";
            this.itemsDataGridViewTextBoxColumn.HeaderText = "Items";
            this.itemsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemsDataGridViewTextBoxColumn.Name = "itemsDataGridViewTextBoxColumn";
            this.itemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
            this.employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            this.employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCISDataGridViewTextBoxColumn
            // 
            this.tCISDataGridViewTextBoxColumn.DataPropertyName = "TCIS";
            this.tCISDataGridViewTextBoxColumn.HeaderText = "TCIS";
            this.tCISDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tCISDataGridViewTextBoxColumn.Name = "tCISDataGridViewTextBoxColumn";
            this.tCISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRADataGridViewTextBoxColumn
            // 
            this.tRADataGridViewTextBoxColumn.DataPropertyName = "TRA";
            this.tRADataGridViewTextBoxColumn.HeaderText = "TRA";
            this.tRADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tRADataGridViewTextBoxColumn.Name = "tRADataGridViewTextBoxColumn";
            this.tRADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netSalesDataGridViewTextBoxColumn
            // 
            this.netSalesDataGridViewTextBoxColumn.DataPropertyName = "NetSales";
            this.netSalesDataGridViewTextBoxColumn.HeaderText = "NetSales";
            this.netSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netSalesDataGridViewTextBoxColumn.Name = "netSalesDataGridViewTextBoxColumn";
            this.netSalesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossMarginDataGridViewTextBoxColumn
            // 
            this.grossMarginDataGridViewTextBoxColumn.DataPropertyName = "GrossMargin";
            this.grossMarginDataGridViewTextBoxColumn.HeaderText = "GrossMargin";
            this.grossMarginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.grossMarginDataGridViewTextBoxColumn.Name = "grossMarginDataGridViewTextBoxColumn";
            this.grossMarginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesHistoryModelBindingSource
            // 
            this.salesHistoryModelBindingSource.DataSource = typeof(BiliPC.SalesHistoryModel);
            // 
            // SalesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 598);
            this.Name = "SalesHistory";
            this.Text = "SalesHistory";
            this.Load += new System.EventHandler(this.SalesHistory_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdSalesHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblSalesHistory;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgdSalesHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfPurchaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossMarginDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesHistoryModelBindingSource;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label lblTransID;
    }
}