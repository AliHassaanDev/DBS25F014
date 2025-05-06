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
    public partial class Teach_UpdateResult : UserControl
    {
        public Teach_UpdateResult()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
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
        private void enter_event_obtainedtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter New Obtained Marks")
            {
                kryptonTextBox2.Text ="";
            }
        }

        private void leave_event_obtainedtxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter New Obtained Marks";
            }
        }
    }
}
