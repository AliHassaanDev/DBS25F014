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
    public partial class Teach_UpdateAssignment : UserControl
    {
        public Teach_UpdateAssignment()
        {
            InitializeComponent();
        }

        private void Teach_UpdateAssignment_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Assignment ID")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Assignment ID";
            }
        }

        private void enter_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Assignment Description")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_topictxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Assignment Description";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
