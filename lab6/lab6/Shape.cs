using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
     public class Shape
    {
        public double dim1, dim2;
        public Shape(double d1, double d2)
        {
            dim1 = d1;
            dim2 = d2;
        }
        public virtual double Area()
        {
            Console.WriteLine("Undefined Shape");
            return 0.0;
        }
    }


}
