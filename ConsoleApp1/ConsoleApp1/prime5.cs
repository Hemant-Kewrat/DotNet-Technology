using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class prime5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if(num%i == 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
            Console.ReadKey();
        }
    }
}
