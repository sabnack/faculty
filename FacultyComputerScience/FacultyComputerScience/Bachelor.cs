using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Bachelor : Student
    {
        public Bachelor(string firstName, string secondName, int age, int cours = 1)
            : base(firstName, secondName, age, cours)
        {

        }
    }
}
