using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author();
            Library newLibrary = new Library();
            Author author1 = new Author() { Name = "Герберт", LastName = "Шилдт", DoB = 1959};
            Author author2 = new Author() { Name = "Джеффри", LastName = "Рихтер", DoB = 1965};
            Author author3 = new Author() { Name = "Джордж", LastName = "Оруэлл", DoB = 1950};
            Author author4 = new Author() { Name = "Джон", LastName = "Толкин", DoB = 1914};
            Book book1 = new Book() { Name = "С# 4.0. Полное руководство", Genre = Genre.Educational, AuthorName = author1, IsInStock = true };
            Book book2 = new Book() { Name = "Программирование на платформе .NET Framework 4.5", Genre = Genre.Educational, AuthorName = author2, IsInStock = true };
            Book book3 = new Book() { Name = "1984", Genre = Genre.Fiction, AuthorName = author3, IsInStock = false };
            Book book4 = new Book() { Name = "Властелин колец", Genre = Genre.Fiction, AuthorName = author4, IsInStock = false };
            Book[] books = new Book[] {book1,book2,book3,book4};
            Author[] authors = new Author[] { author1, author2, author3, author4 };
            foreach (Author aut in authors)
                author.list.Add(aut);
            foreach (Book book in books)
                newLibrary.library.Add(book);
            book3.SetBookAvailable();
            book2.SetBookUnavailable();
            do
            {
                Console.Clear();
                Console.WriteLine($"В библиотеке {newLibrary.library.Count} книг:");
                foreach (var book in newLibrary.library)
                {
                    Console.Write($"{book.Name}, {book.Genre}, автор {book.AuthorName.Name} {book.AuthorName.LastName}");
                    if (book.IsInStock)
                        Console.WriteLine(".На складе - да");
                    else Console.WriteLine(".На складе - нет");
                }
                Console.WriteLine("Добавить автора - 1 \t\t Добавить книгу-2 \t\t Выход-3");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                ConsoleKey number = consoleKeyInfo.Key;
                Console.WriteLine();
                switch (number)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Введите имя");
                        string name = Console.ReadLine();
                        Console.WriteLine("Введите фамилию");
                        string lastName = Console.ReadLine();
                        Console.WriteLine("Введите год рождения автора");
                        uint.TryParse(Console.ReadLine(), out uint result);
                        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName) || result == 0)
                        {
                            Console.WriteLine("Некорректный ввод");
                            break;
                        }
                        author.list.Add(new Author() { Name = name, LastName = lastName, DoB = result });
                        Console.WriteLine($"Автор {name} {lastName} успешно добавлен");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("Введите название книги");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("Введите жанр");
                        Enum.TryParse(Console.ReadLine(), out Genre genre);
                        Console.WriteLine("Введите фамилию автора");
                        string authorName = Console.ReadLine().ToUpper();
                        Author bookAuthorName = null;
                        foreach (var aut in author.list)
                            if (aut.LastName.ToUpper() == authorName)
                                bookAuthorName = aut;
                        if (string.IsNullOrWhiteSpace(bookName) || bookAuthorName == null || (!Enum.IsDefined(typeof(Genre),genre)))
                        {
                            Console.WriteLine("Некорректный ввод");
                            break;
                        }
                        newLibrary.library.Add(new Book() { Name = bookName, Genre = genre, AuthorName = bookAuthorName, IsInStock = true });
                        Console.WriteLine($"Книга {bookName} успешно добавлена в библиотеку");
                        break;
                    case ConsoleKey.D3:
                        return;
                }
                Console.ReadLine();
            }
            while (true);
        }
    }
}
