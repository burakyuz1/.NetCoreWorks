using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EmployeeManagerCore.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeDepartment { get; set; }
    }
}
