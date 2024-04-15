using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class InvalidCast
    {
        public static void Main(string[] args)
        {
            try
            {
                //int[] num = new int[5];
                //Console.WriteLine("Array Element at index: " + num[6]);
                //string n = "3.4";
                //int n1 = int.Parse(n);
                //Console.WriteLine("Number : "+ n1);
                object obj = 500;
                int n = (short)obj;
                Console.WriteLine(n);

            }
            catch (InvalidCastException e1)
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
            }
            Console.ReadKey();
        }
    
}
}
