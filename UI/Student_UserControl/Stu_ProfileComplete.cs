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

namespace FinalProjectDB.UI.Student_UserControl
{
    public partial class Stu_ProfileComplete : UserControl
    {
        public Stu_ProfileComplete()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Your Name")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Your Name";
            }
        }
        private void enter_event_fathertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Your Father Name")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_fathertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Your Father Name";
            }
        }
        private void enter_event_cnictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Your CNIC")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_cnictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Your CNIC";
            }
        }
        private void enter_event_gendertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "Enter Your Gender")
            {
                kryptonTextBox4.Text ="";
            }
        }

        private void leave_event_gendertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "")
            {
                kryptonTextBox4.Text ="Enter Your Gender";
            }
        }
        private void enter_event_phonetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox6.Text == "Enter Your Phone Number")
            {
                kryptonTextBox6.Text ="";
            }
        }

        private void leave_event_phonetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox6.Text == "")
            {
                kryptonTextBox6.Text ="Enter Your Phone Number";
            }
        }
        private void enter_event_addresstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox5.Text == "Enter Your Address")
            {
                kryptonTextBox5.Text ="";
            }
        }

        private void leave_event_addresstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox5.Text == "")
            {
                kryptonTextBox5.Text ="Enter Your Address";
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonTextBox3.Text != "" && kryptonTextBox4.Text != "" 
                    && kryptonTextBox5.Text != "" && kryptonTextBox6.Text != "" && kryptonTextBox1.Text != "Ender Your Name" && 
                    kryptonTextBox2.Text != "Enter Your Father Name" && kryptonTextBox3.Text != "Enter Your CNIC" && 
                    kryptonTextBox4.Text != "Enter Your Gender" && kryptonTextBox5.Text != "Enter Your Address" && 
                    kryptonTextBox6.Text != "Enter Your Phone Number" && kryptonDateTimePicker1.Value.Date != DateTime.Today)
                {
                    int id = UserBL.current_user_id;
                    string name = kryptonTextBox1.Text;
                    string fname = kryptonTextBox2.Text;
                    string gender = kryptonTextBox4.Text;
                    string cnic = kryptonTextBox3.Text;
                    string phoneNo = kryptonTextBox6.Text;
                    string address = kryptonTextBox5.Text;
                    DateTime date = kryptonDateTimePicker1.Value;
                    StudentsBL student = new StudentsBL(id,name,fname,cnic,gender,date,phoneNo,address);
                    if (!StudentsDL.userExists(id)) 
                    {
                        StudentsDL.InsertStudent(student);
                    }
                    StudentsDL.AddStudentInfo(student);

                    kryptonTextBox1.Clear();
                    MessageBox.Show("Your Profile Updated Successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
