using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class TeacherResultBL:CourseBL
    {
        int resultID;
        int studentID;
        String studentName;
        String type;
        int assessmentID;
        decimal obtainedMarks;
        decimal totalMarks;
        public TeacherResultBL() { }
        public TeacherResultBL(int resultID, int studentID, String studentName, String type, int assessmentID, decimal obtainedMarks, decimal totalMarks)
        {
            this.resultID = resultID;
            this.studentID = studentID;
            this.studentName = studentName;
            this.type = type;
            this.assessmentID = assessmentID;
            this.obtainedMarks = obtainedMarks;
            this.totalMarks = totalMarks;
        }
        public int getResultID() { return resultID; }
        public void setResultID(int resultID) { this.resultID = resultID; }
        public String getStudentName() { return studentName; }
        public void setStudentName(String studentName) { this.studentName = studentName; }
        public String getType() { return type; }
        public void setType(String type) { this.type = type; }
        public int getStudentID() { return studentID; }
        public void setStudentID(int studentID) { this.studentID = studentID; }
        public int getAssessmentID() { return assessmentID; }
        public void setAssessmentID(int assessmentID) { this.assessmentID = assessmentID; }
        public decimal getObtainedMarks() { return obtainedMarks; }
        public void setObtainedMarks(decimal obtainedMarks) { this.obtainedMarks = obtainedMarks; }
        public decimal getTotalMarks() { return totalMarks; }
        public void setTotalMarks(decimal totalMarks) { this.totalMarks = totalMarks; }

    }
}
