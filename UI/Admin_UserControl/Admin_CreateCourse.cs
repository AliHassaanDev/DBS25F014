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
    public partial class Admin_CreateCourse : UserControl
    {
        public Admin_CreateCourse()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Course Title")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Course Title";
            }
        }

        private void enter_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Credit Hours")
            {
                kryptonTextBox2.Text ="";
            }
        }
        private void leave_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Credit Hours";
            }
        }

        public void load()
        {
            DepartmentDL.loadDepartmentsList();
            this.kryptonComboBox1.DataSource = null;
            this.kryptonComboBox1.DataSource = DepartmentDL.department_list;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonDateTimePicker1 != null && kryptonComboBox1.Text != "")
                {
                    string name = kryptonTextBox1.Text;
                    DateTime date = kryptonDateTimePicker1.Value;
                    int dept = DepartmentDL.getIDFromDept(kryptonComboBox1.Text);
                    int credithours = Convert.ToInt32(kryptonTextBox2.Text);

                    CourseBL course=new CourseBL(name,date, credithours,dept);

                    CourseDL.CreateCourse(course);

                    MessageBox.Show("Course Created Successfully!");

                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
