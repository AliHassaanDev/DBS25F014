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
            if (kryptonTextBox1.Text == "Enter Your Name")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Your Name";
            }
        }
        private void enter_event_experiencetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Experience in Years")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_experiencetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Experience in Years";
            }
        }
        private void enter_event_studytxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Your Studies")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_studytxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Your Studies";
            }
        }
        private void enter_event_subjecttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox4.Text == "Enter Your Subject")
            {
                kryptonTextBox4.Text ="";
            }
        }

        private void leave_event_subjecttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Your Subject";
            }
        }
    }
}
