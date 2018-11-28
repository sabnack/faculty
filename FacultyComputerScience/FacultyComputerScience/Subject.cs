using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Subject
    {
        public string SubjectName { get; set; }
        public int HoursAmount { get; set; }

        public Subject(string subjectName, int hoursAmount)
        {
            SubjectName = subjectName;
            HoursAmount = hoursAmount;
        }
    }
}
