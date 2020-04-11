namespace BiliPC
{
    using System;
    using System.Drawing;
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
                // Message box showing unfilled textbox.
                string message = "Please fill all of the " + emptyField + " field/s.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else if (usernameExists)
            {
                // Message box showing Username already exists.
                string message = "Username already taken.";
                string title = "New Account";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else if (this.TxtPassword.Text != this.TxtConfirmPassword.Text)
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if ((this.TxtPassword.Text == this.TxtConfirmPassword.Text) && !usernameExists && (emptyField == 0))
            {
                if (double.TryParse(this.txtWage.Text, out double wage))
                {
                    this.db.InsertRecord("Users", new UsersModel
                    {
                        Name = this.txtName.Text,
                        Username = this.txtUsername.Text,
                        Password = this.TxtPassword.Text,
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

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtConfirmPassword.Text))
            {
                this.lblCheckPass.Text = " ";
            }
            else if (this.TxtPassword.Text == this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password Matched.";
                this.lblCheckPass.ForeColor = Color.Green;
            }
            else if (this.TxtPassword.Text != this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password  Not Matched!";
                this.lblCheckPass.ForeColor = Color.Red;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtConfirmPassword.Text))
            {
                this.lblCheckPass.Text = " ";
            }
            else if (this.TxtPassword.Text == this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password Matched.";
                this.lblCheckPass.ForeColor = Color.Green;
            }
            else if (this.TxtPassword.Text != this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password  Not Matched!";
                this.lblCheckPass.ForeColor = Color.Red;
            }
        }
    }
}
