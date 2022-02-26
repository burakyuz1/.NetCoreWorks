using EmployeeManagerCore.Models;
using EmployeeManagerCore.Repository.Abstract;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCore.Repository.Concrete
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Employee> employeeCollection;
        public DbClient(IOptions<EmployeeDbContext> options)
        {
            var client = new MongoClient(options.Value.Connection_String);
            var database = client.GetDatabase(options.Value.Database_Name);
            employeeCollection = database.GetCollection<Employee>(options.Value.Employee_Collection_Name);
        }
        public IMongoCollection<Employee> GetAllEmployees()
        {
            return employeeCollection;
        }
    }
}
