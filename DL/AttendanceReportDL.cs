using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class AttendanceReportDL
    {
        public static List<AttendanceReports> report1 = new List<AttendanceReports>();
        public static List<AttendanceReports> report2 = new List<AttendanceReports>();

        public static void loadAttendanceByStudent(string name)
        {
            report1.Clear();
            var reader = DatabaseHelper.Instance.getData($"SELECT '{name}' AS student,(SELECT topic FROM lecture l WHERE l.lecture_id = a.lecture_id)" +
                $" AS lecture,status FROM attendance a WHERE a.student_id = {StudentsDL.getIDFromStudent(name)}");
            while (reader.Read())
            {
                AttendanceReports data = new AttendanceReports();
                {
                    data.student = reader["student"].ToString();
                    data.lecture = reader["lecture"].ToString();
                    data.status = reader["status"].ToString();
                };
                report1.Add(data);
            }
        }
        public static void loadAttendanceBylecture(string name)
        {
            report2.Clear();
            var reader = DatabaseHelper.Instance.getData($"SELECT (SELECT student_name FROM student s WHERE s.student_id = a.student_id)" +
                $" AS StudentName,{name} AS Lecture ,status FROM attendance a WHERE a.lecture_id = {LecturesDL.getIDFromLecture(name)}");
            while (reader.Read())
            {
                AttendanceReports data = new AttendanceReports();
                {
                    data.student = reader["StudentName"].ToString();
                    data.lecture = reader["Lecture"].ToString();
                    data.status = reader["status"].ToString();
                };
                report2.Add(data);
            }
        }
    }
}
