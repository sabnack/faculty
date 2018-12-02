using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    abstract class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public int Cours;

        public Student(string firstName, string secondName, int age, int cours = 1)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
            Cours = cours;
        }

        public static Student CreateStudent(string firstName, string secondName, int age, int cours = 1)
        {
            if (cours > 0 && cours < 5)
            {
                return new Bachelor(firstName, secondName, age, cours);
            }
            else if (cours > 4 && cours < 7)
            {
                return new Master(firstName, secondName, age, cours);
            }
            else return null;
        }
    }
}
