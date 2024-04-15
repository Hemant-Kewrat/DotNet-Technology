using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class MyRectangle
    {
        public static void Main(String[] args)
        {
            Rectangle r1 = new Rectangle(10, 20);
            Console.WriteLine("Area of Rectangle: " + r1.findArea());
            Console.WriteLine("Perimeter of Rectangle: " + r1.findPerimeter());
            Console.ReadKey();
        }
    }
}
