using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Students(firstName: "Ivan", secondName: "Petrov", age: 21);
            var stud2 = new Students(firstName: "Petr", secondName: "Ivanov", age: 20);

            var group1 = new Groups(stud1, "Group 1");
            
        }
    }
}
