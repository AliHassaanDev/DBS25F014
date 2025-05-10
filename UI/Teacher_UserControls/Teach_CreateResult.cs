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
    public partial class Teach_CreateResult : UserControl
    {
        public Teach_CreateResult()
        {
            InitializeComponent();
            resultCourse.DataSource = LecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            resultCourse.DisplayMember = "CourseName";
            
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("AssessmentId", "Assessment Id");
            dataGridView1.Columns.Add("StudentId", "Student Id");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("CourseName", "Course Name");
            dataGridView1.Columns.Add("Assessment Type", "AssessmentType");
        }
        private void LoadEnrollmentIntoGridView()
        {
            List<TeacherResultBL> results = TeacherResultDL.resultEnrollmentList(resultCourse.Text);
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(
                    result.getAssessmentID(),
                    result.getStudentID(),
                    result.getStudentName(),
                    result.getCourseName(),
                    result.getType()
                );
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_studenttxt(object sender, EventArgs e)
        {
            if (resultStudentID.Text == "Enter Student ID")
            {
                resultStudentID.Text ="";
            }
        }

        private void leave_event_studenttxt(object sender, EventArgs e)
        {
            if (resultStudentID.Text == "")
            {
                resultStudentID.Text ="Enter Student ID";
            }
        }
        private void enter_event_totaltxt(object sender, EventArgs e)
        {
            if (resultTotalmarks.Text == "Enter Total Marks")
            {
                resultTotalmarks.Text ="";
            }
        }

        private void leave_event_totaltxt(object sender, EventArgs e)
        {
            if (resultTotalmarks.Text == "")
            {
                resultTotalmarks.Text ="Enter Total Marks";
            }
        }
        private void enter_event_obtainedtxt(object sender, EventArgs e)
        {
            if (resultObtainedmarks.Text == "Enter Obtained Marks")
            {
                resultObtainedmarks.Text ="";
            }
        }

        private void leave_event_obtainedtxt(object sender, EventArgs e)
        {
            if (resultObtainedmarks.Text == "")
            {
                resultObtainedmarks.Text ="Enter Obtained Marks";
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String courseName = resultCourse.Text;
            int assessmentID =Convert.ToInt32(resultAssessment.Text);
            int studentID =Convert.ToInt32(resultStudentID.Text);
            decimal obtainedMarks =Convert.ToDecimal(resultObtainedmarks.Text);
            decimal totalMarks =Convert.ToDecimal(resultTotalmarks.Text);
            TeacherResultDL.InsertResult(studentID, assessmentID,obtainedMarks, totalMarks);

        }

        private void resultCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadEnrollmentIntoGridView();
        }
    }
}
