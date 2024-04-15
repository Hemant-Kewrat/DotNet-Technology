using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class OverloadingTest
    {
        public static void Main(string[] args)
        {
            MethodOverloading a1 = new MethodOverloading();
            int s1 = a1.add(5, 6);
            int s2 = a1.add(5, 6, 7);
            double s3 = a1.add(5.2, 7.9, 2.3);

            Console.WriteLine("Sum of two integer is: "+ s1);
            Console.WriteLine("Sum of three integer is: " +s2);
            Console.WriteLine("Sum of three double is: " + s3);
            Console.ReadKey();

        }
    }
}
