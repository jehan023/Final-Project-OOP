namespace BiliPC
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class AddNewEmployee : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public AddNewEmployee()
        {
            this.InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            bool usernameExists = this.db.CheckExistenceByGeneric<UsersModel, string>("Users", "Username", this.txtUsername.Text);
            int emptyField = Functions.CheckFields(this.GroupTextBox);

            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (usernameExists)
            {
                MessageBox.Show("Username already taken.");
            }
            else if (this.txtPassword.Text != this.txtConfirmPassword.Text)
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if ((this.txtPassword.Text == this.txtConfirmPassword.Text) && !usernameExists && (emptyField == 0))
            {
                if (double.TryParse(this.txtWage.Text, out double wage))
                {
                    this.db.InsertRecord("Users", new UsersModel
                    {
                        Name = this.txtName.Text,
                        Username = this.txtUsername.Text,
                        Password = this.txtPassword.Text,
                        Salary = wage,
                        IsAdmin = this.adminTrueRadioBtn.Checked,
                    });
                    MessageBox.Show("Account Saved!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
            else
            {
                MessageBox.Show("Unknown Error.");
            }
        }

        private void TxtWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtWage.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }
    }
}
