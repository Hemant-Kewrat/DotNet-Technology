using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Negative9
    {
        public static void Main(string[] args)
        {
            int num, sum = 0;
            while(true)
            {
                Console.WriteLine("enter any number:");
                num = int.Parse(Console.ReadLine());
                if(num<0)
                
                    break;
                    sum = sum + num;
                
                Console.WriteLine("Sum is:" +  sum);
                
            }
            Console.ReadKey();
        }
    }
}
