using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class TeacherBL:UserBL
    {
        public int GridViewTeacherID {  get; set; }
        public string GridViewTeacherName {  get; set; }
        public string GridViewExperience {  get; set; }
        public string GridViewStudies {  get; set; }
        public string GridViewSubjects {  get; set; }

        public TeacherBL(int gridViewTeacherID, string gridViewTeacherName, string gridViewExperience, string gridViewStudies, string gridViewSubjects)
        {
            GridViewTeacherID = gridViewTeacherID;
            GridViewTeacherName = gridViewTeacherName;
            GridViewExperience = gridViewExperience;
            GridViewStudies = gridViewStudies;
            GridViewSubjects = gridViewSubjects;
        }

    }
}
