using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using VogCodeChallenge.API.DatabaseEntities;
using VogCodeChallenge.API.Helpers;

namespace VogCodeChallenge.API.Controllers
{
 

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


        //The implementation for if we would like to switch to a database instead of memory  
        // GET api/employees
        [HttpGet]
        [Route("api/employeesDataBase")]
        public ActionResult<IEnumerable<string>> GetEmployeesDB()
        {
            Helpers.DatabaseModel dbm = new Helpers.DatabaseModel();
            DataTable queryResult = dbm.GetEmployees();
            return Ok(queryResult);
        }
        
    }
}
