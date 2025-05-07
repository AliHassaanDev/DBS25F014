using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FinalProjectDB.BL;
using FinalProjectDB.DL;
using Google.Protobuf.Reflection;
using MySql.Data.MySqlClient;

namespace FinalProjectDB.UI.Student_UserControl
{
    public partial class Stu_CourseRegister : UserControl
    {
        public Stu_CourseRegister()
        {
            InitializeComponent();
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                if (kryptonComboBox2.SelectedIndex != -1)
                {
                    string title = kryptonComboBox2.Text;
                    int id = CourseDL.getIDFromCourse(title);
                    CourseBL course = new CourseBL(id);

                    CourseDL.RegisterCourse(course);

                    MessageBox.Show("Course Registered Successfully!");

                    kryptonComboBox2.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
