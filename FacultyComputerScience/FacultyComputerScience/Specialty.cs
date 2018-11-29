using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Specialty
    {
        public List<Group> Groups { get; set; }
        public List<Subject> Subjects { get; set; }
        public string SpecialtyName { get; }

        public Specialty(string specialtyName)
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
            SpecialtyName = specialtyName;
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
