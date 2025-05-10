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
    public partial class Teach_AttendanceByLecture : UserControl
    {
        public Teach_AttendanceByLecture()
        {
            InitializeComponent();
            attendanceCourse.DataSource = LecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            attendanceCourse.DisplayMember = "CourseName";
            attendanceCourse.SelectedIndexChanged += attendanceCourse_SelectedIndexChanged;
            attendanceLecture.DataSource = LecturesDL.individualTeacherLectureNameONly(attendanceCourse.Text);
        }
        private void attendanceCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attendanceCourse.SelectedItem is TeacherCoursesBL selectedCourse)
            {
                String CourseName = selectedCourse.getCourseName();
                attendanceLecture.DataSource = LecturesDL.individualTeacherLectureNameONly(CourseName);
                attendanceLecture.DisplayMember = "Topic";
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("AttendanceId", "Attendance Id");
            dataGridView1.Columns.Add("StudentId", "Student Id");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("LectureTopic", "Lecture Topic");
            dataGridView1.Columns.Add("Status", "Status");
        }
        private void LoadLectureIntoGridView()
        {
            List<AttendanceBL> attendances = AttendanceDL.attendanceList();
            foreach (var attendance in attendances)
            {
                dataGridView1.Rows.Add(
                    attendance.getAttendanceID(),
                    attendance.getStudentID(),
                    attendance.getStudentName(),
                    attendance.getLectureTopic(),
                    attendance.getStatus()
                );
            }
        }
        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }
    }
}
