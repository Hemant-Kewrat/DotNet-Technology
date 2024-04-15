using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class MyCircle
    {
        public static void Main(string[] args)
        {
            L4_Q1_Circle c1 = new L4_Q1_Circle(8);
            Console.WriteLine("Area of circle c1 = " + c1.findArea() + "\n Circumference of circle = " + c1.findCircumference());
            Console.ReadKey();
        }
    }
}
