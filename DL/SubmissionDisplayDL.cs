using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FinalProjectDB.BL;
using FinalProjectDB.UI;
using MySql.Data.MySqlClient;

namespace FinalProjectDB.DL
{
    internal class SubmissionDisplayDL:TeacherAssesmentsDL
    {
        public override void SubmissionDetails()
        {
            MessageBox.Show("Submission Details");

        }
        public static List<SubmissionDisplayBL> submissionsList(int courseID, String type)
        {
            try
            {
                List<SubmissionDisplayBL> submissions = new List<SubmissionDisplayBL>();
                String query = $@"
    SELECT 
        submissions.submission_id,
        submissions.submitted_at,
        student.student_name,
        assessments.description
    FROM submissions
    INNER JOIN student ON student.student_id = submissions.student_id
    INNER JOIN assessments ON assessments.assessment_id = submissions.assessment_id
    WHERE assessments.course_id = '{courseID}' AND assessments.type = '{type}'";

                using (var reader = DatabaseHelper.Instance.getData(query))
                {
                    while (reader.Read())
                    {
                        SubmissionDisplayBL submission = new SubmissionDisplayBL();
                        submission.SetSubmissionID(reader.GetInt32("submission_id"));
                        submission.SetStudentName(reader.GetString("student_name"));
                        submission.SetDescription(reader.GetString("description"));
                        submission.SetSubmittedAt(reader.GetDateTime("submitted_at"));
                        submissions.Add(submission);
                    }
                }
                return submissions;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
    }
    }