using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_Automatiskt_Implementerade_Egenskper
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            //Creates a new instance of Emil2 with default values
            Person Emil = new Person();                        
            Emil.GetFullName();
            Console.ReadKey();
        }
    }
}
