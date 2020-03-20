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
        static MongoClient client = new MongoClient("mongodb://localhost:27017/");
        static IMongoDatabase db = client.GetDatabase("POS_Database");
        static IMongoCollection<UsersModel> collection = db.GetCollection<UsersModel>("Users");
        bool admin;
        public ViewEmployees()
        {
            InitializeComponent();
            ReadData();
        }

        //Close button
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Add Employee button
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmployee = new AddNewEmployee();
            addEmployee.Show();
        }

        //datasource of datagrid Users
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            List<UsersModel> list = collection.AsQueryable().ToList<UsersModel>();
            EmployeeDataGrid.DataSource = list;
        }

        //refresh table for Users
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<UsersModel> list = collection.AsQueryable().ToList<UsersModel>();
            EmployeeDataGrid.DataSource = list;
        }

        //show in boxes the data

        public void ReadData()
        {
            List<UsersModel> list = collection.AsQueryable().ToList<UsersModel>();
            EmployeeDataGrid.DataSource = list;
            IdBox.Text = EmployeeDataGrid.Rows[0].Cells[0].Value.ToString();
            radioAdminTrue.Checked = EmployeeDataGrid.Rows[0].Cells[1].Value.Equals(true);
            radioAdminFalse.Checked = EmployeeDataGrid.Rows[0].Cells[1].Value.Equals(false);
            NameBox.Text = EmployeeDataGrid.Rows[0].Cells[2].Value.ToString();
            UsernameBox.Text = EmployeeDataGrid.Rows[0].Cells[3].Value.ToString();
            PasswordBox.Text = EmployeeDataGrid.Rows[0].Cells[4].Value.ToString();
            WageBox.Text = EmployeeDataGrid.Rows[0].Cells[5].Value.ToString();
            WorkhoursBox.Text = EmployeeDataGrid.Rows[0].Cells[6].Value.ToString();
                
           
           
        }

        //cell click to view data in boxes
        private void EmployeeDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IdBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                radioAdminTrue.Checked = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.Equals(true);
                radioAdminFalse.Checked = EmployeeDataGrid.Rows[e.RowIndex].Cells[1].Value.Equals(false);
                NameBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                UsernameBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                PasswordBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                WageBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                WorkhoursBox.Text = EmployeeDataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Invalid selection.");
            }
        }

        //Account type Radio buttons
        private void radioAdminTrue_CheckedChanged(object sender, EventArgs e)
        {
            admin = true;
        }

        private void radioAdminFalse_CheckedChanged(object sender, EventArgs e)
        {
            admin = false;
        }

        //Update Employee
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<UsersModel>.Update
               .Set("Name", NameBox.Text)
               .Set("Username", UsernameBox.Text)
               .Set("Password", PasswordBox.Text) 
               .Set("isAdmin", admin)
               .Set("Workhours", Double.Parse(WorkhoursBox.Text))
               .Set("Wage", Double.Parse(WageBox.Text));
            collection.UpdateOne(u => u.Id == ObjectId.Parse(IdBox.Text), updateDef);
            ReadData();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(u => u.Id == ObjectId.Parse(IdBox.Text));
            ReadData();
        }
    }
}
