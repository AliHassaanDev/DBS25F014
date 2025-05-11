using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FinalProjectDB.BL;
using FinalProjectDB.DL;
using Microsoft.Reporting.WinForms;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_AttendenceByStudent : UserControl
    {
        public Admin_AttendenceByStudent()
        {
            InitializeComponent();
        }

        public void loadCourses()
        {
            CourseDL.loadCoursesList();
            this.kryptonComboBox1.DataSource = null;
            this.kryptonComboBox1.DataSource = CourseDL.courses;
        }
        public void loadStudents()
        {
            StudentsDL.StudentsByCourses(kryptonComboBox1.Text);
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = StudentsDL.student;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            AttendanceReportDL.report1.Clear();
            AttendanceReportDL.loadAttendanceByStudent(kryptonComboBox2.Text);
            this.attendanceReportsBindingSource.DataSource = AttendanceReportDL.report1;
            this.reportViewer1.RefreshReport();
            loadCourses();
            loadStudents();
        }

        private void kryptonComboBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void kryptonComboBox2_DropDown(object sender, EventArgs e)
        {
            
        }

        private void kryptonComboBox1_DropDownClosed(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
