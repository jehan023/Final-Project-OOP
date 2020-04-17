namespace BiliPC
{
    using System;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class DashboardUI : Form
    {
        public DashboardUI()
        {
            this.InitializeComponent();
            this.tmrRealtimeTime.Start();
            this.lblTime.Text = DateTime.Now.ToLongTimeString();
            this.lblDate.Text = DateTime.Now.ToLongDateString();
            this.CustomDesign();
            this.txtAcctName.Text = AcctName;
        }

        public static string AcctName { get; set; }

        private void DashboardUI_Load(object sender, EventArgs e)
        {
            // Verify if user is an Admin to show the "Manage Users" button
            using (new LoginUI())
            {
                this.BtnManageEmployees.Visible = LoginUI.Admin;
                this.txtAcctName.Text = AcctName = LoginUI.AcctName;
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

        #region Point of Sale
        private void BtnPOS_Click(object sender, EventArgs e)
        {
            this.HideSubmenu();
            this.OpenContainerForm(new TransactionForm());
        }

        #endregion

        #region Sales
        private void BtnSales_Click(object sender, EventArgs e)
        {
            this.ShowSubmenu(this.panelSales);
        }

        private void BtnTransactionHistory_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new SalesHistory());
            this.HideSubmenu();
        }

        private void BtnSalesReport_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new SalesReport());
            this.HideSubmenu();
        }

        #endregion

        #region Inventory
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            this.ShowSubmenu(this.panelInventory);
        }

        private void BtnSearchProducts_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new ViewProducts());
            this.HideSubmenu();
        }

        private void BtnEditProducts_Click(object sender, EventArgs e)
        {
            this.OpenContainerForm(new Products());
            this.HideSubmenu();
        }

        private void BtnInventoryReport_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new InventoryReport());
            this.HideSubmenu();
        }

        #endregion

        #region Manage Employees
        private void BtnManageEmployees_Click_1(object sender, EventArgs e)
        {
            this.ShowSubmenu(this.panelManageEmployees);
        }

        private void BtnViewEmployees_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new ViewEmployees());
            this.HideSubmenu();
        }

        private void BtnTrackEmployees_Click_1(object sender, EventArgs e)
        {
            this.OpenContainerForm(new TrackEmployees());
            this.HideSubmenu();
        }

        #endregion

        #region Logout
        public static void Logout()
        {
            MongoCRUD db = new MongoCRUD("POS_Database");
            LoginUI.IsLoggedIn = false;
            var userRecord = db.LoadRecordsByGenericT<UsersModel, string>("Users", "Name", AcctName);
            var loginRecord = db.LoadRecordByGenericSortedT<TrackEmployeesModel, ObjectId>("TrackEmployees", "AcctId", userRecord.Id, "Date");
            double workHours = (DateTime.Now - loginRecord.Date).TotalHours + loginRecord.TotalWorkHours;

            // Update current workhours in the UsersModel
            userRecord.Workhours = workHours;
            db.UpsertRecord("Users", userRecord.Id, userRecord);

            // Insert to Track Employees Database
            db.InsertRecord("TrackEmployees", new TrackEmployeesModel
            {
                AcctName = AcctName,
                AcctId = userRecord.Id,
                Date = DateTime.Now,
                LoggedIn = LoginUI.IsLoggedIn,
                TotalWorkHours = workHours,
                Salary = userRecord.Salary,
            });
            AcctName = null;
        }

        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            this.HideSubmenu();

            // Message box log out confirmation.
            string msg = "Are you sure you want to log out?";
            string ttl = "Log out Confirmation";
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(msg, ttl, btns, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Logout();
                using (LoginUI login = new LoginUI())
                {
                    login.ShowDialog();
                }

                this.Close();
            }
        }

        #endregion
    }
}