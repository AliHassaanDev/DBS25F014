using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectDB.BL;

namespace FinalProjectDB.DL
{
    internal class DepartmentDL
    {
        public static List<string> department_list = new List<string>();
        public static void loadDepartmentsList()
        {
            department_list.Clear();
            string query = $"SELECT * FROM final_project.departments";
            var reader=DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
                department_list.Add(Convert.ToString(reader["dept_name"]));
            }
        }
        public static int getIDFromDept(string dept)
        {
            string query = $"SELECT department_id FROM final_project.departments WHERE dept_name='{dept}'";
            var reader= DatabaseHelper.Instance.getData(query);
            reader.Read();
            return Convert.ToInt32(reader["department_id"]);
        }

        public static void insertDepartment(DepartmentBL departmentBL)
        {
            string query = $"CALL insert_into_dept('{departmentBL.getName()}');";
            DatabaseHelper.Instance.Update(query);
        }

        public static void deleteDepartment(string dept) 
        {
            string query = $"CALL delete_dept('{dept}');";
            DatabaseHelper.Instance.Update(query);
        }

        public static void updateDepartment(string dept,int id)
        {
            string query = $"UPDATE `final_project`.`departments` SET `dept_name` = '{dept}' WHERE (`department_id` = {id})";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
