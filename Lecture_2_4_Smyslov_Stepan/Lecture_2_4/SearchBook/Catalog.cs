using System.Collections.Generic;

namespace Lecture_2_4.SearchBook
{
    public class Catalog
    {
        private readonly List<Book> _bookList;

        public Catalog()
        {
            _bookList = new List<Book>();
        }

        public List<Book> Books { get { return _bookList; } }
        public List<Book> SearchString(SearchName search,string searchText)
        {
            var newList = new List<Book>();
            foreach (var book in _bookList)
            {
                if (search(searchText,book))
                    newList.Add(book);
            }
            return newList;
        }

        public List<Book> SearchYears(SearchYears years, int age)
        {
            var newList = new List<Book>();
            foreach (var book in _bookList)
            {
                if (years(age,book))
                    newList.Add(book);
            }
            return newList;
        }
    }
}
