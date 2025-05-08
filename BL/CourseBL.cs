using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class CourseBL
    {
        int courseId;
        string courseName;
        DateTime date;
        int creditHours;
        int dept_id;

        public int GridViewCourseID { get; set; }
        public string GridViewcourseName { get; set; }
        public DateTime GridViewdate { get; set; }
        public int GridViewcreditHours { get; set; }
        public int GridViewDept_id { get; set; }

        public CourseBL() { }
        public CourseBL(string courseName, DateTime date, int creditHours, int dept_id)
        {
            this.courseName = courseName;
            this.date = date;
            this.creditHours = creditHours;
            this.dept_id = dept_id;
        }
        public CourseBL(int id)
        {
            this.courseId=id;
        }

        public CourseBL(int GridViewCourseID, string GridViewcourseName,DateTime GridViewdate,int GridViewcreditHours,int GridViewDept_id)
        {
            this.GridViewCourseID = GridViewCourseID;
            this.GridViewcourseName = GridViewcourseName;
            this.GridViewdate = GridViewdate;
            this.GridViewcreditHours = GridViewcreditHours;
            this.GridViewDept_id = GridViewDept_id;
        }

        public int getCourseId() { return  this.courseId; }
        public void setCourseName(string courseName) { this.courseName = courseName; }
        public void setDate(DateTime date) { this.date = date;}
        public void setCreditHours(int creditHours) {  this.creditHours = creditHours;}
        public void setDept_id(int dept_id) { this.dept_id=dept_id;}

        public string getCourseName() { return this.courseName; }
        public DateTime getDate() { return this.date; }
        public int getCreditHours() { return this.creditHours; }
        public int getDept_id() { return this.dept_id; }
    }
}
