using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class AnonymousEx
    {
        public delegate int addDelegate(int x, int y);
        public static void Main(string[] args)
        {
            addDelegate del = delegate(int x, int y) 
            {
                return x + y;
            };
            int s = del(5, 6);
            Console.WriteLine("Anonymous Example: ");
            Console.WriteLine("Sum = "+s);
            Console.ReadKey();
        }
    }
}
