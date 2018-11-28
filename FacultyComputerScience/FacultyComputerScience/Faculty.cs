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
            PrintMessage("List of subjets");
            foreach (var spec in Specialty)
            {
                foreach (var subj in spec.Subjects)
                {
                    Console.WriteLine(subj.SubjectName);
                }
            }
        }

        public void PrintSpecialtiesList()
        {
            PrintMessage("List of specialties");
            foreach (var item in Specialty)
            {
                Console.WriteLine(item.SpecialtyName);
            }
        }

        public void PrintStudentsList()
        {
            PrintMessage("Students list");

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

        private void PrintMessage(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
