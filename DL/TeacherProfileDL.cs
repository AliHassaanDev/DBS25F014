using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;
using FinalProjectDB.UI;
using MySql.Data.MySqlClient;

namespace FinalProjectDB.DL
{
    internal class TeacherProfileDL
    {
        public static void AddTeacherData(TeacherProfile teacher)
        {
            int userId = -1;
            String query1 = $"SELECT user_id FROM users WHERE users.username='{teacher.getTeacherName()}'";

            using (var reader = DatabaseHelper.Instance.getData(query1))
            {
                if (reader.Read())
                {
                    userId = reader.GetInt32("user_id");
                }
            }

            String query = $"INSERT INTO teachers VALUES ('{userId}','{teacher.getTeacherName()}'," +
                $"'{teacher.getTeacherExperience()}','{teacher.getTeacherStudies()}'," +
                $"'{teacher.getTeacherSubjects()}')";
            DatabaseHelper.Instance.Update(query);
        }
        public static int getTeacherId(String name)
        {
            int teacherId = -1;
            String query1 = $"SELECT teacher_id FROM teachers WHERE teachers.teacher_name='{name}'";
            using (var reader = DatabaseHelper.Instance.getData(query1))
            {
                if (reader.Read())
                {
                    teacherId = reader.GetInt32("teacher_id");
                }
            }
            return teacherId;
        }
        public static void fileComplaint(int userID,String description)
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
        
    }
}
