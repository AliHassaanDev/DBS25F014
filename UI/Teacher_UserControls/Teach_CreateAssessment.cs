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

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_CreateAssessment : UserControl
    {
        public Teach_CreateAssessment()
        {
            InitializeComponent();
            assesmentType.Items.Add("quiz");
            assesmentType.Items.Add("assignment");
            assesmentType.Items.Add("exam");
            ConfigureDataGridView();
            LoadTeacherCoursesIntoGridView();

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TeacherId", "Teacher ID");
            dataGridView1.Columns.Add("CourseTitle", "Course Title");
        }
        private void LoadTeacherCoursesIntoGridView()
        {
            List<TeacherCoursesBL> courses = CourseDL.IndividualTeacherCourses(TeacherProfileDL.getTeacherId(Login.user));
            foreach (var course in courses)
            {
                dataGridView1.Rows.Add(
                    course.getTeacherId(),
                    course.getCourseName()
                );
            }
        }
        private void Teach_CreateAssignment_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (assesmentCourse.Text == "Enter Assignment Course")
            {
                assesmentCourse.Text = "";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (assesmentCourse.Text == "")
            {
                assesmentCourse.Text = "Enter Assignment Course";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (assesmentDescription.Text == "Enter Assignment Description")
            {
                assesmentDescription.Text = "";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (assesmentDescription.Text == "")
            {
                assesmentDescription.Text = "Enter Assignment Description";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String assesmentcourseName = assesmentCourse.Text;
            String assesmentdescription = assesmentDescription.Text;
            DateTime starttime = Convert.ToDateTime(assesmentStartTime.Text);
            DateTime endtime = Convert.ToDateTime(assesmentEndTime.Text);
            int courseID = CourseDL.getIDFromCourse(assesmentcourseName);
            TeacherAssesmentsBL teacherAssesmentsBL = new TeacherAssesmentsBL(courseID, assesmentType.Text, assesmentdescription, starttime, endtime);
            TeacherAssesmentsDL.insertAssesment(teacherAssesmentsBL);
        }
    }
}