using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Structure
    {
        struct Company 
        { 
            string name, address;
            int phone, salary;
            public void ReadEle(string n, string a, int p, int s)
            {
                name = n;
                address = a;
                phone = p;
                salary = s;
            }
            public void display()
            {
                Console.WriteLine("Name of the Company is " + name + " \nAddress is " + address + "\n phone number is " + phone + " \n Salary is " + salary);
                Console.ReadKey();
            }
        };
        public static void Main(string[] args)
        {
            Company c1 = new Company();
            c1.ReadEle("HDLC pvt. ltd.", "Tinkune",982356980,50000);
            c1.display();
        }
    }
}
