using System;
namespace Lecture_1_7
{
    static class ConsoleHelper
    {
        static public void BooksInLibrary(Library library)
        {
            Console.Clear();
            Console.WriteLine($"В библиотеке {library.BookLibrary.Count} книг:");
            foreach (var book in library.BookLibrary)
            {
                Console.Write(
                    $"{book.Name}, {book.Genre}, автор {book.AuthorName.Name} {book.AuthorName.LastName}.На складе - ");
                Console.WriteLine(book.IsInStock ? "да" : "нет");
            }
        }
        static public ConsoleKeyInfo UserChoise()
        {
            Console.WriteLine("Добавить автора - 1 \t\t Добавить книгу-2 \t\t Выход-3");
            var consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();
            return consoleKeyInfo;
        }
        static public string[] AddAuthor()
        {
            Console.WriteLine("Введите имя");
            var name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            var lastName = Console.ReadLine();
            Console.WriteLine("Введите год рождения автора");
            uint.TryParse(Console.ReadLine(), out var result);
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || result == 0)
            {
                Console.WriteLine("Некорректный ввод");
                Console.ReadLine();
                string[] incorrectInput = new string[0];
                return incorrectInput;
            }
            else
                Console.WriteLine($"Автор {name} {lastName} успешно добавлен");
            string[] correctInput = new string[] {name, lastName, result.ToString()};
            Console.ReadLine();
            return correctInput;
        }
        static public string[] AddBook()
        {
            Console.WriteLine("Введите название книги");
            var bookName = Console.ReadLine();
            Console.WriteLine("Введите жанр");
            var genre = Console.ReadLine();
            Console.WriteLine("Введите фамилию автора");
            var authorName = Console.ReadLine().ToUpper();
            var userInput = new string[] {bookName, genre, authorName };
            return userInput;
        }
        static public void BookInputOption(bool isInput,string bookName)
        {
            Console.WriteLine(isInput ? $"Книга {bookName} успешно добавлена в библиотеку" : "Некорректный ввод");
            Console.ReadLine();
        }
    }
}
