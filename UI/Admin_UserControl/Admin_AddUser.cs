using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
