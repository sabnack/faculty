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

        public void PrintStudentsList()
        {
            Program.PrintMessage("List of specialty students", ConsoleColor.Yellow);
            Groups.ForEach(s => s.Students.ForEach(i => Console.WriteLine("{0} {1}", i.FirstName, i.SecondName)));
        }

    }
}
