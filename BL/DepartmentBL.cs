using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class DepartmentBL
    {
        int id;
        string name;

        public int GridViewID { get; set; }
        public string GridViewName { get; set; }

        public DepartmentBL(int GridViewID, string GridViewName) 
        {
            this.GridViewID = GridViewID;
            this.GridViewName = GridViewName;
        }

        public DepartmentBL(string name)
        {
            this.name = name;
        }
        
        public int getId() { return id; }
        public string getName() { return name; }

        public void setId(int id) { this.id=id; }
        public void setName(string name) { this.name=name; }
    }
}
