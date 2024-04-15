using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q4_Multiplication
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Matrix Multiplication");
            int[,] arr1 = { { 1, 2, 1 }, { 4, 2, 3 }, { 7, 4, 9 } };
            int[,] arr2 = { { 3, 1, 0 }, { 3, 4, 7 }, { 6, 1, 3 } };

            int[,] mul = new int[3, 3];

            Console.WriteLine("The first Element is");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Second Element is");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mul[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        mul[i, j] += arr1[i, k] * arr2[k, j];
                    }
                }
            }
            Console.WriteLine("The product of the two matrices is ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mul[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
