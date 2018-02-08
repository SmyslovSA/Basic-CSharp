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
            Console.WriteLine("Please choose option: PurchaseList(1) or ScheduleList(2)");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            ConsoleKey number = consoleKeyInfo.Key;
            Console.WriteLine();
            switch (number)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    #region option1
                    Dictionary<string, decimal> purchase = new Dictionary<string, decimal>();
                    while (true)
                    {
                        Console.WriteLine("Please choose option:\n" +
                          "1.Add product\n" +
                          "2.Remove product\n" +
                          "3.Product price\n" +
                          "4.Products more expensive than\n" +
                          "5.Exit");
                        consoleKeyInfo = Console.ReadKey();
                        number = consoleKeyInfo.Key;
                        Console.WriteLine();
                        switch (number)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.WriteLine("Set product name: ");
                                string productAdd = Console.ReadLine();
                                // TODO двойное ИЛИ для исключения ненужной проверки.
                                while (string.IsNullOrWhiteSpace(productAdd) | purchase.Keys.Contains(productAdd))
                                {
                                    Console.WriteLine("Wrong or duplicate name, set another name.");
                                    productAdd = Console.ReadLine();
                                }
                                decimal price;
                                do
                                {
                                    Console.WriteLine("Set product price: ");
                                    // TODO следует использовать псевдонимы
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
                                if (purchase.Keys.Contains(productRemove))
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
                                    // todo foreach(var pair ... <- чтобы было меньше текста.
                                    // todo если вы уже проврерили что есть продукт, замеч вам тут foreach??
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
                                // todo пользуемся псевдонимы
                                bool isParse = UInt32.TryParse(Console.ReadLine(), out uint expPrice);
                                // TODO if(!isParse) break <- уменьшаем вложенность.
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
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    #region option2
                    // Так как DayOfWeek является ключом для первого словаря, a первый string ключом для второго, то нельзя сделать больше одной записи на каждый день недели,
                    // а также нельзя сделать две записи в одно и то же время (ну или два одинаковых дела если поменять key и value местами).
                    // Это нормально для такого словаря или я чего-то не понял? =)
                    Dictionary<string, string> daySchedule = new Dictionary<string, string>();
                    Dictionary<DayOfWeek, Dictionary<string, string>> weekSchedule = new Dictionary<DayOfWeek, Dictionary<string, string>>();
                    while (true)
                    {
                        Console.WriteLine("Please choose option:\n" +
                                  "1.Add record\n" +
                                  "2.Remove record\n" +
                                  "3.Show schedule on day\n" +
                                  "4.Show schedule on week\n" +
                                  "5.Exit");
                        consoleKeyInfo = Console.ReadKey();
                        number = consoleKeyInfo.Key;
                        Console.WriteLine();
                        switch (number)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.WriteLine("Choose day:\n Monday-1\n Tuesday-2\n Wednesday-3\n Thursday-4\n Friday-5\n Saturday-6\n Sunday-0\n");
                                // TODO Foreach var dow in DayOfWeek write "{dow}-{(int)dow}"... Там проще =)
                                bool isParse = DayOfWeek.TryParse(Console.ReadLine(), out DayOfWeek userDayAdd);
                                // TODO MSDN тоже надо пользовать =) Enum.IsDefined(typeof(DayOfWeek), userDayAdd)
                                if ((!isParse) || (userDayAdd < DayOfWeek.Sunday || userDayAdd > DayOfWeek.Saturday))
                                {
                                    Console.WriteLine("Wrong entry");
                                    break;
                                }
                                Console.WriteLine("Set time of record:");
                                string recordTime = Console.ReadLine();
                                if (daySchedule.Keys.Contains(recordTime))
                                {
                                    Console.WriteLine("Duplicate times. Wrong Entry");
                                    break;
                                }
                                Console.WriteLine("Set name of record:");
                                string recordName = Console.ReadLine();
                                daySchedule.Add(recordTime, recordName);
                                // TODO а вот тут у вас ошибка серьёзная... в итоге все дни недели ссылаются на 1 словарь 
                                weekSchedule.Add(userDayAdd, daySchedule);
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                // TODO смотрим выже
                                Console.WriteLine("Choose day:\n Monday-1\n Tuesday-2\n Wednesday-3\n Thursday-4\n Friday-5\n Saturday-6\n Sunday-0\n");
                                isParse = DayOfWeek.TryParse(Console.ReadLine(), out DayOfWeek userDayRemove);
                                // TODO смотрим выже
                                if ((!isParse) || (userDayRemove < DayOfWeek.Sunday || userDayRemove > DayOfWeek.Saturday))
                                {
                                    Console.WriteLine("Wrong entry");
                                    break;
                                }
                                weekSchedule.Remove(userDayRemove);
                                Console.WriteLine($"Record for {userDayRemove} was removed");
                                break;
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                // TODO смотрим выже
                                Console.WriteLine("Choose day:\n Monday-1\n Tuesday-2\n Wednesday-3\n Thursday-4\n Friday-5\n Saturday-6\n Sunday-0\n");
                                isParse = DayOfWeek.TryParse(Console.ReadLine(), out DayOfWeek userDayShow);
                                // TODO смотрим выже
                                if ((!isParse) || (userDayShow < DayOfWeek.Sunday || userDayShow > DayOfWeek.Saturday))
                                {
                                    Console.WriteLine("Wrong entry");
                                    break;
                                }
                                if (weekSchedule.Keys.Contains(userDayShow))
                                    // TODO та же ошибка что и в случае корзины - если проверили наличие можно было обращаться через [ключ] 
                                    foreach (KeyValuePair<DayOfWeek, Dictionary<string, string>> day in weekSchedule)
                                    {
                                        if (userDayShow == day.Key)
                                            // Непонятно как обратиться к данным {day.Value}, оно возвращает тип данных самого словаря.
                                            // В debug видно, что пара ключ-значение в Value записана,но синтаксис обращения я так и не нашел =(
                                            Console.WriteLine($"Schedule on {day.Key} is ");
                                    }
                                else
                                    Console.WriteLine($"On {userDayShow} no records");
                                break;
                            case ConsoleKey.D4:
                            case ConsoleKey.NumPad4:
                                if (weekSchedule.Count == 0)
                                {
                                    Console.WriteLine("No records on week");
                                    break;
                                }
                                Console.WriteLine("Schedule on week:");
                                foreach (KeyValuePair<DayOfWeek, Dictionary<string, string>> day in weekSchedule)
                                    Console.WriteLine($"Schedule on {day.Key} is ");
                                    // TODO я так понимаю ты вы забыли сделать вывод day.valye?
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
}
