using System;

namespace Uppgift_2_Validera_Egenskaper
{
    internal class Person
    {
        // Auto-implemented property for FirstName with validation.
        private string firstName;
        public string FirstName
        {
            get 
            {
                return firstName;  // Getter to return the first name.
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))  // Validate that it's not empty or null.
                {
                    firstName = value;  // Set the value if valid.
                }
                else
                {
                    Console.WriteLine("First name cannot be empty or null.");
                }
            }
        }

        // Auto-implemented property for LastName with validation.
        private string lastName;
        public string LastName
        {
            get 
            {
                return lastName;  // Getter to return the last name. 
            } 
            set
            {
                if (!string.IsNullOrWhiteSpace(value))  // Validate that it's not empty or null.
                {
                    lastName = value;  // Set the value if valid.
                }
                else
                {
                    Console.WriteLine("Last name cannot be empty or null.");
                }
            }
        }

        // Auto-implemented property for Age with validation.
        private int age;
        public int Age
        {
            get
            {
                return age;  // Getter to return the age.
            }
            set
            {
                if (value >= 0)  // Validate that the age is non-negative.
                {
                    age = value;  // Set the value if valid.
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }

        // Constructor to initialize a Person object with specific values.
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;  
            LastName = lastName;    
            Age = age;              
        }

        // Default constructor in case we want to create a Person without initializing.
        public Person() { }

        // Method to print the data of the person.
        // Displays the full name and age.
        public void GetFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}, Age: {Age}" ); 
        }
    }
}
