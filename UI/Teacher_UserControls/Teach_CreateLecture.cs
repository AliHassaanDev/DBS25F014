using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.DL;
using FinalProjectDB.BL;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_CreateLecture : UserControl
    {
        public Teach_CreateLecture()
        {
            InitializeComponent();
            dataGridView1.DataSource = CourseDL.IndividualTeacherCourses(TeacherProfileDL.getTeacherId(Login.user));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (LectureCourseName.Text == "Enter Lecture Course")
            {
                LectureCourseName.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (LectureCourseName.Text == "")
            {
                LectureCourseName.Text ="Enter Lecture Course";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (LectureTopic.Text == "Enter Lecture Topic")
            {
                LectureTopic.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (LectureTopic.Text == "")
            {
                LectureTopic.Text ="Enter Lecture Topic";
            }
        }

        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (LectureDuration.Text == "Enter Lecture Duration in Hours")
            {
                LectureDuration.Text ="";
            }
        }
        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (LectureDuration.Text == "")
            {
                LectureDuration.Text ="Enter Lecture Duration in Hours";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            String lectureCourse = LectureCourseName.Text;
            LecturesDL.validCourse(lectureCourse);
            String lectureTopic = LectureTopic.Text;
            int lectureDuration = Convert.ToInt32(LectureDuration.Text);
            DateTime lectureDate =LectureTime.Value;
            int courseID = CourseDL.getIDFromCourse(lectureCourse);
            LecturesBL lecture = new LecturesBL(TeacherProfileDL.getTeacherId(Login.user),courseID , lectureTopic,lectureDate,lectureDuration);
            LecturesDL.AddLecture(lecture);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
