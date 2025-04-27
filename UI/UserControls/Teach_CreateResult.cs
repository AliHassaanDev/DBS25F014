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
    public partial class Teach_CreateResult : UserControl
    {
        public Teach_CreateResult()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_studenttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Student ID")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_studenttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Student ID";
            }
        }
        private void enter_event_totaltxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Total Marks")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_totaltxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Total Marks";
            }
        }
        private void enter_event_obtainedtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Obtained Marks")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_obtainedtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Obtained Marks";
            }
        }
    }
}
