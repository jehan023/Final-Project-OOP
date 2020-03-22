using MongoDB.Bson;
using System;
using System.Windows.Forms;


namespace BiliPC
{
    public partial class ViewEmployees : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");

        public ViewEmployees()
        {
            InitializeComponent();
            RefreshAccounts();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            using (AddNewEmployee addEmployee = new AddNewEmployee())
            {
                addEmployee.ShowDialog();
            }
        }

        public void RefreshAccounts()
        {
            var userRecord = db.LoadRecords<UsersModel>("Users");
            EmployeeDataGrid.DataSource = userRecord;
            searchEmployeeBox.Text = "";
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshAccounts();
        }

        private void EmployeeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            adminTrueRadioBtn.Checked = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.Equals(true);
            adminFalseRadioBtn.Checked = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.Equals(false);
            nameBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            usernameBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            wageBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            workhoursBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void UpdateAccountBtn_Click(object sender, EventArgs e)
        {
            // Check the empty fields
            int emptyField = Functions.CheckFields(GroupTextBox);
            if (emptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }

            else
            {
                try
                {
                    var selectedRecord = db.LoadRecordById<UsersModel>("Users", new ObjectId(idBox.Text));
                    selectedRecord.Name = nameBox.Text;
                    selectedRecord.Username = usernameBox.Text;
                    selectedRecord.Password = passwordBox.Text;
                    selectedRecord.Wage = Double.Parse(wageBox.Text);
                    selectedRecord.Workhours = Double.Parse(workhoursBox.Text);
                    selectedRecord.isAdmin = adminTrueRadioBtn.Checked;
                    db.UpsertRecord<UsersModel>("Users", selectedRecord.Id, selectedRecord);
                    RefreshAccounts();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
            }
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                db.DeleleRecord<UsersModel>("Users", ObjectId.Parse(idBox.Text));
                RefreshAccounts();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please select an item.");
            }
        }

        private void SearchEmployeeBtn_Click(object sender, EventArgs e)
        {
            var selectedRecord = db.LoadRecordsBySpecific<UsersModel>("Users", "Name", searchEmployeeBox.Text);
            EmployeeDataGrid.DataSource = selectedRecord;
        }

        private void WageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Functions.RestrictedKeyPressToInt(e);
        }
    }
}
