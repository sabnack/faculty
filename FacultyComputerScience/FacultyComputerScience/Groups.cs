using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Groups
    {
        public List<Students> Group;
        public readonly string GroupName;

        public Groups(Students student, string groupName)
        {
            Group = new List<Students>
            {
                student
            };
            GroupName = groupName;
        }

        public void Add(Students student)
        {
            Group.Add(student);
        }
    }
}
