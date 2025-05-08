using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class AnnouncementDL
    {
        public static List<AnnouncementBL> announcements = new List<AnnouncementBL>();
        public static List<string> announcements_name=new List<string>();

        public static void GridViewloadAnnouncementList()
        {
            announcements.Clear();
            string query = $"SELECT * FROM announcements";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                announcements.Add(new AnnouncementBL(Convert.ToInt32(reader["announce_id"]),
                    Convert.ToString(reader["title"]), Convert.ToString(reader["description"]),
                    Convert.ToDateTime(reader["created_at"])));
            }
        }

        public static void loadAnnouncementList()
        {
            announcements_name.Clear();
            string query = $"SELECT title FROM announcements";
            var reader=DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                announcements_name.Add(Convert.ToString(reader["title"]));
            }
        }
        public static int getIDFromAnnouncement(string acc_name)
        {
            string query = $"SELECT announce_id FROM announcements WHERE title='{acc_name}'";
            var reader= DatabaseHelper.Instance.getData(query);
            reader.Read();
            return Convert.ToInt32(reader["announce_id"]);
        }

        public static void CreateAnnouncement(AnnouncementBL announcement)
        {
            string query = $"INSERT INTO announcements (admin_id,title,description,created_at) VALUES ({UserBL.current_user_id},'{announcement.getTitle()}','{announcement.getDescription()}','{announcement.getCreated().ToString("yyyy-MM-dd HH:mm:ss")}')";
            DatabaseHelper.Instance.Update(query);
        }
        public static void deleteAnnouncement(int id)
        {
            string query = $"DELETE FROM announcements WHERE announce_id={id}";
            DatabaseHelper.Instance.Update(query);
        }
        public static void UpdateAnnouncement(AnnouncementBL announcement,int id)
        {
            string query = $"UPDATE `final_project`.`announcements` SET  `admin_id` = '{UserBL.current_user_id}', `title` = '{announcement.getTitle()}', `description` = '{announcement.getDescription()}', `created_at` = '{announcement.getCreated().ToString("yyyy-MM-dd HH:mm:ss")}' WHERE (`announce_id` = '{id}')";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
