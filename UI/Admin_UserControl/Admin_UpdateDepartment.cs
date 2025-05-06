using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_UpdateDepartment : UserControl
    {
        public Admin_UpdateDepartment()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter New Department Name")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_nametxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter New Department Name";
            }
        }

        public void load()
        {
            DepartmentDL.loadDepartmentsList();
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = DepartmentDL.department_list;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonComboBox2.Text != "")
                {
                    string dept = kryptonTextBox1.Text;
                    int id = DepartmentDL.getIDFromDept(kryptonComboBox2.Text);
                    DepartmentDL.updateDepartment(dept, id);

                    MessageBox.Show("Department updated successfully");

                    load();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
