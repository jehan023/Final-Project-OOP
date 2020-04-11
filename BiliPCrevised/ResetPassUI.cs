namespace BiliPC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ResetPassUI : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public ResetPassUI()
        {
            this.InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int emptyField = Functions.CheckFields(this.GroupTextBox);
            if (emptyField > 0)
            {
                // Message box showing unfilled textbox.
                string message = "Please fill all of the " + emptyField + " field/s.";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            }
            else if (emptyField == 0)
            {
                var usrnmExists = this.db.CheckExistenceByGeneric<UsersModel, string>("Users", "Username", this.txtUsername.Text);
                if (!usrnmExists)
                {
                    // Message box showing Account doesn't exists.
                    string message = "Account does not exists.";
                    string title = "Reset Account";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
                else if (this.TxtNewPassword.Text != this.TxtConfirmPassword.Text)
                {
                    // Message box showing input Passwords doesn't matched.
                    string message = "Please check your entered password.";
                    string title = "Reset Account";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }

                var usersRecord = this.db.LoadRecords<UsersModel>("Users");
                foreach (var user in usersRecord)
                {
                    if (user.Name == this.txtName.Text && user.Username == this.txtUsername.Text
                        && this.TxtNewPassword.Text == this.TxtConfirmPassword.Text)
                    {
                        // Message box confirmation of password resetting
                        string message = "Do you want to reset your passsword?";
                        string title = "Reset Account Confirmation";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            user.Password = this.TxtConfirmPassword.Text;
                            this.db.UpsertRecord("Users", user.Id, user);
                            MessageBox.Show("Password Reset Successful.");
                            this.Close();
                        }

                        break;
                    }
                    else if (user.Username == this.txtUsername.Text && user.Name != this.txtName.Text)
                    {
                        // Message box showing Name doesn't matched.
                        string message = "Please check your Name.";
                        string title = "Reset Account";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }

        private void TxtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtConfirmPassword.Text))
            {
                this.lblCheckPass.Text = " ";
            }
            else if (this.TxtNewPassword.Text == this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password Matched.";
                this.lblCheckPass.ForeColor = Color.Green;
            }
            else if (this.TxtNewPassword.Text != this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password  Not Matched!";
                this.lblCheckPass.ForeColor = Color.Red;
            }
        }

        private void TxtNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.TxtConfirmPassword.Text))
            {
                this.lblCheckPass.Text = " ";
            }
            else if (this.TxtNewPassword.Text == this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password Matched.";
                this.lblCheckPass.ForeColor = Color.Green;
            }
            else if (this.TxtNewPassword.Text != this.TxtConfirmPassword.Text)
            {
                this.lblCheckPass.Text = "Password  Not Matched!";
                this.lblCheckPass.ForeColor = Color.Red;
            }
        }
    }
}
