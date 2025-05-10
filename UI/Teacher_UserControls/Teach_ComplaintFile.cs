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

namespace FinalProjectDB.UI.UserControls
{
    public partial class Teach_ComplaintFile : UserControl
    {
        public Teach_ComplaintFile()
        {
            
            InitializeComponent();
            ComboBox1.Items.Add("Student");
            ComboBox1.Items.Add("Teacher");

        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("UserID", "User ID");
            dataGridView1.Columns.Add("UserName", "User Name");
        }
        private void LoadLectureIntoGridView()
        {
            List<UserBL> users = UserDL.complaintUsers(ComboBox1.Text);
            foreach (var user in users)
            {
                dataGridView1.Rows.Add(
                    user.getUserId(),
                    user.getUsername()
                );
            }
        }
        private void enter_event_usertxt(object sender, EventArgs e)
        {
            if (FileUserID.Text == "Enter User ID")
            {
                FileUserID.Text ="";
            }
        }

        private void leave_event_usertxt(object sender, EventArgs e)
        {
            if (FileUserID.Text == "")
            {
                FileUserID.Text ="Enter User ID";
            }
        }
        private void enter_event_descriptiontxt(object sender, EventArgs e)
        {
            if (FileDescription.Text == "Enter Complaint Description")
            {
                FileDescription.Text ="";
            }
        }

        private void leave_event_descriptiontxt(object sender, EventArgs e)
        {
            if (FileDescription.Text == "")
            {
                FileDescription.Text ="Enter Complaint Description";
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(FileUserID.Text);
            String description = FileDescription.Text;
            TeacherProfileDL.fileComplaint(userID, description);
            dataGridView1.Rows.Clear();
            LoadLectureIntoGridView();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
           
            ConfigureDataGridView();
            LoadLectureIntoGridView();
        }
    }
}
