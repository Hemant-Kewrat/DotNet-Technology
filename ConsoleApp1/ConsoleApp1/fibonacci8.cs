using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class fibonacci8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the nth term:");
            int nth = int.Parse(Console.ReadLine());
            int prev = 0;
            int next = 1;
            int sum = 0;

            for (int i = 0; i <= nth; i++)
            {
                sum = prev + next;
                prev = next;
                next = sum;
                
            }
            Console.WriteLine(sum + " is " +nth+"th term");

            Console.ReadKey();


        }
    }
}
