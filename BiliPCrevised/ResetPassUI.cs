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
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (emptyField == 0)
            {
                var usersRecord = this.db.LoadRecords<UsersModel>("Users");
                foreach (var user in usersRecord)
                {
                    if (user.Name == this.txtName.Text && user.Username == this.txtUsername.Text
                        && this.txtNewPassword.Text == this.txtConfirmPassword.Text)
                    {
                        user.Password = this.txtConfirmPassword.Text;
                        this.db.UpsertRecord("Users", user.Id, user);
                        MessageBox.Show("Success.");
                        this.Close();
                        break;
                    }
                    else if (user.Username == this.txtUsername.Text && user.Name != this.txtName.Text)
                    {
                        MessageBox.Show("Please check your Name/Username.");
                        break;
                    }
                }

                var usrnmExists = this.db.CheckExistenceByGeneric<UsersModel, string>("Users", "Name", this.txtUsername.Text);
                if (!usrnmExists)
                {
                    MessageBox.Show("Account does not exist.");
                }
                else if (this.txtNewPassword.Text != this.txtConfirmPassword.Text)
                {
                    MessageBox.Show("Please check your entered password.");
                }
            }
        }
    }
}
