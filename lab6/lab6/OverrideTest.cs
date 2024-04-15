using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class OverrideTest
    {
        public static void Main(string[] args)
        {
            Triangle1 t1 = new Triangle1(5, 6);
            double a = t1.Area();
            Console.WriteLine("Area of triangle: "+ a);
            Console.ReadKey();
        }
    }
}
