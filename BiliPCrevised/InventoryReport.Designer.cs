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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboViewMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblInventoryReport = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtTCAI = new System.Windows.Forms.TextBox();
            this.lblTRA = new System.Windows.Forms.Label();
            this.txtTRA = new System.Windows.Forms.TextBox();
            this.lblTCAI = new System.Windows.Forms.Label();
            this.dgdInventoryReport = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnlTop.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(793, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 44);
            this.button1.TabIndex = 23;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
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
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdInventoryReport);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 117);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 522);
            this.pnlBackground.TabIndex = 4;
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
            this.txtTCAI.Location = new System.Drawing.Point(379, 74);
            this.txtTCAI.Margin = new System.Windows.Forms.Padding(2);
            this.txtTCAI.Name = "txtTCAI";
            this.txtTCAI.ReadOnly = true;
            this.txtTCAI.Size = new System.Drawing.Size(336, 29);
            this.txtTCAI.TabIndex = 66;
            // 
            // lblTRA
            // 
            this.lblTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTRA.AutoSize = true;
            this.lblTRA.BackColor = System.Drawing.Color.Transparent;
            this.lblTRA.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTRA.ForeColor = System.Drawing.Color.Black;
            this.lblTRA.Location = new System.Drawing.Point(80, 33);
            this.lblTRA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTRA.Name = "lblTRA";
            this.lblTRA.Size = new System.Drawing.Size(295, 22);
            this.lblTRA.TabIndex = 65;
            this.lblTRA.Text = "Total retail amount of all items :";
            // 
            // txtTRA
            // 
            this.txtTRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTRA.Location = new System.Drawing.Point(379, 33);
            this.txtTRA.Margin = new System.Windows.Forms.Padding(2);
            this.txtTRA.Name = "txtTRA";
            this.txtTRA.ReadOnly = true;
            this.txtTRA.Size = new System.Drawing.Size(336, 29);
            this.txtTRA.TabIndex = 64;
            // 
            // lblTCAI
            // 
            this.lblTCAI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTCAI.AutoSize = true;
            this.lblTCAI.BackColor = System.Drawing.Color.Transparent;
            this.lblTCAI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTCAI.ForeColor = System.Drawing.Color.Black;
            this.lblTCAI.Location = new System.Drawing.Point(161, 74);
            this.lblTCAI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTCAI.Name = "lblTCAI";
            this.lblTCAI.Size = new System.Drawing.Size(214, 22);
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
            this.dgdInventoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdInventoryReport.Location = new System.Drawing.Point(26, 22);
            this.dgdInventoryReport.Name = "dgdInventoryReport";
            this.dgdInventoryReport.ReadOnly = true;
            this.dgdInventoryReport.RowHeadersWidth = 51;
            this.dgdInventoryReport.Size = new System.Drawing.Size(894, 365);
            this.dgdInventoryReport.TabIndex = 0;
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
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdInventoryReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblInventoryReport;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboViewMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.DataGridView dgdInventoryReport;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.TextBox txtTCAI;
        private System.Windows.Forms.Label lblTRA;
        private System.Windows.Forms.TextBox txtTRA;
        private System.Windows.Forms.Label lblTCAI;
    }
}