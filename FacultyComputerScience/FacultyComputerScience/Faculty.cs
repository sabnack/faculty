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
            Console.WriteLine("List of specialties");
            foreach (var item in Specialty)
            {
                Console.WriteLine(item.SpecialtyName);
            }
        }
    }
}
