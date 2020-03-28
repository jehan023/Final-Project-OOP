namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class ViewEmployees : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public ViewEmployees()
        {
            this.InitializeComponent();
            this.RefreshAccounts();
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByStringList<UsersModel>("Users", "Name", this.txtSearchEmployee.Text);
            this.dgdEmployee.DataSource = selectedRecord;
        }

        private void RefreshAccounts()
        {
            var userRecord = this.db.LoadRecords<UsersModel>("Users");
            this.dgdEmployee.DataSource = userRecord;
            this.txtSearchEmployee.Text = string.Empty;

            if (userRecord.Any())
            {
                // Show first item in the textboxes
                this.txtAcctID.Text = this.dgdEmployee.Rows[0].Cells[0].Value.ToString();
                this.radAdminTrue.Checked = this.dgdEmployee.Rows[0].Cells[1].Value.Equals(true);
                this.radAdminFalse.Checked = this.dgdEmployee.Rows[0].Cells[1].Value.Equals(false);
                this.txtAcctName.Text = this.dgdEmployee.Rows[0].Cells[2].Value.ToString();
                this.txtAcctUsername.Text = this.dgdEmployee.Rows[0].Cells[3].Value.ToString();
                this.txtAcctPassword.Text = this.dgdEmployee.Rows[0].Cells[4].Value.ToString();
                this.txtAcctWage.Text = this.dgdEmployee.Rows[0].Cells[5].Value.ToString();
                this.txtAcctWorkhours.Text = this.dgdEmployee.Rows[0].Cells[6].Value.ToString();
            }
            else
            {
                // Clear textboxes if the data is null
                this.txtAcctID.Text
                    = this.txtAcctName.Text
                    = this.txtAcctUsername.Text
                    = this.txtAcctPassword.Text
                    = this.txtAcctPassword.Text
                    = this.txtAcctWage.Text
                    = this.txtAcctWorkhours.Text
                    = string.Empty;
                this.radAdminTrue.Checked
                    = this.radAdminFalse.Checked
                    = false;
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            this.RefreshAccounts();
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            using (AddNewEmployee addEmployee = new AddNewEmployee())
            {
                addEmployee.ShowDialog();
            }

            this.RefreshAccounts();
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int emptyField = Functions.CheckFields(this.GroupTextBox);
            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else if (ObjectId.TryParse(this.txtAcctID.Text, out ObjectId id)
                    && double.TryParse(this.txtAcctWage.Text, out double wage)
                    && double.TryParse(this.txtAcctWorkhours.Text, out double workHours))
            {
                var selectedRecord = this.db.LoadRecordById<UsersModel>("Users", id);
                selectedRecord.Name = this.txtAcctName.Text;
                selectedRecord.Username = this.txtAcctUsername.Text;
                selectedRecord.Password = this.txtAcctPassword.Text;
                selectedRecord.Wage = wage;
                selectedRecord.Workhours = workHours;
                selectedRecord.IsAdmin = this.radAdminTrue.Checked;
                this.db.UpsertRecord("Users", selectedRecord.Id, selectedRecord);
                MessageBox.Show("Account updated.");
                this.RefreshAccounts();
            }
            else
            {
                MessageBox.Show("Please enter a valid character.");
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (ObjectId.TryParse(this.txtAcctID.Text, out ObjectId id))
            {
                this.db.DeleleRecord<UsersModel>("Users", id);
                MessageBox.Show("Account deleted.");
                this.RefreshAccounts();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void DgdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.txtAcctID.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.radAdminTrue.Checked = this.dgdEmployee.Rows[e.RowIndex].Cells[1].Value.Equals(true);
                this.radAdminFalse.Checked = this.dgdEmployee.Rows[e.RowIndex].Cells[1].Value.Equals(false);
                this.txtAcctName.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtAcctUsername.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtAcctPassword.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtAcctWage.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.txtAcctWorkhours.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void TxtAcctWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtAcctWage.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }

        private void TxtAcctWorkhours_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtAcctWorkhours.Text.Contains('.'))
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
