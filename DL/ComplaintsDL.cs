using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;
using FinalProjectDB.UI;

namespace FinalProjectDB.DL
{
    internal class ComplaintsDL
    {
        public static List<ComplaintsBL> complaintsAgainstYou()
        {
            List<ComplaintsBL> complaints = new List<ComplaintsBL>();
            string query = $"SELECT description,complaint_date FROM complaints WHERE against_user_id" +
                $"='{TeacherProfileDL.getTeacherId(Login.user)}'";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                ComplaintsBL complaint = new ComplaintsBL();
                {
                    complaint.setDescription(reader["description"].ToString());
                    complaint.setDate(Convert.ToDateTime(reader["complaint_date"].ToString()));


                };
                complaints.Add(complaint);
            }

            return complaints;
        }
        public static List<ComplaintsBL> complaintsByYou()
        {
            List<ComplaintsBL> complaints = new List<ComplaintsBL>();
            string query = $"SELECT username,description,complaint_date FROM complaints INNER JOIN" +
                $" users ON users.user_id=complaints.against_user_id WHERE filed_by_user_id" +
                $"='{TeacherProfileDL.getTeacherId(Login.user)}'";
            var reader = DatabaseHelper.Instance.getData(query);

            while (reader.Read())
            {
                ComplaintsBL complaint = new ComplaintsBL();
                {
                    complaint.setComplainFor(reader["username"].ToString());
                    complaint.setDescription(reader["description"].ToString());
                    complaint.setDate(Convert.ToDateTime(reader["complaint_date"].ToString()));


                };
                complaints.Add(complaint);
            }

            return complaints;
        }
    }
}
