using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_CreateLecture : UserControl
    {
        public Teach_CreateLecture()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Lecture Course")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Lecture Course";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Lecture Topic")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Lecture Topic";
            }
        }

        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "Enter Lecture Duration in Hours")
            {
                kryptonTextBox4.Text ="";
            }
        }
        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "")
            {
                kryptonTextBox4.Text ="Enter Lecture Duration in Hours";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
