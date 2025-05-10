using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.DL;
using FinalProjectDB.UI.Admin_UserControl;
using Google.Protobuf.Reflection;

namespace FinalProjectDB.BL
{
    internal class AttendanceReports
    {
        public string course {  get; set; }
        public string student {  get; set; }
        public string  lecture {  get; set; }
        public string status {  get; set; }

    }
}
