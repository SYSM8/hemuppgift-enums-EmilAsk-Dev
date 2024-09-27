using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_4_Read_Only_Egenskaper
{
    internal class Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public static double Area(double width, double height)
        {
            return width * height;
        }
    }
}
