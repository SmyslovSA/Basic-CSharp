using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region option1
            Dictionary<string, decimal> purchase = new Dictionary<string, decimal>();
            while(true)
            {
                Console.WriteLine("Please choose option:\n" +
                  "1.Add product\n" +
                  "2.Remove product\n" +
                  "3.Product price\n" +
                  "4.Products more expensive than\n" +
                  "5.Exit");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                ConsoleKey number = consoleKeyInfo.Key;
                Console.WriteLine();
                switch (number)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.WriteLine("Set product name: ");
                        string productAdd=Console.ReadLine().ToString();
                        while (string.IsNullOrWhiteSpace(productAdd) | purchase.Keys.Contains(productAdd))
                            { 
                                Console.WriteLine("Wrong or duplicate name, set another name.");
                                productAdd = Console.ReadLine();
                            }                       
                        decimal price;
                        do
                        {
                            Console.WriteLine("Set product price: ");
                            Decimal.TryParse(Console.ReadLine(), out price);
                            if (price <= 0)
                                Console.WriteLine("Wrong price, set another price.");
                        }
                        while (price <= 0);
                        purchase.Add(productAdd, price);
                        Console.WriteLine($"Product {productAdd} with price {price} added to purchases.");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        if (purchase.Count == 0)
                        {
                            Console.WriteLine("Purchase list is empty!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("What product do you want to remove? ");
                        string productRemove = Console.ReadLine();
                        if(purchase.Keys.Contains(productRemove))
                        { 
                            purchase.Remove(productRemove);
                            Console.WriteLine($"{productRemove} was removed from purchases");
                        }
                        else
                            Console.WriteLine($"{productRemove} is not found");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        if (purchase.Count == 0)
                        {
                            Console.WriteLine("Purchase list is empty!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Price of what product do you want to know? ");
                        string productChoose = Console.ReadLine();
                        if (purchase.Keys.Contains(productChoose))
                        {
                            foreach (KeyValuePair<string, decimal> t in purchase)
                            {
                                if (t.Key == productChoose)
                                    Console.WriteLine($"Price of {t.Key} is {t.Value}");
                            }
                        }
                        else
                            Console.WriteLine("Your product is not found");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine("Set price to see what products are more expensive:");
                        bool isParse = UInt32.TryParse(Console.ReadLine(), out uint expPrice);
                        if (isParse)
                        {
                            foreach (KeyValuePair<string, decimal> t in purchase)
                            {
                                if (t.Value > expPrice)
                                    Console.WriteLine($"{t.Key} is {t.Value}");
                            }
                        }
                        else Console.WriteLine("You set wrong price");
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        return;
                }
            }
            #endregion
        }
    }
}
