using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.Interfaces
{
    internal interface IComplain
    {
        List<ComplaintsBL> complaintsByYou();
        List<ComplaintsBL> complaintsAgainstYou();
    }
}
