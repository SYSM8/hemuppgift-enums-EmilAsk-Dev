using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_6_Skapa_ett_enum_för_användarroller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create different users with various roles
            User admin = new User(UserRole.Admin);
            User moderator = new User(UserRole.Moderator);
            User user = new User(UserRole.User);
            User guest = new User(UserRole.Guest);

            // Print messages for each user
            admin.PrintRoleMessage();     
            moderator.PrintRoleMessage();  
            user.PrintRoleMessage();       
            guest.PrintRoleMessage();     

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}
