using Lecture_2_4.SearchBook;

namespace Lecture_2_4
{
    class Program
    {

        static void Main(string[] args)
        {
            var catalog = new Catalog();
            var test = new TestView();
            test.GetStartData(catalog);
            test.UserOutput(test.UserChoise(), catalog);
        }
    }
}
