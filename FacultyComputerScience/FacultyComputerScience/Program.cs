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
            var faculty = new Faculty();
            InitFaculty(faculty);
            faculty.PrintSpecialtiesList();
            faculty.PrintStudentsList();
            faculty.PrintSubjectsList();
           // Console.WriteLine(faculty.Specialty[0].Groups[0].Students[0].AcademicDegree);
        }

        public static void PrintMessage(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public static void InitFaculty(Faculty faculty)
        {
            var stud1 = new Student(firstName: "Ivan", secondName: "Petrov", age: 21);
            var stud2 = new Student(firstName: "Petr", secondName: "Ivanov", age: 20);
            var stud3 = new Student(firstName: "Andrey", secondName: "Zhmurin", age: 22);

            var stud4 = new Student(firstName: "Semen", secondName: "Bulgakov", age: 19);
            var stud5 = new Student(firstName: "Alexandr", secondName: "Pushkin", age: 20);
            var stud6 = new Student(firstName: "Iosif", secondName: "Stalin", age: 22);

            var stud7 = new Student(firstName: "Adolf", secondName: "Gitler", age: 21);
            var stud8 = new Student(firstName: "Vasya", secondName: "Pupkin", age: 20);
            var stud9 = new Student(firstName: "Pavel", secondName: "Morozov", age: 22);

            var stud10 = new Student(firstName: "Anton", secondName: "Chehov", age: 22);
            var stud11 = new Student(firstName: "Winston", secondName: "Cherchel", age: 21);
            var stud12 = new Student(firstName: "Alexandr", secondName: "Makedonskiy", age: 22);

            var group1 = new Group("Group 1");
            group1.Add(stud1);
            group1.Add(stud2);
            group1.Add(stud3);

            var group2 = new Group("Group 2");
            group2.Add(stud4);
            group2.Add(stud5);
            group2.Add(stud6);

            var group3 = new Group("Group 3");
            group3.Add(stud7);
            group3.Add(stud8);
            group3.Add(stud9);

            var group4 = new Group("Group 4");
            group4.Add(stud10);
            group4.Add(stud11);
            group4.Add(stud12);

            var subject1 = new Subject("Computer Systems and Networks", 150);
            var subject2 = new Subject("Network Engineering", 170);

            var subject3 = new Subject("Artificial Intelligence", 160);
            var subject4 = new Subject("Computer Vision", 145);

            var specialty1 = new Specialty("Information Technology");
            specialty1.AddGroup(group1);
            specialty1.AddSubject(subject1);
            specialty1.AddGroup(group2);
            specialty1.AddSubject(subject2);

            var specialty2 = new Specialty("Cybernetics");
            specialty1.AddGroup(group3);
            specialty1.AddSubject(subject3);
            specialty1.AddGroup(group4);
            specialty1.AddSubject(subject4);
            
            faculty.Specialty.Add(specialty1);
            faculty.Specialty.Add(specialty2);
        }
    }
}
