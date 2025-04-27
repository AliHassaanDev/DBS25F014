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
    public partial class Teach_DeleteResult : UserControl
    {
        public Teach_DeleteResult()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_resulttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "Enter Result ID")
            {
                kryptonTextBox3.Text ="";
            }
        }

        private void leave_event_resulttxt(object sender, EventArgs e)
        {
            if (kryptonTextBox3.Text == "")
            {
                kryptonTextBox3.Text ="Enter Result ID";
            }
        }
    }
}
