using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class UserBL
    {
        public static string current_user;
        public static int current_user_id;
        public static int current_user_role_id;

        string email;
        string username;
        string password;
        int role;
        public UserBL(string email, string username, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public UserBL(string email, string username, string password,int role)
        {
            this.email = email;
            this.username = username;
            this.password = password;
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
        public void setEmail(string email) { this.email = email; }
        public void setPassword(string password) { this.password=password; }
        public void setUsername(string username) { this.username=username; }


    }
}
