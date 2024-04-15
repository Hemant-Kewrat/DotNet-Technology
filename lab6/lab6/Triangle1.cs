using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class Triangle1 : Shape
    {
        public Triangle1(double b, double h) : base(b, h) { }
        public override double Area()
        {
            return (0.5 * dim1 * dim2);
        }
    }
}
