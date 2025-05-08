using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class TeacherDL
    {
        public static List<TeacherBL> teachers = new List<TeacherBL>();
        public static List<string> teacher_name = new List<string>();

        public static void GridViewloadteachers()
        {
            teachers.Clear();
            string query = $"SELECT * FROM teachers";
            var reader=DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                teachers.Add(new TeacherBL(Convert.ToInt32(reader["teacher_id"]), Convert.ToString(reader["teacher_name"]),
                Convert.ToString(reader["experience"]),Convert.ToString(reader["studies"]),Convert.ToString(reader["subjects"])));
            }
        }

        public static void loadteachers()
        {
            teacher_name.Clear();
            string query = $"SELECT teacher_name FROM teachers";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                teacher_name.Add(Convert.ToString(reader["teacher_name"]));
            }
        }
        public static int getTeacherIDFromName(string name)
        {
            string query = $"SELECT teacher_id FROM teachers WHERE teacher_name='{name}'";
            var reader = DatabaseHelper.Instance.getData(query);
            reader.Read();
            return Convert.ToInt32(reader["teacher_id"]);
        }

        public static void assignCoursetoTeacher(int t_id,int c_id)
        {
            string query = $"INSERT INTO teachercourses (teacher_id,course_id) VALUES ({t_id},{c_id})";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
