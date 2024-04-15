using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class MultiCast
    {
        public static int Square(int n)
        {  
            return n * n;

        }
        public static int Cube(int n)
        {
            return n * n * n;

        }
        public delegate int MulticastDelegateEx(int x);
        public static void Main(string[] args)
        {
            MulticastDelegateEx del = new MulticastDelegateEx(Square);
            int res1 = del(5);
            Console.WriteLine("Square of 5: "+res1);
            del += Cube;
            int res2 = del(6);
            Console.WriteLine("Cube of 6: " + res2);
            del -= Cube;
            Console.ReadKey();
        }
    }
}
