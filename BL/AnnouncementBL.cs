using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class AnnouncementBL
    {
        string title;
        string description;
        DateTime created;

        public int GridViewAnnounceID { get; set; }
        public string GridViewTitle {  get; set; }
        public string GridViewDescription { get; set; }
        public DateTime GridViewCreated { get; set; }

        public AnnouncementBL(int GridViewID,string gridViewTitle, string gridViewDescription, DateTime gridViewCreated)
        {
            GridViewTitle = gridViewTitle;
            GridViewDescription = gridViewDescription;
            GridViewCreated = gridViewCreated;
            this.GridViewAnnounceID = GridViewID;
        }

        public AnnouncementBL(string title, string description, DateTime created)
        {
            this.title = title;
            this.description = description;
            this.created = created;
        }
        public string getTitle() { return title; }
        public string getDescription() { return description; }
        public DateTime getCreated() { return created; }
        public void setTitle(string title) {  this.title = title; }
        public void setDescription(string description) {  this.description = description; }
        public void setCreated(DateTime created) {  this.created = created; }

    }
}
