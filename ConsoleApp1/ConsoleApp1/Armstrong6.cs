using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Armstrong6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int rem = 0;
            int sum = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("Number is armstrong");

            }
            else
            {
                Console.WriteLine("Number is not armstrong");
            }


            Console.ReadKey();



        }
    }
}
