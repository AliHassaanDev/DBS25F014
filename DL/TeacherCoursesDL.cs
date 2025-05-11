using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class TeacherCoursesDL
    {
        public static List<TeacherCoursesBL> assigned = new List<TeacherCoursesBL>();

        public static void loadAssignedTeachers()
        {
            assigned.Clear();
            var reader = DatabaseHelper.Instance.getData($"SELECT tc.teacher_id,t.teacher_name,course_title FROM teachercourses tc" +
                $" JOIN teachers t ON t.teacher_id = tc.teacher_id JOIN courses c ON tc.course_id = c.course_id");
            while (reader.Read())
            {
                TeacherCoursesBL data = new TeacherCoursesBL();
                {
                    data.TeacherId = Convert.ToInt32(reader["teacher_id"]);
                    data.TeacherName = reader["teacher_name"].ToString();
                    data.CourseName = reader["course_title"].ToString();
                }
                ;
                assigned.Add(data);
            }
        }
    }
}
