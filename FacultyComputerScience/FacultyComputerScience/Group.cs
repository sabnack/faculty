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
    }
}
