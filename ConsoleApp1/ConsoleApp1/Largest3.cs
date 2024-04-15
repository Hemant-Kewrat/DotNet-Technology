using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Largest3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine(a + " is largest");
                }
                else
                {
                    Console.WriteLine(c + "is largest");
                }
            }
            else
            {
                if(b>c)
                {
                    Console.WriteLine(b + "is largest");
                }
                else { Console.WriteLine(c + " is largest");
                }
              
            }
            Console.ReadKey();
        }
    }
}
