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
    public partial class Admin_AllDepartments : UserControl
    {
        public Admin_AllDepartments()
        {
            InitializeComponent();
        }

        public void load()
        {
            DepartmentDL.GridViewloadDepartmentsList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DepartmentDL.list;
            dataGridView1.AutoGenerateColumns=true;
        }
        private void Admin_AllDepartments_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
