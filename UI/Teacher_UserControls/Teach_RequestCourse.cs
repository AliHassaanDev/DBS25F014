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
    public partial class Teach_RequestCourse : UserControl
    {
        public Teach_RequestCourse()
        {
            InitializeComponent();
        }

        private void enter_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Course You Want")
            {
                kryptonTextBox1.Text ="";
            }
        }

        private void leave_event_coursetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Course You Want";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
