namespace BiliPC
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
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.panelManageEmployees = new System.Windows.Forms.Panel();
            this.BtnTrackEmployees = new System.Windows.Forms.Button();
            this.BtnViewEmployees = new System.Windows.Forms.Button();
            this.BtnManageEmployees = new System.Windows.Forms.Button();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.BtnInventoryReport = new System.Windows.Forms.Button();
            this.BtnEditProducts = new System.Windows.Forms.Button();
            this.BtnSearchProducts = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.panelSales = new System.Windows.Forms.Panel();
            this.BtnSalesReport = new System.Windows.Forms.Button();
            this.BtnTransactionHistory = new System.Windows.Forms.Button();
            this.BtnSales = new System.Windows.Forms.Button();
            this.BtnPOS = new System.Windows.Forms.Button();
            this.txtAcctName = new System.Windows.Forms.Label();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBiliPCLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlContainerForm = new System.Windows.Forms.Panel();
            this.picBiliPCLogoDefault = new System.Windows.Forms.PictureBox();
            this.lblCopyrights = new System.Windows.Forms.Label();
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
            this.pnlBottom.Location = new System.Drawing.Point(206, 663);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(944, 24);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(9, 637);
            this.lblDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 14);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoSize = true;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(9, 608);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 24);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.Black;
            this.pnlSideMenu.Controls.Add(this.BtnLogout);
            this.pnlSideMenu.Controls.Add(this.panelManageEmployees);
            this.pnlSideMenu.Controls.Add(this.BtnManageEmployees);
            this.pnlSideMenu.Controls.Add(this.panelInventory);
            this.pnlSideMenu.Controls.Add(this.BtnInventory);
            this.pnlSideMenu.Controls.Add(this.panelSales);
            this.pnlSideMenu.Controls.Add(this.BtnSales);
            this.pnlSideMenu.Controls.Add(this.BtnPOS);
            this.pnlSideMenu.Controls.Add(this.txtAcctName);
            this.pnlSideMenu.Controls.Add(this.lblLoggedInAs);
            this.pnlSideMenu.Controls.Add(this.lblDate);
            this.pnlSideMenu.Controls.Add(this.lblTime);
            this.pnlSideMenu.Controls.Add(this.panelLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(206, 687);
            this.pnlSideMenu.TabIndex = 14;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(0, 442);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnLogout.Size = new System.Drawing.Size(206, 30);
            this.BtnLogout.TabIndex = 48;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click_1);
            // 
            // panelManageEmployees
            // 
            this.panelManageEmployees.BackColor = System.Drawing.Color.DimGray;
            this.panelManageEmployees.Controls.Add(this.BtnTrackEmployees);
            this.panelManageEmployees.Controls.Add(this.BtnViewEmployees);
            this.panelManageEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManageEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelManageEmployees.Location = new System.Drawing.Point(0, 381);
            this.panelManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.panelManageEmployees.Name = "panelManageEmployees";
            this.panelManageEmployees.Size = new System.Drawing.Size(206, 61);
            this.panelManageEmployees.TabIndex = 46;
            // 
            // BtnTrackEmployees
            // 
            this.BtnTrackEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTrackEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTrackEmployees.FlatAppearance.BorderSize = 0;
            this.BtnTrackEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnTrackEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnTrackEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTrackEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTrackEmployees.ForeColor = System.Drawing.Color.White;
            this.BtnTrackEmployees.Location = new System.Drawing.Point(0, 30);
            this.BtnTrackEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTrackEmployees.Name = "BtnTrackEmployees";
            this.BtnTrackEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnTrackEmployees.Size = new System.Drawing.Size(206, 30);
            this.BtnTrackEmployees.TabIndex = 1;
            this.BtnTrackEmployees.Text = "Track Employees";
            this.BtnTrackEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTrackEmployees.UseVisualStyleBackColor = true;
            this.BtnTrackEmployees.Click += new System.EventHandler(this.BtnTrackEmployees_Click_1);
            // 
            // BtnViewEmployees
            // 
            this.BtnViewEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnViewEmployees.FlatAppearance.BorderSize = 0;
            this.BtnViewEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnViewEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnViewEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewEmployees.ForeColor = System.Drawing.Color.White;
            this.BtnViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.BtnViewEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.BtnViewEmployees.Name = "BtnViewEmployees";
            this.BtnViewEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnViewEmployees.Size = new System.Drawing.Size(206, 30);
            this.BtnViewEmployees.TabIndex = 0;
            this.BtnViewEmployees.Text = "View Employees";
            this.BtnViewEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewEmployees.UseVisualStyleBackColor = true;
            this.BtnViewEmployees.Click += new System.EventHandler(this.BtnViewEmployees_Click_1);
            // 
            // BtnManageEmployees
            // 
            this.BtnManageEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnManageEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnManageEmployees.FlatAppearance.BorderSize = 0;
            this.BtnManageEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnManageEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageEmployees.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageEmployees.ForeColor = System.Drawing.Color.White;
            this.BtnManageEmployees.Location = new System.Drawing.Point(0, 351);
            this.BtnManageEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.BtnManageEmployees.Name = "BtnManageEmployees";
            this.BtnManageEmployees.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnManageEmployees.Size = new System.Drawing.Size(206, 30);
            this.BtnManageEmployees.TabIndex = 47;
            this.BtnManageEmployees.Text = "Manage Employees";
            this.BtnManageEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManageEmployees.UseVisualStyleBackColor = true;
            this.BtnManageEmployees.Click += new System.EventHandler(this.BtnManageEmployees_Click_1);
            // 
            // panelInventory
            // 
            this.panelInventory.BackColor = System.Drawing.Color.DimGray;
            this.panelInventory.Controls.Add(this.BtnInventoryReport);
            this.panelInventory.Controls.Add(this.BtnEditProducts);
            this.panelInventory.Controls.Add(this.BtnSearchProducts);
            this.panelInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInventory.Location = new System.Drawing.Point(0, 260);
            this.panelInventory.Margin = new System.Windows.Forms.Padding(2);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(206, 91);
            this.panelInventory.TabIndex = 44;
            // 
            // BtnInventoryReport
            // 
            this.BtnInventoryReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventoryReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventoryReport.FlatAppearance.BorderSize = 0;
            this.BtnInventoryReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnInventoryReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnInventoryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryReport.ForeColor = System.Drawing.Color.White;
            this.BtnInventoryReport.Location = new System.Drawing.Point(0, 60);
            this.BtnInventoryReport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventoryReport.Name = "BtnInventoryReport";
            this.BtnInventoryReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnInventoryReport.Size = new System.Drawing.Size(206, 30);
            this.BtnInventoryReport.TabIndex = 2;
            this.BtnInventoryReport.Text = "Report";
            this.BtnInventoryReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventoryReport.UseVisualStyleBackColor = true;
            this.BtnInventoryReport.Click += new System.EventHandler(this.BtnInventoryReport_Click_1);
            // 
            // BtnEditProducts
            // 
            this.BtnEditProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEditProducts.FlatAppearance.BorderSize = 0;
            this.BtnEditProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnEditProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnEditProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditProducts.ForeColor = System.Drawing.Color.White;
            this.BtnEditProducts.Location = new System.Drawing.Point(0, 30);
            this.BtnEditProducts.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditProducts.Name = "BtnEditProducts";
            this.BtnEditProducts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnEditProducts.Size = new System.Drawing.Size(206, 30);
            this.BtnEditProducts.TabIndex = 1;
            this.BtnEditProducts.Text = "Edit Products";
            this.BtnEditProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditProducts.UseVisualStyleBackColor = true;
            this.BtnEditProducts.Click += new System.EventHandler(this.BtnEditProducts_Click);
            // 
            // BtnSearchProducts
            // 
            this.BtnSearchProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSearchProducts.FlatAppearance.BorderSize = 0;
            this.BtnSearchProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnSearchProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSearchProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchProducts.ForeColor = System.Drawing.Color.White;
            this.BtnSearchProducts.Location = new System.Drawing.Point(0, 0);
            this.BtnSearchProducts.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearchProducts.Name = "BtnSearchProducts";
            this.BtnSearchProducts.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnSearchProducts.Size = new System.Drawing.Size(206, 30);
            this.BtnSearchProducts.TabIndex = 0;
            this.BtnSearchProducts.Text = "Search Products";
            this.BtnSearchProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearchProducts.UseVisualStyleBackColor = true;
            this.BtnSearchProducts.Click += new System.EventHandler(this.BtnSearchProducts_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInventory.FlatAppearance.BorderSize = 0;
            this.BtnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.ForeColor = System.Drawing.Color.White;
            this.BtnInventory.Location = new System.Drawing.Point(0, 230);
            this.BtnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnInventory.Size = new System.Drawing.Size(206, 30);
            this.BtnInventory.TabIndex = 45;
            this.BtnInventory.Text = "Inventory";
            this.BtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInventory.UseVisualStyleBackColor = true;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // panelSales
            // 
            this.panelSales.BackColor = System.Drawing.Color.DimGray;
            this.panelSales.Controls.Add(this.BtnSalesReport);
            this.panelSales.Controls.Add(this.BtnTransactionHistory);
            this.panelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSales.Location = new System.Drawing.Point(0, 166);
            this.panelSales.Margin = new System.Windows.Forms.Padding(2);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(206, 64);
            this.panelSales.TabIndex = 42;
            // 
            // BtnSalesReport
            // 
            this.BtnSalesReport.BackColor = System.Drawing.Color.DimGray;
            this.BtnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalesReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalesReport.FlatAppearance.BorderSize = 0;
            this.BtnSalesReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnSalesReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalesReport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalesReport.ForeColor = System.Drawing.Color.White;
            this.BtnSalesReport.Location = new System.Drawing.Point(0, 30);
            this.BtnSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSalesReport.Name = "BtnSalesReport";
            this.BtnSalesReport.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnSalesReport.Size = new System.Drawing.Size(206, 32);
            this.BtnSalesReport.TabIndex = 2;
            this.BtnSalesReport.Text = "Sales Report";
            this.BtnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalesReport.UseVisualStyleBackColor = false;
            this.BtnSalesReport.Click += new System.EventHandler(this.BtnSalesReport_Click_1);
            // 
            // BtnTransactionHistory
            // 
            this.BtnTransactionHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTransactionHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTransactionHistory.FlatAppearance.BorderSize = 0;
            this.BtnTransactionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnTransactionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnTransactionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransactionHistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransactionHistory.ForeColor = System.Drawing.Color.White;
            this.BtnTransactionHistory.Location = new System.Drawing.Point(0, 0);
            this.BtnTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTransactionHistory.Name = "BtnTransactionHistory";
            this.BtnTransactionHistory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.BtnTransactionHistory.Size = new System.Drawing.Size(206, 30);
            this.BtnTransactionHistory.TabIndex = 1;
            this.BtnTransactionHistory.Text = "Sales History";
            this.BtnTransactionHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTransactionHistory.UseVisualStyleBackColor = true;
            this.BtnTransactionHistory.Click += new System.EventHandler(this.BtnTransactionHistory_Click_1);
            // 
            // BtnSales
            // 
            this.BtnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSales.FlatAppearance.BorderSize = 0;
            this.BtnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSales.ForeColor = System.Drawing.Color.White;
            this.BtnSales.Location = new System.Drawing.Point(0, 136);
            this.BtnSales.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnSales.Size = new System.Drawing.Size(206, 30);
            this.BtnSales.TabIndex = 43;
            this.BtnSales.Text = "Sales";
            this.BtnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSales.UseVisualStyleBackColor = true;
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // BtnPOS
            // 
            this.BtnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPOS.FlatAppearance.BorderSize = 0;
            this.BtnPOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPOS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPOS.ForeColor = System.Drawing.Color.White;
            this.BtnPOS.Location = new System.Drawing.Point(0, 106);
            this.BtnPOS.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPOS.Name = "BtnPOS";
            this.BtnPOS.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.BtnPOS.Size = new System.Drawing.Size(206, 30);
            this.BtnPOS.TabIndex = 41;
            this.BtnPOS.Text = "Point of Sale";
            this.BtnPOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPOS.UseVisualStyleBackColor = true;
            this.BtnPOS.Click += new System.EventHandler(this.BtnPOS_Click);
            // 
            // txtAcctName
            // 
            this.txtAcctName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtAcctName.AutoSize = true;
            this.txtAcctName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctName.ForeColor = System.Drawing.Color.White;
            this.txtAcctName.Location = new System.Drawing.Point(9, 559);
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(43, 17);
            this.txtAcctName.TabIndex = 6;
            this.txtAcctName.Text = "User";
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInAs.ForeColor = System.Drawing.Color.White;
            this.lblLoggedInAs.Location = new System.Drawing.Point(9, 542);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(79, 12);
            this.lblLoggedInAs.TabIndex = 5;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picBiliPCLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(206, 106);
            this.panelLogo.TabIndex = 0;
            // 
            // picBiliPCLogo
            // 
            this.picBiliPCLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBiliPCLogo.Image")));
            this.picBiliPCLogo.Location = new System.Drawing.Point(11, 18);
            this.picBiliPCLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picBiliPCLogo.Name = "picBiliPCLogo";
            this.picBiliPCLogo.Size = new System.Drawing.Size(184, 84);
            this.picBiliPCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBiliPCLogo.TabIndex = 0;
            this.picBiliPCLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(206, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(944, 24);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlContainerForm
            // 
            this.pnlContainerForm.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlContainerForm.Controls.Add(this.lblCopyrights);
            this.pnlContainerForm.Controls.Add(this.picBiliPCLogoDefault);
            this.pnlContainerForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerForm.Location = new System.Drawing.Point(206, 24);
            this.pnlContainerForm.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainerForm.MinimumSize = new System.Drawing.Size(945, 639);
            this.pnlContainerForm.Name = "pnlContainerForm";
            this.pnlContainerForm.Size = new System.Drawing.Size(945, 639);
            this.pnlContainerForm.TabIndex = 0;
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
            // lblCopyrights
            // 
            this.lblCopyrights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyrights.AutoSize = true;
            this.lblCopyrights.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyrights.ForeColor = System.Drawing.Color.Navy;
            this.lblCopyrights.Location = new System.Drawing.Point(379, 593);
            this.lblCopyrights.Name = "lblCopyrights";
            this.lblCopyrights.Size = new System.Drawing.Size(211, 15);
            this.lblCopyrights.TabIndex = 2;
            this.lblCopyrights.Text = "©2020 by J. Hadjisaid and S. Pineda ";
            // 
            // DashboardUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1150, 687);
            this.Controls.Add(this.pnlContainerForm);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1163, 726);
            this.Name = "DashboardUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiliPC Store";
            this.Load += new System.EventHandler(this.DashboardUI_Load);
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlSideMenu.PerformLayout();
            this.panelManageEmployees.ResumeLayout(false);
            this.panelInventory.ResumeLayout(false);
            this.panelSales.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogo)).EndInit();
            this.pnlContainerForm.ResumeLayout(false);
            this.pnlContainerForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBiliPCLogoDefault)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrRealtimeTime;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picBiliPCLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label txtAcctName;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Panel pnlContainerForm;
        private System.Windows.Forms.PictureBox picBiliPCLogoDefault;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel panelManageEmployees;
        private System.Windows.Forms.Button BtnTrackEmployees;
        private System.Windows.Forms.Button BtnViewEmployees;
        private System.Windows.Forms.Button BtnManageEmployees;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Button BtnInventoryReport;
        private System.Windows.Forms.Button BtnEditProducts;
        private System.Windows.Forms.Button BtnSearchProducts;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Button BtnSalesReport;
        private System.Windows.Forms.Button BtnTransactionHistory;
        private System.Windows.Forms.Button BtnSales;
        private System.Windows.Forms.Button BtnPOS;
        private System.Windows.Forms.Label lblCopyrights;
    }
}