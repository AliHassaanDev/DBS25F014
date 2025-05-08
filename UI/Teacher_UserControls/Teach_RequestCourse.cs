using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.DL;
using FinalProjectDB.BL;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_RequestCourse : UserControl
    {
        public Teach_RequestCourse()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadCoursesIntoGridView();
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("CourseName", "Course Name");
            dataGridView1.Columns.Add("CreditHours", "Credit Hours");
            dataGridView1.Columns.Add("EndDate", "End Date");
            dataGridView1.Columns.Add("DepartmentID", "Department ID");
        }
        private void LoadCoursesIntoGridView()
        {
            List<CourseBL> courses = CourseDL.AllAvailableCourses();
            foreach (var course in courses)
            {
                dataGridView1.Rows.Add(
                    course.getCourseName(),
                    course.getCreditHours(),
                    course.getDate(),
                    course.getDept_id()
                );
            }
        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (requestedCourse.Text == "Enter Course You Want")
            {
                requestedCourse.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (requestedCourse.Text == "")
            {
                requestedCourse.Text ="Enter Course You Want";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
            TeacherProfile t1 = new TeacherProfile();
            String RequestedCourse = requestedCourse.Text;
            CourseDL.addRequestedCourse(TeacherProfileDL.getTeacherId(Login.user), RequestedCourse);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
