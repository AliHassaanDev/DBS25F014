using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class LecturesBL: CourseBL
    {
        int lectureId;
        int teacherId;
        int courseId;
        String topic;
        DateTime startTime;
        int duration;
        public LecturesBL() { }
        public LecturesBL(int teacherId, int courseId, String topic, DateTime startTime, int duration)
        {
            this.teacherId = teacherId;
            this.courseId = courseId;
            this.topic = topic;
            this.startTime = startTime;
            this.duration = duration;
        }
        public int getTeacherId()
        {
            return teacherId;
        }
        public int getCourseId()
        {
            return courseId;
        }
        public String getTopic()
        {
            return topic;
        }
        public DateTime getStartTime()
        {
            return startTime;
        }
        public int getDuration()
        {
            return duration;
        }
        public int getLectureId()
        {
            return lectureId;
        }
        public void setTeacherId(int teacherId)
        {
            this.teacherId = teacherId;
        }
        public void setCourseId(int courseId)
        {
            this.courseId = courseId;
        }
        public void setTopic(String topic)
        {
            this.topic = topic;
        }
        public void setStartTime(DateTime startTime)
        {
            this.startTime = startTime;
        }
        public void setDuration(int duration)
        {
            this.duration = duration;
        }
        public void setLectureId(int lectureId)
        {
            this.lectureId = lectureId;
        }

    }
}
