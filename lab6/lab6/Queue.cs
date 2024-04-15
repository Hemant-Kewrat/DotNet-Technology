using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Queue
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Hemant");
            names.Enqueue("Ayuush");
            names.Enqueue("Himal");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Peek element: "+names.Peek());
            Console.WriteLine("Dequeue: " +names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " +names.Peek());
            Console.ReadKey();
        }
    }
}
