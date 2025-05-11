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
    public partial class Admin_AllTeachers : UserControl
    {
        public Admin_AllTeachers()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Admin_AllTeachers_Load(object sender, EventArgs e)
        {
            loadteachers();
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loadteachers()
        {
            TeacherDL.teachers.Clear();
            TeacherDL.GridViewloadteachers();
            this.teacherBLBindingSource.DataSource = TeacherDL.teachers;
            this.reportViewer1.RefreshReport();
        }
    }
}
