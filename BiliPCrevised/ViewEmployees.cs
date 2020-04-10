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
            this.AutoCompleteSearch();
            this.RefreshAccounts();
        }

        private void AutoCompleteSearch()
        {
            AutoCompleteStringCollection search = new AutoCompleteStringCollection();

            var userRecord = this.db.LoadRecords<UsersModel>("Users");

            foreach (var userName in userRecord)
            {
                if (!search.Contains(userName.Name))
                {
                    search.Add(userName.Name);
                }
            }

            this.TxtSearchEmployee.AutoCompleteCustomSource = search;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsByCaseInsensitive<UsersModel>("Users", "Name", this.TxtSearchEmployee.Text);
            this.dgdEmployee.DataSource = selectedRecord;
        }

        private void RefreshAccounts()
        {
            var userRecord = this.db.LoadRecords<UsersModel>("Users");
            this.dgdEmployee.DataSource = userRecord;
            this.TxtSearchEmployee.Text = string.Empty;
            this.AutoCompleteSearch();

            if (userRecord.Any()
                && double.TryParse(this.dgdEmployee.Rows[0].Cells[5].Value.ToString(), out double workhours))
            {
                // Show first item in the textboxes
                this.txtAcctID.Text = this.dgdEmployee.Rows[0].Cells[0].Value.ToString();
                this.txtAcctName.Text = this.dgdEmployee.Rows[0].Cells[1].Value.ToString();
                this.txtAcctUsername.Text = this.dgdEmployee.Rows[0].Cells[2].Value.ToString();
                this.txtAcctPassword.Text = this.dgdEmployee.Rows[0].Cells[3].Value.ToString();
                this.txtAcctSalary.Text = this.dgdEmployee.Rows[0].Cells[4].Value.ToString();
                this.txtAcctWorkhours.Text = workhours.ToString("F2", CultureInfo.CurrentCulture);
                this.radAdminTrue.Checked = this.dgdEmployee.Rows[0].Cells[6].Value.Equals(true);
                this.radAdminFalse.Checked = this.dgdEmployee.Rows[0].Cells[6].Value.Equals(false);
            }
            else
            {
                // Clear textboxes if the data is null
                this.txtAcctID.Text
                    = this.txtAcctName.Text
                    = this.txtAcctUsername.Text
                    = this.txtAcctPassword.Text
                    = this.txtAcctPassword.Text
                    = this.txtAcctSalary.Text
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
            else if (ObjectId.TryParse(this.txtAcctID.Text, out ObjectId id) && double.TryParse(this.txtAcctSalary.Text, out double salary))
            {
                var selectedRecord = this.db.LoadRecordsByGenericT<UsersModel, ObjectId>("Users", "Id", id);
                var userRecord = this.db.LoadRecords<UsersModel>("Users");
                bool usernameExists = false;
                foreach (var user in userRecord)
                {
                    if (user.Id != selectedRecord.Id && user.Username == this.txtAcctUsername.Text)
                    {
                        usernameExists = true;
                    }
                }

                if (!usernameExists)
                {
                    using (DashboardUI dashboard = new DashboardUI())
                    {
                        if (selectedRecord.Name == DashboardUI.AcctName)
                        {
                            DashboardUI.AcctName = this.txtAcctName.Text;
                        }
                    }

                    selectedRecord.Name = this.txtAcctName.Text;
                    selectedRecord.Username = this.txtAcctUsername.Text;
                    selectedRecord.Password = this.txtAcctPassword.Text;
                    selectedRecord.Salary = salary;
                    selectedRecord.IsAdmin = this.radAdminTrue.Checked;
                    this.db.UpsertRecord("Users", selectedRecord.Id, selectedRecord);
                    MessageBox.Show("Account updated.");
                    this.RefreshAccounts();
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose another username.");
                }
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
                var selectedRecord = this.db.LoadRecordsByGenericT<UsersModel, string>("Users", "Name", DashboardUI.AcctName);
                {
                    if (selectedRecord.Id != id)
                    {
                        this.db.DeleleRecord<UsersModel>("Users", id);
                        MessageBox.Show("Account deleted.");
                        this.RefreshAccounts();
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete your account while logged in. Please log in using different admin account.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void DgdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 
                && double.TryParse(this.dgdEmployee.Rows[e.RowIndex].Cells[5].Value.ToString(), out double workhours))
            {
                this.txtAcctID.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.txtAcctName.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.txtAcctUsername.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.txtAcctPassword.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.txtAcctSalary.Text = this.dgdEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.txtAcctWorkhours.Text = workhours.ToString("F2", CultureInfo.CurrentCulture);
                this.radAdminTrue.Checked = this.dgdEmployee.Rows[e.RowIndex].Cells[6].Value.Equals(true);
                this.radAdminFalse.Checked = this.dgdEmployee.Rows[e.RowIndex].Cells[6].Value.Equals(false);
            }
        }

        private void TxtAcctWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 46) && !this.txtAcctSalary.Text.Contains('.'))
            {
                Functions.RestrictedKeyPressToDouble(e);
            }
            else
            {
                Functions.RestrictedKeyPressToInt(e);
            }
        }

        private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            var userRecord = this.db.LoadRecordsByCaseInsensitive<UsersModel>("Users", "Name", this.TxtSearchEmployee.Text);
            this.dgdEmployee.DataSource = userRecord;
        }
    }
}
