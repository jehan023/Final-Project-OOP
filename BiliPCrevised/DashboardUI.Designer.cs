﻿namespace BiliPC
{
    partial class DashboardUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUI));
            this.tmrRealtimeTime = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelManageEmployees = new System.Windows.Forms.Panel();
            this.btnTrackEmployees = new System.Windows.Forms.Button();
            this.btnViewEmployees = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.btnInventoryReport = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.btnSearchProducts = new System.Windows.Forms.Button();
            this.panelSales = new System.Windows.Forms.Panel();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnTransactionHistory = new System.Windows.Forms.Button();
            this.btnCreateTransaction = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBiliPCLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContainerForm = new System.Windows.Forms.Panel();
            this.picBiliPCLogoDefault = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            this.panelManageEmployees.SuspendLayout();
            this.panelInventory.SuspendLayout();
            this.panelSales.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogo)).BeginInit();
            this.pnlContainerForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogoDefault)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrRealtimeTime
            // 
            this.tmrRealtimeTime.Tick += new System.EventHandler(this.TmrRealtimeTime_Tick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(168, 663);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(945, 24);
            this.pnlBottom.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(12, 619);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 14);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(39, 592);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInventory
            // 
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 229);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(168, 30);
            this.btnInventory.TabIndex = 11;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click_1);
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.Black;
            this.pnlSideMenu.Controls.Add(this.btnLogout);
            this.pnlSideMenu.Controls.Add(this.panelManageEmployees);
            this.pnlSideMenu.Controls.Add(this.btnManageEmployees);
            this.pnlSideMenu.Controls.Add(this.lblDate);
            this.pnlSideMenu.Controls.Add(this.lblTime);
            this.pnlSideMenu.Controls.Add(this.panelInventory);
            this.pnlSideMenu.Controls.Add(this.btnInventory);
            this.pnlSideMenu.Controls.Add(this.panelSales);
            this.pnlSideMenu.Controls.Add(this.btnSales);
            this.pnlSideMenu.Controls.Add(this.panelLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(168, 687);
            this.pnlSideMenu.TabIndex = 13;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 441);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(168, 30);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click_1);
            // 
            // panelManageEmployees
            // 
            this.panelManageEmployees.BackColor = System.Drawing.Color.DimGray;
            this.panelManageEmployees.Controls.Add(this.btnTrackEmployees);
            this.panelManageEmployees.Controls.Add(this.btnViewEmployees);
            this.panelManageEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelManageEmployees.Location = new System.Drawing.Point(0, 380);
            this.panelManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.panelManageEmployees.Name = "panelManageEmployees";
            this.panelManageEmployees.Size = new System.Drawing.Size(168, 61);
            this.panelManageEmployees.TabIndex = 21;
            // 
            // btnTrackEmployees
            // 
            this.btnTrackEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrackEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrackEmployees.FlatAppearance.BorderSize = 0;
            this.btnTrackEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTrackEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTrackEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrackEmployees.ForeColor = System.Drawing.Color.White;
            this.btnTrackEmployees.Location = new System.Drawing.Point(0, 30);
            this.btnTrackEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrackEmployees.Name = "btnTrackEmployees";
            this.btnTrackEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTrackEmployees.Size = new System.Drawing.Size(168, 30);
            this.btnTrackEmployees.TabIndex = 3;
            this.btnTrackEmployees.Text = "Track Employees";
            this.btnTrackEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrackEmployees.UseVisualStyleBackColor = true;
            this.btnTrackEmployees.Click += new System.EventHandler(this.BtnTrackEmployees_Click);
            // 
            // btnViewEmployees
            // 
            this.btnViewEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewEmployees.FlatAppearance.BorderSize = 0;
            this.btnViewEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnViewEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.btnViewEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewEmployees.Name = "btnViewEmployees";
            this.btnViewEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnViewEmployees.Size = new System.Drawing.Size(168, 30);
            this.btnViewEmployees.TabIndex = 2;
            this.btnViewEmployees.Text = "View Employees";
            this.btnViewEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmployees.UseVisualStyleBackColor = true;
            this.btnViewEmployees.Click += new System.EventHandler(this.BtnViewEmployees_Click);
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageEmployees.FlatAppearance.BorderSize = 0;
            this.btnManageEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnManageEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployees.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployees.Location = new System.Drawing.Point(0, 350);
            this.btnManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnManageEmployees.Size = new System.Drawing.Size(168, 30);
            this.btnManageEmployees.TabIndex = 20;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageEmployees.UseVisualStyleBackColor = true;
            this.btnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click);
            // 
            // panelInventory
            // 
            this.panelInventory.BackColor = System.Drawing.Color.DimGray;
            this.panelInventory.Controls.Add(this.btnInventoryReport);
            this.panelInventory.Controls.Add(this.btnEditProducts);
            this.panelInventory.Controls.Add(this.btnSearchProducts);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInventory.Location = new System.Drawing.Point(0, 259);
            this.panelInventory.Margin = new System.Windows.Forms.Padding(2);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(168, 91);
            this.panelInventory.TabIndex = 12;
            // 
            // btnInventoryReport
            // 
            this.btnInventoryReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventoryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventoryReport.FlatAppearance.BorderSize = 0;
            this.btnInventoryReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnInventoryReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventoryReport.ForeColor = System.Drawing.Color.White;
            this.btnInventoryReport.Location = new System.Drawing.Point(0, 60);
            this.btnInventoryReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryReport.Name = "btnInventoryReport";
            this.btnInventoryReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnInventoryReport.Size = new System.Drawing.Size(168, 30);
            this.btnInventoryReport.TabIndex = 4;
            this.btnInventoryReport.Text = "Report";
            this.btnInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventoryReport.UseVisualStyleBackColor = true;
            this.btnInventoryReport.Click += new System.EventHandler(this.BtnInventoryReport_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditProducts.FlatAppearance.BorderSize = 0;
            this.btnEditProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEditProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.ForeColor = System.Drawing.Color.White;
            this.btnEditProducts.Location = new System.Drawing.Point(0, 30);
            this.btnEditProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEditProducts.Size = new System.Drawing.Size(168, 30);
            this.btnEditProducts.TabIndex = 3;
            this.btnEditProducts.Text = "Edit Products";
            this.btnEditProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.BtnEditProducts_Click_1);
            // 
            // btnSearchProducts
            // 
            this.btnSearchProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchProducts.FlatAppearance.BorderSize = 0;
            this.btnSearchProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSearchProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProducts.ForeColor = System.Drawing.Color.White;
            this.btnSearchProducts.Location = new System.Drawing.Point(0, 0);
            this.btnSearchProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProducts.Name = "btnSearchProducts";
            this.btnSearchProducts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSearchProducts.Size = new System.Drawing.Size(168, 30);
            this.btnSearchProducts.TabIndex = 2;
            this.btnSearchProducts.Text = "Search Products";
            this.btnSearchProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProducts.UseVisualStyleBackColor = true;
            this.btnSearchProducts.Click += new System.EventHandler(this.BtnSearchProducts_Click_1);
            // 
            // panelSales
            // 
            this.panelSales.BackColor = System.Drawing.Color.DimGray;
            this.panelSales.Controls.Add(this.btnSalesReport);
            this.panelSales.Controls.Add(this.btnTransactionHistory);
            this.panelSales.Controls.Add(this.btnCreateTransaction);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSales.Location = new System.Drawing.Point(0, 136);
            this.panelSales.Margin = new System.Windows.Forms.Padding(2);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(168, 93);
            this.panelSales.TabIndex = 10;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesReport.FlatAppearance.BorderSize = 0;
            this.btnSalesReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSalesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReport.ForeColor = System.Drawing.Color.White;
            this.btnSalesReport.Location = new System.Drawing.Point(0, 60);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSalesReport.Size = new System.Drawing.Size(168, 32);
            this.btnSalesReport.TabIndex = 4;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.BtnSalesReport_Click);
            // 
            // btnTransactionHistory
            // 
            this.btnTransactionHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.btnTransactionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnTransactionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.btnTransactionHistory.Location = new System.Drawing.Point(0, 30);
            this.btnTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransactionHistory.Name = "btnTransactionHistory";
            this.btnTransactionHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnTransactionHistory.Size = new System.Drawing.Size(168, 30);
            this.btnTransactionHistory.TabIndex = 3;
            this.btnTransactionHistory.Text = "Sales History";
            this.btnTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionHistory.UseVisualStyleBackColor = true;
            this.btnTransactionHistory.Click += new System.EventHandler(this.BtnTransactionHistory_Click);
            // 
            // btnCreateTransaction
            // 
            this.btnCreateTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateTransaction.FlatAppearance.BorderSize = 0;
            this.btnCreateTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnCreateTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCreateTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTransaction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTransaction.ForeColor = System.Drawing.Color.White;
            this.btnCreateTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnCreateTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateTransaction.Name = "btnCreateTransaction";
            this.btnCreateTransaction.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateTransaction.Size = new System.Drawing.Size(168, 30);
            this.btnCreateTransaction.TabIndex = 2;
            this.btnCreateTransaction.Text = "Create Transaction";
            this.btnCreateTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTransaction.UseVisualStyleBackColor = true;
            this.btnCreateTransaction.Click += new System.EventHandler(this.BtnCreateTransaction_Click_1);
            // 
            // btnSales
            // 
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(0, 106);
            this.btnSales.Margin = new System.Windows.Forms.Padding(2);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(168, 30);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.BtnSales_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picBiliPCLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(168, 106);
            this.panelLogo.TabIndex = 1;
            // 
            // picBiliPCLogo
            // 
            this.picBiliPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBiliPCLogo.Image")));
            this.picBiliPCLogo.Location = new System.Drawing.Point(4, 18);
            this.picBiliPCLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picBiliPCLogo.Name = "picBiliPCLogo";
            this.picBiliPCLogo.Size = new System.Drawing.Size(162, 76);
            this.picBiliPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBiliPCLogo.TabIndex = 0;
            this.picBiliPCLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(168, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(945, 24);
            this.pnlTop.TabIndex = 16;
            // 
            // pnlContainerForm
            // 
            this.pnlContainerForm.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlContainerForm.Controls.Add(this.picBiliPCLogoDefault);
            this.pnlContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerForm.Location = new System.Drawing.Point(168, 24);
            this.pnlContainerForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainerForm.MinimumSize = new System.Drawing.Size(945, 639);
            this.pnlContainerForm.Name = "pnlContainerForm";
            this.pnlContainerForm.Size = new System.Drawing.Size(945, 639);
            this.pnlContainerForm.TabIndex = 17;
            // 
            // picBiliPCLogoDefault
            // 
            this.picBiliPCLogoDefault.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picBiliPCLogoDefault.Image = ((System.Drawing.Image)(resources.GetObject("picBiliPCLogoDefault.Image")));
            this.picBiliPCLogoDefault.Location = new System.Drawing.Point(332, 161);
            this.picBiliPCLogoDefault.Margin = new System.Windows.Forms.Padding(2);
            this.picBiliPCLogoDefault.Name = "picBiliPCLogoDefault";
            this.picBiliPCLogoDefault.Size = new System.Drawing.Size(284, 262);
            this.picBiliPCLogoDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBiliPCLogoDefault.TabIndex = 0;
            this.picBiliPCLogoDefault.TabStop = false;
            // 
            // DashboardUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1113, 687);
            this.Controls.Add(this.pnlContainerForm);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1129, 726);
            this.Name = "DashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiliPC Store";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.panelManageEmployees.ResumeLayout(false);
            this.panelInventory.ResumeLayout(false);
            this.panelSales.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogo)).EndInit();
            this.pnlContainerForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogoDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrRealtimeTime;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel panelManageEmployees;
        private System.Windows.Forms.Button btnTrackEmployees;
        private System.Windows.Forms.Button btnViewEmployees;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Button btnInventoryReport;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button btnSearchProducts;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnTransactionHistory;
        private System.Windows.Forms.Button btnCreateTransaction;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picBiliPCLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlContainerForm;
        private System.Windows.Forms.PictureBox picBiliPCLogoDefault;
    }
}