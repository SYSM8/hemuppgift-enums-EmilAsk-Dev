using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6_Skapa_ett_enum_för_användarroller
{
    enum UserRole
    {
        Admin,
        Moderator,
        User,
        Guest
    }


    internal class User
    {
        // Property to store the user's role
        public UserRole Role { get; set; }

        // Constructor to initialize the user's role
        public User(UserRole role)
        {
            Role = role;
        }

        // Method to print a message based on the user's role
        public void PrintRoleMessage()
        {
            switch (Role)
            {
                case UserRole.Admin:
                    Console.WriteLine("Welcome, Admin! You have full access.");
                    break;
                case UserRole.Moderator:
                    Console.WriteLine("Welcome, Moderator! You can manage content.");
                    break;
                case UserRole.User:
                    Console.WriteLine("Welcome, User! You can view and comment.");
                    break;
                case UserRole.Guest:
                    Console.WriteLine("Welcome, Guest! You have limited access.");
                    break;
                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }
        }
    }
}
