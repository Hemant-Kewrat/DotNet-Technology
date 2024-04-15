using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q6_Parameter
    {
        public static void increment(int a)
        {
            a = a + 5;
            Console.WriteLine("a=" + a);
        }
        public static void Incr(ref int b)
        {
            b += 10;
            Console.WriteLine("b=" + b);
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Pass by value");
            int x = 10;
            Console.WriteLine("Before: x=" + x);
            increment(x);
            Console.WriteLine("After:x=" + x);
            Console.WriteLine();
            Console.WriteLine("Pass by reference");
            int y = 40;
            Console.WriteLine("Before increment: y=" + y);
            Incr(ref y);
            Console.WriteLine("After increment:y=" + y);
            Console.ReadKey();
        }
    }
}
