using ComponentFactory.Krypton.Toolkit;
using FinalProjectDB.BL;
using FinalProjectDB.DL;
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
    public partial class Admin_UpdateCourse : UserControl
    {
        public Admin_UpdateCourse()
        {
            InitializeComponent();
        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enter_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter New Course Title")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter New Course Title";
            }
        }

        private void enter_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter New Credit Hours")
            {
                kryptonTextBox2.Text ="";
            }
        }
        private void leave_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter New Credit Hours";
            }
        }

        public void load()
        {
            DepartmentDL.loadDepartmentsList();
            this.kryptonComboBox1.DataSource = null;
            this.kryptonComboBox1.DataSource = DepartmentDL.department_list;

            CourseDL.loadCoursesList();
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = CourseDL.courses;
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "" && kryptonComboBox1.Text != "" && kryptonComboBox2.Text != "")
                {
                    string name = kryptonTextBox1.Text;
                    DateTime date = kryptonDateTimePicker1.Value;
                    int dept = DepartmentDL.getIDFromDept(kryptonComboBox1.Text);
                    int credithours = Convert.ToInt32(kryptonTextBox2.Text);

                    int course_id = CourseDL.getIDFromCourse(kryptonComboBox2.Text);

                    CourseBL course = new CourseBL(name, date, credithours, dept);

                    CourseDL.updateCourse(course_id, course);

                    MessageBox.Show("Course updated Successfully!");

                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();

                    load();
                }
            }catch(Exception ex) { MessageBox.Show(ToString(), ex.Message); }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
