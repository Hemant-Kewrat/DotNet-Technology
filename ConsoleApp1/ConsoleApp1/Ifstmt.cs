using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ifstmt
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check whether it is even or odd: ");
            int num = int.Parse(Console.ReadLine());
            if(num %2 == 0) {
                Console.WriteLine("Even number");

             }
            else { Console.WriteLine("Odd number"); }
            Console.ReadKey();
        }
    }
}
