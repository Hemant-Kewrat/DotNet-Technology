using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Triangle : Shape
    {
        public Triangle(double h, double b) : base(h, b) { }
        public override double Area()
        {
            return (0.5 * dim1 * dim2);
        }
    }
}
