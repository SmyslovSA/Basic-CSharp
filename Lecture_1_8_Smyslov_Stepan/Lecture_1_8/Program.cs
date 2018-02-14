using System;

namespace Lecture_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var newAlbum = new Album();
            newAlbum.SetTestAlbum(newAlbum);
            do
            {
                var number = ConsoleHelper.UserChoise().Key;
                switch (number)
                {
                    case ConsoleKey.D1:
                        // TODO В Обращении к типу Program нет необходимости
                        // Вы и так работаете в рамках этого класса
                        Play(newAlbum);
                        break;
                    case ConsoleKey.D2:
                        var choise1 = ConsoleHelper.UserChoiseList();
                        Program.Play(newAlbum, choise1);
                        break;
                    case ConsoleKey.D3:
                        var choise2 = ConsoleHelper.UserChoiseList2();
                        Program.Play(newAlbum, choise2[0], choise2[1]);
                        break;
                    case ConsoleKey.D4:
                        var choise3 = ConsoleHelper.UserAddSong();
                        var song = new Song(choise3[0], choise3[1]);
                        newAlbum.AddSong(song);
                        break;
                    case ConsoleKey.D5:
                        return;
                }
            } while (true);
        }

        static void Play(Album album)
        {
            Console.WriteLine("All songs:");
            Program.WriteTracklist(album, 0, 0);
        }

        // TODO Ошибка в логике - должно было проигрывать от i до конца
        static void Play(Album album, int index)
        {
            Console.WriteLine($"Songs from {index}:");
            Program.WriteTracklist(album, index, index);
        }

        static void Play(Album album, int index, int index2)
        {
            Console.WriteLine($"Songs from {index} to {index2}:");
            Program.WriteTracklist(album, index, index2);
        }

        static void WriteTracklist(Album album, int index, int index2)
        {
            while (album.IndexIsInRange(index))
            {
                Console.WriteLine($"{album[index].Name} {album[index].Artist}");
                index++;
                if (index == index2) return;
            }
        }
    }
}