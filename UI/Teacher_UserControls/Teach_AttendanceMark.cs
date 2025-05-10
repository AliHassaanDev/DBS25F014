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
    public partial class Teach_AttendanceMark : UserControl
    {
        public Teach_AttendanceMark()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadLectureIntoGridView();
            attendanceCourse.DataSource = TeacherLecturesDL.IndividualTeacherCoursesNameOnly(TeacherProfileDL.getTeacherId(Login.user));
            attendanceCourse.DisplayMember = "CourseName";
            attendanceCourse.SelectedIndexChanged += attendanceCourse_SelectedIndexChanged;
            attendanceLecture.DataSource = TeacherLecturesDL.individualTeacherLectureNameONly(attendanceCourse.Text);
        }
        private void attendanceCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attendanceCourse.SelectedItem is TeacherCoursesBL selectedCourse)
            {
                String CourseName = selectedCourse.getCourseName();
                attendanceLecture.DataSource = TeacherLecturesDL.individualTeacherLectureNameONly(CourseName);
                attendanceLecture.DisplayMember = "Topic";
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("StudentId", "Student ID");
            dataGridView1.Columns.Add("StudentName", "Student Name");
            dataGridView1.Columns.Add("CourseTitle", "Course Title");
            dataGridView1.Columns.Add("EnrollmentDate", "Enrollment Date");
        }
        private void LoadLectureIntoGridView()
        {
            List<EnrollmentsBL> enrollments = EnrollmentsDL.enrolledStudentsList();
            foreach (var students in enrollments)
            {
                dataGridView1.Rows.Add(
                    students.getStudentID(),
                    students.getStudentName(),
                    students.getCourseTitle(),
                    students.getEnrollmentDate()
                );
            }
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_studenttxt(object sender, EventArgs e)
        {
            if (attendanceStudentID.Text == "Enter Student ID")
            {
                attendanceStudentID.Text ="";
            }
        }

        private void leave_event_studenttxt(object sender, EventArgs e)
        {
            if (attendanceStudentID.Text == "")
            {
                attendanceStudentID.Text ="Enter Student ID";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int studentId =Convert.ToInt32(attendanceStudentID.Text);
            String courseName = attendanceCourse.Text;
            String lectureName = attendanceLecture.Text;
            String attendancestatus = attendanceStatus.Text;
            int lectureID = TeacherLecturesDL.getLectureId(lectureName);
            EnrollmentsDL.insertAttendance(studentId,lectureID,attendancestatus);
        }
    }
}
