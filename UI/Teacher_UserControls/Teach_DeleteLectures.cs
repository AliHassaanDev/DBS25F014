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
    public partial class Teach_DeleteLectures : UserControl
    {
        public Teach_DeleteLectures()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadLectureIntoGridView();
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
            List<LecturesBL> lectures = LecturesDL.teacherLectures();
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
        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_lecturetxt(object sender, EventArgs e)
        {
            if (LectureTopicDelete.Text == "Enter Lecture Topic")
            {
                LectureTopicDelete.Text ="";
            }
        }
        private void leave_event_lecturetxt(object sender, EventArgs e)
        {
            if (LectureTopicDelete.Text == "")
            {
                LectureTopicDelete.Text ="Enter Lecture Topic";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String LectureTopic = LectureTopicDelete.Text;
            LecturesDL.deleteLecture(LectureTopic);
        }
    }
}
