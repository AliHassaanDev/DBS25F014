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
    public partial class Teach_ComplaintFile : UserControl
    {
        public Teach_ComplaintFile()
        {
            InitializeComponent();
        }
        private void enter_event_usertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter User ID")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_usertxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter User ID";
            }
        }
        private void enter_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Complaint Description")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Complaint Description";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
