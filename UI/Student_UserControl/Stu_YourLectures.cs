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

namespace FinalProjectDB.UI.Student_UserControl
{
    public partial class Stu_YourLectures : UserControl
    {
        public Stu_YourLectures()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            List<TeachersLecturesBL> lectures = TeacherLecturesDL.studentLectures();
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
    }
}
