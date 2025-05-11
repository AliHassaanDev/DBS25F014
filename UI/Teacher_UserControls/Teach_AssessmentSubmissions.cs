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
    public partial class Teach_AssessmentSubmissions : UserControl
    {
        public Teach_AssessmentSubmissions()
        {
            InitializeComponent();
            submissionAssessment.Items.Add("quiz");
            submissionAssessment.Items.Add("assignment");
            submissionAssessment.Items.Add("exam");
            submissionCourse.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            submissionCourse.DisplayMember = "CourseName";
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("SubmissionID", "Submission ID");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("SubmittedAt", "Submitted At");
        }
        private void LoadSubmissionsIntoGridView()
        {
            List<SubmissionDisplayBL> submissions = SubmissionDisplayDL.submissionsList(CourseDL.getIDFromCourse(submissionCourse.Text),submissionAssessment.Text);
            if (submissions == null)
            {
                MessageBox.Show("No submissions found or an error occurred.");
                return;
            }

            dataGridView1.Rows.Clear();
            foreach (var submission in submissions)
            {
                dataGridView1.Rows.Add(
                    submission.GetSubmissionID(),
                    submission.GetStudentName(),
                    submission.GetDescription(),
                    submission.GetSubmittedAt()
                );
            }
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
           ConfigureDataGridView();
            LoadSubmissionsIntoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
