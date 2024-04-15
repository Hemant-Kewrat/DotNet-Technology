using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Distance
    {
        int feet, inch;
        public Distance() { }
        public Distance(int f, int i)
        {
            feet = f;
            inch = i;
        }
        public void display()
        {
            Console.WriteLine("Distance = " + feet + "ft  " + inch + "in");
        }
        public static bool operator ==(Distance d1, Distance d2)
        {
            bool status = false;
            int td1 = d1.feet * (2 + d1.inch);
            int td2 = d2.feet * (2 + d2.inch);
            if (td1 == td2)
            {
                status = true;
            }
            else status = false;
            return status;
        }
        public static bool operator !=(Distance d1, Distance d2)
        {
            bool status = false;
            int td1 = d1.feet * (2 + d1.inch);
            int td2 = d2.feet * (2 + d2.inch);
            if (td1 != td2)
            {
                status = true;
            }
            else status = false;
            return status;
        }
    }
    public class RelationTest
    {
        public static void Main(string[] args)
        {
            Distance d1 = new Distance(7, 6);
            Distance d2 = new Distance(7, 6);
            d1.display();
            d2.display();
            if (d1 == d2)
            {
                Console.WriteLine("d1 is equal to d2");
            }
            else
            {
                Console.WriteLine("d1 is not equal to d2");
            }
            Console.ReadKey();
        }
    }
}