using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.DL;

namespace FinalProjectDB.BL
{
    internal class TeacherCoursesBL:CourseBL
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string CourseName {  get; set; }
        public TeacherCoursesBL() { }
        public int getTeacherId()
        {
            return TeacherId;
        }
        public void setTeacherId(int id)
        {
            this.TeacherId = id;
        }
        public override string ToString()
        {
            return getCourseName();
        }

    }
}
