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
    public partial class Admin_CreateAnnouncement : UserControl
    {
        public Admin_CreateAnnouncement()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enter_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "Enter Announcement Title")
            {
                kryptonTextBox1.Text ="";
            }
        }
        private void leave_event_titletxt(object sender, EventArgs e)
        {
            if (kryptonTextBox1.Text == "")
            {
                kryptonTextBox1.Text ="Enter Announcement Title";
            }
        }
        private void enter_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "Enter Announcement Description")
            {
                kryptonTextBox2.Text ="";
            }
        }
        private void leave_event_descriptiontxt(object sender, EventArgs e)
        {
            if (kryptonTextBox2.Text == "")
            {
                kryptonTextBox2.Text ="Enter Announcement Description";
            }
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kryptonTextBox1.Text != "" && kryptonTextBox2.Text != "")
                {
                    string title = kryptonTextBox1.Text;
                    string description = kryptonTextBox2.Text;
                    DateTime created= DateTime.Now;

                    AnnouncementBL announcement=new AnnouncementBL(title, description, created);

                    AnnouncementDL.CreateAnnouncement(announcement);

                    MessageBox.Show("Announcement created successfully!");

                    kryptonTextBox1.Clear();
                    kryptonTextBox2.Clear();
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
