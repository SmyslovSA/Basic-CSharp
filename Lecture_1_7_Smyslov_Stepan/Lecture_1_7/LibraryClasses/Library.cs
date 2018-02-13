using System;
using System.Collections.Generic;

namespace Lecture_1_7.LibraryClasses
{
    class Library
    {
        public readonly List<Book> BookLibrary = new List<Book>();
        public readonly List<Author> AuthorLibrary = new List<Author>();

        // INIT, BUILD, GET, CREATE - вы тут ничего не устанавливаете. Не правильно выбрано название
        public Author[] SetStartAuthors()
        {
            var author1 = new Author {Name = "Герберт", LastName = "Шилдт", DoB = 1959};
            var author2 = new Author {Name = "Джеффри", LastName = "Рихтер", DoB = 1965};
            var author3 = new Author {Name = "Джордж", LastName = "Оруэлл", DoB = 1950};
            var author4 = new Author {Name = "Джон", LastName = "Толкин", DoB = 1914};
            Author[] authors = {author1, author2, author3, author4};
            return authors;
        }

        // TODO см. выше
        public Book[] SetStartBooks(Author[] author)
        {
            var book1 = new Book
            {
                Name = "С# 4.0. Полное руководство",
                Genre = Genre.Educational,
                AuthorName = author[0],
                IsInStock = true
            };
            var book2 = new Book
            {
                Name = "Программирование на платформе .NET Framework 4.5",
                Genre = Genre.Educational,
                AuthorName = author[1],
                IsInStock = true
            };
            var book3 = new Book {Name = "1984", Genre = Genre.Fiction, AuthorName = author[2], IsInStock = false};
            var book4 = new Book
            {
                Name = "Властелин колец",
                Genre = Genre.Fiction,
                AuthorName = author[3],
                IsInStock = false
            };
            Book[] books = {book1, book2, book3, book4};
            return books;
        }

        public void StartAddToLibrary(Author[] authors, Book[] books, Library library)
        {
            foreach (var aut in authors)
                library.AuthorLibrary.Add(aut);
            foreach (var book in books)
                library.BookLibrary.Add(book);
        }

        public void AddToLibraryAuthor(Library library, string[] userInput)
        {
            if (userInput.Length != 3) return;
            library.AuthorLibrary.Add(new Author
            {
                Name = userInput[0],
                LastName = userInput[1],
                DoB = uint.Parse(userInput[2])
            });
        }

        public bool AddToLibraryBook(Library library, string[] userInput)
        {
            Author bookAuthorName = null;
            foreach (var aut in library.AuthorLibrary)
                if (aut.LastName.ToUpper() == userInput[2])
                    bookAuthorName = aut;
            var isGenre = Enum.TryParse(userInput[1], out Genre genre);
            if (string.IsNullOrWhiteSpace(userInput[0]) || bookAuthorName == null ||
                !isGenre || (genre < Genre.Historical || genre > Genre.Fiction))
                return false;
            library.BookLibrary.Add(new Book
            {
                Name = userInput[0],
                Genre = genre,
                AuthorName = bookAuthorName,
                IsInStock = true
            });
            return true;
        }
    }
}