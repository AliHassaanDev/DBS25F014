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

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_EnrolledStudents : UserControl
    {
        public Admin_EnrolledStudents()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            StudentCoursesDL.enrollments.Clear();
            StudentCoursesDL.loadStudentEnrollments(kryptonComboBox1.Text);
            this.enrollmentsBLBindingSource.DataSource = StudentCoursesDL.enrollments;
            this.reportViewer1.RefreshReport();
            loadCourses();
        }
        public void loadCourses()
        {
            CourseDL.loadCoursesList();
            this.kryptonComboBox1.DataSource = null;
            this.kryptonComboBox1.DataSource = CourseDL.courses;
        }
    }
}
