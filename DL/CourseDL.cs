using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class CourseDL
    {
        public static List<CourseBL> list = new List<CourseBL>();
        public static List<string> courses = new List<string>();

        public static void loadGridviewlist()
        {
            list.Clear();
            string query = $"SELECT * FROM final_project.courses";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                list.Add(new CourseBL(Convert.ToInt32(reader["course_id"]),Convert.ToString(reader["course_title"]), Convert.ToDateTime(reader["end_date"]), Convert.ToInt32(reader["credit_hours"]), Convert.ToInt32(reader["department_id"])));
            }
        }
        public static void loadCoursesList()
        {
            courses.Clear();
            string query = $"SELECT * FROM final_project.courses";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                courses.Add(Convert.ToString(reader["course_title"]));
            }
        }
        public static int getIDFromCourse(string course)
        {
            string query = $"SELECT course_id FROM final_project.courses WHERE course_title='{course}'";
            var reader = DatabaseHelper.Instance.getData(query);
            reader.Read();
            return Convert.ToInt32(reader["course_id"]);
        }


        public static void CreateCourse(CourseBL course)
        {
            string query = $"INSERT INTO courses (course_title,end_date,credit_hours,department_id) VALUES ('{course.getCourseName()}','{course.getDate().ToString("yyyy-MM-dd")}',{course.getCreditHours()},{course.getDept_id()})";
            DatabaseHelper.Instance.Update(query);
        }

        public static void updateCourse(int course_id,CourseBL course)
        {
            string query = $"UPDATE `final_project`.`courses` SET `course_title` = '{course.getCourseName()}', `end_date` = '{course.getDate().ToString("yyyy-MM-dd")}', `credit_hours` = '{course.getCreditHours()}', `department_id` = '{course.getDept_id()}' WHERE (`course_id` = '{course_id}')";
            DatabaseHelper.Instance.Update(query);
        }
        public static void deleteCourse(int course_id)
        {
            string query = $"DELETE FROM courses WHERE course_id={course_id}";
            DatabaseHelper.Instance.Update(query);
        }
        public static void RegisterCourse(CourseBL course)
        {
            string query = $"INSERT INTO enrollments (student_id,course_id,enrolled_date) VALUES ({UserBL.current_user_id},{course.getCourseId()},NOW())";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
