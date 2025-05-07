using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class StudentsDL
    {
        public static List<StudentsBL> students = new List<StudentsBL>();
        public static void AddStudentInfo(StudentsBL s)
        {
            string formattedDate = s.GetDOB().ToString("yyyy-MM-dd");
            string query = $"UPDATE student SET student_name = '{s.GetStudentName()}', father_name = '{s.GetFatherName()}'," +
                $"cnic ='{s.GetCNIC()}',gender ='{s.GetGender()}', dob ='{formattedDate}',phoneno = '{s.GetPhoneNo()}',address = '{s.GetAddress()}' WHERE student_id ={s.GetStudentID()}";
            DatabaseHelper.Instance.Update(query);
        }
        public static void InsertStudent(StudentsBL s) 
        {
            string query = $"INSERT INTO student (student_id) VALUES ({s.GetStudentID()})";
            DatabaseHelper.Instance.Update(query);
        }
        public static bool userExists(int id)
        {
            string query = $"SELECT COUNT(*) FROM student WHERE student_id ={id}";
            var reader = DatabaseHelper.Instance.getData(query);
            if (reader.Read())
            {
                int count = Convert.ToInt32(reader[0]);
                return count > 0;
            }
            return false;
        }
    }
}
