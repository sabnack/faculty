using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Faculty
    {
        public const string NameOfFaculty = "Computer science";
        public List<Specialty> Specialty { get; }
        public List<Teacher> Teachers { get; }

        public Faculty()
        {
            Specialty = new List<Specialty>();
            Teachers = new List<Teacher>();
        }

        public void PrintTeachersList()
        {
            Program.PrintMessage("Teachers List", ConsoleColor.Red);
            Teachers.ForEach(t => Console.WriteLine("{0} {1} {2}", t.FirstName, t.SecondName, t.AcademicStatus));
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void PrintSubjectsList()
        {
            Program.PrintMessage("List of subjets", ConsoleColor.Yellow);
        //    Specialty.ForEach(s => s.Subjects.ForEach(i => Console.WriteLine(i.SubjectName)));
            var tmp = new List<string>();
            Specialty.ForEach(i => tmp.AddRange(i.Subjects.Select(h => h.SubjectName)));
            tmp.Distinct().ToList().ForEach(i => Console.WriteLine(i));
        }

        public void PrintSpecialtiesList()
        {
            Program.PrintMessage("List of specialties", ConsoleColor.Yellow);
            Specialty.ForEach(i => Console.WriteLine(i.SpecialtyName));
        }

        public void PrintStudentsList()
        {
            Program.PrintMessage("Students list", ConsoleColor.Yellow);
            Specialty.ForEach(g => g.Groups.ForEach(s => s.Students.ForEach(i => Console.WriteLine("{0} {1}", i.FirstName, i.SecondName))));
        }

        
    }
}
