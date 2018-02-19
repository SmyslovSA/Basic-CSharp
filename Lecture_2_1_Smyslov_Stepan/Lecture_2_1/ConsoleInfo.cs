using System;
using Lecture_2_1.University;

namespace Lecture_2_1
{
    public class ConsoleInfo
    {
        public void GetStartParameters(Univer university)
        {
            var math = new Lection("Mathemathic", LectionsTypes.Technical);
            var history = new Lection("History", LectionsTypes.Humanitarian);
            var chorus = new Lection("Chorus", LectionsTypes.Musical);
            university.AddLection(math);
            university.AddLection(history);
            university.AddLection(chorus);
            university.AddHuman(new StudentTech("Vasiliy", "Ivanov"));
            university.AddHuman(new StudentTech("Oleg", "Petrov"));
            university.AddHuman(new StudentHumanist("Olga", "Sokolova"));
            university.AddHuman(new StudentHumanist("Andrey", "Sidorov"));
            university.AddHuman(new Teacher("Viktor", "Petrovich", math));
            university.AddHuman(new Teacher("Irina", "Voronova", history));
            university.AddHuman(new Teacher("Tatyana", "Semenova", chorus));
        }

        public void ConsoleInf(Univer university)
        {
            Console.WriteLine($"Number of lections: {university.CountLections()}");
            Console.WriteLine($"Number of people: {university.CountHuman()}");
            Console.WriteLine();
            foreach (var lect in university.GetLections)
            {
                Console.WriteLine($"Lection {lect.LectureName}:");
                foreach (var teacher in university.GetHumans)
                    if (teacher is Teacher && lect.LectureName == (teacher as Teacher).Specialization)
                        Console.WriteLine($"{(teacher as Teacher).Work()}");
                foreach (var student in university.GetHumans)
                    if (student is Student)
                        Console.WriteLine((student as Student).Learn(lect.LectureType));
                Console.WriteLine();
            }
        }
    }
}
