using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please set number from 1 to 150: ");
            Int32.TryParse(Console.ReadLine(), out int userNumber);
            if (userNumber <= 0 || userNumber > 150)
            {
                Console.Write("Wrong number");
                Console.ReadLine();
                return;
            }
            Console.Write($"Simple numbers from 1 to {userNumber} is:");
            for (int i = 2; i <= userNumber; i++)
            {
                bool isSimple=true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }
                if (isSimple)
                    Console.Write($" {i}");
            }
            Console.ReadLine();
        }
    }
}
