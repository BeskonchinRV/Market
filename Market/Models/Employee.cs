using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }


        public Employee(int employeeID, string login, string password, int roleID)
        {
            EmployeeID = employeeID;
            Login = login;
            Password = password;
            RoleID = roleID;
        }
    }
}
