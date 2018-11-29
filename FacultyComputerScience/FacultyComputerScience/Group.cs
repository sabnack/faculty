using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Group
    {
        public List<Student> Students { get; set; }
        public string GroupName { get; }

        public Group(Student student, string groupName)
        {
            Students = new List<Student>
            {
                student
            };
            GroupName = groupName;
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public void PrintStudentsList()
        {
            Program.PrintMessage("Students group list", ConsoleColor.Yellow);
            Program.PrintMessage(GroupName, ConsoleColor.Green);
            Students.ForEach(i => Console.WriteLine("{0} {1}", i.FirstName, i.SecondName));
        }
    }
}
