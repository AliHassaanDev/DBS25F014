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
    internal class TeacherAssesmentsDL
    {
        public static void insertAssesment(TeacherAssesmentsBL teacher)
        {
            string query = "INSERT INTO assessments (course_id, type, description, start_time, due_time,teacher_id) " +
                           "VALUES (@courseId, @type, @description, @startTime, @dueTime,@teacherId)";

            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@courseId", teacher.getCourseId());
                    cmd.Parameters.AddWithValue("@type", teacher.getType());
                    cmd.Parameters.AddWithValue("@description", teacher.getDescription());
                    cmd.Parameters.AddWithValue("@startTime", teacher.getStartTime());
                    cmd.Parameters.AddWithValue("@dueTime", teacher.getdueTime());
                    cmd.Parameters.AddWithValue("@teacherId", TeacherProfileDL.getTeacherId(Login.user));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void updateAssesment(string description, DateTime startTime, DateTime dueTime, int assessmentID)
        {
            string query = "UPDATE assessments SET description = @description, start_time = @startTime, due_time = @dueTime WHERE assessment_id = @assessmentId";

            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@startTime", startTime);
                    cmd.Parameters.AddWithValue("@dueTime", dueTime);
                    cmd.Parameters.AddWithValue("@assessmentId", assessmentID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<TeacherAssesmentsBL> getAssesments()
        {
            String query = $"SELECT assessment_id,course_title,type,description,start_time,due_time FROM" +
                $" assessments INNER JOIN courses ON assessments.course_id = courses.course_id " +
                $"WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}'";
            List<TeacherAssesmentsBL> teacherAssesments = new List<TeacherAssesmentsBL>();
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        TeacherAssesmentsBL teacherAssesment = new TeacherAssesmentsBL();
                        while (reader.Read())
                        {
                            teacherAssesment.setAssessmentId(reader.GetInt32(0));
                            teacherAssesment.setCourseTitle(reader.GetString(1));
                            teacherAssesment.setType(reader.GetString(2));
                            teacherAssesment.setDescription(reader.GetString(3));
                            teacherAssesment.setStartTime(reader.GetDateTime(4));
                            teacherAssesment.setDueTime(reader.GetDateTime(5));
                            teacherAssesments.Add(teacherAssesment);
                        }
                    }
                }
            }
            return teacherAssesments;
        }
        public static List<TeacherAssesmentsBL> getAssesmentID(String courseName)
        {
            String query = $"SELECT assessment_id,course_title,type,description,start_time,due_time FROM" +
                $" assessments INNER JOIN courses ON assessments.course_id = courses.course_id " +
                $"WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}'";
            List<TeacherAssesmentsBL> teacherAssesments = new List<TeacherAssesmentsBL>();
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        TeacherAssesmentsBL teacherAssesment = new TeacherAssesmentsBL();
                        while (reader.Read())
                        {
                            teacherAssesment.setAssessmentId(reader.GetInt32(0));
                            teacherAssesment.setCourseTitle(reader.GetString(1));
                            teacherAssesment.setType(reader.GetString(2));
                            teacherAssesment.setDescription(reader.GetString(3));
                            teacherAssesment.setStartTime(reader.GetDateTime(4));
                            teacherAssesment.setDueTime(reader.GetDateTime(5));
                            teacherAssesments.Add(teacherAssesment);
                        }
                    }
                }
            }
            return teacherAssesments;
        }
        public static List<TeacherAssesmentsBL> viewSubmissions()
        {
            String query = $"SELECT course_title,type,description,start_time,due_time FROM" +
                $" assessments INNER JOIN courses ON assessments.course_id = courses.course_id " +
                $"WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}'";
            List<TeacherAssesmentsBL> teacherAssesments = new List<TeacherAssesmentsBL>();
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        TeacherAssesmentsBL teacherAssesment = new TeacherAssesmentsBL();
                        while (reader.Read())
                        {
                            teacherAssesment.setAssessmentId(reader.GetInt32(0));
                            teacherAssesment.setCourseTitle(reader.GetString(1));
                            teacherAssesment.setType(reader.GetString(2));
                            teacherAssesment.setDescription(reader.GetString(3));
                            teacherAssesment.setStartTime(reader.GetDateTime(4));
                            teacherAssesment.setDueTime(reader.GetDateTime(5));
                            teacherAssesments.Add(teacherAssesment);
                        }
                    }
                }
            }
            return teacherAssesments;
        }
        public static List<TeacherAssesmentsBL> IndividualTeacherAssessments(String course)
        {
            String query = $"SELECT description FROM" +
                $" assessments INNER JOIN courses ON assessments.course_id = courses.course_id " +
                $"WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}' AND courses.course_title='{course}'";
            List<TeacherAssesmentsBL> teacherAssesments = new List<TeacherAssesmentsBL>();
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        TeacherAssesmentsBL teacherAssesment = new TeacherAssesmentsBL();
                        while (reader.Read())
                        {
                            teacherAssesment.setDescription(reader.GetString(0));
                            teacherAssesments.Add(teacherAssesment);
                        }
                    }
                }
            }
            return teacherAssesments;
        }
        public static List<TeacherAssesmentsBL> viewSubmissionsByCondition(String courseName,String type)
        {
            String query = $"SELECT assessment_id,course_title,type,description,start_time,due_time FROM" +
                $" assessments INNER JOIN courses ON assessments.course_id = courses.course_id " +
                $"WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}' AND courses.course_title='{courseName}'" +
                $" AND assessments.type='{type}'";
            List<TeacherAssesmentsBL> teacherAssesments = new List<TeacherAssesmentsBL>();
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        TeacherAssesmentsBL teacherAssesment = new TeacherAssesmentsBL();
                        while (reader.Read())
                        {
                            teacherAssesment.setAssessmentId(reader.GetInt32(0));
                            teacherAssesment.setCourseTitle(reader.GetString(1));
                            teacherAssesment.setType(reader.GetString(2));
                            teacherAssesment.setDescription(reader.GetString(3));
                            teacherAssesment.setStartTime(reader.GetDateTime(4));
                            teacherAssesment.setDueTime(reader.GetDateTime(5));
                            teacherAssesments.Add(teacherAssesment);
                        }
                    }
                }
            }
            return teacherAssesments;
        }
        public static void deleteAssesment(int assessmentID)
        {
            string query = "DELETE FROM assessments WHERE assessment_id = @assessmentId";
            using (var conn = DatabaseHelper.Instance.getConnection())
            {
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@assessmentId", assessmentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}