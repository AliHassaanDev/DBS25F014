using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FinalProjectDB.DL;

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_AllUsers : UserControl
    {
        public Admin_AllUsers()
        {
            InitializeComponent();
        }

        public void load(int id)
        {
            UserDL.GridViewLoadUsers(id);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = UserDL.users;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonComboBox1.Text != "")
                {

                    int role = 1;
                    if (kryptonComboBox1.Text == "Student") { role = 1; }
                    else if (kryptonComboBox1.Text == "Teacher") { role = 2; }
                    else if (kryptonComboBox1.Text == "Admin") { role = 3; }

                    load(role);

                    MessageBox.Show("Loaded successfully!");
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
