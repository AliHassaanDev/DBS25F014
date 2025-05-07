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
namespace FinalProjectDB.UI.UserControls
{
    public partial class Profile : UserControl
    {
        public Profile()
        {
            InitializeComponent();
            label1.Text = Login.user;
            label3.Text = UserDL.getEmail();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
