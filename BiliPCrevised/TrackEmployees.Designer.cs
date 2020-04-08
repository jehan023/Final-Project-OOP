namespace BiliPC
{
    partial class TrackEmployees
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAcctId = new System.Windows.Forms.ComboBox();
            this.lblAcctId = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblTrackEmployees = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgdTrackEmployees = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acctNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggedInDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWorkHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackEmployeesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdTrackEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEmployeesModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.cboAcctId);
            this.panel1.Controls.Add(this.lblAcctId);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.lblTrackEmployees);
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 144);
            this.panel1.TabIndex = 2;
            // 
            // cboAcctId
            // 
            this.cboAcctId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboAcctId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAcctId.FormattingEnabled = true;
            this.cboAcctId.Location = new System.Drawing.Point(203, 89);
            this.cboAcctId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAcctId.Name = "cboAcctId";
            this.cboAcctId.Size = new System.Drawing.Size(497, 32);
            this.cboAcctId.TabIndex = 24;
            this.cboAcctId.SelectedIndexChanged += new System.EventHandler(this.CboAcctId_SelectedIndexChanged);
            // 
            // lblAcctId
            // 
            this.lblAcctId.AutoSize = true;
            this.lblAcctId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctId.ForeColor = System.Drawing.Color.White;
            this.lblAcctId.Location = new System.Drawing.Point(40, 91);
            this.lblAcctId.Name = "lblAcctId";
            this.lblAcctId.Size = new System.Drawing.Size(147, 28);
            this.lblAcctId.TabIndex = 23;
            this.lblAcctId.Text = "Account ID:";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowAll.BackColor = System.Drawing.Color.SpringGreen;
            this.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.ForeColor = System.Drawing.Color.Black;
            this.btnShowAll.Location = new System.Drawing.Point(1044, 63);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(136, 54);
            this.btnShowAll.TabIndex = 21;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // lblTrackEmployees
            // 
            this.lblTrackEmployees.AutoSize = true;
            this.lblTrackEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackEmployees.ForeColor = System.Drawing.Color.White;
            this.lblTrackEmployees.Location = new System.Drawing.Point(35, 26);
            this.lblTrackEmployees.Name = "lblTrackEmployees";
            this.lblTrackEmployees.Size = new System.Drawing.Size(358, 46);
            this.lblTrackEmployees.TabIndex = 16;
            this.lblTrackEmployees.Text = "Track Employees";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Firebrick;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Black;
            this.btnX.Location = new System.Drawing.Point(1215, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.dgdTrackEmployees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1247, 642);
            this.panel2.TabIndex = 3;
            // 
            // dgdTrackEmployees
            // 
            this.dgdTrackEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdTrackEmployees.AutoGenerateColumns = false;
            this.dgdTrackEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdTrackEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdTrackEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdTrackEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.acctIdDataGridViewTextBoxColumn,
            this.acctNameDataGridViewTextBoxColumn,
            this.loggedInDataGridViewCheckBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.totalWorkHoursDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dgdTrackEmployees.DataSource = this.trackEmployeesModelBindingSource;
            this.dgdTrackEmployees.Location = new System.Drawing.Point(31, 27);
            this.dgdTrackEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdTrackEmployees.Name = "dgdTrackEmployees";
            this.dgdTrackEmployees.RowHeadersWidth = 51;
            this.dgdTrackEmployees.Size = new System.Drawing.Size(1185, 585);
            this.dgdTrackEmployees.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // acctIdDataGridViewTextBoxColumn
            // 
            this.acctIdDataGridViewTextBoxColumn.DataPropertyName = "AcctId";
            this.acctIdDataGridViewTextBoxColumn.HeaderText = "AcctId";
            this.acctIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acctIdDataGridViewTextBoxColumn.Name = "acctIdDataGridViewTextBoxColumn";
            // 
            // acctNameDataGridViewTextBoxColumn
            // 
            this.acctNameDataGridViewTextBoxColumn.DataPropertyName = "AcctName";
            this.acctNameDataGridViewTextBoxColumn.HeaderText = "AcctName";
            this.acctNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acctNameDataGridViewTextBoxColumn.Name = "acctNameDataGridViewTextBoxColumn";
            // 
            // loggedInDataGridViewCheckBoxColumn
            // 
            this.loggedInDataGridViewCheckBoxColumn.DataPropertyName = "LoggedIn";
            this.loggedInDataGridViewCheckBoxColumn.HeaderText = "LoggedIn";
            this.loggedInDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.loggedInDataGridViewCheckBoxColumn.Name = "loggedInDataGridViewCheckBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // totalWorkHoursDataGridViewTextBoxColumn
            // 
            this.totalWorkHoursDataGridViewTextBoxColumn.DataPropertyName = "TotalWorkHours";
            this.totalWorkHoursDataGridViewTextBoxColumn.HeaderText = "TotalWorkHours";
            this.totalWorkHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalWorkHoursDataGridViewTextBoxColumn.Name = "totalWorkHoursDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // trackEmployeesModelBindingSource
            // 
            this.trackEmployeesModelBindingSource.DataSource = typeof(BiliPC.TrackEmployeesModel);
            // 
            // TrackEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1247, 786);
            this.Name = "TrackEmployees";
            this.Text = "TrackEmployees";
            this.Load += new System.EventHandler(this.TrackEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdTrackEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEmployeesModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTrackEmployees;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgdTrackEmployees;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox cboAcctId;
        private System.Windows.Forms.Label lblAcctId;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acctNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn loggedInDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWorkHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trackEmployeesModelBindingSource;
    }
}