using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lecture_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose variant of running string (1 or 2):");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            ConsoleKey number = consoleKeyInfo.Key;
            switch (number)
            {
                case ConsoleKey.D1:
                    #region variant1
                    /* Заполняет массив от нуля до последнего индекса, после чего превращает массив в бегущую строку.
                       После окончания бегущей строки ждет её окончания в приложении и запускает цикл заново. */
                    Console.WriteLine();
                    char[] runningStringArray = new char[15];
                    string runningWords = $"Московское время {DateTime.Now}. Говорят и показывают все телестанции страны.";
                    for (; ; )
                    {
                        for (int i = 0; i < runningWords.Length; i++)
                        {
                            if (runningStringArray.Length - i <= 0)
                            {
                                for (int j = 0; j < runningStringArray.Length - 1; j++)
                                    runningStringArray[j] = runningStringArray[j + 1];
                                runningStringArray[runningStringArray.Length - 1] = runningWords[i];
                            }
                            else runningStringArray[i] = runningWords[i];
                            Console.Write(runningStringArray);
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                        for (int i = 1; i < runningStringArray.Length; i++)
                        {
                            for (int j = 1; j < runningStringArray.Length; j++)
                                runningStringArray[j - 1] = runningStringArray[j];
                            runningStringArray[runningStringArray.Length - i] = ' ';
                            Console.Write(runningStringArray);
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                    }
                    #endregion
                case ConsoleKey.D2:
                    #region variant2
                    // Запускает бегущую строку. После окончания сразу же её зацикливает.
                    Console.WriteLine();
                    char[] runningStringArray2 = new char[15];
                    string runningWords2 = $"Московское время {DateTime.Now}. Говорят и показывают все телестанции страны.";
                    for (; ; )
                    {
                        for (int i = 0; i < runningWords2.Length; i++)
                        {
                            {
                                for (int j = 0; j < runningStringArray2.Length - 1; j++)
                                    runningStringArray2[j] = runningStringArray2[j + 1];
                                runningStringArray2[runningStringArray2.Length - 1] = runningWords2[i];
                            }
                            Console.Write(runningStringArray2);
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                    }
                    #endregion
                default:
                    Console.WriteLine("You choose wrong variant");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
