using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_CreateCourse : UserControl
    {
        public Admin_CreateCourse()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Course Title")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Course Title";
            }
        }

        private void enter_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Credit Hours")
            {
                kryptonTextBox2.Text ="";
            }
        }
        private void leave_event_hourstxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Credit Hours";
            }
        }
    }
}
