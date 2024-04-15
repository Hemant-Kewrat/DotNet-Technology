using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface Area
    {
        int findArea();
    }
    interface Perimeter
    {
        int findPerimeter();
    }

    public class Rectangle : Area, Perimeter
    {
        private int length, breadth;
        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public int findArea()
        {
            return (length * breadth);
        }

        public int findPerimeter()
        {
            return 2 * (length + breadth);
        }
    }
    

}
