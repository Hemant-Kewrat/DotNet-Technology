using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Campus
{
    internal class student
    {
        int roll;
        string name;

        public student() { }
        public student(int roll, string name)
        {
            this.roll = roll;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Roll no :"+ roll + " " + "Name:" +  name);
        }
    }
}
