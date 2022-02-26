using EmployeeManagerCore.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCore.Repository.Abstract
{
    public interface IDbClient
    {
        IMongoCollection<Employee> GetAllEmployees();
    }
}
