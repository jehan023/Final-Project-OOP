using System;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class LoginUI : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public LoginUI()
        {
            InitializeComponent();
        }

        public static bool Admin { get; set; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var userRecord = db.LoadRecords<UsersModel>("Users");

            // Default Account
            if (userRecord.Count == 0)
            {
                db.InsertRecord("Users", new UsersModel
                {
                    Name = "Admin",
                    isAdmin = true,
                    Username = "Admin",
                    Password = "Admin123"
                });
                userRecord = db.LoadRecords<UsersModel>("Users");
            }

            string inputUid = textBoxUsername.Text;
            string inputPwd = textBoxPassword.Text;
            bool loggedIn = false;

            foreach (var user in userRecord)
                if ((inputUid == user.Username) && (inputPwd == user.Password))
                {
                    loggedIn = true;
                    Admin = user.isAdmin;
                    this.Hide();
                    using (DashboardUI dashboardUI = new DashboardUI())
                    {
                        dashboardUI.ShowDialog();
                    }
                    this.Close();
                    break;
                }

            if (loggedIn != true)
            {
                MessageBox.Show("Incorrect username/password.");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}