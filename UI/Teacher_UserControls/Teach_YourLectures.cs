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
    public partial class Teach_YourLectures : UserControl
    {
        public Teach_YourLectures()
        {
            InitializeComponent();
            ComboBox1.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            ComboBox1.DisplayMember = "CourseName";

        }

        private void Teach_YourLectures_Load(object sender, EventArgs e)
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
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }
    }
}
