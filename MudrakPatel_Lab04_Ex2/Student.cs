using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudrakPatel_Lab04_02
{
    class Student
    {
        //Properties
        public int id { get; set; }
        public string name { get; set; }

        //Methods and constructors
        //Constructor
        public Student(string Name, int ID)
        {
            name = Name;
            id = ID;
        }

        //Overridden ToString() method
        public override string ToString()
        {
            return String.Format("\nName: {0,3}; ID: {1,6}\n", name, id);
        }
    }
}
