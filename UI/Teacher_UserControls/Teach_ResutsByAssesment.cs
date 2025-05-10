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
    public partial class Teach_ResutsByAssesment : UserControl
    {
        public Teach_ResutsByAssesment()
        {
            InitializeComponent();

            var courses = LecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            course.DataSource = courses;
            course.DisplayMember = "CourseName";
            if (courses.Any())
            {
                var selectedCourse = courses.First();
                String CourseName = selectedCourse.getCourseName();
                assessment.DataSource = TeacherAssesmentsDL.IndividualTeacherAssessments(CourseName);
                assessment.DisplayMember = "Description";
            }

            course.SelectedIndexChanged += assessmentCourse_SelectedIndexChanged;
        }

        private void assessmentCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (course.SelectedItem is TeacherCoursesBL selectedCourse)
            {
                String CourseName = selectedCourse.getCourseName();
                assessment.DataSource = TeacherAssesmentsDL.IndividualTeacherAssessments(CourseName);
                assessment.DisplayMember = "Description";
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ResultId", "Result Id");
            dataGridView1.Columns.Add("AssessmentId", "Assessment Id");
            dataGridView1.Columns.Add("StudentId", "Student Id");
            dataGridView1.Columns.Add("ObtainedMarks", "Obtained Marks");
            dataGridView1.Columns.Add("TotalMarks", "Total Marks");
        }

        private void LoadEnrollmentIntoGridView()
        {
            List<TeacherResultBL> results = TeacherResultDL.resultList(course.Text,assessment.Text);
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(
                    result.getResultID(),
                    result.getAssessmentID(),
                    result.getStudentID(),
                    result.getObtainedMarks(),
                    result.getTotalMarks()

                );
            }
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadEnrollmentIntoGridView();
        }
    }
}
