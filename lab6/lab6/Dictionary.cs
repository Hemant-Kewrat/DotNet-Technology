using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string,string> names = new Dictionary<string,string>();
            names.Add("1", "Sonu");
            names.Add("2", "Hari");
            names.Add("3", "Dhiraj");
            foreach(KeyValuePair<string,string> KV in names) 
            {
                Console.WriteLine("Roll: "+KV.Key+", Name: "+KV.Value);
            }
            Console.ReadKey ();
        }
    }
}
