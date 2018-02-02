using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please set summ of a credit: ");
            Decimal.TryParse(Console.ReadLine(), out decimal creditSumm);
            Console.Write("Please set credit rate:");
            Double.TryParse(Console.ReadLine(), out double creditRate);
            int numberOfMonth = 12;
            string checkSumm = ((creditSumm > 0) && (creditRate > 0)) ? "Your monthly payments is:" : "Wrong number.Your summ set to default";
            double monthRatio = creditRate / numberOfMonth / 100;
            double ratio = ((monthRatio) * (Math.Pow(1 + monthRatio, numberOfMonth))) / (Math.Pow((1 + monthRatio), numberOfMonth) - 1);
            decimal monthlyPaymentsAnnuity = (decimal)ratio * creditSumm;
            Console.WriteLine($"Annuity system: {checkSumm}  {monthlyPaymentsAnnuity:#.00}");
            Console.WriteLine($"Interest for month: {(monthlyPaymentsAnnuity - creditSumm / numberOfMonth):#.00}");
            Console.WriteLine($"Total payment: {(monthlyPaymentsAnnuity * numberOfMonth):#.00}");
            Console.WriteLine($"Interest for year: {(monthlyPaymentsAnnuity * numberOfMonth - creditSumm):#.00}");
            Console.ReadLine();
        }
    }
}
