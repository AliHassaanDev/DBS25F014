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

namespace FinalProjectDB.UI.Admin_UserControl
{
    public partial class Admin_TeachRequests : UserControl
    {
        public Admin_TeachRequests()
        {
            InitializeComponent();
            ConfigureGrid();
            LoadCourseRequests();
        }
        private void LoadCourseRequests()
        {
            string query = "SELECT cr.request_id, cr.request_by_teacher_id, c.course_title, cr.request_for_course_id, cr.status " +
                           "FROM courserequests cr INNER JOIN courses c ON cr.request_for_course_id = c.course_id " +
                           "WHERE cr.status = 'Pending'";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["request_id"],
                        reader["request_by_teacher_id"],
                        reader["course_title"],
                        reader["request_for_course_id"],
                        reader["status"]
                    );
                }
            }
        }
            private void ConfigureGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("RequestID", "Request ID");
            dataGridView1.Columns.Add("TeacherID", "Teacher ID");
            dataGridView1.Columns.Add("CourseTitle", "Course Title");
            dataGridView1.Columns.Add("CourseID", "Course ID");
            dataGridView1.Columns.Add("Status", "Status");

            DataGridViewButtonColumn approveButton = new DataGridViewButtonColumn();
            approveButton.Name = "Action";
            approveButton.HeaderText = "Action";
            approveButton.Text = "Approve";
            approveButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(approveButton);


            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Action"].Index)
            {
                int requestId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["RequestID"].Value);
                int teacherId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TeacherID"].Value);
                int courseId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["CourseID"].Value);

                ApproveRequest(requestId, teacherId, courseId);
            }
        }
        private void ApproveRequest(int requestId, int teacherId, int courseId)
        {
            try
            {
                string insertQuery = $"INSERT INTO teachercourses (teacher_id, course_id) VALUES ({teacherId}, {courseId})";
                DatabaseHelper.Instance.Update(insertQuery);
                string updateQuery = $"UPDATE courserequests SET status = 'Approved' WHERE request_id = {requestId}";
                DatabaseHelper.Instance.Update(updateQuery);

                MessageBox.Show("Request approved successfully!");
                LoadCourseRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
