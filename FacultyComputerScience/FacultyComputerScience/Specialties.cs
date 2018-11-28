using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Specialties
    {
        public List<Groups> Specialty = new List<Groups>();
        public List<Subjects> Subject = new List<Subjects>();
        public readonly string SpecialtyName;

        public Specialties(Groups group, Subjects subject, string specialtyName)
        {
            Specialty.Add(group);
            SpecialtyName = specialtyName;
        }

        
    }
}
