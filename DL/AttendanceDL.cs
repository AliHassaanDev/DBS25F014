using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;
using FinalProjectDB.UI;

namespace FinalProjectDB.DL
{
    internal class AttendanceDL
    {
        public static List<AttendanceBL> attendanceList()
        {
            List<AttendanceBL> attendance = new List<AttendanceBL>();
            String query = $"SELECT attendance.attendance_id,lecture.topic,attendance.student_id,student.student_name,attendance.status FROM attendance INNER JOIN student ON student.student_id=attendance.student_id INNER JOIN lecture ON lecture.lecture_id=attendance.lecture_id WHERE lecture.teacher_id={TeacherProfileDL.getTeacherId(Login.user)}";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    AttendanceBL attendanceBL = new AttendanceBL();
                    attendanceBL.setAttendanceID(reader.GetInt32("attendance_id"));
                    attendanceBL.setStudentID(reader.GetInt32("student_id"));
                    attendanceBL.setStudentName(reader.GetString("student_name"));
                    attendanceBL.setLectureTopic(reader.GetString("topic"));
                    attendanceBL.setStatus(reader.GetString("status"));
                    attendance.Add(attendanceBL);
                }
            }
            return attendance;
        }
    }
}