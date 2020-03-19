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
            public static bool loggedIn { get; set; }
        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            var userRecord = db.LoadRecords<UsersModel>("Users");
            
            // Default Account
            if (userRecord.Count == 0)
            {
                db.InsertRecord("Users", new UsersModel
                {
                    isAdmin = true,
                    Username = "Admin",
                    Password = "Admin123"
                });
            }
            
            string inputUid = textBoxUsername.Text;
            string inputPwd = textBoxPassword.Text;
            IsUser.loggedIn = false;

            foreach (var user in userRecord)
                if ((inputUid == user.Username) && (inputPwd == user.Password))
                {
                    this.Hide();
                    IsUser.loggedIn = true;
                    IsUser.Admin = user.isAdmin;
                    DashboardUI dashboardUI = new DashboardUI();
                    dashboardUI.Show();
                    break;
                }

            if (IsUser.loggedIn != true)
            {
                MessageBox.Show("Incorrect username/password.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        
    }
}