using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_Automatiskt_Implementerade_Egenskper
{
    internal class Person
    {
        // Properties to store basic information about a person.
        public string FirstName { get; set; } = "Undefined";
        public string LastName { get; set; } = "Undefined";
        public int Age { get; set; } = 0;

        //constructor to initialize a Person object with specific values.
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        // Default constructor that initializes properties with default values.
        public Person() { }

        // Method to print the Data of the person
        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
        }
    }
}
