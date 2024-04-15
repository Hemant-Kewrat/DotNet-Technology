using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class L3_Q3_Diagonal
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sum of Diagonal element");
            int[,] arr1 = { { 2, 3, 1 }, { 5, 7, 4 }, { 7, 9, 9 } }; int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum += arr1[i, j];
                    }
                }
            }
            Console.WriteLine("The sum of diagonal element is " + sum); 
            Console.ReadKey();
        }
    }
}
