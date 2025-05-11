using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FinalProjectDB.BL;
using FinalProjectDB.UI;
using MySql.Data.MySqlClient;

namespace FinalProjectDB.DL
{
    internal class TeacherProfileDL
    {
        public static void AddTeacherData(TeacherProfile teacher)
        {
            try
            {
                int userId = -1;
                string query1 = $"SELECT user_id FROM users WHERE users.username='{teacher.getUsername()}'";

                using (var reader = DatabaseHelper.Instance.getData(query1))
                {
                    if (reader.Read())
                    {
                        userId = reader.GetInt32("user_id");
                    }
                }

                if (userId == -1)
                {
                    MessageBox.Show("User not found.");
                }

                string query = $"INSERT INTO teachers VALUES ('{userId}','{teacher.getTeacherName()}'," +
                    $"'{teacher.getTeacherExperience()}','{teacher.getTeacherStudies()}'," +
                    $"'{teacher.getTeacherSubjects()}','{teacher.getUsername()}')";
                DatabaseHelper.Instance.Update(query);
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Database error: " + e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error adding teacher: " + e.Message);
            }
        }
        public static int getTeacherId(string username)
        {
            int teacherId = -1;

            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    using (var cmd = new MySqlCommand("GetTeacherIdFromName", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                teacherId = reader.GetInt32("teacher_id");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return teacherId;
        }

        public static void fileComplaint(int userID,String description)
        {
            try
            {
                string query = "INSERT INTO complaints (filed_by_user_id, against_user_id, description, status) " +
                   "VALUES (@filedBy, @against, @desc, @status)";

                using (var conn = DatabaseHelper.Instance.getConnection())
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@filedBy", getTeacherId(Login.user));
                    cmd.Parameters.AddWithValue("@against", userID);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@status", "Pending");

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("There was an error in filing the complaint: " + e.Message);
            }
        }
        
    }
}
