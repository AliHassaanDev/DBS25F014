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
    public partial class Admin_DeleteAnnouncement : UserControl
    {
        public Admin_DeleteAnnouncement()
        {
            InitializeComponent();
        }

        public void load()
        {
            AnnouncementDL.loadAnnouncementList();
            kryptonComboBox2.DataSource = null;
            kryptonComboBox2.DataSource = AnnouncementDL.announcements_name;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonComboBox2.Text != "")
                {
                    string title=kryptonComboBox2.Text;
                    int id=AnnouncementDL.getIDFromAnnouncement(title);

                    AnnouncementDL.deleteAnnouncement(id);

                    MessageBox.Show("Announcement deleted successfully!");

                    load();
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
