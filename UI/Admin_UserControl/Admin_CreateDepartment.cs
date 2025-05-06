using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.BL;
using FinalProjectDB.DL;

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

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "")
                {
                    string name = kryptonTextBox1.Text;
                    DepartmentBL departmentBL = new DepartmentBL(name);

                    DepartmentDL.insertDepartment(departmentBL);

                    kryptonTextBox1.Clear();
                    MessageBox.Show("Department Added Successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
