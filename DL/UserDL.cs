using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class UserDL
    {
        public static List<UserBL> students = new List<UserBL>();

        public static void AddStudent(UserBL student)
        {
            string query = $"CALL insert_in_users('{student.getUsername()}','{student.getPassword()}','{student.getEmail()}',1)";
            DatabaseHelper.Instance.Update(query);
        }
        public static bool Login(UserBL student)
        {
            string query = $"CALL get_password('{student.getUsername()}')";
            var reader=DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                if (BCrypt.Net.BCrypt.Verify(student.getPassword(), Convert.ToString(reader["hash_password"])))
                {
                    UserBL.current_user_id = Convert.ToInt32(reader["user_id"]);
                    UserBL.current_user = Convert.ToString(reader["username"]);
                    UserBL.current_user_role_id = Convert.ToInt32(reader["role_id"]);
                    return true;
                }
            }
            return false;
        }
    }
}
