using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class ComplaintsBL
    {
        String complainFor;
        String description;
        DateTime date;
        public ComplaintsBL() { }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setComplainFor(String complainFor)
        {
            this.complainFor = complainFor;
        }
        public String getComplainFor()
        {
            return complainFor;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }
        public String getDescription()
        {
            return description;
        }
        public DateTime getDate()
        {
            return date;
        }
    }
}
