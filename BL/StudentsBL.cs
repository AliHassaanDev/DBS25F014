using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectDB.BL
{
    internal class StudentsBL
    {
        private int studentID;
        private string studentName;
        private string fatherName;
        private string cnic;
        private string gender;
        private DateTime dob;
        private string phoneNo;
        private string address;

        public StudentsBL(int id,string studentName, string fatherName, string cnic, string gender, DateTime dob, string phoneNo, string address)
        {
            this.studentID = id;
            this.studentName = studentName;
            this.fatherName = fatherName;
            this.cnic = cnic;
            this.gender = gender;
            this.dob = dob;
            this.phoneNo = phoneNo;
            this.address = address;
        }

        public int GetStudentID() { return studentID; }
        public void SetStudentID(int id) { studentID = id; }
        public string GetStudentName() { return studentName; }
        public void SetStudentName(string name) { studentName = name; }
        public string GetFatherName() { return fatherName; }
        public void SetFatherName(string name) { fatherName = name; }
        public string GetCNIC() { return cnic; }
        public void SetCNIC(string cnic) { this.cnic = cnic; }
        public string GetGender() { return gender; }
        public void SetGender(string gender) { this.gender = gender; }
        public DateTime GetDOB() { return dob; }
        public void SetDOB(DateTime dob) { this.dob = dob; }
        public string GetPhoneNo() { return phoneNo;}
        public void SetPhoneNo(string phoneNo) { this.phoneNo = phoneNo; }
        public string GetAddress() { return address; }
        public void SetAddress(string address) { this.address = address; }
    }
}
