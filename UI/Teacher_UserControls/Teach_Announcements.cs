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
    public partial class Teach_Announcements : UserControl
    {
        public Teach_Announcements()
        {
            InitializeComponent();
        }

        public void load()
        {
            AnnouncementDL.GridViewloadAnnouncementList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AnnouncementDL.announcements;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Teach_Announcements_Load(object sender, EventArgs e)
        {

        }
    }
}
