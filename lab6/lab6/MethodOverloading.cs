using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class MethodOverloading
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x, int y,int z)
        {
            return x + y + z;

        }
        public double add(double x, double y, double z) {  return x + y + z; }
    }
}
