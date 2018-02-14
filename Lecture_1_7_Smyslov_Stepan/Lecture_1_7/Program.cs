using System;
using Lecture_1_7.LibraryClasses;

namespace Lecture_1_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var newLibrary = new Library();
            var startAuthorArray = newLibrary.GetStartAuthors();
            var startBookArray = newLibrary.GetStartBooks(startAuthorArray);
            newLibrary.StartAddToLibrary(startAuthorArray, startBookArray, newLibrary);
            do
            {
                ConsoleHelper.BooksInLibrary(newLibrary);
                var number = ConsoleHelper.UserChoise().Key;
                switch (number)
                {
                    case ConsoleKey.D1:
                        var userInputAuthor = ConsoleHelper.AddAuthor();
                        newLibrary.AddToLibraryAuthor(newLibrary, userInputAuthor);
                        break;
                    case ConsoleKey.D2:
                        var userInputBook = ConsoleHelper.AddBook();
                        var bookOption = newLibrary.AddToLibraryBook(newLibrary, userInputBook);
                        ConsoleHelper.BookInputOption(bookOption, userInputBook[0]);
                        break;
                    case ConsoleKey.D3:
                        return;
                }
            } while (true);
        }
    }
}