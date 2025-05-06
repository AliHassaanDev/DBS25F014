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
    public partial class Admin_DeleteUser : UserControl
    {
        public Admin_DeleteUser()
        {
            InitializeComponent();
        }

        public void load()
        {
            UserDL.loadUsers();
            this.kryptonComboBox2.DataSource = null;
            this.kryptonComboBox2.DataSource = UserDL.user_names;
        }

        private void kryptonComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            if (kryptonComboBox2.Text != "")
            {
                string name = kryptonComboBox2.Text;
                int id = UserDL.getIDFromUsername(name);

                UserDL.deleteUser(id);

                MessageBox.Show("User deleted successfully!");

                load();
            }
        }
    }
}
