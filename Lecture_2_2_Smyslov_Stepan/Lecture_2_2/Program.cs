using Lecture_2_2.University;

namespace Lecture_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var testData = new TestView();
            var univer = new Univer();
            testData.GetStartData(univer);
            testData.PeopleInfo(univer);
        }
    }
}
