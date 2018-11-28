using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Specialties
    {
        public List<Groups> Groups;
        public List<Subjects> Subject;
        public readonly string SpecialtyName;

        public Specialties(Groups group, Subjects subject, string specialtyName)
        {
            Groups = new List<Groups>
            {
                group
            };

            Subject = new List<Subjects>
            {
                subject
            };

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
