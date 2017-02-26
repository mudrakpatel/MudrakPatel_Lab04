using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_Ex3
{
    class Employee
    {
        public string Name { get; set; }
        public double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    salary = 0.0;
            }
        } // end property

        // constructor
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return String.Format("\nName: {0}, Salary:{1}", Name, Salary);
        }
    }
}
