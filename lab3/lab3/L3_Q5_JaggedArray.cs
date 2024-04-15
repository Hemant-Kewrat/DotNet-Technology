using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q5_JaggedArray
    {
        public static void Main(string[] args)
        {
            int[][] Arr = new int[4][];
            Arr[0] = new int[4] { 10, 20, 30, 40 };
            Arr[1] = new int[2] { 50, 60 };
            Arr[2] = new int[3] { 70, 80, 90 };
            Arr[3] = new int[1] { 100 };
            Console.WriteLine("The jagged array is: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < Arr[i].Length; j++)
                {
                    Console.Write(Arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
