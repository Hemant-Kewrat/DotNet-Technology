using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class StudentTest
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            College c1 = new College();
            Employee e1 = new Employee();
            s1.setRoll(105);
            s1.setName("Hemant");
            s1.setAddress("Pokhara");
            c1.setCol("Patan Multiple Campus");
            e1.SetId(55);
            e1.SetEmpName("Ram");         
            e1.SetJob("Manager");
            Console.WriteLine("-------- Student Information----------");
            Console.WriteLine("Roll= " + s1.getRoll());
            Console.WriteLine("Name= " + s1.getName());
            Console.WriteLine("Address= " + s1.getAddress());
            Console.WriteLine("College= " + c1.getCol());
            Console.WriteLine("--------Employee Information----------");
            Console.WriteLine("Employee ID = " + e1.GetId());
            Console.WriteLine("Employee Name= " + e1.GetEmpName());
            Console.WriteLine("Position= "+ e1.GetJobName());
            Console.ReadKey();
        }
    }

}
