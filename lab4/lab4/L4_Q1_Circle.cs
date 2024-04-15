using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class L4_Q1_Circle
    {
        private float radius;
        public L4_Q1_Circle()
        {

        }
        public L4_Q1_Circle(float r)
        {
            radius = r;
        }
        public float findArea()
        {
            return (3.14f*radius*radius);
        }
        public float findCircumference() 
        {
            return (2*3.14f*radius);
        }
    }
}
