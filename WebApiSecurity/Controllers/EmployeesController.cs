using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSecurity.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public class EmployeesController : ApiController
    {
        public Employee Get(int id)
        {
            return new Employee
            {
                Id = id,
                Name = "John Q Law",
                Department = "Enforcement"
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return new Employee[]
            {
                new Employee
                {
                    Id = 12345,
                    Name = "John Q Law",
                    Department="Enforcement"
                },
                new Employee
                {
                    Id = 6789,
                    Name = "John Q Taxpaper",
                    Department = "Revenue"
                }
            };
        }
    }
}
