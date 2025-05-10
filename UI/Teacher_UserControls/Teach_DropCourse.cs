using ComponentFactory.Krypton.Toolkit;
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
namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_DropCourse : UserControl
    {
        public Teach_DropCourse()
        {
            InitializeComponent();
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
        private void teach_DropCourse_Load(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (DropCourseName.Text == "Enter Course You Want to Drop")
            {
                DropCourseName.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (DropCourseName.Text == "")
            {
                DropCourseName.Text ="Enter Course You Want to Drop";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String DropCourse = DropCourseName.Text;
            CourseDL.dropTeacherCourse(DropCourse,TeacherProfileDL.getTeacherId(Login.user));
            dataGridView1.Rows.Clear();
            LoadTeacherCoursesIntoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
