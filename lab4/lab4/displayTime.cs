using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab4.Time;

namespace lab4
{
    internal class displayTime
    {
        public static void Main(string[] args)
        {
            Time t1 = new Time(7, 24, 15);
            Time t2 = new Time(9, 34, 35);
            Console.WriteLine("First time:");
            t1.display();
            Console.WriteLine("Second time:");
            t2.display();
            Console.WriteLine("Sum of first and second time is");
            Time t3 = t1.addTime(t2);
            t3.display();
            Console.WriteLine("Subtraction of first and second time is");
            Time t4 = t1.subTime(t2);
            t4.display();
            Console.ReadKey();
        }

    }
}
