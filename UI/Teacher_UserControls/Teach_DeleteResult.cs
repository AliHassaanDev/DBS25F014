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
    public partial class Teach_DeleteResult : UserControl
    {
        public Teach_DeleteResult()
        {
            InitializeComponent();
            deleteCourse.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            deleteCourse.DisplayMember = "CourseName";
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
            List<TeacherResultBL> results = TeacherResultDL.resultList(deleteCourse.Text);
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
        private void enter_event_resulttxt(object sender, EventArgs e)
        {
            if (deleteResult.Text == "Enter Result ID")
            {
                deleteResult.Text ="";
            }
        }

        private void leave_event_resulttxt(object sender, EventArgs e)
        {
            if (deleteResult.Text == "")
            {
                deleteResult.Text ="Enter Result ID";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadEnrollmentIntoGridView();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String deletecourse = deleteCourse.Text;
            int assessmentid=Convert.ToInt32(deleteAssignment.Text);
            int resultID=Convert.ToInt32(deleteResult.Text);
            TeacherResultDL.DeleteResult(assessmentid,resultID);
        }
    }
}
