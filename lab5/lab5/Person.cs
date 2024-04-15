using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Person
    {
        string name, address;
        public void setName(string n)
        {
            name = n;
        }
        public string getName() 
        { 
            return name;
        }
        public void setAddress(string a)
        {
            address = a;
        }
        public string getAddress()
        {
            return address;
        }
    }
    
}
