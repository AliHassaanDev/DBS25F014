using ComponentFactory.Krypton.Toolkit;
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
    public partial class Teach_UpdateLecture : UserControl
    {
        public Teach_UpdateLecture()
        {
            InitializeComponent();
        }

        private void Teach_UpdateLecture_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Lecture")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Lecture";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter New Lecture Topic")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter New Lecture Topic";
            }
        }

        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "Enter New Lecture Duration in Hours")
            {
                kryptonTextBox4.Text ="";
            }
        }
        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "")
            {
                kryptonTextBox4.Text ="Enter New Lecture Duration in Hours";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
