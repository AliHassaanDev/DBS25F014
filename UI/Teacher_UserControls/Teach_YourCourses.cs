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
namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_YourCourses : UserControl
    {
        public Teach_YourCourses()
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
        private void Teach_YourCourses_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
