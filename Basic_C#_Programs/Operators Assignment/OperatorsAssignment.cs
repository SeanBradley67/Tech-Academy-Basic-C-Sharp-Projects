using System;

namespace Operators_Assignment
{
    // Employee class with properties and overloaded operators
    public class Employee
    {
        // Properties for Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both employee objects have the same Id
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator to compare two Employee objects by Id (required when overloading ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Check if employee objects have different Ids
            return emp1.Id != emp2.Id;
        }

        // Override Equals method to ensure proper comparison
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        // Override GetHashCode to keep it consistent with Equals
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
