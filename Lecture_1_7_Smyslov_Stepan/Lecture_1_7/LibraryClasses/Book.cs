namespace Lecture_1_7.LibraryClasses
{
    class Book
    {
        public string Name;
        public Genre Genre;
        public Author AuthorName;
        public bool IsInStock;

        public void SetBookAvailable()
        {
            IsInStock = true;
        }

        public void SetBookUnavailable()
        {
            IsInStock = false;
        }
    }
}