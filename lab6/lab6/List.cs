using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class List
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Insert(2, 40);
            Console.WriteLine("Total item in list: "+list.Count);
            Console.WriteLine("List item are: ");
            foreach(int val in list)
                Console.WriteLine(val+ " ");
            list.Remove(20);
            list.RemoveAt(3);
            Console.WriteLine("List item after removing: ");
            foreach(int val in list) Console.WriteLine(val + " ");
            Console.ReadKey();

        }
    }
}
