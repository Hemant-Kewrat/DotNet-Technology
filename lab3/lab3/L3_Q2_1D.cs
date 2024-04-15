using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q2_1D
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Minimum and Maximum element from an array");

            int[] arr = { 99, 10, 3, 66, 87, 54, -10 };
            int maximum = arr[0];
            int minimum = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maximum)
                {
                    maximum = arr[i];
                }
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            Console.WriteLine("Maximum element is " + maximum + " and Minimum element is " + minimum);
            Console.ReadKey();
        }
    }
}
