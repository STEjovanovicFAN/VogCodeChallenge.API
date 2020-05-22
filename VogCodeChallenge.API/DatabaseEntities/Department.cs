using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.DatabaseEntities
{
    public class Department : Company
    {
        public string DepartmentName { get; set; }

        public string DepartmentAddress { get; set; }

        public string DepartmentID { get; set; }

    }
}
