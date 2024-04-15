using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Box
    {
        private int width, height, depth;
        public Box()
        {

        }
        public Box(int w, int h, int d) 
        {
            width = w;
            height = h;
            depth = d;
        }
        public int Volume()
        {
            return width * height*depth;
        }
        public int surfaceArea()
        {
            return 2 * ((width * height) + (height * depth) + (depth * height));

        }
    }
}
