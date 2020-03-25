namespace BiliPC
{
    using System;
    using System.Globalization;
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
            bool usernameExists = this.db.CheckExistence<UsersModel>("Users", "Username", this.txtUsername.Text);
            int emptyField = Functions.CheckFields(this.GroupTextBox);

            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (usernameExists == true)
            {
                MessageBox.Show("Username already taken.");
            }
            else if (this.txtPassword.Text != this.txtConfirmPassword.Text)
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if ((this.txtPassword.Text == this.txtConfirmPassword.Text) && !usernameExists && (emptyField == 0))
            {
                try
                {
                    this.db.InsertRecord("Users", new UsersModel
                    {
                        Name = this.txtName.Text,
                        Username = this.txtUsername.Text,
                        Password = this.txtPassword.Text,
                        Wage = double.Parse(this.txtWage.Text, CultureInfo.InvariantCulture),
                        IsAdmin = this.adminTrueRadioBtn.Checked,
                    });
                    MessageBox.Show("Account Saved!");
                    this.Close();
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

        private void TxtWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
