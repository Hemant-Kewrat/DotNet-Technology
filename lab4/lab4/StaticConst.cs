using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class StaticConst
    {
        int Roll;
        String Name;
        static string College;
        public StaticConst(int r, string n)
        {
            Roll = r;
            Name = n;
        }
        static StaticConst()
        {
            College = "Patan Multiple Campus";
        }
        public void display()
        {
            Console.WriteLine("Roll= " + Roll + " \n Name = " + Name + "\n College = " + College);
        }
    }
}
