using System.Collections.Generic;

namespace Lecture_2_4.SearchBook
{
    public static class BookSorting
    {
        public static void Sorting(List<Book> list)
        {
            list.Sort(new BookSorter());
        }
    }
}
