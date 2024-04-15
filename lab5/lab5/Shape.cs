using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public abstract class Shape
    {
        public double dim1, dim2;
        public Shape(double d1, double d2) 
        {
            dim1 = d1;
            dim2 = d2;
        }
        public abstract double Area();
    }
    
}
