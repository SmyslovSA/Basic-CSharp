using System;
namespace Lecture_2_4.SearchBook
{
    public class Book : IComparable<Book>
    {
        public string BookName { get; set; }
        public string AuthorFullName { get; set; }
        public int YearOfWriting { get; set; }

        public Book(string bookName, string author, int year)
        {
            BookName = bookName;
            AuthorFullName = author;
            YearOfWriting = year;
        }

        public int CompareTo(Book other)
        {
            return this.BookName.CompareTo(other.BookName);
        }

        public override string ToString()
        {
            return $"{BookName} - {AuthorFullName},{YearOfWriting} year";
        }
    }
}
