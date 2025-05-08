using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.BL;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_UpdateUser : UserControl
    {
        public Admin_UpdateUser()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter New Username")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter New Username";
            }
        }
        private void enter_event_emailtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter New Email")
            {
                kryptonTextBox3.Text ="";
            }
        }
        private void leave_event_emailtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter New Email";
            }
        }

        private void enter_event_passwordtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter New Password")
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
                kryptonTextBox2.Text ="Enter New Password";
            }
        }

        public void load()
        {
            UserDL.loadUsers();
            kryptonComboBox2.DataSource = null;
            kryptonComboBox2.DataSource = UserDL.user_names;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonComboBox2.Text != "" && kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonTextBox3.Text != "")
                {
                    string name = kryptonTextBox1.Text;
                    string password = kryptonTextBox2.Text;
                    string email = kryptonTextBox3.Text;

                    password = BCrypt.Net.BCrypt.HashPassword(password);

                    int id = UserDL.getIDFromUsername(kryptonComboBox2.Text);

                    UserBL user = new UserBL(email, name, password);

                    UserDL.updateUser(user, id);

                    MessageBox.Show("Updated successfully!");

                    load();

                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                    kryptonTextBox3.Clear();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
