using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VogCodeChallenge.API.DatabaseEntities;

namespace VogCodeChallenge.API.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class ValuesController : ControllerBase
    {
        private CreateEntities ce = new CreateEntities();

        // GET api/employees
        [HttpGet]
        [Route("api/employees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return ce.GetAll();
        }

        // GET api/employees/department/{departmentID}
        [HttpGet("{departmentID}")]
        [Route("api/employees/department/{departmentID}")]
        public IEnumerable<Employee> Get(int departmentID)
        {
            List<Employee> DeptEmp = new List<Employee>();

            foreach(var emp in ce.GetAll())
            {
                if (emp.DepartmentID == departmentID)
                    DeptEmp.Add(emp);
            }

            return DeptEmp;
        }
    }
}
