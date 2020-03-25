namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            this.InitializeComponent();
            this.tmrRealtimeTime.Start();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.lblDate.Text = DateTime.Now.ToLongDateString();
            this.CustomDesign();

            // Verify if user is an Admin to show the "Manage Users" button
            using (new LoginUI())
            {
                this.btnManageEmployees.Visible = LoginUI.Admin;
                this.lblAcctName.Text = LoginUI.AcctName;
            }
        }

        #region Container Form
        public new Form ActiveForm { get; set; } = null;

        private void OpenContainerForm(Form containerForm)
        {
            if (this.ActiveForm != null)
            {
                this.ActiveForm.Close();
            }

            this.ActiveForm = containerForm;
            containerForm.TopLevel = false;
            containerForm.Dock = DockStyle.Fill;
            this.pnlContainerForm.Controls.Add(containerForm);
            containerForm.TopLevel = false;
            containerForm.Dock = DockStyle.Fill;
            this.pnlContainerForm.Controls.Add(containerForm);
            this.pnlContainerForm.Tag = containerForm;
            containerForm.BringToFront();
            containerForm.Show();
        }
        #endregion

        #region Real-time Time
        private void TmrRealtimeTime_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.tmrRealtimeTime.Start();
        }
        #endregion

        #region Hide-Show Submenu
        private void CustomDesign()
        {
            this.panelSales.Visible = false;
            this.panelInventory.Visible = false;
            this.panelManageEmployees.Visible = false;
        }

        private void HideSubmenu()
        {
            if (this.panelSales.Visible == true)
            {
                this.panelSales.Visible = false;
            }

            if (this.panelInventory.Visible == true)
            {
                this.panelInventory.Visible = false;
            }

            if (this.panelManageEmployees.Visible == true)
            {
                this.panelManageEmployees.Visible = false;
            }
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                this.HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        #region Sales
        private void BtnSales_Click_1(object sender, EventArgs e)
            {
                this.ShowSubmenu(this.panelSales);
            }

        private void BtnCreateTransaction_Click_1(object sender, EventArgs e)
            {
                this.OpenContainerForm(new TransactionForm());
                this.HideSubmenu();
            }

        private void BtnSalesReport_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new SalesReport());
            this.HideSubmenu();
        }

        private void BtnTransactionHistory_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new SalesHistory());
            this.HideSubmenu();
        }

        #endregion

        #region Inventory
        private void BtnInventory_Click_1(object sender, EventArgs e)
        {
            this.ShowSubmenu(this.panelInventory);
        }

        private void BtnSearchProducts_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new ViewProducts());
            this.HideSubmenu();
        }

        private void BtnEditProducts_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new Products());
            this.HideSubmenu();
        }

        private void BtnInventoryReport_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new InventoryReport());
            this.HideSubmenu();
        }

        #endregion

        #region Manage Employees
        private void BtnManageEmployees_Click(object sender, EventArgs e)
        {
            this.ShowSubmenu(this.panelManageEmployees);
        }

        private void BtnViewEmployees_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new ViewEmployees());
            this.HideSubmenu();
        }

        private void BtnTrackEmployees_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new TrackEmployees());
            this.HideSubmenu();
        }

        #endregion

        #region Logout
        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            using (LoginUI login = new LoginUI())
            {
                login.ShowDialog();
            }

            this.Close();
        }
        #endregion
    }
}