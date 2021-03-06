﻿namespace BiliPC
{
    partial class TransactionForm
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
            this.btnX = new System.Windows.Forms.Button();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnTransact = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.CboItem = new System.Windows.Forms.ComboBox();
            this.txtTransactionID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtAmountReceived = new System.Windows.Forms.TextBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.lblTransactionID = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalAmountDue = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblTotalUnitPrice = new System.Windows.Forms.Label();
            this.txtTotalUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.dgdCart = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionTempModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTempModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlTop.Controls.Add(this.btnX);
            this.pnlTop.Controls.Add(this.lblTransaction);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 56);
            this.pnlTop.TabIndex = 0;
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
            this.btnX.Location = new System.Drawing.Point(920, 0);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 27);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.Color.White;
            this.lblTransaction.Location = new System.Drawing.Point(8, 9);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(202, 37);
            this.lblTransaction.TabIndex = 0;
            this.lblTransaction.Text = "Transaction";
            // 
            // pnlBackground
            // 
            this.pnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBackground.Controls.Add(this.btnTransact);
            this.pnlBackground.Controls.Add(this.lblCategory);
            this.pnlBackground.Controls.Add(this.cboCategory);
            this.pnlBackground.Controls.Add(this.CboItem);
            this.pnlBackground.Controls.Add(this.txtTransactionID);
            this.pnlBackground.Controls.Add(this.groupBox2);
            this.pnlBackground.Controls.Add(this.btnAddDiscount);
            this.pnlBackground.Controls.Add(this.lblTransactionID);
            this.pnlBackground.Controls.Add(this.btnPrintReceipt);
            this.pnlBackground.Controls.Add(this.txtUnitPrice);
            this.pnlBackground.Controls.Add(this.lblUnitPrice);
            this.pnlBackground.Controls.Add(this.groupBox1);
            this.pnlBackground.Controls.Add(this.btnAddItem);
            this.pnlBackground.Controls.Add(this.btnRemoveItem);
            this.pnlBackground.Controls.Add(this.lblTotalUnitPrice);
            this.pnlBackground.Controls.Add(this.txtTotalUnitPrice);
            this.pnlBackground.Controls.Add(this.txtQuantity);
            this.pnlBackground.Controls.Add(this.lblQuantity);
            this.pnlBackground.Controls.Add(this.lblItem);
            this.pnlBackground.Controls.Add(this.dgdCart);
            this.pnlBackground.Location = new System.Drawing.Point(0, 56);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(945, 583);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnTransact
            // 
            this.btnTransact.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransact.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTransact.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTransact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransact.Location = new System.Drawing.Point(625, 524);
            this.btnTransact.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(132, 45);
            this.btnTransact.TabIndex = 7;
            this.btnTransact.Text = "TRANSACT";
            this.btnTransact.UseVisualStyleBackColor = false;
            this.btnTransact.Click += new System.EventHandler(this.BtnTransact_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(504, 31);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(95, 24);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category :";
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(603, 31);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(192, 28);
            this.cboCategory.TabIndex = 1;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.CboCategory_SelectedIndexChanged);
            // 
            // CboItem
            // 
            this.CboItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CboItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CboItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CboItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboItem.FormattingEnabled = true;
            this.CboItem.Location = new System.Drawing.Point(82, 31);
            this.CboItem.Margin = new System.Windows.Forms.Padding(2);
            this.CboItem.Name = "CboItem";
            this.CboItem.Size = new System.Drawing.Size(372, 28);
            this.CboItem.TabIndex = 2;
            this.CboItem.SelectedIndexChanged += new System.EventHandler(this.CboItem_SelectedIndexChanged);
            this.CboItem.TextChanged += new System.EventHandler(this.CboItem_TextChanged);
            this.CboItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CboItem_KeyPress);
            // 
            // txtTransactionID
            // 
            this.txtTransactionID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTransactionID.BackColor = System.Drawing.Color.DarkGray;
            this.txtTransactionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionID.Location = new System.Drawing.Point(162, 6);
            this.txtTransactionID.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransactionID.Name = "txtTransactionID";
            this.txtTransactionID.ReadOnly = true;
            this.txtTransactionID.Size = new System.Drawing.Size(633, 19);
            this.txtTransactionID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.txtChange);
            this.groupBox2.Controls.Add(this.lblChange);
            this.groupBox2.Controls.Add(this.txtAmountReceived);
            this.groupBox2.Controls.Add(this.lblCash);
            this.groupBox2.Location = new System.Drawing.Point(19, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtChange
            // 
            this.txtChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtChange.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtChange.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(27, 111);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = true;
            this.txtChange.Size = new System.Drawing.Size(312, 39);
            this.txtChange.TabIndex = 0;
            // 
            // lblChange
            // 
            this.lblChange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblChange.AutoSize = true;
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.Black;
            this.lblChange.Location = new System.Drawing.Point(23, 85);
            this.lblChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(77, 24);
            this.lblChange.TabIndex = 0;
            this.lblChange.Text = "Change";
            // 
            // txtAmountReceived
            // 
            this.txtAmountReceived.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtAmountReceived.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAmountReceived.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountReceived.HideSelection = false;
            this.txtAmountReceived.Location = new System.Drawing.Point(27, 36);
            this.txtAmountReceived.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountReceived.Name = "txtAmountReceived";
            this.txtAmountReceived.Size = new System.Drawing.Size(312, 39);
            this.txtAmountReceived.TabIndex = 5;
            this.txtAmountReceived.TextChanged += new System.EventHandler(this.TxtAmountReceived_TextChanged);
            this.txtAmountReceived.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmountReceived_KeyPress);
            // 
            // lblCash
            // 
            this.lblCash.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.Color.Transparent;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.Black;
            this.lblCash.Location = new System.Drawing.Point(23, 10);
            this.lblCash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(53, 24);
            this.lblCash.TabIndex = 0;
            this.lblCash.Text = "Cash";
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddDiscount.BackColor = System.Drawing.Color.Tan;
            this.btnAddDiscount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.Location = new System.Drawing.Point(475, 524);
            this.btnAddDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(132, 45);
            this.btnAddDiscount.TabIndex = 6;
            this.btnAddDiscount.Text = "ADD DISCOUNT";
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.BtnAddDiscount_Click);
            // 
            // lblTransactionID
            // 
            this.lblTransactionID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTransactionID.AutoSize = true;
            this.lblTransactionID.BackColor = System.Drawing.Color.Transparent;
            this.lblTransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionID.ForeColor = System.Drawing.Color.Black;
            this.lblTransactionID.Location = new System.Drawing.Point(15, 5);
            this.lblTransactionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTransactionID.Name = "lblTransactionID";
            this.lblTransactionID.Size = new System.Drawing.Size(140, 24);
            this.lblTransactionID.TabIndex = 0;
            this.lblTransactionID.Text = "Transaction ID: ";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrintReceipt.BackColor = System.Drawing.Color.LightCoral;
            this.btnPrintReceipt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrintReceipt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReceipt.Location = new System.Drawing.Point(774, 524);
            this.btnPrintReceipt.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(132, 45);
            this.btnPrintReceipt.TabIndex = 8;
            this.btnPrintReceipt.Text = "TRANSACT w/ RECEIPT";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.BtnPrintReceipt_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(283, 70);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(171, 26);
            this.txtUnitPrice.TabIndex = 0;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(168, 70);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(100, 24);
            this.lblUnitPrice.TabIndex = 0;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.txtTotalPrice);
            this.groupBox1.Controls.Add(this.lblTotalAmountDue);
            this.groupBox1.Location = new System.Drawing.Point(421, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(19, 39);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(466, 45);
            this.txtTotalPrice.TabIndex = 0;
            // 
            // lblTotalAmountDue
            // 
            this.lblTotalAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalAmountDue.AutoSize = true;
            this.lblTotalAmountDue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDue.ForeColor = System.Drawing.Color.Black;
            this.lblTotalAmountDue.Location = new System.Drawing.Point(15, 13);
            this.lblTotalAmountDue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalAmountDue.Name = "lblTotalAmountDue";
            this.lblTotalAmountDue.Size = new System.Drawing.Size(184, 25);
            this.lblTotalAmountDue.TabIndex = 0;
            this.lblTotalAmountDue.Text = "Total Amount Due";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddItem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(814, 54);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(109, 41);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "ADD";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveItem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(814, 6);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(109, 41);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "REMOVE";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // lblTotalUnitPrice
            // 
            this.lblTotalUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotalUnitPrice.AutoSize = true;
            this.lblTotalUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalUnitPrice.Location = new System.Drawing.Point(458, 69);
            this.lblTotalUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalUnitPrice.Name = "lblTotalUnitPrice";
            this.lblTotalUnitPrice.Size = new System.Drawing.Size(141, 24);
            this.lblTotalUnitPrice.TabIndex = 0;
            this.lblTotalUnitPrice.Text = "Total Unit Price:";
            // 
            // txtTotalUnitPrice
            // 
            this.txtTotalUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTotalUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalUnitPrice.Location = new System.Drawing.Point(603, 67);
            this.txtTotalUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalUnitPrice.Name = "txtTotalUnitPrice";
            this.txtTotalUnitPrice.ReadOnly = true;
            this.txtTotalUnitPrice.Size = new System.Drawing.Size(192, 26);
            this.txtTotalUnitPrice.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(82, 69);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(64, 26);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.TxtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(27, 69);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(48, 24);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Qty :";
            // 
            // lblItem
            // 
            this.lblItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblItem.AutoSize = true;
            this.lblItem.BackColor = System.Drawing.Color.Transparent;
            this.lblItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.Black;
            this.lblItem.Location = new System.Drawing.Point(20, 32);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(55, 24);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item :";
            // 
            // dgdCart
            // 
            this.dgdCart.AllowUserToAddRows = false;
            this.dgdCart.AllowUserToDeleteRows = false;
            this.dgdCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgdCart.AutoGenerateColumns = false;
            this.dgdCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgdCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Item,
            this.Quantity,
            this.UnitPrice,
            this.TotalUnitPrice,
            this.Discount});
            this.dgdCart.DataSource = this.transactionTempModelBindingSource;
            this.dgdCart.Location = new System.Drawing.Point(19, 107);
            this.dgdCart.MultiSelect = false;
            this.dgdCart.Name = "dgdCart";
            this.dgdCart.ReadOnly = true;
            this.dgdCart.RowHeadersWidth = 51;
            this.dgdCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgdCart.Size = new System.Drawing.Size(904, 301);
            this.dgdCart.TabIndex = 9;
            this.dgdCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgdCart_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 80.88277F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.DataPropertyName = "Item";
            this.Item.FillWeight = 224.5989F;
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 72.16849F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.FillWeight = 80.88277F;
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // TotalUnitPrice
            // 
            this.TotalUnitPrice.DataPropertyName = "TotalUnitPrice";
            this.TotalUnitPrice.FillWeight = 80.88277F;
            this.TotalUnitPrice.HeaderText = "TotalUnitPrice";
            this.TotalUnitPrice.MinimumWidth = 6;
            this.TotalUnitPrice.Name = "TotalUnitPrice";
            this.TotalUnitPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.FillWeight = 60.58426F;
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // transactionTempModelBindingSource
            // 
            this.transactionTempModelBindingSource.DataSource = typeof(BiliPC.TransactionTempModel);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(945, 639);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(945, 639);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTempModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblTotalUnitPrice;
        private System.Windows.Forms.TextBox txtTotalUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalAmountDue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtAmountReceived;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtTransactionID;
        private System.Windows.Forms.Label lblTransactionID;
        private System.Windows.Forms.ComboBox CboItem;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.DataGridView dgdCart;
        private System.Windows.Forms.BindingSource transactionTempModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
    }
}