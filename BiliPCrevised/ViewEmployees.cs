using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


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
            AddNewEmployee addEmployee = new AddNewEmployee();
            addEmployee.Show();
        }

        public void RefreshAccounts()
        {
            var userRecord = db.LoadRecords<UsersModel>("Users");
            EmployeeDataGrid.DataSource = userRecord;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshAccounts();
        }

        private void EmployeeDataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
            int emptyField = 0;
            foreach (Control control in GroupTextBox.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        emptyField += 1;
                    }
                }
            }

            if (emptyField > 0 )
            {
                MessageBox.Show("Please fill all of the " + emptyField + " field/s.");
            }

            else
            {
                try
                {
                    var SelectedRecord = db.LoadRecordById<UsersModel>("Users", new ObjectId(idBox.Text));
                    SelectedRecord.Name = nameBox.Text;
                    SelectedRecord.Username = usernameBox.Text;
                    SelectedRecord.Password = passwordBox.Text;
                    SelectedRecord.Wage = Double.Parse(wageBox.Text);
                    SelectedRecord.Workhours = Double.Parse(workhoursBox.Text);
                    SelectedRecord.isAdmin = adminTrueRadioBtn.Checked;
                    db.UpsertRecord<UsersModel>("Users", SelectedRecord.Id, SelectedRecord);
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
    }
}
