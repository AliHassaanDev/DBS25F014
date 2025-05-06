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
    public partial class Admin_DeleteDepartment : UserControl
    {
        public Admin_DeleteDepartment()
        {
            InitializeComponent();
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
                if (kryptonComboBox2.Text != "")
                {
                    DepartmentDL.deleteDepartment(kryptonComboBox2.Text);
                    MessageBox.Show("Department deleted successfully!");

                    load();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
