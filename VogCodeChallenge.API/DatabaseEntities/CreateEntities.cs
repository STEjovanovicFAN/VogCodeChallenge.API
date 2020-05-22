using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.DatabaseEntities
{
    public class CreateEntities
    {
        private List<Employee> Employees = new List<Employee>();

        public CreateEntities()
        {
            InitalizeEmployees();
        }

        private void InitalizeEmployees()
        {
            Employee A = new Employee
            {
                EmployeeFirstName = "John",
                EmployeeLastName = "Smith",
                EmployeeJobTitle = "Staff",
                EmployeeAddress = "101 yes street SW, Calgary Alberta",

                CompanyID = 1,
                CompanyName = "XTEAM",
                DepartmentID = 1
   
            };

            Employee B = new Employee
            {
                EmployeeFirstName = "Janna",
                EmployeeLastName = "Tytle",
                EmployeeJobTitle = "CEO",
                EmployeeAddress = "123 no street NE, Edmonton Alberta",

                CompanyID = 1,
                CompanyName = "XTEAM",
                DepartmentID = 3

            };

            Employees.Add(A);
            Employees.Add(B);
        }

        public IEnumerable<Employee> GetAll()
        {
            return Employees;
        }

        public IList<Employee> ListAll()
        {
            return GetAll().ToList();
        }
    }
}
