using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APISample.models;
using APISample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET api/Employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return EmployeeService.Employees;
        }

        ////GET api/Employees/id
        //[HttpGet]
        //public ActionResult<Employee> Get(int id)
        //{
        //    return EmployeeService.Employees.First(e=>e.Id == id);
        //}

        [HttpPost]
        public ActionResult<Employee> Post(Employee employee)
        {
            EmployeeService.Add(employee);
            return employee;
        }

        [HttpDelete]
        public ActionResult<Employee> Delete(int id)
        {
            return EmployeeService.Delete(id);
        }

        [HttpPut]
        public ActionResult<Employee> Put(Employee employee)
        {
            EmployeeService.Update(employee);
            return employee;
        }
    }
}