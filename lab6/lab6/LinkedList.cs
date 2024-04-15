using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class LinkedList
    {
        public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Surya");
            names.AddLast("Mohan");
            names.AddLast("Bartika");
            names.AddFirst("Peter");
            foreach(var name in names)
            {
                Console.WriteLine(name);    
            }
            Console.ReadKey();
        }
    }
}
