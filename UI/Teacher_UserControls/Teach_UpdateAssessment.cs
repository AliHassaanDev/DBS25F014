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
    public partial class Teach_UpdateAssessment : UserControl
    {
        public Teach_UpdateAssessment()
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

        private void Teach_UpdateAssignment_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (updateAssesmentId.Text == "Enter Assessment ID")
            {
                updateAssesmentId.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (updateAssesmentId.Text == "")
            {
                updateAssesmentId.Text ="Enter Assessment ID";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (updateDescription.Text == "Enter New Assessment Description")
            {
                updateDescription.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (updateDescription.Text == "")
            {
                updateDescription.Text ="Enter New Assessment Description";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int assessmentID= Convert.ToInt32(updateAssesmentId.Text);
            String description = updateDescription.Text;
            DateTime startTime = updateStartTime.Value;
            DateTime dueTime = updateEndTime.Value;
            TeacherAssesmentsDL.updateAssesment(description, startTime, dueTime, assessmentID);
            dataGridView1.Rows.Clear();
            LoadLectureIntoGridView();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
