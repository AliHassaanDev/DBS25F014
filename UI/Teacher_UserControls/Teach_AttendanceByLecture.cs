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
