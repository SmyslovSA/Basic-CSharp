using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            Console.Write("Please set radius of sphere: ");
            string userString = Console.ReadLine();
            double radius;
            Double.TryParse(userString, out radius);
            if (radius > 0)
            {
                Console.WriteLine($"Square of sphere: {4 * pi * Math.Pow(radius, 2)}");
                Console.WriteLine($"Volume of sphere: {(4.00/3.00) * pi * Math.Pow(radius, 3)}");
            }
            else
                Console.WriteLine("You wrote invalid data");
            Console.ReadKey();
        }
    }
}
