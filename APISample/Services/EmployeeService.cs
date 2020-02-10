using APISample.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APISample.Services
{
    public static class EmployeeService
    {
        public static List<Employee> Employees { get; set; }
        static EmployeeService()
        {
            Employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                    FirstName = "Seshi",
                    LastName = "Reddy",
                    Designation = "Technology Specialist"
                },
                new Employee
                {
                    Id=2,
                    FirstName = "Nandini",
                    LastName = "Durga",
                    Designation = "Software Engineer"
                }
            };
        }
        public static void Add(Employee employee)
        {
            Employees.Add(employee);
        }
        public static Employee Delete(int id)
        {
            var emp = Employees.First(e => e.Id == id);
            Employees.Remove(emp);
            return emp;
        }
        public static Employee Update(Employee employee)
        {
            var emp=Employees.First(e=>e.Id == employee.Id);
            emp.FirstName = employee.FirstName;
            emp.LastName = employee.LastName;
            emp.Designation = employee.Designation;
            return emp;
        }

    }
}
