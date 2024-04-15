using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Complex
    {
        int real, img;
        public Complex() { }
        public Complex(int r, int i)
        {
            real = r;
            img = i;
        }
        public void display()
        {
            Console.WriteLine("Complex no : " + real + "+" + img + "i");

        }
        public static Complex operator -(Complex c)
        {
            Complex temp = new Complex();
            temp.real = -c.real;
            temp.img = -c.img;
            return temp;
        }
    }
    public class unaryTest
    {
        public static void Main(string[] args)
        {

            Complex c1 = new Complex(7, 9);
            c1.display();
            Complex c2 = -c1;
            Console.WriteLine("Negative Complex no is");
            c2.display();
            Console.ReadKey();



        }
    }
}
