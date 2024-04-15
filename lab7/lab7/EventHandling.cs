using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class EventHandling
    {
        public void SendMessage(string name, decimal op, decimal np)
        {
            Console.WriteLine("The price of stock " + name + "has changed from " + op + "to " + np);
        }
    }
    public delegate void PriceChanged(string n, decimal op, decimal np);
    public class StockTicker
    {
        public event PriceChanged pc;
        public string name { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                decimal addPrice = price;
                price = value;
                if (pc != null)
                {
                    pc(name, addPrice, price);
                }
            }
        }
        public static void Main(string[] args)
        {
            EventHandling pn = new EventHandling();
            StockTicker nabil = new StockTicker { name = "NABIL", Price = 500 };
            nabil.pc += new PriceChanged(pn.SendMessage);
            nabil.Price = 550;
            Console.ReadKey();

        }
    }
   
}
