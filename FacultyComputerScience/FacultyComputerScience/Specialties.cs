using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Specialties
    {
        public List<Groups> Groups = new List<Groups>();
        public List<Subjects> Subject = new List<Subjects>();
        public readonly string SpecialtyName;

        public Specialties(Groups group, Subjects subject, string specialtyName)
        {
            Groups.Add(group);
            Subject.Add(subject);
            SpecialtyName = specialtyName;
        }

        public void AddGroup (Groups group)
        {
            Groups.Add(group);
        }

        public void AddSubject(Subjects subject)
        {
            Subject.Add(subject);
        }
    }
}
