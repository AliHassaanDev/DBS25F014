using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_DeleteCourse : UserControl
    {
        public Admin_DeleteCourse()
        {
            InitializeComponent();
        }
        public void load()
        {
            CourseDL.loadCoursesList();
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = CourseDL.courses;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonComboBox2.Text != "")
                {
                    CourseDL.deleteCourse(CourseDL.getIDFromCourse(kryptonComboBox2.Text));
                    MessageBox.Show("Course deleted successfully!");

                    load();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
