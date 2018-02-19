using System;
using Lecture_2_1.University;

namespace Lecture_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var univer = new Univer();
            var console = new ConsoleInfo();
            console.GetStartParameters(univer);
            console.ConsoleInf(univer);
        }
    }
}
