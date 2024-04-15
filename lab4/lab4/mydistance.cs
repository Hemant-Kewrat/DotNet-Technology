using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class mydistance
    {
        public static void Main(string[] args)
        {
            Distance d1 =  new Distance(3,9);
            d1.displayDistance1();
            Distance d2 = new Distance(4,4);
           d2.displayDistance2();
            Distance d3 = d1 .addDistance(d2);
            d3.displaySum();
            Console.ReadKey();
            
        }
    }
}
