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
    public partial class Teach_UpdateQuiz : UserControl
    {
        public Teach_UpdateQuiz()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_quiztxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Quiz ID")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_quiztxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Quiz ID";
            }
        }
        private void enter_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter New Quiz Description")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter New Quiz Description";
            }
        }
        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter New Quiz Duration in Hours")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter New Quiz Duration in Hours";
            }
        }
    }
}
