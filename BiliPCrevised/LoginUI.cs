namespace BiliPC
{
    using System;
    using System.Windows.Forms;

    public partial class LoginUI : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public LoginUI()
        {
            this.InitializeComponent();
        }

        public static bool Admin { get; set; }

        public static string AcctName { get; set; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var userRecord = this.db.LoadRecords<UsersModel>("Users");

            // Default Account
            if (userRecord.Count == 0)
            {
                this.db.InsertRecord("Users", new UsersModel
                {
                    Name = "Admin",
                    IsAdmin = true,
                    Username = "Admin",
                    Password = "Admin123",
                });
                userRecord = this.db.LoadRecords<UsersModel>("Users");
            }

            string inputUid = this.txtUsername.Text;
            string inputPwd = this.txtPassword.Text;
            bool loggedIn = false;

            foreach (var user in userRecord)
            {
                if ((inputUid == user.Username) && (inputPwd == user.Password))
                {
                    loggedIn = true;
                    Admin = user.IsAdmin;
                    AcctName = user.Name;
                    this.Hide();
                    using (DashboardUI dashboardUI = new DashboardUI())
                    {
                        dashboardUI.ShowDialog();
                    }

                    this.Close();
                    break;
                }
            }

            if (loggedIn != true)
            {
                MessageBox.Show("Incorrect username/password.");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}