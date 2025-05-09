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
    public partial class Login : KryptonForm
    {
        public static string user;
        
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void enter_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Username")
            {
                kryptonTextBox1.Text = "";
            }
        }

        private void leave_event_usernametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text = "Enter Username";
            }
        }

        private void enter_event_passwordtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Password")
            {
                kryptonTextBox2.Text = "";
                kryptonTextBox2.PasswordChar = '*';
            }
        }

        private void leave_event_passwordtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.PasswordChar = '\0';
                kryptonTextBox2.Text = "Enter Password";
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "")
            {
                string username = kryptonTextBox1.Text;
                string password = kryptonTextBox2.Text;

                UserBL user = new UserBL(username, password);

                if (UserDL.Login(user)) 
                { 
                    MessageBox.Show("Login Successful!");
                    kryptonTextBox1.Text = "Enter Username";
                    kryptonTextBox2.PasswordChar = '\0';
                    kryptonTextBox2.Text = "Enter Password";
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                    UserBL.current_user_role_id = 0;
                }
                Login.user = username;
                

                if (UserBL.current_user_role_id == 1)
                {
                    this.Visible = false;
                    Student student = new Student();
                    student.StartPosition = FormStartPosition.Manual;
                    student.Location = this.Location;
                    student.Size = this.Size;
                    student.Show();
                }
                else if(UserBL.current_user_role_id == 2)
                {
                    this.Visible = false;
                    Teachers teachers=new Teachers();
                    teachers.StartPosition= FormStartPosition.Manual;
                    teachers.Location = this.Location;
                    teachers.Size = this.Size;
                    teachers.Show();
                }
                else if (UserBL.current_user_role_id == 3)
                {
                    this.Visible = false;
                    Admin admin = new Admin();
                    admin.StartPosition = FormStartPosition.Manual;
                    admin.Location = this.Location;
                    admin.Size = this.Size;
                    admin.Show();
                }
            }
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

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
