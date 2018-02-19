using System;
using Lecture_1_9_2.Marks;

namespace Lecture_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentGroup();
            GetStartParameters(group);
            ConsoleInfo(group);
        }

        static void GetStartParameters(StudentGroup group)
        {
            var student1 = new Student("Ivan", "Petrov", new DateTime(1988, 12, 02));
            var student2 = new Student("Sergei", "Ivanov", new DateTime(1985, 11, 15));
            var student3 = new Student("Iriva", "Sokolova", new DateTime(1987, 10, 13));

            student1.AddMark(new Mark("History", DateTime.Today, 5));
            student1.AddMark(new Mark("History", DateTime.Today, 8));
            student1.AddMark(new Mark("History", DateTime.Today, 2));
            student1.AddMark(new Mark("History", DateTime.Today, 9));
            student1.AddMark(new Mark("History", DateTime.Today, 1));

            student2.AddMark(new Mark("History", DateTime.Today, 5));
            student2.AddMark(new Mark("History", DateTime.Today, 9));
            student2.AddMark(new Mark("History", DateTime.Today, 0));
            student2.AddMark(new Mark("History", DateTime.Today, 2));
            student2.AddMark(new Mark("History", DateTime.Today, 6));

            student3.AddMark(new Mark("History", DateTime.Today, 7));
            student3.AddMark(new Mark("History", DateTime.Today, 1));
            student3.AddMark(new Mark("History", DateTime.Today, 4));
            student3.AddMark(new Mark("History", DateTime.Today, 6));
            student3.AddMark(new Mark("History", DateTime.Today, 4));

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
        }

        static void ConsoleInfo(StudentGroup group)
        {
            foreach (var stud in group.Group())
                Console.WriteLine(stud);
            Console.ReadLine();
        }
    }
}