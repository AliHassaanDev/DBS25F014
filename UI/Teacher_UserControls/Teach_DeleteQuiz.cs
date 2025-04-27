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
    public partial class Teach_DeleteQuiz : UserControl
    {
        public Teach_DeleteQuiz()
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
    }
}
