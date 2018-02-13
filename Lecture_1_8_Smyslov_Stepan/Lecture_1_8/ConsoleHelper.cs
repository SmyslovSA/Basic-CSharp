using System;

namespace Lecture_1_8
{
    // TODO Поменяли местами =) public static и дт
    static public class ConsoleHelper
    {
        static public ConsoleKeyInfo UserChoise()
        {
            Console.WriteLine(
                "Прослушать всё - 1 \nПрослушать с - 2 \nПрослушать с и до - 3 \nДобавить песню в альбом - 4 \nВыход - 5 ");
            var consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();
            return consoleKeyInfo;
        }

        static public int UserChoiseList()
        {
            Console.Write("С какой песни?");
            int.TryParse(Console.ReadLine(), out var choise);
            return choise;
        }

        // TODO Можно было не создавать массивов
        static public int[] UserChoiseList2()
        {
            Console.Write("С какой и по какую песню?");
            int.TryParse(Console.ReadLine(), out var choise1);
            int.TryParse(Console.ReadLine(), out var choise2);
            var choise = new int[] {choise1, choise2};
            return choise;
        }
        // TODO как то так =)
        public static void UserChoiseList2V2(out int choise1, out int choise2)
        {
            Console.Write("С какой и по какую песню?");
            int.TryParse(Console.ReadLine(), out choise1);
            int.TryParse(Console.ReadLine(), out choise2);
        }

        static public string[] UserAddSong()
        {
            Console.WriteLine("Введите название песни:");
            var songName = Console.ReadLine();
            Console.WriteLine("Введите автора песни:");
            var songAuthor = Console.ReadLine();
            var userSong = new string[] {songName, songAuthor};
            Console.WriteLine($"Песня {songName} автора {songAuthor} успешно добавлена в альбом");
            return userSong;
        }
    }
}