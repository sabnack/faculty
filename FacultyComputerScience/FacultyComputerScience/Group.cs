using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Group
    {
        public List<Student> Groups { get; set; }
        public string GroupName { get; }

        public Group(Student student, string groupName)
        {
            Groups = new List<Student>
            {
                student
            };
            GroupName = groupName;
        }

        public void Add(Student student)
        {
            Groups.Add(student);
        }
    }
}
