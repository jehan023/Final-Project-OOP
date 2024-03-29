﻿namespace BiliPC
{
    partial class ViewEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.GroupTextBox = new System.Windows.Forms.GroupBox();
            this.txtAcctID = new System.Windows.Forms.TextBox();
            this.lblAcctID = new System.Windows.Forms.Label();
            this.radAdminFalse = new System.Windows.Forms.RadioButton();
            this.radAdminTrue = new System.Windows.Forms.RadioButton();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblAccType = new System.Windows.Forms.Label();
            this.TxtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtAcctUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtAcctWorkhours = new System.Windows.Forms.TextBox();
            this.txtAcctSalary = new System.Windows.Forms.TextBox();
            this.lblWorkhours = new System.Windows.Forms.Label();
            this.txtAcctName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dgdEmployee = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workhoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.GroupTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.btnSearchEmployee);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Controls.Add(this.btnDeleteAccount);
            this.pnlTop.Controls.Add(this.btnUpdateAccount);
            this.pnlTop.Controls.Add(this.TxtSearchEmployee);
            this.pnlTop.Controls.Add(this.btnAddAccount);
            this.pnlTop.Controls.Add(this.lblSearchEmployee);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchEmployee.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearchEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSearchEmployee.Location = new System.Drawing.Point(847, 56);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(75, 25);
            this.btnSearchEmployee.TabIndex = 9;
            this.btnSearchEmployee.Text = "Search";
            this.btnSearchEmployee.UseVisualStyleBackColor = false;
            this.btnSearchEmployee.Click += new System.EventHandler(this.BtnSearchEmployee_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.SpringGreen;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(25, 54);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, -50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employees";
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.IndianRed;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
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
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Location = new System.Drawing.Point(364, 54);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(109, 31);
            this.btnDeleteAccount.TabIndex = 6;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Location = new System.Drawing.Point(251, 54);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(109, 31);
            this.btnUpdateAccount.TabIndex = 5;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.BtnUpdateAccount_Click);
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtSearchEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TxtSearchEmployee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchEmployee.Location = new System.Drawing.Point(658, 57);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(186, 24);
            this.TxtSearchEmployee.TabIndex = 8;
            this.TxtSearchEmployee.TextChanged += new System.EventHandler(this.TxtSearchEmployee_TextChanged);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAccount.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccount.Location = new System.Drawing.Point(138, 54);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(109, 31);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add new";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.ForeColor = System.Drawing.Color.White;
            this.lblSearchEmployee.Location = new System.Drawing.Point(501, 60);
            this.lblSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(153, 18);
            this.lblSearchEmployee.TabIndex = 7;
            this.lblSearchEmployee.Text = "Search Employee:";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBackground.Controls.Add(this.GroupTextBox);
            this.pnlBackground.Controls.Add(this.dgdEmployee);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 100);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 539);
            this.pnlBackground.TabIndex = 10;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BackColor = System.Drawing.Color.Transparent;
            this.GroupTextBox.Controls.Add(this.txtAcctID);
            this.GroupTextBox.Controls.Add(this.lblAcctID);
            this.GroupTextBox.Controls.Add(this.radAdminFalse);
            this.GroupTextBox.Controls.Add(this.radAdminTrue);
            this.GroupTextBox.Controls.Add(this.lblSalary);
            this.GroupTextBox.Controls.Add(this.lblAccType);
            this.GroupTextBox.Controls.Add(this.TxtContactNo);
            this.GroupTextBox.Controls.Add(this.lblContactNo);
            this.GroupTextBox.Controls.Add(this.txtAcctUsername);
            this.GroupTextBox.Controls.Add(this.lblUsername);
            this.GroupTextBox.Controls.Add(this.txtAcctWorkhours);
            this.GroupTextBox.Controls.Add(this.txtAcctSalary);
            this.GroupTextBox.Controls.Add(this.lblWorkhours);
            this.GroupTextBox.Controls.Add(this.txtAcctName);
            this.GroupTextBox.Controls.Add(this.lblName);
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupTextBox.Location = new System.Drawing.Point(0, 359);
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(945, 180);
            this.GroupTextBox.TabIndex = 12;
            this.GroupTextBox.TabStop = false;
            // 
            // txtAcctID
            // 
            this.txtAcctID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctID.Location = new System.Drawing.Point(131, 18);
            this.txtAcctID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctID.Name = "txtAcctID";
            this.txtAcctID.ReadOnly = true;
            this.txtAcctID.Size = new System.Drawing.Size(336, 28);
            this.txtAcctID.TabIndex = 14;
            // 
            // lblAcctID
            // 
            this.lblAcctID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcctID.AutoSize = true;
            this.lblAcctID.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctID.ForeColor = System.Drawing.Color.Black;
            this.lblAcctID.Location = new System.Drawing.Point(40, 21);
            this.lblAcctID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcctID.Name = "lblAcctID";
            this.lblAcctID.Size = new System.Drawing.Size(89, 22);
            this.lblAcctID.TabIndex = 13;
            this.lblAcctID.Text = "Acct ID :";
            // 
            // radAdminFalse
            // 
            this.radAdminFalse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdminFalse.AutoSize = true;
            this.radAdminFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdminFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdminFalse.Location = new System.Drawing.Point(594, 123);
            this.radAdminFalse.Margin = new System.Windows.Forms.Padding(2);
            this.radAdminFalse.Name = "radAdminFalse";
            this.radAdminFalse.Size = new System.Drawing.Size(114, 28);
            this.radAdminFalse.TabIndex = 27;
            this.radAdminFalse.TabStop = true;
            this.radAdminFalse.Text = "Employee";
            this.radAdminFalse.UseVisualStyleBackColor = true;
            // 
            // radAdminTrue
            // 
            this.radAdminTrue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radAdminTrue.AutoSize = true;
            this.radAdminTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radAdminTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAdminTrue.Location = new System.Drawing.Point(594, 91);
            this.radAdminTrue.Margin = new System.Windows.Forms.Padding(2);
            this.radAdminTrue.Name = "radAdminTrue";
            this.radAdminTrue.Size = new System.Drawing.Size(83, 28);
            this.radAdminTrue.TabIndex = 26;
            this.radAdminTrue.TabStop = true;
            this.radAdminTrue.Text = "Admin";
            this.radAdminTrue.UseVisualStyleBackColor = true;
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.Transparent;
            this.lblSalary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.ForeColor = System.Drawing.Color.Black;
            this.lblSalary.Location = new System.Drawing.Point(50, 131);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(79, 22);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary :";
            // 
            // lblAccType
            // 
            this.lblAccType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccType.AutoSize = true;
            this.lblAccType.BackColor = System.Drawing.Color.Transparent;
            this.lblAccType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccType.ForeColor = System.Drawing.Color.Black;
            this.lblAccType.Location = new System.Drawing.Point(488, 94);
            this.lblAccType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccType.Name = "lblAccType";
            this.lblAccType.Size = new System.Drawing.Size(102, 22);
            this.lblAccType.TabIndex = 25;
            this.lblAccType.Text = "Acc type :";
            // 
            // TxtContactNo
            // 
            this.TxtContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContactNo.Location = new System.Drawing.Point(131, 91);
            this.TxtContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtContactNo.Name = "TxtContactNo";
            this.TxtContactNo.Size = new System.Drawing.Size(336, 28);
            this.TxtContactNo.TabIndex = 24;
            this.TxtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContactNo_KeyPress_1);
            // 
            // lblContactNo
            // 
            this.lblContactNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(6, 94);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(123, 22);
            this.lblContactNo.TabIndex = 23;
            this.lblContactNo.Text = "Contact No :";
            // 
            // txtAcctUsername
            // 
            this.txtAcctUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctUsername.Location = new System.Drawing.Point(594, 54);
            this.txtAcctUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctUsername.Name = "txtAcctUsername";
            this.txtAcctUsername.Size = new System.Drawing.Size(336, 28);
            this.txtAcctUsername.TabIndex = 22;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(477, 57);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 22);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username :";
            // 
            // txtAcctWorkhours
            // 
            this.txtAcctWorkhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctWorkhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctWorkhours.Location = new System.Drawing.Point(594, 18);
            this.txtAcctWorkhours.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctWorkhours.Name = "txtAcctWorkhours";
            this.txtAcctWorkhours.ReadOnly = true;
            this.txtAcctWorkhours.Size = new System.Drawing.Size(336, 28);
            this.txtAcctWorkhours.TabIndex = 20;
            // 
            // txtAcctSalary
            // 
            this.txtAcctSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctSalary.Location = new System.Drawing.Point(131, 128);
            this.txtAcctSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctSalary.Name = "txtAcctSalary";
            this.txtAcctSalary.Size = new System.Drawing.Size(336, 28);
            this.txtAcctSalary.TabIndex = 18;
            this.txtAcctSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAcctWage_KeyPress);
            // 
            // lblWorkhours
            // 
            this.lblWorkhours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWorkhours.AutoSize = true;
            this.lblWorkhours.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkhours.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkhours.ForeColor = System.Drawing.Color.Black;
            this.lblWorkhours.Location = new System.Drawing.Point(480, 21);
            this.lblWorkhours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWorkhours.Name = "lblWorkhours";
            this.lblWorkhours.Size = new System.Drawing.Size(112, 22);
            this.lblWorkhours.TabIndex = 19;
            this.lblWorkhours.Text = "Workhr(s) :";
            // 
            // txtAcctName
            // 
            this.txtAcctName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAcctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctName.Location = new System.Drawing.Point(131, 54);
            this.txtAcctName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(336, 28);
            this.txtAcctName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(55, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 22);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name :";
            // 
            // dgdEmployee
            // 
            this.dgdEmployee.AllowUserToAddRows = false;
            this.dgdEmployee.AllowUserToDeleteRows = false;
            this.dgdEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdEmployee.AutoGenerateColumns = false;
            this.dgdEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgdEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.workhoursDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dgdEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgdEmployee.DataSource = this.usersModelBindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdEmployee.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgdEmployee.Location = new System.Drawing.Point(25, 16);
            this.dgdEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dgdEmployee.MultiSelect = false;
            this.dgdEmployee.Name = "dgdEmployee";
            this.dgdEmployee.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgdEmployee.RowHeadersWidth = 51;
            this.dgdEmployee.RowTemplate.Height = 24;
            this.dgdEmployee.Size = new System.Drawing.Size(897, 337);
            this.dgdEmployee.TabIndex = 11;
            this.dgdEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgdEmployee_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workhoursDataGridViewTextBoxColumn
            // 
            this.workhoursDataGridViewTextBoxColumn.DataPropertyName = "Workhours";
            this.workhoursDataGridViewTextBoxColumn.HeaderText = "Workhours";
            this.workhoursDataGridViewTextBoxColumn.Name = "workhoursDataGridViewTextBoxColumn";
            this.workhoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            this.isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // usersModelBindingSource1
            // 
            this.usersModelBindingSource1.DataSource = typeof(BiliPC.UsersModel);
            // 
            // usersModelBindingSource
            // 
            this.usersModelBindingSource.DataSource = typeof(BiliPC.UsersModel);
            // 
            // ViewEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "ViewEmployees";
            this.Text = "ViewEmployees";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.GroupTextBox.ResumeLayout(false);
            this.GroupTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.TextBox TxtSearchEmployee;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.GroupBox GroupTextBox;
        private System.Windows.Forms.TextBox txtAcctID;
        private System.Windows.Forms.Label lblAcctID;
        private System.Windows.Forms.RadioButton radAdminFalse;
        private System.Windows.Forms.RadioButton radAdminTrue;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblAccType;
        private System.Windows.Forms.TextBox TxtContactNo;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtAcctUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtAcctWorkhours;
        private System.Windows.Forms.TextBox txtAcctSalary;
        private System.Windows.Forms.Label lblWorkhours;
        private System.Windows.Forms.TextBox txtAcctName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgdEmployee;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.BindingSource usersModelBindingSource;
        private System.Windows.Forms.BindingSource usersModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workhoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}