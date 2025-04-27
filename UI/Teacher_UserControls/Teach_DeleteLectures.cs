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
    public partial class Teach_DeleteLectures : UserControl
    {
        public Teach_DeleteLectures()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_lecturetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Lecture Topic")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_lecturetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Lecture Topic";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
