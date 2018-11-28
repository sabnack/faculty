using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Student:Person
    {
        public string AcademicDegree;

        public Student(string firstName, string secondName, int age, string academicDegree = "Bachelor")
            :base(firstName, secondName, age)
        {
            AcademicDegree = academicDegree;
        }
    }
}
