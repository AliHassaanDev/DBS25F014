using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FinalProjectDB.BL;
using FinalProjectDB.UI;

namespace FinalProjectDB.DL
{
    internal class CourseDL
    {
        public static List<string> courses = new List<string>();

        public static void loadCoursesList()
        {
            courses.Clear();
            string query = $"SELECT * FROM finalproject.courses";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                courses.Add(Convert.ToString(reader["course_title"]));
            }
        }
        public static int getIDFromCourse(string course)
        {
            string query = $"SELECT course_id FROM finalproject.courses WHERE course_title='{course}'";
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
            string query = $"UPDATE `finalproject`.`courses` SET `course_title` = '{course.getCourseName()}', `end_date` = '{course.getDate().ToString("yyyy-MM-dd")}', `credit_hours` = '{course.getCreditHours()}', `department_id` = '{course.getDept_id()}' WHERE (`course_id` = '{course_id}')";
            DatabaseHelper.Instance.Update(query);
        }
        public static void deleteCourse(int course_id)
        {
            string query = $"DELETE FROM courses WHERE course_id={course_id}";
            DatabaseHelper.Instance.Update(query);
        }
        //teacher
        public static void addRequestedCourse(int teacherID,String courseName)
        {
            int courseId = -1;
            String query1 = $"SELECT course_id FROM courses WHERE courses.course_title='{courseName}'";

            using (var reader = DatabaseHelper.Instance.getData(query1))
            {
                if (reader.Read())
                {
                    courseId = reader.GetInt32("course_id");
                }
            }
            string query = $"INSERT INTO courserequests (request_by_teacher_id,request_for_course_id,status) VALUES ('{teacherID}','{courseId}','pending')";
            DatabaseHelper.Instance.Update(query);
        }
        public static void dropTeacherCourse(String courseName,int teacherID)
        {
            int courseId = -1;
            String query1 = $"SELECT course_id FROM courses WHERE courses.course_title='{courseName}'";
            using (var reader = DatabaseHelper.Instance.getData(query1))
            {
                if (reader.Read())
                {
                    courseId = reader.GetInt32("course_id");
                }
            }
            string query = $"DELETE FROM teachercourses WHERE course_id='{courseId}' AND teacher_id='{teacherID}'";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<TeacherCoursesBL> IndividualTeacherCourses(int teacherID)
        {
            List<TeacherCoursesBL> MyCourses = new List<TeacherCoursesBL>();

            string query = $"SELECT teacher_id, course_title FROM teachercourses " +
               $"INNER JOIN courses ON teachercourses.course_id = courses.course_id " +
               $"WHERE teachercourses.teacher_id = '{teacherID}'";


            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                TeacherCoursesBL course = new TeacherCoursesBL(); 
                {
                    course.TeacherId = int.Parse(reader["teacher_id"].ToString());
                    course.CourseName = reader["course_title"].ToString();

                };
                MyCourses.Add(course);
            }

            return MyCourses;
        }
        
        public static List<CourseBL> AllAvailableCourses()
        {
            List<CourseBL> AllCourses = new List<CourseBL>();
            string query = "SELECT * FROM courses";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                CourseBL course = new CourseBL();
                course.setCourseName(reader["course_title"].ToString());
                course.setCreditHours(int.Parse(reader["credit_hours"].ToString()));
                course.setDate(DateTime.Parse(reader["end_date"].ToString()));
                course.setDept_id(int.Parse(reader["department_id"].ToString()));
                AllCourses.Add(course);
            }
            return AllCourses;
        }
    }
}
