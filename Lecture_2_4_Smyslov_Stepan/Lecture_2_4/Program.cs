namespace Lecture_2_4.SearchBook
// TODO Не правильный namespace
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
