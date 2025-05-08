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
    public partial class Admin_AssignCourse : UserControl
    {
        public Admin_AssignCourse()
        {
            InitializeComponent();
        }

        public void load()
        {
            TeacherDL.loadteachers();
            kryptonComboBox1.DataSource = null;
            kryptonComboBox1.DataSource=TeacherDL.teacher_name;

            CourseDL.loadCoursesList();
            kryptonComboBox2.DataSource = null;
            kryptonComboBox2.DataSource = CourseDL.courses;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if(kryptonComboBox1.Text!="" && kryptonComboBox2.Text!="")
                {
                    int teacher_id=TeacherDL.getTeacherIDFromName(kryptonComboBox1.Text);
                    int course_id = CourseDL.getIDFromCourse(kryptonComboBox2.Text);

                    TeacherDL.assignCoursetoTeacher(teacher_id, course_id);

                    MessageBox.Show("Course assigned to teacher successfully!");

                    load();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
