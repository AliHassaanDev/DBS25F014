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
    public partial class Teach_CourseAssessments : UserControl
    {
        public Teach_CourseAssessments()
        {
            InitializeComponent();
            assessmentType.Items.Add("quiz");
            assessmentType.Items.Add("assignment");
            assessmentType.Items.Add("exam");
            ComboBox1.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            ComboBox1.DisplayMember = "CourseName";
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("AssessmentId", "Assessment ID");
            dataGridView1.Columns.Add("CourseTitle", "Course Title");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("StartTime", "Start Time");
            dataGridView1.Columns.Add("DueTime", "Due Time");
        }
        private void LoadLectureIntoGridView()
        {
            List<TeacherAssesmentsBL> assesments = TeacherAssesmentsDL.viewSubmissionsByCondition(ComboBox1.Text,assessmentType.Text);
            foreach (var assesment in assesments)
            {
                dataGridView1.Rows.Add(
                    assesment.getAssessmentId(),
                    assesment.getCourseTitle(),
                    assesment.getType(),
                    assesment.getDescription(),
                    assesment.getStartTime(),
                    assesment.getdueTime()
                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click_1(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
