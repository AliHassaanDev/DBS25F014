using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_CreateDepartment : UserControl
    {
        public Admin_CreateDepartment()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Department Name")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Department Name";
            }
        }
    }
}
