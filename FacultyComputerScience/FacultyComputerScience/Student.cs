using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
    }
}
