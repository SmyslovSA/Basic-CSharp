using System;
using Lecture_1_9.PredictionClasses;

namespace Lecture_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var predictions = GetStartPrediction();
            while (true)
            {
                var userChoise = (Time)ConsoleHelper.Greetings().Key;
                while (!Enum.IsDefined(typeof(Time), userChoise))
                {
                    ConsoleHelper.WrongInfo();
                    userChoise = (Time)ConsoleHelper.Greetings().Key;
                }
                PrintPrediction(predictions[(int)(userChoise - Time.Today)]);
            }   
        }

        static Prediction[] GetStartPrediction()
        {
            var predictionToday = new Prediction("You will win the lottery",Time.Today);
            var predictionTomorrow = new Prediction("Your car will break",Time.Tomorrow);
            var predictionWeek = new Prediction("You will find a purse with money",Time.Week);
            var predictionMonth = new Prediction("You will find a new job",Time.Month);
            var predictionArray = new Prediction[] { predictionToday, predictionTomorrow, predictionWeek, predictionMonth };
            return predictionArray;
        }

        static void PrintPrediction(Prediction prediction)
        {
            Console.WriteLine(prediction);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
