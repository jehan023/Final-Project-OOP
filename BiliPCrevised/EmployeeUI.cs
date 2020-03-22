﻿using System;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class EmployeeUI : Form
    {
        public EmployeeUI()
        {
            InitializeComponent();
            timer1.Start();
            labelTime.Text = DateTime.Now.ToLongTimeString();
            labelDate.Text = DateTime.Now.ToLongDateString();
            CustomDesign();
            CustomDesign();
        }

        //TIMER TICK
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        #region Hide-Show Submenu
        private void CustomDesign()
        {
            panelSales.Visible = false;
            panelInventory.Visible = false;
        }
        private void HideSubmenu()
        {
            if (panelSales.Visible == true)
                panelSales.Visible = false;
            if (panelInventory.Visible == true)
                panelInventory.Visible = false;
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

        public Form ActiveForm1 { get; set; } = null;

        private void openContainerForm(Form ContainerForm)
        {
            if (ActiveForm1 != null)
                ActiveForm1.Close();
            ActiveForm1 = ContainerForm;
            ContainerForm.TopLevel = false;
            ContainerForm.Dock = DockStyle.Fill;
            panelContainerForm.Controls.Add(ContainerForm);
            panelContainerForm.Tag = ContainerForm;
            ContainerForm.BringToFront();
            ContainerForm.Show();

        }
        public new void Dispose()
        {
            ActiveForm1.Dispose();
        }


        #endregion

        //SALES PART
        #region Sales
        private void btnSales_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSales);
        }

        private void btnCreateTransaction_Click(object sender, EventArgs e)
        {
            openContainerForm(new TransactionForm());
            HideSubmenu();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            //codes for sales history
            HideSubmenu();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            //codes for sales report
            HideSubmenu();
        }

        #endregion

        //INVENTORY PART
        #region Inventory
        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelInventory);
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            openContainerForm(new ViewProducts());
            HideSubmenu();
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            openContainerForm(new Products());
            HideSubmenu();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            //codes for inventory report
            HideSubmenu();
        }
        #endregion

        //LOGOUT PART
        #region Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion








    }
}
