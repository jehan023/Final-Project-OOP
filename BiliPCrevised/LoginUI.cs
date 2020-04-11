namespace BiliPC
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class LoginUI : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public LoginUI()
        {
            this.InitializeComponent();
        }

        public static bool Admin { get; set; }

        public static string AcctName { get; set; }

        public static bool IsLoggedIn { get; set; } = false;

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

            string inputUsrnm = this.txtUsername.Text;
            string inputPwd = this.txtPassword.Text;

            foreach (var user in userRecord)
            {
                if ((inputUsrnm == user.Username) && (inputPwd == user.Password))
                {
                    Admin = user.IsAdmin;
                    AcctName = user.Name;
                    IsLoggedIn = true;
                    this.Hide();

                    double userWorkHours = 0;
                    var trackRecordExists = this.db.CheckExistenceByGeneric<TrackEmployeesModel, ObjectId>("TrackEmployees", "AcctId", user.Id);
                    if (trackRecordExists)
                    {
                        var loginRecord = this.db.LoadRecordByGenericSortedT<TrackEmployeesModel, ObjectId>("TrackEmployees", "AcctId", user.Id, "Date");
                        userWorkHours = loginRecord.TotalWorkHours;
                    }

                    this.db.InsertRecord("TrackEmployees", new TrackEmployeesModel
                    {
                        AcctName = AcctName,
                        AcctId = user.Id,
                        Date = DateTime.Now,
                        LoggedIn = IsLoggedIn,
                        TotalWorkHours = userWorkHours,
                        Salary = user.Salary,
                    });

                    using (DashboardUI dashboardUI = new DashboardUI())
                    {
                        dashboardUI.ShowDialog();
                    }

                    this.Close();
                    break;
                }
            }

            if (IsLoggedIn != true)
            {
                // Message box showing Username/Password incorrect.
                string message = "Incorrect username/password.";
                string title = "Sign In";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using ResetPassUI resetpassUI = new ResetPassUI();
            resetpassUI.ShowDialog();
        }
    }
}