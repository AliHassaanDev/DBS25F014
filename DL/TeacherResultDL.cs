using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;
using FinalProjectDB.UI;

namespace FinalProjectDB.DL
{
    internal class TeacherResultDL
    {
        public static void InsertResult(int studentID, int assessmentID,decimal obtainedMarks, decimal totalMarks)
        {
            String query=$"INSERT INTO results(student_id,assessment_id,obtained_marks,total_marks)" +
                $" VALUES ('{studentID}', '{assessmentID}','{obtainedMarks}', '{totalMarks}')";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<TeacherResultBL> resultEnrollmentList(String courseName)
        {
            List<TeacherResultBL> resultEnrollments = new List<TeacherResultBL>();
            String query = $"SELECT assessments.assessment_id,student.student_id,courses.course_title,student.student_name,assessments.type" +
                $" FROM enrollments INNER JOIN student ON student.student_id=enrollments.student_id INNER JOIN " +
                $"courses ON courses.course_id=enrollments.course_id" +
                $" INNER JOIN assessments ON assessments.course_id=courses.course_id WHERE assessments.teacher_id='{TeacherProfileDL.getTeacherId(Login.user)}' AND course_title='{courseName}'";
            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    TeacherResultBL enroll = new TeacherResultBL();
                    enroll.setAssessmentID(reader.GetInt32("assessment_id"));
                    enroll.setStudentID(reader.GetInt32("student_id"));
                    enroll.setStudentName(reader.GetString("student_name"));
                    enroll.setCourseName(reader.GetString("course_title"));
                    enroll.setType(reader.GetString("type"));
                    resultEnrollments.Add(enroll);
                }
            }
            return resultEnrollments;
        }
        public static List<TeacherResultBL> resultList(String courseName)
        {
            List<TeacherResultBL> resultEnrollments = new List<TeacherResultBL>();
            String query = $"SELECT results.result_id, assessments.assessment_id, student.student_id, " +
    $"courses.course_title, student.student_name, assessments.type, " +
    $"results.obtained_marks, results.total_marks " +
    $"FROM enrollments " +
    $"INNER JOIN student ON student.student_id = enrollments.student_id " +
    $"INNER JOIN courses ON courses.course_id = enrollments.course_id " +
    $"INNER JOIN assessments ON assessments.course_id = courses.course_id " +
    $"INNER JOIN results ON results.student_id = student.student_id AND results.assessment_id = assessments.assessment_id " +
    $"WHERE assessments.teacher_id = '{TeacherProfileDL.getTeacherId(Login.user)}' AND course_title = '{courseName}'";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    TeacherResultBL enroll = new TeacherResultBL();
                    enroll.setResultID(reader.GetInt32("result_id"));
                    enroll.setAssessmentID(reader.GetInt32("assessment_id"));
                    enroll.setStudentID(reader.GetInt32("student_id"));
                    enroll.setStudentName(reader.GetString("student_name"));
                    enroll.setCourseName(reader.GetString("course_title"));
                    enroll.setType(reader.GetString("type"));
                    enroll.setObtainedMarks(reader.GetDecimal("obtained_marks"));
                    enroll.setTotalMarks(reader.GetDecimal("total_marks"));
                    resultEnrollments.Add(enroll);
                }
            }
            return resultEnrollments;
        }
        public static void UpdateResult(int studentID, int assessmentID, decimal obtainedMarks)
        {
            String query = $"UPDATE results SET obtained_marks='{obtainedMarks}' " +
                $"WHERE student_id='{studentID}' AND assessment_id='{assessmentID}'";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteResult(int assessmentID,int resultID)
        {
            String query = $"DELETE FROM results WHERE result_id='{resultID}' AND assessment_id='{assessmentID}'";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<TeacherResultBL> resultList(string courseTitle, string assessmentDescription)
        {
            List<TeacherResultBL> resultList = new List<TeacherResultBL>();

            string query = $@"
        SELECT results.result_id, results.student_id, results.assessment_id, 
               results.obtained_marks, results.total_marks
        FROM results
        INNER JOIN assessments ON results.assessment_id = assessments.assessment_id
        INNER JOIN courses ON assessments.course_id = courses.course_id
        INNER JOIN enrollments ON results.student_id = enrollments.student_id AND courses.course_id = enrollments.course_id
        WHERE courses.course_title = '{courseTitle}'
          AND assessments.description = '{assessmentDescription}'
          AND assessments.teacher_id = '{TeacherProfileDL.getTeacherId(Login.user)}'";

            using (var reader = DatabaseHelper.Instance.getData(query))
            {
                while (reader.Read())
                {
                    TeacherResultBL result = new TeacherResultBL();
                    result.setResultID(reader.GetInt32("result_id"));
                    result.setStudentID(reader.GetInt32("student_id"));
                    result.setAssessmentID(reader.GetInt32("assessment_id"));
                    result.setObtainedMarks(reader.GetDecimal("obtained_marks"));
                    result.setTotalMarks(reader.GetDecimal("total_marks"));
                    resultList.Add(result);
                }
            }

            return resultList;
        }

    }
}