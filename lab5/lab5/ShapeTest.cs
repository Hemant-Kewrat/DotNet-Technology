using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class ShapeTest
    {
        public static void Main(string[] args)
        {
            Triangle t1 = new Triangle(7, 6);
            Console.WriteLine("Area of the triangle = " + t1.Area());
            Console.ReadKey();
        }
    }
}
