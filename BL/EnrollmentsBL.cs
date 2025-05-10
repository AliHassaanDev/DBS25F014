using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class EnrollmentsBL
    {
        int studentID;
        int courseID;
        String courseTitle;
        String studentName;
        DateTime enrollmentDate;
        public EnrollmentsBL() { }
        public EnrollmentsBL(int studentID, int courseID, String courseTitle, String studentName, DateTime enrollmentDate)
        {
            this.studentID = studentID;
            this.courseID = courseID;
            this.courseTitle = courseTitle;
            this.studentName = studentName;
            this.enrollmentDate = enrollmentDate;
        }
        public String getCourseTitle()
        {
            return courseTitle;
        }
        public void setCourseTitle(String courseTitle)
        {
            this.courseTitle = courseTitle;
        }
        public String getStudentName()
        {
            return studentName;
        }
        public void setStudentName(String studentName)
        {
            this.studentName = studentName;
        }
        public int getStudentID()
        {
            return studentID;
        }
        public void setStudentID(int studentID)
        {
            this.studentID = studentID;
        }
        public int getCourseID()
        {
            return courseID;
        }
        public void setCourseID(int courseID)
        {
            this.courseID = courseID;
        }
        public DateTime getEnrollmentDate()
        {
            return enrollmentDate;
        }
        public void setEnrollmentDate(DateTime enrollmentDate)
        {
            this.enrollmentDate = enrollmentDate;
        }

    }
}
