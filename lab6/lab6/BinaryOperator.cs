using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class BinaryOperator
    {
        int real, img;
        public BinaryOperator() { }

        public BinaryOperator( int r, int i)
        {
            real = r;
            img = i;
        }
        public void display()
        {
            Console.WriteLine("Complex No: " + real + "+" + img + "i");
        }
        public static BinaryOperator operator *(BinaryOperator a, BinaryOperator b) 
        {
            BinaryOperator temp = new BinaryOperator();
            temp.real = a.real*b.real;
            temp.img = a.img*b.img;
            return temp;
        }
        public static BinaryOperator operator /(BinaryOperator a, BinaryOperator b)
        {
            BinaryOperator temp = new BinaryOperator();
            temp.real = a.real / b.real;
            temp.img = a.img / b.img;
            return temp;
        }
    }
}
