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
using Microsoft.Reporting.WinForms;
using FinalProjectDB.BL;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_AttendanceByLecture : UserControl
    {
        public Teach_AttendanceByLecture()
        {
            InitializeComponent();
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

            AttendanceReportDL.loadAttendanceBylecture(kryptonComboBox2.Text);

            reportViewer1.LocalReport.ReportPath = "AttendanceByStudentReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", AttendanceReportDL.report1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.attendanceReportsBindingSource.DataSource = AttendanceReportDL.report2;
            this.reportViewer1.RefreshReport();
            loadCourses();
            MessageBox.Show(AttendanceReportDL.report2.Count.ToString());
        }
        public void loadCourses()
        {
            CourseDL.loadCoursesList();
            this.kryptonComboBox1.DataSource = null;
            this.kryptonComboBox1.DataSource = CourseDL.courses;
        }
        public void loadLectures()
        {
            LecturesDL.LecturesByCourses(kryptonComboBox1.Text);
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = LecturesDL.lecture;
        }
        private void kryptonComboBox2_DropDown(object sender, EventArgs e)
        {
          loadLectures();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
