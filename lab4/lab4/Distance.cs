using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Distance
    {
        private int feet, inches;
        public Distance()
        {

        }
        public Distance(int f, int i) 
        { 
            feet = f;
            inches = i;
        }
        public Distance addDistance(Distance d)
        {
            Distance temp = new Distance();
            temp.feet = feet+ d.feet;
            temp.inches = inches + d.inches;
            
            if(temp.inches>=12 ) {
            temp.feet += 1;
                temp.inches -= 12;
            }
            return temp;

        }
        public void displayDistance1()
        {
            Console.WriteLine("distance1 is " +  feet +" feet "+inches+" inches");
        }
        public void displayDistance2()
        {
            Console.WriteLine("distance2 is " + feet + " feet " + inches + " inches");
        }
        public void displaySum() 
        {
            Console.WriteLine("Sum of distances is " + feet + " feet " + inches + " inches");

        }
    }
}
