using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4_Read_Only_Egenskaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area = Rectangle.Area(2, 4);
            
            Console.WriteLine(Area);

            Console.ReadKey();
        }
    }
}
