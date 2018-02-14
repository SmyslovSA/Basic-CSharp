using System;

namespace Lecture_1_8
{
    public static class ConsoleHelper
    {
        public static ConsoleKeyInfo UserChoise()
        {
            Console.WriteLine(
                "Прослушать всё - 1 \nПрослушать с - 2 \nПрослушать с и до - 3 \nДобавить песню в альбом - 4 \nВыход - 5 ");
            var consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();
            return consoleKeyInfo;
        }

        public static int UserChoiseList()
        {
            Console.Write("С какой песни?");
            int.TryParse(Console.ReadLine(), out var choise);
            return choise;
        }

        public static void UserChoiseList2(out int choise1, out int choise2)
        {
            Console.Write("С какой и по какую песню?");
            int.TryParse(Console.ReadLine(), out choise1);
            int.TryParse(Console.ReadLine(), out choise2);
        }

        public static void UserAddSong(out string songName,out string songAuthor)
        {
            Console.WriteLine("Введите название песни:");
            songName = Console.ReadLine();
            Console.WriteLine("Введите автора песни:");
            songAuthor = Console.ReadLine();       
            Console.WriteLine($"Песня {songName} автора {songAuthor} успешно добавлена в альбом");
        }
    }
}