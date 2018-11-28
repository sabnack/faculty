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

        public void PrintListSpecialty()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("List of specialties");
            Console.ResetColor();

            foreach (var item in Specialty)
            {
                Console.WriteLine(item.SpecialtyName);
            }
        }

        public void PrintStudentsList()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Students list");
            Console.ResetColor();

            foreach (var spec in Specialty)
            {
                foreach (var group in spec.Groups)
                {
                    foreach (var student in group.Students)
                    {
                        Console.WriteLine("{0} {1}",student.FirstName, student.SecondName);
                    }
                }
            }
        }
    }
}
