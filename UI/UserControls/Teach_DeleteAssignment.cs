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
    public partial class Teach_DeleteAssignment : UserControl
    {
        public Teach_DeleteAssignment()
        {
            InitializeComponent();
        }

        private void Teach_DeleteAssignment_Load(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_lecturetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Assignment ID")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_lecturetxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Assignment ID";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
