using EmployeeManagerCore.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCore.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Employee AddEmployee(Employee employee);
        Employee GetEmployee(string id);
        void DeleteEmployee(string id);
        Employee UpdateEmployee(Employee employee);
    }
}
