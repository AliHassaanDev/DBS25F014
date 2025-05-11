using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FinalProjectDB.BL
{
    internal class SubmissionDisplayBL
    {
        int SubmissionID { get; set; }
        String studentName { get; set; }
        String description { get; set; }
        int AssessmentID { get; set; }
        int StudentID { get; set; }
        DateTime SubmittedAt { get; set; }
        byte[] FileData { get; set; }

        public SubmissionDisplayBL() { }

        public SubmissionDisplayBL(int submissionID, String studentName, String description, int assessmentID, int studentID, DateTime submittedAt, byte[] fileData)
        {
            SubmissionID = submissionID;
            this.studentName = studentName;
            this.description = description;
            AssessmentID = assessmentID;
            StudentID = studentID;
            SubmittedAt = submittedAt;
            FileData = fileData;
        }
        public int GetSubmissionID()
        {
            return SubmissionID;
        }
        public int GetAssessmentID()
        {
            return AssessmentID;
        }
        public int GetStudentID()
        {
            return StudentID;
        }
        public DateTime GetSubmittedAt()
        {
            return SubmittedAt;
        }
        public byte[] GetFileData()
        {
            return FileData;
        }
        public void SetSubmissionID(int submissionID)
        {
            SubmissionID = submissionID;
        }
        public void SetAssessmentID(int assessmentID)
        {
            AssessmentID = assessmentID;
        }
        public void SetStudentID(int studentID)
        {
            StudentID = studentID;
        }
        public void SetSubmittedAt(DateTime submittedAt)
        {
            SubmittedAt = submittedAt;
        }
        public void SetFileData(byte[] fileData)
        {
            FileData = fileData;
        }
        public String GetStudentName()
        {
            return studentName;
        }
        public String GetDescription()
        {
            return description;
        }
        public void SetStudentName(String studentName)
        {
            this.studentName = studentName;
        }
        public void SetDescription(String description)
        {
            this.description = description;
        }


    }
}