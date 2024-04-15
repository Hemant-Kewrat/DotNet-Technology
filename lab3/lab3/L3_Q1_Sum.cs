using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q1_Sum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int arrsize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrsize];
            Console.WriteLine("Enter the value inside this array");
            for (int i = 0; i < arrsize; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                sum += arr[j];
            }
            Console.WriteLine("The sum of array is" + sum);
            Console.ReadKey();
        }
    }
}
