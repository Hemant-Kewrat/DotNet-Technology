using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class College : Student
    {
        string college;
        public void setCol(string c)
        {
            college = c;
        }
        public string getCol()
        {
            return college;
        }
    }
}
