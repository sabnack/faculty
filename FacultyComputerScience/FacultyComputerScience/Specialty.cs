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
        private IWriter _writer { get; }

        public Specialty(IWriter writer, string specialtyName)
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
            SpecialtyName = specialtyName;
            _writer = writer;
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public void AddSubject(Subject subject)
        {
            Subjects.Add(subject);
        }

        public void PrintStudentsList()
        {
           _writer.WriteInfo("List of specialty students", ConsoleColor.Yellow);
            Groups.ForEach(s => s.Students.ForEach(i => _writer.WriteInfo(string.Format("{0} {1}", i.FirstName, i.SecondName))));
        }

    }
}
