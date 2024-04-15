using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class goto10
    {
        public static void Main(string[] args)
        {
            int x=0,cube;
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
        loop:
            x = x + 1;
            if(x<=n)
            {
                cube = x*x*x;
                Console.WriteLine("cube is" + cube);
                goto loop;
            }
            Console.ReadKey();
        }
    }
}
