using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Student : Person
    {
        int roll;
        
        public void setRoll(int r)
        {
            roll = r;

        }
        public int getRoll()
        {
            return roll;
        }
        

    }
}
