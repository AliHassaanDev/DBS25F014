using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FinalProjectDB.BL;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EDUMS eDUMS = new EDUMS();
            eDUMS.StartPosition = FormStartPosition.Manual;
            eDUMS.Location = this.Location;
            eDUMS.Size = this.Size;
            eDUMS.Show();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonTextBox3.Text != "" &&
                    kryptonTextBox1.Text != "Enter Username" && kryptonTextBox3.Text != "Enter Email" && kryptonTextBox2.Text != "Enter Password")
                {
                    string username = kryptonTextBox1.Text;
                    string email = kryptonTextBox3.Text;
                    string password = kryptonTextBox2.Text;

                    password = BCrypt.Net.BCrypt.HashPassword(password);

                    UserBL student = new UserBL(email, username, password);
                    UserDL.AddStudent(student);
                    MessageBox.Show("Account created successfully!");

                    kryptonTextBox1.Text = "Enter Username";
                    kryptonTextBox3.Text = "Enter Email";
                    kryptonTextBox2.PasswordChar = '\0';
                    kryptonTextBox2.Text = "Enter Password";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
