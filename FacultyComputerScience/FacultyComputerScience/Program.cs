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
            var stud3 = new Students(firstName: "Andrey", secondName: "Zhmurin", age: 22);
            var stud4 = new Students(firstName: "Semen", secondName: "Bulgakov", age: 19);

            var group1 = new Groups(stud1, "Group 1");
            var group2 = new Groups(stud3, "Group 2");
            group1.Add(stud2);
            group2.Add(stud4);

            
            Console.WriteLine(group1.Group[0].FirstName + " " + group1.GroupName);
            Console.WriteLine(group1.Group[1].FirstName + " " + group1.GroupName);
            Console.WriteLine(group2.Group[0].FirstName + " " + group2.GroupName);
            Console.WriteLine(group2.Group[1].FirstName + " " + group2.GroupName);
        }
    }
}
