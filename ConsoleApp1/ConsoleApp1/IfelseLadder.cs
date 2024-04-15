using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IfelseLadder
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Given number is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine("Given number is positive");
             }
            else 
            {
                Console.WriteLine("Zero");
            }
            Console.ReadKey();

        }
    }
}
