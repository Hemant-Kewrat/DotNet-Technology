using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Stack
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Ram");
            names.Push("Hari");
            names.Push("Nischal");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek Element: " +names.Peek());
            Console.WriteLine("Pop: "+names.Pop());
            Console.WriteLine("After pop, peek element: ", names.Peek());
            Console.ReadKey();
        }
    }
}
