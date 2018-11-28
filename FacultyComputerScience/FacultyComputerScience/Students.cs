using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Students
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Students(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
    }
}
