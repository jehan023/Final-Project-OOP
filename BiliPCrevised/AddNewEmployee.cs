using System;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class AddNewEmployee : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            bool UsernameExists = db.CheckExistence<UsersModel>("Users", "Username", usernameBox.Text);

            // Check the empty boxes
            int EmptyField = Functions.CheckFields(GroupTextBox);

            if (EmptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + EmptyField + " field/s.");
            }
            else if (UsernameExists == true)
            {
                MessageBox.Show("Username already taken.");
            }
            else if (passwordBox.Text != confirmPasswordBox.Text)
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if ((passwordBox.Text == confirmPasswordBox.Text) && !UsernameExists && (EmptyField == 0))
            {
                try
                {
                    db.InsertRecord("Users", new UsersModel
                    {
                        Name = nameBox.Text,
                        Username = usernameBox.Text,
                        Password = passwordBox.Text,
                        Wage = double.Parse(wageBox.Text),
                        isAdmin = adminTrueRadioBtn.Checked
                    });
                    MessageBox.Show("Account Saved!");
                    this.Dispose();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
            else
            {
                MessageBox.Show("Unknown Error.");
            }
        }

        private void WageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
