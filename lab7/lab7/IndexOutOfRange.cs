using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class IndexOutOfRange
    {
        public static void Main(string[] args)
        {
            try
            {
                int[] num = new int[5];
                Console.WriteLine("Array Element at index: " + num[6]);
                

            }
            catch(IndexOutOfRangeException e1) {
                Console.WriteLine(e1.Message);
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            Console.ReadKey();
        }
    }
}
