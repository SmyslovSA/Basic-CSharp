using System;
using System.Threading;

namespace Lecture_1_9
{
    public static class ConsoleHelper
    {
        public static ConsoleKeyInfo Greetings()
        {
            Console.WriteLine("\tПредсказание будущего\n" +
                              "Выберите опцию:\n" +
                              "1.На сегодня\n" +
                              "2.На завтра\n" +
                              "3.Через неделю\n" +
                              "4.Через месяц\n");
            var consoleKeyInfo = Console.ReadKey();
            Console.WriteLine();
            return consoleKeyInfo;
        }

        public static void WrongInfo()
        {
            Console.WriteLine("Wrong choise");
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
