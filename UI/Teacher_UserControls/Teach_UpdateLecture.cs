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
    public partial class Teach_UpdateLecture : UserControl
    {
        public Teach_UpdateLecture()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }

        private void Teach_UpdateLecture_Load(object sender, EventArgs e)
        {

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("LectureID", "Lecture ID");
            dataGridView1.Columns.Add("CourseName", "Course Name");
            dataGridView1.Columns.Add("Topic", "Topic");
            dataGridView1.Columns.Add("StartTime", "Start Time");
            dataGridView1.Columns.Add("Duration", "Duration");
        }
        private void LoadLectureIntoGridView()
        {
            List<TeachersLecturesBL> lectures = TeacherLecturesDL.teacherLectures();
            foreach (var lecture in lectures)
            {
                dataGridView1.Rows.Add(
                    lecture.getLectureId(),
                    lecture.getCourseName(),
                    lecture.getTopic(),
                    lecture.getStartTime(),
                    lecture.getDuration()
                );
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (LectureIDUpdate.Text == "Enter Lecture")
            {
                LectureIDUpdate.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (LectureIDUpdate.Text == "")
            {
                LectureIDUpdate.Text ="Enter Lecture";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (LectureTopicUpdate.Text == "Enter New Lecture Topic")
            {
                LectureTopicUpdate.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (LectureTopicUpdate.Text == "")
            {
                LectureTopicUpdate.Text ="Enter New Lecture Topic";
            }
        }

        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (LectureDurationUpdate.Text == "Enter New Lecture Duration in Hours")
            {
                LectureDurationUpdate.Text ="";
            }
        }
        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (LectureDurationUpdate.Text == "")
            {
                LectureDurationUpdate.Text ="Enter New Lecture Duration in Hours";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int LectureID =Convert.ToInt32(LectureIDUpdate.Text);
            String LectureTopic = LectureTopicUpdate.Text;
            int LectureDuration =Convert.ToInt32(LectureDurationUpdate.Text);
            DateTime LectureTime = LectureTimeUpdate.Value;
            TeacherLecturesDL.updateLecture(LectureID, LectureTopic, LectureTime, LectureDuration);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
