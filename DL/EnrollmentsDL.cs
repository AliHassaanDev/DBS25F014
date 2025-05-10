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
    internal class EnrollmentsDL
    {
        public static List<EnrollmentsBL> enrolledStudentsList()
        {
            List<EnrollmentsBL> list = new List<EnrollmentsBL>();
            try
            {
                string query = $"SELECT student.student_id, student.student_name, courses.course_title, enrollments.enrolled_date " +
                    $"FROM enrollments " +
                    $"INNER JOIN student ON student.student_id = enrollments.student_id " +
                    $"INNER JOIN courses ON courses.course_id = enrollments.course_id " +
                    $"INNER JOIN teachercourses ON teachercourses.course_id = enrollments.course_id " +
                    $"WHERE teachercourses.teacher_id = '{TeacherProfileDL.getTeacherId(Login.user)}'";

                using (var conn = DatabaseHelper.Instance.getConnection())
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EnrollmentsBL enrollment = new EnrollmentsBL();
                        enrollment.setStudentID(reader.GetInt32(0));
                        enrollment.setStudentName(reader.GetString(1));
                        enrollment.setCourseTitle(reader.GetString(2));
                        enrollment.setEnrollmentDate(reader.GetDateTime(3));
                        list.Add(enrollment);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("There was an error in loading the enrollments: " + e.Message);
            }
            return list;
        }
        public static void insertAttendance(int studentID,int LectureID,String status)
        {
            String query = $"INSERT INTO attendance(student_id,lecture_id,status) VALUES('{studentID}','{LectureID}','{status}')";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
