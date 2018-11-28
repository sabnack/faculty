using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Teacher:Person
    {
        public string AcademicStatus;

        public Teacher(string firstName, string secondName, int age, string academicStatus = "Professor")
            : base(firstName, secondName, age)
        {
            AcademicStatus = academicStatus;
        }
    }
}
