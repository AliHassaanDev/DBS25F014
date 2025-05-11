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
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

       
      
        private void kryptonButton2_Click(object sender, EventArgs e)
        {

            AttendanceReportDL.report2.Clear();
            AttendanceReportDL.loadAttendanceBylecture(attendanceLecture.Text);
            this.attendanceReportsBindingSource.DataSource = AttendanceReportDL.report2;
            this.reportViewer1.RefreshReport();
            loadCourses();
            loadLectures();
        }
       public void loadCourses()
        {
            CourseDL.loadCoursesList();
            this.attendanceCourse.DataSource = null;
            this.attendanceCourse.DataSource = CourseDL.courses;
        }
        public void loadLectures()
        {
            TeacherLecturesDL.LecturesByCourses(attendanceCourse.Text);
            this.attendanceLecture.DataSource = null;
            this.attendanceLecture.DataSource = TeacherLecturesDL.lecture;
        }
       
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            ConfigureDataGridView();
            LoadLectureIntoGridView();

        }

        private void attendanceCourse_DropDownClosed(object sender, EventArgs e)
        {
            loadLectures();
        }
    }
}
