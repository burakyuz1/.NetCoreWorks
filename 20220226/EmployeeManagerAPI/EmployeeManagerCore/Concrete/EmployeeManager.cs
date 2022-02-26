using EmployeeManagerCore.Abstract;
using EmployeeManagerCore.Models;
using EmployeeManagerCore.Repository.Abstract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCore.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IMongoCollection<Employee> employees;

        public EmployeeManager(IDbClient db)
        {
            employees = db.GetAllEmployees();
        }

        public Employee AddEmployee(Employee employee)
        {
            employees.InsertOne(employee);
            return employee;
        }

        public void DeleteEmployee(string id)
        {
            employees.DeleteOne(x => x.Id == id);
        }

        public List<Employee> GetAllEmployees()
        {
            return employees.Find(x => true).ToList();
        }

        public Employee GetEmployee(string id)
        {
            return employees.Find(x => x.Id == id).FirstOrDefault();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            employees.ReplaceOne(x => x.Id == employee.Id, employee);
            return employee;
        }
    }
}
