using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class LambdaEx
    {
        public delegate int addDelegate(int a, int b);
        public static void Main(string[] args) 
        {
            addDelegate d1 = (a, b) => a+b;
            int s = d1.Invoke(5, 6);
            Console.WriteLine("Lambda Expression\n");
            Console.WriteLine("Sum= "+s);
            Console.ReadKey();

        }
    }
}
