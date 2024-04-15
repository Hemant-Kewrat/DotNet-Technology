using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SwitchCase
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter grade:");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "A+":
                    Console.WriteLine("Distincition");
                    break;
                case "A":
                    Console.WriteLine("First Division");
                    break;
                    case "B":
                    Console.WriteLine("Second Division"); 
                    break;
                    case "C":
                    Console.WriteLine("Third Division"); 
                    break;  
                    case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Fail"); 
                    break;

            }
            Console.ReadKey();
        }
    }
}
