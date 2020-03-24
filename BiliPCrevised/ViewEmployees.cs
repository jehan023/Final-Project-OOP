namespace BiliPC
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using MongoDB.Bson;

    public partial class ViewEmployees : Form
    {
        private readonly MongoCRUD db = new MongoCRUD("POS_Database");

        public ViewEmployees()
        {
            this.InitializeComponent();
            this.RefreshAccounts();

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

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            var selectedRecord = this.db.LoadRecordsBySpecific<UsersModel>("Users", "Name", this.txtSearchEmployee.Text);
            this.dgdEmployee.DataSource = selectedRecord;
        }

        private void RefreshAccounts()
        {
            var userRecord = this.db.LoadRecords<UsersModel>("Users");
            this.dgdEmployee.DataSource = userRecord;
            this.txtSearchEmployee.Text = string.Empty;
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
        }

        private void BtnUpdateAccount_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int emptyField = Functions.CheckFields(this.GroupTextBox);
            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }
            else
            {
                try
                {
                    var selectedRecord = this.db.LoadRecordById<UsersModel>("Users", new ObjectId(this.txtAcctID.Text));
                    selectedRecord.Name = this.txtAcctName.Text;
                    selectedRecord.Username = this.txtAcctUsername.Text;
                    selectedRecord.Password = this.txtAcctPassword.Text;
                    selectedRecord.Wage = double.Parse(this.txtAcctWage.Text, CultureInfo.InvariantCulture);
                    selectedRecord.Workhours = double.Parse(this.txtAcctWorkhours.Text, CultureInfo.InvariantCulture);
                    selectedRecord.IsAdmin = this.radAdminTrue.Checked;
                    this.db.UpsertRecord<UsersModel>("Users", selectedRecord.Id, selectedRecord);
                    this.RefreshAccounts();
                    MessageBox.Show("Account updated.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            try
            {
                this.db.DeleleRecord<UsersModel>("Users", ObjectId.Parse(this.txtAcctID.Text));
                this.RefreshAccounts();
                MessageBox.Show("Account deleted.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void DgdEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Invalid selction.");
            }
        }

        private void WageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
