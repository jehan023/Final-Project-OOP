using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace BiliPC
{
    public partial class LoginUI : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public LoginUI()
        {
            InitializeComponent();
        }

        public class IsUser
        {
            public static bool Admin { get; set; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var userRecord = db.LoadRecords<UsersModel>("Users");
            string inputUid = textBoxUsername.Text;
            string inputPwd = textBoxPassword.Text;
            bool loggedIn = false;
            
            foreach (var user in userRecord)
                if ((inputUid == user.Username) && (inputPwd == user.Password))
                {
                    this.Hide();
                    loggedIn = true;
                    IsUser.Admin = user.isAdmin;
                    DashboardUI dashboardUI = new DashboardUI();
                    dashboardUI.Show();
                    break;
                }

            if (loggedIn != true)
            {
                MessageBox.Show("Incorrect username/password.");
            }
        }
    }
}