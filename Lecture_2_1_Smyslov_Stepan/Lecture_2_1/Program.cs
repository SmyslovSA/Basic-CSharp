using System;
using Lecture_2_1.University;

namespace Lecture_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var univer = new Univer();
            univer.GetStartParameters();
            ConsoleInfo(univer);
        }

        static void ConsoleInfo(Univer university)
        {
            Console.WriteLine($"Number of lections: {university.CountLections()}");
            Console.WriteLine($"Number of people: {university.CountHuman()}");
            Console.WriteLine();
            foreach (var lect in university.GetLections())
            {
                Console.WriteLine($"Lection {lect.LectureName}:");
                foreach (var teacher in university.GetHumans())
                    if (teacher is Teacher && lect.LectureName == (teacher as Teacher).Specialization)
                        Console.WriteLine($"{(teacher as Teacher).Work()}");
                foreach (var student in university.GetHumans())
                    if (student is Student)
                        Console.WriteLine((student as Student).Learn(lect.LectureType));
                Console.WriteLine();
            }
        }
    }
}
