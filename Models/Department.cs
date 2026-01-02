using System;
using System.Collections.Generic;

namespace RelationshipApp.Models
{
    public class Department
    {
        public int Id { get; set; }            // Department ID
        public string Name { get; set; }       // Department Name
        public List<Employee> Employees { get; set; } = new List<Employee>(); // Initialize to avoid warning
    }
}