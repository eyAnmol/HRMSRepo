using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string FName { get; set; }

        public string LName { get;set; }

        public double Salary { get; set; }

        public Employee(int empId, string fname, string lname, double salary) 
        {
            this.Salary = salary;
            this. EmpId = empId;
            this.FName = fname;
            this.LName = lname;
        }
    }
    
}
