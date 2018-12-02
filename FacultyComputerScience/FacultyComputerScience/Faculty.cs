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
        private IWriter _writer { get; }

        public Faculty(IWriter writer)
        {
            Specialty = new List<Specialty>();
            Teachers = new List<Teacher>();
            _writer = writer;
        }

        public void PrintTeachersList()
        {
            _writer.WriteInfo("Teachers List", ConsoleColor.Red);
            Teachers.ForEach(t => _writer.WriteInfo(string.Format("{0} {1} {2}", t.FirstName, t.SecondName, t.AcademicStatus)));
        }

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public void PrintSubjectsList()
        {
            _writer.WriteInfo("List of subjets", ConsoleColor.Yellow);
            var tmp = new List<string>();
            Specialty.ForEach(i => tmp.AddRange(i.Subjects.Select(h => h.SubjectName)));
            tmp.Distinct().ToList().ForEach(i => _writer.WriteInfo(i));
        }

        public void PrintSpecialtiesList()
        {
            _writer.WriteInfo("List of specialties", ConsoleColor.Yellow);
            Specialty.ForEach(i => _writer.WriteInfo(i.SpecialtyName));
        }

        public void PrintStudentsList()
        {
            _writer.WriteInfo("Students list", ConsoleColor.Yellow);
            Specialty.ForEach(g => g.Groups.ForEach(s => s.Students.ForEach(i => _writer.WriteInfo(string.Format("{0} {1}", i.FirstName, i.SecondName)))));
        }

        
    }
}
