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
            InitFaculty();
        }

        public static void InitFaculty()
        {
            var stud1 = new Students(firstName: "Ivan", secondName: "Petrov", age: 21);
            var stud2 = new Students(firstName: "Petr", secondName: "Ivanov", age: 20);
            var stud3 = new Students(firstName: "Andrey", secondName: "Zhmurin", age: 22);

            var stud4 = new Students(firstName: "Semen", secondName: "Bulgakov", age: 19);
            var stud5 = new Students(firstName: "Alexandr", secondName: "Pushkin", age: 20);
            var stud6 = new Students(firstName: "Iosif", secondName: "Stalin", age: 22);

            var stud7 = new Students(firstName: "Adolf", secondName: "Gitler", age: 21);
            var stud8 = new Students(firstName: "Vasya", secondName: "Pupkin", age: 20);
            var stud9 = new Students(firstName: "Pavel", secondName: "Morozov", age: 22);

            var stud10 = new Students(firstName: "Anton", secondName: "Chehov", age: 22);
            var stud11 = new Students(firstName: "Winston", secondName: "Cherchel", age: 21);
            var stud12 = new Students(firstName: "Alexandr", secondName: "Makedonskiy", age: 22);

            var group1 = new Groups(stud1, "Group 1");
            group1.Add(stud2);
            group1.Add(stud3);

            var group2 = new Groups(stud4, "Group 2");
            group2.Add(stud5);
            group2.Add(stud6);

            var group3 = new Groups(stud7, "Group 3");
            group2.Add(stud8);
            group2.Add(stud9);

            var group4 = new Groups(stud10, "Group 4");
            group2.Add(stud10);
            group2.Add(stud10);

            var subject1 = new Subjects("Computer Systems and Networks", 150);
            var subject2 = new Subjects("Network Engineering", 170);

            var subject3 = new Subjects("Artificial Intelligence", 160);
            var subject4 = new Subjects("Computer Vision", 145);

            var specialty1 = new Specialties(group1, subject1, "Information Technology");
            specialty1.AddGroup(group2);
            specialty1.AddSubject(subject2);

            var specialty2 = new Specialties(group3, subject3, "Cybernetics");
            specialty1.AddGroup(group4);
            specialty1.AddSubject(subject4);

            Faculty.Specialty.Add(specialty1);
            Faculty.Specialty.Add(specialty2);
        }
    }
}
