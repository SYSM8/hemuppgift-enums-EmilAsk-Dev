﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1_Skapa_en_Enkel_Klass_med_Egenskaper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a new instance of Emil with set values
            Person Emil = new Person("Emil", "Ask", 2);

            //Creates a new instance of Emil2 with default values
            Person Emil2 = new Person();

            //calls the functions to log the data
            Emil.GetFullName();
            Emil2.GetFullName();

            Console.ReadKey();
        }
    }
}
