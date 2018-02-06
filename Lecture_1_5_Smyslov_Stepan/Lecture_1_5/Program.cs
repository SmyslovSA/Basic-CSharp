using System;
using System.Threading;

namespace Lecture_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose variant of running string (1 or 2): ");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            ConsoleKey number = consoleKeyInfo.Key;
            char[] runningStringArray = new char[15];
            string runningWords = $"Московское время {DateTime.Now}. Говорят и показывают все телестанции страны.";
            switch (number)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    #region variant1
                    /* Заполняет массив от нуля до последнего индекса, после чего превращает массив в бегущую строку.
                       После окончания бегущей строки ждет её окончания в приложении и запускает цикл заново. */
                    Console.WriteLine();
                    while (true)
                    {
                        // DONE перемудрили. Слишком много массивов и циклов =) Но да, оно работает
                        int j = 0;
                        for (int i = 1; i < runningWords.Length+runningStringArray.Length; i++)
                        {
                            if (i >= runningStringArray.Length && i < runningWords.Length)
                            {
                                Console.Write(runningWords.Substring(j, runningStringArray.Length));
                                j++;
                            }
                            else if (i >= runningWords.Length)
                            {
                                Console.Write(runningWords.Substring(j));
                                j++;
                            }
                            else
                                Console.Write(runningWords.Substring(j, i)); 
                            Thread.Sleep(500);
                            Console.Clear();                           
                        }
                    }
                #endregion
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    #region variant2
                    // Запускает бегущую строку. После окончания сразу же её зацикливает.
                    Console.WriteLine();
                    while (true)
                    {
                        foreach (char letter in runningWords)
                        {
                            {
                                for (int j = 0; j < runningStringArray.Length - 1; j++)
                                    runningStringArray[j] = runningStringArray[j + 1];
                                runningStringArray[runningStringArray.Length - 1] = letter;
                            }
                            Console.Write(runningStringArray);
                            Thread.Sleep(500);
                            Console.Clear();
                        }
                    }
                    #endregion
                default:
                    Console.WriteLine();
                    Console.WriteLine("You choose wrong variant");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
