using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class DivideByZeroEx
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any two number: ");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int div = num1 / num2;
                Console.WriteLine("Division= " + div);

            }
            catch(DivideByZeroException e1) 
            {
                Console.WriteLine(e1.Message);
            }
            catch (Exception e2) 
            {
                Console.WriteLine(e2.Message);
            }
            finally { Console.WriteLine("End of program");
            }
            Console.ReadKey();
        }
    }
}
