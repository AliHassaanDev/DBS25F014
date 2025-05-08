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
        public static List<UserBL> users = new List<UserBL>();
        public static List<string> user_names = new List<string>();

        public static void loadUsers()
        {
            user_names.Clear();
            string quer = $"SELECT username FROM users";
            var reader = DatabaseHelper.Instance.getData(quer);
            while(reader.Read())
            {
                user_names.Add(Convert.ToString(reader["username"]));
            }
        }

        public static void GridViewLoadUsers(int role_id)
        {
            users.Clear();
            string quer = $"SELECT * FROM users WHERE role_id={role_id}";
            var reader = DatabaseHelper.Instance.getData(quer);
            while (reader.Read())
            {
                users.Add(new UserBL(Convert.ToInt32(reader["user_id"]),Convert.ToString(reader["email"]),
                    Convert.ToString(reader["username"]), Convert.ToString(reader["hash_password"])));
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

            int id = getIDFromUsername(student.getUsername());
            string query2 = "";
            query2 = $"INSERT INTO `final_project`.`student` (`student_id`) VALUES ('{id}')"; 
            DatabaseHelper.Instance.Update(query2);
        }
        public static void AddUser(UserBL student)
        {
            string query = $"CALL insert_in_users('{student.getUsername()}','{student.getPassword()}','{student.getEmail()}',{student.getRole()})";
            DatabaseHelper.Instance.Update(query);

            int id = getIDFromUsername(student.getUsername());
            if (student.getRole() == 2)
            {
                string query2 = $"INSERT INTO teachers (teacher_id) VALUES ({id})";
                DatabaseHelper.Instance.Update(query2);
            }
        }
        public static void deleteUser(int id)
        {
            string query = $"DELETE FROM users WHERE user_id={id}";
            DatabaseHelper.Instance.Update(query);
        }
        public static void updateUser(UserBL user,int id)
        {
            string query = $"UPDATE `final_project`.`users` SET `email` = '{user.getEmail()}', `username` = '{user.getUsername()}', `hash_password` = '{user.getPassword()}' WHERE (`user_id` = '{id}')";
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
                    UserBL.current_user_email = Convert.ToString(reader["email"]);
                    return true;
                }
            }
            return false;
        }
    }
}
