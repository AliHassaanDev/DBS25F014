using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.DL
{
    internal class TeacherCoursesBL
    {
        private int TeacherId { get; set; }
        private String CourseName { get; set; }
        public TeacherCoursesBL() { }
        public int getTeacherId()
        {
            return TeacherId;
        }
        public String getCourseName()
        {
            return CourseName;
        }
        public void setTeacherId(int id)
        {
            this.TeacherId = id;
        }
        public void setCourseName(String name)
        {
            this.CourseName = name;
        }
        public override string ToString()
        {
            return getCourseName();
        }

    }
}
