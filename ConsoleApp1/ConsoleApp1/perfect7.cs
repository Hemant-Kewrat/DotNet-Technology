using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class perfect7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter any number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num%i == 0)
                {
                    sum += i;
                }
                
            }
            if(sum == num)
            {
                Console.WriteLine(num + " is a perfect number");
            }
            else { Console.WriteLine(num + " is not perfect number"); }
            Console.ReadKey();
        }
        
    }
}
