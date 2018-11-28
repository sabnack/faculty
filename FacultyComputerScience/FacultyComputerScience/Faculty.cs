using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    static class Faculty
    {
        public static readonly string NameOfFaculty = "Computer science";
        public static List<Specialties> Specialty = new List<Specialties>();

        public static void PrintListSpecialty()
        {
            Console.WriteLine("List of specialties");
            foreach (var item in Specialty)
            {
                Console.WriteLine(item.SpecialtyName);
            }
        }
    }
}
