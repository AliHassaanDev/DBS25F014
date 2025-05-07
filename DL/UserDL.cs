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
        public static List<string> user_names = new List<string>();

        public static void loadUsers()
        {
            user_names.Clear();
            string quer = $"SELECT username FROM users";
            var reader = DatabaseHelper.Instance.getData(quer);
            while (reader.Read())
            {
                user_names.Add(Convert.ToString(reader["username"]));
            }
        }
        public static int getIDFromUsername(string name)
        {
            string quer = $"SELECT user_id FROM users WHERE username='{name}'";
            var reader = DatabaseHelper.Instance.getData(quer);
            reader.Read();
            return Convert.ToInt32(reader["user_id"]);
        }

        public static void AddStudent(UserBL student)
        {
            string query = $"CALL insert_in_users('{student.getUsername()}','{student.getPassword()}','{student.getEmail()}',1)";
            DatabaseHelper.Instance.Update(query);
        }
        public static void AddUser(UserBL student)
        {
            string query = $"CALL insert_in_users('{student.getUsername()}','{student.getPassword()}','{student.getEmail()}',{student.getRole()})";
            DatabaseHelper.Instance.Update(query);
        }
        public static void deleteUser(int id)
        {
            string query = $"DELETE FROM users WHERE user_id={id}";
            DatabaseHelper.Instance.Update(query);
        }


        public static bool Login(UserBL student)
        {
            string query = $"CALL get_password('{student.getUsername()}')";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
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
        //teacher
        public static String getEmail()
        {
            String email = "";
            string query = $"SELECT email FROM users WHERE username='{UserBL.current_user}'";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                email = Convert.ToString(reader["email"]);
            }
            return email;
        }
        //teacher
        public static List<UserBL> complaintUsers(String role)
        {
            int roleID = -1;
            if (role == "Student")
            {
                roleID = 1;
            }
            else if (role == "Teacher")
            {
                roleID = 2;
            }
            List<UserBL> users = new List<UserBL>();
            string query = $"SELECT user_id,username FROM users WHERE role_id='{roleID}'";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                UserBL user = new UserBL();
                user.setUserId(Convert.ToInt32(reader["user_id"]));
                user.setUsername(Convert.ToString(reader["username"]));
                users.Add(user);
            }
            return users;
        }
    }
}