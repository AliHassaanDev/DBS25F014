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
    public partial class Teach_DeleteAssessment : UserControl
    {
        public Teach_DeleteAssessment()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadLectureIntoGridView();
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
            List<TeacherAssesmentsBL> assesments = TeacherAssesmentsDL.getAssesments();
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
        private void Teach_DeleteAssignment_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_lecturetxt(object sender, EventArgs e)
        {
            if (deleteAssessmentID.Text == "Enter Assessment ID")
            {
                deleteAssessmentID.Text ="";
            }
        }
        private void leave_event_lecturetxt(object sender, EventArgs e)
        {
            if (deleteAssessmentID.Text == "")
            {
                deleteAssessmentID.Text ="Enter Assessment ID";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int assessmentID = Convert.ToInt32(deleteAssessmentID.Text);
            TeacherAssesmentsDL.deleteAssesment(assessmentID);
        }
    }
}
