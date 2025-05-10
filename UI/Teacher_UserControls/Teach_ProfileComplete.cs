using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.BL;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_ProfileComplete : UserControl
    {
        public Teach_ProfileComplete()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_nametxt(object sender, EventArgs e)
        {
            if (TeacherName.Text == "Enter Your Name")
            {
                TeacherName.Text ="";
            }
        }

        private void leave_event_nametxt(object sender, EventArgs e)
        {
            if (TeacherName.Text == "")
            {
                TeacherName.Text ="Enter Your Name";
            }
        }
        private void enter_event_experiencetxt(object sender, EventArgs e)
        {
            if (TeacherJobExperience.Text == "Enter Experience in Years")
            {
                TeacherJobExperience.Text ="";
            }
        }

        private void leave_event_experiencetxt(object sender, EventArgs e)
        {
            if (TeacherJobExperience.Text == "")
            {
                TeacherJobExperience.Text ="Enter Experience in Years";
            }
        }
        private void enter_event_studytxt(object sender, EventArgs e)
        {
            if (TeacherStudies.Text == "Enter Your Studies")
            {
                TeacherStudies.Text ="";
            }
        }

        private void leave_event_studytxt(object sender, EventArgs e)
        {
            if (TeacherStudies.Text == "")
            {
                TeacherStudies.Text ="Enter Your Studies";
            }
        }
        private void enter_event_subjecttxt(object sender, EventArgs e)
        {
            if (TeacherSubjects.Text == "Enter Your Subject")
            {
                TeacherSubjects.Text ="";
            }
        }

        private void leave_event_subjecttxt(object sender, EventArgs e)
        {
            if (TeacherStudies.Text == "")
            {
                TeacherStudies.Text ="Enter Your Subject";
            }
        }

        public void kryptonButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            String name = TeacherName.Text;
            String userName=teacherUserName.Text;
            int exp = Convert.ToInt32(TeacherJobExperience.Text);
            String studies = TeacherStudies.Text;
            String subjects = TeacherSubjects.Text;
            TeacherProfile t1 = new TeacherProfile(userName,name, exp, studies, subjects);
            TeacherProfileDL.AddTeacherData(t1);
        }
    }
}
