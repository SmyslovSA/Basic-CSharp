using System;
using Lecture_2_2.University;
using RandomNameGeneratorLibrary;

namespace Lecture_2_2
{
    public class TestView
    {
        public void PeopleInfo(Univer univer)
        {
            foreach (var man in univer.Students)
                Console.WriteLine(man.Work());
            foreach (var man in univer.Teachers)
                Console.WriteLine(man.Work());
            foreach (var man in univer.DepartmentHeads)
                Console.WriteLine(man.Work());
        }

        public void GetStartData(Univer univer)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var generator = new PersonNameGenerator();
            for (int i = 0; i < 10; i++)
            {
                univer.AddStudent(new Student(generator.GenerateRandomFirstName(), generator.GenerateRandomLastName(), (Facultates)random.Next(0, 4)));
                univer.AddTeacher(new Teacher(generator.GenerateRandomFirstName(), generator.GenerateRandomLastName(), (Facultates)random.Next(0, 4)));
                univer.AddDepartmentHead(new DepartmentHead(generator.GenerateRandomFirstName(), generator.GenerateRandomLastName(), (Facultates)random.Next(0, 4)));
            }
        }
    }
}
