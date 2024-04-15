using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Employee : Person
    {
        int emp_id;

        string name, job_name;
        public void SetId(int i)
        {
            emp_id = i;
        }
        public int GetId()
        {
            return emp_id;
        }
        public void SetEmpName(string n)
        {
            name = n;
        }
        public string GetEmpName()
        {
            return name;
        }
        public void SetJob(string j) { job_name = j; }


        public string GetJobName()
        {
            return job_name;
        }
    }
}
