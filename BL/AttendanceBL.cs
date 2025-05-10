using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class AttendanceBL
    {
        int attendanceID;
        int studentID;
        int lectureID;
        String status;
        String lectureTopic;
        String studentName;

        public AttendanceBL() { }
        public AttendanceBL(int studentID, int lectureID, String status, String lectureTopic, String studentName)
        {
            this.studentID = studentID;
            this.lectureID = lectureID;
            this.status = status;
            this.lectureTopic = lectureTopic;
            this.studentName = studentName;
        }
        public int getAttendanceID()
        {
            return attendanceID;
        }
        public void setAttendanceID(int attendanceID)
        {
            this.attendanceID = attendanceID;
        }
        public int getStudentID()
        {
            return studentID;
        }
        public void setStudentID(int studentID)
        {
            this.studentID = studentID;
        }
        public int getLectureID()
        {
            return lectureID;
        }
        public void setLectureID(int lectureID)
        {
            this.lectureID = lectureID;
        }
        public String getStatus()
        {
            return status;
        }
        public void setStatus(String status)
        {
            this.status = status;
        }
        public String getLectureTopic()
        {
            return lectureTopic;
        }
        public void setLectureTopic(String lectureTopic)
        {
            this.lectureTopic = lectureTopic;
        }
        public String getStudentName()
        {
            return studentName;
        }
        public void setStudentName(String studentName)
        {
            this.studentName = studentName;
        }
    }
}
