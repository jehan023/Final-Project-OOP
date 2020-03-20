﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiliPC
{
    public partial class AddNewEmployee : Form
    {
        MongoCRUD db = new MongoCRUD("POS_Database");
        
        public AddNewEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            bool UsernameExists = db.CheckExistence<UsersModel>("Users", "Username", UsernameBox.Text);

            // Check the empty boxes
            int EmptyField = 0;
            foreach (Control control in GroupTextBox.Controls)
            {
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        EmptyField += 1;
                    }
                }
            }

            if (EmptyField > 0)
            {
                MessageBox.Show("Please fill all of the " + EmptyField + " field/s.");
            }
            else if (UsernameExists == true)
            {
                MessageBox.Show("Username already taken.");
            }
            else if (PasswordBox.Text != ConfirmPasswordBox.Text)
            {
                MessageBox.Show("Please confirm your password.");
            }
            else if ((PasswordBox.Text == ConfirmPasswordBox.Text) && !UsernameExists && (EmptyField == 0))
            {
                try
                {
                    db.InsertRecord("Users", new UsersModel
                    {
                        Name = NameBox.Text,
                        Username = UsernameBox.Text,
                        Password = PasswordBox.Text,
                        Wage = double.Parse(WageBox.Text),
                        isAdmin = radioBtnAdminTrue.Checked
                    });
                    MessageBox.Show("Account Saved!");
                    this.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid character.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unhandled exception: " + ex + " . Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Unknown Error.");
            }
        }   
    }
}
