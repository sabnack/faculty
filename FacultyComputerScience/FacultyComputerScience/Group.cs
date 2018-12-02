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
        private IWriter _writer { get; }

        public Group(IWriter writer, string groupName)
        {
            Students = new List<Student>();
            GroupName = groupName;
            _writer = writer;
        }

        public void Add(Student student)
        {
            Students.Add(student);
        }

        public void PrintStudentsList()
        {
            _writer.WriteInfo("Students group list", ConsoleColor.Yellow);
            _writer.WriteInfo(GroupName, ConsoleColor.Green);
            Students.ForEach(i => _writer.WriteInfo(string.Format("{0} {1}", i.FirstName, i.SecondName)));
        }
    }
}
