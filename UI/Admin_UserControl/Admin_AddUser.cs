using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.BL;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_AddUser : UserControl
    {
        public Admin_AddUser()
        {
            InitializeComponent();
        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enter_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Username")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Username";
            }
        }
        private void enter_event_emailtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Email")
            {
                kryptonTextBox3.Text ="";
            }
        }
        private void leave_event_emailtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Email";
            }
        }

        private void enter_event_passwordtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Password")
            {
                kryptonTextBox2.Text ="";
                kryptonTextBox2.PasswordChar = '*'; 
            }
        }
        private void leave_event_passwordtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.PasswordChar = '\0';
                kryptonTextBox2.Text ="Enter Password";
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonTextBox3.Text != "" && kryptonComboBox2.Text != "")
                {
                    string name = kryptonTextBox1.Text;
                    string email = kryptonTextBox3.Text;
                    string password = kryptonTextBox2.Text;

                    password = BCrypt.Net.BCrypt.HashPassword(password);

                    int role = 1;
                    if (kryptonComboBox2.Text == "Student") { role = 1; }
                    else if (kryptonComboBox2.Text == "Teacher") { role = 2; }
                    else if (kryptonComboBox2.Text == "Admin") { role = 3; }

                    UserBL user = new UserBL(email, name, password, role);

                    UserDL.AddUser(user);

                    MessageBox.Show("User added successfully!");

                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                    kryptonTextBox3.Clear();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
