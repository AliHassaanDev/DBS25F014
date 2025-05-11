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
    public partial class Admin_AssignedTeachers : UserControl
    {
        public Admin_AssignedTeachers()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadteachers()
        {
            TeacherCoursesDL.assigned.Clear();
            TeacherCoursesDL.loadAssignedTeachers();
           // this.teacherBLBindingSource.DataSource = TeacherDL.teachers;
            this.reportViewer1.RefreshReport();
        }
    }
}
