using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Name
    {
        internal class LongNameException : ApplicationException
        {
            public LongNameException(string msg) : base(msg)
            {
            }
        }
        public class LongNameEx
        {
            public static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Enter a name:");
                    string name = Console.ReadLine(); if (name.Length <= 10)
                    {
                        Console.WriteLine("Your name is : " + name);
                    }
                    else
                    {
                        throw new LongNameException("Enter a valid a short name");
                    }
                }
                catch (LongNameException e1)
                {
                    Console.WriteLine(e1.Message);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
                finally
                {
                    Console.WriteLine("End of program");
                }
                Console.ReadKey();
            }
        }
    }
}
