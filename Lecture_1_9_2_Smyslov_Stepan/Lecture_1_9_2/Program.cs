using System;
using Lecture_1_9_2.Marks;

namespace Lecture_1_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var group = new StudentGroup();
            var console = new ConsoleInfo();
            console.GetStartParameters(group);
            console.ConsoleInf(group);
        }       
    }
}