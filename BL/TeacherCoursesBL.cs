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

        private int TeacherId { get; set; }
        private String TeacherName { get; set; }
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
        public void setTeacherName(String name)
        {
            this.TeacherName = name;
        }
        public String getTeacherName()
        {
            return TeacherName;
        }

    }
}
