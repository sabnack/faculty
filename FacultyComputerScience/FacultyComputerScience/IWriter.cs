using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    interface IWriter
    {
        void WriteInfo(string str, ConsoleColor color = ConsoleColor.White);
        void WriteError();
    }
}
