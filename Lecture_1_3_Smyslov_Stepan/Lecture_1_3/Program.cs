using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTwo = 2;
            int numberThree = 3;
            int numberFive = 5;
            int numberEight = 8;
            int numberThirteen = 13;
            int numberTwentyOne = 21;
            int numberThirtyFour = 34;
            int numberFiftyFive = 55;

            Console.WriteLine($"Using numbers: {numberOne}, {numberTwo}, {numberThree}, {numberFive}, {numberEight}, {numberThirteen}, {numberTwentyOne}, {numberThirtyFour}, {numberFiftyFive}.");
            Console.WriteLine($"{((numberOne & 1) == 1 ? string.Empty : " 1 is even" )}{((numberTwo & 1) == 1 ? string.Empty: " 2 is even")}" +
                          $"{((numberThree & 1) == 1 ? string.Empty : " 3 is even")}{((numberFive & 1) == 1 ? string.Empty : " 5 is even")}" +
                          $"{((numberEight & 1) == 1 ? string.Empty : " 8 is even")}{((numberThirteen & 1) == 1 ? string.Empty : " 13 is even")}" +
                          $"{((numberTwentyOne & 1) == 1 ? string.Empty : " 21 is even")}{((numberThirtyFour & 1) == 1 ? string.Empty : " 34 is even")}" +
                          $"{((numberFiftyFive & 1) == 1 ? string.Empty : " 55 is even")}.");

            Console.WriteLine($"The first five digits: {numberOne << 1}, {numberTwo << 2}, {numberThree << 3}, {numberFive << 4}, {numberEight << 5}.");
            Console.ReadLine();

        }
    }
}
