using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4
{
    internal class StaticDisplay
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-------Static Class------");
            Console.WriteLine("PI=" + StaticClass.PI);
            Console.WriteLine("Cube of 5 = "+ StaticClass.Cube(5));
            Console.WriteLine("------Static Constructor--------");
            StaticConst s1 = new StaticConst(06,"Hemant Kumar Das");
            s1.display();
            Console.ReadKey();

        }
    }
}
