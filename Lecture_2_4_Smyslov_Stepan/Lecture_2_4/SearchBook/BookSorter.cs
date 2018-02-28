using System.Collections.Generic;

namespace Lecture_2_4.SearchBook
{
    public class BookSorter : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            // TODO NullReference? Так же вам бы тут хватило метода сравнения строк через CompareTo
            for (int i = 0; i < x.BookName.Length || i < y.BookName.Length; i++)
            {
                if (x.BookName[i] - y.BookName[i] > 0)
                    return 1;
                else if (x.BookName[i] - y.BookName[i] < 0)
                    return -1;
            }
            return 0;
        }
    }
}
