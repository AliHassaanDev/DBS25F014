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
    public partial class Teach_UpdateResult : UserControl
    {
        public Teach_UpdateResult()
        {
            InitializeComponent();
            updateCourse.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            updateCourse.DisplayMember = "CourseName";
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ResultId", "Result Id");
            dataGridView1.Columns.Add("AssessmentId", "Assessment Id");
            dataGridView1.Columns.Add("StudentId", "Student Id");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("CourseName", "Course Name");
            dataGridView1.Columns.Add("AssessmentType", "Assessment Type");
            dataGridView1.Columns.Add("ObtainedMarks", "Obtained Marks");
            dataGridView1.Columns.Add("TotalMarks", "Total Marks");
        }
        private void LoadEnrollmentIntoGridView()
        {
            List<TeacherResultBL> results = TeacherResultDL.resultList(updateCourse.Text);
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(
                    result.getResultID(),
                    result.getAssessmentID(),
                    result.getStudentID(),
                    result.getStudentName(),
                    result.getCourseName(),
                    result.getType(),
                    result.getObtainedMarks(),
                    result.getTotalMarks()

                );
            }
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_studenttxt(object sender, EventArgs e)
        {
            if (updateStudentID.Text == "Enter Student ID")
            {
                updateStudentID.Text ="";
            }
        }

        private void leave_event_studenttxt(object sender, EventArgs e)
        {
            if (updateStudentID.Text == "")
            {
                updateStudentID.Text ="Enter Student ID";
            }
        }
        private void enter_event_obtainedtxt(object sender, EventArgs e)
        {
            if (updateObtainedMarks.Text == "Enter New Obtained Marks")
            {
                updateObtainedMarks.Text ="";
            }
        }

        private void leave_event_obtainedtxt(object sender, EventArgs e)
        {
            if (updateObtainedMarks.Text == "")
            {
                updateObtainedMarks.Text ="Enter New Obtained Marks";
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadEnrollmentIntoGridView();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String courseName = updateCourse.Text;
            int studentID = Convert.ToInt32(updateStudentID.Text);
            decimal obtainedMarks = Convert.ToDecimal(updateObtainedMarks.Text);
            int assessmentID = Convert.ToInt32(updateAssessment.Text);
            TeacherResultDL.UpdateResult(studentID, assessmentID, obtainedMarks);

        }
    }
}
