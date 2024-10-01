using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2_Validera_Egenskaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Person object with invalid values.
            Person Emil = new Person("", "", -5);

            // Try to log the data (should show validation messages).
            Emil.GetFullName();

            // Set valid values for Emil.
            Emil.FirstName = "Emil";  // Set first name.
            Emil.LastName = "Ask";     // Set last name.
            Emil.Age = 25;             // Set age.

            // Log the data again to show valid values.
            Emil.GetFullName(); // Should show "Emil Ask, Age: 25".

            // Wait for a key press to close the console.
            Console.ReadKey();
        }
    }
}
