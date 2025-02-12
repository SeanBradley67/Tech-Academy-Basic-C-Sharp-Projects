using System;

namespace Polymorphism_Assignment
{
    public interface IQuittable
    {
        void Quit();
    }

    // Abstract class Person
    public abstract class Person
    {
        // Properties for first and last name
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName, to be implemented in derived classes
        public abstract void SayName();
    }

    // Employee class inherits from Person and implements IQuittable
    public class Employee : Person, IQuittable
    {
        // Implement SayName method from Person
        public override void SayName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }

        // Implement Quit method from IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}
