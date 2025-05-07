using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class TeacherProfile
    {
        private int TeacherID { get; set; }
        private String TeacherName { get; set; }
        private int Expereience { get; set; }
        private String Studies { get; set; }
        private String Subjects { get; set; }

        public TeacherProfile() { }

        public TeacherProfile(string teacherName, int expereience, string studies, string subjects)
        {
            this.TeacherName = teacherName;
            this.Expereience = expereience;
            this.Studies = studies;
            this.Subjects = subjects;
        }

        public int getTeacherID()
        {
            return TeacherID;
        }
        public String getTeacherName()
        {
            return TeacherName;
        }
        public int getTeacherExperience()
        {
            return Expereience;
        }
        public String getTeacherStudies()
        {
            return Studies;
        }
        public String getTeacherSubjects()
        {
            return Subjects;
        }
        public void setTeacherID(int id)
        {
            this.TeacherID = id;
        }

        public void setTeacherName(String name)
        {
            this.TeacherName = name;
        }
        public void setTeacherExperience(int exp)
        {
            this.Expereience = exp;
        }
        public void setTeacherStudies(String studies)
        {
            this.Studies = studies;
        }
        public void setTeacherSubjects(String subjects)
        {
            this.Subjects = subjects;
        }
    }
}
