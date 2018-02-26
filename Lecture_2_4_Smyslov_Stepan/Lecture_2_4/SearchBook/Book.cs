namespace Lecture_2_4.SearchBook
{
    public class Book
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

        public override string ToString()
        {
            return $"{BookName} - {AuthorFullName},{YearOfWriting} year";
        }
    }
}
