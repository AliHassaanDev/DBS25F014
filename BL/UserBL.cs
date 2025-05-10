using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace FinalProjectDB.BL
{
    internal class UserBL
    {
        public static string current_user;
        public static int current_user_id;
        public static int current_user_role_id;
        string email;
        protected string username;
        string password;
        int role;
        int user_id;

        public void setUserId(int id) { this.user_id = id; }
        public int getUserId() { return this.user_id; }

        public UserBL() { }
        public UserBL(string email, string username, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }
        public UserBL(String username)
        {
            this.username = username;
        }

        public UserBL(string email, string username, string password,int role)
        {
            this.email = email;
            this.username = username;
            this.password = password;
            if (role != 1 && role != 2 && role != 3) { return; }
            this.role = role;
        }
        public UserBL(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string getEmail() { return email; }
        public string getUsername() { return username; }
        public string getPassword() { return password; }
        public int getRole() { return role; }
        public void setEmail(string email) { this.email = email; }
        public void setPassword(string password) { this.password=password; }
        public void setUsername(string username) { this.username=username; }
        public void setRole(int role) { if (role!=1 && role!=2 && role!=3) { return; } this.role = role;}


    }
}
