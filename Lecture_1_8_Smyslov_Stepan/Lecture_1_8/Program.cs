using System;
using Lecture_1_8.AlbumClasses;

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
                        Play(newAlbum);
                        break;
                    case ConsoleKey.D2:
                        var choise1 = ConsoleHelper.UserChoiseList();
                        Play(newAlbum, choise1);
                        break;
                    case ConsoleKey.D3:
                        ConsoleHelper.UserChoiseList2(out int choose2,out int choose3);
                        Play(newAlbum, choose2, choose3);
                        break;
                    case ConsoleKey.D4:
                        ConsoleHelper.UserAddSong(out string songName, out string songAuthor);
                        var song = new Song(songName,songAuthor);
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
            WriteTracklist(album, 0, 0);
        }

        static void Play(Album album, int index)
        {
            Console.WriteLine($"Songs from {index}:");
            WriteTracklist(album, index, index);
        }

        static void Play(Album album, int index, int index2)
        {
            Console.WriteLine($"Songs from {index} to {index2}:");
            WriteTracklist(album, index, index2);
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