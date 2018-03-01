using System;
using System.Collections.Generic;
using RandomNameGeneratorLibrary;
using Lecture_2_4.SearchBook;

namespace Lecture_2_4
{
    public delegate bool SearchName(string message, Book book);
    public delegate bool SearchYears(int year, Book book);
    public class TestView
    {
        public ConsoleKeyInfo UserChoise()
        {
            Console.WriteLine(
                "Вывести книги с определенного года - 1 \n" +
                "Вывести книги после определенного года - 2 \n" +
                "Вывести книги определенного автора - 3 \n" +
                "Вывести определенные книги - 4 \n" +
                "Вывести книги в названии которых есть: - 5 ");
            var consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();
            return consoleKeyInfo;
        }

        public void UserOutput(ConsoleKeyInfo consoleKeyInfo,Catalog catalog)
        {
            var books = new List<Book>();
            var userInput = Console.ReadLine();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    // TODO Это вам на подумать - что чёрт возьми тут произошло =)
                    bool Years(int year, Book newBook) => newBook.YearOfWriting >= year;
                    books = catalog.SearchYears(Years,  Int32.Parse(userInput));
                    break;
                case ConsoleKey.D2:
                    books = catalog.SearchYears((year, newbook) => newbook.YearOfWriting < year, Int32.Parse(userInput));
                    break;
                case ConsoleKey.D3:
                    SearchName search1 = (search, newBook) => newBook.AuthorFullName.ToUpper() == search.ToUpper();
                    books = catalog.SearchString(search1, userInput);
                    break;
                case ConsoleKey.D4:
                    SearchName search2 = (search, newBook) => newBook.BookName.ToUpper() == search.ToUpper();
                    books = catalog.SearchString(search2, userInput);
                    break;
                case ConsoleKey.D5:
                    SearchName search3 = (search, newBook) => newBook.BookName.ToUpper().Contains(search.ToUpper());
                    books = catalog.SearchString(search3, userInput);
                    break;
            }
            BookSorting.Sorting(books);
            foreach (var book in books)
                Console.WriteLine(book);
            Console.ReadLine();
        }

        public void GetStartData(Catalog catalog)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var generator = new PersonNameGenerator();
            for (int i = 0; i < 10; i++)
                catalog.Books.Add(new Book(generator.GenerateRandomFirstName(), generator.GenerateRandomLastName(), (random.Next(0, 2018))));
        }
    }
}
