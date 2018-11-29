using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Faculty
    {
        public const string NameOfFaculty = "Computer science";
        public List<Specialty> Specialty { get; }

        public Faculty()
        {
            Specialty = new List<Specialty>();
        }

        public void PrintSubjectsList()
        {
            PrintMessage("List of subjets", ConsoleColor.Yellow);
            Specialty.ForEach(s => s.Subjects.ForEach(i => Console.WriteLine(i.SubjectName)));
        }

        public void PrintSpecialtiesList()
        {
            PrintMessage("List of specialties", ConsoleColor.Yellow);
            Specialty.ForEach(i => Console.WriteLine(i.SpecialtyName));
        }

        public void PrintStudentsList()
        {
            PrintMessage("Students list", ConsoleColor.Yellow);
            Specialty.ForEach(g => g.Groups.ForEach(s => s.Students.ForEach(i => Console.WriteLine("{0} {1}", i.FirstName, i.SecondName))));
        }

        private void PrintMessage(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
