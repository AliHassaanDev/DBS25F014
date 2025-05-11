using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class StudentCoursesDL
    {
        public static List<BL.StudentCoursesBL> enrollments = new List<BL.StudentCoursesBL>();
        public static void loadStudentEnrollments(string course)
        {
            enrollments.Clear();
            var reader = DatabaseHelper.Instance.getData($"SELECT e.student_id,s.student_name,e.course_id,c.course_title FROM " +
                $"enrollments e JOIN student s ON s.student_id = e.student_id JOIN courses c ON c.course_id = e.course_id" +
                $" WHERE e.course_id = {CourseDL.getIDFromCourse(course)}");
            while (reader.Read())
            {
                StudentCoursesBL data = new StudentCoursesBL();
                {
                    data.studentId = Convert.ToInt32(reader["student_id"]);
                    data.studentName = reader["student_name"].ToString();
                    data.courseId = Convert.ToInt32(reader["course_id"]);
                    data.courseName = reader["course_title"].ToString();
                }
                ;
                enrollments.Add(data);
            }
        }
    }
}
