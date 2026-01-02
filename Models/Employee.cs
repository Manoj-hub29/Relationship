using System;

namespace RelationshipApp.Models
{
    public class Employee
    {
        public int Id { get; set; }              // Employee ID
        public string Name { get; set; }         // Employee Name
        public int DepartmentId { get; set; }    // Foreign key
        public Department Department { get; set; } // Reference to Department
    } // Make sure this closing bracket exists
}
