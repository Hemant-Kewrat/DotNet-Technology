using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class MyBox
    {
        public static void Main(string[] args)
        {
            Box B1 = new Box(5,3,2);
            Box B2 = new Box(5,3,1);
            Console.WriteLine("Volume of Box B1= "+ B1.Volume()+ "and Box B2= " +B2.Volume());
            Console.WriteLine("Surface area of Box B1= " + B1.surfaceArea()+ "and Box B2= " + B2.surfaceArea());
            Console.ReadKey();
        }
    }
}
