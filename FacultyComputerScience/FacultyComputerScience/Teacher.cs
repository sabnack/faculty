using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Teacher:Person
    {
        public string AcademicStatus;
        public List<Subject> Subjects { get; }
        public List<Group> Groups { get; }

        public Teacher(string firstName, string secondName, int age, string academicStatus = "Professor")
            : base(firstName, secondName, age)
        {
            Subjects = new List<Subject>();
            Groups = new List<Group>();
            AcademicStatus = academicStatus;
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public void AddSubjects(Subject subject)
        {
            Subjects.Add(subject);
        }
    }
}
