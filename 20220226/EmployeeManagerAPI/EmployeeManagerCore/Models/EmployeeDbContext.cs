using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCore.Models
{
    public class EmployeeDbContext
    {
        public string Database_Name { get; set; }
        public string Employee_Collection_Name { get; set; }
        public string Connection_String { get; set; }
    }
}
