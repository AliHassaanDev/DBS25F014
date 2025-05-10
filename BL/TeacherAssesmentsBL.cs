using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class TeacherAssesmentsBL
    {
        int assessmentId;
        int courseId;
        String type;
        String description;
        DateTime startTime;
        DateTime dueTime;
        String courseTitle;
        public TeacherAssesmentsBL() { }
        public TeacherAssesmentsBL(int courseId, String type, String description, DateTime startTime, DateTime endTime)
        {
            this.courseId = courseId;
            this.type = type;
            this.description = description;
            this.startTime = startTime;
            this.dueTime = endTime;
        }
        public TeacherAssesmentsBL(int assesmentID,String courseTitle, String type, String description, DateTime startTime, DateTime endTime)
        {
            this.assessmentId = assesmentID;
            this.type = type;
            this.description = description;
            this.startTime = startTime;
            this.dueTime = endTime;
            this.courseTitle = courseTitle;
        }

        public int getCourseId()
        {
            return courseId;
        }
        public int getAssessmentId()
        {
            return assessmentId;
        }
        public int setAssessmentId(int assessmentId)
        {
            this.assessmentId = assessmentId;
            return assessmentId;
        }
        public String getCourseTitle()
        {
            return courseTitle;
        }
        public void setCourseTitle(String courseTitle)
        {
            this.courseTitle = courseTitle;
        }
        public String getType()
        {
            return type;
        }
        public String getDescription()
        {
            return description;
        }
        public DateTime getStartTime()
        {
            return startTime;
        }
        public DateTime getdueTime()
        {
            return dueTime;
        }
        public void setCourseId(int courseId)
        {
            this.courseId = courseId;
        }
        public void setType(String type)
        {
            this.type = type;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setStartTime(DateTime startTime)
        {
            this.startTime = startTime;
        }
        public void setDueTime(DateTime dueTime)
        {
            this.dueTime = dueTime;
        }
        public override string ToString()
        {
            return description;
        }


    }
}
