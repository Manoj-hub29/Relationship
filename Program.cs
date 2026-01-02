using System;
using System.Collections.Generic;
using RelationshipApp.Models;

namespace RelationshipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Department
            var department = new Department
            {
                Id = 1,
                Name = "IT", // Department name
                Employees = new List<Employee>
                {
                    new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
                    new Employee { Id = 2, Name = "Bob", DepartmentId = 1 }
                }
            };

            // Display Department and Employees
            Console.WriteLine($"Department: {department.Name}");

            foreach (var emp in department.Employees)
            {
                Console.WriteLine($"Employee: {emp.Name}");
            }
        }
    }
}