using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyComputerScience
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleWriter = new ConsoleWriter();
            var faculty = new Faculty(consoleWriter);
            InitFaculty(faculty, consoleWriter);
            faculty.PrintSpecialtiesList();
            faculty.PrintStudentsList();
            faculty.PrintSubjectsList();
            faculty.PrintTeachersList();
            // Console.WriteLine(faculty.Specialty[0].Groups[0].Students[0].AcademicDegree);
        }

        public static void PrintMessage(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public static void InitFaculty(Faculty faculty, IWriter consoleWriter)
        {
            var stud1 = Student.CreateStudent(firstName: "Ivan", secondName: "Petrov", age: 21);
            var stud2 = Student.CreateStudent(firstName: "Petr", secondName: "Ivanov", age: 20, cours:5);
            var stud3 = Student.CreateStudent(firstName: "Andrey", secondName: "Zhmurin", age: 22, cours:2);

            var stud4 = Student.CreateStudent(firstName: "Semen", secondName: "Bulgakov", age: 19, cours:2);
            var stud5 = Student.CreateStudent(firstName: "Alexandr", secondName: "Pushkin", age: 20);
            var stud6 = Student.CreateStudent(firstName: "Iosif", secondName: "Stalin", age: 22, cours:6);

            var stud7 = Student.CreateStudent(firstName: "Adolf", secondName: "Gitler", age: 21, cours:3);
            var stud8 = Student.CreateStudent(firstName: "Vasya", secondName: "Pupkin", age: 20, cours:3);
            var stud9 = Student.CreateStudent(firstName: "Pavel", secondName: "Morozov", age: 22, cours:5);

            var stud10 = Student.CreateStudent(firstName: "Anton", secondName: "Chehov", age: 22, cours:4);
            var stud11 = Student.CreateStudent(firstName: "Winston", secondName: "Cherchel", age: 21, cours:6);
            var stud12 = Student.CreateStudent(firstName: "Alexandr", secondName: "Makedonskiy", age: 22, cours:4);

            var teacher1 = new Teacher("Ivan", "Dubinin", 55);
            var teacher2 = new Teacher("Semen", "Volkov", 43);
            var teacher3 = new Teacher("Stephan", "Kozimir", 39);



            var group1 = new Group(consoleWriter, "Group 1");
            group1.Add(stud1);
            group1.Add(stud2);
            group1.Add(stud3);

            var group2 = new Group(consoleWriter, "Group 2");
            group2.Add(stud4);
            group2.Add(stud5);
            group2.Add(stud6);

            var group3 = new Group(consoleWriter, "Group 3");
            group3.Add(stud7);
            group3.Add(stud8);
            group3.Add(stud9);

            var group4 = new Group(consoleWriter, "Group 4");
            group4.Add(stud10);
            group4.Add(stud11);
            group4.Add(stud12);

            var subject1 = new Subject("Computer Systems and Networks", 150);
            var subject2 = new Subject("Network Engineering", 170);
            var subject5 = new Subject("Artificial Intelligence", 160);

            var subject3 = new Subject("Artificial Intelligence", 160);
            var subject4 = new Subject("Computer Vision", 145);

            var specialty1 = new Specialty(consoleWriter, "Information Technology");
            specialty1.AddGroup(group1);
            specialty1.AddSubject(subject1);
            specialty1.AddGroup(group2);
            specialty1.AddSubject(subject2);
            specialty1.AddSubject(subject5);

            var specialty2 = new Specialty(consoleWriter, "Cybernetics");
            specialty2.AddGroup(group3);
            specialty2.AddSubject(subject3);
            specialty2.AddGroup(group4);
            specialty2.AddSubject(subject4);
            specialty2.PrintStudentsList();

            teacher1.AddGroup(group1);
            teacher2.AddGroup(group2);
            teacher3.AddGroup(group3);

            teacher1.AddSubjects(subject1);
            teacher1.AddSubjects(subject4);
            teacher2.AddSubjects(subject2);
            teacher3.AddSubjects(subject3);

            faculty.AddTeacher(teacher1);
            faculty.AddTeacher(teacher2);
            faculty.AddTeacher(teacher3);

            faculty.Specialty.Add(specialty1);
            faculty.Specialty.Add(specialty2);
        }
    }
}
