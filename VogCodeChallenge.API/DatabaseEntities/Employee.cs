using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.DatabaseEntities
{
    public class Employee : Company
    {
        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string EmployeeJobTitle { get; set; }

        public string EmployeeAddress { get; set; }

        public string DepartmentID { get; set; }
    }
}
