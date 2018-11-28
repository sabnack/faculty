using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Subjects
    {
        public string SubjectName;
        public int HoursAmount;

        public Subjects(string subjectName, int hoursAmount)
        {
            SubjectName = subjectName;
            HoursAmount = hoursAmount;
        }
    }
}
