using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NestedIf
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            if(num%2 !=0)
            {
                if(num%3 == 0) 
                {
                    Console.WriteLine("odd and divisible by 3");
                }
                else
                {
                    Console.WriteLine("Odd but not divisible by 3");
                }
            }
            else
            {
                if(num%3 == 0)
                {
                    Console.WriteLine("Even and divisible by 3");
                }
                else
                {
                    Console.WriteLine("Even but not divisible by 3");
                }
            }
            Console.ReadKey();
        }
    }
}
