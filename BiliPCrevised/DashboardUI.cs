using System;
using System.Windows.Forms;


namespace BiliPC
{
    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            InitializeComponent();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            CustomDesign();

            // verify if user is an Admin to hide the "Manage Users" button
            using (new LoginUI())
            {
                btnManageEmployees.Visible = LoginUI.Admin;
            }
        }

        #region Real-time Time
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
        #endregion

        #region Hide-Show Submenu
        private void CustomDesign()
        {
            panelSales.Visible = false;
            panelInventory.Visible = false;
            panelManageEmployees.Visible = false;
        }
        private void HideSubmenu()
        {
            if (panelSales.Visible == true)
                panelSales.Visible = false;
            if (panelInventory.Visible == true)
                panelInventory.Visible = false;
            if (panelManageEmployees.Visible == true)
                panelManageEmployees.Visible = false;
        }
        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        #endregion

        #region Container Form
        private Form activeForm = null;
        private void OpenContainerForm(Form ContainerForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = ContainerForm;
            ContainerForm.TopLevel = false;
            ContainerForm.Dock = DockStyle.Fill;
            panelContainerForm.Controls.Add(ContainerForm);
            panelContainerForm.Tag = ContainerForm;
            ContainerForm.BringToFront();
            ContainerForm.Show();
        }
        #endregion

        #region Sales
        private void btnSales_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(panelSales);
        }

        private void btnCreateTransaction_Click_1(object sender, EventArgs e)
        {
            OpenContainerForm(new TransactionForm());
            HideSubmenu();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            //codes for sales report
            HideSubmenu();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            //codes for sales history
            HideSubmenu();
        }

        #endregion

        #region Inventory
        private void btnInventory_Click_1(object sender, EventArgs e)
        {
            ShowSubmenu(panelInventory);
        }

        private void btnSearchProducts_Click_1(object sender, EventArgs e)
        {
            OpenContainerForm(new ViewProducts());
            HideSubmenu();
        }

        private void btnEditProducts_Click_1(object sender, EventArgs e)
        {
            OpenContainerForm(new Products());
            HideSubmenu();
        }
        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            //codes for inventory report
            HideSubmenu();
        }

        #endregion

        #region Manage Employees
        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelManageEmployees);
        }

        private void btnViewEmployees_Click(object sender, EventArgs e)
        {
            OpenContainerForm(new ViewEmployees());
            HideSubmenu();
        }

        private void btnTrackEmployees_Click(object sender, EventArgs e)
        {
            OpenContainerForm(new TrackEmployees());
            HideSubmenu();
        }

        #endregion

        #region Logout
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();   
            LoginUI login = new LoginUI();
            login.Show();
            
        }
        #endregion    
    }
}