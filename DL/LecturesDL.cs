using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using FinalProjectDB.BL;
using FinalProjectDB.UI;
using MySql.Data.MySqlClient;
using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;

namespace FinalProjectDB.DL
{
    internal class LecturesDL
    {
        public static List<string> lecture = new List<string>();
        public static void validCourse(String courseName)
        {
            String query = $"SELECT course_title FROM courses INNER JOIN teachercourses ON courses.course_id=" +
                $"teachercourses.course_id WHERE courses.course_title='{courseName}'";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                if (Convert.ToString(reader["course_title"]) != courseName)
                {
                    throw new Exception("You does not teach this course");
                }
            }
        }
        public static void AddLecture(LecturesBL lecture)
        {
            string query = @"INSERT INTO finalproject.lecture 
                     (course_id, teacher_id, topic, start_time, duration) 
                     VALUES (@courseId, @teacherId, @topic, @startTime, @duration)";

            using (var conn = DatabaseHelper.Instance.getConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@courseId", lecture.getCourseId());
                cmd.Parameters.AddWithValue("@teacherId", lecture.getTeacherId());
                cmd.Parameters.AddWithValue("@topic", lecture.getTopic());
                cmd.Parameters.AddWithValue("@startTime", lecture.getStartTime());
                cmd.Parameters.AddWithValue("@duration", lecture.getDuration());

                cmd.ExecuteNonQuery();
            }
        }
        public static void updateLecture(int lectureId, string topic, DateTime startTime, int duration)
        {
            string query = @"UPDATE lecture 
                     SET topic = @topic, start_time = @startTime, duration = @duration 
                     WHERE lecture_id = @lectureId";

            using (var conn = DatabaseHelper.Instance.getConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@topic", topic);
                cmd.Parameters.AddWithValue("@startTime", startTime);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@lectureId", lectureId);

                cmd.ExecuteNonQuery();
            }
        }


        public static int getCourseId(String course)
        {
            int courseId = -1;
            String query1 = $"SELECT course_id FROM courses WHERE courses.course_title='{course}'";
            using (var reader = DatabaseHelper.Instance.getData(query1))
            {
                if (reader.Read())
                {
                    courseId = reader.GetInt32("course_id");
                }
            }
            return courseId;

        }
        public static List<LecturesBL> teacherLectures()
        {
            List<LecturesBL> lectures = new List<LecturesBL>();
            String query = $"SELECT lecture.lecture_id, lecture.teacher_id, lecture.topic, " +
                $"lecture.start_time,lecture.duration,courses.course_title FROM lecture " +
                $"JOIN courses ON courses.course_id" +
                $" = lecture.course_id WHERE lecture.teacher_id ={TeacherProfileDL.getTeacherId(Login.user)}";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                LecturesBL lecture = new LecturesBL();
                lecture.setLectureId(Convert.ToInt32(reader["lecture_id"]));
                lecture.setCourseName(Convert.ToString(reader["course_title"]));
                lecture.setTeacherId(Convert.ToInt32(reader["teacher_id"]));
                lecture.setTopic(Convert.ToString(reader["topic"]));
                lecture.setStartTime(Convert.ToDateTime(reader["start_time"]));
                lecture.setDuration(Convert.ToInt32(reader["duration"]));
                lectures.Add(lecture);
            }
            return lectures;
        }
        public static void deleteLecture(String topic)
        {
            string query = $"DELETE FROM lecture WHERE topic='{topic}'";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<LecturesBL> teacherLecturesByCourses(String selectedCourse)
        {
            List<LecturesBL> lectures = new List<LecturesBL>();
            String query = $"SELECT lecture.lecture_id, lecture.teacher_id, lecture.topic, " +
                $"lecture.start_time,lecture.duration,courses.course_title FROM lecture " +
                $"JOIN courses ON courses.course_id" +
                $" = lecture.course_id WHERE lecture.teacher_id ={TeacherProfileDL.getTeacherId(Login.user)} AND courses.course_title='{selectedCourse}'";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                LecturesBL lecture = new LecturesBL();
                lecture.setLectureId(Convert.ToInt32(reader["lecture_id"]));
                lecture.setCourseName(Convert.ToString(reader["course_title"]));
                lecture.setTeacherId(Convert.ToInt32(reader["teacher_id"]));
                lecture.setTopic(Convert.ToString(reader["topic"]));
                lecture.setStartTime(Convert.ToDateTime(reader["start_time"]));
                lecture.setDuration(Convert.ToInt32(reader["duration"]));
                lectures.Add(lecture);
            }
            return lectures;
        }
        public static List<TeacherCoursesBL> IndividualTeacherCoursesNameOnly(int teacherID)
        {
            List<TeacherCoursesBL> MyCourses = new List<TeacherCoursesBL>();

            string query = $"SELECT course_title FROM courses " +
               $"INNER JOIN lecture ON lecture.course_id = courses.course_id " +
               $"WHERE lecture.teacher_id = '{teacherID}'";


            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                TeacherCoursesBL course = new TeacherCoursesBL();
                {
                    course.CourseName = reader["course_title"].ToString();

                };
                MyCourses.Add(course);
            }

            return MyCourses;
        }
        public static void LecturesByCourses(string course)
        {
            lecture.Clear();
            string query = $"SELECT Distinct topic FROM lecture WHERE course_id ={CourseDL.getIDFromCourse(course)}";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                lecture.Add(Convert.ToString(reader["topic"]));
            }
        }
        public static int getIDFromLecture(string lecture)
        {
            string query = $"SELECT lecture_id FROM lecture WHERE topic='{lecture}'";
            var reader = DatabaseHelper.Instance.getData(query);
            reader.Read();
            return Convert.ToInt32(reader["lecture_id"]);
        }
    }
}