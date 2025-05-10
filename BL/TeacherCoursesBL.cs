using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class TeacherCoursesBL:CourseBL
    {
        private int TeacherId { get; set; }
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
