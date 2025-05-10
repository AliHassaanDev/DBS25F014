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
    public partial class Teach_YourComplaints : UserControl
    {
        public Teach_YourComplaints()
        {
            InitializeComponent();
            ConfigureDataGridView1();
            LoadLectureIntoGridView1();
            ConfigureDataGridView2();
            LoadLectureIntoGridView2();

        }
        private void ConfigureDataGridView1()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("ComplaintDate", "Complaint Date");
        }
        private void LoadLectureIntoGridView1()
        {
            List<ComplaintsBL> complaints = ComplaintsDL.complaintsAgainstYou();
            foreach (var complaint in complaints)
            {
                dataGridView1.Rows.Add(
                    complaint.getDescription(),
                    complaint.getDate()
                );
            }
        }
        private void ConfigureDataGridView2()
        {
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("UserName", "User Name");
            dataGridView2.Columns.Add("Description", "Description");
            dataGridView2.Columns.Add("ComplaintDate", "Complaint Date");
        }
        private void LoadLectureIntoGridView2()
        {
            List<ComplaintsBL> complaints = ComplaintsDL.complaintsByYou();
            foreach (var complaint in complaints)
            {
                dataGridView2.Rows.Add(
                    complaint.getComplainFor(),
                    complaint.getDescription(),
                    complaint.getDate()
                );
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}