using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_5_Enum
{
    // Enum for colors
    enum Color
    {
        Red,
        Green,
        Yellow,
    }
    // Enum for priority levels
    enum Priority
    {
        Low,
        Medium,
        High,
    }

    internal class Task
    {
        // Properties for the task's color and priority
        public Color TaskColor { get; set; }
        public Priority TaskPriority { get; set; }

        // Constructor to initialize the task with color and priority
        public Task(Color color, Priority priority)
        {
            TaskColor = color;
            TaskPriority = priority;
        }

        // Method to print the description of the task
        public void PrintDescription()
        {
            Console.WriteLine($"Task Color: {TaskColor}, Task Priority: {TaskPriority}");
        }
    }
}
