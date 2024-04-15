using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class TestBinOpr
    {
        public static void Main(string[] args)
        {
            BinaryOperator c1 = new BinaryOperator(5, 6);
            BinaryOperator c2 = new BinaryOperator(4, 5);
            c1.display();
            c2.display();
            Console.WriteLine("Multiplication: ");
            BinaryOperator c3 = c1 * c2;
            c3.display();
            Console.WriteLine("Division: ");
            BinaryOperator c4 = c1 / c2;
            c4.display();
            Console.ReadKey();
        }
    }
}
