using EmployeeManagerCore.Abstract;
using EmployeeManagerCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employee;

        public EmployeeController(IEmployeeService employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employee.GetAllEmployees());
        }

        [HttpGet("{id}",Name ="GetEmployee")]
        public IActionResult GetEmployee(string id)
        {
            return Ok(_employee.GetEmployee(id));
        }


        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employee.AddEmployee(employee);
            return CreatedAtRoute("GetEmployee", new { id = employee.Id }, employee);
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(string id)
        {
            _employee.DeleteEmployee(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateEmployee(Employee employee)
        {
         return Ok(_employee.UpdateEmployee(employee));
        }
    }
}
