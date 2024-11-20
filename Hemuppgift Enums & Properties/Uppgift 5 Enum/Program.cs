using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a new Task object with specified color and priority
            Task task = new Task(Color.Red, Priority.High);
            task.PrintDescription(); // Output: Task Color: Red, Task Priority: High

            // Wait for user input before closing
            Console.ReadKey();
        }
    }
}
