using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_CreateQuiz : UserControl
    {
        public Teach_CreateQuiz()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Quiz Course")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Quiz Course";
            }
        }
        private void enter_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Quiz Description")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Quiz Description";
            }
        }
        private void enter_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Quiz Duration in Hours")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_durationtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Quiz Duration in Hours";
            }
        }
    }
}
